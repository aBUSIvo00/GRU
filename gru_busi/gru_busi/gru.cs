using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gru
{
    internal class Gru
    {
        private string nSeriale;
        public string NSeriale
        {
            get { return nSeriale; }
        }
        private string produttore;
        public string Produttore
        {
            get { return produttore; }
        }
        private int pesoMax;
        public int PesoMax
        {
            get { return pesoMax; }
        }
        private int altMin;
        public int Altmin
        {
            get { return altMin; }
            set { altMin = value; }
        }

        private int altBra;
        public int AltBra
        {
            get { return altBra; }
            set { altBra = value; }
        }

        private int altMax;
        public int AltMax
        {
            get { return altMax; }
            set { altMax = value; }
        }

        public Gru(string nSeriale, string produttore, int pesoMax, int altMin, int altBra)
        {
            this.nSeriale = nSeriale;
            this.produttore = produttore;
            this.pesoMax = pesoMax;
            this.altMin = altMin;
            this.altBra = altBra;
        }

        public void AlzaGru(int metri)
        {
            altBra = altBra++;
        }
        public void AbbassaGru(int metri)
        {
            altBra = altBra--;
        }
        public int GetAltezza()
        {
            return altBra;
        }
        public void PosizioneSicura()
        {
            altBra = altMin;
        }
    }
}