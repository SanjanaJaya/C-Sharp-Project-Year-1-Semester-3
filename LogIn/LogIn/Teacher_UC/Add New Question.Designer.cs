namespace LogIn.Teacher_UC
{
    partial class Add_New_Question
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.openquestion = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Questions";
            // 
            // openquestion
            // 
            this.openquestion.BackColor = System.Drawing.Color.LimeGreen;
            this.openquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openquestion.ForeColor = System.Drawing.Color.White;
            this.openquestion.Location = new System.Drawing.Point(373, 603);
            this.openquestion.Name = "openquestion";
            this.openquestion.Size = new System.Drawing.Size(269, 66);
            this.openquestion.TabIndex = 19;
            this.openquestion.Text = "Browse";
            this.openquestion.UseVisualStyleBackColor = false;
            this.openquestion.Click += new System.EventHandler(this.openquestion_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.LimeGreen;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(774, 603);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(269, 66);
            this.reset.TabIndex = 20;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.LimeGreen;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(574, 757);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(269, 66);
            this.submit.TabIndex = 21;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 465);
            this.dataGridView1.TabIndex = 22;
            // 
            // Add_New_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.openquestion);
            this.Controls.Add(this.label1);
            this.Name = "Add_New_Question";
            this.Size = new System.Drawing.Size(1420, 980);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openquestion;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button submit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
