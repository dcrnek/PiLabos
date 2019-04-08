using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int pocetnoStanje = 0;
        private int brojTjedana = 0;
        private int brojStanovcnika = 0;
        private int brojacGodina = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            Izracun();

        }





        private void Izracun()
        {
            
            if (BrojRodBox.Text != "" && BrojPreminulihBox.Text != "" && PocetnoStanje.Text != "" && BrojIseljenih.Text != "" && BrojUseljenihBox.Text != "")
            {
                brojStanovcnika = int.Parse(PocetnoStanje.Text);
                brojacGodina = 0;
                KretanjeBox.Items.Clear();
                do
                {
                    
                    brojStanovcnika = brojStanovcnika + int.Parse(BrojRodBox.Text);
                    brojStanovcnika = brojStanovcnika - int.Parse(BrojPreminulihBox.Text);
                    for (int i = 0; i < 48; i++)
                    {
                        brojStanovcnika = brojStanovcnika + int.Parse(BrojUseljenihBox.Text);
                        brojStanovcnika = brojStanovcnika - int.Parse(BrojIseljenih.Text);

                    }
                    brojacGodina++;
                    if (brojStanovcnika <= 0)
                    {
                        ObavijestBox.ForeColor = Color.Red;
                        ObavijestBox.Text = string.Format("Nestalo je stanovnistvo u {0}. godini.", brojacGodina);
                    }
                    else
                    {
                        
                        KretanjeBox.Items.Add(string.Format("Broj stanovnika za {0}. Godinu: {1}", brojacGodina, brojStanovcnika));
                    }
                    
                } while (brojStanovcnika > 0);
            }
            
        }

        private void BrojRodBox_TextChanged(object sender, EventArgs e)
        {
            Izracun();
        }

        private void PocetnoStanje_TextChanged(object sender, EventArgs e)
        {
            Izracun();
        }

        private void BrojPreminulihBox_TextChanged(object sender, EventArgs e)
        {
            Izracun();
        }

        private void BrojIseljenih_TextChanged(object sender, EventArgs e)
        {
            Izracun();
        }

        private void BrojUseljenihBox_TextChanged(object sender, EventArgs e)
        {
            Izracun();
        }
    }
}
