namespace Locadora_Veiculos
{
    partial class NovaManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaManutencao));
            this.toolStripButton_PesquisarF = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.dateTimePicker_EntregaPrevista = new System.Windows.Forms.DateTimePicker();
            this.toolStripButton_Confirmar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker_Retirada = new System.Windows.Forms.DateTimePicker();
            this.label_EntregaPrevista = new System.Windows.Forms.Label();
            this.label_Retirada = new System.Windows.Forms.Label();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.comboBox_Fornecedor = new System.Windows.Forms.ComboBox();
            this.label_Fornecedor = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label_TipoManutencao = new System.Windows.Forms.Label();
            this.comboBox_TipoManutencao = new System.Windows.Forms.ComboBox();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton_PesquisarF
            // 
            this.toolStripButton_PesquisarF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PesquisarF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PesquisarF.Image")));
            this.toolStripButton_PesquisarF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PesquisarF.Name = "toolStripButton_PesquisarF";
            this.toolStripButton_PesquisarF.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_PesquisarF.Text = "toolStripButton1";
            this.toolStripButton_PesquisarF.Click += new System.EventHandler(this.toolStripButton_PesquisarF_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_PesquisarF});
            this.toolStrip3.Location = new System.Drawing.Point(409, 97);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(26, 25);
            this.toolStrip3.TabIndex = 87;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // dateTimePicker_EntregaPrevista
            // 
            this.dateTimePicker_EntregaPrevista.Location = new System.Drawing.Point(77, 167);
            this.dateTimePicker_EntregaPrevista.Name = "dateTimePicker_EntregaPrevista";
            this.dateTimePicker_EntregaPrevista.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker_EntregaPrevista.TabIndex = 84;
            // 
            // toolStripButton_Confirmar
            // 
            this.toolStripButton_Confirmar.AutoSize = false;
            this.toolStripButton_Confirmar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Confirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Confirmar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Confirmar.Image")));
            this.toolStripButton_Confirmar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Confirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Confirmar.Name = "toolStripButton_Confirmar";
            this.toolStripButton_Confirmar.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Confirmar.Text = "Confirmar";
            this.toolStripButton_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Confirmar.Click += new System.EventHandler(this.toolStripButton_Confirmar_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.AutoSize = false;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(3, 70);
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
            this.toolStripButton_Sair.Text = "&Sair";
            this.toolStripButton_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sair.Click += new System.EventHandler(this.toolStripButton_Sair_Click);
            // 
            // dateTimePicker_Retirada
            // 
            this.dateTimePicker_Retirada.Location = new System.Drawing.Point(77, 141);
            this.dateTimePicker_Retirada.Name = "dateTimePicker_Retirada";
            this.dateTimePicker_Retirada.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker_Retirada.TabIndex = 83;
            // 
            // label_EntregaPrevista
            // 
            this.label_EntregaPrevista.AutoSize = true;
            this.label_EntregaPrevista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EntregaPrevista.Location = new System.Drawing.Point(12, 167);
            this.label_EntregaPrevista.Name = "label_EntregaPrevista";
            this.label_EntregaPrevista.Size = new System.Drawing.Size(59, 19);
            this.label_EntregaPrevista.TabIndex = 82;
            this.label_EntregaPrevista.Text = "Entrega";
            // 
            // label_Retirada
            // 
            this.label_Retirada.AutoSize = true;
            this.label_Retirada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Retirada.Location = new System.Drawing.Point(12, 141);
            this.label_Retirada.Name = "label_Retirada";
            this.label_Retirada.Size = new System.Drawing.Size(64, 19);
            this.label_Retirada.TabIndex = 81;
            this.label_Retirada.Text = "Retirada";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.AutoSize = false;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(3, 70);
            // 
            // comboBox_Fornecedor
            // 
            this.comboBox_Fornecedor.FormattingEnabled = true;
            this.comboBox_Fornecedor.Location = new System.Drawing.Point(99, 97);
            this.comboBox_Fornecedor.Name = "comboBox_Fornecedor";
            this.comboBox_Fornecedor.Size = new System.Drawing.Size(307, 21);
            this.comboBox_Fornecedor.TabIndex = 78;
            // 
            // label_Fornecedor
            // 
            this.label_Fornecedor.AutoSize = true;
            this.label_Fornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fornecedor.Location = new System.Drawing.Point(12, 96);
            this.label_Fornecedor.Name = "label_Fornecedor";
            this.label_Fornecedor.Size = new System.Drawing.Size(81, 19);
            this.label_Fornecedor.TabIndex = 77;
            this.label_Fornecedor.Text = "Fornecedor";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Confirmar,
            this.toolStripSeparator8,
            this.toolStripButton_Sair,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(503, 73);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label_TipoManutencao
            // 
            this.label_TipoManutencao.AutoSize = true;
            this.label_TipoManutencao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TipoManutencao.Location = new System.Drawing.Point(12, 203);
            this.label_TipoManutencao.Name = "label_TipoManutencao";
            this.label_TipoManutencao.Size = new System.Drawing.Size(141, 19);
            this.label_TipoManutencao.TabIndex = 88;
            this.label_TipoManutencao.Text = "Tipo de manutenção";
            // 
            // comboBox_TipoManutencao
            // 
            this.comboBox_TipoManutencao.FormattingEnabled = true;
            this.comboBox_TipoManutencao.Items.AddRange(new object[] {
            "Corretiva",
            "Detectiva",
            "Revisão"});
            this.comboBox_TipoManutencao.Location = new System.Drawing.Point(153, 203);
            this.comboBox_TipoManutencao.Name = "comboBox_TipoManutencao";
            this.comboBox_TipoManutencao.Size = new System.Drawing.Size(176, 21);
            this.comboBox_TipoManutencao.TabIndex = 89;
            // 
            // NovaManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(503, 247);
            this.Controls.Add(this.comboBox_TipoManutencao);
            this.Controls.Add(this.label_TipoManutencao);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.dateTimePicker_EntregaPrevista);
            this.Controls.Add(this.dateTimePicker_Retirada);
            this.Controls.Add(this.label_EntregaPrevista);
            this.Controls.Add(this.label_Retirada);
            this.Controls.Add(this.comboBox_Fornecedor);
            this.Controls.Add(this.label_Fornecedor);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovaManutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Manutenção";
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton_PesquisarF;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EntregaPrevista;
        private System.Windows.Forms.ToolStripButton toolStripButton_Confirmar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Retirada;
        private System.Windows.Forms.Label label_EntregaPrevista;
        private System.Windows.Forms.Label label_Retirada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ComboBox comboBox_Fornecedor;
        private System.Windows.Forms.Label label_Fornecedor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label_TipoManutencao;
        private System.Windows.Forms.ComboBox comboBox_TipoManutencao;
    }
}