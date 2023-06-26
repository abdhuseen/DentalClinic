using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class MoneyCheckForm : Form
    {
        public MoneyCheckForm()
        {
            InitializeComponent();
        }

        private void MoneyCheckForm_Load(object sender, EventArgs e)
        {

            DataTable patients = new DataTable();
            patients.Columns.Add("id");
            patients.Columns.Add("name");
            SqlDataReader recored = DB.query("select * from patient ");
            while (recored.Read())
            {
                patients.Rows.Add(recored["id"],recored["name"]);


            }
            DB.close();

            if (patients.Rows.Count > 0)
            {
                cbx_patientList.DataSource = patients;
                cbx_patientList.ValueMember = "id";
                cbx_patientList.DisplayMember = "name";
                txt_patientName.Text = "";

            }

            int id = 0;

            SqlDataReader recored2 = DB.query("select max(id) as maxid from MoneyCheck ");

            while (recored2.Read())
            {
                if (!recored2.IsDBNull(0))
                    id = int.Parse(recored2["maxid"] + "");

            }
            DB.close();

            txt_checkID.Text = (id + 1) + "";
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
            txt_checkDate.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {


            if (cbx_patientList.Items.Count == 0||cbx_patientList.Text.Trim()=="")
            {
                MessageBox.Show("لا يوجد مرضى معرفين على النظام او ادخال خاطئ");
                return;
            }
            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            DataTable patientCheck = new DataTable();
            patientCheck.Columns.Add("id");
            patientCheck.Columns.Add("number");
            patientCheck.Columns.Add("value");
            patientCheck.Columns.Add("date");
            patientCheck.Columns.Add("pname");

            int pid =int.Parse(cbx_patientList.SelectedValue+ "");

            string query = "select * from  MoneyCheck where pid= " + pid;

            SqlDataReader recored2 = DB.query(query);

            while (recored2.Read())
            {
                patientCheck.Rows.Add(recored2["id"], recored2["number"], recored2["value"], recored2["date"]
                    , recored2["pname"]);

            }
            DB.close();

            if (patientCheck.Rows.Count > 0)
            {
                dataGridView1.DataSource = patientCheck;
            }

            else
            {
                MessageBox.Show("لا يوجد شيكات لهذا المريض");

                refresh();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                txt_checkID.Text = dataGridView1.SelectedRows[0].Cells[0].Value + "";

                txt_checkNumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value + "";

                txt_checkValue.Text = dataGridView1.SelectedRows[0].Cells[2].Value + "";

                txt_checkDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value + "";

                txt_patientName.Text = dataGridView1.SelectedRows[0].Cells[4].Value + "";

            }

        }
        private bool IsIdExist(int id)
        {
            DataTable checkes = new DataTable();
            checkes.Columns.Add("id");
            if (cbx_patientList.Items.Count > 0)
            {
                SqlDataReader recored = DB.query("select * from MoneyCheck where id= " + id);
                while (recored.Read())
                {

                    checkes.Rows.Add(recored["id"]);

                }
                DB.close();

            }

            if (checkes.Rows.Count > 0)
                return true;
            return false;
        }
        private void btn_addCheck_Click(object sender, EventArgs e)
        {

           

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            if (txt_checkNumber.Text.Trim() != "" && txt_checkValue.Text.Trim() != "" &&
                txt_patientName.Text.Trim() != "" && txt_checkDate.Text.Trim() != "")
            {

                

                int id = int.Parse(txt_checkID.Text);

                int pid = int.Parse(cbx_patientList.SelectedValue + "");

                int number = int.Parse(txt_checkNumber.Text);

                double value = double.Parse(txt_checkValue.Text);

                string pname = txt_patientName.Text;

                string date = txt_checkDate.Text;

                if (!IsIdExist(id))
                {
                    string query = "insert into  MoneyCheck (id,number,pname,date,value,pid) values( " + id + "," + number + ","
                + "'" + pname + "'" + "," + "'" + date + "'" + ","
                + value + "," + pid + ")";
                    DB.nonQuery(query);

                    MessageBox.Show("تمت الاضافة بنجاح");
                    refresh();
                    this.MoneyCheckForm_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("رقم المعرف مستخدم مسبقا ");
                }

                


            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }


        }


        private void refresh()
        {
            txt_checkDate.Text = "";

            txt_checkNumber.Text = "";

            txt_checkValue.Text = "";

            txt_patientName.Text = "";

            dataGridView1.DataSource = "";

            cbx_patientList.Text = "";

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            this.MoneyCheckForm_Load(sender, e);

        }

        private void btn_deletePatient_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_checkID.Text);

            if(IsIdExist(id))
            {
                if (MessageBox.Show("هل انتا متاكد من حذف هذا الشيك ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DB.nonQuery("delete from MoneyCheck where id=" + id);
                    refresh();
                    MessageBox.Show("تمت الحذف بنجاح");
                    this.MoneyCheckForm_Load(sender, e);
                }
            }

            else
            {
                MessageBox.Show("لا يمكن حذف شيك غير معرف على النظام");
            }
           





        }

        private void btn_updatePatient_Click(object sender, EventArgs e)
        {

           

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            if (txt_checkNumber.Text.Trim() != "" && txt_checkValue.Text.Trim() != "" &&
                txt_patientName.Text.Trim() != "" && txt_checkDate.Text.Trim() != "")
            {


                
                int id = int.Parse(txt_checkID.Text);

                int pid = int.Parse(cbx_patientList.SelectedValue+ "");

                int number = int.Parse(txt_checkNumber.Text);

                double value = double.Parse(txt_checkValue.Text);

                string pname = txt_patientName.Text;

                string date = txt_checkDate.Text;

                if (IsIdExist(id))
                {
                    string sql = "update MoneyCheck set number=" + number + "," + "pid" + "=" + pid + ","
                   + "pname" + "=" + "'" + pname + "'" + "," + "date" + "=" + "'" + date + "'" + "," + "value=" + value + "where id =" + id;

                    DB.nonQuery(sql);

                    refresh();
                    MessageBox.Show("تمت التعديل بنجاح");
                }

                else
                {
                    MessageBox.Show("لا يمكن التعديل على شيك غير معرف على النظام ");
                }








            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void txt_checkNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;

            }
        }

        private void txt_checkNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_checkValue.Select();

                txt_checkValue.Focus();
            }
        }

        private void txt_checkValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                txt_checkNumber.Select();
                txt_checkNumber.Focus();
            }
        }
    }
}
