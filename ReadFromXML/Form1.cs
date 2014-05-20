using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = "1";
            var doc = XDocument.Load("XMLFile1.xml");
            var emailQuery = from Atleta in doc.Root.Elements("Atleta")
                             where (string)Atleta.Attribute("Id") == ID
                             select new
                             {
                                 Name = (string)Atleta.Attribute("Nombre"),
                                 Genre = (string)Atleta.Attribute("Genero")
                             };


        }
    }
}
