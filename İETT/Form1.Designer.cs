namespace İETT
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
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbİlkGiriş = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rbOgrenci = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btnÖdeme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(12, 25);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(77, 25);
            this.lblBakiye.TabIndex = 0;
            this.lblBakiye.Text = "Bakiye";
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl200.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl200.Location = new System.Drawing.Point(18, 66);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(71, 37);
            this.lbl200.TabIndex = 1;
            this.lbl200.Text = "200";
            this.lbl200.Click += new System.EventHandler(this.lbl200_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOgrenci);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rbİlkGiriş);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktırmalar";
            // 
            // rbİlkGiriş
            // 
            this.rbİlkGiriş.AutoSize = true;
            this.rbİlkGiriş.Location = new System.Drawing.Point(14, 34);
            this.rbİlkGiriş.Name = "rbİlkGiriş";
            this.rbİlkGiriş.Size = new System.Drawing.Size(79, 24);
            this.rbİlkGiriş.TabIndex = 0;
            this.rbİlkGiriş.TabStop = true;
            this.rbİlkGiriş.Text = "İlk Giriş";
            this.rbİlkGiriş.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(14, 74);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(100, 24);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "1.Aktarma";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(14, 114);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(100, 24);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "2.Aktarma";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(14, 156);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(100, 24);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "3.Aktarma";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(14, 195);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(100, 24);
            this.rb4.TabIndex = 4;
            this.rb4.TabStop = true;
            this.rb4.Text = "4.Aktarma";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOgrenci.Location = new System.Drawing.Point(14, 236);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(113, 29);
            this.rbOgrenci.TabIndex = 5;
            this.rbOgrenci.Text = "Öğrenci";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn500);
            this.groupBox2.Controls.Add(this.btn200);
            this.groupBox2.Controls.Add(this.btn100);
            this.groupBox2.Controls.Add(this.btn50);
            this.groupBox2.Controls.Add(this.btn20);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(230, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 293);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakiye Yükleme";
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn20.Location = new System.Drawing.Point(34, 55);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(102, 32);
            this.btn20.TabIndex = 0;
            this.btn20.Text = "20₺Yükle";
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn50.Location = new System.Drawing.Point(34, 104);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(102, 31);
            this.btn50.TabIndex = 1;
            this.btn50.Text = "50₺ Yükle";
            this.btn50.UseVisualStyleBackColor = false;
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.Aquamarine;
            this.btn100.Location = new System.Drawing.Point(34, 150);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(102, 30);
            this.btn100.TabIndex = 2;
            this.btn100.Text = "100₺ Yükle";
            this.btn100.UseVisualStyleBackColor = false;
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn200.Location = new System.Drawing.Point(34, 192);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(102, 27);
            this.btn200.TabIndex = 3;
            this.btn200.Text = "200₺ Yükle";
            this.btn200.UseVisualStyleBackColor = false;
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn500.Location = new System.Drawing.Point(34, 236);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(102, 28);
            this.btn500.TabIndex = 4;
            this.btn500.Text = "500₺ Yükle";
            this.btn500.UseVisualStyleBackColor = false;
            // 
            // btnÖdeme
            // 
            this.btnÖdeme.BackColor = System.Drawing.Color.ForestGreen;
            this.btnÖdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖdeme.Location = new System.Drawing.Point(230, 42);
            this.btnÖdeme.Name = "btnÖdeme";
            this.btnÖdeme.Size = new System.Drawing.Size(136, 61);
            this.btnÖdeme.TabIndex = 4;
            this.btnÖdeme.Text = "Ödeme";
            this.btnÖdeme.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btnÖdeme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lblBakiye);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rbOgrenci;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rbİlkGiriş;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btnÖdeme;
    }
}

