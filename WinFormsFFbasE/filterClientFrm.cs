using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using System.Xml.Linq;
using System.Xml;

namespace WinFormsFFbasE
{
    public partial class filterClientFrm : Form
    {
        private FrmFFbasE frm;

        public filterClientFrm(FrmFFbasE f)
        {
            InitializeComponent();

            frm = f;
        }

        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        private void SetParameters()
        {
            try
            {
                int indexStart;

                comboBoxStatus.SelectedItem = null;

                if (frm.parametersClient[0] != String.Empty)
                {
                    indexStart = frm.parametersClient[0].IndexOf("'") + 1;
                    textBoxName.Text = frm.parametersClient[0].Substring(indexStart, frm.parametersClient[0].Length - indexStart - 2);
                }

                if (frm.parametersClient[1] != String.Empty)
                {
                    indexStart = frm.parametersClient[1].IndexOf("'") + 1;
                    textBoxEmail.Text = frm.parametersClient[1].Substring(indexStart, frm.parametersClient[1].Length - indexStart - 2);
                }

                if (frm.parametersClient[2] != String.Empty)
                {
                    indexStart = frm.parametersClient[2].IndexOf("'") + 1;
                    textBoxPhone.Text = frm.parametersClient[2].Substring(indexStart, frm.parametersClient[2].Length - indexStart - 2);
                }

                if (frm.parametersClient[3] != String.Empty)
                {
                    indexStart = frm.parametersClient[3].IndexOf("'") + 1;
                    textBoxSecPhone.Text = frm.parametersClient[3].Substring(indexStart, frm.parametersClient[3].Length - indexStart - 2);
                }

                if (frm.parametersClient[4] != String.Empty)
                {
                    indexStart = frm.parametersClient[4].IndexOf("'") + 1;
                    textBoxCompany.Text = frm.parametersClient[4].Substring(indexStart, frm.parametersClient[4].Length - indexStart - 2);
                }

                if (frm.parametersClient[5] != String.Empty)
                {
                    indexStart = frm.parametersClient[5].IndexOf("'") + 1;
                    textBoxPost.Text = frm.parametersClient[5].Substring(indexStart, frm.parametersClient[5].Length - indexStart - 2);
                }

                if (frm.parametersClient[6] != String.Empty)
                {
                    indexStart = frm.parametersClient[6].IndexOf("'") + 1;
                    textBoxExperience.Text = frm.parametersClient[6].Substring(indexStart, frm.parametersClient[6].Length - indexStart - 2);
                }

                if (frm.parametersClient[7] != String.Empty)
                {
                    indexStart = frm.parametersClient[7].IndexOf("'") + 1;
                    textBoxInterests.Text = frm.parametersClient[7].Substring(indexStart, frm.parametersClient[7].Length - indexStart - 2);
                }

                if (frm.parametersClient[8] != String.Empty)
                {
                    indexStart = frm.parametersClient[8].IndexOf("%") + 1;
                    comboBoxStatus.SelectedValue = frm.parametersClient[8].Substring(indexStart, frm.parametersClient[8].Length - indexStart - 2);
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр ивента");
            }
        }

        private void SetAutoCompleteCollection()
        {
            for (int i = 0; i < fFbasEDataSet.CLIENT.Rows.Count; i++)
            {
                textBoxName.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][1].ToString());
                textBoxEmail.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][2].ToString());
                textBoxPhone.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][3].ToString());
                textBoxSecPhone.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][4].ToString());
                textBoxCompany.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][5].ToString());
                textBoxPost.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][6].ToString());
                textBoxExperience.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][7].ToString());
                textBoxInterests.AutoCompleteCustomSource.Add(fFbasEDataSet.Tables["CLIENT"].Rows[i][8].ToString());
            }
        }

        private void filterClientFrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.infoCLIENT". При необходимости она может быть перемещена или удалена.
            this.infoCLIENTTableAdapter.Fill(this.fFbasEDataSet.infoCLIENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.CLIENT". При необходимости она может быть перемещена или удалена.
            this.cLIENTTableAdapter.Fill(this.fFbasEDataSet.CLIENT);

            SetParameters();
            SetAutoCompleteCollection();
        }

        private void resetButton_Click(object sender, EventArgs e)
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

            for (int i = 0; i < frm.parametersClient.Count(); i++)
            {
                frm.parametersClient[i] = String.Empty;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != String.Empty) { frm.parametersClient[0] = "C_NAME LIKE'" + textBoxName.Text + "%'"; }

                if (textBoxEmail.Text != String.Empty) { frm.parametersClient[1] = "C_EMAIL LIKE'" + textBoxEmail.Text + "%'"; }

                if (textBoxPhone.Text != String.Empty) { frm.parametersClient[2] = "C_PHONE LIKE'" + textBoxPhone.Text + "%'"; }

                if (textBoxSecPhone.Text != String.Empty) { frm.parametersClient[3] = "C_SEC_PHONE LIKE'" + textBoxSecPhone.Text + "%'"; }

                if (textBoxCompany.Text != String.Empty) { frm.parametersClient[4] = "C_COMPANY LIKE'" + textBoxCompany.Text + "%'"; }

                if (textBoxPost.Text != String.Empty) { frm.parametersClient[5] = "C_POST LIKE'" + textBoxPost.Text + "%'"; }

                if (textBoxExperience.Text != String.Empty) { frm.parametersClient[6] = "C_EXPERIENCE LIKE'" + textBoxExperience.Text + "%'"; }

                if (textBoxInterests.Text != String.Empty) { frm.parametersClient[7] = "C_INTERESTS LIKE'" + textBoxInterests.Text + "%'"; }

                if (comboBoxStatus.SelectedItem != null)
                {
                    frm.parametersClient[8] = "convert(C_SG, 'System.String') LIKE '%"
                   + comboBoxStatus.SelectedValue + "%'";
                }

                this.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр клиента");
            }
        }
    }
}
