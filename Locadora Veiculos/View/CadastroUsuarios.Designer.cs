namespace Locadora_Veiculos
{
    partial class CadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarios));
            this.label_Senha = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_TipoUsuario = new System.Windows.Forms.Label();
            this.comboBox_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.textBox_Nome = new System.Windows.Forms.MaskedTextBox();
            this.textBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.textBox_RG = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Senha = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Senha.Location = new System.Drawing.Point(18, 210);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(48, 19);
            this.label_Senha.TabIndex = 100;
            this.label_Senha.Text = "Senha";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Salvar,
            this.toolStripSeparator2,
            this.toolStripButton_Cancelar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(494, 73);
            this.toolStrip1.TabIndex = 94;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton_Salvar
            // 
            this.toolStripButton_Salvar.AutoSize = false;
            this.toolStripButton_Salvar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Salvar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Salvar.Image")));
            this.toolStripButton_Salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Salvar.Name = "toolStripButton_Salvar";
            this.toolStripButton_Salvar.Size = new System.Drawing.Size(95, 70);
            this.toolStripButton_Salvar.Text = "Salvar";
            this.toolStripButton_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Salvar.Click += new System.EventHandler(this.toolStripButton_Salvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Cancelar
            // 
            this.toolStripButton_Cancelar.AutoSize = false;
            this.toolStripButton_Cancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Cancelar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Cancelar.Image")));
            this.toolStripButton_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cancelar.Name = "toolStripButton_Cancelar";
            this.toolStripButton_Cancelar.Size = new System.Drawing.Size(95, 70);
            this.toolStripButton_Cancelar.Text = "Cancelar";
            this.toolStripButton_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Cancelar.Click += new System.EventHandler(this.toolStripButton_Cancelar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.Location = new System.Drawing.Point(7, 177);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(59, 19);
            this.label_Usuario.TabIndex = 117;
            this.label_Usuario.Text = "Usuário";
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RG.Location = new System.Drawing.Point(251, 125);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(28, 19);
            this.label_RG.TabIndex = 115;
            this.label_RG.Text = "RG";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.Location = new System.Drawing.Point(8, 90);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(47, 19);
            this.label_Nome.TabIndex = 114;
            this.label_Nome.Text = "Nome";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPF.Location = new System.Drawing.Point(22, 123);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(33, 19);
            this.label_CPF.TabIndex = 112;
            this.label_CPF.Text = "CPF";
            // 
            // label_TipoUsuario
            // 
            this.label_TipoUsuario.AutoSize = true;
            this.label_TipoUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TipoUsuario.Location = new System.Drawing.Point(251, 176);
            this.label_TipoUsuario.Name = "label_TipoUsuario";
            this.label_TipoUsuario.Size = new System.Drawing.Size(76, 19);
            this.label_TipoUsuario.TabIndex = 119;
            this.label_TipoUsuario.Text = "Permissão";
            // 
            // comboBox_TipoUsuario
            // 
            this.comboBox_TipoUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "Comum",
            "Administrador"});
            this.comboBox_TipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_TipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoUsuario.FormattingEnabled = true;
            this.comboBox_TipoUsuario.Items.AddRange(new object[] {
            "Comum",
            "Administrador"});
            this.comboBox_TipoUsuario.Location = new System.Drawing.Point(333, 175);
            this.comboBox_TipoUsuario.Name = "comboBox_TipoUsuario";
            this.comboBox_TipoUsuario.Size = new System.Drawing.Size(124, 21);
            this.comboBox_TipoUsuario.TabIndex = 1;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(61, 89);
            this.textBox_Nome.Mask = "???????????????????????????????????????";
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(396, 20);
            this.textBox_Nome.TabIndex = 120;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(61, 123);
            this.textBox_CPF.Mask = "000,000,000-00";
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(184, 20);
            this.textBox_CPF.TabIndex = 121;
            // 
            // textBox_RG
            // 
            this.textBox_RG.Location = new System.Drawing.Point(285, 124);
            this.textBox_RG.Mask = "00.000.000-00";
            this.textBox_RG.Name = "textBox_RG";
            this.textBox_RG.Size = new System.Drawing.Size(172, 20);
            this.textBox_RG.TabIndex = 122;
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(72, 175);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(173, 20);
            this.textBox_Usuario.TabIndex = 123;
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(72, 211);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(173, 20);
            this.textBox_Senha.TabIndex = 124;
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(494, 249);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.textBox_RG);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.comboBox_TipoUsuario);
            this.Controls.Add(this.label_TipoUsuario);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.label_CPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_TipoUsuario;
        private System.Windows.Forms.ComboBox comboBox_TipoUsuario;
        private System.Windows.Forms.MaskedTextBox textBox_Nome;
        private System.Windows.Forms.MaskedTextBox textBox_CPF;
        private System.Windows.Forms.MaskedTextBox textBox_RG;
        private System.Windows.Forms.MaskedTextBox textBox_Usuario;
        private System.Windows.Forms.MaskedTextBox textBox_Senha;
    }
}