using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DentalClinic.controller;
using System.Data.SqlClient;
namespace DentalClinic.view
{
    public partial class CaseForm : Form
    {
        private List<int> treatmentsId;
        private Dictionary<int, double> treatmentsIdAndPrice;
        public CaseForm()
        {
            InitializeComponent();
            treatmentsId = new List<int>();
            treatmentsIdAndPrice = new Dictionary<int, double>();
        }

        private void CaseForm_Load(object sender, EventArgs e)
        {
            //initalize case id

            int id = 0;
            SqlDataReader recored2 = DB.query("select max(id) as maxid from PatientCase ");

            while (recored2.Read())
            {
                if (!recored2.IsDBNull(0))
                    id = int.Parse(recored2["maxid"] + "");

            }
            DB.close();

            txt_caseID.Text = (id + 1) + "";


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



            DataTable treatments = new DataTable();
            treatments.Columns.Add("id");
            treatments.Columns.Add("name");
            treatments.Columns.Add("minprice");
            treatments.Columns.Add("middelprice");
            treatments.Columns.Add("maxprice");
            SqlDataReader recored3 = DB.query("select * from Treatment ");
            while (recored3.Read())
            {
                treatments.Rows.Add(recored3["id"], recored3["name"], recored3["minprice"],
                      recored3["middelprice"], recored3["maxprice"]);


            }
            DB.close();
            if (treatments.Rows.Count > 0)
            {
                dataGridView1.DataSource = treatments;
                cbx_tratementList.DataSource = treatments;
                cbx_tratementList.DisplayMember = "name";
                cbx_tratementList.ValueMember = "id";

            }
        }

        private void cbx_patientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_patientList.Text.Trim() != "")
            {
                txt_patientName.Text = cbx_patientList.Text;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_caseDate.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void btn_addTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int sum = 0;//if equal 3 no radio button checked

                foreach (RadioButton btn in panel2.Controls)
                {
                    if (!btn.Checked)
                    {
                        sum++;
                    }
                }

                if (sum < 3)
                {
                    string id, name, minprice, middelprice, maxprice;
                    id = dataGridView1.SelectedRows[0].Cells[0].Value + "";
                    name = dataGridView1.SelectedRows[0].Cells[1].Value + "";
                    minprice = dataGridView1.SelectedRows[0].Cells[2].Value + "";
                    middelprice = dataGridView1.SelectedRows[0].Cells[3].Value + "";
                    maxprice = dataGridView1.SelectedRows[0].Cells[4].Value + "";
                    string treatment = name;
                    double caseBalance = 0;
                    if (maxprice_radioButton1.Checked)
                    {
                        treatment += "," + maxprice;
                        if (!listBox2.Items.Contains(treatment))
                            caseBalance = double.Parse(maxprice);
                        else
                            caseBalance = 0;
                    }
                    else if (middelprice_radioButton2.Checked)
                    {
                        treatment += "," + middelprice;
                        if (!listBox2.Items.Contains(treatment))
                            caseBalance = double.Parse(middelprice);
                        else
                            caseBalance = 0;
                    }
                    else if (minprice_radioButton3.Checked)
                    {
                        treatment += "," + minprice;
                        if (!listBox2.Items.Contains(treatment))
                            caseBalance = double.Parse(minprice);
                        else
                            caseBalance = 0;
                    }

                    if (!treatmentsIdAndPrice.ContainsKey(int.Parse(id)))
                    {
                        treatmentsIdAndPrice.Add(int.Parse(id), double.Parse(treatment.Split(',')[1]));
                    }

                    if (!listBox2.Items.Contains(treatment))
                        listBox2.Items.Add(treatment);





                    txt_caseBalance.Text = (double.Parse(txt_caseBalance.Text) + caseBalance) + "";

                    


                }

                else
                {
                    MessageBox.Show("من فضلك اختر التسعيرة المناسبة لهذا العلاج ");
                }


            }

