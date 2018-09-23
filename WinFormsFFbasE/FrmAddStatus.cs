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
    public partial class FrmAddStatus : Form
    {
        public FrmAddStatus()
        {
            InitializeComponent();
        }

        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        private void addStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxName.Text != String.Empty)
                {
                    string name = (string)textBoxName.Text;

                    if (queriesTableAdapter1.SQCheckForNotSameStatusName(name) == 0)
                    {
                        sTATUSTableAdapter.Insert(name);
                        MessageBox.Show("Статус успешно добавлен", "Добавление статусов");
                        textBoxName.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Данное имя статуса уже существует !", "Добавление статуса");
                        textBoxName.Text = String.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Введите имя статуса !", "Добавление статуса");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление статуса");
            }
            
        }

        private void FrmAddStatus_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);

        }

        private void saveStatusButton_Click(object sender, EventArgs e)
        {
            sTATUSTableAdapter.Update(fFbasEDataSet.STATUS);
        }

        private void delStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVStatus.CurrentRow.Cells["sGIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> c_count = (int)queriesTableAdapter1.SQCountSG_IDinCLIENT(id);
                global::System.Nullable<int> e_count = (int)queriesTableAdapter1.SQCountSG_IDinEVENT(id);

                if (c_count == 0 && e_count == 0)
                {
                    sTATUSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! К статусу привязан клиент/ивент", "Ошибка удаления статуса");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления статуса");
            }
        }
    }
}
