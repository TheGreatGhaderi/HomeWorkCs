namespace Examples3
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
            this.lblTool = new System.Windows.Forms.Label();
            this.lblErtefaa = new System.Windows.Forms.Label();
            this.lblArz = new System.Windows.Forms.Label();
            this.txtTool = new System.Windows.Forms.TextBox();
            this.txtErtefaa = new System.Windows.Forms.TextBox();
            this.txtArz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool.Location = new System.Drawing.Point(48, 64);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(55, 29);
            this.lblTool.TabIndex = 0;
            this.lblTool.Text = "طول";
            // 
            // lblErtefaa
            // 
            this.lblErtefaa.AutoSize = true;
            this.lblErtefaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErtefaa.Location = new System.Drawing.Point(33, 176);
            this.lblErtefaa.Name = "lblErtefaa";
            this.lblErtefaa.Size = new System.Drawing.Size(70, 29);
            this.lblErtefaa.TabIndex = 1;
            this.lblErtefaa.Text = "ارتفاع";
            // 
            // lblArz
            // 
            this.lblArz.AutoSize = true;
            this.lblArz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArz.Location = new System.Drawing.Point(34, 120);
            this.lblArz.Name = "lblArz";
            this.lblArz.Size = new System.Drawing.Size(69, 29);
            this.lblArz.TabIndex = 2;
            this.lblArz.Text = "عرض";
            // 
            // txtTool
            // 
            this.txtTool.Location = new System.Drawing.Point(133, 64);
            this.txtTool.Multiline = true;
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(118, 33);
            this.txtTool.TabIndex = 3;
            // 
            // txtErtefaa
            // 
            this.txtErtefaa.Location = new System.Drawing.Point(133, 176);
            this.txtErtefaa.Multiline = true;
            this.txtErtefaa.Name = "txtErtefaa";
            this.txtErtefaa.Size = new System.Drawing.Size(118, 33);
            this.txtErtefaa.TabIndex = 5;
            // 
            // txtArz
            // 
            this.txtArz.Location = new System.Drawing.Point(133, 120);
            this.txtArz.Multiline = true;
            this.txtArz.Name = "txtArz";
            this.txtArz.Size = new System.Drawing.Size(118, 33);
            this.txtArz.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "محاسبه مکعب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtArz);
            this.Controls.Add(this.txtErtefaa);
            this.Controls.Add(this.txtTool);
            this.Controls.Add(this.lblArz);
            this.Controls.Add(this.lblErtefaa);
            this.Controls.Add(this.lblTool);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.Label lblErtefaa;
        private System.Windows.Forms.Label lblArz;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.TextBox txtErtefaa;
        private System.Windows.Forms.TextBox txtArz;
        private System.Windows.Forms.Button button1;
    }
}

