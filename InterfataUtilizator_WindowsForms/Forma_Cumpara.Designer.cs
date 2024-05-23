namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Cumpara
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
            this.btnCumpara = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.lstProdus = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCumpara
            // 
            this.btnCumpara.BackColor = System.Drawing.Color.Purple;
            this.btnCumpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCumpara.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCumpara.Location = new System.Drawing.Point(212, 364);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(200, 54);
            this.btnCumpara.TabIndex = 3;
            this.btnCumpara.Text = "Cumpără";
            this.btnCumpara.UseVisualStyleBackColor = false;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(230, 25);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(176, 25);
            this.lblTitlu.TabIndex = 12;
            this.lblTitlu.Text = "Cumpărare client";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.Location = new System.Drawing.Point(84, 83);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(96, 22);
            this.lblTip.TabIndex = 13;
            this.lblTip.Text = "Tip produs";
            // 
            // cbxTip
            // 
            this.cbxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Items.AddRange(new object[] {
            "Alimentar ",
            "Electronic ",
            "Vestimentar ",
            "Casnic ",
            "Sport ",
            "Carte ",
            "Jucarie ",
            "Sanatate ",
            "Mobila ",
            "Gradinarit ",
            "Cosmetic ",
            "Nedefinit"});
            this.cbxTip.Location = new System.Drawing.Point(288, 75);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(250, 30);
            this.cbxTip.TabIndex = 15;
            this.cbxTip.SelectedIndexChanged += new System.EventHandler(this.cbxTip_SelectedIndexChanged);
            // 
            // lstProdus
            // 
            this.lstProdus.FormattingEnabled = true;
            this.lstProdus.ItemHeight = 16;
            this.lstProdus.Location = new System.Drawing.Point(88, 153);
            this.lstProdus.Name = "lstProdus";
            this.lstProdus.Size = new System.Drawing.Size(450, 196);
            this.lstProdus.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(84, 116);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 22);
            this.lblInfo.TabIndex = 17;
            // 
            // Forma_Cumpara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstProdus);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnCumpara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Cumpara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cumpără";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCumpara;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.ListBox lstProdus;
        private System.Windows.Forms.Label lblInfo;
    }
}
