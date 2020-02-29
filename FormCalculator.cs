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
        public FormCalculator()
        {
            InitializeComponent();
        }

        /*
        NAME
            private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
            
        PARAMETERS
            object sender       - A reference to the control/object that raised the event.
            KeyPressEventArgs e - Event data, in this case user char input

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
    }
}
