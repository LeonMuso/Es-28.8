namespace _28._8.Library;

public class Auto : Veicolo
{
    public int Posti { get; set; }
    public override string ToString()
    {
        return "Auto:" + base.ToString() + $", Posti: {Posti} ";
    }
}