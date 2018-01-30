using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPeriode2
{
    public partial class addKlantPage : Form
    {
        public addKlantPage()
        {
            InitializeComponent();
        }

        //Verwijzing naar klantOverzicht aanmaken.
        public klantOverzicht klantOverzicht = new klantOverzicht();

        private void addKlantButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Voer een SQL query uit...
                string query = "INSERT INTO Klanten(Voornaam,Achternaam,Addres,Stad,Email,TelNr)values('" + inputVoornaam.Text + "','" + inputAchternaam.Text + "','" + inputAdres.Text + "','" + inputPlaats.Text + "','" + inputEmail.Text + "','" + inputTel.Text + "');";
                //Benodigd om onze database in het programma te krijgen.
                var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                DialogResult dr;
                dr = MessageBox.Show("Klant aanmaken voltooid!", "Klant aanmaken", MessageBoxButtons.OK);

                if(dr == DialogResult.OK)
                {
                    klantOverzicht.Refresh();
                    this.Close(); //Sluit de klant addKlant venster.
                }

            }
            catch (Exception ex)
            {
                connectionManager.closeConnection();
                MessageBox.Show("Fout bij het aanmaken van klant: " + ex.ToString());
            }
            
        }

        private void cancelAddKlantButton_Click(object sender, EventArgs e)
        {
            //Sluit dit form.
            this.Close();
        }

        private void inputVoornaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputAchternaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPlaats_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
