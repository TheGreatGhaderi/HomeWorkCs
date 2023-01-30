namespace Exaples5
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
            this.lblMian = new System.Windows.Forms.Label();
            this.btnNahaayi = new System.Windows.Forms.Button();
            this.txtMian = new System.Windows.Forms.TextBox();
            this.lblPayan = new System.Windows.Forms.Label();
            this.txtPayan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMian
            // 
            this.lblMian.AutoSize = true;
            this.lblMian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMian.Location = new System.Drawing.Point(41, 71);
            this.lblMian.Name = "lblMian";
            this.lblMian.Size = new System.Drawing.Size(75, 29);
            this.lblMian.TabIndex = 0;
            this.lblMian.Text = "میانترم";
            // 
            // btnNahaayi
            // 
            this.btnNahaayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNahaayi.Location = new System.Drawing.Point(78, 193);
            this.btnNahaayi.Name = "btnNahaayi";
            this.btnNahaayi.Size = new System.Drawing.Size(109, 36);
            this.btnNahaayi.TabIndex = 1;
            this.btnNahaayi.Text = "نمره نهایی";
            this.btnNahaayi.UseVisualStyleBackColor = true;
            this.btnNahaayi.Click += new System.EventHandler(this.BtnNahaayi_Click);
            // 
            // txtMian
            // 
            this.txtMian.Location = new System.Drawing.Point(146, 77);
            this.txtMian.Multiline = true;
            this.txtMian.Name = "txtMian";
            this.txtMian.Size = new System.Drawing.Size(104, 28);
            this.txtMian.TabIndex = 2;
            // 
            // lblPayan
            // 
            this.lblPayan.AutoSize = true;
            this.lblPayan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayan.Location = new System.Drawing.Point(41, 131);
            this.lblPayan.Name = "lblPayan";
            this.lblPayan.Size = new System.Drawing.Size(78, 29);
            this.lblPayan.TabIndex = 3;
            this.lblPayan.Text = "پایانترم";
            // 
            // txtPayan
            // 
            this.txtPayan.Location = new System.Drawing.Point(146, 137);
            this.txtPayan.Multiline = true;
            this.txtPayan.Name = "txtPayan";
            this.txtPayan.Size = new System.Drawing.Size(104, 28);
            this.txtPayan.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 293);
            this.Controls.Add(this.txtPayan);
            this.Controls.Add(this.lblPayan);
            this.Controls.Add(this.txtMian);
            this.Controls.Add(this.btnNahaayi);
            this.Controls.Add(this.lblMian);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMian;
        private System.Windows.Forms.Button btnNahaayi;
        private System.Windows.Forms.TextBox txtMian;
        private System.Windows.Forms.Label lblPayan;
        private System.Windows.Forms.TextBox txtPayan;
    }
}

