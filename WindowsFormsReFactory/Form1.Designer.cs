namespace WindowsFormsReFactory
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.drpCompany = new System.Windows.Forms.ComboBox();
            this.txtProductHeight = new System.Windows.Forms.TextBox();
            this.txtProductWidth = new System.Windows.Forms.TextBox();
            this.txtProductLength = new System.Windows.Forms.TextBox();
            this.txtProductWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoNeedCool = new System.Windows.Forms.RadioButton();
            this.rdoNotNeedCool = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNotNeedCool);
            this.groupBox1.Controls.Add(this.rdoNeedCool);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.drpCompany);
            this.groupBox1.Controls.Add(this.txtProductHeight);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtProductWidth);
            this.groupBox1.Controls.Add(this.txtProductLength);
            this.groupBox1.Controls.Add(this.txtProductWeight);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品資訊";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "物流商";
            // 
            // drpCompany
            // 
            this.drpCompany.FormattingEnabled = true;
            this.drpCompany.Location = new System.Drawing.Point(159, 158);
            this.drpCompany.Name = "drpCompany";
            this.drpCompany.Size = new System.Drawing.Size(100, 20);
            this.drpCompany.TabIndex = 10;
            // 
            // txtProductHeight
            // 
            this.txtProductHeight.Location = new System.Drawing.Point(159, 129);
            this.txtProductHeight.Name = "txtProductHeight";
            this.txtProductHeight.Size = new System.Drawing.Size(100, 22);
            this.txtProductHeight.TabIndex = 9;
            // 
            // txtProductWidth
            // 
            this.txtProductWidth.Location = new System.Drawing.Point(159, 100);
            this.txtProductWidth.Name = "txtProductWidth";
            this.txtProductWidth.Size = new System.Drawing.Size(100, 22);
            this.txtProductWidth.TabIndex = 8;
            // 
            // txtProductLength
            // 
            this.txtProductLength.Location = new System.Drawing.Point(159, 71);
            this.txtProductLength.Name = "txtProductLength";
            this.txtProductLength.Size = new System.Drawing.Size(100, 22);
            this.txtProductLength.TabIndex = 7;
            // 
            // txtProductWeight
            // 
            this.txtProductWeight.Location = new System.Drawing.Point(159, 43);
            this.txtProductWeight.Name = "txtProductWeight";
            this.txtProductWeight.Size = new System.Drawing.Size(100, 22);
            this.txtProductWeight.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(159, 15);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "高";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "寬";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "長";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "重量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名稱";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCharge);
            this.groupBox2.Controls.Add(this.lblCompany);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "結果";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Location = new System.Drawing.Point(157, 50);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(23, 12);
            this.lblCharge.TabIndex = 3;
            this.lblCharge.Text = "180";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(159, 21);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(29, 12);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "郵局";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "運費";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "物流商";
            // 
            // rdoNeedCool
            // 
            this.rdoNeedCool.AutoSize = true;
            this.rdoNeedCool.Location = new System.Drawing.Point(103, 193);
            this.rdoNeedCool.Name = "rdoNeedCool";
            this.rdoNeedCool.Size = new System.Drawing.Size(85, 16);
            this.rdoNeedCool.TabIndex = 12;
            this.rdoNeedCool.TabStop = true;
            this.rdoNeedCool.Text = "radioButton1";
            this.rdoNeedCool.UseVisualStyleBackColor = true;
            // 
            // rdoNotNeedCool
            // 
            this.rdoNotNeedCool.AutoSize = true;
            this.rdoNotNeedCool.Location = new System.Drawing.Point(186, 193);
            this.rdoNotNeedCool.Name = "rdoNotNeedCool";
            this.rdoNotNeedCool.Size = new System.Drawing.Size(85, 16);
            this.rdoNotNeedCool.TabIndex = 13;
            this.rdoNotNeedCool.TabStop = true;
            this.rdoNotNeedCool.Text = "radioButton2";
            this.rdoNotNeedCool.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox drpCompany;
        private System.Windows.Forms.TextBox txtProductHeight;
        private System.Windows.Forms.TextBox txtProductWidth;
        private System.Windows.Forms.TextBox txtProductLength;
        private System.Windows.Forms.TextBox txtProductWeight;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoNotNeedCool;
        private System.Windows.Forms.RadioButton rdoNeedCool;
    }
}