            else
            {
                MessageBox.Show("اختار علاج من فضلك ");
            }
        }

        private void btn_searchTreatment_Click(object sender, EventArgs e)
        {
            if (cbx_tratementList.Items.Count == 0 || cbx_tratementList.Text.Trim() == "")
            {
                MessageBox.Show(" لا يوجد علاجات معرفة على النظام او ادخال خاطئ");
                return;
            }

            DataTable treatments = new DataTable();
            treatments.Columns.Add("id");
            treatments.Columns.Add("name");
            treatments.Columns.Add("minprice");
            treatments.Columns.Add("middelprice");
            treatments.Columns.Add("maxprice");
            SqlDataReader recored3 = DB.query("select * from Treatment where name like'%" + cbx_tratementList.Text + "%'");
            while (recored3.Read())
            {
                treatments.Rows.Add(recored3["id"], recored3["name"], recored3["minprice"],
                      recored3["middelprice"], recored3["maxprice"]);


            }
            DB.close();
            if (treatments.Rows.Count > 0)
            {
                dataGridView1.DataSource = treatments;

            }
        }

        private void btn_updatePatient_Click(object sender, EventArgs e)
        {
            //delete treatement 
            if (listBox2.SelectedItem != null)
            {

                int s = listBox2.SelectedIndex;
                double totalBalance = double.Parse(txt_caseBalance.Text);
                double caseBalance = double.Parse(listBox2.Items[s].ToString().Split(',')[1]);
                if (totalBalance > 0)
                    txt_caseBalance.Text = totalBalance - caseBalance + "";
                listBox2.Items.RemoveAt(s);

            }

        }

        private void btn_addCase_Click(object sender, EventArgs e)
        {

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            if (cbx_patientList.Items.Count > 0 &&
                txt_patientName.Text.Trim() != ""
                && txt_caseDate.Text.Trim() != ""&&listBox2.Items.Count>0)
            {
                int caseId = int.Parse(txt_caseID.Text);
                int pid = int.Parse(cbx_patientList.SelectedValue+"");
                string pname = cbx_patientList.Text;
                double cost = double.Parse(txt_caseBalance.Text);
                string date = txt_caseDate.Text;
                string notes = txt_notes.Text;

                string query = "insert into PatientCase values(" + caseId + "," + pid + "," + "'" + pname + "'"
                    + "," + cost + "," + "'" + date + "'" + "," + "'" + notes + "'" + ")";
                DB.nonQuery(query);


                foreach (int treatId in treatmentsIdAndPrice.Keys)
                {
                    double price = treatmentsIdAndPrice[treatId];
                    DB.nonQuery("insert into case_treatment values(" + caseId + "," + treatId + "," + price + ")");
                }



                MessageBox.Show("تمت الاضافة بنجاح");
                treatmentsIdAndPrice.Clear();
                refresh();
                if (listBox2.Items.Count>0)
                listBox2.Items.Clear();
                this.CaseForm_Load(sender, e);
                txt_caseBalance.Text = "0";
            }



            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }




        }


        private void refresh()
        {
            txt_patientName.Text = "";
            txt_caseDate.Text = "";
            txt_caseBalance.Text = "";

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable treatments = new DataTable();
            treatments.Columns.Add("id");
            treatments.Columns.Add("name");
            treatments.Columns.Add("minprice");
            treatments.Columns.Add("middelprice");
            treatments.Columns.Add("maxprice");
            SqlDataReader recored3 = DB.query("select * from Treatment ");
            while (recored3.Read())
            {
                treatments.Rows.Add(recored3["id"], recored3["name"], recored3["minprice"],
                      recored3["middelprice"], recored3["maxprice"]);


            }
            DB.close();
            if (treatments.Rows.Count > 0)
            {
                dataGridView1.DataSource = treatments;
                cbx_tratementList.DataSource = treatments;
                cbx_tratementList.DisplayMember = "name";

            }
        }
    }
}
