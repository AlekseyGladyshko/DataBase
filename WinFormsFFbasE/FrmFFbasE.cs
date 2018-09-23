using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WinFormsFFbasE
{
    public partial class FrmFFbasE : Form
    {
        public FrmFFbasE()
        {
            InitializeComponent();
        }

        bool[] changed = new bool[6] { false, false, false, false, false, false };
        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        private bool checkForChanges()
        {
            for (int i = 0; i < changed.Length; i++)
            {
                if (changed[i])
                    return true;
            }
            return false;
        }

        private void FrmFFbasE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet2.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.fFbasEDataSet2.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.CLIENT1". При необходимости она может быть перемещена или удалена.
            this.cLIENT1TableAdapter.Fill(this.fFbasEDataSet1.CLIENT1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.allLECTURER". При необходимости она может быть перемещена или удалена.
            this.allLECTURERTableAdapter.Fill(this.fFbasEDataSet.allLECTURER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.COURSE_OF_LECTURE". При необходимости она может быть перемещена или удалена.
            this.cOURSE_OF_LECTURETableAdapter.Fill(this.fFbasEDataSet.COURSE_OF_LECTURE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.infoSTUDENT". При необходимости она может быть перемещена или удалена.
            this.infoSTUDENTTableAdapter.Fill(this.fFbasEDataSet.infoSTUDENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.CLIENT". При необходимости она может быть перемещена или удалена.
            this.cLIENTTableAdapter.Fill(this.fFbasEDataSet.CLIENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.infoCLIENT". При необходимости она может быть перемещена или удалена.
            this.infoCLIENTTableAdapter.Fill(this.fFbasEDataSet.infoCLIENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet2.infoLECTURER". При необходимости она может быть перемещена или удалена.
            this.infoLECTURERTableAdapter.Fill(this.fFbasEDataSet.infoLECTURER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.infoSTUDENT". При необходимости она может быть перемещена или удалена.
            this.infoSTUDENTTableAdapter.Fill(this.fFbasEDataSet.infoSTUDENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.infoEVENT". При необходимости она может быть перемещена или удалена.
            this.infoEVENTTableAdapter.Fill(this.fFbasEDataSet.infoEVENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.infoEVENT". При необходимости она может быть перемещена или удалена.
            this.infoLECTURETableAdapter.Fill(this.fFbasEDataSet.infoLECTURE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.infoEVENT". При необходимости она может быть перемещена или удалена.
            this.infoEVENTTableAdapter.Fill(this.fFbasEDataSet.infoEVENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet1.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.EVENT". При необходимости она может быть перемещена или удалена.
            this.eVENTTableAdapter.Fill(this.fFbasEDataSet.EVENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.LECTURER". При необходимости она может быть перемещена или удалена.
            this.lECTURERTableAdapter.Fill(this.fFbasEDataSet.LECTURER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.LECTURE". При необходимости она может быть перемещена или удалена.
            this.lECTURETableAdapter.Fill(this.fFbasEDataSet.LECTURE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STUDENT". При необходимости она может быть перемещена или удалена.
            this.sTUDENTTableAdapter.Fill(this.fFbasEDataSet.STUDENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.infoCOURSE_OF_LECTURE". При необходимости она может быть перемещена или удалена.
            this.infoCOURSE_OF_LECTURETableAdapter.Fill(this.fFbasEDataSet.infoCOURSE_OF_LECTURE);

            for (int i = 0; i < changed.Length; i++)
            {
                changed[i] = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cOURSE_OF_LECTURETableAdapter.Update(fFbasEDataSet.COURSE_OF_LECTURE);
            changed[1] = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dGVCourseOfLecture.CurrentRow.Index;
                int id = (int)dGVCourseOfLecture.CurrentRow.Cells["cLIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> s_count = (int)queriesTableAdapter1.SQCountCL_IDinStudent(id);
                global::System.Nullable<int> l_count = (int)queriesTableAdapter1.SQCountCL_IDinLecture(id);

                if (s_count == 0 && l_count == 0)
                {
                    infoCOURSEOFLECTUREBindingSource.RemoveCurrent();
                    cOURSEOFLECTUREBindingSource.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! К курсу привязан студент/лекция!", "Ошибка удаления обучающего курса");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления обучающего курса");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cLIENTTableAdapter.Update(fFbasEDataSet.CLIENT);
            changed[0] = false;
        }


        private void delClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVClient.CurrentRow.Cells["cIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> s_count = (int)queriesTableAdapter1.SQCountC_IDinStudent(id);
                global::System.Nullable<int> lc_count = (int)queriesTableAdapter1.SQCountC_IDinLecturer(id);
                global::System.Nullable<int> ev_count = (int)queriesTableAdapter1.SQCountC_IDinEvent_client(id);

                if (s_count == 0 && lc_count == 0 && ev_count == 0)
                {
                    cLIENTBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! К клиенту привязан студент/лектор/участник ивента!", "Ошибка удаления клиента");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления клиента");
            }
        }

        private void saveStudent_Click(object sender, EventArgs e)
        {
            //для зміни курсу, можна в DataGridView зробити 2 колонки comboBox'ы (S_CL, CL_ID, CL_THEME) і (S_C, C_ID, C_NAME)

            sTUDENTTableAdapter.Update(fFbasEDataSet.STUDENT);
            changed[2] = false;
        }

        private void delStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dGVStudent.CurrentRow.Index;
                int s_id = (int)dGVStudent.CurrentRow.Cells["sIDDatagridViewTextBoxColumn"].Value;
                global::System.Nullable<int> sl_count = (int)queriesTableAdapter1.SQCountS_IDinStudent_on_lecture(s_id);

                if (sl_count == 0)
                {
                    infoSTUDENTBindingSource.RemoveCurrent();
                    sTUDENTBindingSource.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! У студента запланирована лекция!", "Ошибка удаления студента");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления студента");
            }
        }

        private void saveLecture_Click(object sender, EventArgs e)
        {
            lECTURETableAdapter.Update(fFbasEDataSet.LECTURE);
            changed[3] = false;
        }

        private void delLecture_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dGVLecture.CurrentRow.Index;
                int id = (int)dGVLecture.CurrentRow.Cells["lIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> sl_count = (int)queriesTableAdapter1.SQCountL_IDinStudent_on_lecture(id);

                if (sl_count == 0)
                {
                    infoLECTUREBindingSource.RemoveCurrent();
                    lECTUREBindingSource.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! К лекции привязан студент!", "Ошибка удаления лекции");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления лекции");
            }
        }

        private void saveLecturer_Click(object sender, EventArgs e)
        {
            lECTURERTableAdapter.Update(fFbasEDataSet.LECTURER);
            changed[4] = false;
        }

        private void delLecturer_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dGVLecturer.CurrentRow.Index;
                int id = (int)dGVLecturer.CurrentRow.Cells["lCIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> l_count = (int)queriesTableAdapter1.SQCountLC_IDinLecture(id);

                if (l_count == 0)
                {
                    infoLECTURERBindingSource.RemoveCurrent();
                    lECTURERBindingSource.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! У лектора запланирована лекция!", "Ошибка удаления лектора");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления лектора");
            }
        }

        private void saveEvent_Click(object sender, EventArgs e)
        {
            eVENTTableAdapter.Update(fFbasEDataSet.EVENT);
            changed[5] = false;
        }

        private void delEvent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVEvent.CurrentRow.Cells["eIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> ec_count = (int)queriesTableAdapter1.SQCountE_IDinEvent_client(id);

                if (ec_count == 0)
                {
                    eVENTBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Удалить нельзя! К ивенту прязан клиент!", "Ошибка удаления ивента");
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Ошибка удаления ивента");
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddClient addClientDialog = new FrmAddClient();

                addClientDialog.ShowDialog(this);
                addClientDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление клиента");
            }
        }


        private void addCourseOfLecture_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddCourseOfLecture addCourseOfLectureDialog = new FrmAddCourseOfLecture(this);

                addCourseOfLectureDialog.ShowDialog(this);
                addCourseOfLectureDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление обучающего курса");
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddStudent addStudentDialog = new FrmAddStudent();

                addStudentDialog.ShowDialog(this);
                addStudentDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление студента");
            }
        }

        private void dGVClient_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void dGVStudent_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string name = (string)dGVStudent.CurrentRow.Cells["sNAMEDataGridViewTextBoxColumn"].Value;
            int s_c = (int)dGVStudent.CurrentRow.Cells["sCDataGridViewTextBoxColumn"].Value;

            infoSTUDENTTableAdapter1.FillByOneStudent(fFbasEDataSet.infoSTUDENT, s_c);
            */
        }

        public List<string> parametersClient = new List<string> { "", "", "", "", "", "", "", "", "" };
        public List<string> parametersCourse = new List<string> { "", "", "" };
        public List<string> parametersStudent = new List<string> { };
        public List<string> parametersLecture = new List<string> { };
        public List<string> parametersLecturer = new List<string> { };
        public List<string> parametersEvent = new List<string> { "", "", "", "", "", "" };

        private void filterClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                filterClientFrm filterClientDialog = new filterClientFrm(this);

                filterClientDialog.ShowDialog(this);
                //filterCourseDialog.Dispose();

                string expression = String.Empty;

                for (int i = 0; i < parametersClient.Count(); i++)
                {
                    if (parametersClient[i] != String.Empty)
                    {
                        expression += " AND " + parametersClient[i];
                    }
                }

                if (expression != String.Empty)
                {
                    int indexEnd = expression.IndexOf("C");
                    int smallC = expression.IndexOf("c");

                    if ((smallC >= 0) && (expression.IndexOf("C") > expression.IndexOf("c")))
                    {
                        indexEnd = expression.IndexOf("c");
                    }

                    expression = expression.Substring(indexEnd, expression.Length - indexEnd);

                    cLIENTBindingSource.Filter = expression;
                }
                else
                {
                    cLIENTBindingSource.RemoveFilter();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Фильтр клиента");
            }
        }

        private void статусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddStatus addStatusDialog = new FrmAddStatus();

                addStatusDialog.ShowDialog(this);
                addStatusDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр клиента");
            }
        }

        private void delFilterClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < parametersCourse.Count(); i++)
                {
                    parametersClient[i] = String.Empty;
                }
                cLIENTBindingSource.RemoveFilter();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Сброс фильтра");
            }
        }

        private void delFilterCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < parametersCourse.Count(); i++)
                {
                    parametersCourse[i] = String.Empty;
                }
                cOURSEOFLECTUREBindingSource.RemoveFilter();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Сброс фильтра");
            }
        }

        private void filterCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFilterCourse filterCourseDialog = new FrmFilterCourse(this);

                filterCourseDialog.ShowDialog(this);
                //filterCourseDialog.Dispose();

                string expression = String.Empty;

                for (int i = 0; i < parametersCourse.Count(); i++)
                {
                    if (parametersCourse[i] != String.Empty)
                    {
                        expression += " AND " + parametersCourse[i];
                    }
                }

                if (expression != String.Empty)
                {
                    int indexEnd = expression.IndexOf("C");
                    expression = expression.Substring(indexEnd, expression.Length - indexEnd);

                    cOURSEOFLECTUREBindingSource.Filter = expression;
                }
                else
                {
                    cOURSEOFLECTUREBindingSource.RemoveFilter();
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр клиента");
            }
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddEvent addEventDialog = new FrmAddEvent();

                addEventDialog.ShowDialog();
                addEventDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление ивента");
            }
        }

        private void filterEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFilterEvent filterEventDialog = new FrmFilterEvent(this);

                filterEventDialog.ShowDialog(this);
                //filterEventDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Фильтр ивента");
            }
        }

        private void dGVClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed[0] = true;
        }

        private void FrmFFbasE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkForChanges())
            {
                DialogResult result = MessageBox.Show("Есть новые изминения. Хотите их сохранить ?", "Внимание",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (changed[0]) saveClient.PerformClick();
                    if (changed[1]) saveCourseOfLecture.PerformClick();
                    if (changed[2]) saveStudent.PerformClick();
                    if (changed[3]) saveLecture.PerformClick();
                    if (changed[4]) saveLecturer.PerformClick();
                    if (changed[5]) saveEvent.PerformClick();
                }
                else if (result == DialogResult.No)
                {
                    //
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddClient addClientDialog = new FrmAddClient();

                addClientDialog.ShowDialog(this);
                addClientDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление клиента");
            }
        }

        private void обучающийКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddCourseOfLecture addCourseOfLectureDialog = new FrmAddCourseOfLecture(this);

                addCourseOfLectureDialog.ShowDialog(this);
                addCourseOfLectureDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление обучающего курса");
            }
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddStudent addStudentDialog = new FrmAddStudent();

                addStudentDialog.ShowDialog(this);
                addStudentDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление студента");
            }
        }

        private void лекцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void лекторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void ивентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddEvent addEventDialog = new FrmAddEvent();

                addEventDialog.ShowDialog();
                addEventDialog.Dispose();
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление ивента");
            }
        }

        private void dGVCourseOfLecture_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed[1] = true;
        }

        private void dGVStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed[2] = true;
        }

        private void dGVLecture_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed[3] = true;
        }

        private void dGVLecturer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed[4] = true;
        }

        private void dGVEvent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed[5] = true;
        }


        private void dGVCourseOfLecture_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dGVCourseOfLecture.CurrentRow.Cells["cLIDDataGridViewTextBoxColumn"].Value;

            if (e.ColumnIndex == dGVCourseOfLecture.CurrentRow.Cells["cLSTUDENTSDataGridViewTextBoxColumn"].ColumnIndex)
                infoSTUDENTTableAdapterSecondary.FillByStudentsOfCourse(fFbasEDataSet.infoSTUDENT, id);
            else if (e.ColumnIndex == dGVCourseOfLecture.CurrentRow.Cells["cLLECTURESDataGridViewTextBoxColumn"].ColumnIndex)
                infoLECTURETableAdapter.FillByLecturesOfCourse(fFbasEDataSet.infoLECTURE, id);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string myXMLfile = @"../../XMLFile.xml";

            var dt = new DataTable();
            foreach (DataGridViewColumn column in dGVClient.Columns)
            {
                dt.Columns.Add();
            }
            object[] cellValues = new object[dGVClient.Columns.Count];
            foreach (DataGridViewRow row in dGVClient.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            DataTable dT = dt;
            dT.Columns[0].ColumnName = "ID";
            DataSet dS = new DataSet();
            dS.Tables.Add(dT);
            dS.Tables[0].TableName = "Client";
            dS.WriteXml(myXMLfile);
        }
    }
}
