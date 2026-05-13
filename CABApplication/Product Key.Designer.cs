namespace CAB.UI
{
    partial class ProductKey
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
            this.GrpCompanyDetail = new System.Windows.Forms.GroupBox();
            this.btnValidateNew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.GrpCompanyDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpCompanyDetail
            // 
            this.GrpCompanyDetail.Controls.Add(this.btnValidateNew);
            this.GrpCompanyDetail.Controls.Add(this.button2);
            this.GrpCompanyDetail.Controls.Add(this.label1);
            this.GrpCompanyDetail.Controls.Add(this.label2);
            this.GrpCompanyDetail.Controls.Add(this.txt_ProductCode);
            this.GrpCompanyDetail.Location = new System.Drawing.Point(3, 2);
            this.GrpCompanyDetail.Name = "GrpCompanyDetail";
            this.GrpCompanyDetail.Size = new System.Drawing.Size(581, 114);
            this.GrpCompanyDetail.TabIndex = 13;
            this.GrpCompanyDetail.TabStop = false;
            this.GrpCompanyDetail.Text = "Product Key";
            this.GrpCompanyDetail.Enter += new System.EventHandler(this.GrpCompanyDetail_Enter);
            // 
            // btnValidateNew
            // 
            this.btnValidateNew.Location = new System.Drawing.Point(486, 52);
            this.btnValidateNew.Name = "btnValidateNew";
            this.btnValidateNew.Size = new System.Drawing.Size(81, 32);
            this.btnValidateNew.TabIndex = 21;
            this.btnValidateNew.Text = "Validate";
            this.btnValidateNew.UseVisualStyleBackColor = false;
            this.btnValidateNew.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnValidateNew.ForeColor = System.Drawing.Color.White;
            this.btnValidateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateNew.FlatAppearance.BorderSize = 0;
            this.btnValidateNew.Click += new System.EventHandler(this.btnValidateNew_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Generate License File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "\'Note* : Click on Generate License File and send file to your vendor to get the p" +
                "roduct key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Key";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.AcceptsReturn = true;
            this.txt_ProductCode.AcceptsTab = true;
            this.txt_ProductCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductCode.Location = new System.Drawing.Point(79, 25);
            this.txt_ProductCode.MaxLength = 500;
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(487, 21);
            this.txt_ProductCode.TabIndex = 2;
            // 
            // ProductKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 114);
            this.Controls.Add(this.GrpCompanyDetail);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 152);
            this.MinimumSize = new System.Drawing.Size(600, 152);
            this.Name = "ProductKey";
            this.Text = "Product Key";
            this.Load += new System.EventHandler(this.ProductKey_Load);
            this.GrpCompanyDetail.ResumeLayout(false);
            this.GrpCompanyDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpCompanyDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnValidateNew;
    }
}
