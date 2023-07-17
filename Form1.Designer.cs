namespace BAD_task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartBtn = new Button();
            Reset = new Button();
            TextBox = new RichTextBox();
            ResultLbl = new Label();
            TaskLbl = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.YellowGreen;
            StartBtn.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            StartBtn.Location = new Point(130, 487);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(114, 50);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // Reset
            // 
            Reset.BackColor = Color.IndianRed;
            Reset.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            Reset.ForeColor = SystemColors.ButtonFace;
            Reset.Location = new Point(370, 487);
            Reset.Name = "Reset";
            Reset.Size = new Size(114, 50);
            Reset.TabIndex = 1;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(41, 88);
            TextBox.Name = "TextBox";
            TextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            TextBox.Size = new Size(830, 350);
            TextBox.TabIndex = 3;
            TextBox.Text = "";
            // 
            // ResultLbl
            // 
            ResultLbl.AutoSize = true;
            ResultLbl.BorderStyle = BorderStyle.Fixed3D;
            ResultLbl.Font = new Font("Segoe UI Black", 16.3018875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ResultLbl.Location = new Point(639, 39);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(2, 37);
            ResultLbl.TabIndex = 4;
            ResultLbl.Visible = false;
            // 
            // TaskLbl
            // 
            TaskLbl.AutoSize = true;
            TaskLbl.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            TaskLbl.Location = new Point(60, 41);
            TaskLbl.Name = "TaskLbl";
            TaskLbl.Size = new Size(166, 30);
            TaskLbl.TabIndex = 5;
            TaskLbl.Text = "Enter your text:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(545, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 6;
            label1.Text = "Result:";
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(919, 618);
            Controls.Add(label1);
            Controls.Add(TaskLbl);
            Controls.Add(ResultLbl);
            Controls.Add(TextBox);
            Controls.Add(Reset);
            Controls.Add(StartBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAD tak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBtn;
        private Button Reset;
        private RichTextBox TextBox;
        private Label ResultLbl;
        private Label TaskLbl;
        private Label label1;
    }
}