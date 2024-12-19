namespace LogIn
{
    partial class library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(library));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.librarynewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet3 = new LogIn.DatabaseteacherDataSet3();
            this.libraryBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet2 = new LogIn.DatabaseteacherDataSet2();
            this.libraryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseteacherDataSet1 = new LogIn.DatabaseteacherDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.libraryBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter = new LogIn.DatabaseteacherDataSet1TableAdapters.libraryTableAdapter();
            this.backbtn = new System.Windows.Forms.Button();
            this.libraryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter1 = new LogIn.DatabaseteacherDataSet2TableAdapters.libraryTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.librarynewTableAdapter = new LogIn.DatabaseteacherDataSet3TableAdapters.librarynewTableAdapter();
            this.stidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarynewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(1850, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1055);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 25);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(631, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stidDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.bornameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.librarynewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1760, 580);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // librarynewBindingSource
            // 
            this.librarynewBindingSource.DataMember = "librarynew";
            this.librarynewBindingSource.DataSource = this.databaseteacherDataSet3;
            // 
            // databaseteacherDataSet3
            // 
            this.databaseteacherDataSet3.DataSetName = "DatabaseteacherDataSet3";
            this.databaseteacherDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingSource5
            // 
            this.libraryBindingSource5.DataMember = "library";
            this.libraryBindingSource5.DataSource = this.databaseteacherDataSet2;
            // 
            // databaseteacherDataSet2
            // 
            this.databaseteacherDataSet2.DataSetName = "DatabaseteacherDataSet2";
            this.databaseteacherDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingSource3
            // 
            this.libraryBindingSource3.DataMember = "library";
            this.libraryBindingSource3.DataSource = this.databaseteacherDataSet2;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "library";
            this.libraryBindingSource.DataSource = this.databaseteacherDataSet1;
            // 
            // databaseteacherDataSet1
            // 
            this.databaseteacherDataSet1.DataSetName = "DatabaseteacherDataSet1";
            this.databaseteacherDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(853, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 53);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(657, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1138, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Burrower Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(189, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student Id:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // libraryBindingSource4
            // 
            this.libraryBindingSource4.DataMember = "library";
            this.libraryBindingSource4.DataSource = this.databaseteacherDataSet2;
            // 
            // libraryBindingSource1
            // 
            this.libraryBindingSource1.DataMember = "library";
            this.libraryBindingSource1.DataSource = this.databaseteacherDataSet1;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(1526, 329);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(174, 53);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // libraryBindingSource2
            // 
            this.libraryBindingSource2.DataMember = "library";
            this.libraryBindingSource2.DataSource = this.databaseteacherDataSet1;
            // 
            // libraryTableAdapter1
            // 
            this.libraryTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.librarynewBindingSource, "bookname", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(858, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 44);
            this.textBox1.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.librarynewBindingSource, "borname", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1409, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 44);
            this.textBox2.TabIndex = 58;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.librarynewBindingSource, "stid", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(377, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 44);
            this.textBox3.TabIndex = 59;
            // 
            // librarynewTableAdapter
            // 
            this.librarynewTableAdapter.ClearBeforeFill = true;
            // 
            // stidDataGridViewTextBoxColumn
            // 
            this.stidDataGridViewTextBoxColumn.DataPropertyName = "stid";
            this.stidDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.stidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.stidDataGridViewTextBoxColumn.Name = "stidDataGridViewTextBoxColumn";
            this.stidDataGridViewTextBoxColumn.Width = 350;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.booknameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.Width = 500;
            // 
            // bornameDataGridViewTextBoxColumn
            // 
            this.bornameDataGridViewTextBoxColumn.DataPropertyName = "borname";
            this.bornameDataGridViewTextBoxColumn.HeaderText = "Borrower Name";
            this.bornameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bornameDataGridViewTextBoxColumn.Name = "bornameDataGridViewTextBoxColumn";
            this.bornameDataGridViewTextBoxColumn.Width = 500;
            // 
            // library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.library_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarynewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private DatabaseteacherDataSet1 databaseteacherDataSet1;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private DatabaseteacherDataSet1TableAdapters.libraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.BindingSource libraryBindingSource1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.BindingSource libraryBindingSource2;
        private DatabaseteacherDataSet2 databaseteacherDataSet2;
        private System.Windows.Forms.BindingSource libraryBindingSource3;
        private DatabaseteacherDataSet2TableAdapters.libraryTableAdapter libraryTableAdapter1;
        private System.Windows.Forms.BindingSource libraryBindingSource4;
        private System.Windows.Forms.BindingSource libraryBindingSource5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private DatabaseteacherDataSet3 databaseteacherDataSet3;
        private System.Windows.Forms.BindingSource librarynewBindingSource;
        private DatabaseteacherDataSet3TableAdapters.librarynewTableAdapter librarynewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bornameDataGridViewTextBoxColumn;
    }
}