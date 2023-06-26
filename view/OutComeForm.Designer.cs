
namespace DentalClinic.view
{
    partial class OutComeForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.cbx_outcomeTypesList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_outcometDate = new System.Windows.Forms.TextBox();
            this.btn_deleteOutCome = new System.Windows.Forms.Button();
            this.btn_updateOutCome = new System.Windows.Forms.Button();
            this.btn_addOutCome = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_outcomeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_outcomeAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_outcomeType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(11, 142);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(491, 48);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "بحث";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbx_outcomeTypesList
            // 
            this.cbx_outcomeTypesList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_outcomeTypesList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_outcomeTypesList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_outcomeTypesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_outcomeTypesList.FormattingEnabled = true;
            this.cbx_outcomeTypesList.Location = new System.Drawing.Point(519, 144);
            this.cbx_outcomeTypesList.Name = "cbx_outcomeTypesList";
            this.cbx_outcomeTypesList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_outcomeTypesList.Size = new System.Drawing.Size(865, 46);
            this.cbx_outcomeTypesList.TabIndex = 21;
            this.cbx_outcomeTypesList.SelectedIndexChanged += new System.EventHandler(this.cbx_outcomeTypesList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.txt_outcometDate);
            this.panel1.Controls.Add(this.btn_deleteOutCome);
            this.panel1.Controls.Add(this.btn_updateOutCome);
            this.panel1.Controls.Add(this.btn_addOutCome);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_outcomeId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_outcomeAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_outcomeType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(519, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 499);
            this.panel1.TabIndex = 20;
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
            // txt_outcometDate
            // 
            this.txt_outcometDate.Enabled = false;
            this.txt_outcometDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outcometDate.Location = new System.Drawing.Point(74, 317);
            this.txt_outcometDate.Name = "txt_outcometDate";
            this.txt_outcometDate.Size = new System.Drawing.Size(403, 34);
            this.txt_outcometDate.TabIndex = 13;
            // 
            // btn_deleteOutCome
            // 
            this.btn_deleteOutCome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deleteOutCome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteOutCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteOutCome.Location = new System.Drawing.Point(74, 401);
            this.btn_deleteOutCome.Name = "btn_deleteOutCome";
            this.btn_deleteOutCome.Size = new System.Drawing.Size(160, 67);
            this.btn_deleteOutCome.TabIndex = 12;
            this.btn_deleteOutCome.Text = "حذف";
            this.btn_deleteOutCome.UseVisualStyleBackColor = false;
            this.btn_deleteOutCome.Click += new System.EventHandler(this.btn_deleteOutCome_Click);
            // 
            // btn_updateOutCome
            // 
            this.btn_updateOutCome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_updateOutCome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateOutCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateOutCome.Location = new System.Drawing.Point(287, 401);
            this.btn_updateOutCome.Name = "btn_updateOutCome";
            this.btn_updateOutCome.Size = new System.Drawing.Size(153, 67);
            this.btn_updateOutCome.TabIndex = 11;
            this.btn_updateOutCome.Text = "تعديل ";
            this.btn_updateOutCome.UseVisualStyleBackColor = false;
            this.btn_updateOutCome.Click += new System.EventHandler(this.btn_updateOutCome_Click);
            // 
            // btn_addOutCome
            // 
            this.btn_addOutCome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addOutCome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOutCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOutCome.Location = new System.Drawing.Point(492, 401);
            this.btn_addOutCome.Name = "btn_addOutCome";
            this.btn_addOutCome.Size = new System.Drawing.Size(147, 67);
            this.btn_addOutCome.TabIndex = 10;
            this.btn_addOutCome.Text = "اضافة ";
            this.btn_addOutCome.UseVisualStyleBackColor = false;
            this.btn_addOutCome.Click += new System.EventHandler(this.btn_addOutCome_Click);
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
            this.label5.Size = new System.Drawing.Size(255, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ المصروف : ";
            // 
            // txt_outcomeId
            // 
            this.txt_outcomeId.Enabled = false;
            this.txt_outcomeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outcomeId.Location = new System.Drawing.Point(74, 28);
            this.txt_outcomeId.Multiline = true;
            this.txt_outcomeId.Name = "txt_outcomeId";
            this.txt_outcomeId.Size = new System.Drawing.Size(403, 44);
            this.txt_outcomeId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(302, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم تعريف المصروف:";
            // 
            // txt_outcomeAmount
            // 
            this.txt_outcomeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outcomeAmount.Location = new System.Drawing.Point(74, 173);
            this.txt_outcomeAmount.Name = "txt_outcomeAmount";
            this.txt_outcomeAmount.Size = new System.Drawing.Size(403, 34);
            this.txt_outcomeAmount.TabIndex = 3;
            this.txt_outcomeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_outcomeAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 173);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(235, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "مقدار المصروف:";
            // 
            // txt_outcomeType
            // 
            this.txt_outcomeType.Enabled = false;
            this.txt_outcomeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outcomeType.Location = new System.Drawing.Point(74, 99);
            this.txt_outcomeType.Name = "txt_outcomeType";
            this.txt_outcomeType.Size = new System.Drawing.Size(403, 34);
            this.txt_outcomeType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 99);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(225, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع المصروف :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 499);
            this.panel2.TabIndex = 25;
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
            this.Column1.HeaderText = "رقم المصروف";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "type";
            this.Column2.HeaderText = "نوع المصروف";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "تاريخ المصروف";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "amount";
            this.Column4.HeaderText = "مقدار المصروف";
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
            this.label4.Size = new System.Drawing.Size(176, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "المصروفات:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(490, 22);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // OutComeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 777);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbx_outcomeTypesList);
            this.Controls.Add(this.panel1);
            this.Name = "OutComeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "OutComeForm";
            this.Load += new System.EventHandler(this.OutComeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbx_outcomeTypesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_outcometDate;
        private System.Windows.Forms.Button btn_deleteOutCome;
        private System.Windows.Forms.Button btn_updateOutCome;
        private System.Windows.Forms.Button btn_addOutCome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_outcomeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_outcomeAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_outcomeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}