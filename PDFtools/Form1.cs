using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GS4Net;


namespace PDFtools
{
    public partial class Form1 : Form
    {
        private string optionParameter = "annot remove ";

        public Form1()
        {
            InitializeComponent();


            //this.Text = "PDFtools v2022 :: Unlock/Remove annot";
            this.MaximizeBox = false;
            this.AllowDrop = true;
            this.DragDrop += (s, e) =>
            {
            };
            this.DragEnter += (s, e) =>
            {
                var effects = DragDropEffects.None;
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    var path = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();

                    if (File.Exists(path))
                    {
                        var extension = Path.GetExtension(path).ToLower();
                        if (extension == ".pdf")
                        {

                            effects = DragDropEffects.Move;
                            var extIndex = path.LastIndexOf('.');
                            string newfileName;


                            // pdfcpu.exe module
                            if (comboBoxSelectMode.SelectedIndex == 1)
                            {
                                if (radioBRemoveAtto.Checked == true)
                                {
                                    newfileName = path.Replace(path.Substring(extIndex, path.Length - extIndex), "_noAnnot.pdf");
                                    File.Copy(path, newfileName);
                                    Process.Start("pdfcpu.exe", "annot remove " + '\u0022' + newfileName + '\u0022');
                                }
                                else if (radioBunpassword.Checked == true)
                                {
                                    newfileName = path.Replace(path.Substring(extIndex, path.Length - extIndex), "_unpw.pdf");
                                    File.Copy(path, newfileName);
                                    Process.Start("pdfcpu.exe", optionParameter + '\u0022' + newfileName + '\u0022');
                                }
                            }

                            // pdfcpu.exe module
                            else if (comboBoxSelectMode.SelectedIndex == 0)
                            {
                                Dictionary<string, string> dArgs = new Dictionary<string, string>();
                                //dArgs.Add("COLORSCREEN", "false");
                                Dictionary<string, string> sArgs = new Dictionary<string, string>();
                                //sArgs.Add("OutputFile", "output.pdf");

                                // Use Generate32 or Generate64 depending on your architecture
                                // GS4Net.GS4Net.Generate64(path, newfileName, dArgs, sArgs);

                                //Process.Start("gswin64c", GS4Net.GS4Net.g_gsArgs);
                                if (radioBRemoveAtto.Checked == true)
                                {
                                    newfileName = path.Replace(path.Substring(extIndex, path.Length - extIndex), "_noAnnot.pdf");
                                    dArgs.Add("ShowAnnots", "false");
                                    GS4Net.GS4Net.Generate(path, newfileName, dArgs, sArgs);
                                }
                                else if (radioBunpassword.Checked == true)
                                {
                                    newfileName = path.Replace(path.Substring(extIndex, path.Length - extIndex), "_unpw.pdf");
                                    GS4Net.GS4Net.Generate(path, newfileName, dArgs, sArgs);
                                }
                            }
                        }
                    }
                }
                e.Effect = effects;

            };
            this.DragLeave += (s, e) =>
            {
                Console.WriteLine("Leave");
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void radioBRemoveAtto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBRemoveAtto.Checked == true)
            {
                optionParameter = "annot remove ";
            }  
            else
            {
                //optionParameter = "decrypt ";
            }

        }

        private void radioBunpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBunpassword.Checked == true)
            {
                optionParameter = "decrypt ";
            }
            else
            {
                //optionParameter = "decrypt ";
            }

        }

        private void comboBoxSelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBoxSelectMode.SelectedIndex == 0)

            //if(comboBoxSelectMode.SelectedIndex == 1)   
           

        }
    }
}
