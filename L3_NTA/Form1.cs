using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace L3_NTA
{
    public partial class Form1 : Form
    {
        ///Konstantos        
        const string CFu = "Uzduotis.txt";                                 // užduoties failo vardas 
        const string CFn = "Pagalba.txt";                                 // nurodymų failo vardas 
       
        /// kintamieji(objektu masyvai)        
        private List<Patalpos> Namai = new List<Patalpos>();                   //pradinis namu sarasas
        private List<Patalpos> DuPlotai = new List<Patalpos>();                   //dvieju didziausiu plotu list
        private List<Patalpos> RajonaiBePasikartojimu;                            //Rajonu list
        private List<Patalpos> AtrinktasSarasas;                                  //naujas sarasas atrinktas is NamuList
        
        public Form1()
        {
            InitializeComponent();

            // Nurodyti meniu punktai padaromi pasyviais 
            spausdinimasToolStripMenuItem.Enabled = false;
            duMaxToolStripMenuItem.Enabled = false;
            rajonaiBePasikartojimuToolStripMenuItem.Enabled = false;
            atrinktasSarasasToolStripMenuItem.Enabled = false;
            rikiavimasToolStripMenuItem.Enabled = false;

        }

        //------------------------------------------------------------------------------------------
        // Grafines sasajos valdymo metodai
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Meniu punkto "Ivesti" atliekami veiksmai
        /// Duomenų failo vardas išrenkamas naudojant openFileDialog komponentą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ivestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenFileDialog komponento savybių nustatymas 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";             // filtras
            openFileDialog1.Title = "Pasirinkite duomenų failą";                               // pavadinimas
            DialogResult result = openFileDialog1.ShowDialog();

            // jeigu pasirinktas failas
            if (result == DialogResult.OK)
            {
                string fv = openFileDialog1.FileName;                             // fv - duomenu failo vardas

                //Duomenu uzkrovimas ekrane
                Duomenys.LoadFile(fv, RichTextBoxStreamType.PlainText);
                //Nuskaitymas
                Skaityti(fv, Namai);
            }

            // Meniu punktų nustatymai
            ivestiToolStripMenuItem.Enabled = false;
            duMaxToolStripMenuItem.Enabled = true;
            rajonaiBePasikartojimuToolStripMenuItem.Enabled = true;
       
                        
        }
        /// <summary>
        /// Meniu punkto "Spausdinti" atliekami veiksmai
        /// Rezultatų failo vardas išrenkamas naudojant saveFileDialog komponentą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spausdinimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SaveFileDialog komponento savybių nustatymas
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";        //filtras
            saveFileDialog1.Title = "Pasirinkite txt rezultatų failą";                         //pavadinimas
            DialogResult result = saveFileDialog1.ShowDialog();

            // jeigu pasirinktas failas 
            if (result == DialogResult.OK)
            {
                string fv = saveFileDialog1.FileName;                          // fv - rezultatu failo vardas

                //jei reikia isvalo faila
                 if (File.Exists(fv))
                     File.Delete(fv);
                
                if (Namai.Count > 0)
                {
                    Spausdinti(fv, Namai, "Duomenys");
                }
                else
                    MessageBox.Show(" duomenu failas tuscias!");
                
                Spausdinti(fv,DuPlotai,"Du Didziausi plotai");
                              
                using (var fr = File.AppendText(fv))
                {
                    fr.WriteLine("Rajonai be pasikartojimu \n");
                    fr.WriteLine("---------------------------");
                    for (int i = 0; i < RajonaiBePasikartojimu.Count; i++)
                        fr.WriteLine(i + 1 + " " + RajonaiBePasikartojimu[i].Rajonas + "\n");
                    fr.WriteLine("---------------------------");
                }
                
                Spausdinti(fv, AtrinktasSarasas, "Atrinkti namai");
               
                
            }
        }

        /// <summary>
        /// Menu punkto "DuMax" atliekami veiksmai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void duMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double max1;
            double max2;

            DuMax(Namai, out max1, out max2);

            int index1 = Namai.IndexOf(Namai.Single(i => i.NamoPlotas == max1));
            int index2 = Namai.IndexOf(Namai.Single(i => i.NamoPlotas == max2));

            Rezultatai.AppendText("\n 2 Didziausi Namu Plotai");
            Rezultatai.AppendText("\n---------------------------------------------------------\n");
            Rezultatai.AppendText(Namai[index1].ToString() + "\n" + Namai[index2].ToString());
            Rezultatai.AppendText("\n---------------------------------------------------------\n");

            DuPlotai.Add(Namai[index1]);
            DuPlotai.Add(Namai[index2]);

            duMaxToolStripMenuItem.Enabled = false;
                                                           
         }
         
        /// <summary>
        /// Menu punto "Rajonai be pasikartojimu" atliekami veiksmai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rajonaiBePasikartojimuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RajonaiBePasikartojimu = Namai.GroupBy(i => i.Rajonas).Select(ss => ss.FirstOrDefault()).ToList();

            Rezultatai.AppendText("\n Rajonai be pasikartojimu \n");
            Rezultatai.AppendText("------------------------------------------ \n");
            for (int i = 0; i < RajonaiBePasikartojimu.Count; i++)
                Rezultatai.AppendText(i + 1 + " " + RajonaiBePasikartojimu[i].Rajonas + "\n");
            Rezultatai.AppendText("------------------------------------------ \n");

            atrinktasSarasasToolStripMenuItem.Enabled = true;
            
        } 
        /// <summary>
        /// Menu punkto "Atrinktas sarasas" atliekami veiksmai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atrinktasSarasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Klaidos isvedimas jei textboxe yra tuscia vieta
            if (TipoIvedimas.Text.Trim() == "")
            {
                MessageBox.Show("Klaida! Prasom ivesti namo tipa");

            }

            string tipas = TipoIvedimas.Text;

            AtrinktasSarasas = AtrinktiNamai(Namai, tipas);

            Rezultatai.AppendText("\nAtrinktas sarasas \n");
            Rezultatai.AppendText("---------------------------------------------------------\n");
            for (int i = 0; i < AtrinktasSarasas.Count; i++)
                Rezultatai.AppendText(i + 1 + " " + AtrinktasSarasas[i].ToString() + "\n");
            Rezultatai.AppendText("---------------------------------------------------------\n");

            rikiavimasToolStripMenuItem.Enabled = true;
            spausdinimasToolStripMenuItem.Enabled = true;

        } 
        /// <summary>
        /// Menu punkto "Rikiavimas" atliekami veiksmai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rikiavimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtrinktasSarasas.Sort();

            Rezultatai.AppendText("\nRikiuotas sarasas \n");
            Rezultatai.AppendText("---------------------------------------------------------\n");
            for (int i = 0; i < AtrinktasSarasas.Count; i++)
                Rezultatai.AppendText(i + 1 + " " + AtrinktasSarasas[i].ToString() + "\n");
            Rezultatai.AppendText("---------------------------------------------------------\n");

           
        }
        /// <summary>
        /// Meniu punkto "Užduotis" atliekami veiksmai: 
        /// parodomas užduoties failo turinys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uzduotisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezultatai.LoadFile(CFu, RichTextBoxStreamType.PlainText);
        }
        /// <summary>
        /// Meniu punkto "Pagalba" atliekami veiksmai 
        /// parodomas pagalbos failo turinys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagalbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezultatai.LoadFile(CFn, RichTextBoxStreamType.PlainText);
        }
        /// <summary>
        ///  Meniu punkto "Baigti" atliekami veiksmai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void baigtiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        //------------------------------------------------------------
        // Uzduoties metodai
        //------------------------------------------------------------
        /// <summary>
        ///  Skaito visus duomenis is failo i List
        /// </summary>
        /// <param name="fv">duomenu failo vardas</param>
        /// <param name="List"> namu sarasas</param>
        static void Skaityti(string fv, List<Patalpos> List)
        {
            using(StreamReader reader = new StreamReader(fv,Encoding.GetEncoding(1257) ))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string rajonas = parts[0];
                    string gatve = parts[1];
                    string namonr = parts[2];
                    string tipas = parts[3];
                    int metai = int.Parse(parts[4]);
                    double plotas = double.Parse(parts[5]);
                    int kambariusk = int.Parse(parts[6]);
                    Patalpos Namai = new Patalpos(rajonas, gatve, namonr, tipas, metai, plotas, kambariusk);
                    List.Add(Namai);

                }


            }
           
        }
        /// <summary>
        ///  Spausdina List duomenis lentele faile.
        /// </summary>
        /// <param name="fv">duomenu failo vardas</param>
        /// <param name="List">namu sarasas</param>
        /// <param name="info">papildoma informacija</param>
        static void Spausdinti(string fv, List<Patalpos> List, string info)
        {
            const string virsus =
                                  "--------------------------------------------------------------\r\n"
                                + "Nr Rajonas    Gatve Namo Nr Tipas   Metai  Plotas Kambariu sk.\r\n"
                                + "--------------------------------------------------------------";
            using (var fr = File.AppendText(fv))
            {
                fr.WriteLine(info);
                fr.WriteLine(virsus);
                for (int i = 0; i < List.Count; i++)
                {
                    Patalpos namai = List[i];
                    fr.WriteLine("{0} {1}", i + 1 , namai);
                }
                fr.WriteLine("--------------------------------------------------------------");
            }
        }


        /// <summary>
        /// Dvieju max plotu paieskos metodas
        /// </summary>
        /// <param name="List">namu sarasas</param>
        /// <param name="max1">1 didziausias plotas</param>
        /// <param name="max2">2 didziausas plotas</param>
        static void DuMax(List<Patalpos> List, out double max1, out double max2)
        {
             max1 = List[0].NamoPlotas;
             max2 = List[1].NamoPlotas;

            if (max2 > max1)
            {
                max1 = List[1].NamoPlotas;
                max2 = List[0].NamoPlotas;
            }

            for (int i = 2; i < List.Count; i++)
            {
                if (List[i].NamoPlotas > max1)
                {
                    max2 = max1;
                    max1 = List[i].NamoPlotas;
                }
                else if (List[i].NamoPlotas > max2)
                {
                    max2 = List[i].NamoPlotas;
                }
            }
        }


        /// <summary>
        /// Atrinkti namai pagal tipa ir plota
        /// </summary>
        /// <param name="List">namu sarasas</param>
        /// <param name="tipas">vartotojo pasirinktas namo tipas</param>
        /// <returns>grazina naujai suformuota lista</returns>
        static List<Patalpos> AtrinktiNamai(List<Patalpos> List, string tipas)
        {
            List<Patalpos> New = new List<Patalpos>();

            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].NamoTipas == tipas && List[i].DidesnisPlotas())
                    New.Add(List[i]);
            }

            return New;
        }
                          
    }
}
