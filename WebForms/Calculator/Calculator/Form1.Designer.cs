
namespace Calculator
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Div = new System.Windows.Forms.RadioButton();
            this.Mul = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the ist no.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the 2nd no.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(425, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(32, 113);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(44, 17);
            this.Add.TabIndex = 5;
            this.Add.TabStop = true;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.CheckedChanged += new System.EventHandler(this.Add_CheckedChanged);
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.Location = new System.Drawing.Point(289, 113);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(41, 17);
            this.Div.TabIndex = 6;
            this.Div.TabStop = true;
            this.Div.Text = "Div";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.CheckedChanged += new System.EventHandler(this.Div_CheckedChanged);
            // 
            // Mul
            // 
            this.Mul.AutoSize = true;
            this.Mul.Location = new System.Drawing.Point(217, 113);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(42, 17);
            this.Mul.TabIndex = 7;
            this.Mul.TabStop = true;
            this.Mul.Text = "Mul";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.CheckedChanged += new System.EventHandler(this.Mul_CheckedChanged);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(117, 113);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(44, 17);
            this.Sub.TabIndex = 8;
            this.Sub.TabStop = true;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.CheckedChanged += new System.EventHandler(this.Sub_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(425, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Answer";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RadioButton Div;
        private System.Windows.Forms.RadioButton Mul;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

