using NewSystemQueue.Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewSystemQueue.View
{

    public partial class MMSQueue : Form
    {

        double mhoMMS;
        double lambdaMMS;
        double rhoMMS;
        double p0MMS;
        public MMSQueue()
        {
            InitializeComponent();
            ApplayAcceptOnlyNumberInTextBox();
            SetDefualtValue();
        }

        private void SetDefualtValue()
        {
            mhoMMS = -1;
            lambdaMMS = -1;
            rhoMMS = -1;
            p0MMS = -1;
        }
        private void ApplayAcceptOnlyNumberInTextBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyPress += InputHelper.HandleNumericInput;
                }
            }
        }
        private void btnCalcP0_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFillData(txtServicesCount, txtMho, txtLambda))
                {
                    ///for student write complete  exception
                    lblMMSReultP0.Text = string.Empty;
                    mhoMMS = Convert.ToDouble(txtMho.Text);
                    lambdaMMS = Convert.ToDouble(txtLambda.Text);
                    //عدد المخدمات
                    int servicesCount = Convert.ToInt32(txtServicesCount.Text);
                    double rateOfServices = mhoMMS * servicesCount;
                    rhoMMS = lambdaMMS / rateOfServices;
                    p0MMS = CalcP0(servicesCount, rhoMMS);
                    p0MMS = p0MMS * 100;


                    txtP0.Text = p0MMS.ToString("F2") + "%";
                }
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show(ex.Message);
                 
            }
        }

        private bool IsFillData(params TextBox[] texts)
        {
            foreach (TextBox textBox in texts)
            {

                if (textBox.Text.Trim()=="")
                {
                    textBox.BackColor = Color.Red;
                    textBox.ForeColor = Color.White;
                    textBox.Focus();
                    MessageBox.Show("قم بتعبئة جميع القيم");
                    return false;
                }

            }
            return true;
        }

        private double CalcP0(int servicesCount, double rhoMMS)
        {
            double firstSecation = 0;
            for (int x = 0; x <= servicesCount - 1; x++)
            {
                firstSecation = firstSecation
                        + (Math.Pow(servicesCount * rhoMMS, x) / Fact(x));
            }
            double secoundSecation = (Math.Pow(servicesCount * rhoMMS, servicesCount)
                            / (Fact(servicesCount) * (1 - rhoMMS)));
            double result = firstSecation + secoundSecation;

            return 1 / result;
        }
        private static long Fact(int number)
        {
            long factResult = 1;
            for (int i = number; i > 1; i--)
            {
                factResult = factResult * i;
            }
            return factResult;
        }
    }
}
