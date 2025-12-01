namespace WinFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baþlangýc, bitis;
            baþlangýc = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);
            for (int i = baþlangýc; i <= bitis; i++)//þartlarýn for parantezinin içinde olup olmadýðýna dikkat et 
            {
                if (radioButton1.Checked == true)
                {
                    if (i % 3 == 0)
                    {
                        listBox1.Items.Add("3'e bölünenler=" + i.ToString() + "\n");// "+=" ifadesi 3'E bölünen tüm sayilari yazar
                                                                                    // ama "=" atama oörötörü sadece o andaki 3'e bölünen 
                                                                                    //son rakamý yazdýrý diyerlerini yazdýrý en sondaki 3'ebölünen rakamý 
                                                                                    //yazdýrýr bu yüzden tüm bölünen deðerleri yazdýrmak için "+=" ekleme 
                                                                                    //opörötörünü kullanmamýz gerekir.
                   }
                }
                else if (radioButton2.Checked == true && i % 5 == 0)
                {
                    label3.Text += "5'e bölünenler=" + i.ToString() + "\n";

                }
                else if (radioButton3.Checked == true)
                {
                    if (i % 8 == 0)
                    {
                        label4.Text += "8'e bölünenler=" + i.ToString() + "\n";

                    }



                }

            }
        }
        /*þu þekildede yazýlabilir kod
     int baþlangýc, bitis;
    baþlangýc = Convert.ToInt32(textBox1.Text);
    bitis = Convert.ToInt32(textBox2.Text);
    // buradaki fark edilmesi gereken þey þartlarýn hepsinde iç içe if ve iç içe else-if kullanýlmýþ yani tüm þartlar yan yana olmalýnýn aksine iç içe yazýlmýþ
    for (int i = baþlangýc; i <= bitis; i++)
    {
        if (radioButton1.Checked) // Eðer radioButton1 seçiliyse
        {
            if (i % 3 == 0) // 3'e bölünüp bölünmediðini kontrol et
            {
                listBox1.Items.Add("3'e bölünenler=" + i.ToString() + "\n");
            }
        }
        else if (radioButton2.Checked) // Eðer radioButton2 seçiliyse
        {
            if (i % 5 == 0) // 5'e bölünüp bölünmediðini kontrol et
            {
                label4.Text += "5'e bölünenler=" + i.ToString() + "\n";
            }
        }
        else if (radioButton3.Checked) // Eðer radioButton3 seçiliyse
        {
            if (i % 8 == 0) // 8'e bölünüp bölünmediðini kontrol et
            {
                label5.Text += "8'e bölünenler=" + i.ToString() + "\n";
            }
        }
    }
}
kodun mantýðý=
Anladým, kodun mantýðýný daha basit ve adým adým açýklamaya çalýþayým. Kodun her bir bölümünü daha anlaþýlýr bir þekilde ele alalým.

Kodun Genel Yapýsý
Kod, kullanýcýdan iki sayý alýr ve bu sayýlar arasýnda belirli bir bölene (3, 5 veya 8) tam bölünebilen sayýlarý bulur. 
Kullanýcý, hangi bölene göre kontrol yapýlacaðýný radyo butonlarý ile seçer.

Adým Adým Açýklama
Deðiþken Tanýmlama ve Kullanýcý Girdisi Alma:
int baþlangýc, bitis;
baþlangýc = Convert.ToInt32(textBox1.Text);
bitis = Convert.ToInt32(textBox2.Text);
baþlangýc ve bitis adýnda iki tam sayý deðiþkeni tanýmlanýr.
Kullanýcý, textBox1 ve textBox2 metin kutularýna iki sayý yazar.
 Bu sayýlar, Convert.ToInt32 ile tam sayýya dönüþtürülerek baþlangýc ve bitis deðiþkenlerine atanýr.
Bu, döngünün hangi aralýkta çalýþacaðýný belirler.

Döngü Baþlatma:
for (int i = baþlangýc; i <= bitis; i++)
for döngüsü, i deðiþkenini baþlangýc deðerinden baþlatýr ve bitis deðerine kadar (bitiþ dahil) devam eder.
Bu döngü, belirtilen aralýktaki her bir sayýyý kontrol etmek için kullanýlýr.

Radyo Butonlarý ile Koþul Kontrolü:

radioButton1 Kontrolü:
if (radioButton1.Checked) // Eðer radioButton1 seçiliyse
{
    if (i % 3 == 0) // 3'e bölünüp bölünmediðini kontrol et
    {
        label3.Text += "3'e bölünenler=" + i.ToString() + "\n";
    }
}
Eðer radioButton1 seçiliyse, i sayýsýnýn 3'e bölünüp bölünmediði kontrol edilir.
i % 3 == 0 ifadesi, i sayýsýnýn 3'e tam bölünüp bölünmediðini kontrol eder. Eðer tam bölünüyorsa, bu sayý label3 etiketine eklenir.
Yani, 3'e tam bölünen sayýlar burada gösterilir.

radioButton2 Kontrolü:
else if (radioButton2.Checked) // Eðer radioButton2 seçiliyse
{
    if (i % 5 == 0) // 5'e bölünüp bölünmediðini kontrol et
    {
        label4.Text += "5'e bölünenler=" + i.ToString() + "\n";
    }
}
Eðer radioButton2 seçiliyse, i sayýsýnýn 5'e bölünüp bölünmediði kontrol edilir.
Eðer i % 5 == 0 koþulu saðlanýyorsa, bu sayý label4 etiketine eklenir. Yani, 5'e tam bölünen sayýlar burada gösterilir.

radioButton3 Kontrolü:
else if (radioButton3.Checked) // Eðer radioButton3 seçiliyse
{
    if (i % 8 == 0) // 8'e bölünüp bölünmediðini kontrol et
    {
        label5.Text += "8'e bölünenler=" + i.ToString() + "\n";
    }
}
Eðer radioButton3 seçiliyse, i sayýsýnýn 8'e bölünüp bölünmediði kontrol edilir.
Eðer i % 8 == 0 koþulu saðlanýyorsa, bu sayý label5 etiketine eklenir. Yani, 8'e tam bölünen sayýlar burada gösterilir.

Örnek Senaryo:
Diyelim ki kullanýcý textBox1'e 10 ve textBox2'ye 30 yazdý. Kullanýcý radioButton1'i (3) seçtiðinde:
Kod, 10'dan 30'a kadar olan sayýlarý kontrol eder.
=10, 11, 12, 13, 14, 15, 16, 17, 18.............30 ve bu sayýlardan hangisi bölünüyorsa onu ekler

        */
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
