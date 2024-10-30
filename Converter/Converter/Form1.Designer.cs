namespace Converter
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
            ConvertButton = new Label();
            a1 = new CheckBox();
            b2 = new CheckBox();
            c3 = new CheckBox();
            d4 = new CheckBox();
            e5 = new CheckBox();
            SuspendLayout();
            // 
            // ConvertButton
            // 
            ConvertButton.AutoSize = true;
            ConvertButton.Location = new Point(193, 39);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(85, 15);
            ConvertButton.TabIndex = 0;
            ConvertButton.Text = "ConvertButton";
            ConvertButton.Click += ConvertButton_Click;
            // 
            // a1
            // 
            a1.AutoSize = true;
            a1.Location = new Point(92, 38);
            a1.Name = "a1";
            a1.Size = new Size(83, 19);
            a1.TabIndex = 1;
            a1.Text = "checkBox1";
            a1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.Location = new Point(92, 63);
            b2.Name = "b2";
            b2.Size = new Size(83, 19);
            b2.TabIndex = 2;
            b2.Text = "checkBox2";
            b2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            c3.AutoSize = true;
            c3.Location = new Point(92, 88);
            c3.Name = "c3";
            c3.Size = new Size(83, 19);
            c3.TabIndex = 3;
            c3.Text = "checkBox3";
            c3.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            d4.AutoSize = true;
            d4.Location = new Point(92, 113);
            d4.Name = "d4";
            d4.Size = new Size(83, 19);
            d4.TabIndex = 4;
            d4.Text = "checkBox4";
            d4.UseVisualStyleBackColor = true;
            // 
            // e5
            // 
            e5.AutoSize = true;
            e5.Location = new Point(92, 138);
            e5.Name = "e5";
            e5.Size = new Size(83, 19);
            e5.TabIndex = 5;
            e5.Text = "checkBox5";
            e5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 553);
            Controls.Add(e5);
            Controls.Add(d4);
            Controls.Add(c3);
            Controls.Add(b2);
            Controls.Add(a1);
            Controls.Add(ConvertButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConvertButton;
        private CheckBox a1;
        private CheckBox b2;
        private CheckBox c3;
        private CheckBox d4;
        private CheckBox e5;
    }
}
