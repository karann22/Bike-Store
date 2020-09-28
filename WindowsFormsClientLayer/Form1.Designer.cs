namespace WindowsFormsClientLayer
{
    partial class Form1
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
            this.labelSrNum = new System.Windows.Forms.Label();
            this.textBoxSrNum = new System.Windows.Forms.TextBox();
            this.labelSpd = new System.Windows.Forms.Label();
            this.labelMd = new System.Windows.Forms.Label();
            this.textBoxMd = new System.Windows.Forms.TextBox();
            this.textBoxSpd = new System.Windows.Forms.TextBox();
            this.labelClr = new System.Windows.Forms.Label();
            this.comboBoxClr = new System.Windows.Forms.ComboBox();
            this.radioButtonRdBikes = new System.Windows.Forms.RadioButton();
            this.radioButtonMtnBikes = new System.Windows.Forms.RadioButton();
            this.labelWght = new System.Windows.Forms.Label();
            this.labelStHght = new System.Windows.Forms.Label();
            this.textBoxWght = new System.Windows.Forms.TextBox();
            this.textBoxStHght = new System.Windows.Forms.TextBox();
            this.Hght = new System.Windows.Forms.Label();
            this.textBoxHght = new System.Windows.Forms.TextBox();
            this.labelSus = new System.Windows.Forms.Label();
            this.labelHdLight = new System.Windows.Forms.Label();
            this.comboBoxSuspension = new System.Windows.Forms.ComboBox();
            this.comboBoxHdLight = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonRdBikes = new System.Windows.Forms.Button();
            this.buttonMtBikes = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelNewSpeedRD = new System.Windows.Forms.Label();
            this.labelNewSpeedMT = new System.Windows.Forms.Label();
            this.textBoxNewSpeedRD = new System.Windows.Forms.TextBox();
            this.textBoxNewSpeedMT = new System.Windows.Forms.TextBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSrNum
            // 
            this.labelSrNum.AutoSize = true;
            this.labelSrNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSrNum.Location = new System.Drawing.Point(32, 26);
            this.labelSrNum.Name = "labelSrNum";
            this.labelSrNum.Size = new System.Drawing.Size(111, 22);
            this.labelSrNum.TabIndex = 0;
            this.labelSrNum.Text = "Serial Number";
            this.labelSrNum.Click += new System.EventHandler(this.labelSrNum_Click);
            // 
            // textBoxSrNum
            // 
            this.textBoxSrNum.Location = new System.Drawing.Point(149, 23);
            this.textBoxSrNum.Name = "textBoxSrNum";
            this.textBoxSrNum.Size = new System.Drawing.Size(161, 26);
            this.textBoxSrNum.TabIndex = 1;
            // 
            // labelSpd
            // 
            this.labelSpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpd.Location = new System.Drawing.Point(32, 100);
            this.labelSpd.Name = "labelSpd";
            this.labelSpd.Size = new System.Drawing.Size(111, 22);
            this.labelSpd.TabIndex = 2;
            this.labelSpd.Text = "Speed";
            this.labelSpd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMd
            // 
            this.labelMd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMd.Location = new System.Drawing.Point(32, 63);
            this.labelMd.Name = "labelMd";
            this.labelMd.Size = new System.Drawing.Size(111, 22);
            this.labelMd.TabIndex = 3;
            this.labelMd.Text = "Made";
            this.labelMd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMd
            // 
            this.textBoxMd.Location = new System.Drawing.Point(149, 61);
            this.textBoxMd.Name = "textBoxMd";
            this.textBoxMd.Size = new System.Drawing.Size(161, 26);
            this.textBoxMd.TabIndex = 4;
            // 
            // textBoxSpd
            // 
            this.textBoxSpd.Location = new System.Drawing.Point(149, 98);
            this.textBoxSpd.Name = "textBoxSpd";
            this.textBoxSpd.Size = new System.Drawing.Size(161, 26);
            this.textBoxSpd.TabIndex = 5;
            this.textBoxSpd.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // labelClr
            // 
            this.labelClr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClr.Location = new System.Drawing.Point(32, 138);
            this.labelClr.Name = "labelClr";
            this.labelClr.Size = new System.Drawing.Size(111, 22);
            this.labelClr.TabIndex = 6;
            this.labelClr.Text = "Color";
            this.labelClr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClr.Click += new System.EventHandler(this.labelClr_Click);
            // 
            // comboBoxClr
            // 
            this.comboBoxClr.FormattingEnabled = true;
            this.comboBoxClr.Location = new System.Drawing.Point(149, 135);
            this.comboBoxClr.Name = "comboBoxClr";
            this.comboBoxClr.Size = new System.Drawing.Size(161, 28);
            this.comboBoxClr.TabIndex = 7;
            this.comboBoxClr.SelectedIndexChanged += new System.EventHandler(this.comboBoxClr_SelectedIndexChanged);
            // 
            // radioButtonRdBikes
            // 
            this.radioButtonRdBikes.AutoSize = true;
            this.radioButtonRdBikes.Location = new System.Drawing.Point(561, 23);
            this.radioButtonRdBikes.Name = "radioButtonRdBikes";
            this.radioButtonRdBikes.Size = new System.Drawing.Size(119, 24);
            this.radioButtonRdBikes.TabIndex = 8;
            this.radioButtonRdBikes.TabStop = true;
            this.radioButtonRdBikes.Text = "Radio Bikes";
            this.radioButtonRdBikes.UseVisualStyleBackColor = true;
            this.radioButtonRdBikes.CheckedChanged += new System.EventHandler(this.radioButtonRdBikes_CheckedChanged);
            // 
            // radioButtonMtnBikes
            // 
            this.radioButtonMtnBikes.AutoSize = true;
            this.radioButtonMtnBikes.Location = new System.Drawing.Point(872, 23);
            this.radioButtonMtnBikes.Name = "radioButtonMtnBikes";
            this.radioButtonMtnBikes.Size = new System.Drawing.Size(143, 24);
            this.radioButtonMtnBikes.TabIndex = 9;
            this.radioButtonMtnBikes.TabStop = true;
            this.radioButtonMtnBikes.Text = "Mountain Bikes";
            this.radioButtonMtnBikes.UseVisualStyleBackColor = true;
            this.radioButtonMtnBikes.CheckedChanged += new System.EventHandler(this.radioButtonMtnBikes_CheckedChanged);
            // 
            // labelWght
            // 
            this.labelWght.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWght.Location = new System.Drawing.Point(561, 107);
            this.labelWght.Name = "labelWght";
            this.labelWght.Size = new System.Drawing.Size(111, 32);
            this.labelWght.TabIndex = 10;
            this.labelWght.Text = "Weight";
            this.labelWght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStHght
            // 
            this.labelStHght.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStHght.Location = new System.Drawing.Point(561, 63);
            this.labelStHght.Name = "labelStHght";
            this.labelStHght.Size = new System.Drawing.Size(111, 30);
            this.labelStHght.TabIndex = 11;
            this.labelStHght.Text = "Seat Height";
            this.labelStHght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWght
            // 
            this.textBoxWght.Location = new System.Drawing.Point(688, 107);
            this.textBoxWght.Name = "textBoxWght";
            this.textBoxWght.Size = new System.Drawing.Size(126, 26);
            this.textBoxWght.TabIndex = 12;
            // 
            // textBoxStHght
            // 
            this.textBoxStHght.Location = new System.Drawing.Point(688, 65);
            this.textBoxStHght.Name = "textBoxStHght";
            this.textBoxStHght.Size = new System.Drawing.Size(126, 26);
            this.textBoxStHght.TabIndex = 13;
            // 
            // Hght
            // 
            this.Hght.BackColor = System.Drawing.SystemColors.Control;
            this.Hght.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hght.Location = new System.Drawing.Point(872, 63);
            this.Hght.Name = "Hght";
            this.Hght.Size = new System.Drawing.Size(111, 30);
            this.Hght.TabIndex = 14;
            this.Hght.Text = "Height";
            this.Hght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHght
            // 
            this.textBoxHght.Location = new System.Drawing.Point(1015, 62);
            this.textBoxHght.Name = "textBoxHght";
            this.textBoxHght.Size = new System.Drawing.Size(118, 26);
            this.textBoxHght.TabIndex = 15;
            // 
            // labelSus
            // 
            this.labelSus.BackColor = System.Drawing.SystemColors.Control;
            this.labelSus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSus.Location = new System.Drawing.Point(872, 101);
            this.labelSus.Name = "labelSus";
            this.labelSus.Size = new System.Drawing.Size(111, 32);
            this.labelSus.TabIndex = 16;
            this.labelSus.Text = "Suspension";
            this.labelSus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHdLight
            // 
            this.labelHdLight.BackColor = System.Drawing.SystemColors.Control;
            this.labelHdLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHdLight.Location = new System.Drawing.Point(872, 143);
            this.labelHdLight.Name = "labelHdLight";
            this.labelHdLight.Size = new System.Drawing.Size(111, 39);
            this.labelHdLight.TabIndex = 17;
            this.labelHdLight.Text = "HeadLight";
            this.labelHdLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSuspension
            // 
            this.comboBoxSuspension.FormattingEnabled = true;
            this.comboBoxSuspension.Location = new System.Drawing.Point(1015, 98);
            this.comboBoxSuspension.Name = "comboBoxSuspension";
            this.comboBoxSuspension.Size = new System.Drawing.Size(118, 28);
            this.comboBoxSuspension.TabIndex = 18;
            this.comboBoxSuspension.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuspension_SelectedIndexChanged);
            // 
            // comboBoxHdLight
            // 
            this.comboBoxHdLight.FormattingEnabled = true;
            this.comboBoxHdLight.Location = new System.Drawing.Point(1015, 147);
            this.comboBoxHdLight.Name = "comboBoxHdLight";
            this.comboBoxHdLight.Size = new System.Drawing.Size(118, 28);
            this.comboBoxHdLight.TabIndex = 19;
            this.comboBoxHdLight.SelectedIndexChanged += new System.EventHandler(this.comboBoxHdLight_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(82, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 45);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(201, 277);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 45);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(319, 277);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(89, 45);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1079, 282);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(89, 48);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(279, 512);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(190, 38);
            this.buttonDisplay.TabIndex = 24;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1060, 553);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 53);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(849, 282);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(206, 26);
            this.textBoxSearch.TabIndex = 26;
            // 
            // labelSearch
            // 
            this.labelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSearch.Location = new System.Drawing.Point(655, 282);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(177, 34);
            this.labelSearch.TabIndex = 27;
            this.labelSearch.Text = "Enter Serial Number";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 20;
            this.listBoxDisplay.Location = new System.Drawing.Point(6, 348);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(1450, 144);
            this.listBoxDisplay.TabIndex = 28;
            this.listBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplay_SelectedIndexChanged);
            // 
            // labelYear
            // 
            this.labelYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYear.Location = new System.Drawing.Point(32, 175);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(111, 22);
            this.labelYear.TabIndex = 30;
            this.labelYear.Text = "Year";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYear.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(149, 171);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(161, 26);
            this.textBoxYear.TabIndex = 31;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // buttonRdBikes
            // 
            this.buttonRdBikes.Location = new System.Drawing.Point(499, 512);
            this.buttonRdBikes.Name = "buttonRdBikes";
            this.buttonRdBikes.Size = new System.Drawing.Size(190, 38);
            this.buttonRdBikes.TabIndex = 32;
            this.buttonRdBikes.Text = "Display Road Bikes";
            this.buttonRdBikes.UseVisualStyleBackColor = true;
            this.buttonRdBikes.Click += new System.EventHandler(this.buttonRdBikes_Click);
            // 
            // buttonMtBikes
            // 
            this.buttonMtBikes.Location = new System.Drawing.Point(724, 512);
            this.buttonMtBikes.Name = "buttonMtBikes";
            this.buttonMtBikes.Size = new System.Drawing.Size(190, 38);
            this.buttonMtBikes.TabIndex = 33;
            this.buttonMtBikes.Text = "Display Mountain Bikes";
            this.buttonMtBikes.UseVisualStyleBackColor = true;
            this.buttonMtBikes.Click += new System.EventHandler(this.buttonMtBikes_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(418, 565);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 53);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Write To File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(651, 565);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(163, 53);
            this.buttonLoad.TabIndex = 35;
            this.buttonLoad.Text = "Read From File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPrice.Location = new System.Drawing.Point(32, 215);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(111, 22);
            this.labelPrice.TabIndex = 36;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrice.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(149, 211);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(161, 26);
            this.textBoxPrice.TabIndex = 37;
            // 
            // labelNewSpeedRD
            // 
            this.labelNewSpeedRD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNewSpeedRD.Location = new System.Drawing.Point(561, 150);
            this.labelNewSpeedRD.Name = "labelNewSpeedRD";
            this.labelNewSpeedRD.Size = new System.Drawing.Size(111, 32);
            this.labelNewSpeedRD.TabIndex = 38;
            this.labelNewSpeedRD.Text = "New Speed: ";
            this.labelNewSpeedRD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewSpeedRD.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelNewSpeedMT
            // 
            this.labelNewSpeedMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNewSpeedMT.Location = new System.Drawing.Point(872, 188);
            this.labelNewSpeedMT.Name = "labelNewSpeedMT";
            this.labelNewSpeedMT.Size = new System.Drawing.Size(111, 32);
            this.labelNewSpeedMT.TabIndex = 39;
            this.labelNewSpeedMT.Text = "New Speed:";
            this.labelNewSpeedMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewSpeedRD
            // 
            this.textBoxNewSpeedRD.Location = new System.Drawing.Point(688, 156);
            this.textBoxNewSpeedRD.Name = "textBoxNewSpeedRD";
            this.textBoxNewSpeedRD.Size = new System.Drawing.Size(126, 26);
            this.textBoxNewSpeedRD.TabIndex = 40;
            // 
            // textBoxNewSpeedMT
            // 
            this.textBoxNewSpeedMT.Location = new System.Drawing.Point(1015, 194);
            this.textBoxNewSpeedMT.Name = "textBoxNewSpeedMT";
            this.textBoxNewSpeedMT.Size = new System.Drawing.Size(118, 26);
            this.textBoxNewSpeedMT.TabIndex = 41;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(442, 277);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(89, 45);
            this.buttonClearAll.TabIndex = 42;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1468, 630);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.textBoxNewSpeedMT);
            this.Controls.Add(this.textBoxNewSpeedRD);
            this.Controls.Add(this.labelNewSpeedMT);
            this.Controls.Add(this.labelNewSpeedRD);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonMtBikes);
            this.Controls.Add(this.buttonRdBikes);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxHdLight);
            this.Controls.Add(this.comboBoxSuspension);
            this.Controls.Add(this.labelHdLight);
            this.Controls.Add(this.labelSus);
            this.Controls.Add(this.textBoxHght);
            this.Controls.Add(this.Hght);
            this.Controls.Add(this.textBoxStHght);
            this.Controls.Add(this.textBoxWght);
            this.Controls.Add(this.labelStHght);
            this.Controls.Add(this.labelWght);
            this.Controls.Add(this.radioButtonMtnBikes);
            this.Controls.Add(this.radioButtonRdBikes);
            this.Controls.Add(this.comboBoxClr);
            this.Controls.Add(this.labelClr);
            this.Controls.Add(this.textBoxSpd);
            this.Controls.Add(this.textBoxMd);
            this.Controls.Add(this.labelMd);
            this.Controls.Add(this.labelSpd);
            this.Controls.Add(this.textBoxSrNum);
            this.Controls.Add(this.labelSrNum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Bikes";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSrNum;
        private System.Windows.Forms.TextBox textBoxSrNum;
        private System.Windows.Forms.Label labelSpd;
        private System.Windows.Forms.Label labelMd;
        private System.Windows.Forms.TextBox textBoxMd;
        private System.Windows.Forms.TextBox textBoxSpd;
        private System.Windows.Forms.Label labelClr;
        private System.Windows.Forms.ComboBox comboBoxClr;
        private System.Windows.Forms.RadioButton radioButtonRdBikes;
        private System.Windows.Forms.RadioButton radioButtonMtnBikes;
        private System.Windows.Forms.Label labelWght;
        private System.Windows.Forms.Label labelStHght;
        private System.Windows.Forms.TextBox textBoxWght;
        private System.Windows.Forms.TextBox textBoxStHght;
        private System.Windows.Forms.Label Hght;
        private System.Windows.Forms.TextBox textBoxHght;
        private System.Windows.Forms.Label labelSus;
        private System.Windows.Forms.Label labelHdLight;
        private System.Windows.Forms.ComboBox comboBoxSuspension;
        private System.Windows.Forms.ComboBox comboBoxHdLight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonRdBikes;
        private System.Windows.Forms.Button buttonMtBikes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelNewSpeedRD;
        private System.Windows.Forms.Label labelNewSpeedMT;
        private System.Windows.Forms.TextBox textBoxNewSpeedRD;
        private System.Windows.Forms.TextBox textBoxNewSpeedMT;
        private System.Windows.Forms.Button buttonClearAll;
    }
}

