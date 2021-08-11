using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szemelyiNyilvantartas01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adatbetoltes();
            gyerekadatbetoltes();
        }

        struct nyilvantartasiAdatok
        {
            public string nev;
            public string szemelyazonosito;
            public string leanykorinev;
            public string szuletesihely;
            public string szuletesiido;
            public string anyjaneve;
            public string tajszam;
            public string adoazonosito;


            public string allandolakcim;
            public string vonalastelall;
            public string tartozkodasihely;
            public string vonalasteltart;

            public string lakcimkartyaszama;
            public string kiallitasidolakcim;


            public string utlevelsz;
            public string utlevelervenyessegiido;


            public string szemelyiszam;
            public string szemelyiervenyessegido;


            public string szolgalatimobil;
            public string sajatmobil;


            public string munkaviszonykezdete;
            public string bmszolgalativiszony;

            public string szolgalatiigazolvanyszama;
            public string szolgalatijelvenyszam;
            public string pecsetnyomoszama;
            public string szolgalatifegyvertipusa;
            public string szolgalatifegyverszama;
            public string szolgalatiloszerdarabsz;

            public string vezetoiengedelyszama;
            public string ervenyessegikategoria;
            public string ervenyessegiidovezeng;
            public string ugyintezoiigazolvanyszama;
            public string kiallitaskelte;

            public string milyennyelv;
            public string nyelvismeretfoka;
            public string nyelvbizszama;

            public string legmagasabbiskvegzettseg;
            public string legiskvegzmegszerzeseve;
            public string rendorivegzettseg;
            public string rendvegzmegszeve;
            public string jelenlegitanulmanyok;

        }
        struct gyerekadatok
        {
            public string szulo_neve;
            public string gyerek_neve;
            public string anyja_neve;
            public string szul_ido;
            public string taj_sz;
            public string ado_szam;


        }
        struct szulokadatok
        { public string szulonevek; }

        nyilvantartasiAdatok[] szemelyek = new nyilvantartasiAdatok[500];
        gyerekadatok[] gyerekek = new gyerekadatok[500];
        //szulokadatok[] szulok = new szulokadatok[100];

        int dbsz, gyerekdbsz = 0;

        private void adatbetoltes()

        {
            try
            {

                string[] fajlbol = File.ReadAllLines("nyilvantartas.txt");

                for (int i = 0; i < fajlbol.Length; i++)
                {
                    string[] seged = fajlbol[i].Split(';');
                    szemelyek[dbsz].nev = seged[0];
                    szemelyek[dbsz].szemelyazonosito = seged[1];
                    szemelyek[dbsz].leanykorinev = seged[2];
                    szemelyek[dbsz].szuletesihely = seged[3];
                    szemelyek[dbsz].szuletesiido = seged[4];
                    szemelyek[dbsz].anyjaneve = seged[5];
                    szemelyek[dbsz].tajszam = seged[6];
                    szemelyek[dbsz].adoazonosito = seged[7];
                    //lakcímadatok
                    szemelyek[dbsz].allandolakcim = seged[8];
                    szemelyek[dbsz].vonalastelall = seged[9];
                    szemelyek[dbsz].tartozkodasihely = seged[10];
                    szemelyek[dbsz].vonalasteltart = seged[11];
                    //lakcímkártya adatok
                    szemelyek[dbsz].lakcimkartyaszama = seged[12];
                    szemelyek[dbsz].kiallitasidolakcim = seged[13];
                    //útlevél adatok
                    szemelyek[dbsz].utlevelsz = seged[14];
                    szemelyek[dbsz].utlevelervenyessegiido = seged[15];
                    //személyigazolvány adatok
                    szemelyek[dbsz].szemelyiszam = seged[16];
                    szemelyek[dbsz].szemelyiervenyessegido = seged[17];
                    //mobiltelefon adatok
                    szemelyek[dbsz].szolgalatimobil = seged[18];
                    szemelyek[dbsz].sajatmobil = seged[19];
                    //munkaviszonnyal kapcsolatos adatok
                    szemelyek[dbsz].munkaviszonykezdete = seged[20];
                    szemelyek[dbsz].bmszolgalativiszony = seged[21];
                    //szolgálati igazolvány jelvény pecsétnyomó
                    szemelyek[dbsz].szolgalatiigazolvanyszama = seged[22];
                    szemelyek[dbsz].szolgalatijelvenyszam = seged[23];
                    szemelyek[dbsz].pecsetnyomoszama = seged[24];
                    //fegyveradatok
                    szemelyek[dbsz].szolgalatifegyvertipusa = seged[25];
                    szemelyek[dbsz].szolgalatifegyverszama = seged[26];
                    szemelyek[dbsz].szolgalatiloszerdarabsz = seged[27];
                    //vezetői engedély, ügyintézői adatok
                    szemelyek[dbsz].vezetoiengedelyszama = seged[28];
                    szemelyek[dbsz].ervenyessegikategoria = seged[29];
                    szemelyek[dbsz].ervenyessegiidovezeng = seged[30];
                    szemelyek[dbsz].ugyintezoiigazolvanyszama = seged[31];
                    szemelyek[dbsz].kiallitaskelte = seged[32];
                    //idegennyyelvi tudás adatok
                    szemelyek[dbsz].milyennyelv = seged[33];
                    szemelyek[dbsz].nyelvismeretfoka = seged[34];
                    szemelyek[dbsz].nyelvbizszama = seged[35];
                    //tanulmányi adatok
                    szemelyek[dbsz].legmagasabbiskvegzettseg = seged[36];
                    szemelyek[dbsz].legiskvegzmegszerzeseve = seged[37];
                    szemelyek[dbsz].rendorivegzettseg = seged[38];
                    szemelyek[dbsz].rendvegzmegszeve = seged[39];
                    szemelyek[dbsz].jelenlegitanulmanyok = seged[40];

                    comboBox1.Items.Add(szemelyek[dbsz].nev);
                    comboBox1.Sorted = comboBox1.Sorted = true;

                                    comboBox2.Items.Add(szemelyek[dbsz].nev);
                                    comboBox2.Sorted = comboBox2.Sorted = true;

                    dbsz++;

                }
            }
            catch (Exception)
            {
                FileStream fnevcim7 = new FileStream("nyilvantartas.txt", FileMode.Create);
                StreamWriter fajlbairo7 = new StreamWriter(fnevcim7, System.Text.Encoding.UTF8);
                fajlbairo7.Close();
                fnevcim7.Close();

            }

        }
        private void gyerekadatbetoltes()
        {
            try
            {

                string[] fajlbol1 = File.ReadAllLines("gyerek_nyilvantartas.txt");
                string egy = "";
                for (int i = 0; i < fajlbol1.Length; i++)
                {
                    string[] gyerekseged = fajlbol1[i].Split(';');
                    gyerekek[gyerekdbsz].szulo_neve = gyerekseged[0];
                    gyerekek[gyerekdbsz].gyerek_neve = gyerekseged[1];
                    gyerekek[gyerekdbsz].anyja_neve = gyerekseged[2];
                    gyerekek[gyerekdbsz].szul_ido = gyerekseged[3];
                    gyerekek[gyerekdbsz].taj_sz = gyerekseged[4];
                    gyerekek[gyerekdbsz].ado_szam = gyerekseged[5];

                    comboBox3.Items.Add(gyerekek[gyerekdbsz].gyerek_neve);

                    egy = gyerekek[gyerekdbsz].szulo_neve;

                    if(!comboBox4.Items.Contains(egy)  ){
                    comboBox4.Items.Add(gyerekek[gyerekdbsz].szulo_neve);
                    comboBox4.Sorted = comboBox4.Sorted = true;
                    
                    }
                    else
                    {
                    }

                    comboBox3.Sorted = comboBox3.Sorted = true;
                    //                comboBox2.Items.Add(szemelyek[dbsz].nev);
                    //                comboBox2.Sorted = comboBox2.Sorted = true;

                    gyerekdbsz++;

                }

            }
            catch (Exception)
            {
                FileStream fnevcim9 = new FileStream("gyerek_nyilvantartas.txt", FileMode.Create);
                StreamWriter fajlbairo9 = new StreamWriter(fnevcim9, System.Text.Encoding.UTF8);
                fajlbairo9.Close();
                fnevcim9.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox75.Text != "") && (textBox73.Text != "") && (textBox72.Text != "") && (textBox74.Text != "") && (textBox71.Text != "") && (textBox70.Text != "") && (textBox69.Text != "") && (textBox68.Text != ""))
            {
                try
                {
                    string ujnev = textBox75.Text;
                    string ujszemelyazonositojel = textBox73.Text;
                    string ujelozoleanykorinev = textBox72.Text;
                    string ujszuletesihely = textBox74.Text;
                    string ujszuletesiido = textBox71.Text;
                    string ujanyjaneve = textBox70.Text;
                    string ujtajszam = textBox69.Text;
                    string ujadoazonositoszam = textBox68.Text;
                    //lakcimadatok
                    string ujallandolakcim = textBox9.Text;
                    string ujalllakcvontel = textBox10.Text;
                    string ujtartozkodasihely = textBox11.Text;
                    string ujtarthelyvontel = textBox12.Text;
                    //lakcikartyaadatok
                    string ujlakcimkartyaszama = textBox20.Text;
                    string ujlakcimkartyakiallitasiido = textBox57.Text;
                    //utleveladatok
                    string ujutlevelszam = textBox16.Text;
                    string ujutlevelervenyessegiido = textBox17.Text;
                    //szemelyigazolvany adatok
                    string ujszemelyigazolvanyszama = textBox18.Text;
                    string ujszemelyigazolvanyervenyessegiido = textBox19.Text;
                    //mobiltelefon adatok
                    string ujszolgalatimobil = textBox8.Text;
                    string ujsajatmobil = textBox15.Text;
                    //munkaviszonnyal kapcsolatos adatok
                    string ujmunkaviszonykezdete = textBox26.Text;
                    string ujbmmunkaviszony = textBox27.Text;
                    //szolgálati igazolvány,jelvény, pecsét
                    string ujszolgalatiigazolvanyszam = textBox28.Text;
                    string ujjelvenyszam = textBox29.Text;
                    string ujpecsetnyomoszam = textBox30.Text;
                    //fegyveradatok
                    string ujszolgalatifegyvertipus = textBox31.Text;
                    string ujszolgalatifegyverszam = textBox32.Text;
                    string ujloszerdbszam = textBox33.Text;
                    //vezetői engedély,ügyintézői adatok
                    string ujvezetoiengedelyszama = textBox21.Text;
                    string ujervenyessegikategoriak = textBox22.Text;
                    string ujvezetoiengedelyervenyessege = textBox23.Text;
                    string ujugyintezoiszama = textBox24.Text;
                    string ujugyintezoikiallitasido = textBox25.Text;
                    //idegen nyelvi tudás
                    string ujidegennyelvekfelsorolas = textBox5.Text;
                    string ujnyelvismeretszintje = textBox6.Text;
                    string ujnyelvvizsgabizonyitvanyszama = textBox7.Text;
                    //tanulmanyi adatok
                    string ujlegmagasabbiskolaivegzettseg = textBox34.Text;
                    string ujlegmiskvegzmegszerzeseve = textBox35.Text;
                    string ujrendorivegzettsege = textBox36.Text;
                    string ujrendorivegzettsegmegszerzesieve = textBox37.Text;
                    string ujjelenlegitanulmanyok = textBox38.Text;




                    FileStream fnev = new FileStream("nyilvantartas.txt", FileMode.Append);
                    StreamWriter fajlbairo = new StreamWriter(fnev, System.Text.Encoding.UTF8);
                    fajlbairo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18};{19};{20};{21};{22};{23};{24};{25};{26};{27};{28};{29};{30};{31};{32};{33};{34};{35};{36};{37};{38};{39};{40}",
                        ujnev, ujszemelyazonositojel, ujelozoleanykorinev, ujszuletesihely,
                        ujszuletesiido, ujanyjaneve, ujtajszam, ujadoazonositoszam, ujallandolakcim,
                        ujalllakcvontel, ujtartozkodasihely, ujtarthelyvontel, ujlakcimkartyaszama,
                        ujlakcimkartyakiallitasiido, ujutlevelszam, ujutlevelervenyessegiido, ujszemelyigazolvanyszama,
                        ujszemelyigazolvanyervenyessegiido, ujszolgalatimobil, ujsajatmobil, ujmunkaviszonykezdete,
                        ujbmmunkaviszony, ujszolgalatiigazolvanyszam, ujjelvenyszam, ujpecsetnyomoszam,
                        ujszolgalatifegyvertipus, ujszolgalatifegyverszam, ujloszerdbszam,
                        ujvezetoiengedelyszama, ujervenyessegikategoriak, ujvezetoiengedelyervenyessege, ujugyintezoiszama,
                        ujugyintezoikiallitasido, ujidegennyelvekfelsorolas, ujnyelvismeretszintje, ujnyelvvizsgabizonyitvanyszama,
                        ujlegmagasabbiskolaivegzettseg, ujlegmiskvegzmegszerzeseve, ujrendorivegzettsege, ujrendorivegzettsegmegszerzesieve,
                        ujjelenlegitanulmanyok);
                    fajlbairo.Close();
                    fnev.Close();
                    MessageBox.Show("Sikerült az adatbázisba felvinni " + textBox75.Text + " adatait Gratulálok!");

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
 dbsz = 0;
                    adatbetoltes();

                }
                catch
                {
                    MessageBox.Show("Egy vagy több mező adata rossz formátumú, vagy hiányos, így nem vehetjük fel.", "Sajnos..");
                }
            }
            else MessageBox.Show("Egy vagy több mező nincs kitöltve. Így nem vehetjük fel az adatokat. Kérem minden mezőt töltsön ki a sikeres felvitel végett.");
        }



        private void button4_Click(object sender, EventArgs e)
        {
            //név és cím lekérés

            FileStream fnevcim = new FileStream("nev_cim.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)

            {
             
                    string nev1 = szemelyek[q].nev;
                    string nevcimadatok1 = szemelyek[q].allandolakcim;
                    string nevidlakcim = szemelyek[q].tartozkodasihely;
                if (nev1 != null)
                {

                    fajlbairo1.WriteLine("{0}:\n{1}:\n{2}\n", "Név: " + nev1, "Állandó lakhely: " + nevcimadatok1, "Tartózkodási hely: " + nevidlakcim);
                }
                else { break; }
            }
                
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és Címeket kimenteni Gratulálok!");
dbsz = 0;
        }




        private void button6_Click(object sender, EventArgs e)
        {
            //név és tb szám lekérés
            FileStream fnevcim = new FileStream("nev_tb.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)
            {
                string nev2 = szemelyek[q].nev;
                string nevtbadatok1 = szemelyek[q].tajszam;

                if (nev2 != null)
                {

                    fajlbairo1.WriteLine("{0}:\n{1}\n", "Név: " + nev2, "TB (taj)szám: " + nevtbadatok1);
                }
                else { break; }

            }
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és TB számokat kimenteni Gratulálok!");
 dbsz = 0;
        }



        private void button8_Click(object sender, EventArgs e)
        {
            //név és vezetői engedély szám lekérés
            FileStream fnevcim = new FileStream("nev_vezetoi_engedely_adatok.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)
            {
                string nev3 = szemelyek[q].nev;
                string vezetoiengedelysz = szemelyek[q].vezetoiengedelyszama;
                string ervenyessegikat = szemelyek[q].ervenyessegikategoria;
                string vezervenyesseg = szemelyek[q].ervenyessegiidovezeng;
                string ugyintezoi = szemelyek[q].ugyintezoiigazolvanyszama;

                if (nev3 != null)
                {

                    fajlbairo1.WriteLine("{0}:\n{1}:\n{2}:\n{3}:\n{4}\n", "Név" + nev3, "Vezetői engedély száma: " + vezetoiengedelysz, "Vez.eng.érvényességi kategóriák: " + ervenyessegikat, "Vez.eng.érvényessége: " + vezervenyesseg, "Ügyintézői száma: " + ugyintezoi);
                }
                else { break; }

            }
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és Vezetői engedély adatokat kimenteni Gratulálok!");
        }



        private void button5_Click(object sender, EventArgs e)
        {
            //név és adószám lekérés
            FileStream fnevcim = new FileStream("nev_adoszam.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)
            {
                string nev4 = szemelyek[q].nev;
                string adoazonosito = szemelyek[q].adoazonosito;

                if (nev4 != null)
                {

                    fajlbairo1.WriteLine("{0}:\n{1}\n", "Név: " + nev4, "Adóazonosító" + adoazonosito);
                }
                else { break; }
            }
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és Adószámokat kimenteni Gratulálok!");
        }



        private void button7_Click(object sender, EventArgs e)
        {
            //név és igazolványszám lekérés
            FileStream fnevcim = new FileStream("nev_igazolvanyszamok.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)
            {
                string nev5 = szemelyek[q].nev;
                string utlevelszama = szemelyek[q].utlevelsz;
                string szemigszam = szemelyek[q].szemelyiszam;
                string szolgigszama = szemelyek[q].szolgalatiigazolvanyszama;
                string vezetoiengszama = szemelyek[q].vezetoiengedelyszama;
                string ugyintezoiigszama = szemelyek[q].ugyintezoiigazolvanyszama;

                if (nev5 != null)
                {
                    fajlbairo1.Write("\n");
                fajlbairo1.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", "Név: " + nev5, "Útlevélszám: " + utlevelszama, "Személyiigazolvány szám: " + szemigszam, "Szolgálatiigazolvány szám: " + szolgigszama, "Vezetőiengedély szám: " + vezetoiengszama, "Ügyintézőiigazolvány szám: " + ugyintezoiigszama);
                }
                else { break; }

            }
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és Igazolvány számokat kimenteni Gratulálok!");
        }



        private void button10_Click(object sender, EventArgs e)

        {

            //név és fegyveradatok lekérés

            FileStream fnevcim = new FileStream("nev_fegyveradatok.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)
            {
                string nev5 = szemelyek[q].nev;
                string szolgfegyvtip = szemelyek[q].szolgalatifegyvertipusa;
                string szolgfegyversz = szemelyek[q].szolgalatifegyverszama;
                string szolgfegyverdbsz = szemelyek[q].szolgalatiloszerdarabsz;

                if (nev5 != null)
                {

                    fajlbairo1.WriteLine("{0}:\n{1}:\n{2}:\n{3}\n", "Neve: " + nev5, "Szolgálati fegyver típusa: " + szolgfegyvtip, "Szolgálati fegyver sorszáma: " + szolgfegyversz, "Szolgálati lőszer db száma: " + szolgfegyverdbsz);
                }
                else { break; }

            }
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és Fegyveradatokat kimenteni Gratulálok!");
        }


        private void button9_Click(object sender, EventArgs e)
        {

            //név és születési idő lekérés

            FileStream fnevcim = new FileStream("nev_szuletesiido.txt", FileMode.Create);
            StreamWriter fajlbairo1 = new StreamWriter(fnevcim, System.Text.Encoding.UTF8);
            for (int q = 0; q < szemelyek.Length; q++)
            {
                string nev6 = szemelyek[q].nev;
                string szulido = szemelyek[q].szuletesiido;

                if (nev6 != null)
                {

                    fajlbairo1.WriteLine("{0}:\n{1}\n", "Név: " + nev6, "Születési idő: " + szulido);

                }
                else { break; }

            }
            fajlbairo1.Close();
            fnevcim.Close();
            MessageBox.Show("Sikerült a Neveket és Születési adatokat kimenteni Gratulálok!");
        }


        // beépülő egéresemény, de használatom kívül mert nem kellett, de nem is törölhető mivel már a kódban benne van és hibát generál ha törlésre kerül.
        private void button4_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
        }


        // 4. es gomb színezése ha az egér rá megy
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Orange;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Khaki;

        }

        // 6. os gomb színezése ha az egér rá megy
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.Orange;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Khaki;
        }

        // 8. as gomb színezése ha az egér ra megy
        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.Orange;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Khaki;
        }

        // 5. ös gomb színezése ha az egér ra megy
        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Orange;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Khaki;
        }
        // 7. es gomb színezése ha az egér ra megy 
        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.Orange;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Khaki;
        }
        // 10. es gomb színezése ha az egér ra megy
        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.Orange;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Khaki;
        }

        // 9. es gomb színezése ha az egér rámegy
        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.Orange;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Khaki;
        }
        //11 .es gomb színezése ha az egér rámegy
        private void button11_Click(object sender, EventArgs e)
        {
     Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                button2.Enabled = true;
                MessageBox.Show("Nem választott TÖRÖLNI kívánt személyt!!!");
            }
            else
            {

                //nyilvántartott adat törlését végzi- be kell állítani a txt- helyét
                string path = @"C:/Users/Danyi László/Desktop/Nyilvántartási adatok/szemelyiNyilvantartas01/szemelyiNyilvantartas01/bin/Debug/nyilvantartas.txt";
                string word = Convert.ToString(comboBox1.SelectedItem);
                var oldLines = System.IO.File.ReadAllLines(path);
                var newLines = oldLines.Where(line => !line.Contains(word));
                System.IO.File.WriteAllLines(path, newLines);
                FileStream obj = new FileStream(path, FileMode.Append);

                obj.Close();
                MessageBox.Show("Sikerült kitörölni a kiválasztott " + comboBox1.Text + "  személyt az adatbázisból Gratulálok!");

                comboBox1.Items.Clear();
                comboBox2.Items.Clear();

                comboBox1.Text = "";
dbsz = 0;
                adatbetoltes();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //            this.Close();



            string message = "Most tényleg be akarod zárni a PROGRAMOT ;(?";
            string title = "Az alkalmazás bezárásának kísérlete:";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if ((textBox47.Text != "") && (textBox42.Text != "") && (textBox43.Text != "") && (textBox44.Text != "") && (textBox45.Text != "") && (textBox46.Text != "") && (textBox42.Text != comboBox3.Text))
            {
                try
                {
                    string ujszulo_nev = textBox47.Text;
                    string ujgyerek_nev = textBox42.Text;
                    string ujanyja_neve = textBox43.Text;
                    string ujszul_ido = textBox44.Text;
                    string ujtaj_sz = textBox45.Text;
                    string ujado_szam = textBox46.Text;

                    FileStream fnev3 = new FileStream("gyerek_nyilvantartas.txt", FileMode.Append);
                    StreamWriter fajlbairo3 = new StreamWriter(fnev3, System.Text.Encoding.UTF8);
                    fajlbairo3.WriteLine("{0};{1};{2};{3};{4};{5}",
                        ujszulo_nev, ujgyerek_nev, ujanyja_neve, ujszul_ido,
                        ujtaj_sz, ujado_szam);
                    fajlbairo3.Close();
                    fnev3.Close();
                    MessageBox.Show("Sikerült az adatbázisba felvinni a " + textBox42.Text + " nevű gyerekének adatait Gratulálok!");


                    comboBox3.Items.Clear();
                    comboBox3.Text = "";
 gyerekdbsz = 0;
                    gyerekadatbetoltes();

                }
                catch
                {

                }
                
            }

            else
            {
                if (comboBox3.Text.Length == 0 || comboBox3.Text != textBox42.Text)
                {
                    button13.Enabled = true;
                    MessageBox.Show("Nem választott TÖRÖLNI kívánt személyt!!!");
                }
                else
                {

                string path = @"C:/Users/Danyi László/Desktop/Nyilvántartási adatok/szemelyiNyilvantartas01/szemelyiNyilvantartas01/bin/Debug/gyerek_nyilvantartas.txt";
                string word = Convert.ToString(comboBox3.SelectedItem);
                var oldLines = System.IO.File.ReadAllLines(path);
                var newLines = oldLines.Where(line => !line.Contains(word));
                System.IO.File.WriteAllLines(path, newLines);
                FileStream obj = new FileStream(path, FileMode.Append);

                obj.Close();
                MessageBox.Show("ÖN adatmódosítást kezdeményezett, így elsőre törölni kellett  " + comboBox3.Text + "  adatait kérem mégegyszer nyomjon a mentésre a  módosítást követően, különben elvesznek az adatok!");

                comboBox3.Items.Clear();
                comboBox3.Text = "";
                comboBox4.Items.Clear();
 gyerekdbsz = 0;
                 gyerekadatbetoltes();
                    //                MessageBox.Show("Egy vagy több mező nincs kitöltve. Így nem vehetjük fel az adatokat. Kérem minden mezőt töltsön ki a sikeres felvitel végett.");

                }
            }
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // gyerekek adatainak lementése.
            FileStream fgyerekadatok1 = new FileStream("gyerekek.txt", FileMode.Create);
            StreamWriter fajlbairo4 = new StreamWriter(fgyerekadatok1, System.Text.Encoding.UTF8);
           for (int q = 0; q < gyerekdbsz; q++)
            {
                string szulo_neve = gyerekek[q].szulo_neve;
                string gyerekneve = gyerekek[q].gyerek_neve;
                string anyja_neve = gyerekek[q].anyja_neve;
                string szul_ido = gyerekek[q].szul_ido;
                string taj_sz = gyerekek[q].taj_sz;
                string ado_szam = gyerekek[q].ado_szam;

                if (szulo_neve !=null)
                {
                    fajlbairo4.WriteLine("{0}:\n{1}:\n{2}:\n{3}:\n{4}:\n{5}\n", "Szülő neve: " + szulo_neve, "Gyermek neve: " + gyerekneve, "Édesanyja neve: " + anyja_neve, "Gyermek születési ideje: " + szul_ido, "Gyermek TB száma : " + taj_sz, "Gyermek adószáma: " + ado_szam);
                }

            }
            fajlbairo4.Close();
            fgyerekadatok1.Close();
            MessageBox.Show("Sikerült a Gyermekek adatainak kimentése, Gratulálok!");
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            comboBox4.Items.Clear();
            gyerekdbsz = 0;
            gyerekadatbetoltes();
            
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Array.Copy(gyerekek, szulok, gyerekek.Length);

            List<string> nevek = new List<string>(50);
            
            int szamol = 0;
            for (int i = 0; i < gyerekek.Length; i++)
            {
                nevek[i] = gyerekek[i].szulo_neve;
                szamol++;
            }
            MessageBox.Show("Ez az"+szamol);

            */
        

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            //gyerekek adatainak módosítására kód!!

            string[] fajlbol9 = File.ReadAllLines("gyerek_nyilvantartas.txt");
            
            int szamolgyerek =0;
            for (int i = 0; i < fajlbol9.Length; i++)
            {
                string[] gyereksegedd = fajlbol9[i].Split(';');
                gyerekek[szamolgyerek].szulo_neve = gyereksegedd[0];
                gyerekek[szamolgyerek].gyerek_neve = gyereksegedd[1];
                gyerekek[szamolgyerek].anyja_neve = gyereksegedd[2];
                gyerekek[szamolgyerek].szul_ido = gyereksegedd[3];
                gyerekek[szamolgyerek].taj_sz = gyereksegedd[4];
                gyerekek[szamolgyerek].ado_szam = gyereksegedd[5];


                if(comboBox3.Text == gyerekek[szamolgyerek].gyerek_neve)
                {

                    textBox47.Text = gyerekek[szamolgyerek].szulo_neve;
                    textBox42.Text = gyerekek[szamolgyerek].gyerek_neve;
                    textBox43.Text = gyerekek[szamolgyerek].anyja_neve;
                    textBox44.Text = gyerekek[szamolgyerek].szul_ido;
                    textBox45.Text = gyerekek[szamolgyerek].taj_sz;
                    textBox46.Text = gyerekek[szamolgyerek].ado_szam;


                }
                szamolgyerek++;

            }
            

        }

            private void button12_Click(object sender, EventArgs e)
        {

            string[] fajlbol = File.ReadAllLines("nyilvantartas.txt");

            int dbszz = 0;
            for (int i = 0; i < fajlbol.Length; i++)
            {
                string[] seged = fajlbol[i].Split(';');
                szemelyek[dbszz].nev = seged[0];
                szemelyek[dbszz].szemelyazonosito = seged[1];
                szemelyek[dbszz].leanykorinev = seged[2];
                szemelyek[dbszz].szuletesihely = seged[3];
                szemelyek[dbszz].szuletesiido = seged[4];
                szemelyek[dbszz].anyjaneve = seged[5];
                szemelyek[dbszz].tajszam = seged[6];
                szemelyek[dbszz].adoazonosito = seged[7];
                //lakcímadatok
                szemelyek[dbszz].allandolakcim = seged[8];
                szemelyek[dbszz].vonalastelall = seged[9];
                szemelyek[dbszz].tartozkodasihely = seged[10];
                szemelyek[dbszz].vonalasteltart = seged[11];
                //lakcímkártya adatok
                szemelyek[dbszz].lakcimkartyaszama = seged[12];
                szemelyek[dbszz].kiallitasidolakcim = seged[13];
                //útlevél adatok
                szemelyek[dbszz].utlevelsz = seged[14];
                szemelyek[dbszz].utlevelervenyessegiido = seged[15];
                //személyigazolvány adatok
                szemelyek[dbszz].szemelyiszam = seged[16];
                szemelyek[dbszz].szemelyiervenyessegido = seged[17];
                //mobiltelefon adatok
                szemelyek[dbszz].szolgalatimobil = seged[18];
                szemelyek[dbszz].sajatmobil = seged[19];
                //munkaviszonnyal kapcsolatos adatok
                szemelyek[dbszz].munkaviszonykezdete = seged[20];
                szemelyek[dbszz].bmszolgalativiszony = seged[21];
                //szolgálati igazolvány jelvény pecsétnyomó
                szemelyek[dbszz].szolgalatiigazolvanyszama = seged[22];
                szemelyek[dbszz].szolgalatijelvenyszam = seged[23];
                szemelyek[dbszz].pecsetnyomoszama = seged[24];
                //fegyveradatok
                szemelyek[dbszz].szolgalatifegyvertipusa = seged[25];
                szemelyek[dbszz].szolgalatifegyverszama = seged[26];
                szemelyek[dbszz].szolgalatiloszerdarabsz = seged[27];
                //vezetői engedély, ügyintézői adatok
                szemelyek[dbszz].vezetoiengedelyszama = seged[28];
                szemelyek[dbszz].ervenyessegikategoria = seged[29];
                szemelyek[dbszz].ervenyessegiidovezeng = seged[30];
                szemelyek[dbszz].ugyintezoiigazolvanyszama = seged[31];
                szemelyek[dbszz].kiallitaskelte = seged[32];
                //idegennyyelvi tudás adatok
                szemelyek[dbszz].milyennyelv = seged[33];
                szemelyek[dbszz].nyelvismeretfoka = seged[34];
                szemelyek[dbszz].nyelvbizszama = seged[35];
                //tanulmányi adatok
                szemelyek[dbszz].legmagasabbiskvegzettseg = seged[36];
                szemelyek[dbszz].legiskvegzmegszerzeseve = seged[37];
                szemelyek[dbszz].rendorivegzettseg = seged[38];
                szemelyek[dbszz].rendvegzmegszeve = seged[39];
                szemelyek[dbszz].jelenlegitanulmanyok = seged[40];


                //                comboBox2.Items.Add(szemelyek[dbsz].nev);
                //                comboBox2.Sorted = comboBox2.Sorted = true;

                if (comboBox2.Text == szemelyek[dbszz].nev)
                {

                    textBox75.Text = szemelyek[dbszz].nev;
                    textBox73.Text = szemelyek[dbszz].szemelyazonosito;
                    textBox72.Text = szemelyek[dbszz].leanykorinev;
                    textBox74.Text = szemelyek[dbszz].szuletesihely;
                    textBox71.Text = szemelyek[dbszz].szuletesiido;
                    textBox70.Text = szemelyek[dbszz].anyjaneve;
                    textBox69.Text = szemelyek[dbszz].tajszam;
                    textBox68.Text = szemelyek[dbszz].adoazonosito;
                    //lakcimadatok
                    textBox9.Text = szemelyek[dbszz].allandolakcim;
                    textBox10.Text = szemelyek[dbszz].vonalastelall;
                    textBox11.Text = szemelyek[dbszz].tartozkodasihely;
                    textBox12.Text = szemelyek[dbszz].vonalasteltart;
                    //lakcikartyaadatok
                    textBox20.Text = szemelyek[dbszz].lakcimkartyaszama;
                    textBox57.Text = szemelyek[dbszz].kiallitasidolakcim;
                    //utleveladatok
                    textBox16.Text = szemelyek[dbszz].utlevelsz;
                    textBox17.Text = szemelyek[dbszz].utlevelervenyessegiido;
                    //szemelyigazolvany adatok
                    textBox18.Text = szemelyek[dbszz].szemelyiszam;
                    textBox19.Text = szemelyek[dbszz].szemelyiervenyessegido;
                    //mobiltelefon adatok
                    textBox8.Text = szemelyek[dbszz].szolgalatimobil;
                    textBox15.Text = szemelyek[dbszz].sajatmobil;
                    //munkaviszonnyal kapcsolatos adatok
                    textBox26.Text = szemelyek[dbszz].munkaviszonykezdete;
                    textBox27.Text = szemelyek[dbszz].bmszolgalativiszony;
                    //szolgálati igazolvány,jelvény, pecsét
                    textBox28.Text = szemelyek[dbszz].szolgalatiigazolvanyszama;
                    textBox29.Text = szemelyek[dbszz].szolgalatijelvenyszam;
                    textBox30.Text = szemelyek[dbszz].pecsetnyomoszama;
                    //fegyveradatok
                    textBox31.Text = szemelyek[dbszz].szolgalatifegyverszama;
                    textBox32.Text = szemelyek[dbszz].szolgalatifegyvertipusa;
                    textBox33.Text = szemelyek[dbszz].szolgalatiloszerdarabsz;
                    //vezetői engedély,ügyintézői adatok
                    textBox21.Text = szemelyek[dbszz].vezetoiengedelyszama;
                    textBox22.Text = szemelyek[dbszz].ervenyessegikategoria;
                    textBox23.Text = szemelyek[dbszz].ervenyessegiidovezeng;
                    textBox24.Text = szemelyek[dbszz].ugyintezoiigazolvanyszama;
                    textBox25.Text = szemelyek[dbszz].kiallitaskelte;
                    //idegen nyelvi tudás
                    textBox5.Text = szemelyek[dbszz].milyennyelv;
                    textBox6.Text = szemelyek[dbszz].nyelvismeretfoka;
                    textBox7.Text = szemelyek[dbszz].nyelvbizszama;
                    //tanulmanyi adatok
                    textBox34.Text = szemelyek[dbszz].legmagasabbiskvegzettseg;
                    textBox35.Text = szemelyek[dbszz].legiskvegzmegszerzeseve;
                    textBox36.Text = szemelyek[dbszz].rendorivegzettseg;
                    textBox37.Text = szemelyek[dbszz].rendvegzmegszeve;
                    textBox38.Text = szemelyek[dbszz].jelenlegitanulmanyok;


                }
                dbszz++;

            }










            if (comboBox2.Text.Length == 0)
            {
                button2.Enabled = true;
                MessageBox.Show("Nem választott MÓDOSÍTANI kívánt személyt!!!");
            }
            else
            {

            }
            }
    }
}
