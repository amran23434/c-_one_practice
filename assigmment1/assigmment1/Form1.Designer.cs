namespace assigmment1
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
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(439, 124);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(265, 26);
            this.txtstudentid.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(439, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(265, 26);
            this.txtname.TabIndex = 1;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(439, 177);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(265, 26);
            this.txtdepartment.TabIndex = 2;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(439, 227);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(265, 26);
            this.txtsemester.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the student name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter the semester";
            // 
            // lbloutput
            // 
            this.lbloutput.Location = new System.Drawing.Point(95, 358);
            this.lbloutput.Multiline = true;
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(653, 74);
            this.lbloutput.TabIndex = 8;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(112, 450);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(133, 62);
            this.btnshowinfo.TabIndex = 9;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(326, 450);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(133, 62);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(537, 450);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(133, 62);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 536);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstudentid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

