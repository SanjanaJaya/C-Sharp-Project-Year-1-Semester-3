namespace LogIn
{
    partial class examlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.studentloginpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wrongstudent = new System.Windows.Forms.Label();
            this.studentlogin = new System.Windows.Forms.Button();
            this.studentusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.teacherloginpass = new System.Windows.Forms.TextBox();
            this.usernameteacher = new System.Windows.Forms.TextBox();
            this.wronglabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseteacherDataSet = new LogIn.DatabaseteacherDataSet();
            this.tblteacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblteacherTableAdapter = new LogIn.DatabaseteacherDataSetTableAdapters.tblteacherTableAdapter();
            this.tblteacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblteacherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.student.SuspendLayout();
            this.teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblteacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblteacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblteacherBindingSource2)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.student);
            this.panel3.Controls.Add(this.teacher);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 955);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // student
            // 
            this.student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.student.Controls.Add(this.button2);
            this.student.Controls.Add(this.checkBox2);
            this.student.Controls.Add(this.studentloginpass);
            this.student.Controls.Add(this.label6);
            this.student.Controls.Add(this.wrongstudent);
            this.student.Controls.Add(this.studentlogin);
            this.student.Controls.Add(this.studentusername);
            this.student.Controls.Add(this.label9);
            this.student.Controls.Add(this.label10);
            this.student.Location = new System.Drawing.Point(641, 252);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(689, 582);
            this.student.TabIndex = 4;
            this.student.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(360, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 69);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(237, 362);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(197, 29);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Show Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // studentloginpass
            // 
            this.studentloginpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentloginpass.ForeColor = System.Drawing.Color.Black;
            this.studentloginpass.Location = new System.Drawing.Point(27, 294);
            this.studentloginpass.Name = "studentloginpass";
            this.studentloginpass.Size = new System.Drawing.Size(633, 49);
            this.studentloginpass.TabIndex = 10;
            this.studentloginpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(241, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 42);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // wrongstudent
            // 
            this.wrongstudent.AutoSize = true;
            this.wrongstudent.BackColor = System.Drawing.Color.Transparent;
            this.wrongstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongstudent.ForeColor = System.Drawing.Color.Red;
            this.wrongstudent.Location = new System.Drawing.Point(138, 519);
            this.wrongstudent.Name = "wrongstudent";
            this.wrongstudent.Size = new System.Drawing.Size(420, 31);
            this.wrongstudent.TabIndex = 8;
            this.wrongstudent.Text = "Wrong Username \"OR\" Password";
            // 
            // studentlogin
            // 
            this.studentlogin.BackColor = System.Drawing.Color.LimeGreen;
            this.studentlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlogin.ForeColor = System.Drawing.Color.White;
            this.studentlogin.Location = new System.Drawing.Point(104, 427);
            this.studentlogin.Name = "studentlogin";
            this.studentlogin.Size = new System.Drawing.Size(223, 69);
            this.studentlogin.TabIndex = 6;
            this.studentlogin.Text = "Login";
            this.studentlogin.UseVisualStyleBackColor = false;
            this.studentlogin.Click += new System.EventHandler(this.studentlogin_Click);
            // 
            // studentusername
            // 
            this.studentusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentusername.ForeColor = System.Drawing.Color.Black;
            this.studentusername.Location = new System.Drawing.Point(27, 152);
            this.studentusername.Name = "studentusername";
            this.studentusername.Size = new System.Drawing.Size(633, 49);
            this.studentusername.TabIndex = 4;
            this.studentusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(241, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 42);
            this.label9.TabIndex = 1;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(208, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "Student\'s Login";
            // 
            // teacher
            // 
            this.teacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teacher.BackColor = System.Drawing.Color.Transparent;
            this.teacher.Controls.Add(this.button3);
            this.teacher.Controls.Add(this.checkBox1);
            this.teacher.Controls.Add(this.loginbutton);
            this.teacher.Controls.Add(this.teacherloginpass);
            this.teacher.Controls.Add(this.usernameteacher);
            this.teacher.Controls.Add(this.wronglabel);
            this.teacher.Controls.Add(this.label5);
            this.teacher.Controls.Add(this.label4);
            this.teacher.Controls.Add(this.label3);
            this.teacher.Location = new System.Drawing.Point(644, 252);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(689, 582);
            this.teacher.TabIndex = 3;
            this.teacher.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.teacher.Enter += new System.EventHandler(this.panel4_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(360, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 69);
            this.button3.TabIndex = 8;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(244, 362);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 29);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(145, 427);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(186, 69);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherloginpass
            // 
            this.teacherloginpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherloginpass.ForeColor = System.Drawing.Color.Black;
            this.teacherloginpass.Location = new System.Drawing.Point(27, 294);
            this.teacherloginpass.Name = "teacherloginpass";
            this.teacherloginpass.PasswordChar = '*';
            this.teacherloginpass.Size = new System.Drawing.Size(633, 49);
            this.teacherloginpass.TabIndex = 5;
            this.teacherloginpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.teacherloginpass.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // usernameteacher
            // 
            this.usernameteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameteacher.ForeColor = System.Drawing.Color.Black;
            this.usernameteacher.Location = new System.Drawing.Point(27, 152);
            this.usernameteacher.Name = "usernameteacher";
            this.usernameteacher.Size = new System.Drawing.Size(633, 49);
            this.usernameteacher.TabIndex = 4;
            this.usernameteacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wronglabel
            // 
            this.wronglabel.AutoSize = true;
            this.wronglabel.BackColor = System.Drawing.Color.Transparent;
            this.wronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wronglabel.ForeColor = System.Drawing.Color.Red;
            this.wronglabel.Location = new System.Drawing.Point(139, 519);
            this.wronglabel.Name = "wronglabel";
            this.wronglabel.Size = new System.Drawing.Size(420, 31);
            this.wronglabel.TabIndex = 3;
            this.wronglabel.Text = "Wrong Username \"OR\" Password";
            this.wronglabel.Click += new System.EventHandler(this.wronglabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(241, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 42);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher\'s Login";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.comboBox1.Location = new System.Drawing.Point(789, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 59);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Noto Sans Sinhala", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(806, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select User Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Noto Sans Sinhala", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(649, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz/Exam Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databaseteacherDataSet
            // 
            this.databaseteacherDataSet.DataSetName = "DatabaseteacherDataSet";
            this.databaseteacherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblteacherBindingSource
            // 
            this.tblteacherBindingSource.DataMember = "tblteacher";
            this.tblteacherBindingSource.DataSource = this.databaseteacherDataSet;
            // 
            // tblteacherTableAdapter
            // 
            this.tblteacherTableAdapter.ClearBeforeFill = true;
            // 
            // tblteacherBindingSource1
            // 
            this.tblteacherBindingSource1.DataMember = "tblteacher";
            this.tblteacherBindingSource1.DataSource = this.databaseteacherDataSet;
            // 
            // tblteacherBindingSource2
            // 
            this.tblteacherBindingSource2.DataMember = "tblteacher";
            this.tblteacherBindingSource2.DataSource = this.databaseteacherDataSet;
            // 
            // examlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "examlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "examlogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.examlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.student.ResumeLayout(false);
            this.student.PerformLayout();
            this.teacher.ResumeLayout(false);
            this.teacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblteacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblteacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblteacherBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel teacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherloginpass;
        private System.Windows.Forms.TextBox usernameteacher;
        private System.Windows.Forms.Label wronglabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel student;
        private System.Windows.Forms.Button studentlogin;
        private System.Windows.Forms.TextBox studentusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label wrongstudent;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox studentloginpass;
        private System.Windows.Forms.Label label6;
        private DatabaseteacherDataSet databaseteacherDataSet;
        private System.Windows.Forms.BindingSource tblteacherBindingSource;
        private DatabaseteacherDataSetTableAdapters.tblteacherTableAdapter tblteacherTableAdapter;
        private System.Windows.Forms.BindingSource tblteacherBindingSource2;
        private System.Windows.Forms.BindingSource tblteacherBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}