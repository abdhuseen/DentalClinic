
namespace DentalClinic.view
{
    partial class MoneyCheckForm
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
            this.cbx_patientList = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_checkDate = new System.Windows.Forms.TextBox();
            this.btn_deletePatient = new System.Windows.Forms.Button();
            this.btn_updatePatient = new System.Windows.Forms.Button();
            this.btn_addCheck = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_checkID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_checkValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_checkNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_patientList
            // 
            this.cbx_patientList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_patientList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_patientList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_patientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_patientList.FormattingEnabled = true;
            this.cbx_patientList.Location = new System.Drawing.Point(12, 12);
            this.cbx_patientList.Name = "cbx_patientList";
            this.cbx_patientList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_patientList.Size = new System.Drawing.Size(649, 46);
            this.cbx_patientList.TabIndex = 20;
            this.cbx_patientList.SelectedIndexChanged += new System.EventHandler(this.cbx_patientList_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(680, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(197, 46);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "بحث";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.txt_checkDate);
            this.panel1.Controls.Add(this.btn_deletePatient);
            this.panel1.Controls.Add(this.btn_updatePatient);
            this.panel1.Controls.Add(this.btn_addCheck);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_patientName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_checkID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_checkValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_checkNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 559);
            this.panel1.TabIndex = 21;
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
            // txt_checkDate
            // 
            this.txt_checkDate.Enabled = false;
            this.txt_checkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkDate.Location = new System.Drawing.Point(74, 369);
            this.txt_checkDate.Multiline = true;
            this.txt_checkDate.Name = "txt_checkDate";
            this.txt_checkDate.Size = new System.Drawing.Size(403, 44);
            this.txt_checkDate.TabIndex = 13;
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
            // btn_addCheck
            // 
            this.btn_addCheck.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCheck.Location = new System.Drawing.Point(432, 466);
            this.btn_addCheck.Name = "btn_addCheck";
            this.btn_addCheck.Size = new System.Drawing.Size(184, 67);
            this.btn_addCheck.TabIndex = 10;
            this.btn_addCheck.Text = "اضافة ";
            this.btn_addCheck.UseVisualStyleBackColor = false;
            this.btn_addCheck.Click += new System.EventHandler(this.btn_addCheck_Click);
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
            this.label5.Location = new System.Drawing.Point(530, 318);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(269, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ صرف الشيك:";
            // 
            // txt_patientName
            // 
            this.txt_patientName.Enabled = false;
            this.txt_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientName.Location = new System.Drawing.Point(74, 250);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(403, 34);
            this.txt_patientName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 250);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(186, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "اسم المريض:";
            // 
            // txt_checkID
            // 
            this.txt_checkID.Enabled = false;
            this.txt_checkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkID.Location = new System.Drawing.Point(74, 28);
            this.txt_checkID.Multiline = true;
            this.txt_checkID.Name = "txt_checkID";
            this.txt_checkID.Size = new System.Drawing.Size(403, 44);
            this.txt_checkID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(191, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "معرف الشيك:";
            // 
            // txt_checkValue
            // 
            this.txt_checkValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkValue.Location = new System.Drawing.Point(74, 173);
            this.txt_checkValue.Name = "txt_checkValue";
            this.txt_checkValue.Size = new System.Drawing.Size(403, 34);
            this.txt_checkValue.TabIndex = 3;
            this.txt_checkValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_checkValue_KeyDown);
            this.txt_checkValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_checkNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 173);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(163, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "قيمة الشيك:";
            // 
            // txt_checkNumber
            // 
            this.txt_checkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkNumber.Location = new System.Drawing.Point(74, 99);
            this.txt_checkNumber.Name = "txt_checkNumber";
            this.txt_checkNumber.Size = new System.Drawing.Size(403, 34);
            this.txt_checkNumber.TabIndex = 1;
            this.txt_checkNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_checkNumber_KeyDown);
            this.txt_checkNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_checkNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 99);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(165, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الشيك :";
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
            this.dataGridView1.Location = new System.Drawing.Point(870, 113);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 559);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "رقم معرف الشيك";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "number";
            this.Column2.HeaderText = "رقم الشيك";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "value";
            this.Column3.HeaderText = "قيمة الشيك";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "date";
            this.Column4.HeaderText = "تاريخ صرف الشيك";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pname";
            this.Column5.HeaderText = "اسم المريض";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // MoneyCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 788);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_patientList);
            this.Controls.Add(this.btn_search);
            this.Name = "MoneyCheckForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الشيكات الواردة";
            this.Load += new System.EventHandler(this.MoneyCheckForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_patientList;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_checkDate;
        private System.Windows.Forms.Button btn_deletePatient;
        private System.Windows.Forms.Button btn_updatePatient;
        private System.Windows.Forms.Button btn_addCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_checkID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_checkValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_checkNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}