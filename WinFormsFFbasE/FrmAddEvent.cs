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
    public partial class FrmAddEvent : Form
    {
        public FrmAddEvent()
        {
            InitializeComponent();
        }

        string unNoneError = "Неизвестная ошибка! Обратитесь к Алексею!";

        private void FrmAddEvent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.EVENT". При необходимости она может быть перемещена или удалена.
            this.eVENTTableAdapter.Fill(this.fFbasEDataSet.EVENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fFbasEDataSet.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.fFbasEDataSet.STATUS);

            this.comboBoxStatus.SelectedItem = null;
        }

        private void dateDate_ValueChanged(object sender, EventArgs e)
        {
            dateDate.CustomFormat = "dd, MMMM, yyyy";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text == String.Empty)
                {
                    MessageBox.Show("Введите название ивента", "Добавление ивента");
                }
                else
                {
                    bool success = true;
                    float receipts = 0, entrancePrice = 0;
                    try
                    {
                        if (textBoxEntrancePrice.Text != String.Empty) { entrancePrice = float.Parse(textBoxEntrancePrice.Text.Replace('.', ',')); }
                        if (textBoxReceipts.Text != String.Empty) { receipts = float.Parse(textBoxReceipts.Text.Replace('.', ',')); }
                    }
                    catch
                    {
                        success = false;
                        MessageBox.Show("Не верно введенное число в поле 'Цена входа'/'Прибыль' !", "Добавление ивента");
                    }

                    if (success)
                    {
                        if (dateDate.CustomFormat == " " && comboBoxStatus.SelectedValue == null)
                        {
                            if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, null, null, null);
                            }
                            else if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text != String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, null, receipts, null);
                            }
                            else if (textBoxEntrancePrice.Text != String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, entrancePrice, null, null);
                            }
                            else
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, entrancePrice, receipts, null);
                            }
                        }
                        else if (dateDate.CustomFormat != " " && comboBoxStatus.SelectedValue == null)
                        {
                            if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, null, null, null);
                            }
                            else if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text != String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, null, receipts, null);
                            }
                            else if (textBoxEntrancePrice.Text != String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, entrancePrice, null, null);
                            }
                            else
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, entrancePrice, receipts, null);
                            }
                        }
                        else if (dateDate.CustomFormat == " " && comboBoxStatus.SelectedValue != null)
                        {
                            if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, null, null, (int)comboBoxStatus.SelectedValue);
                            }
                            else if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text != String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, null, receipts, (int)comboBoxStatus.SelectedValue);
                            }
                            else if (textBoxEntrancePrice.Text != String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, entrancePrice, null, (int)comboBoxStatus.SelectedValue);
                            }
                            else
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, null, textBoxVenue.Text, entrancePrice, receipts, (int)comboBoxStatus.SelectedValue);
                            }
                        }
                        else
                        {
                            if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, null, null, (int)comboBoxStatus.SelectedValue);
                            }
                            else if (textBoxEntrancePrice.Text == String.Empty && textBoxReceipts.Text != String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, null, receipts, (int)comboBoxStatus.SelectedValue);
                            }
                            else if (textBoxEntrancePrice.Text != String.Empty && textBoxReceipts.Text == String.Empty)
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, entrancePrice, null, (int)comboBoxStatus.SelectedValue);
                            }
                            else
                            {
                                eVENTTableAdapter.Insert(textBoxName.Text, dateDate.Value, textBoxVenue.Text, entrancePrice, receipts, (int)comboBoxStatus.SelectedValue);
                            }
                        }
                        MessageBox.Show("Ивент успешно добален!", "Добваление ивента");

                        textBoxName.Text = String.Empty;
                        dateDate.CustomFormat = " ";
                        textBoxVenue.Text = String.Empty;
                        textBoxEntrancePrice.Text = String.Empty;
                        textBoxReceipts.Text = String.Empty;
                        comboBoxStatus.SelectedItem = null;
                    }                 
                }
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление ивента");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxName.Text = String.Empty;
                dateDate.CustomFormat = " ";
                textBoxVenue.Text = String.Empty;
                textBoxEntrancePrice.Text = String.Empty;
                textBoxReceipts.Text = String.Empty;
                comboBoxStatus.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show(unNoneError, "Добавление ивента");
            }
        }
    }
}
