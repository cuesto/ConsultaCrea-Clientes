namespace ConsultaCrea_Cliente
{
    partial class Form1
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
            this.mTxtRNC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtRegimenDePago = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarRNC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.CmbGrupos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mTxtRNC
            // 
            this.mTxtRNC.Location = new System.Drawing.Point(110, 13);
            this.mTxtRNC.Mask = "00000000000";
            this.mTxtRNC.Name = "mTxtRNC";
            this.mTxtRNC.PromptChar = ' ';
            this.mTxtRNC.Size = new System.Drawing.Size(152, 20);
            this.mTxtRNC.TabIndex = 0;
            this.mTxtRNC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxtRNC_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RNC/Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(110, 49);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 37);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Enabled = false;
            this.txtNombreComercial.Location = new System.Drawing.Point(110, 92);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(152, 20);
            this.txtNombreComercial.TabIndex = 3;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(110, 118);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(152, 20);
            this.txtCategoria.TabIndex = 3;
            // 
            // txtRegimenDePago
            // 
            this.txtRegimenDePago.Enabled = false;
            this.txtRegimenDePago.Location = new System.Drawing.Point(110, 144);
            this.txtRegimenDePago.Name = "txtRegimenDePago";
            this.txtRegimenDePago.Size = new System.Drawing.Size(152, 20);
            this.txtRegimenDePago.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(110, 170);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(152, 20);
            this.txtEstado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Comercial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Regimen de Pago";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Estado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBuscarRNC
            // 
            this.btnBuscarRNC.Location = new System.Drawing.Point(172, 196);
            this.btnBuscarRNC.Name = "btnBuscarRNC";
            this.btnBuscarRNC.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarRNC.TabIndex = 4;
            this.btnBuscarRNC.Text = "Consultar DGII";
            this.btnBuscarRNC.UseVisualStyleBackColor = true;
            this.btnBuscarRNC.Click += new System.EventHandler(this.btnBuscarRNC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "&Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mTxtRNC);
            this.groupBox1.Controls.Add(this.btnBuscarRNC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.txtRegimenDePago);
            this.groupBox1.Controls.Add(this.txtNombreComercial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DGII";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtId);
            this.groupBox2.Controls.Add(this.CmbGrupos);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ivend";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(110, 25);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 7;
            // 
            // CmbGrupos
            // 
            this.CmbGrupos.FormattingEnabled = true;
            this.CmbGrupos.Location = new System.Drawing.Point(110, 58);
            this.CmbGrupos.Name = "CmbGrupos";
            this.CmbGrupos.Size = new System.Drawing.Size(152, 21);
            this.CmbGrupos.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Id Cliente";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Grupo de Clientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ConsultaCrea Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTxtRNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtRegimenDePago;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarRNC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbGrupos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label8;
    }
}

