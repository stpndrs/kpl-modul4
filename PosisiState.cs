using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_103082430002
{
    public interface PosisiState
    {
        void tombolW(PosisiKarakterGame context);
        void tombolS(PosisiKarakterGame context);
        void tombolX(PosisiKarakterGame context);
    }

    public class Berdiri : PosisiState
    {
        public void tombolW(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter terbang");
            context.setState(new Terbang());
        }
        public void tombolS(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter jongkok");
            context.setState(new Berjongkok());
        }
        public void tombolX(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter tetap berdiri");
        }
    }

    public class Terbang : PosisiState
    {
        public void tombolW(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter tetap terbang");
        }
        public void tombolS(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter berdiri");
            context.setState(new Berdiri());
        }
        public void tombolX(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter jongkok");
            context.setState(new Berjongkok());
        }
    }

    public class Tengkurap : PosisiState
    {
        public void tombolW(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter jongkok");
            context.setState(new Berjongkok());
        }
        public void tombolS(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter tetap tengkurap");
        }
        public void tombolX(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter tetap tengkurap");
        }
    }

    public class Berjongkok : PosisiState
    {
        public void tombolW(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter berdiri");
            context.setState(new Berdiri());
        }
        public void tombolS(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter tengkurap");
            context.setState(new Tengkurap());
        }
        public void tombolX(PosisiKarakterGame context)
        {
            Console.WriteLine("Karakter tetap berjongkok");
        }
    }
}