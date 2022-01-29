using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordVirusDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse...";
            openFileDialog1.DefaultExt = "exe";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|Dll files (*.dll)|*.dll";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                fileDir.Text = openFileDialog1.FileName;
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    var line = sr.ReadToEnd();
                    string[] strings = line.Split('\r');
                    foreach (var sub in strings)
                    {
                        if (sub.Contains(".NETCoreApp"))
                            usingC.Text = "C# (.NET Core)";
                        if (sub.Contains(".NETFramework"))
                            usingC.Text = "C# (.NET Framework)";

                        if (sub.Contains("h\u0000t\u0000t\u0000p\u0000s\u0000:\u0000/\u0000/\u0000d\u0000i\u0000s\u0000c\u0000o\u0000r\u0000d"))
                        {
                            Regex getURL = new Regex("(?<=h\u0000t\u0000t\u0000p\u0000s\u0000:\u0000/\u0000/\u0000d\u0000i\u0000s\u0000c\u0000o\u0000r\u0000d).*?(?=\\\u0000\u0001)");
                            Match a = getURL.Match(sub);
                            Regex pattern = new Regex("\u0000");
                            string b = pattern.Replace(a.Value, "");
                            b = b.Replace(".com", "https://discord.com");
                            discordWH.Text = b;
                        }
                    }

                }
            }
        }
    }
}
