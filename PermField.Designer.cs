namespace Lab1
{
    partial class PermField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Field_DGW = new System.Windows.Forms.DataGridView();
            this.SetIndex_Btn = new System.Windows.Forms.Button();
            this.SetIndex_TB = new System.Windows.Forms.TextBox();
            this.SetIndex_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Field_DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // Field_DGW
            // 
            this.Field_DGW.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Field_DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Field_DGW.ColumnHeadersVisible = false;
            this.Field_DGW.Location = new System.Drawing.Point(90, 120);
            this.Field_DGW.Name = "Field_DGW";
            this.Field_DGW.ReadOnly = true;
            this.Field_DGW.RowHeadersVisible = false;
            this.Field_DGW.RowHeadersWidth = 51;
            this.Field_DGW.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Field_DGW.RowTemplate.Height = 29;
            this.Field_DGW.Size = new System.Drawing.Size(403, 403);
            this.Field_DGW.TabIndex = 0;
            this.Field_DGW.Visible = false;
            this.Field_DGW.SelectionChanged += new System.EventHandler(this.Field_DGW_SelectionChanged);
            // 
            // SetIndex_Btn
            // 
            this.SetIndex_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetIndex_Btn.Location = new System.Drawing.Point(422, 62);
            this.SetIndex_Btn.Name = "SetIndex_Btn";
            this.SetIndex_Btn.Size = new System.Drawing.Size(50, 30);
            this.SetIndex_Btn.TabIndex = 9;
            this.SetIndex_Btn.Text = "Set";
            this.SetIndex_Btn.UseVisualStyleBackColor = true;
            this.SetIndex_Btn.Click += new System.EventHandler(this.SetIndex_Btn_Click);
            // 
            // SetIndex_TB
            // 
            this.SetIndex_TB.Location = new System.Drawing.Point(291, 64);
            this.SetIndex_TB.Name = "SetIndex_TB";
            this.SetIndex_TB.Size = new System.Drawing.Size(125, 27);
            this.SetIndex_TB.TabIndex = 8;
            this.SetIndex_TB.TextChanged += new System.EventHandler(this.SetSize_TB_TextChanged);
            // 
            // SetIndex_Lbl
            // 
            this.SetIndex_Lbl.AutoSize = true;
            this.SetIndex_Lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetIndex_Lbl.Location = new System.Drawing.Point(99, 65);
            this.SetIndex_Lbl.Name = "SetIndex_Lbl";
            this.SetIndex_Lbl.Size = new System.Drawing.Size(186, 23);
            this.SetIndex_Lbl.TabIndex = 7;
            this.SetIndex_Lbl.Text = "Номер перестановки: ";
            // 
            // PermField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.SetIndex_Btn);
            this.Controls.Add(this.SetIndex_TB);
            this.Controls.Add(this.SetIndex_Lbl);
            this.Controls.Add(this.Field_DGW);
            this.Name = "PermField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermField";
            ((System.ComponentModel.ISupportInitialize)(this.Field_DGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Field_DGW;
        private Button SetIndex_Btn;
        private TextBox SetIndex_TB;
        private Label SetIndex_Lbl;
    }
}