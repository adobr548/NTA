using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_NTA
{
    /// <summary>
    /// Isvestine klase
    /// </summary>
    class Patalpos:Namas
    {        
        public double NamoPlotas { get; set; }                                           //Namo plotas kv.m.
        public int KambariuSk    { get; set; }                                           //Kambariu skaicius
         
        /// <summary>
        /// Konstruktorius be parametru
        /// </summary>
        public Patalpos()
        {
        }

        /// <summary>
        /// Konstruktorius: savybems suteikiam reiksmes
        /// </summary>
        /// <param name="MikroRajonas">mikrorajono pavadinimas</param>
        /// <param name="Gatve">gatves pavadinimas</param>
        /// <param name="NamoNumeris">namo numeris</param>
        /// <param name="NamoTipas">namo tipas</param>
        /// <param name="Metai">pastatymo metai</param>
        /// <param name="NamoPlotas"> namo plotas</param>
        /// <param name="KambariuSk">kambariu skaicius</param>
        public Patalpos(string MikroRajonas, string Gatve, string NamoNumeris,
                        string NamoTipas, int Metai, double NamoPlotas, int KambariuSk)
            : base(MikroRajonas,Gatve,NamoNumeris,NamoTipas,Metai)           
        {
            this.NamoPlotas = NamoPlotas;
            this.KambariuSk = KambariuSk;
        }

        /// <summary>
        /// Namo plotas didesnis uz 100 kv.m.
        /// </summary>
        /// <returns>grazina namo plota didesni uz 100 kv.m.</returns>
        public override bool DidesnisPlotas()
        {
            return NamoPlotas > 100;
        }
        
        /// <summary>
        /// Uzklotas operatorius toString()
        /// </summary>
        /// <returns>grazina suformuota eilute</returns>
        public override string ToString()
        {
            return string.Format("{0} {1,7:f2} {2} ", base.ToString(),NamoPlotas,KambariuSk);
        }
        
    }
}
