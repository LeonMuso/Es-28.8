using _28._8.Library;

namespace _28._8.Winform
{
    public partial class Form1 : Form
    {
        private GestionaleNoleggi gestionale;
        public Form1()
        {
            InitializeComponent();
            gestionale = new GestionaleNoleggi()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            cmbTipoVeicolo.Items.Add("Auto");
            cmbTipoVeicolo.Items.Add("Furgone");
            cmbTipoVeicolo.SelectedIndex = 0;
            

        }

        private void btnAggiungiVeicolo_Click(object sender, EventArgs e)
        {
            if (txtTarga.Text == "" || txtModello.Text == "")
            {
                MessageBox.Show("Inserisci tutti i dettagli");
            }
            else
            {
                if (cmbTipoVeicolo.SelectedItem.ToString() == "Auto")
                {
                    Auto a = new Auto();
                    a.Targa = txtTarga.Text;
                    a.Modello = txtModello.Text;
                    float prezzo;
                    while (!float.TryParse(txtTariffa.Text, out prezzo) || prezzo <= 0)
                    {
                        MessageBox.Show("Inserisci un numero valido di tariffa giornaliera");
                        return;
                    }
                    a.TariffaGiornaliera = prezzo;
                    int posti;
                    while (!int.TryParse(txtPostiCarico.Text, out posti) || posti <= 0)
                    {
                        MessageBox.Show("Inserisci un numero valido di posti");
                        return;
                    }
                    a.Posti = posti;
                    gestionale.Veicoli.Add(a);
                }
                else
                {

                    Furgone f = new Furgone();
                    f.Targa = txtTarga.Text;
                    f.Modello = txtModello.Text;
                    float prezzo;
                    while (!float.TryParse(txtTariffa.Text, out prezzo) || prezzo <= 0)
                    {
                        MessageBox.Show("Inserisci un numero valido di tariffa giornaliera");
                        return;
                    }
                    f.TariffaGiornaliera = prezzo;
                    float carico;
                    while (!float.TryParse(txtPostiCarico.Text, out carico) || carico <= 0)
                    {
                        MessageBox.Show("Inserisci un numero valido di carico in kg");
                        return;
                    }
                    f.CaricoInKg = carico;
                    gestionale.Veicoli.Add(f);
                }

                AggiornaComboVeicoli();
                MessageBox.Show("Veicolo aggiunto");
                txtModello.Clear();
                txtTariffa.Clear();
                txtPostiCarico.Clear();
                txtTarga.Clear();
                txtTarga.Focus();
            }

        }

        private void btnAggiungiCliente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCognome.Text == "" || txtCF.Text == "")
            {
                MessageBox.Show("Inserisci i dettagli del cliente");
                return;
            }
            Cliente c = new Cliente();
            c.Nome = txtNome.Text;
            c.Cognome = txtCognome.Text;
            c.CodiceFiscale = txtCF.Text;
            gestionale.Clienti.Add(c);

            AggiornaComboClienti();
            MessageBox.Show("Cliente aggiunto");
            txtNome.Clear();
            txtCognome.Clear();
            txtCF.Clear();
            txtNome.Focus();
        }

        private void btnAggiungiNoleggio_Click(object sender, EventArgs e)
        {
            if (cmbClienti.SelectedItem == null || cmbClienti.SelectedItem == null)
            {
                MessageBox.Show("Seleziona un veicolo ed un cliente");
                return;
            }
            Veicolo v = (Veicolo)cmbVeicoli.SelectedItem;
            Cliente c = (Cliente)cmbClienti.SelectedItem;

            bool disponibile = gestionale.VerificaDisponibilitaVeicolo(
                v.Targa,
                dtData.Value,
                (int)numGiorni.Value
            );

            if (!disponibile)
            {
                MessageBox.Show("Veicolo non disponibile");
                return;
            }

            Noleggio n = new Noleggio();
            n.ID = gestionale.Noleggi.Count + 1;
            n.Veicolo = v;
            n.Cliente = c;
            n.DataInizio = dtData.Value;
            n.NumeroGiorni = (int)numGiorni.Value;

            gestionale.AggiungiNoleggio(n);
            AggiornaLista();
        }

        private void btnTotCliente_Click(object sender, EventArgs e)
        {
            if (cmbClienti.SelectedItem == null)
            {
                MessageBox.Show("Seleziona un cliente");
                return;
            }

            Cliente c = (Cliente)cmbClienti.SelectedItem;
            float totale = gestionale.PrezzoTotaleNoleggioPerCliente(c.CodiceFiscale);

            MessageBox.Show("Totale noleggi cliente:\n" + totale + " €");
        }

        private void btnRicavoTotale_Click(object sender, EventArgs e)
        {
            float totale = gestionale.PrezzoTotaleRicavatoDaiNoleggi();
            MessageBox.Show("Ricavo totale:\n" + totale + " €");
        }

        private void AggiornaLista()
        {
            lstNoleggi.Items.Clear();
            foreach (Noleggio n in gestionale.Noleggi)
                lstNoleggi.Items.Add(n.ToString());
        }

        private void AggiornaComboVeicoli()
        {
            cmbVeicoli.Items.Clear();
            foreach (Veicolo v in gestionale.Veicoli)
                cmbVeicoli.Items.Add(v);
        }

        private void AggiornaComboClienti()
        {
            cmbClienti.Items.Clear();
            foreach (Cliente c in gestionale.Clienti)
                cmbClienti.Items.Add(c);
        }

        private void cmbTipoVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVeicolo.SelectedItem == "Auto")
            {
                lblPostiCarico.Text = "Posti";
            }
            else
            {
                lblPostiCarico.Text = "Carico";
            }
        }
    }
}

