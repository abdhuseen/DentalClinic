using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DentalClinic.controller;

namespace DentalClinic.view
{
    public partial class OutComeForm : Form
    {
        public OutComeForm()
        {
            InitializeComponent();
        }

        private void OutComeForm_Load(object sender, EventArgs e)
        {
            
            string[] outcomeTypes = new string[] { "فاتورة مياه","فاتورة كهرباء",
            "ضريبة","ايجار","مورد","مواد للاسنان","مصاريف اخرى"
            ,"رواتب الموظفين"};
            cbx_outcomeTypesList.Text =outcomeTypes[0];
            if(cbx_outcomeTypesList.Items.Count==0)
            cbx_outcomeTypesList.Items.AddRange(outcomeTypes);

            //initalize outcome id

            int id = MaxId();
            txt_outcomeId.Text = (id + 1) + "";


            DataTable outcome = new DataTable();
            outcome.Columns.Add("id");
            outcome.Columns.Add("type");
            outcome.Columns.Add("date");
            outcome.Columns.Add("amount");
            SqlDataReader recored3 = DB.query("select * from outcome ");
            while (recored3.Read())
            {
                outcome.Rows.Add(recored3["id"], recored3["type"], recored3["date"],
                      recored3["amount"]);


            }
            DB.close();
            if (outcome.Rows.Count > 0)
            {
                dataGridView1.DataSource = outcome;

            }


        }

        private void cbx_outcomeTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_outcomeTypesList.Text.Trim() != "")
            {
                txt_outcomeType.Text = cbx_outcomeTypesList.Text;
            }
        }

        private void txt_outcomeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;

            }
        }

        private int MaxId()
        {
            int id = 0;

            SqlDataReader recored2 = DB.query("select max(id) as maxid from outcome ");
            while (recored2.Read())
            {
                if (!recored2.IsDBNull(0))
                    id = int.Parse(recored2["maxid"] + "");

            }
            DB.close();
            return id;
        }

        private void refresh()
        {
            
            int id = MaxId();
            txt_outcomeId.Text = (id + 1) + "";
            txt_outcometDate.Text = "";
            txt_outcomeType.Text = "";
            txt_outcomeAmount.Text = "";
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_outcometDate.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
           
            this.OutComeForm_Load(sender, e);
        }

        private void btn_addOutCome_Click(object sender, EventArgs e)
        {
            if (!isEmpty(txt_outcomeType.Text) && !isEmpty(txt_outcomeAmount.Text) && !isEmpty(txt_outcometDate.Text))
            {
                int id = int.Parse(txt_outcomeId.Text);
                string outComeType = txt_outcomeType.Text;
                string date = txt_outcometDate.Text;
                double amount = double.Parse(txt_outcomeAmount.Text);
                if (!IsIdExist(id))
                {
                    DB.nonQuery("insert into outcome values(" + id + "," + "'" + outComeType + "'"
                    + "," + "'" + date + "'" + "," + amount + ")");
                    refresh();
                    MessageBox.Show("تمت الاضافة بنجاح");
                    this.OutComeForm_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("رقم تعريف هذا المصروف مستخدم سابقا");
                }
                

                


            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private bool isEmpty(string str)
        {
            return (str.Trim() == "");
        }
        private bool IsIdExist(int id)
        {
            DataTable outcomes = new DataTable();
            outcomes.Columns.Add("id");
            if (dataGridView1.Rows.Count > 0)
            {
                SqlDataReader recored = DB.query("select * from outcome where id= " + id);
                while (recored.Read())
                {

                    outcomes.Rows.Add(recored["id"]);

                }
                DB.close();

            }

            if (outcomes.Rows.Count > 0)
                return true;
            return false;
        }
        private void btn_updateOutCome_Click(object sender, EventArgs e)
        {
            if (!isEmpty(txt_outcomeType.Text) && !isEmpty(txt_outcomeAmount.Text) && !isEmpty(txt_outcometDate.Text))
            {
                int id = int.Parse(txt_outcomeId.Text);
                string outComeType = txt_outcomeType.Text;
                string date =txt_outcometDate.Text;
                double amount = double.Parse(txt_outcomeAmount.Text);
               

                if (IsIdExist(id))
                {
                    string query = "update outcome set type=" + "'" + outComeType + "'"
                + "," + "date=" + "'" + date + "'" + "," + "amount=" + amount + " where id=" + id;



                    DB.nonQuery(query);

                    refresh();
                    MessageBox.Show("تمت التعديل بنجاح");
                    this.OutComeForm_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("لا يمكنك التعديل على مصروفات غير معرفة على النظام");
                }

                



            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void btn_deleteOutCome_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_outcomeId.Text);

            if (dataGridView1.Rows.Count > 0)
            {
                



                if (IsIdExist(id))
                {
                    if (MessageBox.Show("هل انتا متاكد من حذف هذا المصروف ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DB.nonQuery("delete from outcome where id=" + id);
                        refresh();
                        MessageBox.Show("تمت الحذف بنجاح");
                        this.OutComeForm_Load(sender, e);
                    }
                }

                else
                {
                    MessageBox.Show("هذا المصروف غير معرف على النظام");
                }




            }

            else
            {
                MessageBox.Show("لا يوجد مصروفات معرفة على النظام");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_outcomeId.Text = dataGridView1.CurrentRow.Cells[0].Value + "";
                txt_outcomeType.Text = dataGridView1.CurrentRow.Cells[1].Value + "";
                txt_outcometDate.Text = dataGridView1.CurrentRow.Cells[2].Value + "";
                txt_outcomeAmount.Text = dataGridView1.CurrentRow.Cells[3].Value + "";

            }
        }

        
        


        private void btn_search_Click(object sender, EventArgs e)
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

            }
            else
            {
                MessageBox.Show("لا يوجد مصاريف لهذا الشهر");

                dataGridView1.DataSource = "";
            }
        }
    }
}
