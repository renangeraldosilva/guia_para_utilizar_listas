namespace Aula33
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnAdicionarElementos = new System.Windows.Forms.Button();
            this.btnUnirListas = new System.Windows.Forms.Button();
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.btnRemoverElementos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dicas sobre List";
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(67, 170);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(144, 59);
            this.btnCriar.TabIndex = 1;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAdicionarElementos
            // 
            this.btnAdicionarElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarElementos.Location = new System.Drawing.Point(234, 170);
            this.btnAdicionarElementos.Name = "btnAdicionarElementos";
            this.btnAdicionarElementos.Size = new System.Drawing.Size(144, 59);
            this.btnAdicionarElementos.TabIndex = 1;
            this.btnAdicionarElementos.Text = "Adicionar elemento ";
            this.btnAdicionarElementos.UseVisualStyleBackColor = true;
            this.btnAdicionarElementos.Click += new System.EventHandler(this.btnAdicionarElementos_Click);
            // 
            // btnUnirListas
            // 
            this.btnUnirListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnirListas.Location = new System.Drawing.Point(348, 275);
            this.btnUnirListas.Name = "btnUnirListas";
            this.btnUnirListas.Size = new System.Drawing.Size(144, 59);
            this.btnUnirListas.TabIndex = 1;
            this.btnUnirListas.Text = "Unir listas";
            this.btnUnirListas.UseVisualStyleBackColor = true;
            this.btnUnirListas.Click += new System.EventHandler(this.btnUnirListas_Click);
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizar.Location = new System.Drawing.Point(163, 275);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(144, 59);
            this.btnOrganizar.TabIndex = 1;
            this.btnOrganizar.Text = "Organizar ";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // btnRemoverElementos
            // 
            this.btnRemoverElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverElementos.Location = new System.Drawing.Point(414, 170);
            this.btnRemoverElementos.Name = "btnRemoverElementos";
            this.btnRemoverElementos.Size = new System.Drawing.Size(144, 59);
            this.btnRemoverElementos.TabIndex = 1;
            this.btnRemoverElementos.Text = "Remover elemento";
            this.btnRemoverElementos.UseVisualStyleBackColor = true;
            this.btnRemoverElementos.Click += new System.EventHandler(this.btnRemoverElementos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 394);
            this.Controls.Add(this.btnRemoverElementos);
            this.Controls.Add(this.btnUnirListas);
            this.Controls.Add(this.btnOrganizar);
            this.Controls.Add(this.btnAdicionarElementos);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnAdicionarElementos;
        private System.Windows.Forms.Button btnUnirListas;
        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.Button btnRemoverElementos;
    }
}

