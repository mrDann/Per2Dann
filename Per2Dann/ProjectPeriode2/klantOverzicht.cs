using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPeriode2
{
    public partial class klantOverzicht : Form
    {
        public klantOverzicht()
        {
            InitializeComponent();
        }

        private void klantOverzicht_Load(object sender, EventArgs e)
        {

            //Voer een SQL query uit...
            string query = "SELECT TOP 12 Klanten.Voornaam, Klanten.Achternaam, Reserveringen.MenuID, Reserveringen.AantalPersonen, Reserveringen.AantalTafels, Reserveringen.Tijd FROM Klanten JOIN Reserveringen ON Klanten.KlantID=Reserveringen.KlantID WHERE Tijd > DATEADD(ms, 0, GETDATE()) ORDER BY Tijd ASC";
            //Benodigd om onze database in het programma te krijgen.
            var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            //Haalt de data uit de database en laat hem zien in de view.
            klantenView.ReadOnly = true;
            klantenView.DataSource = dataSet.Tables[0];
        }
          
        
        private void klantOverzicht_Closed(object sender, FormClosedEventArgs e)
        {
            //Iedere keer als je het scherm sluit, wordt de database verbinding gesloten.
            connectionManager.closeConnection();
        }

        private void addKlantButtonOverzicht_Click(object sender, EventArgs e)
        {
            addKlantPage addKlantKnop = new addKlantPage();
            addKlantKnop.Show();
        }

        private void delKlantButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klant verwijdere voltooid!", "Klant verwijderen", MessageBoxButtons.OK);

            /*
            if (klantenView.SelectedRows.Count == 0)
            {
                //Doe niks als er geen rijen geselecteerd zijn
                return;
            }

            var itemVerwijderen = (DataRowView)klantenView.SelectedRows[0].DataBoundItem;


            try
            {
                
                //Voer een SQL query uit...
                string query = "DELETE FROM Klanten WHERE KlantID=" + klantenView.SelectedRows[0].Cells[0].Value.ToString() + "";

                //Benodigd om onze database in het programma te krijgen.
                var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                

                DialogResult dr;
                dr = MessageBox.Show("Weet u zeker dat u deze klant wilt verwijderen?", "Klant verwijderen", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    klantenView.Refresh();
                    Close(); //Sluit de klant addKlant venster.
                }
                else if (dr == DialogResult.No)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                connectionManager.closeConnection();
                MessageBox.Show("Fout bij het aanmaken van klant: " + ex.ToString());
            }
            */
        }
    }
}
