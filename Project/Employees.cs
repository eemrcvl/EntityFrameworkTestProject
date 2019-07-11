using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            ListEmployees();
        }
        private void ListEmployees()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                dgwEmployee.DataSource = context.Employees.ToList();
            }
        }
        private void FindEmployeeByName()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                dgwEmployee.DataSource = context.Employees.Where(p => p.FirstName.ToLower().Contains(tbxName.Text.ToLower())).ToList();
            }
        }
        private void FindEmployeeByLastName()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                dgwEmployee.DataSource = context.Employees.Where(p => p.LastName.ToLower().Contains(tbxLastName.Text.ToLower())).ToList();
            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            string key = tbxName.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListEmployees();
            }
            else
            {
                FindEmployeeByName();
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            string key = tbxLastName.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListEmployees();
            }
            else
            {
                FindEmployeeByLastName();
            }
        }
    }
}
