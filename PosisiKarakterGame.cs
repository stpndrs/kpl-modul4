using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_103082430002
{
    public class PosisiKarakterGame
    {
        private PosisiState state;
        public PosisiKarakterGame()
        {
            state = new Berdiri();
        }
        public void setState(PosisiState newState)
        {
            state = newState;
        }
        public void tekanW()
        {
            state.tombolW(this);
        }
        public void tekanS()
        {
            state.tombolS(this);
        }
        public void tekanX()
        {
            state.tombolX(this);
        }
    }
}