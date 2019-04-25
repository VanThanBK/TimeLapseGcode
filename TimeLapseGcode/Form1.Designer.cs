namespace TimeLapseGcode
{
    partial class TimeLapse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLapse));
            this.checkBoxEnableRetraction = new System.Windows.Forms.CheckBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelRetractionDistance = new System.Windows.Forms.Label();
            this.labelRetractionSpeed = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.checkBoxEnablePark = new System.Windows.Forms.CheckBox();
            this.labelParkX = new System.Windows.Forms.Label();
            this.textBoxHeadX = new System.Windows.Forms.TextBox();
            this.labelParkY = new System.Windows.Forms.Label();
            this.textBoxHeadY = new System.Windows.Forms.TextBox();
            this.textBoxFeedRate = new System.Windows.Forms.TextBox();
            this.labelFeedRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.labelfilePath = new System.Windows.Forms.Label();
            this.labelTimeDelay = new System.Windows.Forms.Label();
            this.textBoxTimeDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarInsertFile = new System.Windows.Forms.ProgressBar();
            this.textBoxLayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxEnableRetraction
            // 
            this.checkBoxEnableRetraction.AutoSize = true;
            this.checkBoxEnableRetraction.Checked = true;
            this.checkBoxEnableRetraction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableRetraction.Location = new System.Drawing.Point(12, 12);
            this.checkBoxEnableRetraction.Name = "checkBoxEnableRetraction";
            this.checkBoxEnableRetraction.Size = new System.Drawing.Size(111, 17);
            this.checkBoxEnableRetraction.TabIndex = 0;
            this.checkBoxEnableRetraction.Text = "Enable Retraction";
            this.checkBoxEnableRetraction.UseVisualStyleBackColor = true;
            this.checkBoxEnableRetraction.CheckedChanged += new System.EventHandler(this.CheckBoxEnableChanged);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(131, 29);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 1;
            this.textBoxDistance.Text = "6.5";
            // 
            // labelRetractionDistance
            // 
            this.labelRetractionDistance.AutoSize = true;
            this.labelRetractionDistance.Location = new System.Drawing.Point(13, 32);
            this.labelRetractionDistance.Name = "labelRetractionDistance";
            this.labelRetractionDistance.Size = new System.Drawing.Size(101, 13);
            this.labelRetractionDistance.TabIndex = 2;
            this.labelRetractionDistance.Text = "Retraction Distance";
            // 
            // labelRetractionSpeed
            // 
            this.labelRetractionSpeed.AutoSize = true;
            this.labelRetractionSpeed.Location = new System.Drawing.Point(13, 58);
            this.labelRetractionSpeed.Name = "labelRetractionSpeed";
            this.labelRetractionSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelRetractionSpeed.TabIndex = 3;
            this.labelRetractionSpeed.Text = "Retraction Speed";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(131, 55);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 4;
            this.textBoxSpeed.Text = "1600";
            // 
            // checkBoxEnablePark
            // 
            this.checkBoxEnablePark.AutoSize = true;
            this.checkBoxEnablePark.Checked = true;
            this.checkBoxEnablePark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnablePark.Location = new System.Drawing.Point(12, 90);
            this.checkBoxEnablePark.Name = "checkBoxEnablePark";
            this.checkBoxEnablePark.Size = new System.Drawing.Size(101, 17);
            this.checkBoxEnablePark.TabIndex = 5;
            this.checkBoxEnablePark.Text = "Park Print Head";
            this.checkBoxEnablePark.UseVisualStyleBackColor = true;
            this.checkBoxEnablePark.CheckedChanged += new System.EventHandler(this.CheckBoxPark);
            // 
            // labelParkX
            // 
            this.labelParkX.AutoSize = true;
            this.labelParkX.Location = new System.Drawing.Point(13, 110);
            this.labelParkX.Name = "labelParkX";
            this.labelParkX.Size = new System.Drawing.Size(92, 13);
            this.labelParkX.TabIndex = 6;
            this.labelParkX.Text = "Park Print Head X";
            // 
            // textBoxHeadX
            // 
            this.textBoxHeadX.Location = new System.Drawing.Point(131, 107);
            this.textBoxHeadX.Name = "textBoxHeadX";
            this.textBoxHeadX.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeadX.TabIndex = 7;
            this.textBoxHeadX.Text = "30";
            // 
            // labelParkY
            // 
            this.labelParkY.AutoSize = true;
            this.labelParkY.Location = new System.Drawing.Point(13, 136);
            this.labelParkY.Name = "labelParkY";
            this.labelParkY.Size = new System.Drawing.Size(92, 13);
            this.labelParkY.TabIndex = 8;
            this.labelParkY.Text = "Park Print Head Y";
            // 
            // textBoxHeadY
            // 
            this.textBoxHeadY.Location = new System.Drawing.Point(131, 133);
            this.textBoxHeadY.Name = "textBoxHeadY";
            this.textBoxHeadY.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeadY.TabIndex = 9;
            this.textBoxHeadY.Text = "317";
            // 
            // textBoxFeedRate
            // 
            this.textBoxFeedRate.Location = new System.Drawing.Point(131, 159);
            this.textBoxFeedRate.Name = "textBoxFeedRate";
            this.textBoxFeedRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeedRate.TabIndex = 10;
            this.textBoxFeedRate.Text = "6000";
            // 
            // labelFeedRate
            // 
            this.labelFeedRate.AutoSize = true;
            this.labelFeedRate.Location = new System.Drawing.Point(13, 162);
            this.labelFeedRate.Name = "labelFeedRate";
            this.labelFeedRate.Size = new System.Drawing.Size(57, 13);
            this.labelFeedRate.TabIndex = 11;
            this.labelFeedRate.Text = "Feed Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "mm/s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "mm/s";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(182, 272);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 33);
            this.buttonInsert.TabIndex = 17;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.InsertClick);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFile.Location = new System.Drawing.Point(29, 272);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(85, 33);
            this.buttonOpenFile.TabIndex = 18;
            this.buttonOpenFile.Text = "OpenFile";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "FilePath:";
            // 
            // labelfilePath
            // 
            this.labelfilePath.AutoSize = true;
            this.labelfilePath.Location = new System.Drawing.Point(9, 337);
            this.labelfilePath.Name = "labelfilePath";
            this.labelfilePath.Size = new System.Drawing.Size(0, 13);
            this.labelfilePath.TabIndex = 20;
            // 
            // labelTimeDelay
            // 
            this.labelTimeDelay.AutoSize = true;
            this.labelTimeDelay.Location = new System.Drawing.Point(13, 202);
            this.labelTimeDelay.Name = "labelTimeDelay";
            this.labelTimeDelay.Size = new System.Drawing.Size(60, 13);
            this.labelTimeDelay.TabIndex = 22;
            this.labelTimeDelay.Text = "Time Delay";
            // 
            // textBoxTimeDelay
            // 
            this.textBoxTimeDelay.Location = new System.Drawing.Point(131, 199);
            this.textBoxTimeDelay.Name = "textBoxTimeDelay";
            this.textBoxTimeDelay.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeDelay.TabIndex = 23;
            this.textBoxTimeDelay.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ms";
            // 
            // progressBarInsertFile
            // 
            this.progressBarInsertFile.Location = new System.Drawing.Point(12, 311);
            this.progressBarInsertFile.Name = "progressBarInsertFile";
            this.progressBarInsertFile.Size = new System.Drawing.Size(267, 10);
            this.progressBarInsertFile.TabIndex = 25;
            // 
            // textBoxLayer
            // 
            this.textBoxLayer.Location = new System.Drawing.Point(131, 225);
            this.textBoxLayer.Name = "textBoxLayer";
            this.textBoxLayer.Size = new System.Drawing.Size(100, 20);
            this.textBoxLayer.TabIndex = 26;
            this.textBoxLayer.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Layer Per Capture ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "layer";
            // 
            // TimeLapse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLayer);
            this.Controls.Add(this.progressBarInsertFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimeDelay);
            this.Controls.Add(this.labelTimeDelay);
            this.Controls.Add(this.labelfilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFeedRate);
            this.Controls.Add(this.textBoxFeedRate);
            this.Controls.Add(this.textBoxHeadY);
            this.Controls.Add(this.labelParkY);
            this.Controls.Add(this.textBoxHeadX);
            this.Controls.Add(this.labelParkX);
            this.Controls.Add(this.checkBoxEnablePark);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelRetractionSpeed);
            this.Controls.Add(this.labelRetractionDistance);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.checkBoxEnableRetraction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeLapse";
            this.Text = "TimeLapse";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEnableRetraction;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelRetractionDistance;
        private System.Windows.Forms.Label labelRetractionSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxEnablePark;
        private System.Windows.Forms.Label labelParkX;
        private System.Windows.Forms.TextBox textBoxHeadX;
        private System.Windows.Forms.Label labelParkY;
        private System.Windows.Forms.TextBox textBoxHeadY;
        private System.Windows.Forms.TextBox textBoxFeedRate;
        private System.Windows.Forms.Label labelFeedRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelfilePath;
        private System.Windows.Forms.Label labelTimeDelay;
        private System.Windows.Forms.TextBox textBoxTimeDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarInsertFile;
        private System.Windows.Forms.TextBox textBoxLayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

