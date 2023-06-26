
namespace DentalClinic.view
{
    partial class PaymentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_paymentDate = new System.Windows.Forms.TextBox();
            this.btn_deletePayment = new System.Windows.Forms.Button();
            this.btn_updatePayment = new System.Windows.Forms.Button();
            this.btn_addPayment = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_paymentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_paymentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.cbx_patientList.Location = new System.Drawing.Point(542, 50);
            this.cbx_patientList.Name = "cbx_patientList";
            this.cbx_patientList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_patientList.Size = new System.Drawing.Size(696, 46);
            this.cbx_patientList.TabIndex = 17;
            this.cbx_patientList.SelectedIndexChanged += new System.EventHandler(this.cbx_patientList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.txt_paymentDate);
            this.panel1.Controls.Add(this.btn_deletePayment);
            this.panel1.Controls.Add(this.btn_updatePayment);
            this.panel1.Controls.Add(this.btn_addPayment);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_paymentId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_paymentAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_patientName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(542, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 499);
            this.panel1.TabIndex = 15;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(691, 401);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(147, 67);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "تحديث ";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_paymentDate
            // 
            this.txt_paymentDate.Enabled = false;
            this.txt_paymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentDate.Location = new System.Drawing.Point(74, 317);
            this.txt_paymentDate.Name = "txt_paymentDate";
            this.txt_paymentDate.Size = new System.Drawing.Size(403, 34);
            this.txt_paymentDate.TabIndex = 13;
            // 
            // btn_deletePayment
            // 
            this.btn_deletePayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePayment.Location = new System.Drawing.Point(74, 401);
            this.btn_deletePayment.Name = "btn_deletePayment";
            this.btn_deletePayment.Size = new System.Drawing.Size(160, 67);
            this.btn_deletePayment.TabIndex = 12;
            this.btn_deletePayment.Text = "حذف";
            this.btn_deletePayment.UseVisualStyleBackColor = false;
            this.btn_deletePayment.Click += new System.EventHandler(this.btn_deletePayment_Click);
            // 
            // btn_updatePayment
            // 
            this.btn_updatePayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_updatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePayment.Location = new System.Drawing.Point(287, 401);
            this.btn_updatePayment.Name = "btn_updatePayment";
            this.btn_updatePayment.Size = new System.Drawing.Size(153, 67);
            this.btn_updatePayment.TabIndex = 11;
            this.btn_updatePayment.Text = "تعديل ";
            this.btn_updatePayment.UseVisualStyleBackColor = false;
            this.btn_updatePayment.Click += new System.EventHandler(this.btn_updatePayment_Click);
            // 
            // btn_addPayment
            // 
            this.btn_addPayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPayment.Location = new System.Drawing.Point(492, 401);
            this.btn_addPayment.Name = "btn_addPayment";
            this.btn_addPayment.Size = new System.Drawing.Size(147, 67);
            this.btn_addPayment.TabIndex = 10;
            this.btn_addPayment.Text = "اضافة ";
            this.btn_addPayment.UseVisualStyleBackColor = false;
            this.btn_addPayment.Click += new System.EventHandler(this.btn_addPayment_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 34);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 261);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(198, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ الدفعة : ";
            // 
            // txt_paymentId
            // 
            this.txt_paymentId.Enabled = false;
            this.txt_paymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentId.Location = new System.Drawing.Point(74, 28);
            this.txt_paymentId.Multiline = true;
            this.txt_paymentId.Name = "txt_paymentId";
            this.txt_paymentId.Size = new System.Drawing.Size(403, 44);
            this.txt_paymentId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(245, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم تعريف الدفعة:";
            // 
            // txt_paymentAmount
            // 
            this.txt_paymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentAmount.Location = new System.Drawing.Point(74, 173);
            this.txt_paymentAmount.Name = "txt_paymentAmount";
            this.txt_paymentAmount.Size = new System.Drawing.Size(403, 34);
            this.txt_paymentAmount.TabIndex = 3;
            this.txt_paymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patientSSN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 173);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(178, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "مقدار الدفعة:";
            // 
            // txt_patientName
            // 
            this.txt_patientName.Enabled = false;
            this.txt_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientName.Location = new System.Drawing.Point(74, 99);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(403, 34);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(25, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 499);
            this.panel2.TabIndex = 18;
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
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(9, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 364);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "رقم الدفعة";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pname";
            this.Column2.HeaderText = "اسم المريض";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "تاريخ الدفعة";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "amount";
            this.Column4.HeaderText = "مقدار الدفعة";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 19);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(123, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "الدفعات:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1244, 48);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(163, 55);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "بحث";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 713);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbx_patientList);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة الدفعات";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_patientList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_paymentDate;
        private System.Windows.Forms.Button btn_deletePayment;
        private System.Windows.Forms.Button btn_updatePayment;
        private System.Windows.Forms.Button btn_addPayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_paymentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_paymentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
    }
}