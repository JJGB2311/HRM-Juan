namespace CapaVistaHRM
{
    partial class Mantenimeitosoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimeitosoli));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo3 = new CapaVista.Combo();
            this.combo2 = new CapaVista.Combo();
            this.combo1 = new CapaVista.Combo();
            this.txt_canti = new System.Windows.Forms.TextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.txt_deta = new System.Windows.Forms.TextBox();
            this.DTP_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_generar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.LblUsuario,
            this.ProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 599);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(924, 22);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel.Text = "Usuario";
            // 
            // LblUsuario
            // 
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(13, 17);
            this.LblUsuario.Text = "..";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 185);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(0, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(928, 82);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(1, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 61);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(828, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(327, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(287, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "Generar Solicitud";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 225);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solicitudes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo3);
            this.groupBox1.Controls.Add(this.combo2);
            this.groupBox1.Controls.Add(this.combo1);
            this.groupBox1.Controls.Add(this.txt_canti);
            this.groupBox1.Controls.Add(this.txt_motivo);
            this.groupBox1.Controls.Add(this.txt_deta);
            this.groupBox1.Controls.Add(this.DTP_fecha);
            this.groupBox1.Controls.Add(this.txt_no);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 271);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion ";
            // 
            // combo3
            // 
            this.combo3.Enabled = false;
            this.combo3.Location = new System.Drawing.Point(112, 137);
            this.combo3.Margin = new System.Windows.Forms.Padding(5);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(214, 31);
            this.combo3.TabIndex = 31;
            // 
            // combo2
            // 
            this.combo2.Enabled = false;
            this.combo2.Location = new System.Drawing.Point(112, 98);
            this.combo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(214, 30);
            this.combo2.TabIndex = 30;
            // 
            // combo1
            // 
            this.combo1.Enabled = false;
            this.combo1.Location = new System.Drawing.Point(112, 64);
            this.combo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(214, 30);
            this.combo1.TabIndex = 29;
            // 
            // txt_canti
            // 
            this.txt_canti.Enabled = false;
            this.txt_canti.Location = new System.Drawing.Point(112, 174);
            this.txt_canti.Name = "txt_canti";
            this.txt_canti.Size = new System.Drawing.Size(214, 27);
            this.txt_canti.TabIndex = 13;
            // 
            // txt_motivo
            // 
            this.txt_motivo.Enabled = false;
            this.txt_motivo.Location = new System.Drawing.Point(350, 163);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(363, 88);
            this.txt_motivo.TabIndex = 11;
            // 
            // txt_deta
            // 
            this.txt_deta.Enabled = false;
            this.txt_deta.Location = new System.Drawing.Point(350, 52);
            this.txt_deta.Multiline = true;
            this.txt_deta.Name = "txt_deta";
            this.txt_deta.Size = new System.Drawing.Size(363, 75);
            this.txt_deta.TabIndex = 10;
            // 
            // DTP_fecha
            // 
            this.DTP_fecha.Enabled = false;
            this.DTP_fecha.Location = new System.Drawing.Point(112, 211);
            this.DTP_fecha.Name = "DTP_fecha";
            this.DTP_fecha.Size = new System.Drawing.Size(214, 27);
            this.DTP_fecha.TabIndex = 9;
            // 
            // txt_no
            // 
            this.txt_no.Enabled = false;
            this.txt_no.Location = new System.Drawing.Point(112, 34);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(214, 27);
            this.txt_no.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perfil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fehca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalles";
            // 
            // BTN_generar
            // 
            this.BTN_generar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_generar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_generar.BackgroundImage")));
            this.BTN_generar.Enabled = false;
            this.BTN_generar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_generar.Location = new System.Drawing.Point(764, 165);
            this.BTN_generar.Name = "BTN_generar";
            this.BTN_generar.Size = new System.Drawing.Size(149, 63);
            this.BTN_generar.TabIndex = 20;
            this.BTN_generar.Text = "Generar";
            this.BTN_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_generar.UseVisualStyleBackColor = false;
            this.BTN_generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.BackgroundImage")));
            this.Btn_borrar.Enabled = false;
            this.Btn_borrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_borrar.Location = new System.Drawing.Point(763, 234);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(149, 63);
            this.Btn_borrar.TabIndex = 21;
            this.Btn_borrar.Text = "Borrar ";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_nuevo.BackgroundImage")));
            this.Btn_nuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_nuevo.Location = new System.Drawing.Point(763, 96);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(149, 63);
            this.Btn_nuevo.TabIndex = 23;
            this.Btn_nuevo.Text = "Nuevo ";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_cancelar.BackgroundImage")));
            this.BTN_cancelar.Enabled = false;
            this.BTN_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_cancelar.Location = new System.Drawing.Point(763, 300);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(149, 62);
            this.BTN_cancelar.TabIndex = 22;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_cancelar.UseVisualStyleBackColor = false;
            this.BTN_cancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mantenimeitosoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(924, 621);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.BTN_generar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Mantenimeitosoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimeitosoli";
            this.Load += new System.EventHandler(this.Mantenimeitosoli_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private CapaVista.Combo combo3;
        private CapaVista.Combo combo2;
        private CapaVista.Combo combo1;
        private System.Windows.Forms.TextBox txt_canti;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.TextBox txt_deta;
        private System.Windows.Forms.DateTimePicker DTP_fecha;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_generar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button BTN_cancelar;
    }
}