using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class PaymentForm : Form
    {
       
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void txt_patientSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txt payment amount accept only numbers and decimal comma (.)

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_paymentDate.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            
            DataTable patient = new DataTable();
            patient.Columns.Add("id");
            patient.Columns.Add("name");
            SqlDataReader recored = DB.query("select * from patient ");
            while (recored.Read())
            {
                patient.Rows.Add(recored["id"], recored["name"]);
                

            }
            DB.close();
            if (patient.Rows.Count > 0)
            {
                cbx_patientList.DataSource = patient;
                cbx_patientList.DisplayMember = "name";
                cbx_patientList.ValueMember = "id";
                
            }

             int id = 0;

           
            
                SqlDataReader recored2 = DB.query("select max(id) as maxid from payment ");
                
                while (recored2.Read())
                {
                   if(!recored2.IsDBNull(0))
                    id = int.Parse(recored2["maxid"] + "");

                }
                DB.close();

                txt_paymentId.Text = (id + 1) + "";




            DataTable payment = new DataTable();
            payment.Columns.Add("id");
            payment.Columns.Add("pname");
            payment.Columns.Add("date");
            payment.Columns.Add("amount");
            SqlDataReader recored3 = DB.query("select * from payment where id >0");
            while (recored3.Read())
            {
              payment.Rows.Add(recored3["id"], recored3["pname"], recored3["date"],
                    recored3["amount"]);


            }
            DB.close();
            if (payment.Rows.Count > 0)
            {
                dataGridView1.DataSource = payment;
                
            }









        }

        private void refresh()
        {
            int id = 0;
            if (cbx_patientList.Items.Count > 0)
            {
                SqlDataReader recored2 = DB.query("select max(id) as maxid from payment ");
                while (recored2.Read())
                {
                    if (!recored2.IsDBNull(0))
                        id = int.Parse(recored2["maxid"] + "");

                }
                DB.close();

            }


            txt_paymentId.Text = (id + 1) + "";
            txt_patientName.Text = "";
            txt_paymentAmount.Text = "";
            txt_paymentDate.Text = "";
            
        }

        private void cbx_patientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_patientName.Text = cbx_patientList.Text;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            this.PaymentForm_Load(sender, e);
        }

        private void btn_addPayment_Click(object sender, EventArgs e)
        {
            

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }

            if (!isEmpty(txt_patientName.Text) && !isEmpty(txt_paymentAmount.Text) && !isEmpty(txt_paymentDate.Text))
            {
                int id = int.Parse(txt_paymentId.Text);
                int pid = int.Parse(cbx_patientList.SelectedValue + ""); 
                string pname = txt_patientName.Text;
                string date = txt_paymentDate.Text;
                double amount = double.Parse(txt_paymentAmount.Text);
                if (!IsIdExist(id))
                {



                    DB.nonQuery("insert into payment values(" + id + "," + pid + "," + "'" + pname + "'"
                     + "," + "'" + date + "'" + "," + amount + ")");
                    refresh();
                    MessageBox.Show("تمت الاضافة بنجاح");
                    this.PaymentForm_Load(sender, e);



                }

                else
                {
                    MessageBox.Show("رقم تعريف هذه الدفعة مستخدم سابقا");
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
            DataTable payments = new DataTable();
            payments.Columns.Add("id");
            if (cbx_patientList.Items.Count > 0)
            {
                SqlDataReader recored = DB.query("select * from payment where id= " + id);
                while (recored.Read())
                {

                    payments.Rows.Add(recored["id"]);

                }
                DB.close();

            }

            if (payments.Rows.Count > 0)
                return true;
            return false;
        }
        private void btn_updatePayment_Click(object sender, EventArgs e)
        {

          

            if (cbx_patientList.SelectedValue == null)
            {
                MessageBox.Show("هذا المريض غير معرف على النظام");
                return;
            }


            if (!isEmpty(txt_patientName.Text) && !isEmpty(txt_paymentAmount.Text) && !isEmpty(txt_paymentDate.Text))
            {
                int id = int.Parse(txt_paymentId.Text);
                int pid = int.Parse(cbx_patientList.SelectedValue + "");
                string pname = txt_patientName.Text;
                string date = txt_paymentDate.Text;
                double amount = double.Parse(txt_paymentAmount.Text);

                if (IsIdExist(id))
                {




                    string query = "update payment set pid=" + pid + "," + "pname=" + "'" + pname + "'"
                  + "," + "date=" + "'" + date + "'" + "," + "amount=" + amount + " where id=" + id;



                    DB.nonQuery(query);

                    refresh();
                    MessageBox.Show("تمت التعديل بنجاح");
                    this.PaymentForm_Load(sender, e);



                }

                else
                {
                    MessageBox.Show("لا يمكنك التعديل على دفعة غير معرفة على النظام");
                }

              
                
                

            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_paymentId.Text = dataGridView1.CurrentRow.Cells[0].Value + "";
                txt_patientName.Text = dataGridView1.CurrentRow.Cells[1].Value + "";
                txt_paymentDate.Text = dataGridView1.CurrentRow.Cells[2].Value + "";
                txt_paymentAmount.Text = dataGridView1.CurrentRow.Cells[3].Value + "";

            }
        }

        private void btn_deletePayment_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_paymentId.Text);
            
            if (dataGridView1.Rows.Count>0)
            {

              


                if (IsIdExist(id))
                {
                    if (MessageBox.Show("هل انتا متاكد من حذف هذه الدفعة ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DB.nonQuery("delete from payment where id=" + id);
                        refresh();
                        MessageBox.Show("تمت الحذف بنجاح");
                        this.PaymentForm_Load(sender, e);
                    }
                }

                else
                {
                    MessageBox.Show("هذه الدفعة غير معرفة على النظام");
                }




            }

            else
            {
                MessageBox.Show("لا يوجد دفع على النظام");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            

            if (cbx_patientList.Text.Trim() != "")
            {
                if (cbx_patientList.SelectedValue == null)
                {
                    MessageBox.Show("هذا المريض غير معرف على النظام");
                    return;
                }

                int pid = int.Parse(cbx_patientList.SelectedValue+"");
                DataTable payment = new DataTable();
                payment.Columns.Add("id");
                payment.Columns.Add("pname");
                payment.Columns.Add("date");
                payment.Columns.Add("amount");
                SqlDataReader recored3 = DB.query("select * from payment where pid ="+pid);
                while (recored3.Read())
                {
                    payment.Rows.Add(recored3["id"], recored3["pname"], recored3["date"],
                          recored3["amount"]);


                }
                DB.close();
                if (payment.Rows.Count > 0)
                {
                    dataGridView1.DataSource = payment;

                }

                else
                {
                    MessageBox.Show("لا يوجد دفعات لهذا المريض");

                    this.btn_refresh_Click(sender, e);
                }

            }

            else
            {
                MessageBox.Show("يرجى اختيار مريض للبحث عن الدفعات الخاصة فيه");
            }
        }
    }
}
