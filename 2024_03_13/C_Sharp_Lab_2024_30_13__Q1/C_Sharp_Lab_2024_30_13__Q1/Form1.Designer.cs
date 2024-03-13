namespace C_Sharp_Lab_2024_30_13__Q1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.number_1_btn = new System.Windows.Forms.Button();
            this.divition_btn = new System.Windows.Forms.Button();
            this.multiplication_btn = new System.Windows.Forms.Button();
            this.addition_btn = new System.Windows.Forms.Button();
            this.substraction_btn = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.number_2_btn_Click = new System.Windows.Forms.Button();
            this.number_3_btn_Click = new System.Windows.Forms.Button();
            this.number_4_btn_Click = new System.Windows.Forms.Button();
            this.number_5_btn_Click = new System.Windows.Forms.Button();
            this.number_6_btn_Click = new System.Windows.Forms.Button();
            this.number_7_btn_Click = new System.Windows.Forms.Button();
            this.number_8_btn_Click = new System.Windows.Forms.Button();
            this.number_9_btn_Click = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.number_0_btn_Click = new System.Windows.Forms.Button();
            this.clearDisplay_btn = new System.Windows.Forms.Button();
            this.calculateValue_btn = new System.Windows.Forms.Button();
            this.operatorDisplay_lable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.calculateValue_btn);
            this.panel1.Controls.Add(this.clearDisplay_btn);
            this.panel1.Controls.Add(this.number_0_btn_Click);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.number_9_btn_Click);
            this.panel1.Controls.Add(this.number_8_btn_Click);
            this.panel1.Controls.Add(this.number_7_btn_Click);
            this.panel1.Controls.Add(this.number_6_btn_Click);
            this.panel1.Controls.Add(this.number_5_btn_Click);
            this.panel1.Controls.Add(this.number_4_btn_Click);
            this.panel1.Controls.Add(this.number_3_btn_Click);
            this.panel1.Controls.Add(this.number_2_btn_Click);
            this.panel1.Controls.Add(this.substraction_btn);
            this.panel1.Controls.Add(this.addition_btn);
            this.panel1.Controls.Add(this.multiplication_btn);
            this.panel1.Controls.Add(this.divition_btn);
            this.panel1.Controls.Add(this.number_1_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 375);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.operatorDisplay_lable);
            this.panel2.Controls.Add(this.textBoxDisplay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 131);
            this.panel2.TabIndex = 1;
            // 
            // number_1_btn
            // 
            this.number_1_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_1_btn.FlatAppearance.BorderSize = 0;
            this.number_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_1_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_1_btn.Location = new System.Drawing.Point(28, 82);
            this.number_1_btn.Name = "number_1_btn";
            this.number_1_btn.Size = new System.Drawing.Size(55, 55);
            this.number_1_btn.TabIndex = 0;
            this.number_1_btn.Tag = "1";
            this.number_1_btn.Text = "1";
            this.number_1_btn.UseVisualStyleBackColor = false;
            this.number_1_btn.Click += new System.EventHandler(this.number_1_btn_Click);
            // 
            // divition_btn
            // 
            this.divition_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.divition_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divition_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divition_btn.Location = new System.Drawing.Point(211, 82);
            this.divition_btn.Name = "divition_btn";
            this.divition_btn.Size = new System.Drawing.Size(55, 55);
            this.divition_btn.TabIndex = 12;
            this.divition_btn.Text = "/";
            this.divition_btn.UseVisualStyleBackColor = false;
            this.divition_btn.Click += new System.EventHandler(this.divition_btn_Click);
            // 
            // multiplication_btn
            // 
            this.multiplication_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.multiplication_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication_btn.Location = new System.Drawing.Point(211, 143);
            this.multiplication_btn.Name = "multiplication_btn";
            this.multiplication_btn.Size = new System.Drawing.Size(55, 55);
            this.multiplication_btn.TabIndex = 13;
            this.multiplication_btn.Text = "*";
            this.multiplication_btn.UseVisualStyleBackColor = false;
            this.multiplication_btn.Click += new System.EventHandler(this.multiplication_btn_Click);
            // 
            // addition_btn
            // 
            this.addition_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.addition_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition_btn.Location = new System.Drawing.Point(211, 265);
            this.addition_btn.Name = "addition_btn";
            this.addition_btn.Size = new System.Drawing.Size(55, 55);
            this.addition_btn.TabIndex = 14;
            this.addition_btn.Text = "+";
            this.addition_btn.UseVisualStyleBackColor = false;
            this.addition_btn.Click += new System.EventHandler(this.addition_btn_Click);
            // 
            // substraction_btn
            // 
            this.substraction_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.substraction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.substraction_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substraction_btn.Location = new System.Drawing.Point(211, 204);
            this.substraction_btn.Name = "substraction_btn";
            this.substraction_btn.Size = new System.Drawing.Size(55, 55);
            this.substraction_btn.TabIndex = 15;
            this.substraction_btn.Text = "-";
            this.substraction_btn.UseVisualStyleBackColor = false;
            this.substraction_btn.Click += new System.EventHandler(this.substraction_btn_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(28, 58);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(238, 53);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // number_2_btn_Click
            // 
            this.number_2_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_2_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_2_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_2_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_2_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_2_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_2_btn_Click.Location = new System.Drawing.Point(89, 82);
            this.number_2_btn_Click.Name = "number_2_btn_Click";
            this.number_2_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_2_btn_Click.TabIndex = 16;
            this.number_2_btn_Click.Tag = "2";
            this.number_2_btn_Click.Text = "2";
            this.number_2_btn_Click.UseVisualStyleBackColor = false;
            this.number_2_btn_Click.Click += new System.EventHandler(this.number_2_btn_Click_Click);
            // 
            // number_3_btn_Click
            // 
            this.number_3_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_3_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_3_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_3_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_3_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_3_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_3_btn_Click.Location = new System.Drawing.Point(150, 82);
            this.number_3_btn_Click.Name = "number_3_btn_Click";
            this.number_3_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_3_btn_Click.TabIndex = 17;
            this.number_3_btn_Click.Tag = "3";
            this.number_3_btn_Click.Text = "3";
            this.number_3_btn_Click.UseVisualStyleBackColor = false;
            this.number_3_btn_Click.Click += new System.EventHandler(this.number_3_btn_Click_Click);
            // 
            // number_4_btn_Click
            // 
            this.number_4_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_4_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_4_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_4_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_4_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_4_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_4_btn_Click.Location = new System.Drawing.Point(28, 143);
            this.number_4_btn_Click.Name = "number_4_btn_Click";
            this.number_4_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_4_btn_Click.TabIndex = 18;
            this.number_4_btn_Click.Tag = "4";
            this.number_4_btn_Click.Text = "4";
            this.number_4_btn_Click.UseVisualStyleBackColor = false;
            this.number_4_btn_Click.Click += new System.EventHandler(this.number_4_btn_Click_Click);
            // 
            // number_5_btn_Click
            // 
            this.number_5_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_5_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_5_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_5_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_5_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_5_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_5_btn_Click.Location = new System.Drawing.Point(89, 143);
            this.number_5_btn_Click.Name = "number_5_btn_Click";
            this.number_5_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_5_btn_Click.TabIndex = 19;
            this.number_5_btn_Click.Tag = "5";
            this.number_5_btn_Click.Text = "5";
            this.number_5_btn_Click.UseVisualStyleBackColor = false;
            this.number_5_btn_Click.Click += new System.EventHandler(this.number_5_btn_Click_Click);
            // 
            // number_6_btn_Click
            // 
            this.number_6_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_6_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_6_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_6_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_6_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_6_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_6_btn_Click.Location = new System.Drawing.Point(150, 143);
            this.number_6_btn_Click.Name = "number_6_btn_Click";
            this.number_6_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_6_btn_Click.TabIndex = 20;
            this.number_6_btn_Click.Tag = "6";
            this.number_6_btn_Click.Text = "6";
            this.number_6_btn_Click.UseVisualStyleBackColor = false;
            this.number_6_btn_Click.Click += new System.EventHandler(this.number_6_btn_Click_Click);
            // 
            // number_7_btn_Click
            // 
            this.number_7_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_7_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_7_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_7_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_7_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_7_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_7_btn_Click.Location = new System.Drawing.Point(28, 204);
            this.number_7_btn_Click.Name = "number_7_btn_Click";
            this.number_7_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_7_btn_Click.TabIndex = 21;
            this.number_7_btn_Click.Tag = "7";
            this.number_7_btn_Click.Text = "7";
            this.number_7_btn_Click.UseVisualStyleBackColor = false;
            this.number_7_btn_Click.Click += new System.EventHandler(this.number_7_btn_Click_Click);
            // 
            // number_8_btn_Click
            // 
            this.number_8_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_8_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_8_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_8_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_8_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_8_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_8_btn_Click.Location = new System.Drawing.Point(89, 204);
            this.number_8_btn_Click.Name = "number_8_btn_Click";
            this.number_8_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_8_btn_Click.TabIndex = 22;
            this.number_8_btn_Click.Tag = "8";
            this.number_8_btn_Click.Text = "8";
            this.number_8_btn_Click.UseVisualStyleBackColor = false;
            this.number_8_btn_Click.Click += new System.EventHandler(this.number_8_btn_Click_Click);
            // 
            // number_9_btn_Click
            // 
            this.number_9_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_9_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_9_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_9_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_9_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_9_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_9_btn_Click.Location = new System.Drawing.Point(150, 204);
            this.number_9_btn_Click.Name = "number_9_btn_Click";
            this.number_9_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_9_btn_Click.TabIndex = 23;
            this.number_9_btn_Click.Tag = "9";
            this.number_9_btn_Click.Text = "9";
            this.number_9_btn_Click.UseVisualStyleBackColor = false;
            this.number_9_btn_Click.Click += new System.EventHandler(this.number_9_btn_Click_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(28, 265);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 24;
            this.button9.Text = ".";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // number_0_btn_Click
            // 
            this.number_0_btn_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_0_btn_Click.FlatAppearance.BorderSize = 0;
            this.number_0_btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.number_0_btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.number_0_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_0_btn_Click.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_0_btn_Click.Location = new System.Drawing.Point(89, 265);
            this.number_0_btn_Click.Name = "number_0_btn_Click";
            this.number_0_btn_Click.Size = new System.Drawing.Size(55, 55);
            this.number_0_btn_Click.TabIndex = 25;
            this.number_0_btn_Click.Tag = "0";
            this.number_0_btn_Click.Text = "0";
            this.number_0_btn_Click.UseVisualStyleBackColor = false;
            this.number_0_btn_Click.Click += new System.EventHandler(this.number_0_btn_Click_Click);
            // 
            // clearDisplay_btn
            // 
            this.clearDisplay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearDisplay_btn.FlatAppearance.BorderSize = 0;
            this.clearDisplay_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.clearDisplay_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clearDisplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDisplay_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDisplay_btn.Location = new System.Drawing.Point(150, 265);
            this.clearDisplay_btn.Name = "clearDisplay_btn";
            this.clearDisplay_btn.Size = new System.Drawing.Size(55, 55);
            this.clearDisplay_btn.TabIndex = 26;
            this.clearDisplay_btn.Text = "C";
            this.clearDisplay_btn.UseVisualStyleBackColor = false;
            this.clearDisplay_btn.Click += new System.EventHandler(this.clearDisplay_btn_Click);
            // 
            // calculateValue_btn
            // 
            this.calculateValue_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calculateValue_btn.FlatAppearance.BorderSize = 0;
            this.calculateValue_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.calculateValue_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.calculateValue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateValue_btn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateValue_btn.Location = new System.Drawing.Point(28, 326);
            this.calculateValue_btn.Name = "calculateValue_btn";
            this.calculateValue_btn.Size = new System.Drawing.Size(238, 37);
            this.calculateValue_btn.TabIndex = 27;
            this.calculateValue_btn.Text = "=";
            this.calculateValue_btn.UseVisualStyleBackColor = false;
            this.calculateValue_btn.Click += new System.EventHandler(this.calculateValue_btn_Click);
            // 
            // operatorDisplay_lable
            // 
            this.operatorDisplay_lable.AutoSize = true;
            this.operatorDisplay_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorDisplay_lable.Location = new System.Drawing.Point(242, 20);
            this.operatorDisplay_lable.Name = "operatorDisplay_lable";
            this.operatorDisplay_lable.Size = new System.Drawing.Size(27, 25);
            this.operatorDisplay_lable.TabIndex = 1;
            this.operatorDisplay_lable.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button number_1_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button substraction_btn;
        private System.Windows.Forms.Button addition_btn;
        private System.Windows.Forms.Button multiplication_btn;
        private System.Windows.Forms.Button divition_btn;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button number_6_btn_Click;
        private System.Windows.Forms.Button number_5_btn_Click;
        private System.Windows.Forms.Button number_4_btn_Click;
        private System.Windows.Forms.Button number_3_btn_Click;
        private System.Windows.Forms.Button number_2_btn_Click;
        private System.Windows.Forms.Button clearDisplay_btn;
        private System.Windows.Forms.Button number_0_btn_Click;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button number_9_btn_Click;
        private System.Windows.Forms.Button number_8_btn_Click;
        private System.Windows.Forms.Button number_7_btn_Click;
        private System.Windows.Forms.Button calculateValue_btn;
        private System.Windows.Forms.Label operatorDisplay_lable;
    }
}

