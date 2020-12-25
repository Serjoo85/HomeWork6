using System;
using System.Windows.Forms;

namespace Task3._1
{
    public partial class Form1 : Form
    {
        internal struct lblText
        {
            public static int[] text = new int[6];
            public static void Add(int index, int value)
            {
                index--;
                text[index] = value;
            }
            public static void Remove(int index)
            {
                index--;
                for(int i = 0; i < text.Length; i++)
                {
                    if(i != index)
                    {
                        if (text[i] > text[index]) text[i]--;
                    }
                }                
                text[index] = 0;                
            }
        }

        internal Mdlgts Mdlgts = new Mdlgts(BusinessLogic.GetDelList());
        
        public Form1()
        {
            InitializeComponent();            

            lvStudentTable.View = View.Details;
            lvStudentTable.GridLines = true;
            lvStudentTable.FullRowSelect = true;
            lvStudentTable.Columns.Add("First name", 70, HorizontalAlignment.Center);
            lvStudentTable.Columns.Add("Last name", 70, HorizontalAlignment.Center);
            lvStudentTable.Columns.Add("Age", 40, HorizontalAlignment.Center);
            lvStudentTable.Columns.Add("Faculty", 50, HorizontalAlignment.Center);
            lvStudentTable.Columns.Add("Course", 50, HorizontalAlignment.Center);
            lvStudentTable.Columns.Add("Average grade", 90, HorizontalAlignment.Center);

            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Student.CreatStudentList(1000);
            lvStudentTable.Items.AddRange(BusinessLogic.GetLvi());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (Mdlgts.f != null)
            {
                Student.ComplexSort(Mdlgts.f);
                lvStudentTable.Items.Clear();
                lvStudentTable.Items.AddRange(BusinessLogic.GetLvi());
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            Student.CreatStudentList(1000);
            lvStudentTable.Items.Clear();
            lvStudentTable.Items.AddRange(BusinessLogic.GetLvi());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Mdlgts.f = null;
            cbFirtsName.Checked = false;
            cbLastName.Checked = false;
            cbAge.Checked = false;
            cbFaculty.Checked = false;
            cbCourse.Checked = false;
            cbAverageG.Checked = false;
        }

        private void cbFirtsName_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbFirtsName, 1);
        }

        private void cbLastName_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbLastName, 2);
        }

        private void cbAge_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbAge, 3);
        }

        private void cbFaculty_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbFaculty, 4);
        }

        private void cbCourse_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbCourse, 5);
        }

        private void cbAverageG_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbAverageG, 6);
        }

        private void CheckboxAction(CheckBox cb, int value)
        {
            if (cb.Checked) lblText.Add(value, Mdlgts.Add(value));
            else
            {
                Mdlgts.Remove(value);
                lblText.Remove(value);                
            }
            LblPrint();
        }

        private void LblPrint()
        {
            lbl1.Text = (lblText.text[0] != 0) ? lblText.text[0].ToString() : "";
            lbl2.Text = (lblText.text[1] != 0) ? lblText.text[1].ToString() : "";
            lbl3.Text = (lblText.text[2] != 0) ? lblText.text[2].ToString() : "";
            lbl4.Text = (lblText.text[3] != 0) ? lblText.text[3].ToString() : "";
            lbl5.Text = (lblText.text[4] != 0) ? lblText.text[4].ToString() : "";
            lbl6.Text = (lblText.text[5] != 0) ? lblText.text[5].ToString() : "";
        }
    }
}
