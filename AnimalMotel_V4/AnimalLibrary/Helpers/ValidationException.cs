using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalMotel
{
    public class ValidationException : Exception
    {
        public ValidationException(string medd, Exception e)
        {
            MessageBox.Show(string.Format(medd, e));
        }
        public ValidationException()
        {

        }

        public void AgeException(string age)
        {
            MessageBox.Show("Age '" + age + "' is not allowed!");
        }

        public void TeethException(string teeth)
        {
            MessageBox.Show("Teeth '" + teeth + "' is not allowed!");
        }

        public void ShowNewMessageBox(string medd)
        {
            MessageBox.Show(medd);
        }
    }
}
