using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;
using Bunifu.UI.WinForms.Helpers.Transitions;
using RestSharp.Extensions;
using System.IO;

namespace API
{
    public partial class Form1 : Form
    {
        private JArray users = null;
        string key = "5a0b90db9f3cab4fa69f3e032cd8cada";
        string[] array = new string[] { "The Super Mario Bros. Movie",
            "Shazam! Fury of the Gods",
            "Avatar: The Way of Water",
            "Creed III",
            "65",
            "Murder Mystery 2",
            "Puss in Boots: The Last Wish",
            "The Pope's Exorcist",
            "John Wick: Chapter 4",
            "Cocaine Bear",
            "Momias",
            "길복순",
            "Winnie the Pooh: Blood and Honey",
            "Attack on Titan",
            "Infelices para Siempre",
            "Chupa",
            "Supercell",
            "The Park",
            "The Mummy Resurrection",
            "La Exorcista"};
        int[] index = new int[] { 502356,
            594767,
            76600,
            677179,
            700391,
            638974,
            315162,
            758323,
            603692,
            804150,
            816904,
            849869,
            980078,
            1033219,
            676841,
            736790,
            842945,
            1084225,
            984105,
            1023313};
        public Form1()
        {
            InitializeComponent();
        }
        void getData()
        {
            if (comboBox1.SelectedItem != null)
            {
                using (WebClient web = new WebClient())
                {
                    int id = index[comboBox1.SelectedIndex];
                    string url = string.Format("https://api.themoviedb.org/3/movie/" + id.ToString() + "?api_key=5a0b90db9f3cab4fa69f3e032cd8cada");
                    textBox.Text = url;
                    var json = web.DownloadString(url);
                    /*MessageBox.Show(json);*/
                    Data.Rootobject data = JsonConvert.DeserializeObject<Data.Rootobject>(json);
                    movieName.Text = data.original_title.ToString();
                    movieLanguage.Text = data.original_language.ToString();
                    movieRelease.Text = data.release_date.ToString();
                    movieVoteAverage.Text = data.vote_average.ToString();
                    movieVoteCount.Text = data.vote_count.ToString();
                    string imageUrl = "https://image.tmdb.org/t/p/w500/";
                    ImageList img = new ImageList();
                    WebClient w = new WebClient();
                    byte[] imageByte = w.DownloadData(imageUrl + data.poster_path);
                    MemoryStream stream = new MemoryStream(imageByte);
                    Image im = Image.FromStream(stream);
                    img.Images.Add(im);
                    img.ImageSize = new Size(230, 230);
                    listView.Items.Add("", 0);
                    listView.LargeImageList = img;
                }
            }
            else
            {
                MessageBox.Show("Please choose movie");
            }
        }
        private void find_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
