namespace bekeszabolcsDoga11._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kilepes.Click += Kilepes_Click;
            piroslbl.Click += piroslbl_Click;
            zoldlbl.Click += zoldlbl_Click;
            keklbl.Click += keklbl_Click;
            alaph.Click += alaph_Click;
            btn1.Click += btn1_Click;
            kivonas.Click += kivonas_Click;
            osszeadas.Click += osszeadas_Click;
            szorzas.Click += szorzas_Click;
            osztas.Click += osztas_Click;   
        }



        private void piroslbl_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void zoldlbl_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Lime;
        }

        private void keklbl_Click(object? sender, EventArgs e)
        {
            BackColor = Color.RoyalBlue;
        }

        private void alaph_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Kilepes_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object? sender, EventArgs e)
        {
            string vmi = $"Szia {textB1.Text}";
            lbl2.Text = vmi;
        }

        private void osszeadas_Click(object? sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(elso.Text);
            b = double.Parse(masodik.Text);
            c = a + b;
            eredmeny.Text = c.ToString();
        }

        private void kivonas_Click(object? sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(elso.Text);
            b = double.Parse(masodik.Text);
            c = a - b;
            eredmeny.Text = c.ToString();
        }

        private void szorzas_Click(object? sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(elso.Text);
            b = double.Parse(masodik.Text);
            c = a * b;
            eredmeny.Text = c.ToString();
        }

        private void osztas_Click(object? sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(elso.Text);
            b = double.Parse(masodik.Text);
            c = a / b;
            
            eredmeny.Text = c.ToString();
        }
    }
}