using System;
using System.Windows.Forms;

namespace udpTSAR_CHAT
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public int localPort
        {
            get { return Int32.Parse(txtBaglanPort.Text); }
            set { txtBaglanPort.Text = value.ToString(); }
        }
        public string remoteIP
        {
            get { return txtKarsiIP.Text; }
            set { txtKarsiIP.Text = value; }
        }
        public int remotePort
        {
            get { return Int32.Parse(txtKarsiPort.Text); }
            set { txtKarsiPort.Text = value.ToString(); }
        }
        private void BtnConn_Click(object sender, EventArgs e)
        {
            VeriDepo veriDepo = new VeriDepo();
            if (!string.IsNullOrEmpty(txtBaglanPort.Text)
                && !string.IsNullOrEmpty(txtKarsiPort.Text)
                && !string.IsNullOrEmpty(txtKarsiIP.Text))
            {
                if (txtBaglanPort.Text == txtKarsiPort.Text)
                {
                    MessageBox.Show("Bağlanmak istediğiniz port ile karşı taraftaki port aynı olmamalı!","Hata!");
                }
                else
                {
                    localPort = Int32.Parse(txtBaglanPort.Text);
                    remoteIP = txtKarsiIP.Text;
                    remotePort = Int32.Parse(txtKarsiPort.Text);
                    MessageBox.Show( $" Bağlanılan port bilgileri:  \n " +
                                    $" Bağlanılan Port : {localPort} " +
                                    $" Karşı IP: {remoteIP} " +
                                    $" Karşı Port: {remotePort} ", "Başarılı!");
                    udpTsar Tsar = new udpTsar();
                    Tsar.Show();
                    this.Hide();
                }                 
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz ve doğru girin", "Hata!");
            }
        }
    }
    public class VeriDepo
    {
        public int baglanPort;
        public string karsiIP;
        public int karsiPort;
    }
}
