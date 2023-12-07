namespace IFSPFarma.App.Cadastro
{
    partial class RemedioCadastro
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            label2 = new Label();
            txtId = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            txtTipo = new Guna.UI2.WinForms.Guna2TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            materialTabControl1.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPage1.SuspendLayout();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Size = new Size(408, 296);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(400, 268);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(guna2GroupBox1);
            tabPage1.Size = new Size(400, 268);
            tabPage1.Controls.SetChildIndex(btnCancelar, 0);
            tabPage1.Controls.SetChildIndex(btnSalvar, 0);
            tabPage1.Controls.SetChildIndex(bt, 0);
            tabPage1.Controls.SetChildIndex(btn, 0);
            tabPage1.Controls.SetChildIndex(guna2GroupBox1, 0);
            // 
            // btn
            // 
            btn.DialogResult = DialogResult.None;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.Location = new Point(-720, -129);
            btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            // 
            // bt
            // 
            bt.DialogResult = DialogResult.None;
            bt.DisabledState.BorderColor = Color.DarkGray;
            bt.DisabledState.CustomBorderColor = Color.DarkGray;
            bt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bt.Location = new Point(-833, -129);
            bt.ShadowDecoration.CustomizableEdges = customizableEdges7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(298, 223);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(196, 223);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(94, 223);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(298, 223);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(196, 223);
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.Controls.Add(txtId);
            guna2GroupBox1.Controls.Add(label1);
            guna2GroupBox1.Controls.Add(txtTipo);
            guna2GroupBox1.CustomizableEdges = customizableEdges5;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(36, 17);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GroupBox1.Size = new Size(337, 186);
            guna2GroupBox1.TabIndex = 12;
            guna2GroupBox1.Text = "Medicamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 110);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 13;
            label2.Text = "Id : ";
            // 
            // txtId
            // 
            txtId.CustomizableEdges = customizableEdges1;
            txtId.DefaultText = "";
            txtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtId.Location = new Point(77, 128);
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PlaceholderText = "";
            txtId.SelectedText = "";
            txtId.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtId.Size = new Size(178, 25);
            txtId.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 64);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 11;
            label1.Text = "Tipo de remédio : ";
            // 
            // txtTipo
            // 
            txtTipo.CustomizableEdges = customizableEdges3;
            txtTipo.DefaultText = "";
            txtTipo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTipo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTipo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTipo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTipo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTipo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTipo.Location = new Point(77, 82);
            txtTipo.Name = "txtTipo";
            txtTipo.PasswordChar = '\0';
            txtTipo.PlaceholderText = "";
            txtTipo.SelectedText = "";
            txtTipo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTipo.Size = new Size(178, 25);
            txtTipo.TabIndex = 10;
            // 
            // RemedioCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 363);
            Name = "RemedioCadastro";
            Text = "Medicamentos";
            materialTabControl1.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTipo;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
    }
}