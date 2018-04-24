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
            this.GenerateExcel = new System.Windows.Forms.Button();
            this.Generate10AddXButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateExcel
            // 
            this.GenerateExcel.Location = new System.Drawing.Point(360, 310);
            this.GenerateExcel.Name = "GenerateExcel";
            this.GenerateExcel.Size = new System.Drawing.Size(105, 31);
            this.GenerateExcel.TabIndex = 0;
            this.GenerateExcel.Text = "生成";
            this.GenerateExcel.UseVisualStyleBackColor = true;
            this.GenerateExcel.Click += new System.EventHandler(this.GenerateExcel_Click);
            // 
            // Generate10AddXButton
            // 
            this.Generate10AddXButton.Location = new System.Drawing.Point(44, 38);
            this.Generate10AddXButton.Name = "Generate10AddXButton";
            this.Generate10AddXButton.Size = new System.Drawing.Size(108, 31);
            this.Generate10AddXButton.TabIndex = 1;
            this.Generate10AddXButton.Text = "生成10+X的试卷";
            this.Generate10AddXButton.UseVisualStyleBackColor = true;
            this.Generate10AddXButton.Click += new System.EventHandler(this.Generate10AddXButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 353);
            this.Controls.Add(this.Generate10AddXButton);
            this.Controls.Add(this.GenerateExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateExcel;
        private System.Windows.Forms.Button Generate10AddXButton;
    }
}

