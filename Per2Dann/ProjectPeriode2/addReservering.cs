using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPeriode2
{
    public partial class addReservering : Form
    {
        public addReservering()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReserveringNew ReserveringExtra = new AddReserveringNew();
            ReserveringExtra.Show();
        }

        private void addReservering_Load(object sender, EventArgs e)
        {
            //Voer een SQL query uit...
            string query = "SELECT TOP 12 Klanten.Voornaam, Klanten.Achternaam, Reserveringen.MenuID, Reserveringen.AantalPersonen, Reserveringen.AantalTafels, Reserveringen.Tijd FROM Klanten JOIN Reserveringen ON Klanten.KlantID=Reserveringen.KlantID WHERE Tijd > DATEADD(ms, 0, GETDATE()) ORDER BY Tijd ASC";
            //Benodigd om onze database in het programma te krijgen.
            var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            
            //Haalt de data uit de database en laat hem zien in de view.
            reserveringView.ReadOnly = true;
            reserveringView.DataSource =  dataSet.Tables[0];
        }

        private void addReservering_Closed(object sender, FormClosedEventArgs e)
        {
            //Iedere keer als je het scherm sluit, wordt de database verbinding gesloten.
            connectionManager.closeConnection();
        }

        private void reserveringView_CellContentClick(object sender, EventArgs e)
        {
            //Niet verwijderen
        }

    }
}
