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
    public partial class FrmAddClient : Form
    {
        string unNoneError = "Неизвестная ошибка. Обратитесь к Алексею!";

        public FrmAddClient()
        {
            InitializeComponent();
        }
 
        private void FrmAddClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.CLIENT". При необходимости она может быть перемещена или удалена.
            this.cLIENTTableAdapter.Fill(this.fFbasEDataSet.CLIENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);
            // ComboBox's not selected
            this.comboBoxStatus.SelectedItem = null;
        }

        private void saveAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;

                if (name == String.Empty)
                {
                    MessageBox.Show("Имя/фамилия не указана!", "Добавление клиента");
                }
                else
                {
                    if (this.comboBoxStatus.SelectedValue == null)
                    {
                        cLIENTTableAdapter.Insert(textBoxName.Text, textBoxEmail.Text, textBoxPhone.Text, textBoxSecPhone.Text, 
                                                  textBoxCompany.Text, textBoxPost.Text, textBoxExperience.Text, textBoxInterests.Text, null);
                    }
                    else
                    {
                        cLIENTTableAdapter.Insert(textBoxName.Text, textBoxEmail.Text, textBoxPhone.Text, textBoxSecPhone.Text, textBoxCompany.Text, 
                                                  textBoxPost.Text, textBoxExperience.Text, textBoxInterests.Text, (int)comboBoxStatus.SelectedValue);
                    }
                   
                    this.textBoxName.Text = String.Empty;
                    this.textBoxEmail.Text = String.Empty;
                    this.textBoxPhone.Text = String.Empty;
                    this.textBoxSecPhone.Text = String.Empty;
                    this.textBoxCompany.Text = String.Empty;
                    this.textBoxPost.Text = String.Empty;
                    this.textBoxExperience.Text = String.Empty;
                    this.textBoxInterests.Text = String.Empty;
                    this.comboBoxStatus.SelectedItem = null;

                    MessageBox.Show("Клиент добавлен!", "Добавление клиента");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление клиента");
            }
        }

        private void clearAddClient_Click(object sender, EventArgs e)
        {
            this.textBoxName.Text = String.Empty;
            this.textBoxEmail.Text = String.Empty;
            this.textBoxPhone.Text = String.Empty;
            this.textBoxSecPhone.Text = String.Empty;
            this.textBoxCompany.Text = String.Empty;
            this.textBoxPost.Text = String.Empty;
            this.textBoxExperience.Text = String.Empty;
            this.textBoxInterests.Text = String.Empty;
            this.comboBoxStatus.SelectedItem = null;
        }
    }
}
