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

namespace LoL_Setting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do You Really Want to Exite??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://throwbin.io/U8KfVLB");

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string initialPath = "";
            bool allow = false;



            if (Directory.Exists("C:/Riot Games"))
            {
                initialPath = "C:/Riot Games";
                
                allow = true;
            }
            else if (Directory.Exists("E:/Riot Games"))
            {
                
                initialPath = "E:/Riot Games";
                allow = true;
            }
            else if (Directory.Exists("D:/Riot Games"))
            {
                
                initialPath = "D:/Riot Games";
                allow = true;
            }
            else
            {
                MessageBox.Show("wa zpi tadir l file f c ola e ola d");
            }






            if (allow)
            {


                //<game.cfg>
                string gameCfg;
                if (File.Exists(initialPath + "/League of Legends/Config/game.cfg"))
                {
                    //read
                    FileStream Rfs = new FileStream(initialPath + "/League of Legends/Config/game.cfg", FileMode.Open);
                    StreamReader sr = new StreamReader(Rfs);
                    gameCfg = sr.ReadToEnd();
                    sr.Close(); Rfs.Close();


                    //write
                    FileStream Wfs = new FileStream("game.cfg", FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(Wfs);
                    sw.Write(gameCfg);
                    sw.Close(); Wfs.Close();
                    MessageBox.Show("Safi a zpi Bsahtek hadchi ra khdem mzn");
                }
                else
                {
                    MessageBox.Show("wa zpi hadchi ra makaynsh");
                }
                //</game.cfg>


                //------------------------------------------------------------------------------------


                //<PersistedSettings.json>
                string Persisted;
                if (File.Exists(initialPath + "/League of Legends/Config/PersistedSettings.json"))
                {
                    //read
                    FileStream Rfs1 = new FileStream(initialPath + "/League of Legends/Config/PersistedSettings.json", FileMode.Open);
                    StreamReader sr1 = new StreamReader(Rfs1);
                    Persisted = sr1.ReadToEnd();
                    sr1.Close(); Rfs1.Close();


                    //write
                    FileStream Wfs1 = new FileStream("PersistedSettings.json", FileMode.OpenOrCreate);
                    StreamWriter sw1 = new StreamWriter(Wfs1);
                    sw1.Write(Persisted);
                    sw1.Close(); Wfs1.Close();

                }
                else
                {
                    MessageBox.Show("wa zpi hadchi ra makaynsh");
                }
                //</PersistedSettings.json>


                //------------------------------------------------------------------------------------

                //<SettingsToPersist.json>
                string Persist;
                if (File.Exists(initialPath + "/League of Legends/DATA/CFG/defaults/SettingsToPersist.json"))
                {
                    //read
                    FileStream Rfs2 = new FileStream(initialPath + "/League of Legends/DATA/CFG/defaults/SettingsToPersist.json", FileMode.Open);
                    StreamReader sr2 = new StreamReader(Rfs2);
                    Persist = sr2.ReadToEnd();
                    sr2.Close(); Rfs2.Close();


                    //write
                    FileStream Wfs2 = new FileStream("SettingsToPersist.json", FileMode.OpenOrCreate);
                    StreamWriter sw2 = new StreamWriter(Wfs2);
                    sw2.Write(Persist);
                    sw2.Close(); Wfs2.Close();

                }
                else
                {
                    MessageBox.Show("wa zpi hadchi ra makaynsh");
                }
                label7.Text = "You're Importation \n Done Successfully";
                
                //</SettingsToPersist.json>
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string initialPath = "";
            bool allow = false;



            if (Directory.Exists("C:/Riot Games"))
            {
                initialPath = "C:/Riot Games";
                
                allow = true;
            }
            else if (Directory.Exists("E:/Riot Games"))
            {
                
                initialPath = "E:/Riot Games";
                allow = true;
            }
            else if (Directory.Exists("D:/Riot Games"))
            {
                
                initialPath = "D:/Riot Games";
                allow = true;
            }
            else
            {
                MessageBox.Show("wa zpi tadir l file f c ola e ola d");
            }

            if (allow)
            {
                //<game.cfg>
                string gameCfg;
                if (File.Exists(initialPath + "/League of Legends/Config/game.cfg"))
                {
                    //read
                    FileStream Rfs = new FileStream("game.cfg", FileMode.Open);
                    StreamReader sr = new StreamReader(Rfs);
                    gameCfg = sr.ReadToEnd();
                    sr.Close(); Rfs.Close();


                    //write
                    FileStream Wfs = new FileStream(initialPath + "/League of Legends/Config/game.cfg", FileMode.Open);
                    StreamWriter sw = new StreamWriter(Wfs);
                    sw.Write(gameCfg);
                    sw.Close(); Wfs.Close();
                    MessageBox.Show("Safi a zpi Bsahtek hadchi ra khdem mzn");
                }
                else
                {
                    MessageBox.Show("wa zpi hadchi ra makaynch");
                }
                //</game.cfg>

                //<SettingsToPersist.json>
                string Persist;
                if (File.Exists(initialPath + "/League of Legends/DATA/CFG/defaults/SettingsToPersist.json"))
                {
                    //read
                    FileStream Rfs = new FileStream("SettingsToPersist.json", FileMode.Open);
                    StreamReader sr = new StreamReader(Rfs);
                    Persist = sr.ReadToEnd();
                    sr.Close(); Rfs.Close();


                    //write
                    FileStream Wfs = new FileStream(initialPath + "/League of Legends/DATA/CFG/defaults/SettingsToPersist.json", FileMode.Open);
                    StreamWriter sw = new StreamWriter(Wfs);
                    sw.Write(Persist);
                    sw.Close(); Wfs.Close();

                }
                else
                {
                    MessageBox.Show("wa zpi hadchi ra makaynch");
                }
                //</SettingsToPersist.json>

                //<PersistedSettings.json>
                string Persisted;
                if (File.Exists(initialPath + "/League of Legends/Config/PersistedSettings.json"))
                {
                    //read
                    FileStream Rfs = new FileStream("PersistedSettings.json", FileMode.Open);
                    StreamReader sr = new StreamReader(Rfs);
                    Persisted = sr.ReadToEnd();
                    sr.Close(); Rfs.Close();


                    //write
                    FileStream Wfs = new FileStream(initialPath + "/League of Legends/Config/PersistedSettings.json", FileMode.Open);
                    StreamWriter sw = new StreamWriter(Wfs);
                    sw.Write(Persisted);
                    sw.Close(); Wfs.Close();

                }
                else
                {
                    MessageBox.Show("wa zpi hadchi ra makaynch");
                }
                label7.Text = "You're Exportation \n Done Successfully";
                //</PersistedSettings.json>
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labeltime.Text = datetime.ToString();
        }
    }
}
