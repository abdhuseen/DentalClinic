using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class TreatmentPlanSearchForm : Form
    {
        public TreatmentPlanSearchForm()
        {
            InitializeComponent();
        }

        private void TreatmentPlanSearchForm_Load(object sender, EventArgs e)
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
                cbx_patientList.DataSource = patient;
                cbx_patientList.ValueMember = "id";
                cbx_patientList.DisplayMember = "name";

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (cbx_patientList.Items.Count == 0 || cbx_patientList.Text.Trim()=="")
            {
                MessageBox.Show("لا يوجد مرضى معرفين على النظام او ادخال خاطئ");
                return;
            }

            if (cbx_patientList.SelectedValue == null)
            {

                MessageBox.Show("هذا المريض غير معرف على النظام");

                return;
            }

            int pid = int.Parse(cbx_patientList.SelectedValue + "");

            string query = "select  TreatmentPlan.id,name as pname,description from TreatmentPlan,patient where TreatmentPlan.pid=patient.id and TreatmentPlan.pid="+pid;

            DataTable plans = new DataTable();

            plans.Columns.Add("id");

            plans.Columns.Add("pname");

            plans.Columns.Add("description");

            SqlDataReader recored = DB.query(query);
            while (recored.Read())
            {
                plans.Rows.Add(recored["id"], recored["pname"], recored["description"]);


            }
            DB.close();

            if (plans.Rows.Count > 0)
            {
                dataGridView1.DataSource = plans;

            }
            else
            {

                MessageBox.Show("لا يوجد خطط علاجية لهذا المريض");

                dataGridView1.DataSource = "";

                txt_desc.Text = "";
                PictureBox p2 = new PictureBox();
                pictureBox1.Image = p2.Image;
               


            }

        }
       private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                int planid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DentalClinic;Integrated Security=True");
                    SqlCommand command = new SqlCommand();

                    string query = "select *  from TreatmentPlan  where id="+planid;

                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();

                        command.Connection = sqlConnection;

                        command.CommandType = CommandType.Text;

                        command.CommandText = query;
                    }


                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        txt_desc.Text = reader[2].ToString();

                        byte[] img = (byte[])reader[3];

                        if (img != null)
                        {
                            pictureBox1.Image = byteArrayToImage(img);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...|All files (*.*)|*.*";
            openFileDialog1.Title = "اختر الصورة المرادة ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                



            }
        }
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {

            if (cbx_patientList.SelectedValue == null)
            {

                MessageBox.Show("هذا المريض غير معرف على النظام");

                return;
            }
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    byte[] photo = null;
                    int planid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    photo = imageToByteArray(pictureBox1.Image);
                    int pid = int.Parse(cbx_patientList.SelectedValue + "");
                    string desc = txt_desc.Text;
                    if (photo != null)
                    {
                        if(openFileDialog1.FileName== "openFileDialog1")
                        {
                            string sql = "update TreatmentPlan set description=" + "'" + desc + "'" + " where id=" + planid;
                            DB.nonQuery(sql);
                            MessageBox.Show(" تم التعديل بنجاح ");
                            txt_desc.Text = "";
                            PictureBox p2 = new PictureBox();
                            pictureBox1.Image = p2.Image;
                        }
                        else
                        {
                            string time = DateTime.Now.ToString("dd_MM_yy_hh_mm_ss");
                            string sql = "update TreatmentPlan set pid=" + pid + "," + "description=" + "'" + desc + "'" + "," +
                                "xrayImage=" + "@photo" + time + " where id=" + planid;
                            DB.GetCommand().Parameters.AddWithValue("@photo" + time, File.ReadAllBytes(openFileDialog1.FileName));
                            DB.nonQuery(sql);
                            MessageBox.Show(" تم التعديل بنجاح ");
                            txt_desc.Text = "";
                            PictureBox p2 = new PictureBox();
                            pictureBox1.Image = p2.Image;
                            
                        }
                       
                        
                    }
                    else
                    {
                        MessageBox.Show(" لم تقوم بتحميل صورة");
                    }
                }

                else
                {
                    MessageBox.Show("لم تختر خطة لتعديلها");
                }
            }
            catch(Exception ex)
            {
                string x = openFileDialog1.FileName;
                string msg = ex.Message;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                int planid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());




                if (MessageBox.Show("هل انتا متاكد من حذف هذه الخطة", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DB.nonQuery("delete from TreatmentPlan where id=" + planid);
                    //refresh();
                    MessageBox.Show("تمت الحذف بنجاح");
                    PictureBox p2 = new PictureBox();
                    pictureBox1.Image = p2.Image;
                    
                    btn_search_Click(sender, e);




                }

                    


                
            }

            else
            {
                MessageBox.Show("لم تختر خطة لحذفها");
            }
        }
    }
}
