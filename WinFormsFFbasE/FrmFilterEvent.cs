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
    public partial class FrmFilterEvent : Form
    {
        FrmFFbasE frm;

        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        public FrmFilterEvent( FrmFFbasE f)
        {
            InitializeComponent();

            frm = f;

            SetParameters();
        }

        private void SetParameters()
        {
            try
            {
                int indexStart;

                if (frm.parametersEvent[0] != String.Empty)
                {
                    indexStart = frm.parametersEvent[0].IndexOf("'") + 1;
                    textBoxName.Text = frm.parametersEvent[0].Substring(indexStart, frm.parametersEvent[0].Length - indexStart - 2);
                }

                if (frm.parametersEvent[1] != String.Empty)
                {
                    indexStart = frm.parametersEvent[1].IndexOf("'") + 1;
                    dateDate.Value = DateTime.Parse(frm.parametersEvent[1].Substring(indexStart, frm.parametersEvent[1].Length - indexStart - 1));
                }

                if (frm.parametersEvent[2] != String.Empty)
                {
                    indexStart = frm.parametersEvent[2].IndexOf("'") + 1;
                    textBoxVenue.Text = frm.parametersEvent[2].Substring(indexStart, frm.parametersEvent[2].Length - indexStart - 2);
                }

                if (frm.parametersEvent[3] != String.Empty)
                {
                    indexStart = frm.parametersEvent[3].IndexOf("'") + 1;
                    textBoxEntrancePrice.Text = frm.parametersEvent[3].Substring(indexStart, frm.parametersEvent[3].Length - indexStart - 2);
                }

                if (frm.parametersEvent[4] != String.Empty)
                {
                    indexStart = frm.parametersEvent[4].IndexOf("'") + 1;
                    textBoxReceipts.Text = frm.parametersEvent[4].Substring(indexStart, frm.parametersEvent[4].Length - indexStart - 2);
                }

                if (frm.parametersEvent[5] != String.Empty)
                {
                    indexStart = frm.parametersEvent[5].IndexOf("%") + 1;
                    comboBoxStatus.SelectedValue = frm.parametersEvent[5].Substring(indexStart, frm.parametersEvent[5].Length - indexStart - 2);
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр ивента");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxName.Text = String.Empty;
                dateDate.CustomFormat = " ";
                textBoxVenue.Text = String.Empty;
                textBoxEntrancePrice.Text = String.Empty;
                textBoxReceipts.Text = String.Empty;
                comboBoxStatus.SelectedItem = null;

                for (int i = 0; i < frm.parametersEvent.Count(); i++)
                {
                    frm.parametersEvent[i] = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр ивента");
            }
        }

        private void dateDate_ValueChanged(object sender, EventArgs e)
        {
            dateDate.CustomFormat = "dd, MMMM, yyyy";
        }

        private void FrmFilterEvent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);

        }
    }
}
