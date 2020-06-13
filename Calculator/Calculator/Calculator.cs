using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double _ilkRakam;
        string _islem;

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTransaction.Text = txtTransaction.Text + "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = ",";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + ",";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double _ikinciRakam;
            double sonuc;

            _ikinciRakam = Convert.ToDouble(txtTransaction.Text);

            if (_islem == "+")
            {
                sonuc = (_ilkRakam + _ikinciRakam);
                txtResult.Text = Convert.ToString(sonuc);
                _ilkRakam = sonuc;
            }
            if (_islem == "-")
            {
                sonuc = (_ilkRakam - _ikinciRakam);
                txtResult.Text = Convert.ToString(sonuc);
                _ilkRakam = sonuc;
            }
            if (_islem == "*")
            {
                sonuc = (_ilkRakam * _ikinciRakam);
                txtResult.Text = Convert.ToString(sonuc);
                _ilkRakam = sonuc;
            }
            if (_islem == "/")
            {
                if (_ikinciRakam == 0)
                {
                    txtTransaction.Text = "Sıfırla bölünemez";

                }
                else
                {
                    sonuc = (_ilkRakam / _ikinciRakam);
                    txtResult.Text = Convert.ToString(sonuc);
                    _ilkRakam = sonuc;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _ilkRakam = Convert.ToDouble(txtTransaction.Text);
            txtTransaction.Text = "0";
            _islem = "+";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtTransaction.Text = "0";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "6";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "6";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "3";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "3";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTransaction.Text = "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "8";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "8";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "5";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "5";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "1";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "1";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "4";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "4";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "7";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "7";
            }


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "9";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "9";
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtTransaction.Text = txtTransaction.Text.Substring(0, (txtTransaction.TextLength - 1));
            if (txtTransaction.TextLength == 0)
            {
                txtTransaction.Text = "0";
            }

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            _ilkRakam = Convert.ToDouble(txtTransaction.Text);
            txtTransaction.Text = "0";
            _islem = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            _ilkRakam = Convert.ToDouble(txtTransaction.Text);
            txtTransaction.Text = "0";
            _islem = "/";
        }

        private void txtTransaction_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "0" && txtTransaction.Text != null)
            {
                txtTransaction.Text = "2";
            }
            else
            {
                txtTransaction.Text = txtTransaction.Text + "2";
            }

        }

        private void btnExtraction_Click(object sender, EventArgs e)
        {
            _ilkRakam = Convert.ToDouble(txtTransaction.Text);
            txtTransaction.Text = "0";
            _islem = "-";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            _ilkRakam = Convert.ToDouble(txtTransaction.Text);
            _islem = "√";
            _ilkRakam = Convert.ToDouble(txtTransaction.Text);
            txtResult.Text = (Math.Sqrt(_ilkRakam)).ToString();
        }
    }
}
