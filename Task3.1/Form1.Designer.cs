
namespace Task3._1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.cbFirtsName = new System.Windows.Forms.CheckBox();
            this.cbLastName = new System.Windows.Forms.CheckBox();
            this.cbAge = new System.Windows.Forms.CheckBox();
            this.cbFaculty = new System.Windows.Forms.CheckBox();
            this.cbCourse = new System.Windows.Forms.CheckBox();
            this.cbAverageG = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lvStudentTable = new System.Windows.Forms.ListView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblSuggest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(549, 22);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 45);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate new";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(558, 69);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(107, 34);
            this.lblTitle1.TabIndex = 3;
            this.lblTitle1.Text = "\r\nSorting options:";
            // 
            // cbFirtsName
            // 
            this.cbFirtsName.AutoSize = true;
            this.cbFirtsName.Location = new System.Drawing.Point(580, 106);
            this.cbFirtsName.Name = "cbFirtsName";
            this.cbFirtsName.Size = new System.Drawing.Size(96, 21);
            this.cbFirtsName.TabIndex = 4;
            this.cbFirtsName.Text = "Firts name";
            this.cbFirtsName.UseVisualStyleBackColor = true;
            this.cbFirtsName.CheckedChanged += new System.EventHandler(this.cbFirtsName_CheckedChanged);
            // 
            // cbLastName
            // 
            this.cbLastName.AutoSize = true;
            this.cbLastName.Location = new System.Drawing.Point(580, 133);
            this.cbLastName.Name = "cbLastName";
            this.cbLastName.Size = new System.Drawing.Size(96, 21);
            this.cbLastName.TabIndex = 5;
            this.cbLastName.Text = "Last name";
            this.cbLastName.UseVisualStyleBackColor = true;
            this.cbLastName.CheckedChanged += new System.EventHandler(this.cbLastName_CheckedChanged);
            // 
            // cbAge
            // 
            this.cbAge.AutoSize = true;
            this.cbAge.Location = new System.Drawing.Point(580, 160);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(55, 21);
            this.cbAge.TabIndex = 6;
            this.cbAge.Text = "Age";
            this.cbAge.UseVisualStyleBackColor = true;
            this.cbAge.CheckedChanged += new System.EventHandler(this.cbAge_CheckedChanged);
            // 
            // cbFaculty
            // 
            this.cbFaculty.AutoSize = true;
            this.cbFaculty.Location = new System.Drawing.Point(580, 187);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(75, 21);
            this.cbFaculty.TabIndex = 7;
            this.cbFaculty.Text = "Faculty";
            this.cbFaculty.UseVisualStyleBackColor = true;
            this.cbFaculty.CheckedChanged += new System.EventHandler(this.cbFaculty_CheckedChanged);
            // 
            // cbCourse
            // 
            this.cbCourse.AutoSize = true;
            this.cbCourse.Location = new System.Drawing.Point(580, 214);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(75, 21);
            this.cbCourse.TabIndex = 8;
            this.cbCourse.Text = "Course";
            this.cbCourse.UseVisualStyleBackColor = true;
            this.cbCourse.CheckedChanged += new System.EventHandler(this.cbCourse_CheckedChanged);
            // 
            // cbAverageG
            // 
            this.cbAverageG.AutoSize = true;
            this.cbAverageG.Location = new System.Drawing.Point(580, 241);
            this.cbAverageG.Name = "cbAverageG";
            this.cbAverageG.Size = new System.Drawing.Size(124, 21);
            this.cbAverageG.TabIndex = 9;
            this.cbAverageG.Text = "Average grade";
            this.cbAverageG.UseVisualStyleBackColor = true;
            this.cbAverageG.CheckedChanged += new System.EventHandler(this.cbAverageG_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(551, 278);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset option";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lvStudentTable
            // 
            this.lvStudentTable.HideSelection = false;
            this.lvStudentTable.Location = new System.Drawing.Point(12, 21);
            this.lvStudentTable.Name = "lvStudentTable";
            this.lvStudentTable.Size = new System.Drawing.Size(518, 528);
            this.lvStudentTable.TabIndex = 13;
            this.lvStudentTable.UseCompatibleStateImageBehavior = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(552, 107);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(22, 17);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "lbl";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(552, 133);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(22, 17);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "lbl";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(552, 161);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(22, 17);
            this.lbl3.TabIndex = 16;
            this.lbl3.Text = "lbl";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(552, 188);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(22, 17);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "lbl";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(552, 215);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(22, 17);
            this.lbl5.TabIndex = 18;
            this.lbl5.Text = "lbl";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(552, 241);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(22, 17);
            this.lbl6.TabIndex = 19;
            this.lbl6.Text = "lbl";
            // 
            // lblSuggest
            // 
            this.lblSuggest.AutoSize = true;
            this.lblSuggest.Location = new System.Drawing.Point(548, 335);
            this.lblSuggest.Name = "lblSuggest";
            this.lblSuggest.Size = new System.Drawing.Size(337, 17);
            this.lblSuggest.TabIndex = 20;
            this.lblSuggest.Text = "Нажмите на чекбокс для мгновенной сортировки.";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 590);
            this.Controls.Add(this.lblSuggest);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lvStudentTable);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbAverageG);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.cbLastName);
            this.Controls.Add(this.cbFirtsName);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплексная сортировка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.CheckBox cbFirtsName;
        private System.Windows.Forms.CheckBox cbLastName;
        private System.Windows.Forms.CheckBox cbAge;
        private System.Windows.Forms.CheckBox cbFaculty;
        private System.Windows.Forms.CheckBox cbCourse;
        private System.Windows.Forms.CheckBox cbAverageG;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lvStudentTable;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;        
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblSuggest;
    }
}

