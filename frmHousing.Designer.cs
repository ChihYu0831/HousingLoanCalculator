namespace 個人房貸試算器
{
    partial class frmHousing
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblTotalHousePrice = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.lblResult5 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult4 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpInput.Controls.Add(this.txtBox5);
            this.grpInput.Controls.Add(this.txtBox4);
            this.grpInput.Controls.Add(this.txtBox3);
            this.grpInput.Controls.Add(this.txtBox2);
            this.grpInput.Controls.Add(this.txtBox1);
            this.grpInput.Controls.Add(this.btnCalculate);
            this.grpInput.Controls.Add(this.lblGracePeriod);
            this.grpInput.Controls.Add(this.lblDownPayment);
            this.grpInput.Controls.Add(this.lblAnnualInterestRate);
            this.grpInput.Controls.Add(this.lblLoanTerm);
            this.grpInput.Controls.Add(this.lblTotalHousePrice);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(476, 209);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.PaleVioletRed;
            this.grpOutput.Controls.Add(this.label5);
            this.grpOutput.Controls.Add(this.label4);
            this.grpOutput.Controls.Add(this.label3);
            this.grpOutput.Controls.Add(this.label2);
            this.grpOutput.Controls.Add(this.label1);
            this.grpOutput.Controls.Add(this.lbl1);
            this.grpOutput.Controls.Add(this.lblResult6);
            this.grpOutput.Controls.Add(this.lblResult1);
            this.grpOutput.Controls.Add(this.lblResult4);
            this.grpOutput.Controls.Add(this.lblResult3);
            this.grpOutput.Controls.Add(this.lblResult2);
            this.grpOutput.Controls.Add(this.lblResult5);
            this.grpOutput.Location = new System.Drawing.Point(12, 241);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(476, 254);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // lblTotalHousePrice
            // 
            this.lblTotalHousePrice.AutoSize = true;
            this.lblTotalHousePrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalHousePrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalHousePrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalHousePrice.Location = new System.Drawing.Point(41, 34);
            this.lblTotalHousePrice.Name = "lblTotalHousePrice";
            this.lblTotalHousePrice.Size = new System.Drawing.Size(102, 21);
            this.lblTotalHousePrice.TabIndex = 0;
            this.lblTotalHousePrice.Text = "房屋總價(元)";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanTerm.Location = new System.Drawing.Point(41, 127);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(102, 21);
            this.lblLoanTerm.TabIndex = 1;
            this.lblLoanTerm.Text = "貸款年限(年)";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(41, 96);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(100, 21);
            this.lblAnnualInterestRate.TabIndex = 2;
            this.lblAnnualInterestRate.Text = "貸款利率(%)";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDownPayment.Location = new System.Drawing.Point(41, 65);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(116, 21);
            this.lblDownPayment.TabIndex = 3;
            this.lblDownPayment.Text = "自備款比例(%)";
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGracePeriod.Location = new System.Drawing.Point(41, 158);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(86, 21);
            this.lblGracePeriod.TabIndex = 4;
            this.lblGracePeriod.Text = "寬限期(年)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(354, 58);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 85);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBox1.Location = new System.Drawing.Point(161, 31);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(162, 29);
            this.txtBox1.TabIndex = 6;
            this.txtBox1.Text = "12000000";
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBox2.Location = new System.Drawing.Point(161, 62);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(162, 29);
            this.txtBox2.TabIndex = 7;
            this.txtBox2.Text = "20";
            this.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox3
            // 
            this.txtBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBox3.Location = new System.Drawing.Point(161, 93);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(162, 29);
            this.txtBox3.TabIndex = 8;
            this.txtBox3.Text = "2.15";
            this.txtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBox4.Location = new System.Drawing.Point(161, 124);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(162, 29);
            this.txtBox4.TabIndex = 9;
            this.txtBox4.Text = "30";
            this.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox5
            // 
            this.txtBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBox5.Location = new System.Drawing.Point(161, 155);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(162, 29);
            this.txtBox5.TabIndex = 10;
            this.txtBox5.Text = "0";
            this.txtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult5
            // 
            this.lblResult5.AutoSize = true;
            this.lblResult5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult5.Location = new System.Drawing.Point(41, 170);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Size = new System.Drawing.Size(118, 21);
            this.lblResult5.TabIndex = 15;
            this.lblResult5.Text = "總利息支出(元)";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult2.Location = new System.Drawing.Point(41, 78);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(162, 21);
            this.lblResult2.TabIndex = 14;
            this.lblResult2.Text = "每月應繳金額(本+息)";
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult3.Location = new System.Drawing.Point(41, 109);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(102, 21);
            this.lblResult3.TabIndex = 13;
            this.lblResult3.Text = "首期利息(元)";
            // 
            // lblResult4
            // 
            this.lblResult4.AutoSize = true;
            this.lblResult4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult4.Location = new System.Drawing.Point(41, 139);
            this.lblResult4.Name = "lblResult4";
            this.lblResult4.Size = new System.Drawing.Size(102, 21);
            this.lblResult4.TabIndex = 12;
            this.lblResult4.Text = "首期本金(元)";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblResult1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult1.Location = new System.Drawing.Point(41, 47);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(118, 21);
            this.lblResult1.TabIndex = 11;
            this.lblResult1.Text = "貸款總金額(元)";
            // 
            // lblResult6
            // 
            this.lblResult6.AutoSize = true;
            this.lblResult6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult6.Location = new System.Drawing.Point(41, 201);
            this.lblResult6.Name = "lblResult6";
            this.lblResult6.Size = new System.Drawing.Size(118, 21);
            this.lblResult6.TabIndex = 21;
            this.lblResult6.Text = "總還款金額(元)";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Pink;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Location = new System.Drawing.Point(238, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(162, 29);
            this.lbl1.TabIndex = 23;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(238, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 24;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(238, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 25;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(238, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 26;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(238, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 27;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(238, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 28;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 518);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmHousing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸計算器";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblTotalHousePrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult4;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult5;
        private System.Windows.Forms.Label lblResult6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

