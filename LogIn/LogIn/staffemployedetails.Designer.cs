namespace LogIn
{
    partial class staffemployedetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffemployedetails));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet8 = new LogIn.DatabaseteacherDataSet8();
            this.staffemployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet3 = new LogIn.DatabaseteacherDataSet3();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffname = new System.Windows.Forms.TextBox();
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
            this.backbtn = new System.Windows.Forms.Button();
            this.staffemployeTableAdapter = new LogIn.DatabaseteacherDataSet3TableAdapters.staffemployeTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.staffdetailsTableAdapter = new LogIn.DatabaseteacherDataSet8TableAdapters.staffdetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffemployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.staffidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffdetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-49, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1760, 580);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staffid";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.Width = 275;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 400;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 250;
            // 
            // staffdetailsBindingSource
            // 
            this.staffdetailsBindingSource.DataMember = "staffdetails";
            this.staffdetailsBindingSource.DataSource = this.databaseteacherDataSet8;
            // 
            // databaseteacherDataSet8
            // 
            this.databaseteacherDataSet8.DataSetName = "DatabaseteacherDataSet8";
            this.databaseteacherDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffemployeBindingSource
            // 
            this.staffemployeBindingSource.DataMember = "staffemploye";
            this.staffemployeBindingSource.DataSource = this.databaseteacherDataSet3;
            // 
            // databaseteacherDataSet3
            // 
            this.databaseteacherDataSet3.DataSetName = "DatabaseteacherDataSet3";
            this.databaseteacherDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.staffdetailsBindingSource, "age", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1517, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 44);
            this.textBox2.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.staffdetailsBindingSource, "position", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1125, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 44);
            this.textBox1.TabIndex = 72;
            // 
            // staffname
            // 
            this.staffname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.staffname.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.staffdetailsBindingSource, "name", true));
            this.staffname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffname.Location = new System.Drawing.Point(667, 188);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(274, 44);
            this.staffname.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1424, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 37);
            this.label5.TabIndex = 70;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 37);
            this.label4.TabIndex = 69;
            this.label4.Text = "Staff Id:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(970, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 37);
            this.label3.TabIndex = 68;
            this.label3.Text = "Position:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 67;
            this.label2.Text = "Name:";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(881, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 53);
            this.button4.TabIndex = 66;
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
            this.button5.Location = new System.Drawing.Point(224, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 53);
            this.button5.TabIndex = 63;
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
            this.label1.Location = new System.Drawing.Point(784, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 61);
            this.label1.TabIndex = 62;
            this.label1.Text = "Staff Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1055);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 25);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 60;
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
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(1560, 322);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(174, 53);
            this.backbtn.TabIndex = 76;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // staffemployeTableAdapter
            // 
            this.staffemployeTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.staffdetailsBindingSource, "staffid", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(264, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 44);
            this.textBox3.TabIndex = 77;
            this.textBox3.Text = "as";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // staffdetailsTableAdapter
            // 
            this.staffdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffemployedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffname);
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
            this.Name = "staffemployedetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffemployedetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.staffemployedetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffemployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox staffname;
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
        private System.Windows.Forms.Button backbtn;
        private DatabaseteacherDataSet3 databaseteacherDataSet3;
        private System.Windows.Forms.BindingSource staffemployeBindingSource;
        private DatabaseteacherDataSet3TableAdapters.staffemployeTableAdapter staffemployeTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private DatabaseteacherDataSet8 databaseteacherDataSet8;
        private System.Windows.Forms.BindingSource staffdetailsBindingSource;
        private DatabaseteacherDataSet8TableAdapters.staffdetailsTableAdapter staffdetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}