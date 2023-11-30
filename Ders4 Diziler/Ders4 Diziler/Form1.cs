namespace Ders4_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[4];
        string[] kelimeler = new string[2];
        private void Form1_Load(object sender, EventArgs e)
        {
            // lblelemanlar.Text = sayilar[1].ToString();
            sayilar[3] = 2;
            sayilar[2] = 5;
            sayilar[1] = 6;
            sayilar[0] = 78;
            kelimeler[0] = "youtube dersleri";
            kelimeler[1] = "Abone ol:)";
            //lblelemanlar.Text=  sayilar[sayilar.Length - 1].ToString();
            sayilar[sayilar.Length - 1] = 45;
            lblelemanlar.Text = sayilar[sayilar.Length - 1].ToString();
            //lblelemanlar.Text = "1.sayı: "+sayilar[0].ToString()+" 2.sayı: "+sayilar[3].ToString();
        }
    }
}
