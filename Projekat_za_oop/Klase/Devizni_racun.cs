using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public class Devizni_racun : Racun
    {
        protected double stanjeUEur;
        protected string iban;
        protected string swift;
        protected Racun Racun;

        public Devizni_Racun( Racun racun, string brRac, string ib, string sw)
        {
            this.stanjeUEur = stanje/124;
            this.iban = ib;
            this.swift = sw;
            this.brRacuna = brRac;
          }

        public double Iban()
        {
            return stanjeUEur;

        }
    }
}
