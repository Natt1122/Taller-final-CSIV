namespace Final
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
            this.TbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbape2 = new System.Windows.Forms.TextBox();
            this.Tbape1 = new System.Windows.Forms.TextBox();
            this.Tbnom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(297, 147);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(121, 20);
            this.TbID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "IDENTIFICACIÓN";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(333, 253);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(104, 30);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(333, 202);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(104, 30);
            this.BtnBuscar.TabIndex = 20;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(157, 253);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(104, 30);
            this.BtnModificar.TabIndex = 19;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(157, 202);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(104, 30);
            this.BtnCrear.TabIndex = 18;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "SEGUNDO APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PRIMER APELLIDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "NOMBRE";
            // 
            // Tbape2
            // 
            this.Tbape2.Location = new System.Drawing.Point(297, 108);
            this.Tbape2.Name = "Tbape2";
            this.Tbape2.Size = new System.Drawing.Size(121, 20);
            this.Tbape2.TabIndex = 14;
            // 
            // Tbape1
            // 
            this.Tbape1.Location = new System.Drawing.Point(297, 71);
            this.Tbape1.Name = "Tbape1";
            this.Tbape1.Size = new System.Drawing.Size(121, 20);
            this.Tbape1.TabIndex = 13;
            // 
            // Tbnom
            // 
            this.Tbnom.Location = new System.Drawing.Point(297, 29);
            this.Tbnom.Name = "Tbnom";
            this.Tbnom.Size = new System.Drawing.Size(121, 20);
            this.Tbnom.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 307);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbape2);
            this.Controls.Add(this.Tbape1);
            this.Controls.Add(this.Tbnom);
            this.Name = "Form1";
            this.Text = "Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbape2;
        private System.Windows.Forms.TextBox Tbape1;
        private System.Windows.Forms.TextBox Tbnom;
    }
}

