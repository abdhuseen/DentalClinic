using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class PatientBalanceForm : Form
    {
        public PatientBalanceForm()
        {
            InitializeComponent();
        }

        private double TotalCasesCost(int id)
        {
            double total = 0;
            SqlDataReader recored3 = DB.query("select sum(cost) as TotalCasesCost from PatientCase where pid="+id);
            while (recored3.Read())
            {
                if (!recored3.IsDBNull(0))
                    total = double.Parse(recored3["TotalCasesCost"] + "");



            }
            DB.close();
            return total;
        }

        private double Totalpayments(int id)
        {
            double total = 0;
            SqlDataReader recored3 = DB.query("select sum(amount) as Totalpayments from payment where pid="+id);
            while (recored3.Read())
            {
                if (!recored3.IsDBNull(0))
                    total = double.Parse(recored3["Totalpayments"] + "");



            }
            DB.close();
            return total;
        }


        private double Totalchecks(int id)
        {
            double total = 0;
            SqlDataReader recored3 = DB.query("select sum(value) as Totalchecks from MoneyCheck where pid="+id);
            while (recored3.Read())
            {
                if (!recored3.IsDBNull(0))
                    total = double.Parse(recored3["Totalchecks"] + "");



            }
            DB.close();
            return total;
        }

        private void PatientBalanceForm_Load(object sender, EventArgs e)
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
                cbx_patientList.ValueMember = "id";
                cbx_patientList.DisplayMember = "name";

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbx_patientList.Items.Count == 0|| cbx_patientList.Text.Trim()=="")
            {
                MessageBox.Show("لا يوجد مرضى معرفين على النظام او ادخال خاطئ");
                return;
            }

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            int pid = int.Parse(cbx_patientList.SelectedValue+ "");

            double totalPayments = Totalpayments(pid);

            double totalCost = TotalCasesCost(pid);

            double totalChecks = Totalchecks(pid);

            DataTable payment = new DataTable();
            payment.Columns.Add("id");
            payment.Columns.Add("pname");
            payment.Columns.Add("date");
            payment.Columns.Add("amount");
            SqlDataReader recored3 = DB.query("select * from payment where pid =" + pid);
            while (recored3.Read())
            {
                payment.Rows.Add(recored3["id"], recored3["pname"], recored3["date"],
                      recored3["amount"]);


            }
            DB.close();
            if (payment.Rows.Count > 0)
            {
                dataGridView2.DataSource = payment;
                lbl_totalPayments.Text =totalPayments + "";
            }
            else
            {
                dataGridView2.DataSource = "";
                MessageBox.Show("لا يوجد دفعات لهذا المريض");
                lbl_totalPayments.Text = "0";
            }



            DataTable cases = new DataTable();
            cases.Columns.Add("id");
            cases.Columns.Add("pname");
            cases.Columns.Add("cost");
            cases.Columns.Add("date");
      
           

            string query = "select * from PatientCase where pid=" + pid;

            SqlDataReader recored = DB.query(query);

            while (recored.Read())
            {
                cases.Rows.Add(recored["id"], recored["pname"], recored["cost"], recored["date"]);
            }

            DB.close();

            if (cases.Rows.Count > 0)
            {

                dataGridView1.DataSource = cases;
                lbl_totalCaseCost.Text = totalCost + "";
            }

            else
            {
                dataGridView1.DataSource = "";
                MessageBox.Show("لا يوجد جلسات لهذا المريض");
                lbl_totalCaseCost.Text = "0";
            }

            DataTable patientCheck = new DataTable();
            patientCheck.Columns.Add("id");
            patientCheck.Columns.Add("number");
            patientCheck.Columns.Add("value");
            patientCheck.Columns.Add("date");
            patientCheck.Columns.Add("pname");


            string query2 = "select * from  MoneyCheck where pid="+pid;

            SqlDataReader recored2 = DB.query(query2);

            while (recored2.Read())
            {
                patientCheck.Rows.Add(recored2["id"], recored2["number"], recored2["value"], recored2["date"]
                    , recored2["pname"]);

            }
            DB.close();

            if (patientCheck.Rows.Count > 0)
            {
                dataGridView3.DataSource = patientCheck;
                txt_sumOfChecks.Text = totalChecks + "";
            }
            else
            {
                MessageBox.Show("لا يوجد شيكات لهذا المريض");

                

                dataGridView3.DataSource = "";

                txt_sumOfChecks.Text = "0";
            }

            double balance = (totalPayments+totalChecks) - totalCost;
            if (balance == 0)
            {
                lbl_forhim.Text = "0";
                lbl_onhim.Text = "0";
            }

            else if (balance > 0)
            {
                lbl_forhim.Text = balance + "";
                lbl_onhim.Text = "0";
            }
            else
            {
                lbl_forhim.Text = "0";
                lbl_onhim.Text = (balance*-1) + "";
            }



        }
    }
}
