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
    public partial class FrmAddCourseOfLecture : Form
    {
        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        FrmFFbasE frm = new FrmFFbasE();

        public FrmAddCourseOfLecture(FrmFFbasE f)
        {
            InitializeComponent();

            frm = f;
        }

        private void clearCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTheme.Text = String.Empty;
                dateTimePickerStart.CustomFormat = " ";
                dateTimePickerEnd.CustomFormat = " ";
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление обучающего курса");
            }
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTheme.Text == String.Empty)
                {
                    MessageBox.Show("Введите название курса", "Добавление обучающего курса");
                }
                else
                {
                    if (dateTimePickerStart.CustomFormat == " " && dateTimePickerEnd.CustomFormat != " ")
                    {
                        cOURSE_OF_LECTURETableAdapter.Insert(textBoxTheme.Text, null, dateTimePickerEnd.Value);
                        MessageBox.Show("Обучающий курс успешно добавлен", "Добавление обучающего курса");
                    }
                    else if (dateTimePickerStart.CustomFormat != " " && dateTimePickerEnd.CustomFormat == " ")
                    {
                        cOURSE_OF_LECTURETableAdapter.Insert(textBoxTheme.Text, dateTimePickerStart.Value, null);
                        MessageBox.Show("Обучающий курс успешно добавлен", "Добавление обучающего курса");
                    }
                    else if (dateTimePickerStart.CustomFormat == " " && dateTimePickerEnd.CustomFormat == " ")
                    {
                        cOURSE_OF_LECTURETableAdapter.Insert(textBoxTheme.Text, null, null);
                        MessageBox.Show("Обучающий курс успешно добавлен", "Добавление обучающего курса");
                    }
                    else
                    {
                        if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
                        {
                            MessageBox.Show("Начало курса не может быть позже конца !", "Добавление обучающего курса");
                        }
                        else
                        {
                            cOURSE_OF_LECTURETableAdapter.Insert(textBoxTheme.Text, dateTimePickerStart.Value, dateTimePickerEnd.Value);
                            MessageBox.Show("Обучающий курс успешно добавлен", "Добавление обучающего курса");
                        }
                    }                    
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление обучающего курса");
            }
        }

        private void FrmAddCourseOfLecture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.COURSE_OF_LECTURE". При необходимости она может быть перемещена или удалена.
            this.cOURSE_OF_LECTURETableAdapter.Fill(this.fFbasEDataSet.COURSE_OF_LECTURE);

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.CustomFormat = "dd, MMMM, yyyy";
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.CustomFormat = "dd, MMMM, yyyy";
        }
    }
}
