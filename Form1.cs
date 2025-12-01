namespace WinFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bom oyunu
        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic, bitis,bolen;
            baslangic = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);
            bolen = Convert.ToInt32(textBox3.Text);
            for(int i=baslangic;i<=bitis;i++)
            {
                if(i%bolen==0)
                {
                    label4.Text += "Bom=" + i.ToString()+"\n";//"\n"= alt satıra geçmemizi sağlar
                }
                else
                {
                    label4.Text +=  i.ToString()+"\n";
                }
            }
        }
    }
}
/*
kodun mantığı=
Tabii ki! Verdiğiniz kod parçasının mantığını daha detaylı bir şekilde açıklayayım. 
Bu kod, bir Windows Forms uygulamasında kullanıcıdan alınan başlangıç ve bitiş değerleri arasında belirli bir bölene göre sayıları kontrol eder 
Ve bu sayıları bir etiket (label4) üzerinde gösterir. 
İşte kodun mantığı:

Kodun Tamamı:
private void button1_Click(object sender, EventArgs e)
{
    int baslangic, bitis, bolen;
    baslangic = Convert.ToInt32(textBox1.Text);
    bitis = Convert.ToInt32(textBox2.Text);
    bolen = Convert.ToInt32(textBox3.Text);
    
    for (int i = baslangic; i <= bitis; i++)
    {
        if (i % bolen == 0)
        {
            label4.Text += "Bom=" + i.ToString() + "\n"; // "\n" = alt satıra geçmemizi sağlar
        }
        else
        {
            label4.Text += i.ToString() + "\n";
        }
    }
}
Adım Adım Açıklama:

Değişken Tanımlama:
int baslangic, bitis, bolen;
baslangic, bitis, ve bolen adında üç tam sayı değişkeni tanımlanır. Bu değişkenler, kullanıcıdan alınan değerleri saklamak için 
kullanılacaktır.

Kullanıcı Girdilerini Alma:
baslangic = Convert.ToInt32(textBox1.Text);
bitis = Convert.ToInt32(textBox2.Text);
bolen = Convert.ToInt32(textBox3.Text);
textBox1, textBox2, ve textBox3 metin kutularından kullanıcıdan alınan değerler, 
Convert.ToInt32 ile tam sayıya dönüştürülerek baslangic, bitis, ve bolen değişkenlerine atanır.
Bu, döngünün hangi aralıkta çalışacağını ve hangi sayıya göre kontrol yapılacağını belirler.

Döngü Başlatma:
for (int i = baslangic; i <= bitis; i++)
for döngüsü, i değişkenini baslangic değerinden başlatır ve bitis değerine kadar (bitiş dahil) devam eder. 
Bu döngü, belirtilen aralıktaki her bir sayıyı kontrol etmek için kullanılır.

Bölme Kontrolü:
if (i % bolen == 0)
if ifadesi, i sayısının bolen ile tam bölünüp bölünmediğini kontrol eder. 
Eğer i sayısı bolen ile tam bölünüyorsa (kalan 0 ise), bu durumda "Bom" yazılacak.

"Bom" Yazma:
label4.Text += "Bom=" + i.ToString() + "\n"; // "\n" ifadesi, metin kutusuna yeni bir satır ekler.
Eğer i sayısı bolen ile tam bölünüyorsa kalan 0 ise, label4 etiketine "Bom=" ifadesi ve i sayısı yazılır.
Bu, bölünebilen sayılar için bir gösterimdir.

Diğer Sayıları Yazma:
else
{
    label4.Text += i.ToString() + "\n";
}
Eğer i sayısı bolen ile tam bölünmüyorsa, bu durumda sadece i sayısı label4 etiketine yazılır.
Yani, bölünemeyen sayılar burada gösterilir. Yine "\n" ifadesi, metin kutusuna yeni bir satır ekler.
// "!=" Bu işaret "eşit değil" alnlamına  gelir.
Örnek Senaryo:
Diyelim ki kullanıcı şu değerleri girdi:
textBox1: 10 (başlangıç)
textBox2: 20 (bitiş)
textBox3: 3 (bölme)
Döngü şu şekilde çalışır:
i = 10:
10 % 3 != 0 → "10" yazılır.
i = 11:
11 % 3 != 0 → "11" yazılır.
i = 12:
12 % 3 == 0 → "BOM=12" yazılır.
i = 13:
13 % 3 != 0 → "13" yazılır.
i = 14:
14 % 3 != 0 → "14" yazılır.
i = 15:
15 % 3 == 0 → "BOM=15" yazılır.
i = 16:
16 % 3 != 0 → "16" yazılır.
i = 17:
17 % 3 != 0 → "17" yazılır.
i = 18:
18 % 3 == 0 → "BOM=18" yazılır.
i = 19:
19 % 3 != 0 → "19" yazılır.
i = 20:
20 % 3 != 0 → "20" yazılır.
Sonuç;
Döngü tamamlandığında, label4 etiketinin içeriği şu şekilde olacaktır:
10
11
Bom=12
13
14
Bom=15
16
17
Bom=18
19
20
Özet:
Kodun Amacı: Kullanıcıdan alınan başlangıç ve bitiş değerleri arasında, 
belirli bir bölene (kullanıcının girdiği değer) göre sayıları kontrol etmek ve bu sayıları bir etiket üzerinde göstermek.
Bölme Kontrolü: E2ğer sayı belirtilen bölene tam bölünüyorsa "Bom" ifadesi ile birlikte yazılır, aksi takdirde sayı kendisi yazılır.
Sonuç: Kullanıcı, belirli bir aralıkta hangi sayıların belirtilen bölene tam bölündüğünü ve hangilerinin bölünmediğini görebilir.
*/