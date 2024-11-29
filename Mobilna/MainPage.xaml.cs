using System.Reflection.Emit;

namespace lakierySklep
{
    public partial class MainPage : ContentPage
    {
        int wybranyProdukt = 0;
        int count = 0;
        double cenaKoszyk = 0;
        const int liczbaProduktow = 3;


        private void odswieszProdukt(string? zdjecie, string? odcien, string nazwa, double cena, string info, string Reklama = "")
        {
            imgProdukt.Source = $"{zdjecie}.jpg";
            lblNazwa.Text = nazwa;
            lblCena.Text = $"{cena} PLN";
            lblOpis.Text = info;
            if (String.IsNullOrEmpty(Reklama))
            {
                lblReklama.IsVisible = false ;
            }
            else
            {
                lblReklama.IsVisible = true ;
                lblReklama.Text = Reklama ;
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void onNastepnyClicked(object sender, EventArgs e)
        {
            wybranyProdukt++;
            if (wybranyProdukt >= liczbaProduktow)
                wybranyProdukt = 0;

            switch (wybranyProdukt)
            {
                case 0:
                    odswieszProdukt("f1", "fioletowy", "No Risk No story", 27.29, "Oszczedzasz 33%");
                    break;
                case 1:
                    odswieszProdukt("c1", "czerwony", "Alizee", 27.29, "Oszczędzasz 31%");
                    break;
                case 2:
                    odswieszProdukt("z4", "złoty", "White Sparkle", 9.99, "Oszczedzasz 76%", "PROMOCJA");
                    break;
                default:
                    break;
            }
        }

        private void onPoprzedniClicked(object sender, EventArgs e)
        {
            wybranyProdukt--;
            if (wybranyProdukt < 0)
                wybranyProdukt = 2;

            switch (wybranyProdukt)
            {
                case 0:
                    odswieszProdukt("f1", "fioletowy", "No Risk No story", 27.29, "Oszczedzasz 33%");
                    break;
                case 1:
                    odswieszProdukt("c1", "czerwony", "Alizee", 27.29, "Oszczędzasz 31%");
                    break;
                case 2:
                    odswieszProdukt("z4", "złoty", "White Sparkle", 9.99, "Oszczedzasz 76%", "PROMOCJA");
                    break;
                default:
                    break;
            }
        }

        private void onKoszykClicked(object sender, EventArgs e)
        {
            count++;

            switch (wybranyProdukt)
            {
                case 0:
                    cenaKoszyk += 27.29;
                    break;
                case 1:
                    cenaKoszyk += 27.29;
                    break;
                case 2:
                    cenaKoszyk += 9.99;
                    break;
                default:
                    break;
            }

            lblKoszykInfo.Text = $"w koszyku: {count} szt.\n {cenaKoszyk.ToString("0.00")} PLN";
        }


    }

}
