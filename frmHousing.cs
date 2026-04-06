using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class frmHousing : Form
    {
        public frmHousing()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double housePrice, downPaymentPercent, annualRate;
            int loanYears, graceYears;

            if (!double.TryParse(txtBox1.Text, out housePrice) || housePrice <= 0)
            {
                MessageBox.Show("請輸入正確的房屋總價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox1.Focus();
                return;
            }

            if (!double.TryParse(txtBox2.Text, out downPaymentPercent) || downPaymentPercent < 0 || downPaymentPercent >= 100)
            {
                MessageBox.Show("請輸入正確的自備款比例（0~100 之間）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox2.Focus();
                return;
            }

            if (!double.TryParse(txtBox3.Text, out annualRate) || annualRate < 0)
            {
                MessageBox.Show("請輸入正確的貸款利率。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox3.Focus();
                return;
            }

            if (!int.TryParse(txtBox4.Text, out loanYears) || loanYears <= 0)
            {
                MessageBox.Show("請輸入正確的貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox4.Focus();
                return;
            }

            if (!int.TryParse(txtBox5.Text, out graceYears) || graceYears < 0)
            {
                MessageBox.Show("請輸入正確的寬限期。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox5.Focus();
                return;
            }

            if (graceYears > loanYears)
            {
                MessageBox.Show("寬限期不可大於貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox5.Focus();
                return;
            }

            double downPaymentAmount = housePrice * downPaymentPercent / 100.0;
            double loanAmount = housePrice - downPaymentAmount;

            int totalMonths = loanYears * 12;
            int graceMonths = graceYears * 12;
            int repayMonths = totalMonths - graceMonths;

            if (repayMonths <= 0)
            {
                MessageBox.Show("寬限期不可等於或大於整個貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox5.Focus();
                return;
            }

            double monthlyRate = annualRate / 100.0 / 12.0;
            double monthlyPayment;
            double firstInterest;
            double firstPrincipal;
            double totalInterest;
            double totalPayment;

            if (monthlyRate == 0)
            {
                monthlyPayment = loanAmount / repayMonths;
                firstInterest = 0;
                firstPrincipal = monthlyPayment;
                totalInterest = 0;
                totalPayment = loanAmount;
            }
            else
            {
                monthlyPayment = loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, repayMonths)
                               / (Math.Pow(1 + monthlyRate, repayMonths) - 1);

                firstInterest = loanAmount * monthlyRate;
                firstPrincipal = monthlyPayment - firstInterest;

                double graceInterestTotal = loanAmount * monthlyRate * graceMonths;
                double amortizationInterestTotal = monthlyPayment * repayMonths - loanAmount;

                totalInterest = graceInterestTotal + amortizationInterestTotal;
                totalPayment = loanAmount + totalInterest;
            }

            lbl1.Text = loanAmount.ToString("N2");
            lbl2.Text = monthlyPayment.ToString("N2");
            lbl3.Text = firstInterest.ToString("N2");
            lbl4.Text = firstPrincipal.ToString("N2");
            lbl5.Text = totalInterest.ToString("N2");
            lbl6.Text = totalPayment.ToString("N2");
        }
    }
}
