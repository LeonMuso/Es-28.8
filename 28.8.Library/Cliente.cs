namespace _28._8.Library;

public class Cliente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string CodiceFiscale { get; set; }

    public override string ToString()
    {
        return $"Cliente: {Nome} {Cognome}, Codice Fiscale: {CodiceFiscale} ";
    }
}