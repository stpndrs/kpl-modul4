using modul4_103082430002;

class Program
{
    public static void Main(string[] args)
    {
        KodeBuah kb = new KodeBuah();
        Console.WriteLine(kb.getKodeBuah("Apel"));
        Console.WriteLine(kb.getKodeBuah("Pisang"));
        Console.WriteLine(kb.getKodeBuah("Melon"));
        Console.WriteLine(kb.getKodeBuah("Durian"));
        Console.WriteLine(kb.getKodeBuah("Mangga"));
    }
}