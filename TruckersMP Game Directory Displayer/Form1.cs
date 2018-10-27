using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckersMP_Game_Directory_Displayer
{
    public partial class Form1 : Form
    {
        public static RegistryKey TMP;
        public String Game = "";
        public void Print(object V)
        {


            Console.WriteLine(V);


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // HKEY_LOCAL_MACHINE\SOFTWARE\TruckersMP - here's TruckersMP registry entry!
            try
            {
                TMP = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TruckersMP",true);
                if (TMP != null || System.IO.Directory.Exists(TMP.GetValue("InstallDir").ToString()))
                {
                    
                    foreach (var item in TMP.GetValueNames())
                    {
                        if (item == "InstallDir") { GameSelect.SelectedIndex = 0;  break; }
                        else
                        {
                            if (TMP.GetValue(item).ToString() != null)
                            {
                                GameSelect.Items.Add(item.TrimStart("InstallLocation".ToCharArray()));
                            }
                            else
                            {
                                Print("Doesn't exist: " + item);
                            }
                        }
                        
                    }
                    //InstallDir.Text = TMP.GetValue("InstallLocationATS").ToString();
                    Game = GameSelect.SelectedItem.ToString();
                    var A = FileVersionInfo.GetVersionInfo(TMP.GetValue("InstallLocation" + Game).ToString() + "\\bin\\win_x64\\" + ((Game == "ATS") ? ("amtrucks.exe") : ("eurotrucks2.exe")));
                    InstallDir.Text = TMP.GetValue("InstallLocation" + Game).ToString();
                    GameVer.Text = A.FileVersion.Remove(A.FileVersion.IndexOf("(") - 1);
                }
                else
                {
                    //In case if TruckersMP is NOT installed properly....
                    MessageBox.Show("Couldn't load registry key. Make sure that TruckersMP is installed correctly. ");
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Couldn't load registry key. Make sure that TruckersMP is installed correctly.");
                Application.Exit();
            }
        }
        
        private void DirChange_Click(object sender, EventArgs e)
        {
            var A = FileVersionInfo.GetVersionInfo(TMP.GetValue("InstallLocation" + Game).ToString() + "\\bin\\win_x64\\" + ((Game == "ATS") ? ("amtrucks.exe") : ("eurotrucks2.exe")));
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Select the new directory for " + Game;
            folder.ShowDialog();
            try
            {

        
            if (System.IO.File.Exists(folder.SelectedPath.ToString() + "\\bin\\win_x64\\" + ((Game == "ATS") ? ("amtrucks.exe") : ("eurotrucks2.exe")))&& A.FileVersion != "")
            {
                Print("Selected directory...");
                    TMP.SetValue("InstallLocation" + Game, folder.SelectedPath);
                InstallDir.Text = TMP.GetValue("InstallLocation" + Game).ToString();
                GameVer.Text = A.FileVersion.Remove(A.FileVersion.IndexOf("(") - 1);
                MessageBox.Show("Saved the new directory for "+ Game);
            }
            else
            {
                Print("Selected invalid directory...");
                MessageBox.Show("User has cancelled the directory selection, or the directory is invalid.\nCurrent directory has not been changed.");
            }
            }
            catch 
            {
                Print("Selected invalid directory...");
                MessageBox.Show("User has cancelled the directory selection, or the directory is invalid.\nCurrent directory has not been changed.");

            }
        }

        private void GameSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            Game = GameSelect.SelectedItem.ToString();
            var A = FileVersionInfo.GetVersionInfo(TMP.GetValue("InstallLocation" + Game).ToString() + "\\bin\\win_x64\\" + ((Game == "ATS") ? ("amtrucks.exe") : ("eurotrucks2.exe")));
            InstallDir.Text = TMP.GetValue("InstallLocation" + Game).ToString();
            GameVer.Text = A.FileVersion.Remove(A.FileVersion.IndexOf("(") - 1);


        }
    }
}
