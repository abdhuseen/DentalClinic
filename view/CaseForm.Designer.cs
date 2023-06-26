
namespace DentalClinic.view
{
    partial class CaseForm
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
            this.cbx_patientList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_caseDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_caseBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_caseID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updatePatient = new System.Windows.Forms.Button();
            this.btn_addTreatment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cbx_tratementList = new System.Windows.Forms.ComboBox();
            this.btn_searchTreatment = new System.Windows.Forms.Button();
            this.maxprice_radioButton1 = new System.Windows.Forms.RadioButton();
            this.middelprice_radioButton2 = new System.Windows.Forms.RadioButton();
            this.minprice_radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.btn_addCase = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_patientList
            // 
            this.cbx_patientList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_patientList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_patientList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_patientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_patientList.FormattingEnabled = true;
            this.cbx_patientList.Location = new System.Drawing.Point(25, 1);
            this.cbx_patientList.Name = "cbx_patientList";
            this.cbx_patientList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_patientList.Size = new System.Drawing.Size(762, 46);
            this.cbx_patientList.TabIndex = 17;
            this.cbx_patientList.SelectedIndexChanged += new System.EventHandler(this.cbx_patientList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_caseDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_caseBalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_caseID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_patientName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 453);
            this.panel1.TabIndex = 15;
            // 
            // txt_caseDate
            // 
            this.txt_caseDate.Enabled = false;
            this.txt_caseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caseDate.Location = new System.Drawing.Point(74, 308);
            this.txt_caseDate.Multiline = true;
            this.txt_caseDate.Name = "txt_caseDate";
            this.txt_caseDate.Size = new System.Drawing.Size(403, 44);
            this.txt_caseDate.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 34);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 249);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(191, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ الجلسة:";
            // 
            // txt_caseBalance
            // 
            this.txt_caseBalance.Enabled = false;
            this.txt_caseBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caseBalance.Location = new System.Drawing.Point(74, 179);
            this.txt_caseBalance.Multiline = true;
            this.txt_caseBalance.Name = "txt_caseBalance";
            this.txt_caseBalance.Size = new System.Drawing.Size(403, 44);
            this.txt_caseBalance.TabIndex = 7;
            this.txt_caseBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 179);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(183, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "تكلفة الجلسة:";
            // 
            // txt_caseID
            // 
            this.txt_caseID.Enabled = false;
            this.txt_caseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caseID.Location = new System.Drawing.Point(74, 28);
            this.txt_caseID.Multiline = true;
            this.txt_caseID.Name = "txt_caseID";
            this.txt_caseID.Size = new System.Drawing.Size(403, 44);
            this.txt_caseID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(258, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم تعريف الجلسة:";
            // 
            // txt_patientName
            // 
            this.txt_patientName.Enabled = false;
            this.txt_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientName.Location = new System.Drawing.Point(74, 99);
            this.txt_patientName.Multiline = true;
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(403, 44);
            this.txt_patientName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 99);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المريض :";
            // 
            // btn_updatePatient
            // 
            this.btn_updatePatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_updatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePatient.Location = new System.Drawing.Point(802, 825);
            this.btn_updatePatient.Name = "btn_updatePatient";
            this.btn_updatePatient.Size = new System.Drawing.Size(654, 67);
            this.btn_updatePatient.TabIndex = 11;
            this.btn_updatePatient.Text = "حذف علاج ";
            this.btn_updatePatient.UseVisualStyleBackColor = false;
            this.btn_updatePatient.Click += new System.EventHandler(this.btn_updatePatient_Click);
            // 
            // btn_addTreatment
            // 
            this.btn_addTreatment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTreatment.Location = new System.Drawing.Point(802, 492);
            this.btn_addTreatment.Name = "btn_addTreatment";
            this.btn_addTreatment.Size = new System.Drawing.Size(654, 67);
            this.btn_addTreatment.TabIndex = 10;
            this.btn_addTreatment.Text = "اضافة علاج ";
            this.btn_addTreatment.UseVisualStyleBackColor = false;
            this.btn_addTreatment.Click += new System.EventHandler(this.btn_addTreatment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(802, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 380);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "رقم العلاج";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "اسم العلاج";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "minprice";
            this.Column3.HeaderText = "اقل قيمة للعلاج";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "middelprice";
            this.Column4.HeaderText = "متوسط قيمة العلاج";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "maxprice";
            this.Column5.HeaderText = "اعلى قيمة للعلاج";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(802, 565);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(654, 254);
            this.listBox2.TabIndex = 20;
            // 
            // cbx_tratementList
            // 
            this.cbx_tratementList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_tratementList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_tratementList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_tratementList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tratementList.FormattingEnabled = true;
            this.cbx_tratementList.Location = new System.Drawing.Point(802, 1);
            this.cbx_tratementList.Name = "cbx_tratementList";
            this.cbx_tratementList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_tratementList.Size = new System.Drawing.Size(518, 46);
            this.cbx_tratementList.TabIndex = 22;
            // 
            // btn_searchTreatment
            // 
            this.btn_searchTreatment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_searchTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchTreatment.Location = new System.Drawing.Point(1344, 1);
            this.btn_searchTreatment.Name = "btn_searchTreatment";
            this.btn_searchTreatment.Size = new System.Drawing.Size(101, 51);
            this.btn_searchTreatment.TabIndex = 21;
            this.btn_searchTreatment.Text = "بحث";
            this.btn_searchTreatment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_searchTreatment.UseVisualStyleBackColor = false;
            this.btn_searchTreatment.Click += new System.EventHandler(this.btn_searchTreatment_Click);
            // 
            // maxprice_radioButton1
            // 
            this.maxprice_radioButton1.AutoSize = true;
            this.maxprice_radioButton1.Location = new System.Drawing.Point(6, 19);
            this.maxprice_radioButton1.Name = "maxprice_radioButton1";
            this.maxprice_radioButton1.Size = new System.Drawing.Size(103, 21);
            this.maxprice_radioButton1.TabIndex = 23;
            this.maxprice_radioButton1.TabStop = true;
            this.maxprice_radioButton1.Text = "اعلى سعر علاج";
            this.maxprice_radioButton1.UseVisualStyleBackColor = true;
            // 
            // middelprice_radioButton2
            // 
            this.middelprice_radioButton2.AutoSize = true;
            this.middelprice_radioButton2.Location = new System.Drawing.Point(225, 19);
            this.middelprice_radioButton2.Name = "middelprice_radioButton2";
            this.middelprice_radioButton2.Size = new System.Drawing.Size(89, 21);
            this.middelprice_radioButton2.TabIndex = 24;
            this.middelprice_radioButton2.TabStop = true;
            this.middelprice_radioButton2.Text = "متوسط السعر";
            this.middelprice_radioButton2.UseVisualStyleBackColor = true;
            // 
            // minprice_radioButton3
            // 
            this.minprice_radioButton3.AutoSize = true;
            this.minprice_radioButton3.Location = new System.Drawing.Point(436, 19);
            this.minprice_radioButton3.Name = "minprice_radioButton3";
            this.minprice_radioButton3.Size = new System.Drawing.Size(67, 21);
            this.minprice_radioButton3.TabIndex = 25;
            this.minprice_radioButton3.TabStop = true;
            this.minprice_radioButton3.Text = "اقل سعر";
            this.minprice_radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.maxprice_radioButton1);
            this.panel2.Controls.Add(this.minprice_radioButton3);
            this.panel2.Controls.Add(this.middelprice_radioButton2);
            this.panel2.Location = new System.Drawing.Point(802, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 47);
            this.panel2.TabIndex = 26;
            // 
            // txt_notes
            // 
            this.txt_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notes.Location = new System.Drawing.Point(12, 519);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(775, 280);
            this.txt_notes.TabIndex = 27;
            this.txt_notes.Text = "add Note";
            // 
            // btn_addCase
            // 
            this.btn_addCase.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCase.Location = new System.Drawing.Point(12, 825);
            this.btn_addCase.Name = "btn_addCase";
            this.btn_addCase.Size = new System.Drawing.Size(775, 67);
            this.btn_addCase.TabIndex = 28;
            this.btn_addCase.Text = "اضافة جلسة";
            this.btn_addCase.UseVisualStyleBackColor = false;
            this.btn_addCase.Click += new System.EventHandler(this.btn_addCase_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 969);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_addCase);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbx_tratementList);
            this.Controls.Add(this.btn_searchTreatment);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_patientList);
            this.Controls.Add(this.btn_updatePatient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_addTreatment);
            this.MaximizeBox = false;
            this.Name = "CaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة الحالات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_patientList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_caseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_caseBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_caseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updatePatient;
        private System.Windows.Forms.Button btn_addTreatment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox cbx_tratementList;
        private System.Windows.Forms.Button btn_searchTreatment;
        private System.Windows.Forms.RadioButton maxprice_radioButton1;
        private System.Windows.Forms.RadioButton middelprice_radioButton2;
        private System.Windows.Forms.RadioButton minprice_radioButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Button btn_addCase;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}