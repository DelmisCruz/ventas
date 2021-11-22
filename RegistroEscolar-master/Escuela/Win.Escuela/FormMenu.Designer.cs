namespace Win.Escuela
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMaestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturasDeMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escuelaToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(521, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escuelaToolStripMenuItem
            // 
            this.escuelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.maestroToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.facturaMaestrosToolStripMenuItem});
            this.escuelaToolStripMenuItem.Name = "escuelaToolStripMenuItem";
            this.escuelaToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.escuelaToolStripMenuItem.Text = "Escuela";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.estudianteToolStripMenuItem_Click);
            // 
            // maestroToolStripMenuItem
            // 
            this.maestroToolStripMenuItem.Name = "maestroToolStripMenuItem";
            this.maestroToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.maestroToolStripMenuItem.Text = "Maestro";
            this.maestroToolStripMenuItem.Click += new System.EventHandler(this.maestroToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.facturaToolStripMenuItem.Text = "Factura Estudiantes";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // facturaMaestrosToolStripMenuItem
            // 
            this.facturaMaestrosToolStripMenuItem.Name = "facturaMaestrosToolStripMenuItem";
            this.facturaMaestrosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.facturaMaestrosToolStripMenuItem.Text = "Factura Maestros";
            this.facturaMaestrosToolStripMenuItem.Click += new System.EventHandler(this.facturaMaestrosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeEstudianteToolStripMenuItem,
            this.reporteDeMaestroToolStripMenuItem,
            this.reporteDeFacturaDeEstudiantesToolStripMenuItem,
            this.reporteDeFacturasDeMaestrosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reporteDeEstudianteToolStripMenuItem
            // 
            this.reporteDeEstudianteToolStripMenuItem.Name = "reporteDeEstudianteToolStripMenuItem";
            this.reporteDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reporteDeEstudianteToolStripMenuItem.Text = "Reporte de Estudiante";
            this.reporteDeEstudianteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEstudianteToolStripMenuItem_Click);
            // 
            // reporteDeMaestroToolStripMenuItem
            // 
            this.reporteDeMaestroToolStripMenuItem.Name = "reporteDeMaestroToolStripMenuItem";
            this.reporteDeMaestroToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reporteDeMaestroToolStripMenuItem.Text = "Reporte de Maestro";
            this.reporteDeMaestroToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMaestroToolStripMenuItem_Click);
            // 
            // reporteDeFacturaDeEstudiantesToolStripMenuItem
            // 
            this.reporteDeFacturaDeEstudiantesToolStripMenuItem.Name = "reporteDeFacturaDeEstudiantesToolStripMenuItem";
            this.reporteDeFacturaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reporteDeFacturaDeEstudiantesToolStripMenuItem.Text = "Reporte de Factura de Estudiantes";
            this.reporteDeFacturaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturaDeEstudiantesToolStripMenuItem_Click);
            // 
            // reporteDeFacturasDeMaestrosToolStripMenuItem
            // 
            this.reporteDeFacturasDeMaestrosToolStripMenuItem.Name = "reporteDeFacturasDeMaestrosToolStripMenuItem";
            this.reporteDeFacturasDeMaestrosToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reporteDeFacturasDeMaestrosToolStripMenuItem.Text = "Reporte de Facturas de Maestros";
            this.reporteDeFacturasDeMaestrosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasDeMaestrosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escuelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMaestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaMaestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturasDeMaestrosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}