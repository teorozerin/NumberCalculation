using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberCalculation
{
    public partial class Calculation : Form
    {
        double num1=0, num2=0 , result=0 ;
        string operationtype=string.Empty ;
        public Calculation()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string firstNum = txtSayi1.Text.Replace(".", ",");
            string secondNum = txtSayi2.Text.Replace(".", ",");

            if(double.TryParse(firstNum, out num1) && double.TryParse(secondNum, out num2) )
            {
                if(rbToplama.Checked)
                {
                    result=num1+num2;
                    operationtype = "+";
                }
                else if(rbCikarma.Checked)
                {
                    result = num1 - num2;
                    operationtype="-";
                }
                else if (rbCarpma.Checked)
                {
                    result = num1 * num2;
                    operationtype="*";
                }
                else if (rbBolme.Checked)
                {
                    result=num1/num2;
                    operationtype="/";
                }
                else
                {
                    lblSonuc.Text = "İşlem türü seçmediniz";
                    lblSonuc.ForeColor= Color.Red;
                    return;
                }

                lblSonuc.Text=string.Format("{0} {1} {2} = {3}", num1,operationtype,num2,result);
                lblSonuc.ForeColor = Color.Green;
            }
            else
            {
                lblSonuc.Text= "Girdiğiniz değerleri kontrol ediniz";
                lblSonuc.ForeColor=Color.Red;
            }
        }
    }
}
