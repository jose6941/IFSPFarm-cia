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
            txtData = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboFarmaceutico = new ReaLTaiizor.Controls.MaterialComboBox();
            cboProdutos = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Size = new Size(388, 385);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(469, 374);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(cboProdutos);
            tabPage1.Controls.Add(cboFarmaceutico);
            tabPage1.Controls.Add(cboCliente);
            tabPage1.Controls.Add(txtData);
            tabPage1.Size = new Size(380, 357);
            tabPage1.Controls.SetChildIndex(button1, 0);
            tabPage1.Controls.SetChildIndex(txtData, 0);
            tabPage1.Controls.SetChildIndex(cboCliente, 0);
            tabPage1.Controls.SetChildIndex(cboFarmaceutico, 0);
            tabPage1.Controls.SetChildIndex(cboProdutos, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            // 
            // txtData
            // 
            txtData.AnimateReadOnly = false;
            txtData.AutoCompleteMode = AutoCompleteMode.None;
            txtData.AutoCompleteSource = AutoCompleteSource.None;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.CharacterCasing = CharacterCasing.Normal;
            txtData.Depth = 0;
            txtData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HideSelection = true;
            txtData.Hint = "Data da venda";
            txtData.LeadingIcon = null;
            txtData.Location = new Point(67, 21);
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.ReadOnly = false;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(250, 48);
            txtData.TabIndex = 4;
            txtData.TabStop = false;
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(67, 129);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(146, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 5;
            // 
            // cboFarmaceutico
            // 
            cboFarmaceutico.AutoResize = false;
            cboFarmaceutico.BackColor = Color.FromArgb(255, 255, 255);
            cboFarmaceutico.Depth = 0;
            cboFarmaceutico.DrawMode = DrawMode.OwnerDrawVariable;
            cboFarmaceutico.DropDownHeight = 174;
            cboFarmaceutico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFarmaceutico.DropDownWidth = 121;
            cboFarmaceutico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFarmaceutico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFarmaceutico.FormattingEnabled = true;
            cboFarmaceutico.Hint = "Farmaceutico";
            cboFarmaceutico.IntegralHeight = false;
            cboFarmaceutico.ItemHeight = 43;
            cboFarmaceutico.Location = new Point(67, 184);
            cboFarmaceutico.MaxDropDownItems = 4;
            cboFarmaceutico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFarmaceutico.Name = "cboFarmaceutico";
            cboFarmaceutico.Size = new Size(146, 49);
            cboFarmaceutico.StartIndex = 0;
            cboFarmaceutico.TabIndex = 6;
            // 
            // cboProdutos
            // 
            cboProdutos.AutoResize = false;
            cboProdutos.BackColor = Color.FromArgb(255, 255, 255);
            cboProdutos.Depth = 0;
            cboProdutos.DrawMode = DrawMode.OwnerDrawVariable;
            cboProdutos.DropDownHeight = 174;
            cboProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProdutos.DropDownWidth = 121;
            cboProdutos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProdutos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProdutos.FormattingEnabled = true;
            cboProdutos.Hint = "Produtos";
            cboProdutos.IntegralHeight = false;
            cboProdutos.ItemHeight = 43;
            cboProdutos.Location = new Point(67, 239);
            cboProdutos.MaxDropDownItems = 4;
            cboProdutos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProdutos.Name = "cboProdutos";
            cboProdutos.Size = new Size(146, 49);
            cboProdutos.StartIndex = 0;
            cboProdutos.TabIndex = 7;
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
            txtId.Location = new Point(67, 75);
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
            txtId.TabIndex = 8;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // VendaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 452);
            Location = new Point(0, 0);
            Name = "VendaCadastro";
            Text = "Cadastro de vendas";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboProdutos;
        private ReaLTaiizor.Controls.MaterialComboBox cboFarmaceutico;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}