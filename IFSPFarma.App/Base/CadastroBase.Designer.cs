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
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.txtCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            this.gridConsualta = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsualta)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPageConsulta);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(596, 415);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSalvar);
            this.tabPage1.Controls.Add(this.txtCancelar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSalvar
            // 
            this.txtSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalvar.Animated = true;
            this.txtSalvar.AnimatedGIF = true;
            this.txtSalvar.CustomizableEdges = customizableEdges1;
            this.txtSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtSalvar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalvar.ForeColor = System.Drawing.Color.Black;
            this.txtSalvar.Location = new System.Drawing.Point(477, 351);
            this.txtSalvar.Name = "txtSalvar";
            this.txtSalvar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.txtSalvar.Size = new System.Drawing.Size(105, 30);
            this.txtSalvar.TabIndex = 5;
            this.txtSalvar.Text = "Salvar";
            // 
            // txtCancelar
            // 
            this.txtCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCancelar.Animated = true;
            this.txtCancelar.AnimatedGIF = true;
            this.txtCancelar.CustomizableEdges = customizableEdges3;
            this.txtCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtCancelar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCancelar.ForeColor = System.Drawing.Color.Black;
            this.txtCancelar.Location = new System.Drawing.Point(364, 351);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.txtCancelar.Size = new System.Drawing.Size(107, 30);
            this.txtCancelar.TabIndex = 4;
            this.txtCancelar.Text = "Cancelar";
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.btnExcluir);
            this.tabPageConsulta.Controls.Add(this.btnEditar);
            this.tabPageConsulta.Controls.Add(this.btnNovo);
            this.tabPageConsulta.Controls.Add(this.gridConsualta);
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 24);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulta.Size = new System.Drawing.Size(588, 387);
            this.tabPageConsulta.TabIndex = 1;
            this.tabPageConsulta.Text = "Consulta";
            this.tabPageConsulta.UseVisualStyleBackColor = true;
            this.tabPageConsulta.Click += new System.EventHandler(this.tabPageConsulta_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnExcluir.Location = new System.Drawing.Point(505, 345);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(80, 36);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEditar.Location = new System.Drawing.Point(426, 345);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(71, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNovo.Depth = 0;
            this.btnNovo.HighEmphasis = true;
            this.btnNovo.Icon = null;
            this.btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnNovo.Location = new System.Drawing.Point(354, 345);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNovo.Size = new System.Drawing.Size(64, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNovo.UseAccentColor = false;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridConsualta
            // 
            this.gridConsualta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConsualta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsualta.Location = new System.Drawing.Point(6, 6);
            this.gridConsualta.Name = "gridConsualta";
            this.gridConsualta.RowTemplate.Height = 25;
            this.gridConsualta.Size = new System.Drawing.Size(576, 327);
            this.gridConsualta.TabIndex = 0;
            this.gridConsualta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsualta_CellContentClick);
            // 
            // CadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 482);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoHide = false;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "CadastroBase";
            this.Text = "Cadastro base";
            this.Load += new System.EventHandler(this.CadastroBase_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsualta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        protected ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        protected TabPage tabPageConsulta;
        protected DataGridView gridConsualta;
        protected TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Button txtSalvar;
        private Guna.UI2.WinForms.Guna2Button txtCancelar;
    }
}