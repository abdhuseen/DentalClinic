
namespace DentalClinic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.patientList = new System.Windows.Forms.ToolStripMenuItem();
            this.TratementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addTratement = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTratement = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTratement = new System.Windows.Forms.ToolStripMenuItem();
            this.IncomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.OutComeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addOutcome = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOutcome = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOutcome = new System.Windows.Forms.ToolStripMenuItem();
            this.الجردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الجردالشهريToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الجردالسنويToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالجلساتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.البيانالماليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الدفعبالشيكاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الخطةالعلاجيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بحثالخططالعلاجيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientMenu,
            this.TratementMenu,
            this.IncomeMenu,
            this.OutComeMenu,
            this.الجردToolStripMenuItem,
            this.caseToolStripMenuItem,
            this.عرضالجلساتToolStripMenuItem,
            this.البيانالماليToolStripMenuItem,
            this.الدفعبالشيكاتToolStripMenuItem,
            this.الخطةالعلاجيةToolStripMenuItem,
            this.بحثالخططالعلاجيةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientMenu
            // 
            this.patientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatient,
            this.updatePatient,
            this.deletePatient,
            this.patientList});
            this.patientMenu.Name = "patientMenu";
            this.patientMenu.Size = new System.Drawing.Size(70, 26);
            this.patientMenu.Text = "المرضى";
            this.patientMenu.Click += new System.EventHandler(this.patientMenu_Click);
            // 
            // addPatient
            // 
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(215, 26);
            this.addPatient.Text = "اضافة مريض";
            this.addPatient.Click += new System.EventHandler(this.patientMenu_Click);
            // 
            // updatePatient
            // 
            this.updatePatient.Name = "updatePatient";
            this.updatePatient.Size = new System.Drawing.Size(215, 26);
            this.updatePatient.Text = "تعديل بيانات مريض";
            this.updatePatient.Click += new System.EventHandler(this.patientMenu_Click);
            // 
            // deletePatient
            // 
            this.deletePatient.Name = "deletePatient";
            this.deletePatient.Size = new System.Drawing.Size(215, 26);
            this.deletePatient.Text = "حذف مريض";
            this.deletePatient.Click += new System.EventHandler(this.patientMenu_Click);
            // 
            // patientList
            // 
            this.patientList.Name = "patientList";
            this.patientList.Size = new System.Drawing.Size(215, 26);
            this.patientList.Text = "قائمة المرضى";
            this.patientList.Click += new System.EventHandler(this.patientList_Click);
            // 
            // TratementMenu
            // 
            this.TratementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTratement,
            this.updateTratement,
            this.deleteTratement});
            this.TratementMenu.Name = "TratementMenu";
            this.TratementMenu.Size = new System.Drawing.Size(77, 26);
            this.TratementMenu.Text = "العلاجات";
            this.TratementMenu.Click += new System.EventHandler(this.TratementMenu_Click);
            // 
            // addTratement
            // 
            this.addTratement.Name = "addTratement";
            this.addTratement.Size = new System.Drawing.Size(201, 26);
            this.addTratement.Text = "اضافة علاج";
            this.addTratement.Click += new System.EventHandler(this.TratementMenu_Click);
            // 
            // updateTratement
            // 
            this.updateTratement.Name = "updateTratement";
            this.updateTratement.Size = new System.Drawing.Size(201, 26);
            this.updateTratement.Text = "تعديل بيانات علاج";
            this.updateTratement.Click += new System.EventHandler(this.TratementMenu_Click);
            // 
            // deleteTratement
            // 
            this.deleteTratement.Name = "deleteTratement";
            this.deleteTratement.Size = new System.Drawing.Size(201, 26);
            this.deleteTratement.Text = "حذف علاج";
            this.deleteTratement.Click += new System.EventHandler(this.TratementMenu_Click);
            // 
            // IncomeMenu
            // 
            this.IncomeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIncome,
            this.updateIncome,
            this.deleteIncome});
            this.IncomeMenu.Name = "IncomeMenu";
            this.IncomeMenu.Size = new System.Drawing.Size(89, 26);
            this.IncomeMenu.Text = "المدخولات";
            this.IncomeMenu.Click += new System.EventHandler(this.IncomeMenu_Click);
            // 
            // addIncome
            // 
            this.addIncome.Name = "addIncome";
            this.addIncome.Size = new System.Drawing.Size(172, 26);
            this.addIncome.Text = "اضافة دفعة ";
            this.addIncome.Click += new System.EventHandler(this.IncomeMenu_Click);
            // 
            // updateIncome
            // 
            this.updateIncome.Name = "updateIncome";
            this.updateIncome.Size = new System.Drawing.Size(172, 26);
            this.updateIncome.Text = "تعديل دفعة ";
            this.updateIncome.Click += new System.EventHandler(this.IncomeMenu_Click);
            // 
            // deleteIncome
            // 
            this.deleteIncome.Name = "deleteIncome";
            this.deleteIncome.Size = new System.Drawing.Size(172, 26);
            this.deleteIncome.Text = "حذف دفعة";
            this.deleteIncome.Click += new System.EventHandler(this.IncomeMenu_Click);
            // 
            // OutComeMenu
            // 
            this.OutComeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOutcome,
            this.updateOutcome,
            this.deleteOutcome});
            this.OutComeMenu.Name = "OutComeMenu";
            this.OutComeMenu.Size = new System.Drawing.Size(94, 26);
            this.OutComeMenu.Text = "المصروفات";
            this.OutComeMenu.Click += new System.EventHandler(this.OutComeMenu_Click);
            // 
            // addOutcome
            // 
            this.addOutcome.Name = "addOutcome";
            this.addOutcome.Size = new System.Drawing.Size(197, 26);
            this.addOutcome.Text = "اضافة مصروفات";
            this.addOutcome.Click += new System.EventHandler(this.OutComeMenu_Click);
            // 
            // updateOutcome
            // 
            this.updateOutcome.Name = "updateOutcome";
            this.updateOutcome.Size = new System.Drawing.Size(197, 26);
            this.updateOutcome.Text = "تعديل مصروفات";
            this.updateOutcome.Click += new System.EventHandler(this.OutComeMenu_Click);
            // 
            // deleteOutcome
            // 
            this.deleteOutcome.Name = "deleteOutcome";
            this.deleteOutcome.Size = new System.Drawing.Size(197, 26);
            this.deleteOutcome.Text = "حذف مصروفات";
            this.deleteOutcome.Click += new System.EventHandler(this.OutComeMenu_Click);
            // 
            // الجردToolStripMenuItem
            // 
            this.الجردToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الجردالشهريToolStripMenuItem,
            this.الجردالسنويToolStripMenuItem});
            this.الجردToolStripMenuItem.Name = "الجردToolStripMenuItem";
            this.الجردToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.الجردToolStripMenuItem.Text = "الجرد";
            // 
            // الجردالشهريToolStripMenuItem
            // 
            this.الجردالشهريToolStripMenuItem.Name = "الجردالشهريToolStripMenuItem";
            this.الجردالشهريToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.الجردالشهريToolStripMenuItem.Text = "الجرد الشهري";
            this.الجردالشهريToolStripMenuItem.Click += new System.EventHandler(this.الجردالشهريToolStripMenuItem_Click);
            // 
            // الجردالسنويToolStripMenuItem
            // 
            this.الجردالسنويToolStripMenuItem.Name = "الجردالسنويToolStripMenuItem";
            this.الجردالسنويToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.الجردالسنويToolStripMenuItem.Text = "الجرد السنوي";
            this.الجردالسنويToolStripMenuItem.Click += new System.EventHandler(this.الجردالسنويToolStripMenuItem_Click);
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.caseToolStripMenuItem.Text = "الجلسات العلاجية";
            this.caseToolStripMenuItem.Click += new System.EventHandler(this.caseToolStripMenuItem_Click);
            // 
            // عرضالجلساتToolStripMenuItem
            // 
            this.عرضالجلساتToolStripMenuItem.Name = "عرضالجلساتToolStripMenuItem";
            this.عرضالجلساتToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.عرضالجلساتToolStripMenuItem.Text = "عرض الجلسات";
            this.عرضالجلساتToolStripMenuItem.Click += new System.EventHandler(this.عرضالجلساتToolStripMenuItem_Click);
            // 
            // البيانالماليToolStripMenuItem
            // 
            this.البيانالماليToolStripMenuItem.Name = "البيانالماليToolStripMenuItem";
            this.البيانالماليToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.البيانالماليToolStripMenuItem.Text = "البيان المالي";
            this.البيانالماليToolStripMenuItem.Click += new System.EventHandler(this.البيانالماليToolStripMenuItem_Click);
            // 
            // الدفعبالشيكاتToolStripMenuItem
            // 
            this.الدفعبالشيكاتToolStripMenuItem.Name = "الدفعبالشيكاتToolStripMenuItem";
            this.الدفعبالشيكاتToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.الدفعبالشيكاتToolStripMenuItem.Text = "الدفع بالشيكات";
            this.الدفعبالشيكاتToolStripMenuItem.Click += new System.EventHandler(this.الدفعبالشيكاتToolStripMenuItem_Click);
            // 
            // الخطةالعلاجيةToolStripMenuItem
            // 
            this.الخطةالعلاجيةToolStripMenuItem.Name = "الخطةالعلاجيةToolStripMenuItem";
            this.الخطةالعلاجيةToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.الخطةالعلاجيةToolStripMenuItem.Text = "الخطة العلاجية";
            this.الخطةالعلاجيةToolStripMenuItem.Click += new System.EventHandler(this.الخطةالعلاجيةToolStripMenuItem_Click);
            // 
            // بحثالخططالعلاجيةToolStripMenuItem
            // 
            this.بحثالخططالعلاجيةToolStripMenuItem.Name = "بحثالخططالعلاجيةToolStripMenuItem";
            this.بحثالخططالعلاجيةToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.بحثالخططالعلاجيةToolStripMenuItem.Text = "بحث الخطط العلاجية";
            this.بحثالخططالعلاجيةToolStripMenuItem.Click += new System.EventHandler(this.بحثالخططالعلاجيةToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 569);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عيادة الدكتور مهند السرخي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientMenu;
        private System.Windows.Forms.ToolStripMenuItem addPatient;
        private System.Windows.Forms.ToolStripMenuItem updatePatient;
        private System.Windows.Forms.ToolStripMenuItem deletePatient;
        private System.Windows.Forms.ToolStripMenuItem patientList;
        private System.Windows.Forms.ToolStripMenuItem TratementMenu;
        private System.Windows.Forms.ToolStripMenuItem addTratement;
        private System.Windows.Forms.ToolStripMenuItem updateTratement;
        private System.Windows.Forms.ToolStripMenuItem deleteTratement;
        private System.Windows.Forms.ToolStripMenuItem IncomeMenu;
        private System.Windows.Forms.ToolStripMenuItem addIncome;
        private System.Windows.Forms.ToolStripMenuItem updateIncome;
        private System.Windows.Forms.ToolStripMenuItem deleteIncome;
        private System.Windows.Forms.ToolStripMenuItem OutComeMenu;
        private System.Windows.Forms.ToolStripMenuItem addOutcome;
        private System.Windows.Forms.ToolStripMenuItem updateOutcome;
        private System.Windows.Forms.ToolStripMenuItem deleteOutcome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem الجردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الجردالشهريToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الجردالسنويToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالجلساتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem البيانالماليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الدفعبالشيكاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الخطةالعلاجيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بحثالخططالعلاجيةToolStripMenuItem;
    }
}

