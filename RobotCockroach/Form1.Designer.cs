
namespace RobotCockroach
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Field = new System.Windows.Forms.Panel();
            this.Group = new System.Windows.Forms.Panel();
            this.Algorithm = new System.Windows.Forms.ListBox();
            this.UpBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.StepBtn = new System.Windows.Forms.Button();
            this.NebBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.AllowDrop = true;
            this.Field.Location = new System.Drawing.Point(0, 0);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(498, 450);
            this.Field.TabIndex = 0;
            this.Field.DragDrop += new System.Windows.Forms.DragEventHandler(this.Field_DragDrop);
            this.Field.DragEnter += new System.Windows.Forms.DragEventHandler(this.Field_DragEnter);
            // 
            // Group
            // 
            this.Group.Controls.Add(this.UpBtn);
            this.Group.Controls.Add(this.RightBtn);
            this.Group.Controls.Add(this.DownBtn);
            this.Group.Controls.Add(this.LeftBtn);
            this.Group.Controls.Add(this.StepBtn);
            this.Group.Controls.Add(this.NebBtn);
            this.Group.Controls.Add(this.RunBtn);
            this.Group.Controls.Add(this.ClearBtn);
            this.Group.Location = new System.Drawing.Point(504, 0);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(143, 450);
            this.Group.TabIndex = 1;
            // 
            // Algorithm
            // 
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Location = new System.Drawing.Point(653, 12);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(135, 420);
            this.Algorithm.TabIndex = 0;
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(36, 12);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 2;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(36, 43);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(75, 23);
            this.RightBtn.TabIndex = 3;
            this.RightBtn.Text = "Right";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(36, 72);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 4;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(36, 101);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(75, 23);
            this.LeftBtn.TabIndex = 5;
            this.LeftBtn.Text = "Left";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // StepBtn
            // 
            this.StepBtn.Location = new System.Drawing.Point(36, 130);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(75, 23);
            this.StepBtn.TabIndex = 6;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.StepBtn_Click);
            // 
            // NebBtn
            // 
            this.NebBtn.Location = new System.Drawing.Point(36, 356);
            this.NebBtn.Name = "NebBtn";
            this.NebBtn.Size = new System.Drawing.Size(75, 23);
            this.NebBtn.TabIndex = 7;
            this.NebBtn.Text = "New Hero";
            this.NebBtn.UseVisualStyleBackColor = true;
            this.NebBtn.Click += new System.EventHandler(this.NebBtn_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(36, 385);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(75, 23);
            this.RunBtn.TabIndex = 8;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(36, 414);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Field);
            this.Name = "MainForm";
            this.Text = "Робот-таракан";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Panel Group;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button StepBtn;
        private System.Windows.Forms.Button NebBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ListBox Algorithm;
        private System.Windows.Forms.Timer timer1;
    }
}

