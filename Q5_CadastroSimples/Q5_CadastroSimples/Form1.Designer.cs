namespace Q5_CadastroSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCadastroNome = new TextBox();
            txtCadastroSenha = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(149, 57);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Cadrastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 94);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 126);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Senha :";
            // 
            // txtCadastroNome
            // 
            txtCadastroNome.Location = new Point(149, 91);
            txtCadastroNome.Name = "txtCadastroNome";
            txtCadastroNome.Size = new Size(100, 23);
            txtCadastroNome.TabIndex = 1;
            // 
            // txtCadastroSenha
            // 
            txtCadastroSenha.Location = new Point(149, 120);
            txtCadastroSenha.Name = "txtCadastroSenha";
            txtCadastroSenha.Size = new Size(100, 23);
            txtCadastroSenha.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(149, 177);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 230);
            Controls.Add(button1);
            Controls.Add(txtCadastroSenha);
            Controls.Add(txtCadastroNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCadastroNome;
        private TextBox txtCadastroSenha;
        private Button button1;
    }
}
