namespace WinFormsFFbasE
{
    partial class FrmFilterEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxVenue = new System.Windows.Forms.TextBox();
            this.textBoxEntrancePrice = new System.Windows.Forms.TextBox();
            this.textBoxReceipts = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.fFbasEDataSet = new WinFormsFFbasE.FFbasEDataSet();
            this.sTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTATUSTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.STATUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название ивента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата проведения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Местро проведения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена входа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Прибыль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Статус:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(129, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // dateDate
            // 
            this.dateDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDate.CustomFormat = " ";
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDate.Location = new System.Drawing.Point(129, 39);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(209, 20);
            this.dateDate.TabIndex = 7;
            this.dateDate.ValueChanged += new System.EventHandler(this.dateDate_ValueChanged);
            // 
            // textBoxVenue
            // 
            this.textBoxVenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVenue.Location = new System.Drawing.Point(129, 66);
            this.textBoxVenue.Name = "textBoxVenue";
            this.textBoxVenue.Size = new System.Drawing.Size(209, 20);
            this.textBoxVenue.TabIndex = 8;
            // 
            // textBoxEntrancePrice
            // 
            this.textBoxEntrancePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEntrancePrice.Location = new System.Drawing.Point(129, 93);
            this.textBoxEntrancePrice.Name = "textBoxEntrancePrice";
            this.textBoxEntrancePrice.Size = new System.Drawing.Size(209, 20);
            this.textBoxEntrancePrice.TabIndex = 9;
            // 
            // textBoxReceipts
            // 
            this.textBoxReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceipts.Location = new System.Drawing.Point(129, 120);
            this.textBoxReceipts.Name = "textBoxReceipts";
            this.textBoxReceipts.Size = new System.Drawing.Size(209, 20);
            this.textBoxReceipts.TabIndex = 10;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DataSource = this.sTATUSBindingSource;
            this.comboBoxStatus.DisplayMember = "SG_NAME";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(129, 147);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(209, 21);
            this.comboBoxStatus.TabIndex = 11;
            this.comboBoxStatus.ValueMember = "SG_ID";
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFind.Location = new System.Drawing.Point(93, 201);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 12;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClear.Location = new System.Drawing.Point(174, 201);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // fFbasEDataSet
            // 
            this.fFbasEDataSet.DataSetName = "FFbasEDataSet";
            this.fFbasEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTATUSBindingSource
            // 
            this.sTATUSBindingSource.DataMember = "STATUS";
            this.sTATUSBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // sTATUSTableAdapter
            // 
            this.sTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFilterEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 257);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxReceipts);
            this.Controls.Add(this.textBoxEntrancePrice);
            this.Controls.Add(this.textBoxVenue);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFilterEvent";
            this.Text = "Фильтр ивента";
            this.Load += new System.EventHandler(this.FrmFilterEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.TextBox textBoxVenue;
        private System.Windows.Forms.TextBox textBoxEntrancePrice;
        private System.Windows.Forms.TextBox textBoxReceipts;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClear;
        private FFbasEDataSet fFbasEDataSet;
        private System.Windows.Forms.BindingSource sTATUSBindingSource;
        private FFbasEDataSetTableAdapters.STATUSTableAdapter sTATUSTableAdapter;
    }
}