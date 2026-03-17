using modul4_103082430002;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------------- Kode Buah ---------------");
        KodeBuah kb = new KodeBuah();
        Console.WriteLine(kb.getKodeBuah("Apel"));
        Console.WriteLine(kb.getKodeBuah("Pisang"));
        Console.WriteLine(kb.getKodeBuah("Melon"));
        Console.WriteLine(kb.getKodeBuah("Durian"));
        Console.WriteLine(kb.getKodeBuah("Mangga"));

        Console.WriteLine("\n---------------- HEROOO ---------------");
        PosisiKarakterGame hero = new PosisiKarakterGame();

        // Simulasi Berdiri -> Jongkok -> Tengkurap -> Jongkok
        hero.tekanS(); // Ke Jongkok
        hero.tekanS(); // Ke Tengkurap
        hero.tekanW(); // Kembali ke Jongkok

        // Simulasi Jongkok -> Berdiri -> Terbang (Take Off)
        hero.tekanW(); // Ke Berdiri
        hero.tekanW(); // Output: "posisi take off", Ke Terbang

        // Simulasi Terbang -> Jongkok (Landing)
        hero.tekanX(); // Output: "posisi landing", Ke Jongkok

        // Simulasi Terbang via tekan S (ke Berdiri)
        hero.tekanW(); // Ke Berdiri
        hero.tekanW(); // Ke Terbang
        hero.tekanS(); // Ke Berdiri
    }
}