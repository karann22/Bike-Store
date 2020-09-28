using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBusinessLayer;
using ClassLibraryDataLayer;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using ClassLibraryBusinessLayer.Bus;

namespace WindowsFormsClientLayer
{
    public partial class Form1 : Form
    {
        List<Bikes> myList = new List<Bikes>();
        List<RoadBikes> rdList = new List<RoadBikes>();
        List<MountainBikes> mtList = new List<MountainBikes>();



        int index = -1;
        int positionColor = -1;
        int positionHdLight = -1;
        int positionSuspension = -1;
        private bool buttonRemove1Clicked;
        private bool buttonRemove2Clicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            foreach (EnumColor item in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxClr.Items.Add(item);
            }
            this.comboBoxClr.Text = Convert.ToString(this.comboBoxClr.Items[3]);
            foreach (EnumHeadlight item in Enum.GetValues(typeof(EnumHeadlight)))
            {
                this.comboBoxHdLight.Items.Add(item);
            }
            this.comboBoxHdLight.Text = Convert.ToString(this.comboBoxHdLight.Items[2]);

            foreach (EnumSuspension item in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(item);
            }
            this.comboBoxSuspension.Text = Convert.ToString(this.comboBoxSuspension.Items[3]);

        }

        private void radioButtonRdBikes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRdBikes.Checked == true)
            {
                comboBoxSuspension.Visible = false;
                textBoxHght.Visible = false;
                comboBoxHdLight.Visible = false;
                textBoxNewSpeedMT.Visible = false;
            }
            else
            {
                comboBoxSuspension.Visible = true;
                textBoxHght.Visible = true;
                comboBoxHdLight.Visible = true;
                textBoxNewSpeedMT.Visible = true;
            }

        }
        private void radioButtonMtnBikes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMtnBikes.Checked == true)
            {
                textBoxStHght.Visible = false;
                textBoxWght.Visible = false;
                textBoxNewSpeedRD.Visible = false;
            }
            else
            {
                textBoxStHght.Visible = true;
                textBoxWght.Visible = true;
                textBoxNewSpeedRD.Visible = true;
            }
        }

        private void labelClr_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClr_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionColor = this.comboBoxClr.SelectedIndex;

        }

        private void comboBoxSuspension_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionSuspension = this.comboBoxSuspension.SelectedIndex;
        }

        private void comboBoxHdLight_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionHdLight = this.comboBoxHdLight.SelectedIndex;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Bikes newBike = new Bikes();
            RoadBikes newRoadBikes = new RoadBikes();
            MountainBikes newMountainBikes = new MountainBikes();
            //Validation
            bool correct = false;


            if (Validator.Is12Digit(textBoxSrNum.Text))
                correct = true;
            if (!correct) MessageBox.Show("you must input 12 digit for serial number",
                                                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;


            correct = false;

            if (Validator.IsAlphabetNumber(textBoxMd.Text))
                correct = true;
            if (!correct) MessageBox.Show("you must input character for made",
                                                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;


            correct = false;

            if (Validator.IsEmpty(textBoxSrNum.Text) || Validator.IsEmpty(textBoxMd.Text) || Validator.IsEmpty(textBoxYear.Text)
                || Validator.IsEmpty(textBoxSpd.Text) || Validator.IsEmpty(textBoxPrice.Text))
                correct = true;
            if (!correct) MessageBox.Show("you must not leave empty",
                                                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;



            if (radioButtonRdBikes.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxSrNum.Text)
                    && !String.IsNullOrEmpty(textBoxMd.Text)
                    && !String.IsNullOrEmpty(textBoxSpd.Text)
                    && !String.IsNullOrEmpty(textBoxYear.Text)
                    && !String.IsNullOrEmpty(comboBoxClr.Text))
                {
                    newRoadBikes.SerNum = Convert.ToInt64(this.textBoxSrNum.Text);
                    newRoadBikes.Make = this.textBoxMd.Text;
                    newRoadBikes.Speed = Convert.ToInt32(this.textBoxSpd.Text);
                    newRoadBikes.Color = (EnumColor)positionColor;
                    newRoadBikes.Year = Convert.ToInt32(this.textBoxYear.Text);
                    newRoadBikes.Price = Convert.ToInt32(this.textBoxPrice.Text);

                    newRoadBikes.SeatHeight = Convert.ToInt32(this.textBoxStHght.Text);
                    newRoadBikes.Weight = Convert.ToInt32(this.textBoxWght.Text);

                    rdList.Add(newRoadBikes);
                    listBoxDisplay.Items.Add(newRoadBikes);

                    myList.AddRange(rdList);
                }
            }
            else if (radioButtonMtnBikes.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxSrNum.Text)
                && !String.IsNullOrEmpty(textBoxMd.Text)
                && !String.IsNullOrEmpty(textBoxSpd.Text)
                && !String.IsNullOrEmpty(textBoxYear.Text)
                && !String.IsNullOrEmpty(comboBoxClr.Text))
                {
                    newMountainBikes.SerNum = Convert.ToInt64(this.textBoxSrNum.Text);
                    newMountainBikes.Make = this.textBoxMd.Text;
                    newMountainBikes.Speed = Convert.ToInt32(this.textBoxSpd.Text);
                    newMountainBikes.Color = (EnumColor)positionColor;
                    newMountainBikes.Year = Convert.ToInt32(this.textBoxYear.Text);
                    newMountainBikes.Price = Convert.ToInt32(this.textBoxPrice.Text);

                    newMountainBikes.Height = Convert.ToInt32(this.textBoxHght.Text);
                    newMountainBikes.Suspension = (EnumSuspension)positionSuspension;
                    newMountainBikes.Headlight = (EnumHeadlight)positionHdLight;

                    mtList.Add(newMountainBikes);
                    listBoxDisplay.Items.Add(newMountainBikes);

                    myList.AddRange(mtList);
                }
            }

            else if (String.IsNullOrEmpty(textBoxSrNum.Text)
                    && String.IsNullOrEmpty(textBoxMd.Text)
                    && String.IsNullOrEmpty(textBoxSpd.Text)
                    && String.IsNullOrEmpty(textBoxYear.Text))
            {
                MessageBox.Show("NO DATA...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Select the Bike Type !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void C_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();

            if (myList.Count >= 0)
            {
                foreach (IMovable bkRecord in myList)
                {
                    this.listBoxDisplay.Items.Add(bkRecord);
                }
            }
            else MessageBox.Show("The list is empty!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Bikes bikeFound = null;
            bool found = false;
            foreach (Bikes bk in myList)
            {
                if (bk.SerNum == Convert.ToInt64(textBoxSearch.Text))
                {
                    bikeFound = bk;
                    found = true;
                    textBoxSearch.Text = ""; textBoxSearch.Focus();
                    break;
                }
            }
            if (found)
            {
                MessageBox.Show("Bike found..." + bikeFound);
            }
            else
            {
                MessageBox.Show("Bike not found...");
            }
            textBoxSearch.Text = ""; textBoxSearch.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            index = this.listBoxDisplay.SelectedIndex;

            DialogResult result;
            result = MessageBox.Show("DO YOU WANT TO UPDATE?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (radioButtonRdBikes.Checked == true)
                {
                    long serNum = Convert.ToInt64(this.textBoxSrNum.Text);
                    string make = this.textBoxMd.Text;
                    float price = Convert.ToInt32(textBoxPrice.Text);
                    EnumColor color = (EnumColor)positionColor;
                    double speed = Convert.ToInt32(this.textBoxSpd.Text);
                    int year = Convert.ToInt32(this.textBoxYear.Text);
                    double SeatHeight = Convert.ToInt32(this.textBoxStHght.Text);
                    double Weight = Convert.ToInt32(this.textBoxWght.Text);
                    double newSpeed = Convert.ToInt32(this.textBoxNewSpeedRD.Text);

                    //MessageBox.Show("Radio Bike UPDATED");
                }

                else if (radioButtonMtnBikes.Checked == true)
                {
                    long serNum = Convert.ToInt64(this.textBoxSrNum.Text);
                    string make = this.textBoxMd.Text;
                    float price = Convert.ToInt32(textBoxPrice.Text);
                    EnumColor color = (EnumColor)positionColor;
                    double speed = Convert.ToInt32(this.textBoxSpd.Text);
                    int year = Convert.ToInt32(this.textBoxYear.Text);
                    double Height = Convert.ToInt32(this.textBoxHght.Text);
                    EnumSuspension Suspension = (EnumSuspension)positionSuspension;
                    EnumHeadlight Headlight = (EnumHeadlight)positionHdLight;
                    double newSpeed = Convert.ToInt32(this.textBoxNewSpeedMT.Text);

                    //MessageBox.Show("Mountain Bike UPDATED");

                }
            }
            else MessageBox.Show("The Bike serial number - " + this.myList[index].SerNum + " is not updated");

            FileHandler.WriteToXmlFile(myList);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("\n Are you sure you want to exit the application ?", "EXIT",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("\nThis app is created by: \n\t Karanveer Singh ");

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                index = this.listBoxDisplay.SelectedIndex;


                if (index >= 0)
                {
                    //this.myList.RemoveAt(index);
                    this.rdList.RemoveAt(index);
                    buttonRemove1Clicked = true;
                }
                else if (index >= 0)
                {
                    //this.myList.RemoveAt(index);
                    this.mtList.RemoveAt(index);
                    buttonRemove2Clicked = true;
                }


                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }

                this.listBoxDisplay.Items.Clear();

                this.comboBoxClr.Text = Convert.ToString(this.comboBoxClr.Items[2]) ;
                this.comboBoxHdLight.Text = Convert.ToString(this.comboBoxHdLight.Items[2]);
                this.comboBoxSuspension.Text = Convert.ToString(this.comboBoxSuspension.Items[3]);

                this.textBoxSrNum.Focus();
                MessageBox.Show("The selected record is deleted!");
            }
            else
            {
                MessageBox.Show("The selected record " + this.myList[index].SerNum + " is not deleted");
            }

            FileHandler.WriteToXmlFile(myList);
        }

        private void buttonRdBikes_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();

            if (rdList.Count >= 0 && buttonRemove1Clicked == false)
            {
                foreach (RoadBikes rdRecord in rdList)
                {
                    this.listBoxDisplay.Items.Add(rdRecord);
                }
            }
            else if (rdList.Count >= 0)
            {
                foreach (RoadBikes rdRecord in rdList)
                {
                    this.listBoxDisplay.Items.Add(rdRecord);
                }
            }
            else MessageBox.Show("The list is empty!");
        }

        private void buttonMtBikes_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();

            if (mtList.Count >= 0 && buttonRemove2Clicked == false)
            {
                foreach (MountainBikes mtRecord in mtList)
                {
                    this.listBoxDisplay.Items.Add(mtRecord);
                }
            }
            else if (mtList.Count >= 0)
            {
                foreach (MountainBikes mtRecord in mtList)
                {
                    this.listBoxDisplay.Items.Add(mtRecord);
                }
            }
            else MessageBox.Show("The list is empty!");
        }

        private void labelSrNum_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileHandler.WriteToXmlFile(myList);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();

            if (File.Exists(FileHandler.xmlFilePath))
            {
                List<Bikes> listOfBikes = new List<Bikes>();

                listOfBikes = FileHandler.ReadFromXmlFile();

                myList = listOfBikes;

                if (myList.Count > 0)
                {
                    foreach (Bikes bk in myList)
                    {
                        this.listBoxDisplay.Items.Add(bk);
                    }
                }

                //Display(listFromFile);

                MessageBox.Show("Content loaded");
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBoxDisplay.SelectedIndex;



            if (radioButtonRdBikes.Checked == true)
            {
                this.textBoxSrNum.Text = Convert.ToString(this.myList[index].SerNum);
                this.textBoxMd.Text = this.rdList[index].Make;
                this.comboBoxClr.Text = Convert.ToString(this.rdList[index].Color);
                this.textBoxSpd.Text = Convert.ToString(this.rdList[index].Speed);
                this.textBoxPrice.Text = Convert.ToString(this.rdList[index].Price);
                this.textBoxYear.Text = Convert.ToString(this.rdList[index].Year);

                this.textBoxStHght.Text = Convert.ToString(this.rdList[index].SeatHeight);
                this.textBoxWght.Text = Convert.ToString(this.rdList[index].Weight);
                this.textBoxNewSpeedRD.Text = Convert.ToString(this.rdList[index].NewSpeed);

            }

            else if (radioButtonMtnBikes.Checked == true)
            {
            this.textBoxSrNum.Text = Convert.ToString(this.mtList[index].SerNum);
            this.textBoxMd.Text = this.mtList [index].Make;
            this.comboBoxClr.Text = Convert.ToString(this.mtList[index].Color);
            this.textBoxSpd.Text = Convert.ToString(this.mtList[index].Speed);
            this.textBoxPrice.Text = Convert.ToString(this.mtList[index].Price);
            this.textBoxYear.Text = Convert.ToString(this.mtList[index].Year);

            this.textBoxHght.Text = Convert.ToString(this.mtList[index].Height);
            this.comboBoxSuspension.Text = Convert.ToString(this.mtList[index].Suspension);
            this.comboBoxHdLight.Text = Convert.ToString(this.mtList[index].Headlight);
            this.textBoxNewSpeedMT.Text = Convert.ToString(this.mtList[index].NewSpeed);
        }
    }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonUpdate.Visible = true;
            foreach (Control control in Controls)
            {
                this.textBoxHght.Text = "";
                this.textBoxStHght.Text = "";

                if (control is TextBox)
                {
                    control.Text = "";

                    this.comboBoxSuspension.Text = Convert.ToString(this.comboBoxSuspension.Items[0]);
                    this.comboBoxClr.Text = Convert.ToString(this.comboBoxClr.Items[0]);
                    this.radioButtonMtnBikes.Checked = this.radioButtonRdBikes.Checked = false;
                }
            }

            this.listBoxDisplay.Items.Clear();
            this.textBoxSearch.Focus();
        }
    }
}
