using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Threading;

namespace udpTSAR_CHAT
{
    public partial class udpTsar : Form
    {        
        public string alll;
        static UdpClient udpClient;
        static int localPort;
        static string remoteIP;
        static int remotePort;
        public string bilgiler
        {            
            get { return alll; }
            set { alll = value; }
        }        
        public udpTsar()
        {
            InitializeComponent();
            Thread GelenVerileriDinleme = new Thread(new ThreadStart(GelenMesaj));
            GelenVerileriDinleme.IsBackground = true;
            GelenVerileriDinleme.Start();
            Thread receiveThread = new Thread(new ThreadStart(GelenMesaj));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }        
        private void udpTsar_Load(object sender, EventArgs e)
        {            
            udpTsar Tsar = new udpTsar();
            udpClient = new UdpClient(localPort);
            Form1 form1 = new Form1();
            localPort= form1.localPort;
            remoteIP = form1.remoteIP;
            remotePort = form1.remotePort;
            lblBilgi.Text = $"Bağlanılan Port: {form1.localPort.ToString()}" +
                $"\nKarşı IP: {form1.remoteIP.ToString()}" +
                $"\nKarşı Port: {form1.remotePort.ToString()}";
        }
        private void Tsar_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient.Close();
        }
        public void SendMsg()
        {
            try
            {
                byte[] GidenVeri = Encoding.UTF8.GetBytes(txtGonderilecekMesaj.Text);
                udpClient.Send(GidenVeri, GidenVeri.Length, remoteIP, remotePort);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Gönderirken hata oluştu: {ex.Message}");
            }

            int i = 0;
            Label[] gidenMesajlar = new Label[1];
            gidenMesajlar[i] = new Label();

            gidenMesajlar[i].Text = txtGonderilecekMesaj.Text;

            gidenMesajlar[i].BackColor = Color.Transparent;
            gidenMesajlar[i].ForeColor = Color.White;
            gidenMesajlar[i].AutoSize = true;
            gidenMesajlar[i].Padding = new Padding(10);
            gidenMesajlar[i].Font = new Font("Arial", 11, FontStyle.Regular);

            Guna2Panel[] gidenMesajlarPanel = new Guna2Panel[1];
            gidenMesajlarPanel[i] = new Guna2Panel();
            tblChatArea.RowCount++;
            gidenMesajlarPanel[i].FillColor = Color.SeaGreen;
            gidenMesajlarPanel[i].Anchor = AnchorStyles.Top;
            gidenMesajlarPanel[i].Anchor = AnchorStyles.Right;
            gidenMesajlarPanel[i].Padding = new Padding(20);
            gidenMesajlarPanel[i].Margin = new Padding(20);
            gidenMesajlarPanel[i].BorderRadius = 15;
            gidenMesajlarPanel[i].AutoSize = true;
            gidenMesajlarPanel[i].Controls.Add(gidenMesajlar[i]);
            tblChatArea.Controls.Add(gidenMesajlarPanel[i], 1, tblChatArea.RowCount);
            tblChatArea.VerticalScroll.Value = tblChatArea.VerticalScroll.Maximum;
            tblChatArea.PerformLayout();
            txtGonderilecekMesaj.Text = string.Empty;
            i++;
        }
        
        public void GelenMesaj()
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            string gelenMesaj;

            while (true)
            {
                try
                {
                    byte[] GelenVeri = udpClient.Receive(ref remoteEndPoint);
                    gelenMesaj = Encoding.UTF8.GetString(GelenVeri);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Alırken hata oluştu: {ex.Message}");
                }
            }

            int i = 0;
            Label[] gelenMesajlar = new Label[1];
            gelenMesajlar[i] = new Label();
            gelenMesajlar[i].Text = $"{remoteEndPoint.Address}: {gelenMesaj}";
            gelenMesajlar[i].BackColor = Color.Transparent;
            gelenMesajlar[i].ForeColor = Color.White;
            gelenMesajlar[i].AutoSize = true;
            gelenMesajlar[i].Padding = new Padding(10);
            gelenMesajlar[i].Font = new Font("Arial", 11, FontStyle.Regular);

            Guna2Panel[] gelenMesajlarPanel = new Guna2Panel[1];
            gelenMesajlarPanel[i] = new Guna2Panel();
            tblChatArea.RowCount++;
            gelenMesajlarPanel[i].FillColor = Color.Brown;
            gelenMesajlarPanel[i].Anchor = AnchorStyles.Top;
            gelenMesajlarPanel[i].Anchor = AnchorStyles.Left;
            gelenMesajlarPanel[i].Padding = new Padding(20);
            gelenMesajlarPanel[i].Margin = new Padding(20);
            gelenMesajlarPanel[i].BorderRadius = 15;
            gelenMesajlarPanel[i].AutoSize = true;
            gelenMesajlarPanel[i].Controls.Add(gelenMesajlar[i]);
            tblChatArea.Controls.Add(gelenMesajlarPanel[i], 1, tblChatArea.RowCount);
            tblChatArea.VerticalScroll.Value = tblChatArea.VerticalScroll.Maximum;
            tblChatArea.PerformLayout();
            i++;
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            SendMsg();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
           GelenMesaj();
        }

        private void txtGonderilecekMesaj_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    return;
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    SendMsg();
                }
                
            }
        }
    }
}
