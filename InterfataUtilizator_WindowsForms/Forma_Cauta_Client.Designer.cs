namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Cauta_Client
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
            this.btnNume = new System.Windows.Forms.Button();
            this.btnNrTelefon = new System.Windows.Forms.Button();
            this.btnCNP = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNrTelefon = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.dgvCauta = new System.Windows.Forms.DataGridView();
            this.btnCautareNume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(75, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(151, 25);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Căutare clienți";
            // 
            // btnNume
            // 
            this.btnNume.BackColor = System.Drawing.Color.Purple;
            this.btnNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNume.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNume.Location = new System.Drawing.Point(114, 186);
            this.btnNume.Name = "btnNume";
            this.btnNume.Size = new System.Drawing.Size(343, 54);
            this.btnNume.TabIndex = 3;
            this.btnNume.Text = "După nume și prenume";
            this.btnNume.UseVisualStyleBackColor = false;
            this.btnNume.Click += new System.EventHandler(this.btnNume_Click);
            // 
            // btnNrTelefon
            // 
            this.btnNrTelefon.BackColor = System.Drawing.Color.Purple;
            this.btnNrTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNrTelefon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNrTelefon.Location = new System.Drawing.Point(862, 186);
            this.btnNrTelefon.Name = "btnNrTelefon";
            this.btnNrTelefon.Size = new System.Drawing.Size(409, 54);
            this.btnNrTelefon.TabIndex = 5;
            this.btnNrTelefon.Text = "După număr de telefon";
            this.btnNrTelefon.UseVisualStyleBackColor = false;
            this.btnNrTelefon.Click += new System.EventHandler(this.btnNrTelefon_Click);
            // 
            // btnCNP
            // 
            this.btnCNP.BackColor = System.Drawing.Color.Purple;
            this.btnCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCNP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCNP.Location = new System.Drawing.Point(505, 186);
            this.btnCNP.Name = "btnCNP";
            this.btnCNP.Size = new System.Drawing.Size(323, 54);
            this.btnCNP.TabIndex = 6;
            this.btnCNP.Text = "După CNP";
            this.btnCNP.UseVisualStyleBackColor = false;
            this.btnCNP.Click += new System.EventHandler(this.btnCNP_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Purple;
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInapoi.Location = new System.Drawing.Point(1259, 479);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(111, 54);
            this.btnInapoi.TabIndex = 7;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(114, 99);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(57, 22);
            this.lblNume.TabIndex = 8;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrenume.Location = new System.Drawing.Point(114, 152);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(82, 22);
            this.lblPrenume.TabIndex = 9;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCNP.Location = new System.Drawing.Point(501, 152);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(48, 22);
            this.lblCNP.TabIndex = 10;
            this.lblCNP.Text = "CNP";
            // 
            // lblNrTelefon
            // 
            this.lblNrTelefon.AutoSize = true;
            this.lblNrTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrTelefon.Location = new System.Drawing.Point(858, 99);
            this.lblNrTelefon.Name = "lblNrTelefon";
            this.lblNrTelefon.Size = new System.Drawing.Size(147, 22);
            this.lblNrTelefon.TabIndex = 11;
            this.lblNrTelefon.Text = "Număr de telefon";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNume.Location = new System.Drawing.Point(207, 86);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(250, 35);
            this.txtNume.TabIndex = 5;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrenume.Location = new System.Drawing.Point(207, 139);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(250, 35);
            this.txtPrenume.TabIndex = 12;
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCNP.Location = new System.Drawing.Point(578, 139);
            this.txtCNP.Multiline = true;
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(250, 35);
            this.txtCNP.TabIndex = 13;
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNrTelefon.Location = new System.Drawing.Point(1020, 86);
            this.txtNrTelefon.Multiline = true;
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(250, 35);
            this.txtNrTelefon.TabIndex = 14;
            // 
            // dgvCauta
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCauta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCauta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCauta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCauta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCauta.Location = new System.Drawing.Point(118, 263);
            this.dgvCauta.Name = "dgvCauta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCauta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCauta.RowHeadersWidth = 51;
            this.dgvCauta.RowTemplate.Height = 24;
            this.dgvCauta.Size = new System.Drawing.Size(1152, 207);
            this.dgvCauta.TabIndex = 15;
            // 
            // btnCautareNume
            // 
            this.btnCautareNume.BackColor = System.Drawing.Color.Purple;
            this.btnCautareNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCautareNume.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCautareNume.Location = new System.Drawing.Point(505, 74);
            this.btnCautareNume.Name = "btnCautareNume";
            this.btnCautareNume.Size = new System.Drawing.Size(323, 54);
            this.btnCautareNume.TabIndex = 16;
            this.btnCautareNume.Text = "După nume";
            this.btnCautareNume.UseVisualStyleBackColor = false;
            this.btnCautareNume.Click += new System.EventHandler(this.btnCautareNume_Click);
            // 
            // Forma_Cauta_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 545);
            this.Controls.Add(this.btnCautareNume);
            this.Controls.Add(this.dgvCauta);
            this.Controls.Add(this.txtNrTelefon);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNrTelefon);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnCNP);
            this.Controls.Add(this.btnNrTelefon);
            this.Controls.Add(this.btnNume);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Cauta_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adăugare Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnNume;
        private System.Windows.Forms.Button btnNrTelefon;
        private System.Windows.Forms.Button btnCNP;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblNrTelefon;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.DataGridView dgvCauta;
        private System.Windows.Forms.Button btnCautareNume;
    }
}