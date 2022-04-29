namespace Aula33.Telas
{
    partial class TelaAdicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomeDigitado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para adicionar um elemento (ex: texto) use o comando .Add()";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 231);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNomeDigitado
            // 
            this.txtNomeDigitado.Location = new System.Drawing.Point(12, 183);
            this.txtNomeDigitado.Name = "txtNomeDigitado";
            this.txtNomeDigitado.Size = new System.Drawing.Size(201, 20);
            this.txtNomeDigitado.TabIndex = 3;
            this.txtNomeDigitado.TextChanged += new System.EventHandler(this.txtNomeDigitado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite algo para ser guardado na \"Lista\" ";
            // 
            // txtBoxLista
            // 
            this.txtBoxLista.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBoxLista.FormattingEnabled = true;
            this.txtBoxLista.Location = new System.Drawing.Point(329, 155);
            this.txtBoxLista.Name = "txtBoxLista";
            this.txtBoxLista.Size = new System.Drawing.Size(172, 225);
            this.txtBoxLista.TabIndex = 5;
            this.txtBoxLista.SelectedIndexChanged += new System.EventHandler(this.txtBoxLista_SelectedIndexChanged);
            // 
            // TelaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 426);
            this.Controls.Add(this.txtBoxLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeDigitado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAdicionar";
            this.Text = "Adicionar elemento";
            this.Load += new System.EventHandler(this.TelaAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNomeDigitado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox txtBoxLista;
    }
}