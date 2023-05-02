namespace Lab1
{
    partial class Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.SetSize_Btn = new System.Windows.Forms.Button();
            this.SetSize_TB = new System.Windows.Forms.TextBox();
            this.SetSize_Lbl = new System.Windows.Forms.Label();
            this.ShowPerm_Btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuItem1.Text = "О программе";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem2.Text = "Задания";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem3.Text = "Выход";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(18, 82);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(808, 168);
            this.Info.TabIndex = 2;
            this.Info.Text = resources.GetString("Info.Text");
            this.Info.Visible = false;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(293, 42);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(303, 24);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "Кол-во перестановок: 0000000000";
            this.Answer.Visible = false;
            // 
            // SetSize_Btn
            // 
            this.SetSize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetSize_Btn.Location = new System.Drawing.Point(237, 39);
            this.SetSize_Btn.Name = "SetSize_Btn";
            this.SetSize_Btn.Size = new System.Drawing.Size(50, 30);
            this.SetSize_Btn.TabIndex = 6;
            this.SetSize_Btn.Text = "Set";
            this.SetSize_Btn.UseVisualStyleBackColor = true;
            this.SetSize_Btn.Visible = false;
            this.SetSize_Btn.Click += new System.EventHandler(this.SetSize_Btn_Click);
            // 
            // SetSize_TB
            // 
            this.SetSize_TB.Location = new System.Drawing.Point(102, 38);
            this.SetSize_TB.Name = "SetSize_TB";
            this.SetSize_TB.Size = new System.Drawing.Size(125, 32);
            this.SetSize_TB.TabIndex = 5;
            this.SetSize_TB.Visible = false;
            this.SetSize_TB.TextChanged += new System.EventHandler(this.SetSize_TB_TextChanged);
            // 
            // SetSize_Lbl
            // 
            this.SetSize_Lbl.AutoSize = true;
            this.SetSize_Lbl.Location = new System.Drawing.Point(18, 42);
            this.SetSize_Lbl.Name = "SetSize_Lbl";
            this.SetSize_Lbl.Size = new System.Drawing.Size(78, 24);
            this.SetSize_Lbl.TabIndex = 4;
            this.SetSize_Lbl.Text = "Размер:";
            this.SetSize_Lbl.Visible = false;
            // 
            // ShowPerm_Btn
            // 
            this.ShowPerm_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowPerm_Btn.Location = new System.Drawing.Point(633, 40);
            this.ShowPerm_Btn.Name = "ShowPerm_Btn";
            this.ShowPerm_Btn.Size = new System.Drawing.Size(237, 29);
            this.ShowPerm_Btn.TabIndex = 8;
            this.ShowPerm_Btn.Text = "Показать перестановки";
            this.ShowPerm_Btn.UseVisualStyleBackColor = true;
            this.ShowPerm_Btn.Visible = false;
            this.ShowPerm_Btn.Click += new System.EventHandler(this.ShowPerm_Btn_Click);
            // 
            // Lab1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 303);
            this.Controls.Add(this.ShowPerm_Btn);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.SetSize_Btn);
            this.Controls.Add(this.SetSize_TB);
            this.Controls.Add(this.SetSize_Lbl);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Л/р 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label Info;
        private Label Answer;
        private Button SetSize_Btn;
        private TextBox SetSize_TB;
        private Label SetSize_Lbl;
        private Button ShowPerm_Btn;
    }
}