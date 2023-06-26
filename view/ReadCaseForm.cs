using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class ReadCaseForm : Form
    {
        public ReadCaseForm()
        {
            InitializeComponent();
        }

        private void ReadCaseForm_Load(object sender, EventArgs e)
        {

            DataTable patients = new DataTable();
            patients.Columns.Add("id");
            patients.Columns.Add("name");
            SqlDataReader recored = DB.query("select * from patient ");
            while (recored.Read())
            {
                patients.Rows.Add(recored["id"], recored["name"]);


            }
            DB.close();

            if (patients.Rows.Count > 0)
            {
                cbx_patientList.DataSource = patients;
                cbx_patientList.DisplayMember = "name";
                cbx_patientList.ValueMember = "id";
               
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbx_patientList.Items.Count == 0 || cbx_patientList.Text.Trim()=="")
            {
                MessageBox.Show(" لا يوجد مرضى معرفين على النظام او ادخال خاطئ");
                return;
            }

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            DataTable cases = new DataTable();
            cases.Columns.Add("id");
            cases.Columns.Add("pname");
            cases.Columns.Add("cost");
            cases.Columns.Add("date");
            cases.Columns.Add("notes");
            int pid = int.Parse(cbx_patientList.SelectedValue + "");

            string query = "select * from PatientCase where pid="+pid;

            SqlDataReader recored = DB.query(query);

            while (recored.Read())
            {
                cases.Rows.Add(recored["id"],recored["pname"],recored["cost"],recored["date"],recored["notes"]);
            }

            DB.close();

            if (cases.Rows.Count > 0)
            {

                dataGridView1.DataSource = cases;
            }

            else
            {
                dataGridView1.DataSource = "";

                MessageBox.Show("لا يوجد جلسات لهذا المريض");
            }

            txt_notes.Text = "";
            listBox1.Items.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataTable treatments_case = new DataTable();
                treatments_case.Columns.Add("name");
                treatments_case.Columns.Add("price");
                int caseid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                txt_notes.Text = dataGridView1.SelectedRows[0].Cells[4].Value + "";
                string query = "select name,price from Treatment,case_treatment where Treatment.id=case_treatment.treatmentId and case_treatment.caseId="+caseid;
                SqlDataReader recored = DB.query(query);

                while (recored.Read())
                {
                    treatments_case.Rows.Add(recored["name"], recored["price"]);
                }
                DB.close();

                if (treatments_case.Rows.Count > 0)
                {
                    
                    listBox1.Items.Clear();
                    for (int i = 0; i < treatments_case.Rows.Count; i++)
                    {
                        listBox1.Items.Add(treatments_case.Rows[i]["name"] + "," + treatments_case.Rows[i]["price"] );
                    }
                    
                }


                
            }
        }

        private void delete_case_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int caseId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value + "");

                if (MessageBox.Show("هل انتا متاكد من حذف هذا الجلسة ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DB.nonQuery("delete from PatientCase where id=" + caseId);

                    MessageBox.Show("تمت الحذف بنجاح");

                    dataGridView1.DataSource = "";

                    listBox1.Items.Clear();

                    txt_notes.Text = "";
 

                }

            }

            else
            {
                MessageBox.Show("لم تقم باختيار جلسة لحذفها");
            }
        }
    }
}
