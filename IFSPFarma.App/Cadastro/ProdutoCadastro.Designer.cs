namespace IFSPFarma.App.Cadastro
{
    partial class ProdutoCadastro
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
            txtValoru = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQnt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtValort = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboRemedio = new ReaLTaiizor.Controls.MaterialComboBox();
            cboFornecedor = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Size = new Size(365, 440);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(357, 412);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(cboFornecedor);
            tabPage1.Controls.Add(cboRemedio);
            tabPage1.Controls.Add(txtValort);
            tabPage1.Controls.Add(txtQnt);
            tabPage1.Controls.Add(txtValoru);
            tabPage1.Size = new Size(357, 412);
            tabPage1.Controls.SetChildIndex(txtValoru, 0);
            tabPage1.Controls.SetChildIndex(txtQnt, 0);
            tabPage1.Controls.SetChildIndex(txtValort, 0);
            tabPage1.Controls.SetChildIndex(cboRemedio, 0);
            tabPage1.Controls.SetChildIndex(cboFornecedor, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            // 
            // txtValoru
            // 
            txtValoru.AnimateReadOnly = false;
            txtValoru.AutoCompleteMode = AutoCompleteMode.None;
            txtValoru.AutoCompleteSource = AutoCompleteSource.None;
            txtValoru.BackgroundImageLayout = ImageLayout.None;
            txtValoru.CharacterCasing = CharacterCasing.Normal;
            txtValoru.Depth = 0;
            txtValoru.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValoru.HideSelection = true;
            txtValoru.Hint = "Valor unitário";
            txtValoru.LeadingIcon = null;
            txtValoru.Location = new Point(57, 21);
            txtValoru.MaxLength = 32767;
            txtValoru.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValoru.Name = "txtValoru";
            txtValoru.PasswordChar = '\0';
            txtValoru.PrefixSuffixText = null;
            txtValoru.ReadOnly = false;
            txtValoru.RightToLeft = RightToLeft.No;
            txtValoru.SelectedText = "";
            txtValoru.SelectionLength = 0;
            txtValoru.SelectionStart = 0;
            txtValoru.ShortcutsEnabled = true;
            txtValoru.Size = new Size(250, 48);
            txtValoru.TabIndex = 4;
            txtValoru.TabStop = false;
            txtValoru.TextAlign = HorizontalAlignment.Left;
            txtValoru.TrailingIcon = null;
            txtValoru.UseSystemPasswordChar = false;
            // 
            // txtQnt
            // 
            txtQnt.AnimateReadOnly = false;
            txtQnt.AutoCompleteMode = AutoCompleteMode.None;
            txtQnt.AutoCompleteSource = AutoCompleteSource.None;
            txtQnt.BackgroundImageLayout = ImageLayout.None;
            txtQnt.CharacterCasing = CharacterCasing.Normal;
            txtQnt.Depth = 0;
            txtQnt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQnt.HideSelection = true;
            txtQnt.Hint = "Quantidade";
            txtQnt.LeadingIcon = null;
            txtQnt.Location = new Point(57, 75);
            txtQnt.MaxLength = 32767;
            txtQnt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQnt.Name = "txtQnt";
            txtQnt.PasswordChar = '\0';
            txtQnt.PrefixSuffixText = null;
            txtQnt.ReadOnly = false;
            txtQnt.RightToLeft = RightToLeft.No;
            txtQnt.SelectedText = "";
            txtQnt.SelectionLength = 0;
            txtQnt.SelectionStart = 0;
            txtQnt.ShortcutsEnabled = true;
            txtQnt.Size = new Size(250, 48);
            txtQnt.TabIndex = 5;
            txtQnt.TabStop = false;
            txtQnt.TextAlign = HorizontalAlignment.Left;
            txtQnt.TrailingIcon = null;
            txtQnt.UseSystemPasswordChar = false;
            // 
            // txtValort
            // 
            txtValort.AnimateReadOnly = false;
            txtValort.AutoCompleteMode = AutoCompleteMode.None;
            txtValort.AutoCompleteSource = AutoCompleteSource.None;
            txtValort.BackgroundImageLayout = ImageLayout.None;
            txtValort.CharacterCasing = CharacterCasing.Normal;
            txtValort.Depth = 0;
            txtValort.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValort.HideSelection = true;
            txtValort.Hint = "Valor total";
            txtValort.LeadingIcon = null;
            txtValort.Location = new Point(57, 129);
            txtValort.MaxLength = 32767;
            txtValort.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValort.Name = "txtValort";
            txtValort.PasswordChar = '\0';
            txtValort.PrefixSuffixText = null;
            txtValort.ReadOnly = false;
            txtValort.RightToLeft = RightToLeft.No;
            txtValort.SelectedText = "";
            txtValort.SelectionLength = 0;
            txtValort.SelectionStart = 0;
            txtValort.ShortcutsEnabled = true;
            txtValort.Size = new Size(250, 48);
            txtValort.TabIndex = 6;
            txtValort.TabStop = false;
            txtValort.TextAlign = HorizontalAlignment.Left;
            txtValort.TrailingIcon = null;
            txtValort.UseSystemPasswordChar = false;
            // 
            // cboRemedio
            // 
            cboRemedio.AutoResize = false;
            cboRemedio.BackColor = Color.FromArgb(255, 255, 255);
            cboRemedio.Depth = 0;
            cboRemedio.DrawMode = DrawMode.OwnerDrawVariable;
            cboRemedio.DropDownHeight = 174;
            cboRemedio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRemedio.DropDownWidth = 121;
            cboRemedio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboRemedio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboRemedio.FormattingEnabled = true;
            cboRemedio.Hint = "Remedio";
            cboRemedio.IntegralHeight = false;
            cboRemedio.ItemHeight = 43;
            cboRemedio.Location = new Point(57, 237);
            cboRemedio.MaxDropDownItems = 4;
            cboRemedio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboRemedio.Name = "cboRemedio";
            cboRemedio.Size = new Size(121, 49);
            cboRemedio.StartIndex = 0;
            cboRemedio.TabIndex = 7;
            // 
            // cboFornecedor
            // 
            cboFornecedor.AutoResize = false;
            cboFornecedor.BackColor = Color.FromArgb(255, 255, 255);
            cboFornecedor.Depth = 0;
            cboFornecedor.DrawMode = DrawMode.OwnerDrawVariable;
            cboFornecedor.DropDownHeight = 174;
            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFornecedor.DropDownWidth = 121;
            cboFornecedor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFornecedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Hint = "Fornecedor";
            cboFornecedor.IntegralHeight = false;
            cboFornecedor.ItemHeight = 43;
            cboFornecedor.Location = new Point(57, 292);
            cboFornecedor.MaxDropDownItems = 4;
            cboFornecedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(121, 49);
            cboFornecedor.StartIndex = 0;
            cboFornecedor.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(57, 183);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(250, 48);
            txtId.TabIndex = 9;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // ProdutoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 507);
            Location = new Point(0, 0);
            Name = "ProdutoCadastro";
            Text = "Cadastro de produtos";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQnt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValoru;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValort;
        private ReaLTaiizor.Controls.MaterialComboBox cboFornecedor;
        private ReaLTaiizor.Controls.MaterialComboBox cboRemedio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}