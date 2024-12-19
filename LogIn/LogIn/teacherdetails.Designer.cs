namespace LogIn
{
    partial class teacherdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherdetails));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teacherdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet8 = new LogIn.DatabaseteacherDataSet8();
            this.teacherdetailBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet7 = new LogIn.DatabaseteacherDataSet7();
            this.teacherdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet3 = new LogIn.DatabaseteacherDataSet3();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.teacherdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teacherdetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet6 = new LogIn.DatabaseteacherDataSet6();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teacherdetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.teacherdetailTableAdapter = new LogIn.DatabaseteacherDataSet3TableAdapters.teacherdetailTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherdetailTableAdapter1 = new LogIn.DatabaseteacherDataSet6TableAdapters.teacherdetailTableAdapter();
            this.teacherdetailTableAdapter2 = new LogIn.DatabaseteacherDataSet7TableAdapters.teacherdetailTableAdapter();
            this.teacherdetailsTableAdapter = new LogIn.DatabaseteacherDataSet8TableAdapters.TeacherdetailsTableAdapter();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacheridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherdetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1760, 580);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // teacherdetailsBindingSource
            // 
            this.teacherdetailsBindingSource.DataMember = "Teacherdetails";
            this.teacherdetailsBindingSource.DataSource = this.databaseteacherDataSet8;
            // 
            // databaseteacherDataSet8
            // 
            this.databaseteacherDataSet8.DataSetName = "DatabaseteacherDataSet8";
            this.databaseteacherDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherdetailBindingSource3
            // 
            this.teacherdetailBindingSource3.DataMember = "teacherdetail";
            this.teacherdetailBindingSource3.DataSource = this.databaseteacherDataSet7;
            // 
            // databaseteacherDataSet7
            // 
            this.databaseteacherDataSet7.DataSetName = "DatabaseteacherDataSet7";
            this.databaseteacherDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherdetailBindingSource
            // 
            this.teacherdetailBindingSource.DataMember = "teacherdetail";
            this.teacherdetailBindingSource.DataSource = this.databaseteacherDataSet3;
            // 
            // databaseteacherDataSet3
            // 
            this.databaseteacherDataSet3.DataSetName = "DatabaseteacherDataSet3";
            this.databaseteacherDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teacherdetailsBindingSource1, "subject", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(876, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 44);
            this.textBox2.TabIndex = 57;
            // 
            // teacherdetailsBindingSource1
            // 
            this.teacherdetailsBindingSource1.DataMember = "Teacherdetails";
            this.teacherdetailsBindingSource1.DataSource = this.databaseteacherDataSet8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teacherdetailsBindingSource1, "name", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(460, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 44);
            this.textBox1.TabIndex = 56;
            // 
            // teacherdetailBindingSource1
            // 
            this.teacherdetailBindingSource1.DataMember = "teacherdetail";
            this.teacherdetailBindingSource1.DataSource = this.databaseteacherDataSet6;
            // 
            // databaseteacherDataSet6
            // 
            this.databaseteacherDataSet6.DataSetName = "DatabaseteacherDataSet6";
            this.databaseteacherDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1150, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 37);
            this.label5.TabIndex = 54;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1512, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 37);
            this.label4.TabIndex = 53;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(731, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 37);
            this.label3.TabIndex = 52;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(348, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 51;
            this.label2.Text = "Name:";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(878, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 53);
            this.button4.TabIndex = 50;
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
            this.button5.Location = new System.Drawing.Point(189, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 53);
            this.button5.TabIndex = 47;
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
            this.label1.Location = new System.Drawing.Point(741, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 61);
            this.label1.TabIndex = 46;
            this.label1.Text = "Teacher Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1055);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 25);
            this.panel2.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 44;
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
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1544, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 53);
            this.button3.TabIndex = 60;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teacherdetailsBindingSource1, "gender", true));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(1646, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 45);
            this.comboBox1.TabIndex = 61;
            // 
            // teacherdetailBindingSource2
            // 
            this.teacherdetailBindingSource2.DataMember = "teacherdetail";
            this.teacherdetailBindingSource2.DataSource = this.databaseteacherDataSet6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teacherdetailsBindingSource1, "age", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1232, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 44);
            this.textBox3.TabIndex = 62;
            // 
            // teacherdetailTableAdapter
            // 
            this.teacherdetailTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teacherdetailsBindingSource1, "teacherid", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(75, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 44);
            this.textBox4.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 37);
            this.label6.TabIndex = 63;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // teacherdetailTableAdapter1
            // 
            this.teacherdetailTableAdapter1.ClearBeforeFill = true;
            // 
            // teacherdetailTableAdapter2
            // 
            this.teacherdetailTableAdapter2.ClearBeforeFill = true;
            // 
            // teacherdetailsTableAdapter
            // 
            this.teacherdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacherid";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "Teacher ID";
            this.teacheridDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            this.teacheridDataGridViewTextBoxColumn.Width = 225;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 300;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 250;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 300;
            // 
            // teacherdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.Name = "teacherdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherdetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.teacherdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherdetailBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private DatabaseteacherDataSet3 databaseteacherDataSet3;
        private System.Windows.Forms.BindingSource teacherdetailBindingSource;
        private DatabaseteacherDataSet3TableAdapters.teacherdetailTableAdapter teacherdetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private DatabaseteacherDataSet6 databaseteacherDataSet6;
        private System.Windows.Forms.BindingSource teacherdetailBindingSource1;
        private DatabaseteacherDataSet6TableAdapters.teacherdetailTableAdapter teacherdetailTableAdapter1;
        private System.Windows.Forms.BindingSource teacherdetailBindingSource2;
        private DatabaseteacherDataSet7 databaseteacherDataSet7;
        private System.Windows.Forms.BindingSource teacherdetailBindingSource3;
        private DatabaseteacherDataSet7TableAdapters.teacherdetailTableAdapter teacherdetailTableAdapter2;
        private DatabaseteacherDataSet8 databaseteacherDataSet8;
        private System.Windows.Forms.BindingSource teacherdetailsBindingSource;
        private DatabaseteacherDataSet8TableAdapters.TeacherdetailsTableAdapter teacherdetailsTableAdapter;
        private System.Windows.Forms.BindingSource teacherdetailsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}