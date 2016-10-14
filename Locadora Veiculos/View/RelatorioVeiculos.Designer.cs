namespace Locadora_Veiculos
{
    partial class RelatorioVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVeiculos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Emitir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Status = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label_Filtro = new System.Windows.Forms.Label();
            this.comboBox_Filtro = new System.Windows.Forms.ComboBox();
            this.groupBox_Periodo = new System.Windows.Forms.GroupBox();
            this.radioButton_Selecionar = new System.Windows.Forms.RadioButton();
            this.radioButton_Todos = new System.Windows.Forms.RadioButton();
            this.label_AteData = new System.Windows.Forms.Label();
            this.label_DeData = new System.Windows.Forms.Label();
            this.dateTimePicker_AteData = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DeData = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.groupBox_Periodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Emitir,
            this.toolStripSeparator2,
            this.toolStripButton_Sair,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(368, 73);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Emitir
            // 
            this.toolStripButton_Emitir.AutoSize = false;
            this.toolStripButton_Emitir.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Emitir.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Emitir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Emitir.Image")));
            this.toolStripButton_Emitir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Emitir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Emitir.Name = "toolStripButton_Emitir";
            this.toolStripButton_Emitir.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Emitir.Text = "Emitir";
            this.toolStripButton_Emitir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Emitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Emitir.Click += new System.EventHandler(this.toolStripButton_Emitir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Sair
            // 
            this.toolStripButton_Sair.AutoSize = false;
            this.toolStripButton_Sair.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Sair.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Sair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Sair.Image")));
            this.toolStripButton_Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sair.Name = "toolStripButton_Sair";
            this.toolStripButton_Sair.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Sair.Text = "Sair";
            this.toolStripButton_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sair.Click += new System.EventHandler(this.toolStripButton_Sair_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(12, 107);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(49, 19);
            this.label_Status.TabIndex = 66;
            this.label_Status.Text = "Status";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Todos",
            "Alugados",
            "Disponíveis",
            "Manutenção"});
            this.comboBox_Status.Location = new System.Drawing.Point(67, 108);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(145, 21);
            this.comboBox_Status.TabIndex = 65;
            // 
            // label_Filtro
            // 
            this.label_Filtro.AutoSize = true;
            this.label_Filtro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filtro.Location = new System.Drawing.Point(12, 159);
            this.label_Filtro.Name = "label_Filtro";
            this.label_Filtro.Size = new System.Drawing.Size(72, 19);
            this.label_Filtro.TabIndex = 67;
            this.label_Filtro.Text = "Filtrar por";
            // 
            // comboBox_Filtro
            // 
            this.comboBox_Filtro.FormattingEnabled = true;
            this.comboBox_Filtro.Items.AddRange(new object[] {
            "Todos",
            "Entrega Locação",
            "Entrega Manutenção",
            "Prox.Licenciamento",
            "Marca",
            "Modelo",
            "Fabricante"});
            this.comboBox_Filtro.Location = new System.Drawing.Point(90, 160);
            this.comboBox_Filtro.Name = "comboBox_Filtro";
            this.comboBox_Filtro.Size = new System.Drawing.Size(122, 21);
            this.comboBox_Filtro.TabIndex = 68;
            // 
            // groupBox_Periodo
            // 
            this.groupBox_Periodo.Controls.Add(this.radioButton_Selecionar);
            this.groupBox_Periodo.Controls.Add(this.radioButton_Todos);
            this.groupBox_Periodo.Controls.Add(this.label_AteData);
            this.groupBox_Periodo.Controls.Add(this.label_DeData);
            this.groupBox_Periodo.Controls.Add(this.dateTimePicker_AteData);
            this.groupBox_Periodo.Controls.Add(this.dateTimePicker_DeData);
            this.groupBox_Periodo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Periodo.Location = new System.Drawing.Point(16, 195);
            this.groupBox_Periodo.Name = "groupBox_Periodo";
            this.groupBox_Periodo.Size = new System.Drawing.Size(340, 100);
            this.groupBox_Periodo.TabIndex = 75;
            this.groupBox_Periodo.TabStop = false;
            this.groupBox_Periodo.Text = "Período";
            // 
            // radioButton_Selecionar
            // 
            this.radioButton_Selecionar.AutoSize = true;
            this.radioButton_Selecionar.Location = new System.Drawing.Point(88, 19);
            this.radioButton_Selecionar.Name = "radioButton_Selecionar";
            this.radioButton_Selecionar.Size = new System.Drawing.Size(75, 17);
            this.radioButton_Selecionar.TabIndex = 80;
            this.radioButton_Selecionar.Text = "Selecionar";
            this.radioButton_Selecionar.UseVisualStyleBackColor = true;
            this.radioButton_Selecionar.CheckedChanged += new System.EventHandler(this.radioButton_Selecionar_CheckedChanged);
            // 
            // radioButton_Todos
            // 
            this.radioButton_Todos.AutoSize = true;
            this.radioButton_Todos.Checked = true;
            this.radioButton_Todos.Location = new System.Drawing.Point(10, 19);
            this.radioButton_Todos.Name = "radioButton_Todos";
            this.radioButton_Todos.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Todos.TabIndex = 79;
            this.radioButton_Todos.TabStop = true;
            this.radioButton_Todos.Text = "Todos";
            this.radioButton_Todos.UseVisualStyleBackColor = true;
            this.radioButton_Todos.CheckedChanged += new System.EventHandler(this.radioButton_Todos_CheckedChanged);
            // 
            // label_AteData
            // 
            this.label_AteData.AutoSize = true;
            this.label_AteData.Enabled = false;
            this.label_AteData.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_AteData.Location = new System.Drawing.Point(3, 74);
            this.label_AteData.Name = "label_AteData";
            this.label_AteData.Size = new System.Drawing.Size(29, 20);
            this.label_AteData.TabIndex = 78;
            this.label_AteData.Text = "Até";
            // 
            // label_DeData
            // 
            this.label_DeData.AutoSize = true;
            this.label_DeData.Enabled = false;
            this.label_DeData.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_DeData.Location = new System.Drawing.Point(6, 49);
            this.label_DeData.Name = "label_DeData";
            this.label_DeData.Size = new System.Drawing.Size(26, 20);
            this.label_DeData.TabIndex = 77;
            this.label_DeData.Text = "De";
            // 
            // dateTimePicker_AteData
            // 
            this.dateTimePicker_AteData.Enabled = false;
            this.dateTimePicker_AteData.Location = new System.Drawing.Point(38, 74);
            this.dateTimePicker_AteData.Name = "dateTimePicker_AteData";
            this.dateTimePicker_AteData.Size = new System.Drawing.Size(225, 21);
            this.dateTimePicker_AteData.TabIndex = 76;
            // 
            // dateTimePicker_DeData
            // 
            this.dateTimePicker_DeData.Enabled = false;
            this.dateTimePicker_DeData.Location = new System.Drawing.Point(38, 48);
            this.dateTimePicker_DeData.Name = "dateTimePicker_DeData";
            this.dateTimePicker_DeData.Size = new System.Drawing.Size(225, 21);
            this.dateTimePicker_DeData.TabIndex = 75;
            // 
            // RelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(368, 307);
            this.Controls.Add(this.groupBox_Periodo);
            this.Controls.Add(this.comboBox_Filtro);
            this.Controls.Add(this.label_Filtro);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Veículos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_Periodo.ResumeLayout(false);
            this.groupBox_Periodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Emitir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label_Filtro;
        private System.Windows.Forms.ComboBox comboBox_Filtro;
        private System.Windows.Forms.GroupBox groupBox_Periodo;
        private System.Windows.Forms.RadioButton radioButton_Selecionar;
        private System.Windows.Forms.RadioButton radioButton_Todos;
        private System.Windows.Forms.Label label_AteData;
        private System.Windows.Forms.Label label_DeData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AteData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeData;
    }
}