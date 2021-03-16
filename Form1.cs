using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_Discord_source_Creator_by_Scary_Tiger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urltxturl = txtURL.Text + "index.php";
            bool result = CheckFile(txtURL.Text + "index.php");
            if (result)
            {
                MessageBox.Show("La tua licenza risulta attiva e scadrà tra TOT giorni.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2.show();
            }
            else
            {
                MessageBox.Show("Non hai una licenza attiva oppure l'utente non esiste o il link che hai inserito non è valido. Se non e' nessuno di questi problemi, potrebbe essere che sei stato bandito. Contatta Scary Tiger.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckFile(string URL)
        {
            try
            {

                HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
                request.Method = "HEAD";
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    return (response.StatusCode == HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {

                return false;
            }
    }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Per avere la licenza di questo software, devi entrare nel server discord di Scary Tiger, inserendo il codice seguente: GKP49SR , e chiedento in privato a Scary Tiger di darti la licenza. Poi lui ti darà un link dove lo devi copiare e incollare qui", "Come avere la licenza per questo software - Istruzioni -- Scary Tiger");
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
