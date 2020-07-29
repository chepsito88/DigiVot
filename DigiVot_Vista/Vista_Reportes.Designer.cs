namespace DigiVot_Vista
{
    partial class Vista_Reportes
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
            this.rptELecciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptELecciones
            // 
            this.rptELecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptELecciones.Location = new System.Drawing.Point(0, 0);
            this.rptELecciones.Name = "rptELecciones";
            this.rptELecciones.ServerReport.BearerToken = null;
            this.rptELecciones.Size = new System.Drawing.Size(1009, 621);
            this.rptELecciones.TabIndex = 0;
            // 
            // Vista_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.rptELecciones);
            this.Name = "Vista_Reportes";
            this.Text = "DigiVot: Reportes";
            this.Load += new System.EventHandler(this.Vista_Reportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rptELecciones;
    }
}