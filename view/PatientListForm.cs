using DentalClinic.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class PatientListForm : Form
    {
        public PatientListForm()
        {
            InitializeComponent();
        }

        private void PatientListForm_Load(object sender, EventArgs e)
        {
           
            DataTable patient = new DataTable();
            patient.Columns.Add("id");
            patient.Columns.Add("name");
            patient.Columns.Add("ssn");
            patient.Columns.Add("phone");
            patient.Columns.Add("birthDay");

            SqlDataReader recored = DB.query("select * from patient");
            while (recored.Read())
            {
                patient.Rows.Add(recored["id"], recored["name"], recored["ssn"], recored["phone"], recored["birthDay"]);


            }
            DB.close();

            if (patient.Rows.Count > 0)
            {
                patientTable.DataSource = patient;
            }
            else
            {

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string name = cbx_patientList.Text;
            DataTable patient = new DataTable();
            patient.Columns.Add("id");
            patient.Columns.Add("name");
            patient.Columns.Add("ssn");
            patient.Columns.Add("phone");
            patient.Columns.Add("birthDay");

            SqlDataReader recored = DB.query("select * from patient  where name like"+"'"+"%"+name+"%"+"'");
            while (recored.Read())
            {
                patient.Rows.Add(recored["id"], recored["name"], recored["ssn"], recored["phone"], recored["birthDay"]);


            }
            DB.close();

            if (patient.Rows.Count > 0)
            {
                patientTable.DataSource = patient;
            }
            else
            {
                MessageBox.Show("هذا المريض غير موجود");
            }

            
        }
    }
}
