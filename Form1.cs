namespace Kisi_Kayit_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Birthdate = DateOnly.FromDateTime(dtpBirthdate.Value),
                Age = (int)nudAge.Value,
                Gender = rdbMale.Checked
            };

            lstPersons.Items.Add(person);

            txtName.Clear();
            txtSurname.Clear();
            nudAge.Value = 0;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstPersons.Items.RemoveAt(lstPersons.SelectedIndex);
        }
    }
}