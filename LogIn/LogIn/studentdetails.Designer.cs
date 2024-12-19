namespace LogIn
{
    partial class studentdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentdetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet8 = new LogIn.DatabaseteacherDataSet8();
            this.studentdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet3 = new LogIn.DatabaseteacherDataSet3();
            this.grade = new System.Windows.Forms.TextBox();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentid = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.studentdetailTableAdapter = new LogIn.DatabaseteacherDataSet3TableAdapters.studentdetailTableAdapter();
            this.gender = new System.Windows.Forms.ComboBox();
            this.studentsTableAdapter = new LogIn.DatabaseteacherDataSet8TableAdapters.studentsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1858, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1055);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 25);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1760, 580);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "studentid";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 300;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 350;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 350;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 350;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.databaseteacherDataSet8;
            // 
            // databaseteacherDataSet8
            // 
            this.databaseteacherDataSet8.DataSetName = "DatabaseteacherDataSet8";
            this.databaseteacherDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentdetailBindingSource
            // 
            this.studentdetailBindingSource.DataMember = "studentdetail";
            this.studentdetailBindingSource.DataSource = this.databaseteacherDataSet3;
            // 
            // databaseteacherDataSet3
            // 
            this.databaseteacherDataSet3.DataSetName = "DatabaseteacherDataSet3";
            this.databaseteacherDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grade
            // 
            this.grade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grade.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentsBindingSource1, "grade", true));
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(1077, 196);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(274, 44);
            this.grade.TabIndex = 41;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "students";
            this.studentsBindingSource1.DataSource = this.databaseteacherDataSet8;
            // 
            // studentid
            // 
            this.studentid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studentid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentsBindingSource1, "studentid", true));
            this.studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid.Location = new System.Drawing.Point(263, 196);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(274, 44);
            this.studentid.TabIndex = 40;
            this.studentid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentsBindingSource1, "name", true));
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(658, 196);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(274, 44);
            this.name.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(938, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 37);
            this.label5.TabIndex = 38;
            this.label5.Text = "Grade:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1382, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 37);
            this.label4.TabIndex = 37;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 37);
            this.label3.TabIndex = 36;
            this.label3.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(543, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(876, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 53);
            this.button4.TabIndex = 34;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(184, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 53);
            this.button5.TabIndex = 31;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(749, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 61);
            this.label1.TabIndex = 30;
            this.label1.Text = "Student Details";
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(1567, 322);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(174, 53);
            this.backbtn.TabIndex = 77;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // studentdetailTableAdapter
            // 
            this.studentdetailTableAdapter.ClearBeforeFill = true;
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource1, "gender", true));
            this.gender.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentsBindingSource1, "gender", true));
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(1527, 196);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(274, 45);
            this.gender.TabIndex = 78;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentdetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.studentdetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox studentid;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
        private DatabaseteacherDataSet3 databaseteacherDataSet3;
        private System.Windows.Forms.BindingSource studentdetailBindingSource;
        private DatabaseteacherDataSet3TableAdapters.studentdetailTableAdapter studentdetailTableAdapter;
        private System.Windows.Forms.ComboBox gender;
        private DatabaseteacherDataSet8 databaseteacherDataSet8;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DatabaseteacherDataSet8TableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}