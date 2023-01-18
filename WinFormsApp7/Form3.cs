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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            BinaryFormatter f = new BinaryFormatter();
            List<Employee> emp_list = new List<Employee>();

            FileStream n = new FileStream("Data.txt", FileMode.Open);

            while (n.Position < n.Length)
            {
                Employee emp2 = (Employee)f.Deserialize(n);
                emp_list.Add(emp2);
            }
            ResultData.DataSource = emp_list;
            n.Close();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            this.ResultData.Columns["name"].Visible = false;
            this.ResultData.Columns["Department"].Visible = false;
            this.ResultData.Columns["Gender"].Visible = false;
            this.ResultData.Columns["IID"].Visible = false;

            string Selectedname = S_name.Text.ToString();
            string SelectedDep = S_Dep.Text.ToString();
            string SelectedPJ = S_Proj.Text.ToString();
            string SelectedId = S_id.Text.ToString();

            FileStream fs = new FileStream("Data.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Employee> filter = new List<Employee>();

            while (fs.Position != fs.Length)
            {
                Employee em = (Employee)bf.Deserialize(fs);
                if (em.Name.Equals(Selectedname) || (em.ID.Equals(SelectedId)) || (em.Department.Equals(SelectedDep)) || (em.Projects.Equals(SelectedPJ)))
                {
                    filter.Add(em);
                }
            }
            ResultData.DataSource = filter;
            fs.Close();
        }
        private void S_id_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void ResultData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void S_name_TextChanged(object sender, EventArgs e)
        {
           

        }
        private void S_Dep_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void S_Proj_TextChanged(object sender, EventArgs e)
        {
        }        
    }
}
