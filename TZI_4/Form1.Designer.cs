namespace Modelling_signals
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxHexNumber = new System.Windows.Forms.TextBox();
            this.textBoxBinNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSwitchMetod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(763, 121);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // textBoxHexNumber
            // 
            this.textBoxHexNumber.Location = new System.Drawing.Point(12, 11);
            this.textBoxHexNumber.Name = "textBoxHexNumber";
            this.textBoxHexNumber.Size = new System.Drawing.Size(151, 22);
            this.textBoxHexNumber.TabIndex = 1;
            this.textBoxHexNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBinNumber_KeyPress);
            // 
            // textBoxBinNumber
            // 
            this.textBoxBinNumber.Location = new System.Drawing.Point(169, 11);
            this.textBoxBinNumber.Name = "textBoxBinNumber";
            this.textBoxBinNumber.ReadOnly = true;
            this.textBoxBinNumber.Size = new System.Drawing.Size(452, 22);
            this.textBoxBinNumber.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 129);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxSwitchMetod
            // 
            this.comboBoxSwitchMetod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSwitchMetod.FormattingEnabled = true;
            this.comboBoxSwitchMetod.Items.AddRange(new object[] {
            "NRZ",
            "diff. NRZ",
            "NRZI",
            "RZ",
            "AMI",
            "Manchester ",
            "2B1Q"});
            this.comboBoxSwitchMetod.Location = new System.Drawing.Point(627, 11);
            this.comboBoxSwitchMetod.Name = "comboBoxSwitchMetod";
            this.comboBoxSwitchMetod.Size = new System.Drawing.Size(154, 24);
            this.comboBoxSwitchMetod.TabIndex = 5;
            this.comboBoxSwitchMetod.SelectedIndexChanged += new System.EventHandler(this.comboBoxSwitchMetod_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 178);
            this.Controls.Add(this.comboBoxSwitchMetod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxBinNumber);
            this.Controls.Add(this.textBoxHexNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "TZI_4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxHexNumber;
        private System.Windows.Forms.TextBox textBoxBinNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSwitchMetod;
    }
}

