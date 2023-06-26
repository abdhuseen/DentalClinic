using DentalClinic.view;
using System;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PatientForm frm = new PatientForm() {TopLevel=false,TopMost=true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void patientList_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PatientListForm frm = new PatientListForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void TratementMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TreatmentForm frm = new TreatmentForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void IncomeMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PaymentForm frm = new PaymentForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();

        }

        private void OutComeMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OutComeForm frm = new OutComeForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();

        }

        private void الجردالشهريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            MonthDetailsForm frm = new MonthDetailsForm();
            frm.ShowDialog();

        }

        private void الجردالسنويToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            YearDetailsForm frm = new YearDetailsForm();
            frm.ShowDialog();
        }

        private void caseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CaseForm frm = new CaseForm();
            frm.ShowDialog();



        }

        private void عرضالجلساتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            ReadCaseForm frm = new ReadCaseForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void البيانالماليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            PatientBalanceForm frm = new PatientBalanceForm();
            frm.MaximizeBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void الدفعبالشيكاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MoneyCheckForm frm = new MoneyCheckForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void الخطةالعلاجيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TreatmentPlanForm frm = new TreatmentPlanForm() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void بحثالخططالعلاجيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentPlanSearchForm frm = new TreatmentPlanSearchForm();

            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;

            frm.Show();
        }
    }
}
