namespace FormsExercício3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.txtDiagonal = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaValor = new System.Windows.Forms.Label();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(251, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de área de quadrado";
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonal.Location = new System.Drawing.Point(197, 142);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(72, 20);
            this.lblDiagonal.TabIndex = 1;
            this.lblDiagonal.Text = "Diagonal";
            // 
            // txtDiagonal
            // 
            this.txtDiagonal.Location = new System.Drawing.Point(311, 142);
            this.txtDiagonal.Name = "txtDiagonal";
            this.txtDiagonal.Size = new System.Drawing.Size(280, 20);
            this.txtDiagonal.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(197, 185);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Área:";
            // 
            // lblAreaValor
            // 
            this.lblAreaValor.AutoSize = true;
            this.lblAreaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaValor.Location = new System.Drawing.Point(307, 185);
            this.lblAreaValor.Name = "lblAreaValor";
            this.lblAreaValor.Size = new System.Drawing.Size(51, 20);
            this.lblAreaValor.TabIndex = 6;
            this.lblAreaValor.Text = "label5";
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularArea.Location = new System.Drawing.Point(351, 232);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(97, 30);
            this.btnCalcularArea.TabIndex = 7;
            this.btnCalcularArea.Text = "Calcular";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.clickou_calcular_area);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.lblAreaValor);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtDiagonal);
            this.Controls.Add(this.lblDiagonal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.TextBox txtDiagonal;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreaValor;
        private System.Windows.Forms.Button btnCalcularArea;
    }
}

