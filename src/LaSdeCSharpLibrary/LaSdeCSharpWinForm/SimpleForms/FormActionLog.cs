using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LaSdeCSharpWinForm.SimpleForms
{
    /// <summary>
    /// This class is used to do an action and log the evolution.
    ///   Action<Action<string>> action is
    /// </summary>
    class FormActionLog : FormOkCancel
    {
        private System.Windows.Forms.TextBox textBoxLog = new TextBox();
        private System.Windows.Forms.Button buttonAction = new Button();
        // action = a delegate to a function that does somenthing that takes a delegate as parameter that is used to log the evolution
        private Action<Action<string>> action = null;
        private void InitializeComponent(string actionButtonText, Action<Action<string>> actionForButton)
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
            InitButton
                (buttonAction,
                new Point(48, 48),
                new Point(80, 24),
                actionButtonText);
            action = actionForButton;
            buttonAction.Click += new EventHandler(buttonAction_Click);
            textBoxLog.Multiline = true;
            textBoxLog.Location = new Point(48, 80);
            textBoxLog.Size = new Size(600, 300);
            textBoxLog.ScrollBars = ScrollBars.Both;
            
            textBoxLog.ReadOnly = true;

            this.Controls.Add(buttonAction);
            this.Controls.Add(textBoxLog);
        }
        private void buttonAction_Click(object? sender, EventArgs e)
        {
            action(AddToLog);
        }

        protected void AddToLog(string pAddToLog)
        {
            textBoxLog.Text += pAddToLog;
            textBoxLog.Refresh();
        }

        /// <summary>
        /// Init the dialog
        /// </summary>
        /// <param name="actionButtonText"> The text of the button </param>
        /// <param name="actionForButton"> Is the action that executed when the button is pressed
        ///             the fuction takes one parameter a delegate used as callback for logging </param>
        public FormActionLog(string actionButtonText, Action<Action<string>> actionForButton  )
        {
            
            InitializeComponent(actionButtonText,actionForButton);
            
        }

    }
}
