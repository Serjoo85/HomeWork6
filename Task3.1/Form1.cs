using System;
using System.Windows.Forms;

namespace Task3._1
{
    /*3. Переделать программу «Пример использования коллекций» для решения следующих задач:
    а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    в) отсортировать список по возрасту студента;
    г) * отсортировать список по курсу и возрасту студента;
    д) разработать единый метод подсчета количества студентов по различным параметрам
    выбора с помощью делегата и методов предикатов.
    
    Сергей Иванов.     
     */

    public partial class Form1 : Form
    {

        /// <summary>
        /// Массив номеров для Chekboxes.
        /// </summary>
        internal struct lblText
        {
            public static int[] textLbl = new int[6];
            
            /// <summary>
            /// Добавление номера в массив.
            /// </summary>
            /// <param name="cbNumber">
            /// номер Chexbox сверху вниз.
            /// </param>
            /// <param name="index">
            /// индекс в списке делегатов.
            /// </param>
            public static void Add(int cbNumber, int index)
            {
                cbNumber--;
                textLbl[cbNumber] = index;
            }

            /// <summary>
            /// Обновляем нумерацию Checkboxes
            /// </summary>
            /// <param name="index">
            /// номер чекбокса (индекс массива text)
            /// </param>
            public static void Remove(int index)
            {
                index--;
                for(int i = 0; i < textLbl.Length; i++)
                {
                    if(i != index)
                    {
                        if (textLbl[i] > textLbl[index]) textLbl[i]--;
                    }
                }                
                textLbl[index] = 0;                
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

            lblSuggest.Text = "For sorting\nuse checkbox.";

            LblPrint();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Student.GenerateStudentList(1000);
            lvStudentTable.Items.AddRange(BusinessLogic.GetLvi());
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            Student.GenerateStudentList(1000);
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
            CheckboxAction(cbFirtsName.Checked, 1);
            SortStList();
        }

        private void cbLastName_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbLastName.Checked, 2);
            SortStList();
        }

        private void cbAge_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbAge.Checked, 3);
            SortStList();
        }

        private void cbFaculty_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbFaculty.Checked, 4);
            SortStList();
        }

        private void cbCourse_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbCourse.Checked, 5);
            SortStList();
        }

        private void cbAverageG_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxAction(cbAverageG.Checked, 6);
            SortStList();
        }

        private void CheckboxAction(bool cbCheked, int cbNumber)
        {
            if (cbCheked) lblText.Add(cbNumber, Mdlgts.Add(cbNumber));
            else
            {
                Mdlgts.Remove(cbNumber);
                lblText.Remove(cbNumber);                
            }
            LblPrint();
        }

        private void SortStList()
        {
            if (Mdlgts.f != null)
            {
                Student.ComplexSort(Mdlgts.f);
                lvStudentTable.Items.Clear();
                lvStudentTable.Items.AddRange(BusinessLogic.GetLvi());
            }
        }

        private void LblPrint()
        {
            lbl1.Text = (lblText.textLbl[0] != 0) ? lblText.textLbl[0].ToString() : "";
            lbl2.Text = (lblText.textLbl[1] != 0) ? lblText.textLbl[1].ToString() : "";
            lbl3.Text = (lblText.textLbl[2] != 0) ? lblText.textLbl[2].ToString() : "";
            lbl4.Text = (lblText.textLbl[3] != 0) ? lblText.textLbl[3].ToString() : "";
            lbl5.Text = (lblText.textLbl[4] != 0) ? lblText.textLbl[4].ToString() : "";
            lbl6.Text = (lblText.textLbl[5] != 0) ? lblText.textLbl[5].ToString() : "";
        }
    }
}
