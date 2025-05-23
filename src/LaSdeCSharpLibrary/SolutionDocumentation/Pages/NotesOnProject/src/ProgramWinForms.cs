using System.Windows.Forms;

namespace LaSdeCSharpWinForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var form = new Form
           {
               Text = "Hello World",
               Width = 800,
               Height = 600
           };
            var label = new Label
            {
                Text = "Hello, World!",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            form.Controls.Add(label);
            Application.Run(form);
        }
    }
}
