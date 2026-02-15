using _28._8.Library;

namespace Library.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_AggiungiVeicolo()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Auto a = new()
            {
                Targa = "AB123CD",
                Modello = "Fiat Panda",
                TariffaGiornaliera = 30.0f,
                Posti = 5
            };

            gestionale.Veicoli.Add(a);

            Assert.AreEqual(1, gestionale.Veicoli.Count);
        }

        [TestMethod]
        public void Test_AggiungiCliente()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Cliente cliente = new()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                CodiceFiscale = "MRARSS80A01H501U"
            };

            gestionale.Clienti.Add(cliente);

            Assert.AreEqual(1, gestionale.Clienti.Count);
        }
        [TestMethod]
        public void Test_AggiungiNoleggio()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };
            Auto a = new()
            {
                Targa = "AB123CD",
                Modello = "Fiat Panda",
                TariffaGiornaliera = 30.0f,
                Posti = 5
            };
            Cliente cliente = new()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                CodiceFiscale = "MRARSS80A01H501U"
            };
            Noleggio n = new()
            {
                ID = 123,
                Veicolo = a,
                Cliente = cliente,
                DataInizio = new DateTime(2024, 8, 5),
                NumeroGiorni = 5
            };
            gestionale.Veicoli.Add(a);
            gestionale.Clienti.Add(cliente);
            gestionale.Noleggi.Add(n);

            Assert.AreEqual(1, gestionale.Noleggi.Count);
            Assert.AreEqual(123, gestionale.Noleggi[0].ID);

        }
        [TestMethod]
        public void Test_PrezzoTotaleNoleggio()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Auto a = new()
            {
                Targa = "AA111AA",
                Modello = "Panda",
                TariffaGiornaliera = 20,
                Posti = 5
            };

            Cliente c = new()
            {
                Nome = "Luigi",
                Cognome = "Verdi",
                CodiceFiscale = "LGVRD"
            };
            Cliente t = new()
            {
                Nome = "Bobi",
                Cognome = "Check",
                CodiceFiscale = "BBOCK"
            };

            gestionale.Veicoli.Add(a);
            gestionale.Clienti.Add(c);
            gestionale.Clienti.Add(t);

            Noleggio n = new()
            {
                ID = 1,
                Veicolo = a,
                Cliente = c,
                DataInizio = DateTime.Today,
                NumeroGiorni = 3
            };
            Noleggio n2 = new()
            {
                ID = 2,
                Veicolo = a,
                Cliente = t,
                DataInizio = DateTime.Today,
                NumeroGiorni = 3 
            };

            gestionale.Noleggi.Add(n);
            gestionale.Noleggi.Add(n2);

            float totale = gestionale.PrezzoTotaleNoleggio("AA111AA");
            
            Assert.AreEqual(120, totale); 
        }

        [TestMethod]
        public void Test_DisponibilitaVeicolo_False()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Auto a = new()
            {
                Targa = "BB222BB",
                Modello = "Yaris",
                TariffaGiornaliera = 40,
                Posti = 5
            };

            Cliente c = new()
            {
                Nome = "Anna",
                Cognome = "Bianchi",
                CodiceFiscale = "ANNBI"
            };

            gestionale.Veicoli.Add(a);
            gestionale.Clienti.Add(c);

            Noleggio n = new()
            {
                ID = 1,
                Veicolo = a,
                Cliente = c,
                DataInizio = new DateTime(2024, 1, 1),
                NumeroGiorni = 5
            };

            gestionale.Noleggi.Add(n);

            bool disponibile = gestionale.VerificaDisponibilitaVeicolo("BB222BB", new DateTime(2024, 1, 3), 2);
            Assert.IsFalse(disponibile);
        }

        [TestMethod]
        public void Test_DisponibilitaVeicolo_True()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Auto a = new()
            {
                Targa = "CC333CC",
                Modello = "Clio",
                TariffaGiornaliera = 35,
                Posti = 5
            };

            gestionale.Veicoli.Add(a);

            bool disponibile = gestionale.VerificaDisponibilitaVeicolo("CC333CC", new DateTime(2024, 5, 1), 3);
            Assert.IsTrue(disponibile);
        }
        [TestMethod]
        public void Test_PrezzoTotaleNoleggioPerCliente()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Auto a1 = new()
            {
                Targa = "AA111AA",
                Modello = "Panda",
                TariffaGiornaliera = 20,
                Posti = 5
            };

            Auto a2 = new()
            {
                Targa = "BB222BB",
                Modello = "Yaris",
                TariffaGiornaliera = 40,
                Posti = 5
            };

            Cliente c = new()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                CodiceFiscale = "MRARSS"
            };

            gestionale.Veicoli.Add(a1);
            gestionale.Veicoli.Add(a2);
            gestionale.Clienti.Add(c);

            Noleggio n1 = new()
            {
                ID = 1,
                Veicolo = a1,
                Cliente = c,
                DataInizio = DateTime.Today,
                NumeroGiorni = 2 // 20*2 = 40
            };

            Noleggio n2 = new()
            {
                ID = 2,
                Veicolo = a2,
                Cliente = c,
                DataInizio = DateTime.Today,
                NumeroGiorni = 3 // 40*3 = 120
            };

            gestionale.Noleggi.Add(n1);
            gestionale.Noleggi.Add(n2);

            float totale = gestionale.PrezzoTotaleNoleggioPerCliente("MRARSS");

            Assert.AreEqual(160, totale);
        }
        [TestMethod]
        public void Test_RicercaNoleggioPerID()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Auto a = new()
            {
                Targa = "ID123",
                Modello = "Opel",
                TariffaGiornaliera = 30,
                Posti = 5
            };

            Cliente c = new()
            {
                Nome = "Test",
                Cognome = "User",
                CodiceFiscale = "TEST"
            };

            Noleggio n = new()
            {
                ID = 99,
                Veicolo = a,
                Cliente = c,
                DataInizio = DateTime.Today,
                NumeroGiorni = 4
            };

            gestionale.Noleggi.Add(n);

            Noleggio trovato = gestionale.Noleggi[0];

            Assert.AreEqual(99, trovato.ID);
        }

        [TestMethod]
        public void Test_VeicoloNonEsistente()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            bool disponibile = gestionale.VerificaDisponibilitaVeicolo(
                "NONESISTE",
                DateTime.Today,
                2
            );

            Assert.IsTrue(disponibile);
        }

        [TestMethod]
        public void Test_ClienteSenzaNoleggi()
        {
            GestionaleNoleggi gestionale = new()
            {
                Veicoli = new List<Veicolo>(),
                Clienti = new List<Cliente>(),
                Noleggi = new List<Noleggio>()
            };

            Cliente c = new()
            {
                Nome = "c",
                Cognome = "c",
                CodiceFiscale = "c"
            };

            gestionale.Clienti.Add(c);

            float totale = gestionale.PrezzoTotaleNoleggioPerCliente("c");

            Assert.AreEqual(0, totale);
        }

    }
}
