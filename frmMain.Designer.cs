namespace WFA241010DolgozatBusaiDániel
{
    partial class frmMain
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
            lblFirst = new Label();
            lblSecond = new Label();
            lblThird = new Label();
            lblFourth = new Label();
            lblFifth = new Label();
            tbxFirst = new TextBox();
            tbxSecond = new TextBox();
            tbxThird = new TextBox();
            tbxFourth = new TextBox();
            tbxFifth = new TextBox();
            btnGen = new Button();
            btnCheck = new Button();
            rtbInstructior = new RichTextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblFirst.Location = new Point(12, 16);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(124, 37);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "xx + yy =";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSecond.Location = new Point(12, 46);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(117, 37);
            lblSecond.TabIndex = 0;
            lblSecond.Text = "xx - yy =";
            // 
            // lblThird
            // 
            lblThird.AutoSize = true;
            lblThird.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblThird.Location = new Point(12, 83);
            lblThird.Name = "lblThird";
            lblThird.Size = new Size(124, 37);
            lblThird.TabIndex = 0;
            lblThird.Text = "xx + yy =";
            // 
            // lblFourth
            // 
            lblFourth.AutoSize = true;
            lblFourth.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblFourth.Location = new Point(12, 120);
            lblFourth.Name = "lblFourth";
            lblFourth.Size = new Size(117, 37);
            lblFourth.TabIndex = 0;
            lblFourth.Text = "xx - yy =";
            // 
            // lblFifth
            // 
            lblFifth.AutoSize = true;
            lblFifth.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblFifth.Location = new Point(12, 157);
            lblFifth.Name = "lblFifth";
            lblFifth.Size = new Size(124, 37);
            lblFifth.TabIndex = 0;
            lblFifth.Text = "xx + yy =";
            // 
            // tbxFirst
            // 
            tbxFirst.Enabled = false;
            tbxFirst.Location = new Point(142, 23);
            tbxFirst.Name = "tbxFirst";
            tbxFirst.Size = new Size(100, 23);
            tbxFirst.TabIndex = 1;
            // 
            // tbxSecond
            // 
            tbxSecond.Enabled = false;
            tbxSecond.Location = new Point(142, 53);
            tbxSecond.Name = "tbxSecond";
            tbxSecond.Size = new Size(100, 23);
            tbxSecond.TabIndex = 1;
            // 
            // tbxThird
            // 
            tbxThird.Enabled = false;
            tbxThird.Location = new Point(142, 90);
            tbxThird.Name = "tbxThird";
            tbxThird.Size = new Size(100, 23);
            tbxThird.TabIndex = 1;
            // 
            // tbxFourth
            // 
            tbxFourth.Enabled = false;
            tbxFourth.Location = new Point(142, 127);
            tbxFourth.Name = "tbxFourth";
            tbxFourth.Size = new Size(100, 23);
            tbxFourth.TabIndex = 1;
            // 
            // tbxFifth
            // 
            tbxFifth.Enabled = false;
            tbxFifth.Location = new Point(142, 164);
            tbxFifth.Name = "tbxFifth";
            tbxFifth.Size = new Size(100, 23);
            tbxFifth.TabIndex = 1;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(248, 23);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(122, 23);
            btnGen.TabIndex = 2;
            btnGen.Text = "Új feladatok";
            btnGen.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Enabled = false;
            btnCheck.Location = new Point(248, 53);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(122, 23);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Ellenőrzés";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // rtbInstructior
            // 
            rtbInstructior.Enabled = false;
            rtbInstructior.Location = new Point(248, 83);
            rtbInstructior.Name = "rtbInstructior";
            rtbInstructior.Size = new Size(122, 77);
            rtbInstructior.TabIndex = 3;
            rtbInstructior.Text = "Kezdéshez nyomd meg az \"Új feladatok\" gombot!";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(248, 164);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Bezárás";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 211);
            Controls.Add(rtbInstructior);
            Controls.Add(btnClose);
            Controls.Add(btnCheck);
            Controls.Add(btnGen);
            Controls.Add(tbxFifth);
            Controls.Add(tbxFourth);
            Controls.Add(tbxThird);
            Controls.Add(tbxSecond);
            Controls.Add(tbxFirst);
            Controls.Add(lblFourth);
            Controls.Add(lblFifth);
            Controls.Add(lblThird);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private Label lblSecond;
        private Label lblThird;
        private Label lblFourth;
        private Label lblFifth;
        private TextBox tbxFirst;
        private TextBox tbxSecond;
        private TextBox tbxThird;
        private TextBox tbxFourth;
        private TextBox tbxFifth;
        private Button btnGen;
        private Button btnCheck;
        private RichTextBox rtbInstructior;
        private Button btnClose;
    }
}
