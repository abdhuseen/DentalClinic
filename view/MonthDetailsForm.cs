using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class MonthDetailsForm : Form
    {
        public MonthDetailsForm()
        {
            InitializeComponent();
        }

        private double TotalOutComes(string format)
        {
            double total = 0;
            SqlDataReader recored3 = DB.query("select sum(amount) as TotalOutComes from outcome where date like '%" + format + "%'");
            while (recored3.Read())
            {
                if (!recored3.IsDBNull(0))
                    total =double.Parse(recored3["TotalOutComes"]+"");
                


            }
            DB.close();
            return total;
        }

        private double Totalpayments(string format)
        {
            double total = 0;
            SqlDataReader recored3 = DB.query("select sum(amount) as Totalpayments from payment where date like '%" + format + "%'");
            while (recored3.Read())
            {
                if (!recored3.IsDBNull(0))
                    total = double.Parse(recored3["Totalpayments"] + "");



            }
            DB.close();
            return total;
        }


        private double Totalchecks(string format)
        {
            //الشيكات

            double total = 0;
            SqlDataReader recored3 = DB.query("select sum(value) as Totalchecks from MoneyCheck where date like '%" + format + "%'");
            while (recored3.Read())
            {
                if (!recored3.IsDBNull(0))
                    total = double.Parse(recored3["Totalchecks"] + "");



            }
            DB.close();
            return total;
        }
        

        private void btn_details_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            string[] dateDetails = date.Split('/');
            string year = dateDetails[0];
            string month = dateDetails[1];
            string format = year + "/" + month;
            DataTable outcome = new DataTable();
            outcome.Columns.Add("id");
            outcome.Columns.Add("type");
            outcome.Columns.Add("date");
            outcome.Columns.Add("amount");
            SqlDataReader recored3 = DB.query("select * from outcome where date like '%" + format + "%'");
            while (recored3.Read())
            {
                outcome.Rows.Add(recored3["id"], recored3["type"], recored3["date"],
                      recored3["amount"]);


            }
            DB.close();
            if (outcome.Rows.Count > 0)
            {
                dataGridView1.DataSource = outcome;
                txt_sumOfOutcome.Text = TotalOutComes(format) + "";

            }
            else
            {
                MessageBox.Show("لا يوجد مصاريف لهذا الشهر");

                dataGridView1.DataSource = "";
                txt_sumOfOutcome.Text = "0";
            }


            DataTable payment = new DataTable();
            payment.Columns.Add("id");
            payment.Columns.Add("pname");
            payment.Columns.Add("date");
            payment.Columns.Add("amount");
            SqlDataReader recored4 = DB.query("select * from payment where date like '%" + format + "%'");
            while (recored4.Read())
            {
                payment.Rows.Add(recored4["id"], recored4["pname"], recored4["date"],
                      recored4["amount"]);


            }
            DB.close();
            if (payment.Rows.Count > 0)
            {
                dataGridView2.DataSource = payment;
                txt_sumOfPayments.Text = Totalpayments(format) + "";

            }
            else
            {

                MessageBox.Show("لا يوجد مدفوعات لهذا الشهر");

                txt_sumOfPayments.Text = "0";

                dataGridView2.DataSource = "";

            }

            DataTable patientCheck = new DataTable();
            patientCheck.Columns.Add("id");
            patientCheck.Columns.Add("number");
            patientCheck.Columns.Add("value");
            patientCheck.Columns.Add("date");
            patientCheck.Columns.Add("pname");


            string query = "select * from  MoneyCheck where date like '%" + format + "%'";

            SqlDataReader recored2 = DB.query(query);

            while (recored2.Read())
            {
                patientCheck.Rows.Add(recored2["id"], recored2["number"], recored2["value"], recored2["date"]
                    , recored2["pname"]);

            }
            DB.close();

            if (patientCheck.Rows.Count > 0)
            {
                dataGridView3.DataSource = patientCheck;
                txt_sumOfChecks.Text = Totalchecks(format) + "";
            }
            else
            {
                MessageBox.Show("لا يوجد شيكات لهذا الشهر");

                txt_sumOfChecks.Text = "0";

                dataGridView3.DataSource = "";
            }


            txt_netIncome.Text = ((double.Parse(txt_sumOfPayments.Text) + double.Parse(txt_sumOfChecks.Text)) - double.Parse(txt_sumOfOutcome.Text)) + "";
        }
    }
}
