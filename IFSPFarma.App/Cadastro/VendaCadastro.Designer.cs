namespace IFSPFarma.App.Cadastro
{
    partial class VendaCadastro
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
            this.cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboFarmaceutico = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboProdutos = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtTotalvenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtQnt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.txtValoru = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.gridVendas = new System.Windows.Forms.DataGridView();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.txtDesconto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Size = new System.Drawing.Size(530, 695);
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Size = new System.Drawing.Size(469, 374);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Size = new System.Drawing.Size(522, 667);
            this.tabPage1.Controls.SetChildIndex(this.groupBox1, 0);
            this.tabPage1.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // cboCliente
            // 
            this.cboCliente.AutoResize = false;
            this.cboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCliente.Depth = 0;
            this.cboCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCliente.DropDownHeight = 174;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.DropDownWidth = 121;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Hint = "Cliente";
            this.cboCliente.IntegralHeight = false;
            this.cboCliente.ItemHeight = 43;
            this.cboCliente.Location = new System.Drawing.Point(274, 22);
            this.cboCliente.MaxDropDownItems = 4;
            this.cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(230, 49);
            this.cboCliente.StartIndex = 0;
            this.cboCliente.TabIndex = 5;
            // 
            // cboFarmaceutico
            // 
            this.cboFarmaceutico.AutoResize = false;
            this.cboFarmaceutico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboFarmaceutico.Depth = 0;
            this.cboFarmaceutico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboFarmaceutico.DropDownHeight = 174;
            this.cboFarmaceutico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFarmaceutico.DropDownWidth = 121;
            this.cboFarmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboFarmaceutico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboFarmaceutico.FormattingEnabled = true;
            this.cboFarmaceutico.Hint = "Farmaceutico";
            this.cboFarmaceutico.IntegralHeight = false;
            this.cboFarmaceutico.ItemHeight = 43;
            this.cboFarmaceutico.Location = new System.Drawing.Point(274, 77);
            this.cboFarmaceutico.MaxDropDownItems = 4;
            this.cboFarmaceutico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboFarmaceutico.Name = "cboFarmaceutico";
            this.cboFarmaceutico.Size = new System.Drawing.Size(230, 49);
            this.cboFarmaceutico.StartIndex = 0;
            this.cboFarmaceutico.TabIndex = 6;
            // 
            // cboProdutos
            // 
            this.cboProdutos.AutoResize = false;
            this.cboProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboProdutos.Depth = 0;
            this.cboProdutos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboProdutos.DropDownHeight = 174;
            this.cboProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutos.DropDownWidth = 121;
            this.cboProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Hint = "Remédios";
            this.cboProdutos.IntegralHeight = false;
            this.cboProdutos.ItemHeight = 43;
            this.cboProdutos.Location = new System.Drawing.Point(5, 22);
            this.cboProdutos.MaxDropDownItems = 4;
            this.cboProdutos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(230, 49);
            this.cboProdutos.StartIndex = 0;
            this.cboProdutos.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.AllowPromptAsInput = true;
            this.txtData.AnimateReadOnly = false;
            this.txtData.AsciiOnly = false;
            this.txtData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtData.BeepOnError = false;
            this.txtData.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.HidePromptOnLeave = false;
            this.txtData.HideSelection = true;
            this.txtData.Hint = "Data da venda";
            this.txtData.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtData.LeadingIcon = null;
            this.txtData.Location = new System.Drawing.Point(19, 76);
            this.txtData.Mask = "99/99/9999";
            this.txtData.MaxLength = 32767;
            this.txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PrefixSuffixText = null;
            this.txtData.PromptChar = '_';
            this.txtData.ReadOnly = false;
            this.txtData.RejectInputOnFirstFailure = false;
            this.txtData.ResetOnPrompt = true;
            this.txtData.ResetOnSpace = true;
            this.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(230, 48);
            this.txtData.SkipLiterals = true;
            this.txtData.TabIndex = 9;
            this.txtData.TabStop = false;
            this.txtData.Text = "  /  /";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.TrailingIcon = null;
            this.txtData.UseSystemPasswordChar = false;
            this.txtData.ValidatingType = null;
            // 
            // txtTotalvenda
            // 
            this.txtTotalvenda.AnimateReadOnly = false;
            this.txtTotalvenda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotalvenda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotalvenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalvenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalvenda.Depth = 0;
            this.txtTotalvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalvenda.HideSelection = true;
            this.txtTotalvenda.Hint = "Valor total";
            this.txtTotalvenda.LeadingIcon = null;
            this.txtTotalvenda.Location = new System.Drawing.Point(274, 77);
            this.txtTotalvenda.MaxLength = 32767;
            this.txtTotalvenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTotalvenda.Name = "txtTotalvenda";
            this.txtTotalvenda.PasswordChar = '\0';
            this.txtTotalvenda.PrefixSuffixText = null;
            this.txtTotalvenda.ReadOnly = false;
            this.txtTotalvenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalvenda.SelectedText = "";
            this.txtTotalvenda.SelectionLength = 0;
            this.txtTotalvenda.SelectionStart = 0;
            this.txtTotalvenda.ShortcutsEnabled = true;
            this.txtTotalvenda.Size = new System.Drawing.Size(230, 48);
            this.txtTotalvenda.TabIndex = 10;
            this.txtTotalvenda.TabStop = false;
            this.txtTotalvenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalvenda.TrailingIcon = null;
            this.txtTotalvenda.UseSystemPasswordChar = false;
            // 
            // txtQnt
            // 
            this.txtQnt.AnimateReadOnly = false;
            this.txtQnt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQnt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQnt.Depth = 0;
            this.txtQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQnt.HideSelection = true;
            this.txtQnt.Hint = "Quantidade";
            this.txtQnt.LeadingIcon = null;
            this.txtQnt.Location = new System.Drawing.Point(274, 23);
            this.txtQnt.MaxLength = 32767;
            this.txtQnt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.PasswordChar = '\0';
            this.txtQnt.PrefixSuffixText = null;
            this.txtQnt.ReadOnly = false;
            this.txtQnt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQnt.SelectedText = "";
            this.txtQnt.SelectionLength = 0;
            this.txtQnt.SelectionStart = 0;
            this.txtQnt.ShortcutsEnabled = true;
            this.txtQnt.Size = new System.Drawing.Size(230, 48);
            this.txtQnt.TabIndex = 11;
            this.txtQnt.TabStop = false;
            this.txtQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQnt.TrailingIcon = null;
            this.txtQnt.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit2
            // 
            this.materialTextBoxEdit2.AnimateReadOnly = false;
            this.materialTextBoxEdit2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBoxEdit2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBoxEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxEdit2.Depth = 0;
            this.materialTextBoxEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEdit2.HideSelection = true;
            this.materialTextBoxEdit2.Hint = "Id da venda";
            this.materialTextBoxEdit2.LeadingIcon = null;
            this.materialTextBoxEdit2.Location = new System.Drawing.Point(19, 22);
            this.materialTextBoxEdit2.MaxLength = 32767;
            this.materialTextBoxEdit2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBoxEdit2.Name = "materialTextBoxEdit2";
            this.materialTextBoxEdit2.PasswordChar = '\0';
            this.materialTextBoxEdit2.PrefixSuffixText = null;
            this.materialTextBoxEdit2.ReadOnly = false;
            this.materialTextBoxEdit2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxEdit2.SelectedText = "";
            this.materialTextBoxEdit2.SelectionLength = 0;
            this.materialTextBoxEdit2.SelectionStart = 0;
            this.materialTextBoxEdit2.ShortcutsEnabled = true;
            this.materialTextBoxEdit2.Size = new System.Drawing.Size(230, 48);
            this.materialTextBoxEdit2.TabIndex = 12;
            this.materialTextBoxEdit2.TabStop = false;
            this.materialTextBoxEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxEdit2.TrailingIcon = null;
            this.materialTextBoxEdit2.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aloneComboBox1);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblProdutos);
            this.groupBox1.Controls.Add(this.txtValoru);
            this.groupBox1.Controls.Add(this.gridVendas);
            this.groupBox1.Controls.Add(this.materialButton1);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtQnt);
            this.groupBox1.Controls.Add(this.cboProdutos);
            this.groupBox1.Controls.Add(this.txtTotalvenda);
            this.groupBox1.Location = new System.Drawing.Point(6, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 433);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do produto";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(109, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 15);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total: 0";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(6, 398);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(71, 15);
            this.lblProdutos.TabIndex = 16;
            this.lblProdutos.Text = "Remédios: 0";
            // 
            // txtValoru
            // 
            this.txtValoru.AnimateReadOnly = false;
            this.txtValoru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValoru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValoru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValoru.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValoru.Depth = 0;
            this.txtValoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValoru.HideSelection = true;
            this.txtValoru.Hint = "Valor unitário";
            this.txtValoru.LeadingIcon = null;
            this.txtValoru.Location = new System.Drawing.Point(5, 77);
            this.txtValoru.MaxLength = 32767;
            this.txtValoru.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtValoru.Name = "txtValoru";
            this.txtValoru.PasswordChar = '\0';
            this.txtValoru.PrefixSuffixText = null;
            this.txtValoru.ReadOnly = false;
            this.txtValoru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValoru.SelectedText = "";
            this.txtValoru.SelectionLength = 0;
            this.txtValoru.SelectionStart = 0;
            this.txtValoru.ShortcutsEnabled = true;
            this.txtValoru.Size = new System.Drawing.Size(230, 48);
            this.txtValoru.TabIndex = 15;
            this.txtValoru.TabStop = false;
            this.txtValoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValoru.TrailingIcon = null;
            this.txtValoru.UseSystemPasswordChar = false;
            // 
            // gridVendas
            // 
            this.gridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendas.Location = new System.Drawing.Point(5, 196);
            this.gridVendas.Name = "gridVendas";
            this.gridVendas.RowTemplate.Height = 25;
            this.gridVendas.Size = new System.Drawing.Size(498, 186);
            this.gridVendas.TabIndex = 14;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(338, 144);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(98, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "Adicionar";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.AnimateReadOnly = false;
            this.txtDesconto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesconto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesconto.Depth = 0;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesconto.HideSelection = true;
            this.txtDesconto.Hint = "Desconto ";
            this.txtDesconto.LeadingIcon = null;
            this.txtDesconto.Location = new System.Drawing.Point(4, 132);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.PasswordChar = '\0';
            this.txtDesconto.PrefixSuffixText = null;
            this.txtDesconto.ReadOnly = false;
            this.txtDesconto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesconto.SelectedText = "";
            this.txtDesconto.SelectionLength = 0;
            this.txtDesconto.SelectionStart = 0;
            this.txtDesconto.ShortcutsEnabled = true;
            this.txtDesconto.Size = new System.Drawing.Size(231, 48);
            this.txtDesconto.TabIndex = 12;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesconto.TrailingIcon = null;
            this.txtDesconto.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.cboCliente);
            this.groupBox2.Controls.Add(this.cboFarmaceutico);
            this.groupBox2.Controls.Add(this.materialTextBoxEdit2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 145);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da venda";
            // 
            // aloneComboBox1
            // 
            this.aloneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.aloneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aloneComboBox1.EnabledCalc = true;
            this.aloneComboBox1.FormattingEnabled = true;
            this.aloneComboBox1.ItemHeight = 20;
            this.aloneComboBox1.Location = new System.Drawing.Point(260, 150);
            this.aloneComboBox1.Name = "aloneComboBox1";
            this.aloneComboBox1.Size = new System.Drawing.Size(64, 26);
            this.aloneComboBox1.TabIndex = 18;
            // 
            // VendaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 762);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VendaCadastro";
            this.Text = "Cadastro de vendas";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboProdutos;
        private ReaLTaiizor.Controls.MaterialComboBox cboFarmaceutico;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalvenda;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQnt;
        private DataGridView gridVendas;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDesconto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValoru;
        private Label lblTotal;
        private Label lblProdutos;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
    }
}