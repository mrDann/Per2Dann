using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPeriode2
{
    public partial class AddReserveringNew : Form
    {
        public AddReserveringNew()
        {
            InitializeComponent();
        }

        public addReservering ar = new addReservering();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Voer een SQL query uit...
                string query = "INSERT INTO Reserveringen(KlantID, MenuID, AantalPersonen, AantalTafels, Tijd)values('" + inputKlantID.Text + "','" + inputMenuID.Text + "','" + inputAantalPersonen.Text + "','" + inputAantalTafels.Text + "','" + inputTijd.Text + "');";
                //Benodigd om onze database in het programma te krijgen.
                var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                DialogResult dr;
                dr = MessageBox.Show("Reservering aanmaken voltooid!", "Reservering aanmaken", MessageBoxButtons.OK);

                if (dr == DialogResult.OK)
                {
                    ar.Refresh();
                    this.Close(); //Sluit de klant addKlant venster.
                }

            }
            catch (Exception ex)
            {
                connectionManager.closeConnection();
                MessageBox.Show("Fout bij het aanmaken van klant: " + ex.ToString());
            }
        }
    }
}
