namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Afisare_Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnAdauga_Client = new System.Windows.Forms.Button();
            this.btnModifica_Client = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnCumpara = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dgvAfisareClienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisareClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(75, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(195, 25);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Administrare clienți";
            // 
            // btnAdauga_Client
            // 
            this.btnAdauga_Client.BackColor = System.Drawing.Color.Purple;
            this.btnAdauga_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga_Client.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdauga_Client.Location = new System.Drawing.Point(45, 75);
            this.btnAdauga_Client.Name = "btnAdauga_Client";
            this.btnAdauga_Client.Size = new System.Drawing.Size(200, 54);
            this.btnAdauga_Client.TabIndex = 1;
            this.btnAdauga_Client.Text = "Adaugă client";
            this.btnAdauga_Client.UseVisualStyleBackColor = false;
            this.btnAdauga_Client.Click += new System.EventHandler(this.btnAdauga_Client_Click);
            // 
            // btnModifica_Client
            // 
            this.btnModifica_Client.BackColor = System.Drawing.Color.Purple;
            this.btnModifica_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifica_Client.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifica_Client.Location = new System.Drawing.Point(45, 150);
            this.btnModifica_Client.Name = "btnModifica_Client";
            this.btnModifica_Client.Size = new System.Drawing.Size(200, 54);
            this.btnModifica_Client.TabIndex = 2;
            this.btnModifica_Client.Text = "Modifică client";
            this.btnModifica_Client.UseVisualStyleBackColor = false;
            this.btnModifica_Client.Click += new System.EventHandler(this.btnModifica_Client_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.Purple;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCauta.Location = new System.Drawing.Point(45, 375);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(200, 54);
            this.btnCauta.TabIndex = 3;
            this.btnCauta.Text = "Caută client";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.Purple;
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizare.Location = new System.Drawing.Point(45, 225);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(200, 54);
            this.btnActualizare.TabIndex = 4;
            this.btnActualizare.Text = "Actualizează lista";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.Purple;
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSterge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSterge.Location = new System.Drawing.Point(45, 450);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(200, 54);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Șterge client";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnCumpara
            // 
            this.btnCumpara.BackColor = System.Drawing.Color.Purple;
            this.btnCumpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCumpara.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCumpara.Location = new System.Drawing.Point(45, 300);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(200, 54);
            this.btnCumpara.TabIndex = 6;
            this.btnCumpara.Text = "Cumpără produs";
            this.btnCumpara.UseVisualStyleBackColor = false;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Purple;
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInapoi.Location = new System.Drawing.Point(1259, 487);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(111, 54);
            this.btnInapoi.TabIndex = 7;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // dgvAfisareClienti
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAfisareClienti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAfisareClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAfisareClienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAfisareClienti.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfisareClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAfisareClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfisareClienti.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAfisareClienti.Location = new System.Drawing.Point(281, 75);
            this.dgvAfisareClienti.Name = "dgvAfisareClienti";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfisareClienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAfisareClienti.RowHeadersWidth = 51;
            this.dgvAfisareClienti.RowTemplate.Height = 24;
            this.dgvAfisareClienti.Size = new System.Drawing.Size(1056, 378);
            this.dgvAfisareClienti.TabIndex = 8;
            // 
            // Forma_Afisare_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.dgvAfisareClienti);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnCumpara);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnModifica_Client);
            this.Controls.Add(this.btnAdauga_Client);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Afisare_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrare client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisareClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnAdauga_Client;
        private System.Windows.Forms.Button btnModifica_Client;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnCumpara;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dgvAfisareClienti;
    }
}