using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeLapseGcode
{
    public partial class TimeLapse : Form
    {
        OpenFileDialog OpenFile = new OpenFileDialog();

        string FileGcode = "";
        string FilePath = "";
        string[] Lines;

        string RetractionDistance = "";
        float RetractionDistanceFloat;
        string RetractionSpeed = "";

        string HeadX = "";
        string HeadY = "";
        string FeedRate = "";

        string TimeDelay = "";

        int LayerPerCapture;

        public TimeLapse()
        {
            InitializeComponent();
        }

        private void ReadGcodeFile()
        {
            FileGcode = File.ReadAllText(FilePath);
            Lines = FileGcode.Split('\n');
            if (FilePath == "")
            {
                MessageBox.Show("Choose File!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Open Done!", "Thông báo");
            }
        }

        private void InsertGcodeFile()
        {
            float ExtruderDisTance = 0;
            int LastIndex = 0;

            Invoke(new Action(() =>
            {
                progressBarInsertFile.Maximum = Lines.Length;
            }));

            for (int i = 0; i < Lines.Length; i++)
            {
                Lines[i] = Lines[i].Replace("\r", "");

                if (Lines[i].Contains(";LAYER:") == true)
                {
                    int LayerNumber = int.Parse(Lines[i].Substring(Lines[i].IndexOf(":") + 1));

                    if (LayerNumber == 0)
                    {
                        continue;
                    }

                    if (LayerNumber != (LastIndex + LayerPerCapture))
                    {
                        continue;
                    }

                    LastIndex = LayerNumber;

                    for (int j = i - 1; j > i - 10; j--)
                    {
                        if (Lines[j].Contains("G1") == true && Lines[j].Contains("E") == true)
                        {
                            string snumber = Lines[j].Substring(Lines[j].IndexOf("E") + 1);
                            string[] snumberfloat = snumber.Split('.');

                            float numfloat = float.Parse(snumberfloat[0]);
                            float numfloat1 = 0;
                            if (snumberfloat.Length > 1)
                            {
                                numfloat1 = float.Parse(snumberfloat[1]);
                            }                          

                            while (numfloat1 > 1)
                            {
                                numfloat1 = numfloat1 / 10;
                            }

                            ExtruderDisTance = numfloat + numfloat1;
                            break;
                        }
                    }

                    float extruderDistance = ExtruderDisTance - RetractionDistanceFloat;
                    string sextruderDistance = extruderDistance.ToString();
                    sextruderDistance = sextruderDistance.Replace(",", ".");

                    string gcodebuffer = "G1" + " " + "F" + RetractionSpeed + " " + "E" + sextruderDistance + "\n";
                    gcodebuffer = gcodebuffer + "G1" + " " + "F" + FeedRate + " " + "X" + HeadX + " " + "Y" + HeadY + " " + "\n";
                    gcodebuffer = gcodebuffer + "M400" + "\n";
                    gcodebuffer = gcodebuffer + "M240" + "\n";
                    gcodebuffer = gcodebuffer + "G4" + " " + "P" + TimeDelay + "\n";

                    Lines[i] = gcodebuffer + Lines[i];

                    for (int j = i + 1; j < i + 5; j++)
                    {
                        if (Lines[j].Contains("G0") == true)
                        {
                            sextruderDistance = ExtruderDisTance.ToString();
                            sextruderDistance = sextruderDistance.Replace(",", ".");

                            Lines[j] = Lines[j] + "\n" + "G1" + " " + "F" + RetractionSpeed + " " + "E" + sextruderDistance;
                            break;
                        }
                    }                 
                }
                Invoke(new Action(() =>
                {
                    progressBarInsertFile.Value = i;
                }));
            }

            File.WriteAllLines(FilePath ,Lines);
            Invoke(new Action(() =>
            {
                buttonOpenFile.Enabled = true;
            }));
            
            MessageBox.Show("Save Done!", "Thông báo");
        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            progressBarInsertFile.Value = 0;
            labelfilePath.Text = " ";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                FilePath = OpenFile.FileName;               
                labelfilePath.Text = FilePath;                
            }
            
            Thread threadOpen = new Thread(ReadGcodeFile);
            threadOpen.Start();
        }

        private void CheckBoxEnableChanged(object sender, EventArgs e)
        {
            if(checkBoxEnableRetraction.Checked == true)
            {
                textBoxDistance.Enabled = true;
                textBoxSpeed.Enabled = true;
                labelRetractionDistance.Enabled = true;
                labelRetractionSpeed.Enabled = true;
            } else
            {
                textBoxDistance.Enabled = false;
                textBoxSpeed.Enabled = false;
                labelRetractionDistance.Enabled = false;
                labelRetractionSpeed.Enabled = false;
            }
        }

        private void CheckBoxPark(object sender, EventArgs e)
        {
            if (checkBoxEnablePark.Checked == true)
            {
                textBoxHeadX.Enabled = true;
                textBoxHeadY.Enabled = true;
                textBoxFeedRate.Enabled = true;
                labelParkX.Enabled = true;
                labelParkY.Enabled = true;
                labelFeedRate.Enabled = true;
            }
            else
            {
                textBoxHeadX.Enabled = false;
                textBoxHeadY.Enabled = false;
                textBoxFeedRate.Enabled = false;
                labelParkX.Enabled = false;
                labelParkY.Enabled = false;
                labelFeedRate.Enabled = false;
            }
        }

        private void UpdateData()
        {
            RetractionDistance = textBoxDistance.Text;

            string[] snumberfloat = RetractionDistance.Split('.');

            float numfloat = float.Parse(snumberfloat[0]);
            float numfloat1 = float.Parse(snumberfloat[1]);

            while (numfloat1 > 1)
            {
                numfloat1 = numfloat1 / 10;
            }

            RetractionDistanceFloat = numfloat + numfloat1;


            RetractionSpeed = textBoxSpeed.Text;

            HeadX = textBoxHeadX.Text;
            HeadY = textBoxHeadY.Text;
            FeedRate = textBoxFeedRate.Text;

            TimeDelay = textBoxTimeDelay.Text;

            LayerPerCapture = int.Parse(textBoxLayer.Text);
        }

        private void InsertClick(object sender, EventArgs e)
        {
            UpdateData();
            buttonOpenFile.Enabled = false;
            Thread threadInsert = new Thread(InsertGcodeFile);
            threadInsert.Start();          
        }

        private void FormLoad(object sender, EventArgs e)
        {
            OpenFile.Filter = "gcode files (*.gcode)|*.gcode|All files (*.*)|*.*";
        }
    }
}
