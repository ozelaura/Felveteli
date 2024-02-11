using System;
using System.Windows;

namespace Felveteli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Felvetelizo felvetelizo;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Felvetelizo ujdiak) : this()
        {
            this.felvetelizo = ujdiak;

            this.Title = $"{felvetelizo.Nev} adataink rögzítése";
            txtNeve.Text = felvetelizo.Nev;
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string azonosito = txtOMazonosito.Text;
            if (azonosito.Length != 11)
            {
                MessageBox.Show("Nem megfelelő OM azonosító!");
                return;
            }

            // Minden karakter szám
            if (true) {}

            felvetelizo.OM_Azonosito = azonosito;

            string nev = txtNeve.Text;
            if (nev.)
            {
                
            }
            felvetelizo.Nev = nev;

            felvetelizo.ErtesitesiCim = txtCim.Text;




            felvetelizo.Email = txtEmail.Text;
            felvetelizo.SzuletesiDatum = Convert.ToDateTime(txtSzuletesiDatum.Text);

            try
            {
                this.felvetelizo.MatekPontok = int.Parse(txtMatematika.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem számformátum!");
                return;
            }
            if (felvetelizo.Matematika < 0 || felvetelizo > 50)
            {
                MessageBox.Show("Nem lehet ennyi pontja!");
                return;
            }

            this.felvetelizo.MagyarPontok = int.Parse(txtMagyar.Text);
            Close();
        }
    }
}
