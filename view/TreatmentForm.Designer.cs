
namespace DentalClinic.view
{
    partial class TreatmentForm
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
            this.cbx_tratementList = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_maxPrice = new System.Windows.Forms.TextBox();
            this.btn_deleteTratement = new System.Windows.Forms.Button();
            this.btn_updateTratement = new System.Windows.Forms.Button();
            this.btn_addTratement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_middelPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tratementId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_minPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tratementName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_tratementList
            // 
            this.cbx_tratementList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_tratementList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_tratementList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_tratementList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tratementList.FormattingEnabled = true;
            this.cbx_tratementList.Location = new System.Drawing.Point(283, 54);
            this.cbx_tratementList.Name = "cbx_tratementList";
            this.cbx_tratementList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_tratementList.Size = new System.Drawing.Size(614, 46);
            this.cbx_tratementList.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(917, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(197, 54);
            this.btn_search.TabIndex = 16;
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
            this.panel1.Controls.Add(this.txt_maxPrice);
            this.panel1.Controls.Add(this.btn_deleteTratement);
            this.panel1.Controls.Add(this.btn_updateTratement);
            this.panel1.Controls.Add(this.btn_addTratement);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_middelPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_tratementId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_minPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_tratementName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(249, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 553);
            this.panel1.TabIndex = 15;
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
            // txt_maxPrice
            // 
            this.txt_maxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxPrice.Location = new System.Drawing.Point(74, 327);
            this.txt_maxPrice.Name = "txt_maxPrice";
            this.txt_maxPrice.Size = new System.Drawing.Size(403, 34);
            this.txt_maxPrice.TabIndex = 13;
            this.txt_maxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_maxPrice_KeyDown);
            this.txt_maxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minPrice_KeyPress);
            // 
            // btn_deleteTratement
            // 
            this.btn_deleteTratement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deleteTratement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteTratement.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteTratement.Location = new System.Drawing.Point(14, 466);
            this.btn_deleteTratement.Name = "btn_deleteTratement";
            this.btn_deleteTratement.Size = new System.Drawing.Size(197, 67);
            this.btn_deleteTratement.TabIndex = 12;
            this.btn_deleteTratement.Text = "حذف";
            this.btn_deleteTratement.UseVisualStyleBackColor = false;
            this.btn_deleteTratement.Click += new System.EventHandler(this.btn_deleteTratement_Click);
            // 
            // btn_updateTratement
            // 
            this.btn_updateTratement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_updateTratement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateTratement.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateTratement.Location = new System.Drawing.Point(227, 466);
            this.btn_updateTratement.Name = "btn_updateTratement";
            this.btn_updateTratement.Size = new System.Drawing.Size(190, 67);
            this.btn_updateTratement.TabIndex = 11;
            this.btn_updateTratement.Text = "تعديل ";
            this.btn_updateTratement.UseVisualStyleBackColor = false;
            this.btn_updateTratement.Click += new System.EventHandler(this.btn_updateTratement_Click);
            // 
            // btn_addTratement
            // 
            this.btn_addTratement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addTratement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTratement.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTratement.Location = new System.Drawing.Point(432, 466);
            this.btn_addTratement.Name = "btn_addTratement";
            this.btn_addTratement.Size = new System.Drawing.Size(184, 67);
            this.btn_addTratement.TabIndex = 10;
            this.btn_addTratement.Text = "اضافة ";
            this.btn_addTratement.UseVisualStyleBackColor = false;
            this.btn_addTratement.Click += new System.EventHandler(this.btn_addTratement_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 318);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(242, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "اعلى سعر للعلاج:";
            // 
            // txt_middelPrice
            // 
            this.txt_middelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_middelPrice.Location = new System.Drawing.Point(74, 250);
            this.txt_middelPrice.Name = "txt_middelPrice";
            this.txt_middelPrice.Size = new System.Drawing.Size(403, 34);
            this.txt_middelPrice.TabIndex = 7;
            this.txt_middelPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_middelPrice_KeyDown);
            this.txt_middelPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 250);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(268, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "متوسط سعر العلاج:";
            // 
            // txt_tratementId
            // 
            this.txt_tratementId.Enabled = false;
            this.txt_tratementId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tratementId.Location = new System.Drawing.Point(74, 28);
            this.txt_tratementId.Multiline = true;
            this.txt_tratementId.Name = "txt_tratementId";
            this.txt_tratementId.Size = new System.Drawing.Size(403, 44);
            this.txt_tratementId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(250, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم تعريف العلاج:";
            // 
            // txt_minPrice
            // 
            this.txt_minPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minPrice.Location = new System.Drawing.Point(74, 173);
            this.txt_minPrice.Name = "txt_minPrice";
            this.txt_minPrice.Size = new System.Drawing.Size(403, 34);
            this.txt_minPrice.TabIndex = 3;
            this.txt_minPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_minPrice_KeyDown);
            this.txt_minPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 173);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(221, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "اقل سعر للعلاج:";
            // 
            // txt_tratementName
            // 
            this.txt_tratementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tratementName.Location = new System.Drawing.Point(74, 99);
            this.txt_tratementName.Name = "txt_tratementName";
            this.txt_tratementName.Size = new System.Drawing.Size(403, 34);
            this.txt_tratementName.TabIndex = 1;
            this.txt_tratementName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tratementName_KeyDown);
            this.txt_tratementName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tratementName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 99);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(172, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العلاج :";
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 748);
            this.Controls.Add(this.cbx_tratementList);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Name = "TreatmentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة العلاجات";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_tratementList;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_maxPrice;
        private System.Windows.Forms.Button btn_deleteTratement;
        private System.Windows.Forms.Button btn_updateTratement;
        private System.Windows.Forms.Button btn_addTratement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_middelPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tratementId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_minPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tratementName;
        private System.Windows.Forms.Label label1;
    }
}