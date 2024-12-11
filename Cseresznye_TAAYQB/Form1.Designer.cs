namespace Cseresznye_TAAYQB
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
            button1 = new Button();
            button2 = new Button();
            btnKilep = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(109, 179);
            button1.Name = "button1";
            button1.Size = new Size(359, 239);
            button1.TabIndex = 0;
            button1.Text = "API URL ellenörző";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(603, 179);
            button2.Name = "button2";
            button2.Size = new Size(395, 239);
            button2.TabIndex = 1;
            button2.Text = "Stock elemzés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnKilep
            // 
            btnKilep.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKilep.Location = new Point(1064, 539);
            btnKilep.Name = "btnKilep";
            btnKilep.Size = new Size(75, 23);
            btnKilep.TabIndex = 2;
            btnKilep.Text = "&Kilépés";
            btnKilep.UseVisualStyleBackColor = true;
            btnKilep.Click += btnKilep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(377, 79);
            label1.Name = "label1";
            label1.Size = new Size(359, 43);
            label1.TabIndex = 3;
            label1.Text = "Stock elemző program";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 574);
            Controls.Add(label1);
            Controls.Add(btnKilep);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnKilep;
        private Label label1;
    }
}