namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Main
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProdus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Purple;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClient.Location = new System.Drawing.Point(146, 164);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(150, 95);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProdus
            // 
            this.btnProdus.BackColor = System.Drawing.Color.Purple;
            this.btnProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProdus.Location = new System.Drawing.Point(330, 164);
            this.btnProdus.Name = "btnProdus";
            this.btnProdus.Size = new System.Drawing.Size(150, 95);
            this.btnProdus.TabIndex = 1;
            this.btnProdus.Text = "Produs";
            this.btnProdus.UseVisualStyleBackColor = false;
            this.btnProdus.Click += new System.EventHandler(this.btnProdus_Click);
            // 
            // Forma_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnProdus);
            this.Controls.Add(this.btnClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnProdus;
    }
}
