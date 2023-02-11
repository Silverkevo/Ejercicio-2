namespace Tarea2
{
    partial class Ejercicio
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Nota1TextBox = new System.Windows.Forms.TextBox();
            this.Nota2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nota3TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nota4TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcularAsyncButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota del Primer Parcial";
            // 
            // Nota1TextBox
            // 
            this.Nota1TextBox.Location = new System.Drawing.Point(300, 85);
            this.Nota1TextBox.Name = "Nota1TextBox";
            this.Nota1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota1TextBox.TabIndex = 1;
            // 
            // Nota2TextBox
            // 
            this.Nota2TextBox.Location = new System.Drawing.Point(300, 143);
            this.Nota2TextBox.Name = "Nota2TextBox";
            this.Nota2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota2TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota del Segundo Parcial";
            // 
            // Nota3TextBox
            // 
            this.Nota3TextBox.Location = new System.Drawing.Point(300, 198);
            this.Nota3TextBox.Name = "Nota3TextBox";
            this.Nota3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota3TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota del Tercer Parcial";
            // 
            // Nota4TextBox
            // 
            this.Nota4TextBox.Location = new System.Drawing.Point(300, 253);
            this.Nota4TextBox.Name = "Nota4TextBox";
            this.Nota4TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota4TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota del Cuarto Parcial";
            // 
            // CalcularAsyncButton
            // 
            this.CalcularAsyncButton.Location = new System.Drawing.Point(266, 304);
            this.CalcularAsyncButton.Name = "CalcularAsyncButton";
            this.CalcularAsyncButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularAsyncButton.TabIndex = 8;
            this.CalcularAsyncButton.Text = "Calcular";
            this.CalcularAsyncButton.UseVisualStyleBackColor = true;
            this.CalcularAsyncButton.Click += new System.EventHandler(this.CalcularAsyncButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingrese las notas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio
            // 
            this.AcceptButton = this.CalcularAsyncButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalcularAsyncButton);
            this.Controls.Add(this.Nota4TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nota3TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nota2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nota1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nota1TextBox;
        private System.Windows.Forms.TextBox Nota2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nota3TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nota4TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcularAsyncButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

