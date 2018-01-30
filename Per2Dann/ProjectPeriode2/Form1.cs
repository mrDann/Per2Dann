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
    public partial class Form1 : Form
    {
        private bool toggle = true;
        public Form1()
        {
            InitializeComponent();
            button2.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;
            button10.BackColor = Color.Green;
            button11.BackColor = Color.Green;
            button12.BackColor = Color.Green;
            button13.BackColor = Color.Green;
            button14.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Maak en start een timer (klok)
            Timer t = new Timer();
            t.Interval = 1000; //Update iedere seconde (1000 milliseconden)
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();

            try
            {
                /*Voer een SQL query uit... LET OP: (ms, 0) is benodigd! Dit voegt geen tijd toe, maar is wel een vereiste van SQL!
                Het wordt super ingewikkeld als we een drievoudige INNER JOIN moeten doen en daarvan de TOP 10 moeten selecteren. Daarom nu dit. */
                string query = "SELECT TOP 12 Klanten.Voornaam, Klanten.Achternaam, Reserveringen.MenuID, Reserveringen.AantalPersonen, Reserveringen.AantalTafels, Reserveringen.Tijd FROM Klanten JOIN Reserveringen ON Klanten.KlantID=Reserveringen.KlantID WHERE Tijd > DATEADD(ms, 0, GETDATE()) ORDER BY Tijd ASC";
                //Benodigd om onze database in het programma te krijgen.
                var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                //Haalt de data uit de database en laat hem zien in de view.
                resViewNext.ReadOnly = true;
                resViewNext.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                connectionManager.closeConnection();
                MessageBox.Show("Fout bij het uitlezen van database: " + ex.ToString());
            }



        }
        private void button3_Click(object sender, EventArgs e)
        {
            menuPage HomeKnopMenu = new menuPage();
            HomeKnopMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            klantOverzicht klantenKnop = new klantOverzicht();
            klantenKnop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addReservering addKnop = new addReservering();
            addKnop.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletePage delKnop = new deletePage();
            delKnop.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTijd.Text = DateTime.Now.ToString("HH:mm");
        }

        private void labelTijd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button2.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button2.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button5.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button5.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button6.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button6.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button7.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button7.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button8.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button8.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button9.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button9.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button10.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button10.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button11.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button11.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button12.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button12.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button13.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button13.BackColor = Color.Green;

                toggle = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                button14.BackColor = Color.Red;

                toggle = false;
            }
            else
            {
                button14.BackColor = Color.Green;

                toggle = true;
            }
        }
    }
}
