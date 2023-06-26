using DentalClinic.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DentalClinic.view
{
    public partial class TreatmentPlanForm : Form
    {

        
        public TreatmentPlanForm()
        {
            InitializeComponent();
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

        // convert image to byte array
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        //Byte array to photo
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void cbx_patientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_patientList.Text.Trim() != "")
            {
                txt_patientName.Text = cbx_patientList.Text;
            }
        }

        private void TreatmentPlanForm_Load(object sender, EventArgs e)
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
            else
            {

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(cbx_patientList.Items.Count==0 || cbx_patientList.Text.Trim()=="")
            {
                MessageBox.Show("لا يوجد مرضى معرفين على النظام او ادخال خاطئ");
                return;
            }

            if (cbx_patientList.SelectedValue == null)
            {

                MessageBox.Show("هذا المريض غير معرف على النظام");

                return;
            }

            try
            {
                byte[] photo = null;
                if (pictureBox1.Image != null)
                    photo = imageToByteArray(pictureBox1.Image);
                int id = 0;
                int pid = int.Parse(cbx_patientList.SelectedValue+"");
                string desc = txt_desc.Text;
                SqlDataReader recored2 = DB.query("select max(id) as maxid from TreatmentPlan ");

                while (recored2.Read())
                {
                    if (!recored2.IsDBNull(0))
                        id = int.Parse(recored2["maxid"] + "");

                }
                DB.close();

                id = (id + 1);


                if (photo != null)
                {
                    
                    string sql = "insert into TreatmentPlan values(" + id + "," + pid + "," + "'" + desc + "'" + "," + "@photo" + id + ")";
                    DB.GetCommand().Parameters.AddWithValue("@photo" + id, File.ReadAllBytes(openFileDialog1.FileName));
                    DB.nonQuery(sql);
                    MessageBox.Show(" تم الاضافة بنجاح ");
                    txt_desc.Text = "";
                    PictureBox p2 = new PictureBox();
                    pictureBox1.Image = p2.Image;
                    


                }
                else
                {
                    
                    MessageBox.Show(" لم تقوم بتحميل صورة");
                }

            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }


        }
       
    }
}
