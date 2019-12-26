using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class PersonalUi : Form
    {
        public PersonalUi()
        {
            InitializeComponent();
        }

        private PersonalInfo PersonalInfo;
        PersonalInfo PersonalInfo1 = new PersonalInfo();

        private void saveButton_Click(object sender, EventArgs e)
        {
            //PersonalInfo.FirstName = firstNameTextBox.Text;
            //PersonalInfo.MiddleName = middleNameTextBox.Text;
            //PersonalInfo.LastName = lastNameTextBox.Text;

            PersonalInfo = new PersonalInfo(firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text);

            List<PersonalInfo> personalInfos = new List<PersonalInfo> ();

            personalInfos.Add(PersonalInfo);

            //PersonalInfo1 = new PersonalInfo();

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //firstNameTextBox.Text = PersonalInfo.FirstName;
            //middleNameTextBox.Text = PersonalInfo.MiddleName;
            //lastNameTextBox.Text = PersonalInfo.LastName;

            fullNameTextBox.Text = PersonalInfo.GetFullName();
            reverseNameTextBox.Text = PersonalInfo.GetReverseName();
        }
    }
}
