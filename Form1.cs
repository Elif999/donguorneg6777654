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
