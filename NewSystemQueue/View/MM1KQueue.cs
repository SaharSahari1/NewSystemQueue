﻿using ExteanstionExceaption;
using NewSystemQueue.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSystemQueue.View
{
    public partial class MM1KQueue : Form
    {
        private double mho;
        private double lambda;
        private double capacityCustomer;
        private double p0;
        //TODO:Write Function to to set some field is default value
        private double rho = -1;
        public MM1KQueue()
        {
            InitializeComponent();
            ApplayAcceptOnlyNumberInTextBox();
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

        private void btnCalcRho_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO:Write Function to check if number is negative
                mho = double.Parse(txtMho.Text);
                lambda = double.Parse(txtLambda.Text);
                if (mho <= 0)
                {
                    txtMho.Text = string.Empty;
                    txtMho.Focus();
                    throw new DivideByZeroException("can not mho equla zero or negative number fix him");
                }
                if (lambda >= mho)
                {
                    txtMho.Text = string.Empty;
                    txtLambda.Text = string.Empty;
                    txtLambda.Focus();
                    throw new SystemUnstableException("لا يمكن أن تكون لامدا أكبر او تساوي ميو");
                }
                rho = CaclRho(mho, lambda);
                txtRho.Text = (rho * 100).ToString("F2") + " %";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CaclRho(double mho, double lambda)
        {
            return lambda / mho;
        }

        private void btnCalcPn_Click(object sender, EventArgs e)
        {
            //TODO: For Student Check if throw any Exception
            var xxxx = p0 * Math.Pow(rho, Convert.ToInt32(txtN.Text));
            txtPn.Text = (xxxx * 100).ToString("F2") + " %";
        }

        private void btnCalcP0_Click(object sender, EventArgs e)
        {
            //TODO:Check if k negative number 
            capacityCustomer = Convert.ToDouble(txtK.Text);
            p0 = CalcP0(capacityCustomer,rho);
            txtP0.Text = (p0 * 100).ToString("F2") + " %";
        }

        private double CalcP0(double capacityCustomer, double rho)
        {
            var result = (1 - rho) / (1 - Math.Pow(rho, capacityCustomer + 1));

            return result;
        }

        private void MM1KQueue_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcPk_Click(object sender, EventArgs e)
        {
            
            var xxxx = p0 * Math.Pow(rho, Convert.ToInt32(txtK.Text));
            txtPk.Text = (xxxx * 100).ToString("F2") + " %";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var lq = double.Parse(txtLq.Text);
                var lambdaEff = double.Parse(txtLambdaeffect.Text);

                var wq = lq / lambdaEff;
                txtwq.Text = wq.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var ls = double.Parse(textls.Text);
                var lambdaEff = double.Parse(txtLambdaeffect.Text);

                var ws = ls / lambdaEff;
                txtws.Text = ws.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcR_Click(object sender, EventArgs e)
        {
            try
            {
                var r = mho * (1 - p0);
                txtR.Text = r.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcLq_Click(object sender, EventArgs e)
        {
            try
            {
                var lambdaEff = double.Parse(txtLambdaeffect.Text);

                var lq = rho * (Math.Pow(rho, capacityCustomer) * (1 - capacityCustomer * rho + Math.Pow(rho, capacityCustomer - 1))) / (1 - Math.Pow(rho, capacityCustomer + 1));
                txtLq.Text = lq.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcLmbdaeffect_Click(object sender, EventArgs e)
        {
            try
            {
                var lambdaEff = lambda * (1 - Math.Pow(rho, capacityCustomer));
                txtLambdaeffect.Text = lambdaEff.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
