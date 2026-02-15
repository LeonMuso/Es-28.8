namespace _28._8.Library;

public class GestionaleNoleggi
{
    public List<Veicolo> Veicoli { get; set; } = new();
    public List<Noleggio> Noleggi { get; set; } = new();
    public List<Cliente> Clienti { get; set; } = new();

    public List<Noleggio> VisualizzaNoleggiConTargaOCodiceFiscale(string s)
    {
        List<Noleggio> risultato = new();
        foreach (var noleggio in Noleggi)
        {
            if (noleggio.Veicolo.Targa == s || noleggio.Cliente.CodiceFiscale == s)
            {
                risultato.Add(noleggio);
            }
        }
        return risultato;
    }

    public Noleggio VisualizzaDettagliNoleggioConID(int id)
    {
        foreach (Noleggio noleggio in Noleggi)
        {
            if (noleggio.ID == id)
            {
                return noleggio;
            }
        }
        return null;
    }

    public bool VerificaDisponibilitaVeicolo(string targa, DateTime dataInizio, int numeroGiorni)
    {
        foreach (Noleggio noleggio in Noleggi)
        {
            if (noleggio.Veicolo.Targa == targa)
            {
                DateTime dataFineNoleggio = noleggio.DataInizio.AddDays(noleggio.NumeroGiorni);
                DateTime dataFineRichiesta = dataInizio.AddDays(numeroGiorni);
                if (dataInizio < dataFineNoleggio && dataFineRichiesta > noleggio.DataInizio)
                {
                    return false; // Veicolo non disponibile
                }
            }
        }
        return true; // Veicolo disponibile
    }

    public void AggiungiNoleggio(Noleggio noleggio)
    {
        noleggio.Costo = noleggio.NumeroGiorni * noleggio.Veicolo.TargiifaGiornaliera;
        Noleggi.Add(noleggio);
    }

    public float PrezzoTotaleNoleggio(string targa)
    {
        float totale = 0;
        foreach (Noleggio noleggio in Noleggi)
        {
            if (noleggio.Veicolo.Targa == targa)
            {
                totale += noleggio.Costo;
            }
        }
        return totale;
    }

    public float PrezzoTotaleNoleggioPerCliente(string codiceFiscale)
    {
        float totale = 0;
        foreach (Noleggio noleggio in Noleggi)
        {
            if (noleggio.Cliente != null && noleggio.Cliente.CodiceFiscale.Contains(codiceFiscale))
            {
                totale += noleggio.Costo;
            }
        }
        return totale;
    }

    public float PrezzoTotaleRicavatoDaiNoleggi()
    {
        float totale = 0;
        foreach (Noleggio noleggio in Noleggi)
        {
            if (noleggio is Auto)
            {
                totale += noleggio.Costo;
            }
        }
        return totale;
    }
}