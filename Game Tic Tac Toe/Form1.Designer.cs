namespace Game_Tic_Tac_Toe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.NGBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EBtn = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 13);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(61, 58);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 141);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(61, 58);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 77);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(61, 58);
            this.A10.TabIndex = 3;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(79, 141);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(61, 58);
            this.A21.TabIndex = 4;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(79, 77);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(61, 58);
            this.A11.TabIndex = 5;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(79, 13);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(61, 58);
            this.A01.TabIndex = 6;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(146, 13);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(61, 58);
            this.A02.TabIndex = 7;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(146, 77);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(61, 58);
            this.A12.TabIndex = 8;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(146, 141);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(61, 58);
            this.A22.TabIndex = 9;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGBtn
            // 
            this.NGBtn.Location = new System.Drawing.Point(12, 234);
            this.NGBtn.Name = "NGBtn";
            this.NGBtn.Size = new System.Drawing.Size(82, 48);
            this.NGBtn.TabIndex = 10;
            this.NGBtn.Text = "Yeni Oyuna Başla";
            this.NGBtn.UseVisualStyleBackColor = true;
            this.NGBtn.Click += new System.EventHandler(this.NGBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nəticəni Təzələ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EBtn
            // 
            this.EBtn.Location = new System.Drawing.Point(255, 249);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(101, 33);
            this.EBtn.TabIndex = 12;
            this.EBtn.Text = "Çıxış";
            this.EBtn.UseVisualStyleBackColor = true;
            this.EBtn.Click += new System.EventHandler(this.EBtn_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(233, 24);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(86, 30);
            this.XWin.TabIndex = 13;
            this.XWin.Text = "X";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(233, 87);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(86, 28);
            this.OWin.TabIndex = 14;
            this.OWin.Text = "O";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(233, 153);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(86, 30);
            this.Draws.TabIndex = 15;
            this.Draws.Text = "Draw";
            this.Draws.Click += new System.EventHandler(this.Draws_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 313);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.EBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NGBtn);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button NGBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
    }
}

