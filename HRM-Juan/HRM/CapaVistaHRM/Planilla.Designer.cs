namespace CapaVistaHRM
{
    partial class Planilla
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
            this.Btn_detalle = new System.Windows.Forms.Button();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTP_fechaf = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_fechai = new System.Windows.Forms.DateTimePicker();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_detalle
            // 
            this.Btn_detalle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_detalle.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Btn_detalle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_detalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_detalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_detalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_detalle.Location = new System.Drawing.Point(513, 155);
            this.Btn_detalle.Name = "Btn_detalle";
            this.Btn_detalle.Size = new System.Drawing.Size(266, 98);
            this.Btn_detalle.TabIndex = 5;
            this.Btn_detalle.Text = "Detalle planilla";
            this.Btn_detalle.UseVisualStyleBackColor = false;
            this.Btn_detalle.Click += new System.EventHandler(this.Btn_detalle_Click);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Insertar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Btn_Insertar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Insertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Insertar.Location = new System.Drawing.Point(586, 123);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(204, 68);
            this.Btn_Insertar.TabIndex = 0;
            this.Btn_Insertar.Text = "Generar";
            this.Btn_Insertar.UseVisualStyleBackColor = false;
            this.Btn_Insertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_generar
            // 
            this.Btn_generar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_generar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Btn_generar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_generar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_generar.Location = new System.Drawing.Point(513, 43);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(266, 90);
            this.Btn_generar.TabIndex = 1;
            this.Btn_generar.Text = "Generar detalle planilla";
            this.Btn_generar.UseVisualStyleBackColor = false;
            this.Btn_generar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTP_fechaf);
            this.groupBox2.Controls.Add(this.Btn_Insertar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.DTP_fechai);
            this.groupBox2.Controls.Add(this.Txt_nombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 205);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // DTP_fechaf
            // 
            this.DTP_fechaf.Location = new System.Drawing.Point(121, 124);
            this.DTP_fechaf.Name = "DTP_fechaf";
            this.DTP_fechaf.Size = new System.Drawing.Size(435, 27);
            this.DTP_fechaf.TabIndex = 10;
            this.DTP_fechaf.Value = new System.DateTime(2020, 4, 13, 0, 0, 0, 0);
            this.DTP_fechaf.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha fin";
            // 
            // DTP_fechai
            // 
            this.DTP_fechai.Location = new System.Drawing.Point(118, 77);
            this.DTP_fechai.Name = "DTP_fechai";
            this.DTP_fechai.Size = new System.Drawing.Size(435, 27);
            this.DTP_fechai.TabIndex = 8;
            this.DTP_fechai.Value = new System.DateTime(2020, 4, 13, 0, 0, 0, 0);
            this.DTP_fechai.ValueChanged += new System.EventHandler(this.DTP_fecha_ValueChanged);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(121, 164);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(438, 27);
            this.Txt_nombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha inicio";
            // 
            // Txt_id
            // 
            this.Txt_id.Enabled = false;
            this.Txt_id.Location = new System.Drawing.Point(118, 40);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(438, 27);
            this.Txt_id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Planilla";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Planilla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_detalle);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.Btn_generar);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(801, 273);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "información";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.LblUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 584);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(842, 22);
            this.statusStrip.TabIndex = 13;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(586, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Nueva planilla";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Planilla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(842, 606);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Planilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "planilla";
            this.Load += new System.EventHandler(this.Planilla_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_detalle;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
        private System.Windows.Forms.DateTimePicker DTP_fechaf;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker DTP_fechai;
        private System.Windows.Forms.Button button1;
    }
}