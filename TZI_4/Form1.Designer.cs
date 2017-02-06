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
            this.textBoxBinStaffNumber = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxSizeStaffing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(748, 121);
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
            this.textBoxBinNumber.Size = new System.Drawing.Size(405, 22);
            this.textBoxBinNumber.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 129);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxSwitchMetod
            // 
            this.comboBoxSwitchMetod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSwitchMetod.FormattingEnabled = true;
            this.comboBoxSwitchMetod.Items.AddRange(new object[] {
            "NRZ",
            "NRZI(1)",
            "NRZI(0)",
            "RZ",
            "AMI",
            "Manchester",
            "2B1Q"});
            this.comboBoxSwitchMetod.Location = new System.Drawing.Point(585, 9);
            this.comboBoxSwitchMetod.Name = "comboBoxSwitchMetod";
            this.comboBoxSwitchMetod.Size = new System.Drawing.Size(85, 24);
            this.comboBoxSwitchMetod.TabIndex = 5;
            // 
            // textBoxBinStaffNumber
            // 
            this.textBoxBinStaffNumber.Location = new System.Drawing.Point(169, 39);
            this.textBoxBinStaffNumber.Name = "textBoxBinStaffNumber";
            this.textBoxBinStaffNumber.ReadOnly = true;
            this.textBoxBinStaffNumber.Size = new System.Drawing.Size(405, 22);
            this.textBoxBinStaffNumber.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(677, 9);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 27);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(584, 37);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(89, 27);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(677, 37);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 27);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxSizeStaffing
            // 
            this.textBoxSizeStaffing.Location = new System.Drawing.Point(12, 39);
            this.textBoxSizeStaffing.Name = "textBoxSizeStaffing";
            this.textBoxSizeStaffing.Size = new System.Drawing.Size(151, 22);
            this.textBoxSizeStaffing.TabIndex = 6;
            this.textBoxSizeStaffing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizeStaffing_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 207);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxBinStaffNumber);
            this.Controls.Add(this.textBoxSizeStaffing);
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
        private System.Windows.Forms.TextBox textBoxBinStaffNumber;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxSizeStaffing;
    }
}

