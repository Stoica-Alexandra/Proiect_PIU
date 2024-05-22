namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Sigur
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
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNu = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDa
            // 
            this.btnDa.BackColor = System.Drawing.Color.Purple;
            this.btnDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDa.Location = new System.Drawing.Point(50, 129);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(150, 50);
            this.btnDa.TabIndex = 0;
            this.btnDa.Text = "Da";
            this.btnDa.UseVisualStyleBackColor = false;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNu
            // 
            this.btnNu.BackColor = System.Drawing.Color.Purple;
            this.btnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNu.Location = new System.Drawing.Point(236, 129);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(150, 50);
            this.btnNu.TabIndex = 1;
            this.btnNu.Text = "Nu";
            this.btnNu.UseVisualStyleBackColor = false;
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(141, 60);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(151, 25);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Vrei să ștergi?";
            // 
            // Forma_Sigur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 236);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnDa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Sigur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ștergere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button btnNu;
        private System.Windows.Forms.Label lblTitlu;
    }
}