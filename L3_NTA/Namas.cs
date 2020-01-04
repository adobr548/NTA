using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_NTA
{
    /// <summary>
    /// Bazine abstrakti klase
    /// </summary>
    abstract public class Namas:IComparable<Namas>
    {       
        public string Rajonas   { get; set; }                                //Savybes: Mikrorajono pavadinimas
        public string GatvesPav { get; set; }                                //Gatves pavadinimas
        public string NamoNr    { get; set; }                                //Namo numeris
        public string NamoTipas { get; set; }                                //Namo tipas
        public int Metai        { get; set; }                                //Pastatymo metai
            
        /// <summary>
        /// Konstruktorius be parametru
        /// </summary>
        public Namas()
        {
        }

        /// <summary>
        /// Konstruktorius: savybems suteikiam reiksmes
        /// </summary>
        /// <param name="Rajonas">mikrorajono pavadinimas</param>
        /// <param name="GatvesPav">gatves pavadinimas</param>
        /// <param name="NamoNr">namo numeris</param>
        /// <param name="NamoTipas">namo tipas</param>
        /// <param name="Metai">pastatymo metai</param>
        public Namas(string Rajonas,string GatvesPav,string NamoNr,string NamoTipas, int Metai)            
        {
            this.Rajonas = Rajonas;
            this.GatvesPav = GatvesPav;
            this.NamoNr = NamoNr;
            this.NamoTipas = NamoTipas;
            this.Metai = Metai;            
           
        }

        /// <summary>
        /// Abstraktus namo ploto didesnio uz 100 kv.m. metodas.Realizuotas isvestineje klaseje
        /// </summary>
        /// <returns>grazina plota didesni uz 100 kv.m.</returns>
        abstract public bool DidesnisPlotas();

        /// <summary>
        /// Uzklotas operatorius toString()
        /// </summary>
        /// <returns>grazina suformuota eilute</returns>
        public override string ToString()
        {
            string eilute = string.Format("{0} {1} {2} {3} {4} ",
                                      Rajonas,GatvesPav,NamoNr,NamoTipas, Metai);
            return eilute;
        }

        /// <summary>
        ///Metodas CompareTo
        ///saraso rikiavimas pagal gatves pavadinima ir metus didejimo tvarka
        /// </summary>
        /// <param name="kitas">kitas Namo elementas</param>
        /// <returns>grazina 1(jei tenkina salyga),kitu atveju -1</returns>
        public int CompareTo(Namas kitas)
        {
            int poz = String.Compare(this.GatvesPav, kitas.GatvesPav, StringComparison.CurrentCulture);

            if ((this.Metai < kitas.Metai || ((this.Metai == kitas.Metai) && (poz > 0))))
                return 1;
            else
                return -1;
        }

    }
}
