using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = Playlist.SelectedIndex;

            switch (ind)
            {
                case 1:
                    Metadatos.Text = "Artista: Rels b  Album: Buenos genes  Año:2019  Genero:Hip Hop";
                    break;

                case 2:
                    Metadatos.Text = "Artista: Drefquila  Album: A fuego  Año:2017  Genero:Hip Hop";
                    break;

                case 3:
                    Metadatos.Text = "Artista: Maikel Delacalle  Album: Amuleto  Año:2019  Genero:Hip Hop";
                    break;

                case 4:
                    Metadatos.Text = "Artista: Avril Lavigne  Album: Rock N Roll  Año:2013  Genero:Rock";
                    break;

                case 5:
                    Metadatos.Text = "Artista: Rebeca Lane  Album: Poesía Venenosa  Año:2015  Genero:Hip Hop";
                    break;

                case 6:
                    Metadatos.Text = "Artista: Franco De Vita  Album: Stop  Año:2004  Genero:Pop";
                    break;

                case 7:
                    Metadatos.Text = "Artista: Camila  Album: Dejarte de Amar  Año:2004  Genero:Pop";
                    break;

                case 8:
                    Metadatos.Text = "Artista: Reik  Album: Reik  Año:2005  Genero:Pop";
                    break;

                case 9:
                    Metadatos.Text = "Artista: Silvia y Karmen  Album: Seremos Gigantes  Año:2017  Genero:Pop";
                    break;

                case 10:
                    Metadatos.Text = "Artista: Golden Ganga  Album: Musica Libre  Año:2010  Genero:Reggae";
                    break;
            }
            
        }

        private void Metadatos_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Playlist.Items.Count > 0)
                Playlist.SetSelected(1, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Playlist.SelectedIndex >1)
            {
                int count= Playlist.SelectedIndex;
                
                if (count != 0)
                {
                    count = Playlist.SelectedIndex;
                    Playlist.SelectedIndex = count - 1;
                }
               
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Playlist.SelectedIndex >0 && Playlist.SelectedIndex <= 9) 
            {
                               
                {
                    int count= Playlist.SelectedIndex;
                    Playlist.SelectedIndex = count + 1;

                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Playlist.Items.Count > 0)
                Playlist.SetSelected(10, true);

        }
    }
}
