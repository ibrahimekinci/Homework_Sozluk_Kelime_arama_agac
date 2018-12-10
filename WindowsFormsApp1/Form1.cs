using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        protected static TreeHelper tree = new TreeHelper();
        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            //exe ile aynı yerde bulunan txt dosyası okunacak. WindowsFormsApp1\bin\Debug\sozluk.txt

            //txt deki tüm satırları string bir dizinin elamanı olarak okudum.

            var words = FileHelper.GetFileArray();

            if (words != null)
            {
                //okunanlar dizisi boş değilse onları ağaca ekliyorumm teker teker
                foreach (var item in words)
                {
                    tree.addNode(item);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ekrandaki listeyi boşalt
            listBox1.Items.Clear();


            var result = tree.GetWords(textBox1.Text);
            if (result != null)
            {
                //sonuçları ekrana yaz
                foreach (var item in result)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
    }
}
