namespace LTUinl3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Sätter TextBox till Multiline och aktiverar scroll om det behövs
            txtResultat.Multiline = true;
            txtResultat.ScrollBars = ScrollBars.Vertical; // Lägg till rullningslistor om texten blir för lång
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registreraPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kod för att visa inmatningsformuläret (vilket redan är synligt på Form1)
            MessageBox.Show("Vänligen fyll i personuppgifterna och tryck OK.");
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Skapa en ny person baserat på inmatade data
            Person person = new Person
            {
                Förnamn = txtFörnamn.Text,
                Efternamn = txtEfternamn.Text,
                Personnummer = txtPersonnummer.Text
            };

            // Kontrollera personnumret
            if (person.KontrolleraPersonnummer())
            {
                // Gör texten svart som i exemplet
                txtResultat.ForeColor = Color.Black;

                // Formatera resultatet på flera rader med Environment.NewLine för säker radbrytning
                txtResultat.Text = $"Förnamn: {person.Förnamn}{Environment.NewLine}" +
                                   $"Efternamn: {person.Efternamn}{Environment.NewLine}" +
                                   $"Personnr: {person.Personnummer}{Environment.NewLine}" +
                                   $"{person.BestämKön()}";
            }
            else
            {
                // Gör texten röd för felmeddelanden
                txtResultat.ForeColor = Color.Red;
                txtResultat.Text = $"Personnummer felaktigt, försök igen!{Environment.NewLine}";
            }
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFörnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
