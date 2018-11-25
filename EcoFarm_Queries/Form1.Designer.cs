namespace EcoFarm_Queries
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
            this.data1 = new System.Windows.Forms.DataGridView();
            this.Select_odbc = new System.Windows.Forms.Button();
            this.Upd_Odbc = new System.Windows.Forms.Button();
            this.sql_select = new System.Windows.Forms.Button();
            this.upd_sql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(10, 69);
            this.data1.Name = "data1";
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1127, 300);
            this.data1.TabIndex = 0;
            // 
            // Select_odbc
            // 
            this.Select_odbc.Location = new System.Drawing.Point(10, 17);
            this.Select_odbc.Name = "Select_odbc";
            this.Select_odbc.Size = new System.Drawing.Size(221, 36);
            this.Select_odbc.TabIndex = 1;
            this.Select_odbc.Text = "Select ODBC";
            this.Select_odbc.UseVisualStyleBackColor = true;
            this.Select_odbc.Click += new System.EventHandler(this.Select_odbc_Click);
            // 
            // Upd_Odbc
            // 
            this.Upd_Odbc.Location = new System.Drawing.Point(253, 17);
            this.Upd_Odbc.Name = "Upd_Odbc";
            this.Upd_Odbc.Size = new System.Drawing.Size(221, 34);
            this.Upd_Odbc.TabIndex = 2;
            this.Upd_Odbc.Text = "ODBC Update";
            this.Upd_Odbc.UseVisualStyleBackColor = true;
            this.Upd_Odbc.Click += new System.EventHandler(this.Upd_Odbc_Click);
            // 
            // sql_select
            // 
            this.sql_select.Location = new System.Drawing.Point(655, 17);
            this.sql_select.Name = "sql_select";
            this.sql_select.Size = new System.Drawing.Size(221, 36);
            this.sql_select.TabIndex = 3;
            this.sql_select.Text = "SQL Select";
            this.sql_select.UseVisualStyleBackColor = true;
            this.sql_select.Click += new System.EventHandler(this.sql_select_Click);
            // 
            // upd_sql
            // 
            this.upd_sql.Location = new System.Drawing.Point(907, 18);
            this.upd_sql.Name = "upd_sql";
            this.upd_sql.Size = new System.Drawing.Size(221, 34);
            this.upd_sql.TabIndex = 4;
            this.upd_sql.Text = "SQL Update";
            this.upd_sql.UseVisualStyleBackColor = true;
            this.upd_sql.Click += new System.EventHandler(this.upd_sql_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 377);
            this.Controls.Add(this.upd_sql);
            this.Controls.Add(this.sql_select);
            this.Controls.Add(this.Upd_Odbc);
            this.Controls.Add(this.Select_odbc);
            this.Controls.Add(this.data1);
            this.Name = "Form1";
            this.Text = "Непараметризированные запросы";
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button Select_odbc;
        private System.Windows.Forms.Button Upd_Odbc;
        private System.Windows.Forms.Button sql_select;
        private System.Windows.Forms.Button upd_sql;
    }
}

