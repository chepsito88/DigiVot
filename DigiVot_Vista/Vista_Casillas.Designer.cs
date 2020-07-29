namespace DigiVot_Vista
{
    partial class Vista_Casillas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCasilla = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCasilla = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.grpOperaciones = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlListaCasillas = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgCasilla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlUbicacion = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtEstado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLocalidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtMesa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.txtMunicipio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtClaveMesa = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.erpAviso = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlCasilla.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.pnlListaCasillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCasilla)).BeginInit();
            this.pnlUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCasilla
            // 
            this.pnlCasilla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlCasilla.BorderRadius = 5;
            this.pnlCasilla.BorderThickness = 2;
            this.pnlCasilla.Controls.Add(this.txtNombre);
            this.pnlCasilla.Controls.Add(this.txtIp);
            this.pnlCasilla.Controls.Add(this.lblCasilla);
            this.pnlCasilla.Controls.Add(this.lblIp);
            this.pnlCasilla.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlCasilla.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.pnlCasilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCasilla.ForeColor = System.Drawing.Color.White;
            this.pnlCasilla.Location = new System.Drawing.Point(70, 15);
            this.pnlCasilla.Name = "pnlCasilla";
            this.pnlCasilla.ShadowDecoration.Parent = this.pnlCasilla;
            this.pnlCasilla.Size = new System.Drawing.Size(184, 229);
            this.pnlCasilla.TabIndex = 46;
            this.pnlCasilla.Text = "Datos Casilla:";
            this.pnlCasilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCasilla
            // 
            this.lblCasilla.AutoSize = true;
            this.lblCasilla.BackColor = System.Drawing.Color.Transparent;
            this.lblCasilla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblCasilla.Location = new System.Drawing.Point(64, 57);
            this.lblCasilla.Name = "lblCasilla";
            this.lblCasilla.Size = new System.Drawing.Size(62, 18);
            this.lblCasilla.TabIndex = 46;
            this.lblCasilla.Text = "Casilla:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.BackColor = System.Drawing.Color.Transparent;
            this.lblIp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblIp.Location = new System.Drawing.Point(51, 124);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(88, 18);
            this.lblIp.TabIndex = 45;
            this.lblIp.Text = "Ip Address:";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpOperaciones.BorderRadius = 5;
            this.grpOperaciones.BorderThickness = 2;
            this.grpOperaciones.Controls.Add(this.btnLimpiar);
            this.grpOperaciones.Controls.Add(this.btnEliminar);
            this.grpOperaciones.Controls.Add(this.btnEditar);
            this.grpOperaciones.Controls.Add(this.btnGuardar);
            this.grpOperaciones.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpOperaciones.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.grpOperaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperaciones.ForeColor = System.Drawing.Color.White;
            this.grpOperaciones.Location = new System.Drawing.Point(70, 274);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.ShadowDecoration.Parent = this.grpOperaciones;
            this.grpOperaciones.Size = new System.Drawing.Size(184, 329);
            this.grpOperaciones.TabIndex = 45;
            this.grpOperaciones.Text = "Operaciones";
            this.grpOperaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BorderRadius = 22;
            this.btnLimpiar.CheckedState.Parent = this.btnLimpiar;
            this.btnLimpiar.CustomImages.Parent = this.btnLimpiar;
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.HoverState.Parent = this.btnLimpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(51, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.Parent = this.btnLimpiar;
            this.btnLimpiar.Size = new System.Drawing.Size(88, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 22;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(51, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(88, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderRadius = 22;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(51, 133);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(88, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Modificar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 22;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(51, 68);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(88, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            // 
            // pnlListaCasillas
            // 
            this.pnlListaCasillas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlListaCasillas.BorderRadius = 5;
            this.pnlListaCasillas.BorderThickness = 2;
            this.pnlListaCasillas.Controls.Add(this.dtgCasilla);
            this.pnlListaCasillas.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlListaCasillas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.pnlListaCasillas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlListaCasillas.ForeColor = System.Drawing.Color.White;
            this.pnlListaCasillas.Location = new System.Drawing.Point(291, 274);
            this.pnlListaCasillas.Name = "pnlListaCasillas";
            this.pnlListaCasillas.ShadowDecoration.Parent = this.pnlListaCasillas;
            this.pnlListaCasillas.Size = new System.Drawing.Size(590, 327);
            this.pnlListaCasillas.TabIndex = 44;
            this.pnlListaCasillas.Text = "Listado de Casillas";
            this.pnlListaCasillas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgCasilla
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgCasilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCasilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCasilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgCasilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCasilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgCasilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCasilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCasilla.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCasilla.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCasilla.EnableHeadersVisualStyles = false;
            this.dtgCasilla.GridColor = System.Drawing.Color.White;
            this.dtgCasilla.Location = new System.Drawing.Point(19, 48);
            this.dtgCasilla.MultiSelect = false;
            this.dtgCasilla.Name = "dtgCasilla";
            this.dtgCasilla.ReadOnly = true;
            this.dtgCasilla.RowHeadersVisible = false;
            this.dtgCasilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCasilla.Size = new System.Drawing.Size(549, 262);
            this.dtgCasilla.TabIndex = 30;
            this.dtgCasilla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgCasilla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCasilla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgCasilla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgCasilla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgCasilla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgCasilla.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgCasilla.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgCasilla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.dtgCasilla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCasilla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCasilla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCasilla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgCasilla.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgCasilla.ThemeStyle.ReadOnly = true;
            this.dtgCasilla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.dtgCasilla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgCasilla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCasilla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCasilla.ThemeStyle.RowsStyle.Height = 22;
            this.dtgCasilla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCasilla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlUbicacion
            // 
            this.pnlUbicacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlUbicacion.BorderRadius = 5;
            this.pnlUbicacion.BorderThickness = 2;
            this.pnlUbicacion.Controls.Add(this.txtClaveMesa);
            this.pnlUbicacion.Controls.Add(this.lblClave);
            this.pnlUbicacion.Controls.Add(this.txtEstado);
            this.pnlUbicacion.Controls.Add(this.txtLocalidad);
            this.pnlUbicacion.Controls.Add(this.lblEstado);
            this.pnlUbicacion.Controls.Add(this.lblLocalidad);
            this.pnlUbicacion.Controls.Add(this.txtMesa);
            this.pnlUbicacion.Controls.Add(this.lblMesa);
            this.pnlUbicacion.Controls.Add(this.txtMunicipio);
            this.pnlUbicacion.Controls.Add(this.lblMunicipio);
            this.pnlUbicacion.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlUbicacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.pnlUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUbicacion.ForeColor = System.Drawing.Color.White;
            this.pnlUbicacion.Location = new System.Drawing.Point(291, 15);
            this.pnlUbicacion.Name = "pnlUbicacion";
            this.pnlUbicacion.ShadowDecoration.Parent = this.pnlUbicacion;
            this.pnlUbicacion.Size = new System.Drawing.Size(590, 229);
            this.pnlUbicacion.TabIndex = 43;
            this.pnlUbicacion.Text = "Ubicacion Casilla";
            this.pnlUbicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblClave.Location = new System.Drawing.Point(108, 57);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(158, 18);
            this.lblClave.TabIndex = 40;
            this.lblClave.Text = "Ingrese Clave Mesa:";
            // 
            // txtEstado
            // 
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.DefaultText = "";
            this.txtEstado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstado.DisabledState.Parent = this.txtEstado;
            this.txtEstado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstado.Enabled = false;
            this.txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.FocusedState.Parent = this.txtEstado;
            this.txtEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.HoverState.Parent = this.txtEstado;
            this.txtEstado.Location = new System.Drawing.Point(383, 179);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(243, 189, 243, 189);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.PlaceholderText = "Estado";
            this.txtEstado.SelectedText = "";
            this.txtEstado.ShadowDecoration.Parent = this.txtEstado;
            this.txtEstado.Size = new System.Drawing.Size(150, 31);
            this.txtEstado.TabIndex = 50;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalidad.DefaultText = "";
            this.txtLocalidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocalidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocalidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalidad.DisabledState.Parent = this.txtLocalidad;
            this.txtLocalidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocalidad.FocusedState.Parent = this.txtLocalidad;
            this.txtLocalidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocalidad.HoverState.Parent = this.txtLocalidad;
            this.txtLocalidad.Location = new System.Drawing.Point(53, 179);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(162, 129, 162, 129);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.PasswordChar = '\0';
            this.txtLocalidad.PlaceholderText = "Localidad Casilla";
            this.txtLocalidad.SelectedText = "";
            this.txtLocalidad.ShadowDecoration.Parent = this.txtLocalidad;
            this.txtLocalidad.Size = new System.Drawing.Size(150, 31);
            this.txtLocalidad.TabIndex = 50;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblEstado.Location = new System.Drawing.Point(425, 157);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 18);
            this.lblEstado.TabIndex = 45;
            this.lblEstado.Text = "Estado:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblLocalidad.Location = new System.Drawing.Point(85, 157);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(87, 18);
            this.lblLocalidad.TabIndex = 45;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtMesa
            // 
            this.txtMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMesa.DefaultText = "";
            this.txtMesa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMesa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMesa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMesa.DisabledState.Parent = this.txtMesa;
            this.txtMesa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMesa.Enabled = false;
            this.txtMesa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMesa.FocusedState.Parent = this.txtMesa;
            this.txtMesa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMesa.HoverState.Parent = this.txtMesa;
            this.txtMesa.Location = new System.Drawing.Point(53, 123);
            this.txtMesa.Margin = new System.Windows.Forms.Padding(162, 129, 162, 129);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.PasswordChar = '\0';
            this.txtMesa.PlaceholderText = "Municipio";
            this.txtMesa.SelectedText = "";
            this.txtMesa.ShadowDecoration.Parent = this.txtMesa;
            this.txtMesa.Size = new System.Drawing.Size(150, 31);
            this.txtMesa.TabIndex = 50;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblMesa.Location = new System.Drawing.Point(102, 98);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(52, 18);
            this.lblMesa.TabIndex = 45;
            this.lblMesa.Text = "Mesa:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMunicipio.DefaultText = "";
            this.txtMunicipio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMunicipio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMunicipio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMunicipio.DisabledState.Parent = this.txtMunicipio;
            this.txtMunicipio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMunicipio.Enabled = false;
            this.txtMunicipio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMunicipio.FocusedState.Parent = this.txtMunicipio;
            this.txtMunicipio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMunicipio.HoverState.Parent = this.txtMunicipio;
            this.txtMunicipio.Location = new System.Drawing.Point(383, 123);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(108, 88, 108, 88);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.PasswordChar = '\0';
            this.txtMunicipio.PlaceholderText = "Municipio";
            this.txtMunicipio.SelectedText = "";
            this.txtMunicipio.ShadowDecoration.Parent = this.txtMunicipio;
            this.txtMunicipio.Size = new System.Drawing.Size(150, 31);
            this.txtMunicipio.TabIndex = 50;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.lblMunicipio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblMunicipio.Location = new System.Drawing.Point(412, 98);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(86, 18);
            this.lblMunicipio.TabIndex = 45;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // txtClaveMesa
            // 
            this.txtClaveMesa.Location = new System.Drawing.Point(274, 51);
            this.txtClaveMesa.MaxLength = 3;
            this.txtClaveMesa.Name = "txtClaveMesa";
            this.txtClaveMesa.Size = new System.Drawing.Size(140, 27);
            this.txtClaveMesa.TabIndex = 51;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(20, 146);
            this.txtIp.MaxLength = 15;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(140, 27);
            this.txtIp.TabIndex = 51;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 77);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 27);
            this.txtNombre.TabIndex = 51;
            // 
            // erpAviso
            // 
            this.erpAviso.ContainerControl = this;
            // 
            // Vista_Casillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(955, 618);
            this.Controls.Add(this.pnlCasilla);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.pnlListaCasillas);
            this.Controls.Add(this.pnlUbicacion);
            this.Name = "Vista_Casillas";
            this.Text = "DigiVot: Casillas";
            this.pnlCasilla.ResumeLayout(false);
            this.pnlCasilla.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.pnlListaCasillas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCasilla)).EndInit();
            this.pnlUbicacion.ResumeLayout(false);
            this.pnlUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpAviso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GroupBox pnlCasilla;
        public System.Windows.Forms.Label lblCasilla;
        public System.Windows.Forms.Label lblIp;
        public Guna.UI2.WinForms.Guna2GroupBox grpOperaciones;
        public Guna.UI2.WinForms.Guna2Button btnLimpiar;
        public Guna.UI2.WinForms.Guna2Button btnEliminar;
        public Guna.UI2.WinForms.Guna2Button btnEditar;
        public Guna.UI2.WinForms.Guna2Button btnGuardar;
        public Guna.UI2.WinForms.Guna2GroupBox pnlListaCasillas;
        public Guna.UI2.WinForms.Guna2DataGridView dtgCasilla;
        public Guna.UI2.WinForms.Guna2GroupBox pnlUbicacion;
        public System.Windows.Forms.Label lblClave;
        public Guna.UI2.WinForms.Guna2TextBox txtEstado;
        public Guna.UI2.WinForms.Guna2TextBox txtLocalidad;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.Label lblLocalidad;
        public Guna.UI2.WinForms.Guna2TextBox txtMunicipio;
        public System.Windows.Forms.Label lblMunicipio;
        public Guna.UI2.WinForms.Guna2TextBox txtMesa;
        public System.Windows.Forms.Label lblMesa;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIp;
        public System.Windows.Forms.TextBox txtClaveMesa;
        public System.Windows.Forms.ErrorProvider erpAviso;
    }
}