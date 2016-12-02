namespace Locadora_Veiculos
{
    partial class ExibirPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirPedido));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Entrega = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_NPedido = new System.Windows.Forms.Label();
            this.textBox_NPedido = new System.Windows.Forms.TextBox();
            this.label_DataAbertura = new System.Windows.Forms.Label();
            this.textBox_Cliente = new System.Windows.Forms.TextBox();
            this.label_Valor = new System.Windows.Forms.Label();
            this.textBox_Valor = new System.Windows.Forms.TextBox();
            this.dataGridView_Pedido = new System.Windows.Forms.DataGridView();
            this.ReservaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFormaPagamento = new System.Windows.Forms.TextBox();
            this.textBoxTipoRetirada = new System.Windows.Forms.TextBox();
            this.textBoxSituacao = new System.Windows.Forms.TextBox();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Entrega,
            this.toolStripSeparator8,
            this.toolStripButton_Sair,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(720, 73);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Entrega
            // 
            this.toolStripButton_Entrega.AutoSize = false;
            this.toolStripButton_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Entrega.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Entrega.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Entrega.Image")));
            this.toolStripButton_Entrega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Entrega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Entrega.Name = "toolStripButton_Entrega";
            this.toolStripButton_Entrega.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Entrega.Text = "Entrega";
            this.toolStripButton_Entrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Entrega.Click += new System.EventHandler(this.toolStripButton_Entrega_Click);
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
            this.toolStripButton_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Sair.ForeColor = System.Drawing.SystemColors.InfoText;
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
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.AutoSize = false;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(3, 70);
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cliente.Location = new System.Drawing.Point(27, 103);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(55, 19);
            this.label_Cliente.TabIndex = 65;
            this.label_Cliente.Text = "Cliente";
            // 
            // label_NPedido
            // 
            this.label_NPedido.AutoSize = true;
            this.label_NPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NPedido.Location = new System.Drawing.Point(8, 144);
            this.label_NPedido.Name = "label_NPedido";
            this.label_NPedido.Size = new System.Drawing.Size(74, 19);
            this.label_NPedido.TabIndex = 77;
            this.label_NPedido.Text = "Nº Pedido";
            // 
            // textBox_NPedido
            // 
            this.textBox_NPedido.Enabled = false;
            this.textBox_NPedido.Location = new System.Drawing.Point(96, 146);
            this.textBox_NPedido.Name = "textBox_NPedido";
            this.textBox_NPedido.Size = new System.Drawing.Size(233, 20);
            this.textBox_NPedido.TabIndex = 78;
            // 
            // label_DataAbertura
            // 
            this.label_DataAbertura.AutoSize = true;
            this.label_DataAbertura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataAbertura.Location = new System.Drawing.Point(358, 145);
            this.label_DataAbertura.Name = "label_DataAbertura";
            this.label_DataAbertura.Size = new System.Drawing.Size(100, 19);
            this.label_DataAbertura.TabIndex = 79;
            this.label_DataAbertura.Text = "Data Abertura";
            // 
            // textBox_Cliente
            // 
            this.textBox_Cliente.Enabled = false;
            this.textBox_Cliente.Location = new System.Drawing.Point(96, 105);
            this.textBox_Cliente.Name = "textBox_Cliente";
            this.textBox_Cliente.Size = new System.Drawing.Size(234, 20);
            this.textBox_Cliente.TabIndex = 81;
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
            this.label_Valor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valor.Location = new System.Drawing.Point(358, 105);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(42, 19);
            this.label_Valor.TabIndex = 82;
            this.label_Valor.Text = "Valor";
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.Enabled = false;
            this.textBox_Valor.Location = new System.Drawing.Point(474, 105);
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(193, 20);
            this.textBox_Valor.TabIndex = 83;
            // 
            // dataGridView_Pedido
            // 
            this.dataGridView_Pedido.AllowUserToAddRows = false;
            this.dataGridView_Pedido.AllowUserToDeleteRows = false;
            this.dataGridView_Pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Pedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservaId,
            this.DataReserva,
            this.DataEntrega,
            this.DataRetirada,
            this.Veiculo,
            this.ValorCategoria,
            this.Total});
            this.dataGridView_Pedido.Location = new System.Drawing.Point(12, 294);
            this.dataGridView_Pedido.Name = "dataGridView_Pedido";
            this.dataGridView_Pedido.ReadOnly = true;
            this.dataGridView_Pedido.Size = new System.Drawing.Size(696, 56);
            this.dataGridView_Pedido.TabIndex = 84;
            // 
            // ReservaId
            // 
            this.ReservaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReservaId.HeaderText = "Número Pedido";
            this.ReservaId.Name = "ReservaId";
            this.ReservaId.ReadOnly = true;
            this.ReservaId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservaId.Width = 96;
            // 
            // DataReserva
            // 
            this.DataReserva.HeaderText = "Data Da Reserva";
            this.DataReserva.Name = "DataReserva";
            this.DataReserva.ReadOnly = true;
            // 
            // DataEntrega
            // 
            this.DataEntrega.HeaderText = "Data da Entrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            // 
            // DataRetirada
            // 
            this.DataRetirada.HeaderText = "Data da Retirada";
            this.DataRetirada.Name = "DataRetirada";
            this.DataRetirada.ReadOnly = true;
            // 
            // Veiculo
            // 
            this.Veiculo.HeaderText = "Veículo";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.ReadOnly = true;
            // 
            // ValorCategoria
            // 
            this.ValorCategoria.HeaderText = "Valor da Categoria";
            this.ValorCategoria.Name = "ValorCategoria";
            this.ValorCategoria.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // textBoxFormaPagamento
            // 
            this.textBoxFormaPagamento.Enabled = false;
            this.textBoxFormaPagamento.Location = new System.Drawing.Point(96, 188);
            this.textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            this.textBoxFormaPagamento.Size = new System.Drawing.Size(233, 20);
            this.textBoxFormaPagamento.TabIndex = 86;
            // 
            // textBoxTipoRetirada
            // 
            this.textBoxTipoRetirada.Enabled = false;
            this.textBoxTipoRetirada.Location = new System.Drawing.Point(474, 188);
            this.textBoxTipoRetirada.Name = "textBoxTipoRetirada";
            this.textBoxTipoRetirada.Size = new System.Drawing.Size(193, 20);
            this.textBoxTipoRetirada.TabIndex = 87;
            // 
            // textBoxSituacao
            // 
            this.textBoxSituacao.Enabled = false;
            this.textBoxSituacao.Location = new System.Drawing.Point(96, 236);
            this.textBoxSituacao.Name = "textBoxSituacao";
            this.textBoxSituacao.Size = new System.Drawing.Size(233, 20);
            this.textBoxSituacao.TabIndex = 88;
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Enabled = false;
            this.textBoxusuario.Location = new System.Drawing.Point(474, 238);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(193, 20);
            this.textBoxusuario.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "Retirada";
            // 
            // textBoxData
            // 
            this.textBoxData.Enabled = false;
            this.textBoxData.Location = new System.Drawing.Point(474, 143);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(193, 20);
            this.textBoxData.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Situação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 95;
            this.label4.Text = "Usuário";
            // 
            // ExibirPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(720, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.textBoxSituacao);
            this.Controls.Add(this.textBoxTipoRetirada);
            this.Controls.Add(this.textBoxFormaPagamento);
            this.Controls.Add(this.dataGridView_Pedido);
            this.Controls.Add(this.textBox_Valor);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.textBox_Cliente);
            this.Controls.Add(this.label_DataAbertura);
            this.Controls.Add(this.textBox_NPedido);
            this.Controls.Add(this.label_NPedido);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExibirPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Entrega;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_NPedido;
        private System.Windows.Forms.TextBox textBox_NPedido;
        private System.Windows.Forms.Label label_DataAbertura;
        private System.Windows.Forms.TextBox textBox_Cliente;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.TextBox textBox_Valor;
        private System.Windows.Forms.DataGridView dataGridView_Pedido;
        private System.Windows.Forms.TextBox textBoxFormaPagamento;
        private System.Windows.Forms.TextBox textBoxTipoRetirada;
        private System.Windows.Forms.TextBox textBoxSituacao;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}