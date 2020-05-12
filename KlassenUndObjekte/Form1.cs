using KlassenUndObjekte.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassenUndObjekte
{
    public partial class Form1 : Form
    {
        List<Fahrzeug> Autos;
        public Form1()
        {
            InitializeComponent();
            Autos = new List<Fahrzeug>();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            M3 m3 = new M3();
            m3.Farbe = textBox1.Text;
            m3.HerstellungsWerk = textBox2.Text;
            m3.Listenpreis = float.Parse(textBox3.Text);

            Autos.Add(m3);
            listBox1.Items.Add(m3);
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            M3 selectedFahrzeug = (M3) listBox1.Items[listBox1.SelectedIndex];

            labelListboxFarbe.Text = selectedFahrzeug.Farbe;
            labelListboxHerstellungswerk.Text = selectedFahrzeug.HerstellungsWerk;
            label6.Text = selectedFahrzeug.Listenpreis.ToString();
        }
    }
}
