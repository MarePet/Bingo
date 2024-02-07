using DatabaseBroker;
using Domain;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FrmServer
{
    public partial class FormServer : Form
    {
        private Server server = new Server();
        bool stop = false;
        Thread randomize;
        Igra igra = new Igra();
        int[] dobitnaKombinacija;
        public FormServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnSacuvaj.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stop = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            randomize = new Thread(Randomize);
            randomize.Start();
            randomize.IsBackground = true;
        }

        private void Randomize()
        {
            Random r = new Random();
            while (!stop)
            {
                Thread.Sleep(2000);
                Invoke(new Action(() =>
                {
                    lblCifra1.Text = r.Next(0, 6).ToString();
                    lblCifra2.Text = r.Next(0, 6).ToString();
                    lblCifra3.Text = r.Next(0, 6).ToString();
                    lblCifra4.Text = r.Next(0, 6).ToString();
                }));
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            btnPokreni.Enabled = false;

            server.Start();
            Thread serverskaNit = new Thread(server.HandleClients);
            serverskaNit.Start();

            dobitnaKombinacija = new int[4];
            dobitnaKombinacija[0] = Int32.Parse(lblCifra1.Text);
            dobitnaKombinacija[1] = Int32.Parse(lblCifra2.Text);
            dobitnaKombinacija[2] = Int32.Parse(lblCifra3.Text);
            dobitnaKombinacija[3] = Int32.Parse(lblCifra4.Text);

            server.DobitnaKombinacija = dobitnaKombinacija;

            Thread pobeda = new Thread(ListenWin);
            pobeda.Start();
            pobeda.IsBackground = true;
        }

        private void ListenWin()
        {
            while (true)
            {
                if (server.Win())
                {
                    Invoke(new Action(() => { btnSacuvaj.Enabled = true; }));
                    igra = server.Igra;
                    igra.ZadtataKombinacija = dobitnaKombinacija[0] + "-" + dobitnaKombinacija[1] + "-" + dobitnaKombinacija[2] + "-" + dobitnaKombinacija[3];
                    Thread.Sleep(int.MaxValue);
                    break;
                }
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Broker.Instance.SaveGame(igra))
            {
                MessageBox.Show("Uspesno cuvanje!");
                btnSacuvaj.Enabled = false;
            }
        }
    }
}
