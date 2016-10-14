namespace Locadora_Veiculos
{
    partial class Locacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locacao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Confirmar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_CheckList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.label_Veiculo = new System.Windows.Forms.Label();
            this.comboBox_Veiculo = new System.Windows.Forms.ComboBox();
            this.label_Retirada = new System.Windows.Forms.Label();
            this.label_Entrega = new System.Windows.Forms.Label();
            this.dateTimePicker_Retirada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Entrega = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_PesquisarV = new System.Windows.Forms.ToolStripButton();
            this.groupBox_FormaPagamento = new System.Windows.Forms.GroupBox();
            this.radioButton_CartaoDebito = new System.Windows.Forms.RadioButton();
            this.radioButton_CartaoCredito = new System.Windows.Forms.RadioButton();
            this.radioButton_Boleto = new System.Windows.Forms.RadioButton();
            this.radioButton_Dinheiro = new System.Windows.Forms.RadioButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_PesquisarC = new System.Windows.Forms.ToolStripButton();
            this.label_TipoRetirada = new System.Windows.Forms.Label();
            this.comboBox_TipoRetirada = new System.Windows.Forms.ComboBox();
            this.label_CheckList = new System.Windows.Forms.Label();
            this.textBox_CheckList = new System.Windows.Forms.TextBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Remover = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_Veiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox_FormaPagamento.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veiculos)).BeginInit();
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
            this.toolStripButton_CheckList,
            this.toolStripSeparator4,
            this.toolStripButton_Sair,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(720, 73);
            this.toolStrip1.TabIndex = 2;
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
            // toolStripButton_CheckList
            // 
            this.toolStripButton_CheckList.AutoSize = false;
            this.toolStripButton_CheckList.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_CheckList.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_CheckList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CheckList.Image")));
            this.toolStripButton_CheckList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_CheckList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CheckList.Name = "toolStripButton_CheckList";
            this.toolStripButton_CheckList.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_CheckList.Text = "Checklist";
            this.toolStripButton_CheckList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_CheckList.Click += new System.EventHandler(this.toolStripButton_CheckList_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(3, 70);
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
            this.label_Cliente.Location = new System.Drawing.Point(361, 111);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(55, 19);
            this.label_Cliente.TabIndex = 63;
            this.label_Cliente.Text = "Cliente";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(422, 111);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(246, 21);
            this.comboBox_Cliente.TabIndex = 64;
            // 
            // label_Veiculo
            // 
            this.label_Veiculo.AutoSize = true;
            this.label_Veiculo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Veiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Veiculo.Location = new System.Drawing.Point(2, 111);
            this.label_Veiculo.Name = "label_Veiculo";
            this.label_Veiculo.Size = new System.Drawing.Size(56, 19);
            this.label_Veiculo.TabIndex = 65;
            this.label_Veiculo.Text = "Veículo";
            // 
            // comboBox_Veiculo
            // 
            this.comboBox_Veiculo.FormattingEnabled = true;
            this.comboBox_Veiculo.Location = new System.Drawing.Point(64, 111);
            this.comboBox_Veiculo.Name = "comboBox_Veiculo";
            this.comboBox_Veiculo.Size = new System.Drawing.Size(246, 21);
            this.comboBox_Veiculo.TabIndex = 66;
            // 
            // label_Retirada
            // 
            this.label_Retirada.AutoSize = true;
            this.label_Retirada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Retirada.Location = new System.Drawing.Point(2, 168);
            this.label_Retirada.Name = "label_Retirada";
            this.label_Retirada.Size = new System.Drawing.Size(64, 19);
            this.label_Retirada.TabIndex = 67;
            this.label_Retirada.Text = "Retirada";
            // 
            // label_Entrega
            // 
            this.label_Entrega.AutoSize = true;
            this.label_Entrega.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Entrega.Location = new System.Drawing.Point(2, 192);
            this.label_Entrega.Name = "label_Entrega";
            this.label_Entrega.Size = new System.Drawing.Size(59, 19);
            this.label_Entrega.TabIndex = 68;
            this.label_Entrega.Text = "Entrega";
            // 
            // dateTimePicker_Retirada
            // 
            this.dateTimePicker_Retirada.Location = new System.Drawing.Point(64, 167);
            this.dateTimePicker_Retirada.Name = "dateTimePicker_Retirada";
            this.dateTimePicker_Retirada.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker_Retirada.TabIndex = 69;
            // 
            // dateTimePicker_Entrega
            // 
            this.dateTimePicker_Entrega.Location = new System.Drawing.Point(64, 190);
            this.dateTimePicker_Entrega.Name = "dateTimePicker_Entrega";
            this.dateTimePicker_Entrega.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker_Entrega.TabIndex = 70;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_PesquisarV});
            this.toolStrip2.Location = new System.Drawing.Point(316, 111);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(26, 25);
            this.toolStrip2.TabIndex = 71;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_PesquisarV
            // 
            this.toolStripButton_PesquisarV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PesquisarV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PesquisarV.Image")));
            this.toolStripButton_PesquisarV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PesquisarV.Name = "toolStripButton_PesquisarV";
            this.toolStripButton_PesquisarV.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_PesquisarV.Text = "toolStripButton1";
            this.toolStripButton_PesquisarV.Click += new System.EventHandler(this.toolStripButton_PesquisarV_Click);
            // 
            // groupBox_FormaPagamento
            // 
            this.groupBox_FormaPagamento.Controls.Add(this.radioButton_CartaoDebito);
            this.groupBox_FormaPagamento.Controls.Add(this.radioButton_CartaoCredito);
            this.groupBox_FormaPagamento.Controls.Add(this.radioButton_Boleto);
            this.groupBox_FormaPagamento.Controls.Add(this.radioButton_Dinheiro);
            this.groupBox_FormaPagamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_FormaPagamento.Location = new System.Drawing.Point(422, 168);
            this.groupBox_FormaPagamento.Name = "groupBox_FormaPagamento";
            this.groupBox_FormaPagamento.Size = new System.Drawing.Size(257, 93);
            this.groupBox_FormaPagamento.TabIndex = 72;
            this.groupBox_FormaPagamento.TabStop = false;
            this.groupBox_FormaPagamento.Text = "Forma de Pagamento";
            // 
            // radioButton_CartaoDebito
            // 
            this.radioButton_CartaoDebito.AutoSize = true;
            this.radioButton_CartaoDebito.Location = new System.Drawing.Point(130, 68);
            this.radioButton_CartaoDebito.Name = "radioButton_CartaoDebito";
            this.radioButton_CartaoDebito.Size = new System.Drawing.Size(117, 18);
            this.radioButton_CartaoDebito.TabIndex = 3;
            this.radioButton_CartaoDebito.TabStop = true;
            this.radioButton_CartaoDebito.Text = "Cartão de Débito";
            this.radioButton_CartaoDebito.UseVisualStyleBackColor = true;
            // 
            // radioButton_CartaoCredito
            // 
            this.radioButton_CartaoCredito.AutoSize = true;
            this.radioButton_CartaoCredito.Location = new System.Drawing.Point(130, 31);
            this.radioButton_CartaoCredito.Name = "radioButton_CartaoCredito";
            this.radioButton_CartaoCredito.Size = new System.Drawing.Size(119, 18);
            this.radioButton_CartaoCredito.TabIndex = 2;
            this.radioButton_CartaoCredito.TabStop = true;
            this.radioButton_CartaoCredito.Text = "Cartão de Crédito";
            this.radioButton_CartaoCredito.UseVisualStyleBackColor = true;
            // 
            // radioButton_Boleto
            // 
            this.radioButton_Boleto.AutoSize = true;
            this.radioButton_Boleto.Location = new System.Drawing.Point(17, 68);
            this.radioButton_Boleto.Name = "radioButton_Boleto";
            this.radioButton_Boleto.Size = new System.Drawing.Size(61, 18);
            this.radioButton_Boleto.TabIndex = 1;
            this.radioButton_Boleto.TabStop = true;
            this.radioButton_Boleto.Text = "Boleto";
            this.radioButton_Boleto.UseVisualStyleBackColor = true;
            // 
            // radioButton_Dinheiro
            // 
            this.radioButton_Dinheiro.AutoSize = true;
            this.radioButton_Dinheiro.Location = new System.Drawing.Point(17, 31);
            this.radioButton_Dinheiro.Name = "radioButton_Dinheiro";
            this.radioButton_Dinheiro.Size = new System.Drawing.Size(73, 18);
            this.radioButton_Dinheiro.TabIndex = 0;
            this.radioButton_Dinheiro.TabStop = true;
            this.radioButton_Dinheiro.Text = "Dinheiro";
            this.radioButton_Dinheiro.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_PesquisarC});
            this.toolStrip3.Location = new System.Drawing.Point(671, 111);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(26, 25);
            this.toolStrip3.TabIndex = 73;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton_PesquisarC
            // 
            this.toolStripButton_PesquisarC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PesquisarC.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PesquisarC.Image")));
            this.toolStripButton_PesquisarC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PesquisarC.Name = "toolStripButton_PesquisarC";
            this.toolStripButton_PesquisarC.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_PesquisarC.Text = "toolStripButton1";
            this.toolStripButton_PesquisarC.Click += new System.EventHandler(this.toolStripButton_PesquisarC_Click);
            // 
            // label_TipoRetirada
            // 
            this.label_TipoRetirada.AutoSize = true;
            this.label_TipoRetirada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TipoRetirada.Location = new System.Drawing.Point(2, 230);
            this.label_TipoRetirada.Name = "label_TipoRetirada";
            this.label_TipoRetirada.Size = new System.Drawing.Size(118, 19);
            this.label_TipoRetirada.TabIndex = 76;
            this.label_TipoRetirada.Text = "Local da retirada";
            // 
            // comboBox_TipoRetirada
            // 
            this.comboBox_TipoRetirada.FormattingEnabled = true;
            this.comboBox_TipoRetirada.Items.AddRange(new object[] {
            "No Local",
            "Entrega ao Cliente"});
            this.comboBox_TipoRetirada.Location = new System.Drawing.Point(118, 231);
            this.comboBox_TipoRetirada.Name = "comboBox_TipoRetirada";
            this.comboBox_TipoRetirada.Size = new System.Drawing.Size(184, 21);
            this.comboBox_TipoRetirada.TabIndex = 77;
            this.comboBox_TipoRetirada.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoRetirada_SelectedIndexChanged);
            // 
            // label_CheckList
            // 
            this.label_CheckList.AutoSize = true;
            this.label_CheckList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CheckList.Location = new System.Drawing.Point(549, 296);
            this.label_CheckList.Name = "label_CheckList";
            this.label_CheckList.Size = new System.Drawing.Size(138, 19);
            this.label_CheckList.TabIndex = 78;
            this.label_CheckList.Text = "Checklist do veículo";
            // 
            // textBox_CheckList
            // 
            this.textBox_CheckList.ForeColor = System.Drawing.Color.Maroon;
            this.textBox_CheckList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_CheckList.Location = new System.Drawing.Point(539, 318);
            this.textBox_CheckList.Name = "textBox_CheckList";
            this.textBox_CheckList.Size = new System.Drawing.Size(158, 20);
            this.textBox_CheckList.TabIndex = 100;
            this.textBox_CheckList.Text = "Não Realizado";
            this.textBox_CheckList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Adicionar,
            this.toolStripSeparator3,
            this.toolStripButton_Remover});
            this.toolStrip4.Location = new System.Drawing.Point(6, 303);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(126, 38);
            this.toolStrip4.TabIndex = 74;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton_Adicionar
            // 
            this.toolStripButton_Adicionar.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Adicionar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Adicionar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Adicionar.Image")));
            this.toolStripButton_Adicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Adicionar.Name = "toolStripButton_Adicionar";
            this.toolStripButton_Adicionar.Size = new System.Drawing.Size(62, 35);
            this.toolStripButton_Adicionar.Text = "Adicionar";
            this.toolStripButton_Adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Adicionar.Click += new System.EventHandler(this.toolStripButton_Adicionar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton_Remover
            // 
            this.toolStripButton_Remover.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton_Remover.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Remover.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Remover.Image")));
            this.toolStripButton_Remover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Remover.Name = "toolStripButton_Remover";
            this.toolStripButton_Remover.Size = new System.Drawing.Size(55, 35);
            this.toolStripButton_Remover.Text = "Remover";
            this.toolStripButton_Remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Remover.Click += new System.EventHandler(this.toolStripButton_Remover_Click);
            // 
            // dataGridView_Veiculos
            // 
            this.dataGridView_Veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Veiculos.Location = new System.Drawing.Point(6, 344);
            this.dataGridView_Veiculos.Name = "dataGridView_Veiculos";
            this.dataGridView_Veiculos.Size = new System.Drawing.Size(702, 127);
            this.dataGridView_Veiculos.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Horário";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 104;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 105;
            // 
            // Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Veiculos);
            this.Controls.Add(this.textBox_CheckList);
            this.Controls.Add(this.label_CheckList);
            this.Controls.Add(this.comboBox_TipoRetirada);
            this.Controls.Add(this.label_TipoRetirada);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.groupBox_FormaPagamento);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dateTimePicker_Entrega);
            this.Controls.Add(this.dateTimePicker_Retirada);
            this.Controls.Add(this.label_Entrega);
            this.Controls.Add(this.label_Retirada);
            this.Controls.Add(this.comboBox_Veiculo);
            this.Controls.Add(this.label_Veiculo);
            this.Controls.Add(this.comboBox_Cliente);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Locacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox_FormaPagamento.ResumeLayout(false);
            this.groupBox_FormaPagamento.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Confirmar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.Label label_Veiculo;
        private System.Windows.Forms.ComboBox comboBox_Veiculo;
        private System.Windows.Forms.Label label_Retirada;
        private System.Windows.Forms.Label label_Entrega;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Retirada;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Entrega;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_PesquisarV;
        private System.Windows.Forms.GroupBox groupBox_FormaPagamento;
        private System.Windows.Forms.RadioButton radioButton_CartaoDebito;
        private System.Windows.Forms.RadioButton radioButton_CartaoCredito;
        private System.Windows.Forms.RadioButton radioButton_Boleto;
        private System.Windows.Forms.RadioButton radioButton_Dinheiro;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton_PesquisarC;
        private System.Windows.Forms.Label label_TipoRetirada;
        private System.Windows.Forms.ComboBox comboBox_TipoRetirada;
        private System.Windows.Forms.Label label_CheckList;
        private System.Windows.Forms.TextBox textBox_CheckList;
        private System.Windows.Forms.ToolStripButton toolStripButton_CheckList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton_Adicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_Remover;
        private System.Windows.Forms.DataGridView dataGridView_Veiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}