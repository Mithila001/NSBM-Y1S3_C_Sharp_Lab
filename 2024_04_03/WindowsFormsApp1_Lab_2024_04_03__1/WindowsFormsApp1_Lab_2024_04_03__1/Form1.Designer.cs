namespace WindowsFormsApp1_Lab_2024_04_03__1
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
            this.enterEmployeeDetail_btn = new System.Windows.Forms.Button();
            this.displayEmployee_btn = new System.Windows.Forms.Button();
            this.enterContactDetails_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterEmployeeDetail_btn
            // 
            this.enterEmployeeDetail_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEmployeeDetail_btn.Location = new System.Drawing.Point(83, 188);
            this.enterEmployeeDetail_btn.Name = "enterEmployeeDetail_btn";
            this.enterEmployeeDetail_btn.Size = new System.Drawing.Size(171, 93);
            this.enterEmployeeDetail_btn.TabIndex = 0;
            this.enterEmployeeDetail_btn.Text = "Enter Employee Details";
            this.enterEmployeeDetail_btn.UseVisualStyleBackColor = true;
            this.enterEmployeeDetail_btn.Click += new System.EventHandler(this.enterEmployeeDetail_btn_Click);
            // 
            // displayEmployee_btn
            // 
            this.displayEmployee_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmployee_btn.Location = new System.Drawing.Point(550, 188);
            this.displayEmployee_btn.Name = "displayEmployee_btn";
            this.displayEmployee_btn.Size = new System.Drawing.Size(171, 93);
            this.displayEmployee_btn.TabIndex = 1;
            this.displayEmployee_btn.Text = "Display Employee";
            this.displayEmployee_btn.UseVisualStyleBackColor = true;
            this.displayEmployee_btn.Click += new System.EventHandler(this.displayEmployee_btn_Click);
            // 
            // enterContactDetails_btn
            // 
            this.enterContactDetails_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContactDetails_btn.Location = new System.Drawing.Point(318, 188);
            this.enterContactDetails_btn.Name = "enterContactDetails_btn";
            this.enterContactDetails_btn.Size = new System.Drawing.Size(171, 93);
            this.enterContactDetails_btn.TabIndex = 2;
            this.enterContactDetails_btn.Text = "Enter Contact Details";
            this.enterContactDetails_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterContactDetails_btn);
            this.Controls.Add(this.displayEmployee_btn);
            this.Controls.Add(this.enterEmployeeDetail_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterEmployeeDetail_btn;
        private System.Windows.Forms.Button displayEmployee_btn;
        private System.Windows.Forms.Button enterContactDetails_btn;
    }
}

