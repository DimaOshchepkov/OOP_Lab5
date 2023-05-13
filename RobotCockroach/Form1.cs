using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotCockroach
{
    enum direction : byte { Up, Right, Down, Left };
    
    public partial class MainForm : Form
    {
        Random random = new Random();
        int AlgStep = 0;
        List<Cockroach> workCockroachs;//рабочий Таракан - активный Таракан, который будет выполнять алгоритм
        List<PictureBox> workpbs;//рабочее поле PictureBox - поле на котрой будет рабочий Таракан
        List<Cockroach> LC;//Список для хранения созданных Тараканов
        List<PictureBox> PB;//Список для хранения созданных объектов PictureBox

        public MainForm()
        {
            LC = new List<Cockroach>();
            PB = new List<PictureBox>();

            workCockroachs = new List<Cockroach>();
            workpbs = new List<PictureBox>();

            InitializeComponent();
        }

        private void NebBtn_Click(object sender, EventArgs e)
        {
            Cockroach cockroach = new Cockroach(new Bitmap(@"D:\Лабораторки\ООП\OOP_Lab5\RobotCockroach\cockroach1.png"));//
            PictureBox p = new PictureBox();
            foreach (var workpb in workpbs)
                workpb.BorderStyle = BorderStyle.None;
            p.BorderStyle = BorderStyle.FixedSingle;

            p.MouseMove += new MouseEventHandler(IMouseMove);
            p.MouseDown += new MouseEventHandler(IMouseDown);
            PB.Add(p);
            LC.Add(cockroach);
            workCockroachs.Add(cockroach);
            workpbs.Add(p);

            Show(cockroach, Field, p);

        }

        //Изображение объекта Таракан в PictureBox используется при изменении направления Таракана
        private void RePaint(Cockroach cockroach, PictureBox p)
        {
            p.Bounds = new Rectangle(cockroach.X, cockroach.Y, cockroach.Image.Width, cockroach.Image.Height);//создание новых границ изображения для PictureBox
            p.Image = cockroach.Image;
        }

        private void Show(Cockroach cockroach, Panel owner, PictureBox p)
        {

            cockroach.X = (owner.Width - cockroach.Image.Width) / 2 +
                    random.Next(-(owner.Width - cockroach.Image.Width)/2, (owner.Width - cockroach.Image.Width) / 2);
            cockroach.Y = (owner.Height - cockroach.Image.Height) / 2 +
                    random.Next(-(owner.Width - cockroach.Image.Width) / 2, (owner.Width - cockroach.Image.Width) / 2);
            RePaint(cockroach, p);
            owner.Controls.Add(p);// добавляем PictureBox к элементу Panel

        }

        private void IMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int k = PB.IndexOf(sender as PictureBox);//запоминаем номер нажатого компонента PictureBox
                if (Control.ModifierKeys != Keys.Control)
                {
                    foreach (var workpb in workpbs)
                        workpb.BorderStyle = BorderStyle.None;

                    workCockroachs.Clear();
                    workpbs.Clear();
                }
                var p = sender as PictureBox;
                p.BorderStyle = BorderStyle.FixedSingle;

                if (!workpbs.Exists(x => x == p))
                {
                    workpbs.Add(p);//объявляет его рабочим
                    workCockroachs.Add(LC[k]);//по найденному номеру находим Таракана в списке
                }
            }
        }
        private void IMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picture = sender as PictureBox;
                picture.Tag = new Point(e.X, e.Y);//запоминаем координаты мыши на момент начала перетаскивания
                picture.DoDragDrop(sender, DragDropEffects.Move);//начинаем перетаскивание ЧЕГО и с КАКИМ ЭФФЕКТОМ
            }
        }

        private void Field_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }

        }

        private void Field_DragDrop(object sender, DragEventArgs e)
        {
            //извлекаем PictureBox
            PictureBox picture = (PictureBox)e.Data.GetData(typeof(PictureBox));
            int k = workpbs.FindIndex(x => x == picture);
            Panel panel = sender as Panel;
            
            //извлекаем клиентские координаты мыши в момент начала перетскивания
            Point pointDrag = (Point)picture.Tag;
            //получаем клиентские координаты в момент отпускания кнопки
            Point pointDrop = panel.PointToClient(new Point(e.X, e.Y));
            
            //вычисляем и устанавливаем Location для PictureBox в Panel

            picture.Location = new Point(pointDrop.X - pointDrag.X, pointDrop.Y - pointDrag.Y);
            //устанавливаем координаты для X и Y для рабочего таракана
            
            workCockroachs[k].X = picture.Location.X;
            workCockroachs[k].Y = picture.Location.Y;
            picture.Parent = panel;

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AlgStep == Algorithm.Items.Count) //конец алгоритма
            {
                AlgStep = 0;
                timer1.Stop();
            }
            else//выполнение команды из списка
            {
                foreach (var (workCockroach, workpb) in workCockroachs.Zip(workpbs, Tuple.Create))
                {
                    string s = (string)Algorithm.Items[AlgStep];
                    Algorithm.SetSelected(AlgStep, true);
                    if (s == "Step")
                        workCockroach.Step(20);
                    else
                        workCockroach.ChangeTrend(s[0]);
                    RePaint(workCockroach, workpb);
                    
                }
                AlgStep++;
            }

        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NebBtn_Click(sender, e);
        }

        private void StepBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void ToolStripMenuItemFindSkin_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var (cockroach, p) in workCockroachs.Zip(workpbs, Tuple.Create))
                    {
                        cockroach.Image = new Bitmap(openFileDialog.FileName);
                        RePaint(cockroach, p);
                    }

                }
            }
        }

        private void ButtonDeleteHero_Click(object sender, EventArgs e)
        {
            while (workpbs.Count != 0)
            {
                int k = PB.IndexOf(workpbs[0] as PictureBox);
                workCockroachs.RemoveAt(0);
                workpbs[0].Dispose();
                workpbs.RemoveAt(0);
                LC.RemoveAt(k);
                PB[k].Dispose();
                PB.RemoveAt(k);
            }
        }
    }
}
