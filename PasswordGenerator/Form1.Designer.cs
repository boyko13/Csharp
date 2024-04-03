namespace Passwordgenerator
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
            Passwordlabel = new Label();
            Passwordlenghtlabel = new Label();
            passwordlenghtSlider = new TrackBar();
            copyButton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)passwordlenghtSlider).BeginInit();
            SuspendLayout();
            // 
            // Passwordlabel
            // 
            Passwordlabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Passwordlabel.Location = new Point(169, 27);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(551, 70);
            Passwordlabel.TabIndex = 0;
            Passwordlabel.Text = "label1";
            Passwordlabel.TextAlign = ContentAlignment.MiddleCenter;
            Passwordlabel.Click += label1_Click;
            // 
            // Passwordlenghtlabel
            // 
            Passwordlenghtlabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Passwordlenghtlabel.Location = new Point(169, 218);
            Passwordlenghtlabel.Name = "Passwordlenghtlabel";
            Passwordlenghtlabel.Size = new Size(551, 70);
            Passwordlenghtlabel.TabIndex = 1;
            Passwordlenghtlabel.Text = "Password lenght: 5";
            Passwordlenghtlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordlenghtSlider
            // 
            passwordlenghtSlider.Location = new Point(169, 316);
            passwordlenghtSlider.Name = "passwordlenghtSlider";
            passwordlenghtSlider.Size = new Size(551, 45);
            passwordlenghtSlider.TabIndex = 2;
            passwordlenghtSlider.Scroll += passwordlenghtSlider_Scroll;
            // 
            // copyButton1
            // 
            copyButton1.BackColor = SystemColors.Control;
            copyButton1.BackgroundImageLayout = ImageLayout.None;
            copyButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            copyButton1.Location = new Point(169, 367);
            copyButton1.Name = "copyButton1";
            copyButton1.Size = new Size(551, 45);
            copyButton1.TabIndex = 3;
            copyButton1.Text = "Copy Password";
            copyButton1.UseVisualStyleBackColor = false;
            copyButton1.Click += copyButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(851, 490);
            Controls.Add(copyButton1);
            Controls.Add(passwordlenghtSlider);
            Controls.Add(Passwordlenghtlabel);
            Controls.Add(Passwordlabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Password Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)passwordlenghtSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Passwordlabel;
        private Label Passwordlenghtlabel;
        private TrackBar passwordlenghtSlider;
        private Button copyButton1;
    }
}
