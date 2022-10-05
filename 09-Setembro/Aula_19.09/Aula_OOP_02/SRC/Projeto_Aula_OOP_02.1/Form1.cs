using Libary_class_Aula_OOP_02;

namespace Projeto_Aula_OOP_02._1
{
    public partial class Form1 : Form
    {
        public Contact Client { get; set; }
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new Contact();
            
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            Client.Full_Name = textBox_Name.Text;
        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {
            Client.Phone_number = textBox_Phone.Text;
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            Client.Email = textBox_email.Text;
        }

        private void textBox_postcode_TextChanged(object sender, EventArgs e)
        {
            Client.PostalCode = textBox_postcode.Text;
        }

        private void textBox_adress_TextChanged(object sender, EventArgs e)
        {
            Client.Address = textBox_adress.Text;
        }

        private void textBox_district_TextChanged(object sender, EventArgs e)
        {
            Client.district = textBox_district.Text;
        }

        private void textBox_City_TextChanged(object sender, EventArgs e)
        {
            Client.City = textBox_City.Text;  
        }

        private void textBox_state_TextChanged(object sender, EventArgs e)
        {
            Client.state = textBox_state.Text;
        }

        private void textBox_Country_TextChanged(object sender, EventArgs e)
        {
            Client.Coutry = textBox_Country.Text;
        }

        private void textBox_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            textBox_text.Text = Client.Full_Name;
            textBox_text.Text = Client.Phone_number;
        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {

        }
    }
}