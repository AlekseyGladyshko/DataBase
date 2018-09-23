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
    public partial class FrmFilterCourse : Form
    {
        FrmFFbasE frm;

        public FrmFilterCourse(FrmFFbasE f)
        {
            InitializeComponent();

            frm = f;

            SetParameters();
        }

        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        private void SetParameters()
        {
            try
            {
                int indexStart;

                if (frm.parametersCourse[0] != String.Empty)
                {
                    indexStart = frm.parametersCourse[0].IndexOf("'") + 1;
                    textBoxTheme.Text = frm.parametersCourse[0].Substring(indexStart, frm.parametersCourse[0].Length - indexStart - 2);
                }

                if (frm.parametersCourse[1] != String.Empty)
                {
                    indexStart = frm.parametersCourse[1].IndexOf("'") + 1;
                    //dateStart.CustomFormat = frm.parametersCourse[1].Substring(indexStart, frm.parametersCourse[1].Length - indexStart - 1);
                    dateStart.Value = DateTime.Parse(frm.parametersCourse[1].Substring(indexStart, frm.parametersCourse[1].Length - indexStart - 1));
                }

                if (frm.parametersCourse[2] != String.Empty)
                {
                    indexStart = frm.parametersCourse[2].IndexOf("'") + 1;
                    dateEnd.Value = DateTime.Parse(frm.parametersCourse[2].Substring(indexStart, frm.parametersCourse[2].Length - indexStart - 1));
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр курса");
            }
        }
  
        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTheme.Text = String.Empty;
                dateStart.CustomFormat = " ";
                dateEnd.CustomFormat = " ";

                for (int i = 0; i < frm.parametersCourse.Count(); i++)
                {
                    frm.parametersCourse[i] = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр обучающего курса");
            }
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            //dateEnd.Value = dateEnd.
            dateEnd.CustomFormat = "dd, MMMM, yyyy";
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            dateStart.CustomFormat = "dd, MMMM, yyyy";
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Добавить CheckBox если например фильтровать курсы до указаной даты начала, или после указаной даты конца !!!

            if (textBoxTheme.Text != String.Empty) { frm.parametersCourse[0] = "CL_THEME LIKE'" + textBoxTheme.Text + "%'"; }

            if (dateStart.CustomFormat != " ") { frm.parametersCourse[1] = "CL_START >= '" + dateStart.Value + "'"; }

            if (dateEnd.CustomFormat != " ") { frm.parametersCourse[2] = "CL_END <= '" + dateEnd.Value + "'"; }
            
            this.Dispose();
        }
    }
}
