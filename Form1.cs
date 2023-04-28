using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Reproductor01
{
    public partial class Form1 : Form
    {
        ListSong lista = new ListSong();
        string directorioMP3 = "";
        Cancion song = new Cancion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.FileName = "Seleccione una canción";
            abrir.Filter = "Archivo mp3|*.mp3|Archivo wav|*.wav|Archivo MP4|*.MP4|Todos los Archivos|*.*";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            abrir.FilterIndex = 1;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                directorioMP3 = abrir.FileName;

                TagLib.File tags = TagLib.File.Create(directorioMP3);

                song.Titulo = nombre.Text = tags.Tag.Title;
                song.Artista = artista.Text = tags.Tag.JoinedPerformers;
                song.Directorio = url.Text = directorioMP3;
                lista.insertar(song);

                listBox1.Items.Add(song.Titulo);
                

            }

        }

        
        //public void AddSong(string name, string artist, string url)
        //{
        //    Datos.media.NextSong(name, artist, url);
        //}

        private void btnanterior_Click(object sender, EventArgs e)
        {
            //lista.RecorrerLista();
        }
    }
}