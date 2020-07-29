namespace DigiVot_Vista
{
    partial class Vista_Password
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
            this.pnlPartido = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlPartido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPartido
            // 
            this.pnlPartido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlPartido.BorderRadius = 5;
            this.pnlPartido.BorderThickness = 2;
            this.pnlPartido.Controls.Add(this.lblPass);
            this.pnlPartido.Controls.Add(this.txtPass);
            this.pnlPartido.Controls.Add(this.btnActualizar);
            this.pnlPartido.Controls.Add(this.lblContra);
            this.pnlPartido.Controls.Add(this.txtContra);
            this.pnlPartido.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlPartido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.pnlPartido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPartido.ForeColor = System.Drawing.Color.White;
            this.pnlPartido.Location = new System.Drawing.Point(26, 44);
            this.pnlPartido.Name = "pnlPartido";
            this.pnlPartido.ShadowDecoration.Parent = this.pnlPartido;
            this.pnlPartido.Size = new System.Drawing.Size(515, 220);
            this.pnlPartido.TabIndex = 15;
            this.pnlPartido.Text = "Mantenimiento Password";
            this.pnlPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BorderRadius = 22;
            this.btnActualizar.CheckedState.Parent = this.btnActualizar;
            this.btnActualizar.CustomImages.Parent = this.btnActualizar;
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.HoverState.Parent = this.btnActualizar;
            this.btnActualizar.Location = new System.Drawing.Point(206, 167);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ShadowDecoration.Parent = this.btnActualizar;
            this.btnActualizar.Size = new System.Drawing.Size(113, 40);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseTransparentBackground = true;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblContra.Location = new System.Drawing.Point(94, 61);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(127, 18);
            this.lblContra.TabIndex = 4;
            this.lblContra.Text = "Nombre Partido:";
            // 
            // txtContra
            // 
            this.txtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.DefaultText = "";
            this.txtContra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContra.DisabledState.Parent = this.txtContra;
            this.txtContra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContra.FocusedState.Parent = this.txtContra;
            this.txtContra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContra.HoverState.Parent = this.txtContra;
            this.txtContra.Location = new System.Drawing.Point(275, 55);
            this.txtContra.Margin = new System.Windows.Forms.Padding(6);
            this.txtContra.MaxLength = 8;
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.PlaceholderText = "";
            this.txtContra.SelectedText = "";
            this.txtContra.ShadowDecoration.Parent = this.txtContra;
            this.txtContra.Size = new System.Drawing.Size(150, 31);
            this.txtContra.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblPass.Location = new System.Drawing.Point(94, 120);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(127, 18);
            this.lblPass.TabIndex = 24;
            this.lblPass.Text = "Nombre Partido:";
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.Location = new System.Drawing.Point(275, 114);
            this.txtPass.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtPass.MaxLength = 8;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(150, 31);
            this.txtPass.TabIndex = 23;
            // 
            // Vista_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 313);
            this.Controls.Add(this.pnlPartido);
            this.Name = "Vista_Password";
            this.Text = "DigiVot: Password";
            this.pnlPartido.ResumeLayout(false);
            this.pnlPartido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GroupBox pnlPartido;
        public System.Windows.Forms.Label lblPass;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        public Guna.UI2.WinForms.Guna2Button btnActualizar;
        public System.Windows.Forms.Label lblContra;
        public Guna.UI2.WinForms.Guna2TextBox txtContra;
    }
}