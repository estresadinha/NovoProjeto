namespace projetonovo
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
            this.botao1 = new System.Windows.Forms.Button();
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.botao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botao3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botao1.Location = new System.Drawing.Point(1, 12);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(180, 75);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "clique aqui";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.Location = new System.Drawing.Point(12, 106);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.Size = new System.Drawing.Size(125, 25);
            this.primeiraMensagem.TabIndex = 2;
            this.primeiraMensagem.Text = "mensagem";
            this.primeiraMensagem.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Red;
            this.botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.Location = new System.Drawing.Point(1, 147);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(246, 44);
            this.botao2.TabIndex = 3;
            this.botao2.Text = "clique de novo";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // botao3
            // 
            this.botao3.BackColor = System.Drawing.Color.Navy;
            this.botao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botao3.Location = new System.Drawing.Point(236, 12);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(160, 57);
            this.botao3.TabIndex = 5;
            this.botao3.Text = "clique";
            this.botao3.UseVisualStyleBackColor = false;
            this.botao3.Click += new System.EventHandler(this.botao3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.primeiraMensagem);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label primeiraMensagem;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Label label2;
    }
}

