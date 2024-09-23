namespace Corte1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEvaluarEdad = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(365, 26);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(141, 21);
            this.cbCiudad.TabIndex = 0;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(154, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(122, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su nombre:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(154, 88);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(122, 20);
            this.tbApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese su apellido:";
            // 
            // btnEvaluarEdad
            // 
            this.btnEvaluarEdad.Location = new System.Drawing.Point(124, 165);
            this.btnEvaluarEdad.Name = "btnEvaluarEdad";
            this.btnEvaluarEdad.Size = new System.Drawing.Size(83, 40);
            this.btnEvaluarEdad.TabIndex = 5;
            this.btnEvaluarEdad.Text = "Evaluar Edad";
            this.btnEvaluarEdad.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(249, 165);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 44);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(381, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(154, 123);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 8;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtbFechaNacimiento_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 275);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEvaluarEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbCiudad);
            this.Name = "Form1";
            this.Text = "Registro de edades (SAZT)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEvaluarEdad;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}

