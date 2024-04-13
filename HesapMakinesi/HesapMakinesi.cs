namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }
        double? gecmis = 0, sonuc, sayi;
        string sonsayi, islem;
        bool hareket;
        void Sayilar(string s)
        {
            hareket = true;
            if (sonsayi == "0")
                sonsayi = s;
            else
                sonsayi += s;
            txSonuc.Text = sonsayi;
            sayi = Convert.ToDouble(sonsayi);
        }

        void islemler(string i)
        {
            if (txGecmis.Text != "")
                islem = txGecmis.Text.Substring(txGecmis.Text.Length - 2, 2);
            else
                islem = i;

            if (gecmis != 0)
            {
                if (hareket == true)
                {
                    if (islem == " +")
                        sonuc = gecmis + sayi;
                    else if (islem == " -")
                        sonuc = gecmis - sayi;
                    else if (islem == " x")
                        sonuc = gecmis * sayi;
                    else if (islem == " ÷")
                        sonuc = gecmis / sayi;
                    hareket = false;
                }
            }
            else
            {
                if (sayi == null)
                    sayi = 0;
                sonuc = sayi;
            }
            if (islem == " =")
                islem = i;
            sonsayi = "0";
            gecmis = sonuc;
            txGecmis.Text = sonuc + i;
            txSonuc.Text = sonuc.ToString();
        }

        private void btnArtiEksi_Click(object sender, EventArgs e)
        {
            if (txSonuc.Text == "0" || txSonuc.Text == "")
                txSonuc.Text = "0";
            else
            {
                sonsayi = (Convert.ToDouble(txSonuc.Text) * -1).ToString();
                txSonuc.Text = sonsayi;
                sayi = Convert.ToDouble(sonsayi);
            }
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            bool _bool = txSonuc.Text.Contains(",");
            if (txSonuc.Text == "0" || txSonuc.Text == "")
                txSonuc.Text = "0";
            else
            {
                if (_bool != true)
                {
                    sonsayi += ",";
                    txSonuc.Text = sonsayi;
                    sayi = Convert.ToDouble(sonsayi);
                }
            }
        }

        private void btnSilTekRakam_Click(object sender, EventArgs e)
        {
            if (txGecmis.Text != "")
                islem = txGecmis.Text.Substring(txGecmis.Text.Length - 2, 2);

            if (txSonuc.Text == "0")
                txSonuc.Text = "0";
            else
            {
                if (islem == " =")
                {

                    txGecmis.Text = "";
                    gecmis = 0; sonuc = null; sayi = null;
                    sonsayi = "";
                    islem = "";
                    hareket = false;
                }
                else
                {
                    if (txSonuc.Text.Length > 1)
                        sonsayi = txSonuc.Text.Substring(0, txSonuc.TextLength - 1);
                    else sonsayi = "0";
                    txSonuc.Text = sonsayi;
                    sayi = Convert.ToDouble(sonsayi);
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txSonuc.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txSonuc.Text = "0";
            txGecmis.Text = "";
            gecmis = 0; sonuc = null; sayi = null;
            sonsayi = "";
            islem = "";
            hareket = false;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (islem == " +")
                sonuc = gecmis + sayi;
            else if (islem == " -")
                sonuc = gecmis - sayi;
            else if (islem == " x")
                sonuc = gecmis * sayi;
            else if (islem == " ÷")
                sonuc = gecmis / sayi;
            else
            {
                sonuc = sayi;
                gecmis = null;
            }

            sonsayi = "0";

            txGecmis.Text = gecmis + islem + sayi + " =";
            gecmis = sonuc;
            txSonuc.Text = sonuc.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            islemler(" +");
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            islemler(" -");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            islemler(" x");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            islemler(" ÷");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Sayilar("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Sayilar("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Sayilar("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Sayilar("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Sayilar("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Sayilar("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Sayilar("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Sayilar("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Sayilar("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Sayilar("0");
        }
    }
}
