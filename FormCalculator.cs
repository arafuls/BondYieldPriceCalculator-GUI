using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BondYieldCalculator_CSharpGUI
{
    public partial class FormCalculator : Form
    {
        private double m_coupon { get; set; } = 0;
        private double m_years { get; set; } = 0;
        private double m_face { get; set; } = 0;
        private double m_rate { get; set; } = 0;

        public FormCalculator()
        {
            InitializeComponent();
        }



        /*
        NAME
            private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
            
        PARAMETERS
            object sender       - A reference to the control/object that raised the event.
            KeyPressEventArgs e - Relevant event data.

        DESCRIPTION
            Sanitizes input but checking if each character entered into the textbox
            is a whitelisted character.
        */
        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Setting Handled to true cancels the KeyPress event.
            char input = e.KeyChar;

            // Allow digits, backspace, and decimal
            if (!Char.IsDigit(input) && input != 8 && input != '.')
            {
                e.Handled = true;  
            }

            // Allow only one decimal
            if (input == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }



        /*
        NAME
            private void buttonCalcPrice_Click(object sender, EventArgs e)
            
        PARAMETERS
            object sender   - A reference to the control/object that raised the event.
            EventArgs e     - Relevant event data.

        DESCRIPTION
            Calculates the price of a bond and displays the result on a modified label.
        */
        private void buttonCalcPrice_Click(object sender, EventArgs e)
        {
            m_coupon = Convert.ToDouble(this.textBoxPriceCoupon.Text);
            m_years = Convert.ToDouble(this.textBoxPriceYears.Text);
            m_face = Convert.ToDouble(this.textBoxPriceFace.Text);
            m_rate = Convert.ToDouble(this.textBoxPriceRate.Text);

            double cashflow = m_coupon * m_face;
            double pv = SummationPV(m_years, m_face, m_rate, cashflow);

            price.Text = Math.Round(pv, 7).ToString();
        }



        /*
        NAME
            private double SummationPV(double a_years, double a_face, double a_rate, double a_cashflow)

        PARAMETERS
        	int a_years			- The number of years for bond maturity.
        	double a_face		- The face value of the bond.
        	double a_rate		- The yield rate of the bond.
        	double a_cashflow	- The annual coupon payments to be made.

        DESCRIPTION
        	Sums total payments for a bond to calculate the current present value.

        RETURNS
        	Returns a double representing the total present value of the a bond.
        */
        private double SummationPV(double a_years, double a_face, double a_rate, double a_cashflow)
        {
            // Summation formula for present value
            double pv = 0;
            for (int i = 1; i < a_years + 1; i++)
            {
                pv += a_cashflow / Math.Pow(1 + a_rate, i);
            }
            pv += a_face / Math.Pow(1 + a_rate, a_years);    // Adding final payment to present value

            return pv;
        }
    }
}
