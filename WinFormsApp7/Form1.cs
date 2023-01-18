using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ID = "";
            string Name = "";
            string Department = "";
            string Gender = "";
            List <string> Projects = new List<string>();

            FileStream fs = new FileStream("Data.txt", FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();

            ID = Txt_id.Text;
            Name = txt_name.Text;
            
            if (radio_male.Checked)
                Gender = radio_male.Text;
            else if (radio_female.Checked)
                Gender = radio_female.Text;
            Department = cmb_department.SelectedItem.ToString();
            
            foreach (string item in checkedListBox1_Project.CheckedItems)
            {
                Projects.Add(item);
            }
            

            Employee F = new Employee(ID, Name, Gender, Department, Projects);
            formatter.Serialize(fs, F);
            MessageBox.Show("User added successfully !");
            fs.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm f = new ShowForm();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayForm a = new DisplayForm();
            a.Show();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
