using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Album> albums = new List<Album>();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();

            string path = @"C:\Users\TEB\Downloads\pliki2\Data.txt";
            StreamReader stream = new StreamReader(path, Encoding.UTF8, true);

            while (!stream.EndOfStream)
            {
                albums.Add(new Album()
                {
                    artist = stream.ReadLine(),
                    album = stream.ReadLine(),
                    songNumber = stream.ReadLine(),
                    year = stream.ReadLine(),
                    downloadNumber = int.Parse(stream.ReadLine()),
                });
                stream.ReadLine();
            }
            stream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            albums[counter].downloadNumber++;
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter > 0)
            {
                counter--;
            }
            else
            {
                counter = albums.Count - 1;
            }
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter < albums.Count - 1)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            display();
        }
        public void display()
        {
            label1.Text = albums[counter].artist;
            label2.Text = albums[counter].album;
            label3.Text = albums[counter].songNumber;
            label4.Text = albums[counter].year;
            label5.Text = albums[counter].downloadNumber.ToString();
        }
    }
    public class Album
    {
        public string artist { get; set; }
        public string album { get; set; }
        public string songNumber { get; set; }
        public string year { get; set; }
        public int downloadNumber { get; set; }

    }
}
