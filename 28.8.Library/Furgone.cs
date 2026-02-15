namespace _28._8.Library;

public class Furgone : Veicolo
{
    public float CaricoInKg { get; set; }

    public override string ToString()
    {
        return "Furgone:" + base.ToString() + $", CaricoInKg: {CaricoInKg} ";
    }
}