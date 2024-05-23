namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Afisare_Produs
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
            this.btnAdauga_Produs = new System.Windows.Forms.Button();
            this.btnModifica_Produs = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dgvAfisareProduse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisareProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(75, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(217, 25);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Administrare produse";
            // 
            // btnAdauga_Produs
            // 
            this.btnAdauga_Produs.BackColor = System.Drawing.Color.Purple;
            this.btnAdauga_Produs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga_Produs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdauga_Produs.Location = new System.Drawing.Point(45, 75);
            this.btnAdauga_Produs.Name = "btnAdauga_Produs";
            this.btnAdauga_Produs.Size = new System.Drawing.Size(200, 54);
            this.btnAdauga_Produs.TabIndex = 1;
            this.btnAdauga_Produs.Text = "Adaugă produs";
            this.btnAdauga_Produs.UseVisualStyleBackColor = false;
            this.btnAdauga_Produs.Click += new System.EventHandler(this.btnAdauga_Produs_Click);
            // 
            // btnModifica_Produs
            // 
            this.btnModifica_Produs.BackColor = System.Drawing.Color.Purple;
            this.btnModifica_Produs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifica_Produs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifica_Produs.Location = new System.Drawing.Point(45, 150);
            this.btnModifica_Produs.Name = "btnModifica_Produs";
            this.btnModifica_Produs.Size = new System.Drawing.Size(200, 54);
            this.btnModifica_Produs.TabIndex = 2;
            this.btnModifica_Produs.Text = "Modifică produs";
            this.btnModifica_Produs.UseVisualStyleBackColor = false;
            this.btnModifica_Produs.Click += new System.EventHandler(this.btnModifica_Produs_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.Purple;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCauta.Location = new System.Drawing.Point(45, 300);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(200, 54);
            this.btnCauta.TabIndex = 3;
            this.btnCauta.Text = "Caută produs";
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
            this.btnSterge.Location = new System.Drawing.Point(45, 375);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(200, 54);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Șterge produs";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
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
            // dgvAfisareProduse
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAfisareProduse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAfisareProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAfisareProduse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAfisareProduse.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfisareProduse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAfisareProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfisareProduse.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAfisareProduse.Location = new System.Drawing.Point(281, 75);
            this.dgvAfisareProduse.Name = "dgvAfisareProduse";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfisareProduse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAfisareProduse.RowHeadersWidth = 51;
            this.dgvAfisareProduse.RowTemplate.Height = 24;
            this.dgvAfisareProduse.Size = new System.Drawing.Size(1054, 380);
            this.dgvAfisareProduse.TabIndex = 8;
            // 
            // Forma_Afisare_Produs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.dgvAfisareProduse);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnModifica_Produs);
            this.Controls.Add(this.btnAdauga_Produs);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Afisare_Produs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrare produs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisareProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnAdauga_Produs;
        private System.Windows.Forms.Button btnModifica_Produs;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dgvAfisareProduse;
    }
}