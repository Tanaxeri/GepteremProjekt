using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepteremProjekt
{
    public partial class GepteremProjekt : Form
    {
        PetrikLajosSzg pl = new PetrikLajosSzg("petrikgepek.txt");
        int Gepteremszam = 0;
        int kepmer = 45;
        List<Image> Gepteremkep = new List<Image> { Image.FromFile(@"Kepek\Pont0.jpg"), Image.FromFile(@"Kepek\Pont1.jpg"), Image.FromFile(@"Kepek\Pont2.jpg"), Image.FromFile(@"Kepek\Pont3.jpg") };
        public GepteremProjekt()
        {
            InitializeComponent();
        }

        private void BalGomb_Click(object sender, EventArgs e)
        {

            Gepteremszam = --Gepteremszam < 0 ? pl.Geptermek.Count - 1 : Gepteremszam;
            TeremFriss();

        }

        private void JobbGomb_Click(object sender, EventArgs e)
        {

            Gepteremszam = ++Gepteremszam > pl.Geptermek.Count - 1 ? 0 : Gepteremszam;
            TeremFriss();

        }

        private void MentesGomb_Click(object sender, EventArgs e)
        {

            try
            {
                File.Copy("petrikgepek.txt", "petrikgepek.bak", true);
                using (StreamWriter sw = new StreamWriter("petrikgepek.txt"))
                {

                    foreach (Gepterem item in pl.Geptermek)
                    {

                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.SorDb, item.HelyDb));
                        for (int i = 0; i < item.SorDb; i++)
                        {

                            string[] sor = new string[item.HelyDb];
                            
                            for (int j = 0; j < item.HelyDb-1; j++)
                            {

                                sor[j] = item.Ertekeles[i, j].ToString();

                            }

                            sw.WriteLine(string.Join(";",sor));

                        }

                        sw.WriteLine();

                    }

                    MessageBox.Show("A mentés sikeres!");

                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\nA mentés sikertelen!");
                return;
            }
            
        }

        private void GepteremProjekt_Load(object sender, EventArgs e)
        {
            TeremFriss();
        }

        void TeremFriss()
        {

            this.Text = $"{pl.Geptermek[Gepteremszam].Nev} ({pl.Geptermek[Gepteremszam].Atlag().ToString("0.00")}) ";
            TeremNevSzemely.BackgroundImage = Image.FromFile(@"Kepek\" + pl.Geptermek[Gepteremszam].Nev.Split()[0] + ".jpg");
            TeremNevSzemely.BackgroundImageLayout = ImageLayout.Stretch;
            TeremPanel.Controls.Clear();
            for (int i = 0; i < pl.Geptermek[Gepteremszam].SorDb; i++)
            {

                for (int j = 0; j < pl.Geptermek[Gepteremszam].HelyDb; j++)
                {

                    PictureBox ter = new PictureBox();
                    ter.Image = Gepteremkep[pl.Geptermek[Gepteremszam].Ertekeles[i, j]];
                    ter.SetBounds(j * kepmer, i * kepmer, kepmer, kepmer);
                    ter.SizeMode = PictureBoxSizeMode.StretchImage;
                    ter.Padding = new Padding(2);
                    int sor = i; int hely = j;
                    ter.Click += (o, e) =>
                    {

                        switch (pl.Geptermek[Gepteremszam].Ertekeles[sor, hely])
                        {

                            case 1:
                                pl.Geptermek[Gepteremszam].Ertekeles[sor, hely] = 2;
                                ter.Image = Gepteremkep[pl.Geptermek[Gepteremszam].Ertekeles[sor, hely]];
                                break;
                            case 2:
                                pl.Geptermek[Gepteremszam].Ertekeles[sor, hely] = 3;
                                ter.Image = Gepteremkep[pl.Geptermek[Gepteremszam].Ertekeles[sor, hely]];
                                break;
                            case 3:
                                pl.Geptermek[Gepteremszam].Ertekeles[sor, hely] = 1;
                                ter.Image = Gepteremkep[pl.Geptermek[Gepteremszam].Ertekeles[sor, hely]];
                                break;
                            default:
                                MessageBox.Show("Ezen a helyen nem ült senki!");
                                break;

                        }

                        this.Text = $"{pl.Geptermek[Gepteremszam].Nev} ({pl.Geptermek[Gepteremszam].Atlag().ToString("0.00")})";

                    };

                    TeremPanel.Controls.Add(ter);

                }



            }


        }
    }
}
