namespace _28._8.Library;

public class Noleggio
{
    public int ID { get; set; }

    public DateTime DataInizio { get; set; }
    public int NumeroGiorni { get; set; }
    public float Costo { get; set; }

    public Veicolo Veicolo { get; set; }
    public Cliente Cliente { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}\n" +
               $"Veicolo: {Veicolo}\n" +
               $"Cliente: {Cliente}\n" +
               $"Data inizio: {DataInizio.ToShortDateString()}\n" +
               $"Giorni: {NumeroGiorni}\n" +
               $"Costo: {Costo} €";
    }
}