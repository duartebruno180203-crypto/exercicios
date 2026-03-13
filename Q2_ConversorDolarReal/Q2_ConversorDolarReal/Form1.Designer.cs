namespace Q2_ConversorDolarReal
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
            btnconverter = new Button();
            txtdolares = new TextBox();
            txtcotacao = new TextBox();
            lbcotacao = new Label();
            lbdolares = new Label();
            lbresultado = new Label();
            SuspendLayout();
            // 
            // btnconverter
            // 
            btnconverter.Location = new Point(57, 135);
            btnconverter.Name = "btnconverter";
            btnconverter.Size = new Size(125, 23);
            btnconverter.TabIndex = 7;
            btnconverter.Text = "Converter";
            btnconverter.UseVisualStyleBackColor = true;
            btnconverter.Click += btnconverter_Click;
            // 
            // txtdolares
            // 
            txtdolares.Location = new Point(188, 61);
            txtdolares.Name = "txtdolares";
            txtdolares.Size = new Size(69, 23);
            txtdolares.TabIndex = 5;
            // 
            // txtcotacao
            // 
            txtcotacao.Location = new Point(152, 26);
            txtcotacao.Name = "txtcotacao";
            txtcotacao.Size = new Size(69, 23);
            txtcotacao.TabIndex = 6;
            // 
            // lbcotacao
            // 
            lbcotacao.AutoSize = true;
            lbcotacao.Location = new Point(24, 29);
            lbcotacao.Name = "lbcotacao";
            lbcotacao.Size = new Size(122, 15);
            lbcotacao.TabIndex = 3;
            lbcotacao.Text = "Cotação do dólar (R$)";
            // 
            // lbdolares
            // 
            lbdolares.AutoSize = true;
            lbdolares.Location = new Point(21, 69);
            lbdolares.Name = "lbdolares";
            lbdolares.Size = new Size(161, 15);
            lbdolares.TabIndex = 4;
            lbdolares.Text = "Quantidade em dólares (US$)";
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(108, 103);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(28, 15);
            lbresultado.TabIndex = 8;
            lbresultado.Text = "0,00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 254);
            Controls.Add(lbresultado);
            Controls.Add(btnconverter);
            Controls.Add(txtdolares);
            Controls.Add(txtcotacao);
            Controls.Add(lbcotacao);
            Controls.Add(lbdolares);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconverter;
        private TextBox txtdolares;
        private TextBox txtcotacao;
        private Label lbcotacao;
        private Label lbdolares;
        private Label lbresultado;
    }
}
