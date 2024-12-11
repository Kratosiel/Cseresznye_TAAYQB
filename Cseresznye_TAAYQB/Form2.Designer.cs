namespace Cseresznye_TAAYQB
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(1011, 520);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "&Vissza";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 49);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "URL megadása";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(67, 153);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(334, 261);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(522, 153);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(319, 261);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(306, 76);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "mehet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 118);
            label2.Name = "label2";
            label2.Size = new Size(195, 15);
            label2.TabIndex = 6;
            label2.Text = "A korrekt formának így kell kinéznie";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 555);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button2;
        private Label label2;
    }
}