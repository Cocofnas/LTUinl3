namespace LTUinl3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // S�tter TextBox till Multiline och aktiverar scroll om det beh�vs
            txtResultat.Multiline = true;
            txtResultat.ScrollBars = ScrollBars.Vertical; // L�gg till rullningslistor om texten blir f�r l�ng
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registreraPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kod f�r att visa inmatningsformul�ret (vilket redan �r synligt p� Form1)
            MessageBox.Show("V�nligen fyll i personuppgifterna och tryck OK.");
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Skapa en ny person baserat p� inmatade data
            Person person = new Person
            {
                F�rnamn = txtF�rnamn.Text,
                Efternamn = txtEfternamn.Text,
                Personnummer = txtPersonnummer.Text
            };

            // Kontrollera personnumret
            if (person.KontrolleraPersonnummer())
            {
                // G�r texten svart som i exemplet
                txtResultat.ForeColor = Color.Black;

                // Formatera resultatet p� flera rader med Environment.NewLine f�r s�ker radbrytning
                txtResultat.Text = $"F�rnamn: {person.F�rnamn}{Environment.NewLine}" +
                                   $"Efternamn: {person.Efternamn}{Environment.NewLine}" +
                                   $"Personnr: {person.Personnummer}{Environment.NewLine}" +
                                   $"{person.Best�mK�n()}";
            }
            else
            {
                // G�r texten r�d f�r felmeddelanden
                txtResultat.ForeColor = Color.Red;
                txtResultat.Text = $"Personnummer felaktigt, f�rs�k igen!{Environment.NewLine}";
            }
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtF�rnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
