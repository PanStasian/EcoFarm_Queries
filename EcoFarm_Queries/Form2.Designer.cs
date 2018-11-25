namespace EcoFarm_Queries
{
    partial class Form2
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
            this.param_grid = new System.Windows.Forms.DataGridView();
            this.select_odbc = new System.Windows.Forms.Button();
            this.paramming = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table_comb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.field_comb = new System.Windows.Forms.ComboBox();
            this.odbc_select_scalar = new System.Windows.Forms.Button();
            this.ScalTB = new System.Windows.Forms.TextBox();
            this.odbc_insert_Pos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pos_codeTB = new System.Windows.Forms.TextBox();
            this.Pos_nameTB = new System.Windows.Forms.TextBox();
            this.Depart_codeTB = new System.Windows.Forms.TextBox();
            this.ActivityTB = new System.Windows.Forms.TextBox();
            this.sql_select = new System.Windows.Forms.Button();
            this.scalar_sqlTB = new System.Windows.Forms.TextBox();
            this.sql_scalar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sql_insert = new System.Windows.Forms.Button();
            this.emp_numTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.emp_nameTB = new System.Windows.Forms.TextBox();
            this.emp_phoneTB = new System.Windows.Forms.TextBox();
            this.emp_adrTB = new System.Windows.Forms.TextBox();
            this.emp_pos_codeTB = new System.Windows.Forms.TextBox();
            this.emp_passp_numbTB = new System.Windows.Forms.TextBox();
            this.emp_passp_serTB = new System.Windows.Forms.TextBox();
            this.emp_birthTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.param_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // param_grid
            // 
            this.param_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.param_grid.Location = new System.Drawing.Point(10, 322);
            this.param_grid.Name = "param_grid";
            this.param_grid.RowTemplate.Height = 24;
            this.param_grid.Size = new System.Drawing.Size(776, 242);
            this.param_grid.TabIndex = 0;
            // 
            // select_odbc
            // 
            this.select_odbc.Location = new System.Drawing.Point(244, 19);
            this.select_odbc.Name = "select_odbc";
            this.select_odbc.Size = new System.Drawing.Size(101, 48);
            this.select_odbc.TabIndex = 1;
            this.select_odbc.Text = "ODBC Select";
            this.select_odbc.UseVisualStyleBackColor = true;
            this.select_odbc.Click += new System.EventHandler(this.select_odbc_Click);
            // 
            // paramming
            // 
            this.paramming.Location = new System.Drawing.Point(7, 22);
            this.paramming.Name = "paramming";
            this.paramming.Size = new System.Drawing.Size(149, 22);
            this.paramming.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paramming);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите параметр";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.table_comb);
            this.groupBox2.Location = new System.Drawing.Point(180, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "В таблице";
            // 
            // table_comb
            // 
            this.table_comb.FormattingEnabled = true;
            this.table_comb.Items.AddRange(new object[] {
            "Position",
            "Employees"});
            this.table_comb.Location = new System.Drawing.Point(6, 21);
            this.table_comb.Name = "table_comb";
            this.table_comb.Size = new System.Drawing.Size(104, 24);
            this.table_comb.TabIndex = 0;
            this.table_comb.SelectedIndexChanged += new System.EventHandler(this.table_comb_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.field_comb);
            this.groupBox3.Location = new System.Drawing.Point(302, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "В поле";
            // 
            // field_comb
            // 
            this.field_comb.FormattingEnabled = true;
            this.field_comb.Location = new System.Drawing.Point(7, 21);
            this.field_comb.Name = "field_comb";
            this.field_comb.Size = new System.Drawing.Size(137, 24);
            this.field_comb.TabIndex = 1;
            // 
            // odbc_select_scalar
            // 
            this.odbc_select_scalar.Location = new System.Drawing.Point(244, 79);
            this.odbc_select_scalar.Name = "odbc_select_scalar";
            this.odbc_select_scalar.Size = new System.Drawing.Size(157, 48);
            this.odbc_select_scalar.TabIndex = 6;
            this.odbc_select_scalar.Text = "ODBC Select Scalar";
            this.odbc_select_scalar.UseVisualStyleBackColor = true;
            this.odbc_select_scalar.Click += new System.EventHandler(this.odbc_select_scalar_Click);
            // 
            // ScalTB
            // 
            this.ScalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScalTB.Location = new System.Drawing.Point(407, 79);
            this.ScalTB.Multiline = true;
            this.ScalTB.Name = "ScalTB";
            this.ScalTB.Size = new System.Drawing.Size(46, 48);
            this.ScalTB.TabIndex = 7;
            this.ScalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // odbc_insert_Pos
            // 
            this.odbc_insert_Pos.Location = new System.Drawing.Point(6, 165);
            this.odbc_insert_Pos.Name = "odbc_insert_Pos";
            this.odbc_insert_Pos.Size = new System.Drawing.Size(216, 48);
            this.odbc_insert_Pos.TabIndex = 8;
            this.odbc_insert_Pos.Text = "ODBC insert to Position";
            this.odbc_insert_Pos.UseVisualStyleBackColor = true;
            this.odbc_insert_Pos.Click += new System.EventHandler(this.odbc_insert_Pos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ActivityTB);
            this.groupBox4.Controls.Add(this.odbc_insert_Pos);
            this.groupBox4.Controls.Add(this.Depart_codeTB);
            this.groupBox4.Controls.Add(this.Pos_nameTB);
            this.groupBox4.Controls.Add(this.Pos_codeTB);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 226);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Activity";
            // 
            // Pos_codeTB
            // 
            this.Pos_codeTB.Location = new System.Drawing.Point(107, 20);
            this.Pos_codeTB.Name = "Pos_codeTB";
            this.Pos_codeTB.Size = new System.Drawing.Size(115, 22);
            this.Pos_codeTB.TabIndex = 4;
            // 
            // Pos_nameTB
            // 
            this.Pos_nameTB.Location = new System.Drawing.Point(70, 50);
            this.Pos_nameTB.Name = "Pos_nameTB";
            this.Pos_nameTB.Size = new System.Drawing.Size(152, 22);
            this.Pos_nameTB.TabIndex = 5;
            // 
            // Depart_codeTB
            // 
            this.Depart_codeTB.Location = new System.Drawing.Point(122, 81);
            this.Depart_codeTB.Name = "Depart_codeTB";
            this.Depart_codeTB.Size = new System.Drawing.Size(100, 22);
            this.Depart_codeTB.TabIndex = 6;
            // 
            // ActivityTB
            // 
            this.ActivityTB.Location = new System.Drawing.Point(64, 112);
            this.ActivityTB.Name = "ActivityTB";
            this.ActivityTB.Size = new System.Drawing.Size(158, 22);
            this.ActivityTB.TabIndex = 7;
            // 
            // sql_select
            // 
            this.sql_select.Location = new System.Drawing.Point(244, 133);
            this.sql_select.Name = "sql_select";
            this.sql_select.Size = new System.Drawing.Size(113, 48);
            this.sql_select.TabIndex = 10;
            this.sql_select.Text = "SQL Select";
            this.sql_select.UseVisualStyleBackColor = true;
            this.sql_select.Click += new System.EventHandler(this.sql_select_Click);
            // 
            // scalar_sqlTB
            // 
            this.scalar_sqlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scalar_sqlTB.Location = new System.Drawing.Point(407, 190);
            this.scalar_sqlTB.Multiline = true;
            this.scalar_sqlTB.Name = "scalar_sqlTB";
            this.scalar_sqlTB.Size = new System.Drawing.Size(46, 48);
            this.scalar_sqlTB.TabIndex = 12;
            this.scalar_sqlTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sql_scalar
            // 
            this.sql_scalar.Location = new System.Drawing.Point(244, 190);
            this.sql_scalar.Name = "sql_scalar";
            this.sql_scalar.Size = new System.Drawing.Size(157, 48);
            this.sql_scalar.TabIndex = 11;
            this.sql_scalar.Text = "SQL Select Scalar";
            this.sql_scalar.UseVisualStyleBackColor = true;
            this.sql_scalar.Click += new System.EventHandler(this.sql_scalar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.emp_birthTB);
            this.groupBox5.Controls.Add(this.emp_passp_serTB);
            this.groupBox5.Controls.Add(this.emp_passp_numbTB);
            this.groupBox5.Controls.Add(this.emp_pos_codeTB);
            this.groupBox5.Controls.Add(this.emp_adrTB);
            this.groupBox5.Controls.Add(this.emp_phoneTB);
            this.groupBox5.Controls.Add(this.emp_nameTB);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.sql_insert);
            this.groupBox5.Controls.Add(this.emp_numTB);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(483, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 288);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employees";
            // 
            // sql_insert
            // 
            this.sql_insert.Location = new System.Drawing.Point(9, 237);
            this.sql_insert.Name = "sql_insert";
            this.sql_insert.Size = new System.Drawing.Size(288, 43);
            this.sql_insert.TabIndex = 8;
            this.sql_insert.Text = "SQL insert to Employees";
            this.sql_insert.UseVisualStyleBackColor = true;
            this.sql_insert.Click += new System.EventHandler(this.sql_insert_Click);
            // 
            // emp_numTB
            // 
            this.emp_numTB.Location = new System.Drawing.Point(136, 21);
            this.emp_numTB.Name = "emp_numTB";
            this.emp_numTB.Size = new System.Drawing.Size(161, 22);
            this.emp_numTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Full name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Position code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Passport number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Passport series";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Birth date";
            // 
            // emp_nameTB
            // 
            this.emp_nameTB.Location = new System.Drawing.Point(81, 53);
            this.emp_nameTB.Name = "emp_nameTB";
            this.emp_nameTB.Size = new System.Drawing.Size(216, 22);
            this.emp_nameTB.TabIndex = 13;
            // 
            // emp_phoneTB
            // 
            this.emp_phoneTB.Location = new System.Drawing.Point(64, 81);
            this.emp_phoneTB.Name = "emp_phoneTB";
            this.emp_phoneTB.Size = new System.Drawing.Size(233, 22);
            this.emp_phoneTB.TabIndex = 14;
            // 
            // emp_adrTB
            // 
            this.emp_adrTB.Location = new System.Drawing.Point(64, 109);
            this.emp_adrTB.Name = "emp_adrTB";
            this.emp_adrTB.Size = new System.Drawing.Size(233, 22);
            this.emp_adrTB.TabIndex = 15;
            // 
            // emp_pos_codeTB
            // 
            this.emp_pos_codeTB.Location = new System.Drawing.Point(96, 133);
            this.emp_pos_codeTB.Name = "emp_pos_codeTB";
            this.emp_pos_codeTB.Size = new System.Drawing.Size(201, 22);
            this.emp_pos_codeTB.TabIndex = 16;
            // 
            // emp_passp_numbTB
            // 
            this.emp_passp_numbTB.Location = new System.Drawing.Point(128, 158);
            this.emp_passp_numbTB.Name = "emp_passp_numbTB";
            this.emp_passp_numbTB.Size = new System.Drawing.Size(169, 22);
            this.emp_passp_numbTB.TabIndex = 17;
            // 
            // emp_passp_serTB
            // 
            this.emp_passp_serTB.Location = new System.Drawing.Point(118, 184);
            this.emp_passp_serTB.Name = "emp_passp_serTB";
            this.emp_passp_serTB.Size = new System.Drawing.Size(179, 22);
            this.emp_passp_serTB.TabIndex = 18;
            // 
            // emp_birthTB
            // 
            this.emp_birthTB.Location = new System.Drawing.Point(81, 209);
            this.emp_birthTB.Name = "emp_birthTB";
            this.emp_birthTB.Size = new System.Drawing.Size(216, 22);
            this.emp_birthTB.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 576);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.scalar_sqlTB);
            this.Controls.Add(this.sql_scalar);
            this.Controls.Add(this.sql_select);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ScalTB);
            this.Controls.Add(this.odbc_select_scalar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.select_odbc);
            this.Controls.Add(this.param_grid);
            this.Name = "Form2";
            this.Text = "Параметризированные запросы";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.param_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView param_grid;
        private System.Windows.Forms.Button select_odbc;
        private System.Windows.Forms.TextBox paramming;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox table_comb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox field_comb;
        private System.Windows.Forms.Button odbc_select_scalar;
        private System.Windows.Forms.TextBox ScalTB;
        private System.Windows.Forms.Button odbc_insert_Pos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ActivityTB;
        private System.Windows.Forms.TextBox Depart_codeTB;
        private System.Windows.Forms.TextBox Pos_nameTB;
        private System.Windows.Forms.TextBox Pos_codeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sql_select;
        private System.Windows.Forms.TextBox scalar_sqlTB;
        private System.Windows.Forms.Button sql_scalar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox emp_birthTB;
        private System.Windows.Forms.TextBox emp_passp_serTB;
        private System.Windows.Forms.TextBox emp_passp_numbTB;
        private System.Windows.Forms.TextBox emp_pos_codeTB;
        private System.Windows.Forms.TextBox emp_adrTB;
        private System.Windows.Forms.TextBox emp_phoneTB;
        private System.Windows.Forms.TextBox emp_nameTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sql_insert;
        private System.Windows.Forms.TextBox emp_numTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}