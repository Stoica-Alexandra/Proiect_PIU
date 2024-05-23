namespace InterfataUtilizator_WindowsForms
{
    partial class Forma_Cauta_Produs
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
            this.btnTip = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.dgvCauta = new System.Windows.Forms.DataGridView();
            this.btnCautareNume = new System.Windows.Forms.Button();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnPretInterval = new System.Windows.Forms.Button();
            this.txtPret1 = new System.Windows.Forms.TextBox();
            this.lblPret1 = new System.Windows.Forms.Label();
            this.txtPret2 = new System.Windows.Forms.TextBox();
            this.lblPret2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(75, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(173, 25);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Căutare produse";
            // 
            // btnTip
            // 
            this.btnTip.BackColor = System.Drawing.Color.Purple;
            this.btnTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTip.Location = new System.Drawing.Point(507, 140);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(361, 54);
            this.btnTip.TabIndex = 5;
            this.btnTip.Text = "După tip";
            this.btnTip.UseVisualStyleBackColor = false;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
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
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNume.Location = new System.Drawing.Point(207, 86);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(250, 35);
            this.txtNume.TabIndex = 5;
            // 
            // dgvCauta
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCauta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCauta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCauta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dgvCauta.Location = new System.Drawing.Point(118, 266);
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
            this.btnCautareNume.Location = new System.Drawing.Point(118, 140);
            this.btnCautareNume.Name = "btnCautareNume";
            this.btnCautareNume.Size = new System.Drawing.Size(339, 54);
            this.btnCautareNume.TabIndex = 16;
            this.btnCautareNume.Text = "După nume";
            this.btnCautareNume.UseVisualStyleBackColor = false;
            this.btnCautareNume.Click += new System.EventHandler(this.btnCautareNume_Click);
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
            this.cbxTip.Location = new System.Drawing.Point(618, 91);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(250, 30);
            this.cbxTip.TabIndex = 17;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.Location = new System.Drawing.Point(503, 99);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(96, 22);
            this.lblTip.TabIndex = 18;
            this.lblTip.Text = "Tip produs";
            // 
            // btnPretInterval
            // 
            this.btnPretInterval.BackColor = System.Drawing.Color.Purple;
            this.btnPretInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretInterval.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretInterval.Location = new System.Drawing.Point(931, 196);
            this.btnPretInterval.Name = "btnPretInterval";
            this.btnPretInterval.Size = new System.Drawing.Size(339, 54);
            this.btnPretInterval.TabIndex = 21;
            this.btnPretInterval.Text = "După interval de preț";
            this.btnPretInterval.UseVisualStyleBackColor = false;
            this.btnPretInterval.Click += new System.EventHandler(this.btnPretInterval_Click);
            // 
            // txtPret1
            // 
            this.txtPret1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPret1.Location = new System.Drawing.Point(1020, 86);
            this.txtPret1.Multiline = true;
            this.txtPret1.Name = "txtPret1";
            this.txtPret1.Size = new System.Drawing.Size(250, 35);
            this.txtPret1.TabIndex = 19;
            // 
            // lblPret1
            // 
            this.lblPret1.AutoSize = true;
            this.lblPret1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPret1.Location = new System.Drawing.Point(927, 94);
            this.lblPret1.Name = "lblPret1";
            this.lblPret1.Size = new System.Drawing.Size(58, 22);
            this.lblPret1.TabIndex = 20;
            this.lblPret1.Text = "Preț 1";
            // 
            // txtPret2
            // 
            this.txtPret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPret2.Location = new System.Drawing.Point(1020, 140);
            this.txtPret2.Multiline = true;
            this.txtPret2.Name = "txtPret2";
            this.txtPret2.Size = new System.Drawing.Size(250, 35);
            this.txtPret2.TabIndex = 22;
            // 
            // lblPret2
            // 
            this.lblPret2.AutoSize = true;
            this.lblPret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPret2.Location = new System.Drawing.Point(927, 148);
            this.lblPret2.Name = "lblPret2";
            this.lblPret2.Size = new System.Drawing.Size(58, 22);
            this.lblPret2.TabIndex = 23;
            this.lblPret2.Text = "Preț 2";
            // 
            // Forma_Cauta_Produs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.txtPret2);
            this.Controls.Add(this.lblPret2);
            this.Controls.Add(this.btnPretInterval);
            this.Controls.Add(this.txtPret1);
            this.Controls.Add(this.lblPret1);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.btnCautareNume);
            this.Controls.Add(this.dgvCauta);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnTip);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Forma_Cauta_Produs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Căutare produs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.DataGridView dgvCauta;
        private System.Windows.Forms.Button btnCautareNume;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnPretInterval;
        private System.Windows.Forms.TextBox txtPret1;
        private System.Windows.Forms.Label lblPret1;
        private System.Windows.Forms.TextBox txtPret2;
        private System.Windows.Forms.Label lblPret2;
    }
}