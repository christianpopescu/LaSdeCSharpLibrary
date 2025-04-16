using LaSdeCSharpWinForm.SimpleForms;
using System.Windows.Forms;

namespace LaSdeCSharpWinForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<Action<string>> action = DoSomething;
               ;
           
            var form = new FormActionLog("Action", action);

            Application.Run(form);
        }

        static void DoSomething(Action<string> logSomething)
        {
            logSomething("Test\r\n");
            logSomething("Test1\r\n");
        }
    }
}
