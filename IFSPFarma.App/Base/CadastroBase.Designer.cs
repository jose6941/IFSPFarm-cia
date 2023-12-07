namespace IFSPFarma.App
{
    partial class CadastroBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btn = new Guna.UI2.WinForms.Guna2Button();
            bt = new Guna.UI2.WinForms.Guna2Button();
            tabPageConsulta = new TabPage();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            gridConsualta = new DataGridView();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridConsualta).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPageConsulta);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(595, 393);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btn);
            tabPage1.Controls.Add(bt);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(587, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.DarkGray;
            btnSalvar.Location = new Point(485, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(96, 39);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += txtSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(383, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 39);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += txtCancelar_Click;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn.Animated = true;
            btn.AnimatedGIF = true;
            btn.CustomizableEdges = customizableEdges1;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.FillColor = Color.LightGray;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn.ForeColor = Color.Black;
            btn.Location = new Point(589, 550);
            btn.Name = "btn";
            btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn.Size = new Size(105, 30);
            btn.TabIndex = 5;
            btn.Text = "Salvar";
            btn.Click += txtSalvar_Click;
            // 
            // bt
            // 
            bt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt.Animated = true;
            bt.AnimatedGIF = true;
            bt.CustomizableEdges = customizableEdges3;
            bt.DisabledState.BorderColor = Color.DarkGray;
            bt.DisabledState.CustomBorderColor = Color.DarkGray;
            bt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bt.FillColor = Color.LightGray;
            bt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt.ForeColor = Color.Black;
            bt.Location = new Point(476, 550);
            bt.Name = "bt";
            bt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            bt.Size = new Size(107, 30);
            bt.TabIndex = 4;
            bt.Text = "Cancelar";
            bt.Click += txtCancelar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(gridConsualta);
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(587, 365);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Click += tabPageConsulta_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.BackColor = Color.DarkGray;
            btnExcluir.Location = new Point(485, 320);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 39);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.BackColor = Color.DarkGray;
            btnNovo.Location = new Point(281, 320);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(96, 39);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.Location = new Point(383, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // gridConsualta
            // 
            gridConsualta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gridConsualta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridConsualta.Location = new Point(0, 0);
            gridConsualta.Name = "gridConsualta";
            gridConsualta.RowTemplate.Height = 25;
            gridConsualta.Size = new Size(584, 286);
            gridConsualta.TabIndex = 12;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 460);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerTabControl = materialTabControl1;
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro base";
            Load += CadastroBase_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridConsualta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        protected ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        protected TabPage tabPageConsulta;
        protected TabPage tabPage1;
        protected internal Guna.UI2.WinForms.Guna2Button btn;
        protected internal Guna.UI2.WinForms.Guna2Button bt;
        protected internal Button btnSalvar;
        protected internal Button btnCancelar;
        protected internal DataGridView gridConsualta;
        protected internal Button btnNovo;
        protected internal Button btnExcluir;
        protected internal Button btnEditar;
    }
}