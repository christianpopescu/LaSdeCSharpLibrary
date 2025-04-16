using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpWinForm.SimpleForms
{
    public class FormOkCancel : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button buttonOk = new Button();
        private System.Windows.Forms.Button buttonCancel = new Button();

        protected void InitButton(System.Windows.Forms.Button button,
            Point position,
            Point size,
            string text)
        {
            button.Location = position;
            button.Size = new Size(size);
            button.Text = text;
            
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ResumeLayout(false);

            InitButton
                (buttonOk,
                new Point(48, 432),
                new Point(80, 24),
                "OK");
            buttonOk.Click += new EventHandler(buttonOk_Click);


            InitButton
                (buttonCancel,
                new Point(148, 432),
                new Point(80, 24),
                "Cancel");
            buttonCancel.Click += new EventHandler(buttonCancel_Click);
        }
        private void FormOkCancel_Load(object? sender, EventArgs e)
        {
            this.Text = "Form with Ok and Cancel Buttonss";
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(buttonOk);
            this.Controls.Add(buttonCancel);
        }

        private void buttonCancel_Click(object? sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOk_Click(object? sender, EventArgs e)
        {
            this.Dispose();
        }

        public FormOkCancel()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormOkCancel_Load); // Link the Load event to the method
        }
    }
    
}
