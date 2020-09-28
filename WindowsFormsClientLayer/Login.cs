using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsClientLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public class User
        {
            private int id;
            private string name;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
        }

        public static String txtFilePath = @"../../data/details.txt";
        public static List<User> ReadFromTextFile()

        {

            try
            {
                List<User> list = new List<User>();
                StreamReader sr = new StreamReader(txtFilePath);

                String line = null;

                while ((line = sr.ReadLine()) != null)
                {
                    User aUser = new User();

                    String[] fields = line.Split('|');

                    aUser.Id = Convert.ToInt32(fields[0]);
                    aUser.Name = fields[1];


                    list.Add(aUser);

                }

                sr.Close();
                return list;

            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> userList = new List<User>();
            userList = ReadFromTextFile();

            foreach (User A in userList)
            {
                if (A.Id == Convert.ToInt32(textBoxPassword.Text) && A.Name == textBoxUserName.Text)
                {
                    Form1 fs = new Form1();
                    fs.Show();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
