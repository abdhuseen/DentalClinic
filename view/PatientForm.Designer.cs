
namespace DentalClinic.view
{
    partial class PatientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_birthDate = new System.Windows.Forms.TextBox();
            this.btn_deletePatient = new System.Windows.Forms.Button();
            this.btn_updatePatient = new System.Windows.Forms.Button();
            this.btn_addPatient = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_patientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_patientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_patientSSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbx_patientList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.txt_birthDate);
            this.panel1.Controls.Add(this.btn_deletePatient);
            this.panel1.Controls.Add(this.btn_updatePatient);
            this.panel1.Controls.Add(this.btn_addPatient);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_patientPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_patientID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_patientSSN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_patientName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(139, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 559);
            this.panel1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(631, 466);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(184, 67);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "تحديث ";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_birthDate
            // 
            this.txt_birthDate.Enabled = false;
            this.txt_birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthDate.Location = new System.Drawing.Point(74, 369);
            this.txt_birthDate.Name = "txt_birthDate";
            this.txt_birthDate.Size = new System.Drawing.Size(403, 34);
            this.txt_birthDate.TabIndex = 13;
            // 
            // btn_deletePatient
            // 
            this.btn_deletePatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePatient.Location = new System.Drawing.Point(14, 466);
            this.btn_deletePatient.Name = "btn_deletePatient";
            this.btn_deletePatient.Size = new System.Drawing.Size(197, 67);
            this.btn_deletePatient.TabIndex = 12;
            this.btn_deletePatient.Text = "حذف";
            this.btn_deletePatient.UseVisualStyleBackColor = false;
            this.btn_deletePatient.Click += new System.EventHandler(this.btn_deletePatient_Click);
            // 
            // btn_updatePatient
            // 
            this.btn_updatePatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_updatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePatient.Location = new System.Drawing.Point(227, 466);
            this.btn_updatePatient.Name = "btn_updatePatient";
            this.btn_updatePatient.Size = new System.Drawing.Size(190, 67);
            this.btn_updatePatient.TabIndex = 11;
            this.btn_updatePatient.Text = "تعديل ";
            this.btn_updatePatient.UseVisualStyleBackColor = false;
            this.btn_updatePatient.Click += new System.EventHandler(this.btn_updatePatient_Click);
            // 
            // btn_addPatient
            // 
            this.btn_addPatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPatient.Location = new System.Drawing.Point(432, 466);
            this.btn_addPatient.Name = "btn_addPatient";
            this.btn_addPatient.Size = new System.Drawing.Size(184, 67);
            this.btn_addPatient.TabIndex = 10;
            this.btn_addPatient.Text = "اضافة ";
            this.btn_addPatient.UseVisualStyleBackColor = false;
            this.btn_addPatient.Click += new System.EventHandler(this.btn_addPatient_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 325);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 34);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 315);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(184, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ الميلاد:";
            // 
            // txt_patientPhone
            // 
            this.txt_patientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientPhone.Location = new System.Drawing.Point(74, 250);
            this.txt_patientPhone.Name = "txt_patientPhone";
            this.txt_patientPhone.Size = new System.Drawing.Size(403, 34);
            this.txt_patientPhone.TabIndex = 7;
            this.txt_patientPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_patientPhone_KeyDown);
            this.txt_patientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patientSSN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 250);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(164, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "رقم التلفون:";
            // 
            // txt_patientID
            // 
            this.txt_patientID.Enabled = false;
            this.txt_patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientID.Location = new System.Drawing.Point(74, 28);
            this.txt_patientID.Multiline = true;
            this.txt_patientID.Name = "txt_patientID";
            this.txt_patientID.Size = new System.Drawing.Size(403, 44);
            this.txt_patientID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(274, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم تعريف المريض:";
            // 
            // txt_patientSSN
            // 
            this.txt_patientSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientSSN.Location = new System.Drawing.Point(74, 173);
            this.txt_patientSSN.Name = "txt_patientSSN";
            this.txt_patientSSN.Size = new System.Drawing.Size(403, 34);
            this.txt_patientSSN.TabIndex = 3;
            this.txt_patientSSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_patientSSN_KeyDown);
            this.txt_patientSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patientSSN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 173);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(155, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الهوية:";
            // 
            // txt_patientName
            // 
            this.txt_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientName.Location = new System.Drawing.Point(74, 99);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(403, 34);
            this.txt_patientName.TabIndex = 1;
            this.txt_patientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_patientName_KeyDown);
            this.txt_patientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patientName_KeyPress);
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
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(139, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(197, 55);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "بحث";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbx_patientList
            // 
            this.cbx_patientList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_patientList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_patientList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_patientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_patientList.FormattingEnabled = true;
            this.cbx_patientList.Location = new System.Drawing.Point(342, 37);
            this.cbx_patientList.Name = "cbx_patientList";
            this.cbx_patientList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_patientList.Size = new System.Drawing.Size(649, 46);
            this.cbx_patientList.TabIndex = 14;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 738);
            this.Controls.Add(this.cbx_patientList);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Name = "PatientForm";
            this.Text = "شاشة ادارة المرضى";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_patientSSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_patientPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_patientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_deletePatient;
        private System.Windows.Forms.Button btn_updatePatient;
        private System.Windows.Forms.Button btn_addPatient;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbx_patientList;
        private System.Windows.Forms.TextBox txt_birthDate;
        private System.Windows.Forms.Button btn_refresh;
    }
}