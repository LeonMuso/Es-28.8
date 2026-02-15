namespace _28._8.Library
{
    public abstract class Veicolo
    {
        public string Targa { get; set; }
        public string Modello { get; set; }
        public float TariffaGiornaliera { get; set; }

        public override string ToString()
        {
            return $" {Modello}, Targa: {Targa}, Tariffa Giornaliera: {TariffaGiornaliera} ";
        }

    }
}
