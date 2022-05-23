namespace ReponedorCliente.formularios
{
    partial class REGISTRAR
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
            this.button1 = new System.Windows.Forms.Button();
            this.listadatos = new System.Windows.Forms.DataGridView();
            this.regresarbtn = new System.Windows.Forms.Button();
            this.registrarbtn = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listadatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 33;
            this.button1.Text = "LIMPIAR ENTRADAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listadatos
            // 
            this.listadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadatos.Location = new System.Drawing.Point(358, 43);
            this.listadatos.Name = "listadatos";
            this.listadatos.ReadOnly = true;
            this.listadatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadatos.Size = new System.Drawing.Size(670, 377);
            this.listadatos.TabIndex = 32;
            // 
            // regresarbtn
            // 
            this.regresarbtn.Location = new System.Drawing.Point(888, 528);
            this.regresarbtn.Name = "regresarbtn";
            this.regresarbtn.Size = new System.Drawing.Size(140, 34);
            this.regresarbtn.TabIndex = 30;
            this.regresarbtn.Text = "REGRESAR";
            this.regresarbtn.UseVisualStyleBackColor = true;
            this.regresarbtn.Click += new System.EventHandler(this.regresarbtn_Click_1);
            // 
            // registrarbtn
            // 
            this.registrarbtn.Location = new System.Drawing.Point(33, 353);
            this.registrarbtn.Name = "registrarbtn";
            this.registrarbtn.Size = new System.Drawing.Size(141, 34);
            this.registrarbtn.TabIndex = 29;
            this.registrarbtn.Text = "AGREGAR";
            this.registrarbtn.UseVisualStyleBackColor = true;
            this.registrarbtn.Click += new System.EventHandler(this.registrarbtn_Click_1);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(129, 303);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(212, 20);
            this.txtdireccion.TabIndex = 28;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(129, 257);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(212, 20);
            this.txtemail.TabIndex = 27;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(129, 209);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(139, 20);
            this.txttelefono.TabIndex = 26;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(129, 162);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(212, 20);
            this.txtapellido.TabIndex = 25;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(129, 116);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(212, 20);
            this.txtnombre.TabIndex = 24;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(129, 62);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(139, 20);
            this.txtidcliente.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "IDCLIENTE";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // REGISTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listadatos);
            this.Controls.Add(this.regresarbtn);
            this.Controls.Add(this.registrarbtn);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "REGISTRAR";
            this.Text = "REGISTRAR";
            this.Load += new System.EventHandler(this.REGISTRAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listadatos;
        private System.Windows.Forms.Button regresarbtn;
        private System.Windows.Forms.Button registrarbtn;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}