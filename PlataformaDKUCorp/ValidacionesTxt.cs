using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp
{
    internal class ValidacionesTxt
    {
        //Confirmar Txt User
        public static void ConfTxt(KeyPressEventArgs e)
        {
            if ( !(char.IsDigit(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar == (char)Keys.Back) && (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
