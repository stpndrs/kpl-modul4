using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_103082430002
{
    internal class KodeBuah
    {
        public string getKodeBuah(string b)
        {
            string[] fruits =
            {
                "Apel",
                "Aprikot",
                "Alpukat",
                "Pisang",
                "Paprika",
                "Blackberry",
                "Ceri",
                "Kelapa",
                "Jagung",
                "Kurma",
                "Durian",
                "Anggur",
                "Melon",
                "Semangka"
            };

            string[] codes =
            {
                "A00",
                "B00",
                "C00",
                "D00",
                "E00",
                "F00",
                "H00",
                "I00",
                "J00",
                "K00",
                "L00",
                "M00",
                "N00",
                "O00"
            };

            foreach (var fruit in fruits)
            {
                if (fruit.Equals(b, StringComparison.OrdinalIgnoreCase))
                {
                    int index = Array.IndexOf(fruits, fruit);
                    return codes[index];
                }   
            }
            return "Tidak ditemukan";
        }
    }
}
