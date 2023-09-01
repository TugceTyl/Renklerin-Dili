namespace Renklerin_Dili
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 38);
            label1.Name = "label1";
            label1.Size = new Size(274, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Color World";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(52, 128);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 1;
            label2.Text = "İsim:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(134, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 34);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mavi", "Sarı", "Kırmızı", "Siyah", "Beyaz", "Yeşil" });
            comboBox1.Location = new Point(134, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 36);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(31, 201);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 4;
            label3.Text = "Renkler:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(88, 248);
            button1.Name = "button1";
            button1.Size = new Size(169, 55);
            button1.TabIndex = 5;
            button1.Text = "Tamam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(31, 372);
            label4.Name = "label4";
            label4.Size = new Size(34, 28);
            label4.TabIndex = 6;
            label4.Text = "00";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(564, 155);
            button2.Name = "button2";
            button2.Size = new Size(155, 148);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(843, 550);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(255, 128, 128);
            Name = "Form2";
            Text = "Renkler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
    }
}