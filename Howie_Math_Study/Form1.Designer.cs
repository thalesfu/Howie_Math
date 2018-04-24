namespace Howie_Math_Study
{
    partial class Form1
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
            this.Generate10AddXButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionCountbox = new System.Windows.Forms.TextBox();
            this.Generate9AddXButton = new System.Windows.Forms.Button();
            this.Generate8AddXButton = new System.Windows.Forms.Button();
            this.Generate10SubtractionXButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate10AddXButton
            // 
            this.Generate10AddXButton.Location = new System.Drawing.Point(35, 82);
            this.Generate10AddXButton.Name = "Generate10AddXButton";
            this.Generate10AddXButton.Size = new System.Drawing.Size(108, 31);
            this.Generate10AddXButton.TabIndex = 1;
            this.Generate10AddXButton.Text = "生成10+X的试卷";
            this.Generate10AddXButton.UseVisualStyleBackColor = true;
            this.Generate10AddXButton.Click += new System.EventHandler(this.Generate10AddXButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "题目数量";
            // 
            // questionCountbox
            // 
            this.questionCountbox.Location = new System.Drawing.Point(109, 28);
            this.questionCountbox.Name = "questionCountbox";
            this.questionCountbox.Size = new System.Drawing.Size(100, 21);
            this.questionCountbox.TabIndex = 3;
            this.questionCountbox.Text = "120";
            // 
            // Generate9AddXButton
            // 
            this.Generate9AddXButton.Location = new System.Drawing.Point(164, 82);
            this.Generate9AddXButton.Name = "Generate9AddXButton";
            this.Generate9AddXButton.Size = new System.Drawing.Size(112, 31);
            this.Generate9AddXButton.TabIndex = 4;
            this.Generate9AddXButton.Text = "生成9+X的试卷";
            this.Generate9AddXButton.UseVisualStyleBackColor = true;
            this.Generate9AddXButton.Click += new System.EventHandler(this.Generate9AddXButton_Click);
            // 
            // Generate8AddXButton
            // 
            this.Generate8AddXButton.Location = new System.Drawing.Point(300, 82);
            this.Generate8AddXButton.Name = "Generate8AddXButton";
            this.Generate8AddXButton.Size = new System.Drawing.Size(112, 31);
            this.Generate8AddXButton.TabIndex = 5;
            this.Generate8AddXButton.Text = "生成8+X的试卷";
            this.Generate8AddXButton.UseVisualStyleBackColor = true;
            this.Generate8AddXButton.Click += new System.EventHandler(this.Generate8AddXButton_Click);
            // 
            // Generate10SubtractionXButton
            // 
            this.Generate10SubtractionXButton.Location = new System.Drawing.Point(35, 134);
            this.Generate10SubtractionXButton.Name = "Generate10SubtractionXButton";
            this.Generate10SubtractionXButton.Size = new System.Drawing.Size(112, 31);
            this.Generate10SubtractionXButton.TabIndex = 6;
            this.Generate10SubtractionXButton.Text = "生成10-X的试卷";
            this.Generate10SubtractionXButton.UseVisualStyleBackColor = true;
            this.Generate10SubtractionXButton.Click += new System.EventHandler(this.Generate10SubtractionXButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 353);
            this.Controls.Add(this.Generate10SubtractionXButton);
            this.Controls.Add(this.Generate8AddXButton);
            this.Controls.Add(this.Generate9AddXButton);
            this.Controls.Add(this.questionCountbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate10AddXButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Generate10AddXButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionCountbox;
        private System.Windows.Forms.Button Generate9AddXButton;
        private System.Windows.Forms.Button Generate8AddXButton;
        private System.Windows.Forms.Button Generate10SubtractionXButton;
    }
}

