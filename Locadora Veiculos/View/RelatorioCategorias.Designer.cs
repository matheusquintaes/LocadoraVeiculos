namespace Locadora_Veiculos
{
    partial class RelatorioCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioCategorias));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Emitir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Tipo = new System.Windows.Forms.Label();
            this.comboBox_Tipo = new System.Windows.Forms.ComboBox();
            this.label_Valor = new System.Windows.Forms.Label();
            this.comboBox_Valor = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Emitir,
            this.toolStripSeparator2,
            this.toolStripButton_Sair,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(384, 73);
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
            // label_Tipo
            // 
            this.label_Tipo.AutoSize = true;
            this.label_Tipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tipo.Location = new System.Drawing.Point(29, 106);
            this.label_Tipo.Name = "label_Tipo";
            this.label_Tipo.Size = new System.Drawing.Size(37, 19);
            this.label_Tipo.TabIndex = 70;
            this.label_Tipo.Text = "Tipo";
            // 
            // comboBox_Tipo
            // 
            this.comboBox_Tipo.FormattingEnabled = true;
            this.comboBox_Tipo.Items.AddRange(new object[] {
            "Todos",
            "Com Veículos Cadastrados"});
            this.comboBox_Tipo.Location = new System.Drawing.Point(72, 106);
            this.comboBox_Tipo.Name = "comboBox_Tipo";
            this.comboBox_Tipo.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Tipo.TabIndex = 69;
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
            this.label_Valor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valor.Location = new System.Drawing.Point(24, 142);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(42, 19);
            this.label_Valor.TabIndex = 71;
            this.label_Valor.Text = "Valor";
            // 
            // comboBox_Valor
            // 
            this.comboBox_Valor.FormattingEnabled = true;
            this.comboBox_Valor.Items.AddRange(new object[] {
            "Todos",
            "Menor para Maior",
            "Maior para Menor"});
            this.comboBox_Valor.Location = new System.Drawing.Point(72, 142);
            this.comboBox_Valor.Name = "comboBox_Valor";
            this.comboBox_Valor.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Valor.TabIndex = 72;
            // 
            // RelatorioCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.comboBox_Valor);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.label_Tipo);
            this.Controls.Add(this.comboBox_Tipo);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Categoria";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Emitir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Tipo;
        private System.Windows.Forms.ComboBox comboBox_Tipo;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.ComboBox comboBox_Valor;
    }
}