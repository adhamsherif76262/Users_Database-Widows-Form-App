using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp7;

namespace WinFormsApp7
{
    [Serializable]
    class Employee
    {

        public string ID { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Department { set; get; }
        public List<string> Projects { set; get; }


        public Employee(string iD, string name, string gender, string department, List<string> projects)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Department = department;
            Projects = projects;
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
