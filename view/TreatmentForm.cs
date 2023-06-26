using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class TreatmentForm : Form
    {

        // txt >>>> TextBoxControl
        //btn>>>>>>Button Control

        public TreatmentForm()
        {
            InitializeComponent();
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            txt_tratementName.Select();
            txt_tratementName.Focus();

            
            int id = 0;
            DataTable treatments = new DataTable();
            treatments.Columns.Add("id");
            treatments.Columns.Add("name");
            SqlDataReader recored = DB.query("select * from Treatment ");
            while (recored.Read())
            {
                treatments.Rows.Add(recored["id"], recored["name"]);
                id = int.Parse(recored["id"] + "");

            }
            DB.close();

            if (treatments.Rows.Count > 0)
            {
                //fill all treatments in the system to the combobox

                cbx_tratementList.DataSource = treatments;
                cbx_tratementList.DisplayMember = "name";
                cbx_tratementList.ValueMember = "id";
                txt_tratementId.Text = (id + 1) + "";//initalize treatment id

            }
            else
            {
                txt_tratementId.Text = (id + 1) + "";//initalize treatment id

            }
        }

       

        private bool isEmpty(string str)
        {
            return (str.Trim() == "");
        }

        private void refresh()
        {

            txt_tratementName.Text = "";

            txt_minPrice.Text = "";

            txt_middelPrice.Text = "";

            txt_maxPrice.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            int id = LastId();

            txt_tratementId.Text = (id + 1) + "";
            refresh();
        }

        private int LastId()
        {
            int id = 0;
            if (cbx_tratementList.Items.Count > 0)
            {
                SqlDataReader recored = DB.query("select max(id) as maxid from Treatment ");
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
            DataTable treatment = new DataTable();
            treatment.Columns.Add("id");
            if (cbx_tratementList.Items.Count > 0)
            {
                SqlDataReader recored = DB.query("select * from Treatment where id= " + id);
                while (recored.Read())
                {

                    treatment.Rows.Add(recored["id"]);

                }
                DB.close();

            }

            if (treatment.Rows.Count > 0)
                return true;
            return false;
        }
        private void btn_addTratement_Click(object sender, EventArgs e)
        {
            

            if (!isEmpty(txt_tratementName.Text) && !isEmpty(txt_minPrice.Text)
                && !isEmpty(txt_middelPrice.Text) && !isEmpty(txt_maxPrice.Text))
            {
                int id = int.Parse(txt_tratementId.Text);
                string name = txt_tratementName.Text;
                double minPrice = double.Parse(txt_minPrice.Text);
                double middelPrice = double.Parse(txt_middelPrice.Text);
                double maxPrice = double.Parse(txt_maxPrice.Text);

                if (!IsIdExist(id))
                {
                    DB.nonQuery("insert into Treatment values(" + id + "," + "'" + name + "'" + "," + "'" + minPrice + "'" + "," + "'" + middelPrice + "'" + "," + "'" + maxPrice + "'" + ")");
                    refresh();
                    MessageBox.Show("تمت الاضافة بنجاح");
                    this.TreatmentForm_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("رقم التعريف مستخدم مسبقا");
                }
               
            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void btn_updateTratement_Click(object sender, EventArgs e)
        {
           

            if (!isEmpty(txt_tratementName.Text) && !isEmpty(txt_minPrice.Text)
                && !isEmpty(txt_middelPrice.Text) && !isEmpty(txt_maxPrice.Text)
                )
            {
                int id = int.Parse(txt_tratementId.Text);
                string name = txt_tratementName.Text;
                double minPrice = double.Parse(txt_minPrice.Text);
                double middelPrice = double.Parse(txt_middelPrice.Text);
                double maxPrice = double.Parse(txt_maxPrice.Text);
                if (IsIdExist(id))
                {

                    string query = "update Treatment set name= " + "'" + name + "'" + "," + "minprice=" + minPrice
                    + "," + "middelprice=" + middelPrice + "," + "maxprice=" + maxPrice + " where id =" + id;
                    DB.nonQuery(query);
                    refresh();
                    MessageBox.Show("تم التعديل بنجاح");
                    this.TreatmentForm_Load(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("لا يمكن التعديل على علاج غير معرف على النظام");
                }
            }

            else
            {
                MessageBox.Show("يوجد حقول فارغة او ادخال خاطئ");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if(cbx_tratementList.Items.Count==0)
            {
                MessageBox.Show("لا يوجد علاجات معرفة على النظام");
                return;
            }

            if (cbx_tratementList.Text.Trim() != "")
            {

                if (cbx_tratementList.SelectedValue == null)
                {
                    MessageBox.Show("هذا العلاج غير موجود على النظام");
                    return;

                }

                int id = int.Parse(cbx_tratementList.SelectedValue+"");

                SqlDataReader recored = DB.query("select * from Treatment where id =" + id);


                while (recored.Read())
                {


                    txt_tratementId.Text = recored["id"] + "";

                    txt_tratementName.Text = recored["name"] + "";

                    txt_minPrice.Text = recored["minprice"] + "";

                    txt_middelPrice.Text = recored["middelprice"] + "";

                    txt_maxPrice.Text = recored["maxprice"] + "";



                }
                DB.close();
               
            }

            else
            {
                MessageBox.Show("اختار علاج للبحث");
            }
        }

        private void btn_deleteTratement_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_tratementId.Text);
            

            if (cbx_tratementList.Items.Count > 0)
            {
                

                if (IsIdExist(id))
                {
                    if (MessageBox.Show("هل انتا متاكد من حذف هذا العلاج ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DB.nonQuery("delete from Treatment where id=" + id);
                        refresh();
                        MessageBox.Show("تمت الحذف بنجاح");
                        this.TreatmentForm_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("هذا العلاج غير موجود");
                }


            }

            else
            {
                MessageBox.Show("لا يوجد علاجات على النظام");
            }
        }

        private void txt_minPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txt minPrice,middelPrice and MaxPrice only accept numbers

            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar)&&(e.KeyChar!='.'))
            {
                e.Handled = true;
            }
        }

        private void txt_tratementName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt treatment name only accept letters

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tratementName_KeyDown(object sender, KeyEventArgs e)
        {
            // if you click enter then you will transfer from treatmentNameTxt to minprice txt

            if (e.KeyData == Keys.Enter)
            {
                txt_minPrice.Select();
                txt_minPrice.Focus();
            }
        }

        private void txt_minPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // if you click enter then you will transfer from  minprice txt to middel price txt
                txt_middelPrice.Select();
                txt_middelPrice.Focus();
            }

            if (e.KeyData == Keys.Up)
            {
                //if you click UP arrow then you will transfer from txt minprice to txt traetment name

                txt_tratementName.Select();
                txt_tratementName.Focus();
            }

        }

        private void txt_middelPrice_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                // if you click enter then you will transfer from  middelprice txt to max price txt

                txt_maxPrice.Select();
                txt_maxPrice.Focus();
            }

            if (e.KeyData == Keys.Up)
            {
                // if you click UP arrow then you will transfer from  middelprice txt to min price txt
                txt_minPrice.Select();
                txt_minPrice.Focus();
            }
        }

        private void txt_maxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                // if you click UP arrow then you will transfer from  maxprice txt to middel price txt

                txt_middelPrice.Select();
                txt_middelPrice.Focus();
            }
        }
    }
}
