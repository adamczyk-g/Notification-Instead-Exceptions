using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefactoringExceptions.WinForms.View
{
    public partial class MainForm : Form, MainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateOfThePerformance.Format = DateTimePickerFormat.Custom;
            dateOfThePerformance.CustomFormat = "dd MMM yyyy";
        }

        public string NumberOfSeats { get { return numberOfSeats.Text; } }
        public string DateOfThePerformance { get { return dateOfThePerformance.Value.ToString(); } }
        
        public void ShowMessage(string message)
        {
            messages.Text = message;
        }
        public void ClearMessages()
        {
            messages.Text = string.Empty;
        }

        public event EventHandler BookSeats { add { this.bookSeats.Click += new System.EventHandler(value); } remove { this.bookSeats.Click -= new System.EventHandler(value); } }
    }
}
