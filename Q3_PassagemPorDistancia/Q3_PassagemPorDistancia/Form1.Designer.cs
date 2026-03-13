namespace Q3_PassagemPorDistancia
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
            txtValor = new TextBox();
            txtkm = new TextBox();
            txt = new Label();
            lbcalcular = new Button();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.BackColor = SystemColors.Info;
            txtValor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.ForeColor = Color.IndianRed;
            txtValor.Location = new Point(71, 60);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(52, 25);
            txtValor.TabIndex = 9;
            txtValor.Text = "0,00";
            // 
            // txtkm
            // 
            txtkm.BackColor = SystemColors.Info;
            txtkm.Location = new Point(71, 22);
            txtkm.Name = "txtkm";
            txtkm.Size = new Size(65, 23);
            txtkm.TabIndex = 8;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(34, 25);
            txt.Name = "txt";
            txt.Size = new Size(31, 15);
            txt.TabIndex = 6;
            txt.Text = "Km :";
            // 
            // lbcalcular
            // 
            lbcalcular.BackColor = Color.LightYellow;
            lbcalcular.FlatStyle = FlatStyle.Flat;
            lbcalcular.Location = new Point(21, 99);
            lbcalcular.Name = "lbcalcular";
            lbcalcular.Size = new Size(157, 32);
            lbcalcular.TabIndex = 5;
            lbcalcular.Text = "Calcular";
            lbcalcular.UseVisualStyleBackColor = false;
            lbcalcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 141);
            Controls.Add(txtValor);
            Controls.Add(txtkm);
            Controls.Add(txt);
            Controls.Add(lbcalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private TextBox txtkm;
        private Label txt;
        private Button lbcalcular;
    }
}
