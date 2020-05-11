using System;
using System.Windows.Forms;

namespace MementoPatternDemo
{
    public partial class Form1 : Form
    {
        private Employee _employee;

        public Form1()
        {
            _employee = new Employee() { FirstName="Toby",LastName="Yan",Address="Zhangjiang Hi-Tech Park"};
            _employee.SyncToOriginal();

            InitializeComponent();
            SetDataToUI();
        }

        private void SetDataToUI()
        {
            textFirstname.Text = _employee.FirstName;
            textLastName.Text  = _employee.LastName;
            textAddress.Text   = _employee.Address;
        }
        private void SetUIToData()
        {
            _employee.FirstName = textFirstname.Text;
            _employee.LastName  = textLastName.Text;
            _employee.Address   = textAddress.Text;
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SetUIToData();
            if (!_employee.IsModified())
                return;
            _employee.SyncToOriginal();
        }

        private void buttonModified_Click(object sender, EventArgs e)
        {
            SetUIToData();
            if (_employee.IsModified())
                MessageBox.Show("The information has been monified","Example",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("The information hasn't been monified", "Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _employee.Revert();
            SetDataToUI();
        }
    }
}
