using _28._8.Library;

namespace Es_28._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionaleNoleggi gestionaleNoleggi = new GestionaleNoleggi()
            {
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>(),
                Veicoli = new List<Veicolo>()
            };

            bool continua = true;

            while (continua)
            {
                Console.WriteLine("inserisci:\n" +
                    "1) per aggiungere un veicolo\n" +
                    "2) per aggiungere un cliente\n" +
                    "3) per aggiungere un noleggio\n" +
                    "4) per visualizzare noleggi\n" +
                    "5) per visualizzare noleggio per ID\n" +
                    "6) per verificare disponibilità\n" +
                    "7) totale per cliente\n" +
                    "8) ricavo totale\n" +
                    "0) esci");

                int scelta;
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 8)
                {
                    Console.WriteLine("errore");
                }

                switch (scelta)
                {
                    case 0:
                        continua = false;
                        break;

                    case 1:
                        Console.WriteLine("inserisci 1 per aggiungere un auto, o 2 per un furgone:");
                        int scelta2 = 0;
                        while (!int.TryParse(Console.ReadLine(), out scelta2) || scelta2 < 1 || scelta2 > 2)
                        {
                            Console.WriteLine("errore");
                        }
                        if (scelta2 == 1)
                        {
                            Auto auto = new Auto();
                            Console.WriteLine("inserisci la targa:");
                            auto.Targa = Console.ReadLine();
                            Console.WriteLine("inserisci il modello:");
                            auto.Modello = Console.ReadLine();
                            Console.WriteLine("inserisci la tariffa giornaliera:");
                            float tariffa;
                            while (!float.TryParse(Console.ReadLine(), out tariffa))
                            {
                                Console.WriteLine("errore");
                            }
                            auto.TargiifaGiornaliera = tariffa;
                            Console.WriteLine("inserisci i posti:");
                            int posti;
                            while (!int.TryParse(Console.ReadLine(), out posti))
                            {
                                Console.WriteLine("errore");
                            }
                            auto.Posti = posti;
                            gestionaleNoleggi.Veicoli.Add(auto);
                        }
                        else if (scelta2 == 2)
                        {
                            Furgone furgone = new Furgone();
                            Console.WriteLine("inserisci la targa:");
                            furgone.Targa = Console.ReadLine();
                            Console.WriteLine("inserisci il modello:");
                            furgone.Modello = Console.ReadLine();
                            Console.WriteLine("inserisci la tariffa giornaliera:");
                            float tariffa;
                            while (!float.TryParse(Console.ReadLine(), out tariffa))
                            {
                                Console.WriteLine("errore");
                            }
                            furgone.TargiifaGiornaliera = tariffa;
                            Console.WriteLine("inserisci il carico:");
                            float carico;
                            while (!float.TryParse(Console.ReadLine(), out carico))
                            {
                                Console.WriteLine("errore");
                            }
                            furgone.CaricoInKg = carico;
                            gestionaleNoleggi.Veicoli.Add(furgone);
                        }
                        break;
                    case 2:
                        Cliente cliente = new Cliente();
                        Console.WriteLine("inserisci nome:");
                        cliente.Nome = Console.ReadLine();
                        Console.WriteLine("inserisci cognonome:");
                        cliente.Cognome = Console.ReadLine();
                        Console.WriteLine("inserisci codice fiscale:");
                        cliente.CodiceFiscale = Console.ReadLine();
                        gestionaleNoleggi.Clienti.Add(cliente);
                        break;
                    case 3:
                        Noleggio noleggio = new Noleggio();
                        Console.WriteLine("inserisci id:");
                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("errore");
                        }
                        noleggio.ID = id;

                        Console.Write("Targa veicolo: ");
                        string targa = Console.ReadLine();
                        foreach (Veicolo v in gestionaleNoleggi.Veicoli)
                            if (v.Targa == targa)
                                noleggio.Veicolo = v;

                        Console.Write("CF cliente: ");
                        string cf = Console.ReadLine();
                        foreach (Cliente cl in gestionaleNoleggi.Clienti)
                            if (cl.CodiceFiscale == cf)
                                noleggio.Cliente = cl;

                        Console.Write("Data (yyyy-mm-dd): ");
                        noleggio.DataInizio = DateTime.Parse(Console.ReadLine());
                        Console.Write("Giorni: ");
                        noleggio.NumeroGiorni = int.Parse(Console.ReadLine());

                        gestionaleNoleggi.AggiungiNoleggio(noleggio);
                        break;
                    case 4:
                        Console.Write("Inserisci targa o CF: ");
                        var noleggiTarga = gestionaleNoleggi.VisualizzaNoleggiConTargaOCodiceFiscale(Console.ReadLine());
                        foreach (var n in noleggiTarga)
                        {
                            Console.WriteLine(n);
                        }
                        break;
                    case 5:
                        Console.Write("ID: ");
                        var noleggioID = gestionaleNoleggi.VisualizzaDettagliNoleggioConID(int.Parse(Console.ReadLine()));
                        Console.WriteLine(noleggioID);
                        break;

                    case 6:
                        Console.Write("Targa: ");
                        string tg = Console.ReadLine();
                        Console.Write("Data: ");
                        DateTime d = DateTime.Parse(Console.ReadLine());
                        Console.Write("Giorni: ");
                        int gg = int.Parse(Console.ReadLine());
                        bool disponibile = gestionaleNoleggi.VerificaDisponibilitaVeicolo(tg, d, gg);
                        if (disponibile)
                        {
                            Console.WriteLine("disponibile");
                        }
                        else
                        {
                            Console.WriteLine("non disponibile");
                        }
                        break;

                    case 7:
                        Console.Write("CF: ");
                        float totalePerCliente = gestionaleNoleggi.PrezzoTotaleNoleggioPerCliente(Console.ReadLine());
                        Console.WriteLine(totalePerCliente);
                        break;

                    case 8:
                        float totaleNoleggi = gestionaleNoleggi.PrezzoTotaleRicavatoDaiNoleggi();
                        Console.WriteLine(totaleNoleggi);
                        break;
                    default:
                        continua = false;
                        break;
                }
            }
        }
    }
}
