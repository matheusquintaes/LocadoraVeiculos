namespace Locadora_Veiculos
{
    partial class Manutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manutencao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Nova = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Devolucao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label_HistoricoManutencoes = new System.Windows.Forms.Label();
            this.dataGridView_HistoricoManutencoes = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistoricoManutencoes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Nova,
            this.toolStripSeparator2,
            this.toolStripButton_Devolucao,
            this.toolStripSeparator3,
            this.toolStripButton_Sair,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(720, 73);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Nova
            // 
            this.toolStripButton_Nova.AutoSize = false;
            this.toolStripButton_Nova.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Nova.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Nova.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Nova.Image")));
            this.toolStripButton_Nova.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Nova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Nova.Name = "toolStripButton_Nova";
            this.toolStripButton_Nova.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Nova.Text = "Nova";
            this.toolStripButton_Nova.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Nova.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Nova.Click += new System.EventHandler(this.toolStripButton_Nova_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Devolucao
            // 
            this.toolStripButton_Devolucao.AutoSize = false;
            this.toolStripButton_Devolucao.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Devolucao.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Devolucao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Devolucao.Image")));
            this.toolStripButton_Devolucao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Devolucao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Devolucao.Name = "toolStripButton_Devolucao";
            this.toolStripButton_Devolucao.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Devolucao.Text = "Devolução";
            this.toolStripButton_Devolucao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Devolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Devolucao.Click += new System.EventHandler(this.toolStripButton_Devolucao_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(3, 70);
            // 
            // label_HistoricoManutencoes
            // 
            this.label_HistoricoManutencoes.AutoSize = true;
            this.label_HistoricoManutencoes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HistoricoManutencoes.Location = new System.Drawing.Point(263, 103);
            this.label_HistoricoManutencoes.Name = "label_HistoricoManutencoes";
            this.label_HistoricoManutencoes.Size = new System.Drawing.Size(179, 19);
            this.label_HistoricoManutencoes.TabIndex = 86;
            this.label_HistoricoManutencoes.Text = "Histórico de Manutenções";
            // 
            // dataGridView_HistoricoManutencoes
            // 
            this.dataGridView_HistoricoManutencoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HistoricoManutencoes.Location = new System.Drawing.Point(13, 125);
            this.dataGridView_HistoricoManutencoes.Name = "dataGridView_HistoricoManutencoes";
            this.dataGridView_HistoricoManutencoes.Size = new System.Drawing.Size(695, 346);
            this.dataGridView_HistoricoManutencoes.TabIndex = 87;
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.dataGridView_HistoricoManutencoes);
            this.Controls.Add(this.label_HistoricoManutencoes);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistoricoManutencoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Nova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_HistoricoManutencoes;
        private System.Windows.Forms.ToolStripButton toolStripButton_Devolucao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView_HistoricoManutencoes;
    }
}