using System.ComponentModel.DataAnnotations;

namespace ATMBank_.Models;

public class TempInfo
{
    [Range(1, 2500000)]
    public int JumlahPenarikan { get; set; }

    [Range(111,999)]
    public int NoRekening { get; set; }

    [Range(1, 2500000)]
    public int Nominal { get; set; }

    public int JumlahLembar { get; set; }
}