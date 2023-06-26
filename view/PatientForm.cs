using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DentalClinic.controller;
namespace DentalClinic.view
{
    public partial class PatientForm : Form
    {
        // txt >>>> TextBoxControl
        //btn>>>>>>Button Control
        public PatientForm()
        {
            InitializeComponent();
        }
  
        private void PatientForm_Load(object sender, EventArgs e)
        {

            txt_patientName.Select();
            txt_patientName.Focus();
            //initalize the id of the patient

            int id = 0;
            DataTable patient = new DataTable();
            patient.Columns.Add("id");
            patient.Columns.Add("name");
            SqlDataReader recored = DB.query("select * from patient ");
            while (recored.Read())
            {
                patient.Rows.Add(recored["id"], recored["name"]);
                id = int.Parse(recored["id"] + "");

            }
            DB.close();

            if (patient.Rows.Count > 0)
            {
                //fill all patients in the system inside the combo box
                cbx_patientList.DataSource = patient;
                cbx_patientList.DisplayMember = "name";
                cbx_patientList.ValueMember = "id";
                txt_patientID.Text = (id + 1) + "";
                
            }
            else
            {
                txt_patientID.Text = (id + 1) + "";
                
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            


            if (cbx_patientList.Text.Trim() != "")
            {
                if (cbx_patientList.SelectedValue == null)
                {
                    MessageBox.Show("هذا المريض غير موجود على النظام");
                    refresh();
                    return;
                }
                int id = int.Parse(cbx_patientList.SelectedValue + "");

                SqlDataReader recored = DB.query("select * from patient where id =" + id);

                while (recored.Read())
                {


                    txt_patientID.Text = recored["id"] + "";

                    txt_patientName.Text = recored["name"] + "";

                    txt_patientSSN.Text = recored["ssn"] + "";

                    txt_patientPhone.Text = recored["phone"] + "";

                    txt_birthDate.Text = recored["birthDay"] + "";



                }
                DB.close();

                


            }

            else
            {
                MessageBox.Show("يجب اختيار اسم مريض للبحث");
            }
        }

        private int LastId()
        {
            int id = 0;
            if (cbx_patientList.Items.Count > 0)
            {
                SqlDataReader recored = DB.query("select max(id) as maxid from patient ");
                while (recored.Read())
                {
                    if (!recored.IsDBNull(0))
                        id = int.Parse(recored["maxid"] + "");

                }
                DB.close();

            }

            return id;
        }

        private bool IsIdExist(int id)
        {
            DataTable patient = new DataTable();
            patient.Columns.Add("id");
            if (cbx_patientList.Items.Count > 0)
            {
                SqlDataReader recored = DB.query("select * from patient where id= "+id);
                while (recored.Read())
                {

                    patient.Rows.Add(recored["id"]);

                }
                DB.close();

            }

            if (patient.Rows.Count > 0)
                return true;
            return false;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            int id = LastId();
            

            txt_patientID.Text = (id + 1) + "";
            refresh();
         

        }


        private void refresh()
        {
            txt_patientName.Text = "";

            txt_patientSSN.Text = "";

            txt_patientPhone.Text = "";

            txt_birthDate.Text = "";

            cbx_patientList.Text = "";
          
        }

        private void btn_addPatient_Click(object sender, EventArgs e)
        {


            if (!isEmpty(txt_patientName.Text) && !isEmpty(txt_patientSSN.Text)
            && !isEmpty(txt_patientPhone.Text) && !isEmpty(txt_birthDate.Text))
            {
                int id = int.Parse(txt_patientID.Text);
                string name = txt_patientName.Text;
                string ssn = txt_patientSSN.Text;
                string phone = txt_patientPhone.Text;
                string birthDay = txt_birthDate.Text;

                if (!IsIdExist(id))
                {
                    DB.nonQuery("insert into patient values(" + id + "," + "'" + name + "'" + "," + "'" + ssn + "'" + "," + "'" + phone + "'" + "," + "'" + birthDay + "'" + ")");

                    refresh();
                    MessageBox.Show("تمت الاضافة بنجاح");
                    this.PatientForm_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("هذا المعرف تم استخدامه مسبقا");
                }



            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_birthDate.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private bool isEmpty(string str)
        {
            return (str.Trim() == "");
        }

        private void btn_updatePatient_Click(object sender, EventArgs e)
        {


            if (!isEmpty(txt_patientName.Text) && !isEmpty(txt_patientSSN.Text)
                && !isEmpty(txt_patientPhone.Text) && !isEmpty(txt_birthDate.Text)
                )
            {
                int id = int.Parse(txt_patientID.Text);
                string name = txt_patientName.Text;
                string ssn = txt_patientSSN.Text;
                string phone = txt_patientPhone.Text;
                string birthDay = txt_birthDate.Text;


                if (IsIdExist(id))
                {
                    string sql = "update patient set name=" + "'" + name + "'" + "," + "ssn" + "=" + "'" + ssn + "'" + ","
                  + "phone" + "=" + "'" + phone + "'" + "," + "birthDay" + "=" + "'" + birthDay + "'" + "where id =" + id;

                    DB.nonQuery(sql);

                    refresh();
                    MessageBox.Show("تمت التعديل بنجاح");
                    btn_addPatient.Enabled = true;
                    this.PatientForm_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("لا يمكن التعديل على بيانات مريض غير معرف على النظام");
                }




            }
            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void btn_deletePatient_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_patientID.Text);
            if (cbx_patientList.Items.Count > 0)
            {

                if (IsIdExist(id))
                {
                    if (MessageBox.Show("هل انتا متاكد من حذف هذا المريض ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DB.nonQuery("delete from patient where id=" + id);
                        refresh();
                        MessageBox.Show("تمت الحذف بنجاح");
                        this.PatientForm_Load(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("هذا المريض غير موجود ");
                }


            }

            else
            {
                MessageBox.Show("لا يوجد مرضى معرفين على النظام لذلك لا يمكنك الحذف");
            }


        }

        private void txt_patientSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt patien ssn and txt patient phone number accept only numbers

            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_patientSSN_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Enter)
            {
                // when you click enter you will transfer from txt patient ssn to txt patient phone 
                txt_patientPhone.Select();
                txt_patientPhone.Focus();
            }

            if (e.KeyData == Keys.Up)
            {
                //when you click UP Arrow you will transfer from txt patien ssn to txt patient name

                txt_patientName.Select();
                txt_patientName.Focus();
            }
        }

        private void txt_patientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt patient name will accept only letters 

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_patientName_KeyDown(object sender, KeyEventArgs e)
        {
            // when you click enter you will transfer from txt patient name to txt patient ssn

            if (e.KeyData == Keys.Enter)
            {
                txt_patientSSN.Select();
                txt_patientSSN.Focus();
            }
        }

        private void txt_patientPhone_KeyDown(object sender, KeyEventArgs e)
        {
            //when you click UP Arrow you will transfer from txt patien name to txt patient ssn

            if (e.KeyData == Keys.Up)
            {

                txt_patientSSN.Select();
                txt_patientSSN.Focus();
            }
        }
    }
}
