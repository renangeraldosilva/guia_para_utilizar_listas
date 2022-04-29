namespace Aula33.Telas
{
    partial class TelaOrganizar
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
            this.listBoxOrganizar = new System.Windows.Forms.ListBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOrganizar
            // 
            this.listBoxOrganizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBoxOrganizar.FormattingEnabled = true;
            this.listBoxOrganizar.Location = new System.Drawing.Point(62, 176);
            this.listBoxOrganizar.Name = "listBoxOrganizar";
            this.listBoxOrganizar.Size = new System.Drawing.Size(172, 225);
            this.listBoxOrganizar.TabIndex = 12;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(283, 311);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(83, 23);
            this.btnReverse.TabIndex = 13;
            this.btnReverse.Text = "Decrescente";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(283, 200);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(83, 23);
            this.btnShort.TabIndex = 13;
            this.btnShort.Text = "Crescente";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // TelaOrganizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 484);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.listBoxOrganizar);
            this.Name = "TelaOrganizar";
            this.Text = "TelaOrganizar";
            this.Load += new System.EventHandler(this.TelaOrganizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrganizar;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnShort;
    }
}