using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFFbasE
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STUDENT". При необходимости она может быть перемещена или удалена.
            this.sTUDENTTableAdapter.Fill(this.fFbasEDataSet.STUDENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.COURSE_OF_LECTURE". При необходимости она может быть перемещена или удалена.
            this.cOURSE_OF_LECTURETableAdapter.Fill(this.fFbasEDataSet.COURSE_OF_LECTURE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.CLIENT". При необходимости она может быть перемещена или удалена.
            this.cLIENTTableAdapter.Fill(this.fFbasEDataSet.CLIENT);                       
            // ComboBox's not selected
            this.comboBoxClient.SelectedItem = null;
            this.comboBoxCourse.SelectedItem = null;
            this.comboBoxCL.SelectedItem = null;
            this.comboBoxName.SelectedItem = null;
            this.comboBoxEmail.SelectedItem = null;
            this.comboBoxPhone.SelectedItem = null;
            this.comboBoxSecPhone.SelectedItem = null;
            this.comboBoxCompany.SelectedItem = null;
            this.comboBoxPost.SelectedItem = null;
            this.comboBoxExperience.SelectedItem = null;
            this.comboBoxInterests.SelectedItem = null;
        }

        /*
        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c_id;

            if (comboBoxClient.SelectedValue != null)
            {
                c_id = (int)comboBoxClient.SelectedValue;
                
                this.textBoxName.Text = (string)queriesTableAdapter1.SQFindC_NAMEbyC_ID(c_id);
                this.textBoxEmail.Text = (string)queriesTableAdapter1.SQFindC_EMAILbyC_ID(c_id);
                this.textBoxPhone.Text = (string)queriesTableAdapter1.SQFindC_PHONEbyC_ID(c_id);
                this.textBoxSecPhone.Text = (string)queriesTableAdapter1.SQFindC_SEC_PHONEbyC_ID(c_id);
                this.textBoxCompany.Text = (string)queriesTableAdapter1.SQFindC_COMPANYbyC_ID(c_id);
                this.textBoxPost.Text = (string)queriesTableAdapter1.SQFindC_POSTbyC_ID(c_id);
                this.textBoxExperience.Text = (string)queriesTableAdapter1.SQFindC_EXPERIENCEbyC_ID(c_id);
                this.textBoxInterests.Text = (string)queriesTableAdapter1.SQFindC_INTERESTSbyC_ID(c_id);
                
                if (queriesTableAdapter1.SQFindS_IDbyC_ID(c_id) == null)
                {
                    this.comboBoxStatus.SelectedItem = null;
                }
                else
                {
                    this.comboBoxStatus.SelectedValue = queriesTableAdapter1.SQFindS_IDbyC_ID(c_id);
                }              
            }
        }
        */

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxCourse.SelectedItem != null)
            {
                sTUDENTTableAdapter.Insert((int)comboBoxClient.SelectedValue, (int)comboBoxCourse.SelectedValue);
                MessageBox.Show("Студент успешно добавлен", "Добавление студента");

                this.comboBoxClient.SelectedItem = null;
                this.comboBoxCourse.SelectedItem = null;
                this.comboBoxCL.SelectedItem = null;
                this.comboBoxName.SelectedItem = null;
                this.comboBoxEmail.SelectedItem = null;
                this.comboBoxPhone.SelectedItem = null;
                this.comboBoxSecPhone.SelectedItem = null;
                this.comboBoxCompany.SelectedItem = null;
                this.comboBoxPost.SelectedItem = null;
                this.comboBoxExperience.SelectedItem = null;
                this.comboBoxInterests.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Выберите клиента и обучающий курс!", "Добавление студента");
            }
        }
    }
}
