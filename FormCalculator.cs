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
        private double m_YieldCoupon { get; set; } = 0;
        private double m_YieldYears { get; set; } = 0;
        private double m_YieldFace { get; set; } = 0;
        private double m_YieldPrice { get; set; } = 0;

        private double m_PriceCoupon { get; set; } = 0;
        private double m_PriceYears { get; set; } = 0;
        private double m_PriceFace { get; set; } = 0;
        private double m_PriceRate { get; set; } = 0;

        public FormCalculator()
        {
            InitializeComponent();
        }



        /*
        NAME
        	bool Compare(double a, double b, double epsilon)
        PARAMETERS
        	double a		- The first double to compare.
        	double b		- The second double to compare.
        	double episilon	- The precision when comparing. Default (0.0000001).
        DESCRIPTION
        	Compares two doubles to see if they are within epsilon distance.
        RETURNS
        	Returns true if doubles are within epsilon distance, otherwise returns false.
        */
        private bool Compare(double a, double b, double epsilon = 0.0000001)
        {
            return Math.Abs(a - b) < epsilon;
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



        /*
        NAME
            private void ValidateTextBox(TextBox a_textBox)

        PARAMETERS
        	TextBox a_textBox - A reference to the textbox control to be validated.

        DESCRIPTION
        	Checks if a_textbox.Text has a valid string, if not it is given the value "0".
        */
        private void ValidateTextBox(TextBox a_textBox)
        {
            if (String.IsNullOrEmpty(a_textBox.Text))
            {
                a_textBox.Text = "0";
            }
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
            ValidateTextBox(this.textBoxPriceCoupon);
            ValidateTextBox(this.textBoxPriceYears);
            ValidateTextBox(this.textBoxPriceFace);
            ValidateTextBox(this.textBoxPriceRate);

            m_PriceCoupon = Convert.ToDouble(this.textBoxPriceCoupon.Text);
            m_PriceYears = Convert.ToDouble(this.textBoxPriceYears.Text);
            m_PriceFace = Convert.ToDouble(this.textBoxPriceFace.Text);
            m_PriceRate = Convert.ToDouble(this.textBoxPriceRate.Text);

            double cashflow = m_PriceCoupon * m_PriceFace;
            double pv = SummationPV(m_PriceYears, m_PriceFace, m_PriceRate, cashflow);

            this.price.Text = Math.Round(pv, 7).ToString();
        }



        /*
        NAME
            private void buttonCalcYield_Click(object sender, EventArgs e)
            
        PARAMETERS
            object sender   - A reference to the control/object that raised the event.
            EventArgs e     - Relevant event data.

        DESCRIPTION
            Calculates the yield rate of a bond and displays the result on a modified label.
        */
        private void buttonCalcYield_Click(object sender, EventArgs e)
        {
            ValidateTextBox(this.textBoxYieldCoupon);
            ValidateTextBox(this.textBoxYieldYears);
            ValidateTextBox(this.textBoxYieldFace);
            ValidateTextBox(this.textBoxYieldPrice);

            m_YieldCoupon = Convert.ToDouble(this.textBoxYieldCoupon.Text);
            m_YieldYears = Convert.ToDouble(this.textBoxYieldYears.Text);
            m_YieldFace = Convert.ToDouble(this.textBoxYieldFace.Text);
            m_YieldPrice = Convert.ToDouble(this.textBoxYieldPrice.Text);

            double cashflow = m_YieldCoupon * m_YieldFace;
            double r1 = 0;
            double r2 = 1;

            // Binary search to find the rate
            while (true)
            {
                double rate = (r1 + r2) / 2;
                double pv = SummationPV(m_YieldYears, m_YieldFace, rate, cashflow);

                // If current rate gives us expected par value
                if (Compare(pv, m_YieldPrice))
                {
                    this.yield.Text = Math.Round(rate, 7).ToString();
                    return;
                }

                // Adjust rate accordingly to find exact pv
                if (pv < m_YieldPrice)
                {
                    // Estimated PV is too low
                    r2 = rate;
                }
                else if (pv > m_YieldPrice)
                {
                    // Estimated PV is too high
                    r1 = rate;
                }
            }
        }

    }
}
