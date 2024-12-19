namespace LogIn
{
    partial class librarylogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librarylogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.databaseteacherDataSet1 = new LogIn.DatabaseteacherDataSet();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wrongstudent = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet1)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.panel2.TabIndex = 2;
            // 
            // databaseteacherDataSet1
            // 
            this.databaseteacherDataSet1.DataSetName = "DatabaseteacherDataSet";
            this.databaseteacherDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.pass);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.wrongstudent);
            this.panel5.Controls.Add(this.login);
            this.panel5.Controls.Add(this.user);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(616, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(689, 582);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Location = new System.Drawing.Point(27, 294);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(633, 49);
            this.pass.TabIndex = 10;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LimeGreen;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(86, 432);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(223, 69);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(27, 152);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(633, 49);
            this.user.TabIndex = 4;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.TextChanged += new System.EventHandler(this.usernamestudent_TextChanged);
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
            this.label10.Location = new System.Drawing.Point(230, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "Library Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(371, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // librarylogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "librarylogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "librarylogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.librarylogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseteacherDataSet1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private DatabaseteacherDataSet databaseteacherDataSet1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wrongstudent;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}