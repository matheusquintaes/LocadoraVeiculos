namespace Locadora_Veiculos
{
    partial class DevolucaoManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucaoManutencao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Confirmar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.label_DataEntrega = new System.Windows.Forms.Label();
            this.dateTimePicker_DataEntrega = new System.Windows.Forms.DateTimePicker();
            this.textBox_Observacoes = new System.Windows.Forms.TextBox();
            this.label_Observacoes = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Confirmar,
            this.toolStripSeparator8,
            this.toolStripButton_Cancelar,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(504, 73);
            this.toolStrip1.TabIndex = 77;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButton_Cancelar
            // 
            this.toolStripButton_Cancelar.AutoSize = false;
            this.toolStripButton_Cancelar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Cancelar.Image")));
            this.toolStripButton_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cancelar.Name = "toolStripButton_Cancelar";
            this.toolStripButton_Cancelar.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Cancelar.Text = "Cancelar";
            this.toolStripButton_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Cancelar.Click += new System.EventHandler(this.toolStripButton_Cancelar_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.AutoSize = false;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(3, 70);
            // 
            // label_DataEntrega
            // 
            this.label_DataEntrega.AutoSize = true;
            this.label_DataEntrega.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataEntrega.Location = new System.Drawing.Point(12, 101);
            this.label_DataEntrega.Name = "label_DataEntrega";
            this.label_DataEntrega.Size = new System.Drawing.Size(114, 19);
            this.label_DataEntrega.TabIndex = 86;
            this.label_DataEntrega.Text = "Data de entrega";
            // 
            // dateTimePicker_DataEntrega
            // 
            this.dateTimePicker_DataEntrega.Location = new System.Drawing.Point(132, 101);
            this.dateTimePicker_DataEntrega.Name = "dateTimePicker_DataEntrega";
            this.dateTimePicker_DataEntrega.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker_DataEntrega.TabIndex = 87;
            // 
            // textBox_Observacoes
            // 
            this.textBox_Observacoes.Location = new System.Drawing.Point(16, 182);
            this.textBox_Observacoes.Multiline = true;
            this.textBox_Observacoes.Name = "textBox_Observacoes";
            this.textBox_Observacoes.Size = new System.Drawing.Size(363, 53);
            this.textBox_Observacoes.TabIndex = 88;
            // 
            // label_Observacoes
            // 
            this.label_Observacoes.AutoSize = true;
            this.label_Observacoes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Observacoes.Location = new System.Drawing.Point(12, 160);
            this.label_Observacoes.Name = "label_Observacoes";
            this.label_Observacoes.Size = new System.Drawing.Size(93, 19);
            this.label_Observacoes.TabIndex = 89;
            this.label_Observacoes.Text = "Observações";
            // 
            // DevolucaoManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(504, 247);
            this.Controls.Add(this.label_Observacoes);
            this.Controls.Add(this.textBox_Observacoes);
            this.Controls.Add(this.dateTimePicker_DataEntrega);
            this.Controls.Add(this.label_DataEntrega);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolucaoManutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução Manutenção";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Confirmar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label label_DataEntrega;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataEntrega;
        private System.Windows.Forms.TextBox textBox_Observacoes;
        private System.Windows.Forms.Label label_Observacoes;
    }
}