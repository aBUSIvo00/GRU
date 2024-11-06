using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gru
{
    internal class RadioComando
    {
        public string NumeroSeriale
        {
            get { return NumeroSeriale; }
            set { NumeroSeriale = value; }
        }
        private Gru gruAssociata;

        public RadioComando(string numeroSeriale, Gru gru)
        {
            NumeroSeriale = numeroSeriale;
            gruAssociata = gru;
        }

        public void AlzaGru(int metri)
        {
            gruAssociata.AlzaGru(metri);
        }

        public void AbbassaGru(int metri)
        {
            gruAssociata.AbbassaGru(metri);
        }

        public void RiportaInPosizioneSicurezza()
        {
            gruAssociata.PosizioneSicura();
        }

        public double GetAltezzaGru()
        {
            return gruAssociata.GetAltezza();
        }
    }
}