using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtools
{
    public partial class Form1 : Form
    {
        private string optionParameter = "annot remove ";

        public Form1()
        {
            InitializeComponent();


            this.Text = "PDFtools :: unpassword and remove annotations";
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
                            var newfileName = path.Replace(path.Substring(extIndex, path.Length - extIndex), "_unpw.pdf");
                            File.Copy(path, newfileName);
                            //ExcelFileExtension.SaveAsCSV(path, newPDF);
                            //Process.Start(newPDF);
                            Process.Start("pdfcpu.exe", "annot remove " + newfileName);

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
    }
}
