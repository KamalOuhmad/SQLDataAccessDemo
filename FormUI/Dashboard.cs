using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
          
        }

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(nameText.Text);

            UpdateBinding();
        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InserPerson(authorIdBox.Text, nameBox.Text);

            authorIdBox.Text = "";
            nameBox.Text = "";
        }
    }
}
