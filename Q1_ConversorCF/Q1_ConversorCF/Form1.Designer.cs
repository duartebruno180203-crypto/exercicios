namespace Q1_ConversorCF
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
            lbresultado = new Label();
            lbcelsius = new Label();
            txtcelsius = new TextBox();
            btnconverter = new Button();
            SuspendLayout();
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(174, 27);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(28, 15);
            lbresultado.TabIndex = 0;
            lbresultado.Text = "0,00";
            // 
            // lbcelsius
            // 
            lbcelsius.AutoSize = true;
            lbcelsius.Location = new Point(12, 22);
            lbcelsius.Name = "lbcelsius";
            lbcelsius.Size = new Size(74, 15);
            lbcelsius.TabIndex = 0;
            lbcelsius.Text = "Celsius (Cº) :";
            // 
            // txtcelsius
            // 
            txtcelsius.Location = new Point(90, 19);
            txtcelsius.Name = "txtcelsius";
            txtcelsius.Size = new Size(69, 23);
            txtcelsius.TabIndex = 1;
            // 
            // btnconverter
            // 
            btnconverter.Location = new Point(132, 65);
            btnconverter.Name = "btnconverter";
            btnconverter.Size = new Size(75, 23);
            btnconverter.TabIndex = 2;
            btnconverter.Text = "Converter";
            btnconverter.UseVisualStyleBackColor = true;
            btnconverter.Click += btnconverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 116);
            Controls.Add(btnconverter);
            Controls.Add(txtcelsius);
            Controls.Add(lbcelsius);
            Controls.Add(lbresultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbresultado;
        private Label lbcelsius;
        private TextBox txtcelsius;
        private Button btnconverter;
    }
}
