using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

            this.employeeData.Columns["name"].Visible = false;
            this.employeeData.Columns["ID"].Visible = false;
            this.employeeData.Columns["Department"].Visible = false;
            this.employeeData.Columns["Gender"].Visible = false;
            this.employeeData.Columns["Project"].Visible = false;

            BinaryFormatter f = new BinaryFormatter();
            List<Employee> emp_list = new List<Employee>();

            FileStream w = new FileStream("Data.txt", FileMode.Open);

            while (w.Position < w.Length) {
                Employee emp = (Employee)f.Deserialize(w);
                emp_list.Add(emp);
            }
            employeeData.DataSource = emp_list;
            w.Close();
        }

        private void employeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
