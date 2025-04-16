using LaSdeCSharpWinForm.SimpleForms;
using System.Windows.Forms;

namespace LaSdeCSharpWinForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var form = new FormOkCancel();

            Application.Run(form);
        }
    }
}
