using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProj
{
    public partial class Form1 : Form
    {

        UserData currentUserData;

        UserData[] userDatasTest = { new UserData(1, "111","Vova", "Mail_1", "111", 1),
                                     new UserData(2, "Vanya","Vanya", "Mail_2", "222", 2),
                                     new UserData(3, "Pasha", "Pasha", "Mail_3", "333", 3),
                                     new UserData(4, "Leha", "Leha", "Mail_4", "444", 4),};

        public Form1()
        {
            InitializeComponent();
            currentUserData = new UserData(-1, null, null, null, null, -1);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string name = LoginBox.Text;
            string password = PaswBox.Text;

            for (int i = 0; i < userDatasTest.Length; i++)
            {
                if (userDatasTest[i].Name.ToLower() == name.ToLower())
                    if (userDatasTest[i].Password == password)
                    {
                        MessageBox.Show("Access is allowed!");
                        currentUserData = userDatasTest[i];
                    }
                    else
                    {
                        MessageBox.Show("Invalid password!");
                    }


            }
        }
    }
}
