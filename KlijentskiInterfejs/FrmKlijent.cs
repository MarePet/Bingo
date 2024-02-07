using Domain;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KlijentskiInterfejs
{
    public partial class FrmKlijent : Form
    {
        BindingList<Pogadjanje> pogadjanja = new BindingList<Pogadjanje>();
        int pokusaji = 1;
        Igra igra = new Igra();
        public FrmKlijent()
        {
            InitializeComponent();
            dgvPogadjanja.DataSource = pogadjanja;
            Communication.Instance.Connect();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (pokusaji <= 6)
            {
                int[] cifre = new int[4];
                Pogadjanje p = new Pogadjanje();
                try
                {
                    cifre[0] = Int32.Parse(txtCifra1.Text);
                    cifre[1] = Int32.Parse(txtCifra2.Text);
                    cifre[2] = Int32.Parse(txtCifra3.Text);
                    cifre[3] = Int32.Parse(txtCifra4.Text);
                    p.Cifre = cifre;
                    p.Kombinacija = cifre[0] + "-" + cifre[1] + "-" + cifre[2] + "-" + cifre[3];

                    Request request = new Request(p, Operacija.Pogadjanje);
                    Communication.Instance.Send(request);
                    Response response = Communication.Instance.Recieve();

                    p = response.ResponseObject as Pogadjanje;

                    lblNaMestu.Text = p.BrojPogodjenihNaMestu.ToString();
                    lblNISUNaMestu.Text = p.BrojPogodjenihNISUNaMestu.ToString();
                    p.RB = dgvPogadjanja.Rows.Count;
                    pogadjanja.Add(p);
                    igra.Pogadjanja.Add(p);
                    dgvPogadjanja.DataSource = pogadjanja;

                    if (response.IsSuccesful)
                    {
                        MessageBox.Show("Uspesno ste pogodili kombinaciju!");
                        btnPosalji.Enabled = false;
                        igra.BrojPokusaja = pokusaji;
                        igra.Rezultat = "Pobedio";
                        igra.Datum = System.DateTime.Now;

                        request.RequestObject = igra;
                        request.Operacija = Operacija.KrajIgre;
                        Communication.Instance.Send(request);
                        return;
                    }

                    pokusaji++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Pogresan format cifre!");
                }
            }
            else
            {

                MessageBox.Show("Iskoristili ste sve pokusaje!");
                btnPosalji.Enabled = false;
                igra.BrojPokusaja = pokusaji;
                igra.Rezultat = "Izgubio";
                igra.Datum = DateTime.Now;

                Request request = new Request(igra, Operacija.KrajIgre);
                Communication.Instance.Send(request);

                return;
            }
        }
    }
}
