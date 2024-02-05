namespace Calculator
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
            textBox = new TextBox();
            btn1 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btnequal = new Button();
            btn0 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            btnmulti = new Button();
            btnsub = new Button();
            btndiv = new Button();
            btnplus = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btnpoint = new Button();
            btnC = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(88, 30);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(413, 61);
            textBox.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(88, 216);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 60);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(88, 392);
            btn7.Name = "btn7";
            btn7.Size = new Size(62, 60);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(88, 302);
            btn4.Name = "btn4";
            btn4.Size = new Size(62, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnequal
            // 
            btnequal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnequal.Location = new Point(439, 392);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(62, 149);
            btnequal.TabIndex = 4;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(88, 481);
            btn0.Name = "btn0";
            btn0.Size = new Size(179, 60);
            btn0.TabIndex = 8;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(205, 302);
            btn5.Name = "btn5";
            btn5.Size = new Size(62, 60);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(205, 392);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 60);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(205, 216);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 60);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnmulti
            // 
            btnmulti.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmulti.Location = new Point(322, 127);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(62, 60);
            btnmulti.TabIndex = 15;
            btnmulti.Text = "x";
            btnmulti.UseVisualStyleBackColor = true;
            btnmulti.Click += btnmulti_Click;
            // 
            // btnsub
            // 
            btnsub.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsub.ImageAlign = ContentAlignment.TopCenter;
            btnsub.Location = new Point(439, 127);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(62, 60);
            btnsub.TabIndex = 14;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = true;
            btnsub.Click += btnsub_Click;
            // 
            // btndiv
            // 
            btndiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndiv.Location = new Point(205, 127);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(62, 60);
            btndiv.TabIndex = 13;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnplus.Location = new Point(439, 216);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(62, 146);
            btnplus.TabIndex = 12;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(322, 302);
            btn6.Name = "btn6";
            btn6.Size = new Size(62, 60);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(322, 392);
            btn9.Name = "btn9";
            btn9.Size = new Size(62, 60);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(322, 216);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 60);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnpoint
            // 
            btnpoint.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpoint.Location = new Point(322, 481);
            btnpoint.Name = "btnpoint";
            btnpoint.Size = new Size(62, 60);
            btnpoint.TabIndex = 16;
            btnpoint.Text = ".";
            btnpoint.TextAlign = ContentAlignment.TopCenter;
            btnpoint.UseVisualStyleBackColor = true;
            btnpoint.Click += btnpoint_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.ForeColor = Color.DarkGreen;
            btnC.Location = new Point(88, 127);
            btnC.Name = "btnC";
            btnC.Size = new Size(62, 60);
            btnC.TabIndex = 17;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(587, 568);
            Controls.Add(btnC);
            Controls.Add(btnpoint);
            Controls.Add(btnmulti);
            Controls.Add(btnsub);
            Controls.Add(btndiv);
            Controls.Add(btnplus);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn2);
            Controls.Add(btnequal);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button btn1;
        private Button btn7;
        private Button btn4;
        private Button btnequal;
        private Button btn0;
        private Button btn5;
        private Button btn8;
        private Button btn2;
        private Button btnmulti;
        private Button btnsub;
        private Button btndiv;
        private Button btnplus;
        private Button btn6;
        private Button btn9;
        private Button btn3;
        private Button btnpoint;
        private Button btnC;
    }
}
