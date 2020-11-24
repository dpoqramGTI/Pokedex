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
using System.Xml;

namespace Pokedex
{         
    public partial class Form3 : Form
    {
        int productNumber = 0;

        private List<Pokemon> pokedex = new List<Pokemon>();
        bool xml = false;
        public Form3(List<Pokemon> pokedex)
        {
            this.pokedex = pokedex;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            xml = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            xml = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if (xml == false) {
                try
                {
                    addToCsv();
                    MessageBox.Show("CSV File created ! ");
                }
             catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                try
                {
                    addToXml(productNumber);

                    XmlDataDocument xmldoc = new XmlDataDocument();
                    XmlNodeList xmlnode;
                    int i = 0;
                   
                    string str = null;
                    

                    FileStream fs = new FileStream("pokedex" + productNumber.ToString() + ".xml", FileMode.Open, FileAccess.Read);
                    productNumber++;
                    xmldoc.Load(fs);
                    str = xmldoc.InnerXml;
                    textBox1.Text = str.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }
       public void addToXml(int productNumber)
        {
            XmlTextWriter writer = new XmlTextWriter("pokedex" + productNumber.ToString() + ".xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            for (int i = 0; i < pokedex.Count; i++)
            {
                createNode(pokedex[i].name, pokedex[i].level, pokedex[i].type, pokedex[i].weight, pokedex[i].sex, pokedex[i].price, pokedex[i].ammount,writer);


            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File created ! ");
        }
        public  void addToCsv()
        {
            StringBuilder sb = new StringBuilder("Pokemon;Level;Type;Weight;Sex;Price;Ammount\r\n");
            String row;
            List<Pokemon> pokedex1 = new List<Pokemon>();

            

            for (int i = 0; i < pokedex.Count; i++)
            {
                row = String.Concat(pokedex[i].name, ';', pokedex[i].level.ToString(), ';',
                    pokedex[i].type, ';', pokedex[i].weight.ToString(), ';', pokedex[i].sex, ';', pokedex[i].price.ToString(), ';', pokedex[i].ammount.ToString());
                
                sb.Append(row);
                sb.AppendLine();
                
            }
            File.WriteAllText(@"fileadress.csv", sb.ToString());
            textBox1.Text = sb.ToString();

        }
  
        private void createNode(string name, int level, string type, int weight, string sex,float price,int ammount, XmlTextWriter writer)
        {
            writer.WriteStartElement("Pokemon");
            writer.WriteStartElement("Name");
            writer.WriteString(name);
            writer.WriteEndElement();
            writer.WriteStartElement("Level");
            writer.WriteString(level.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Type");
            writer.WriteString(type);
            writer.WriteEndElement();
            writer.WriteStartElement("Weight");
            writer.WriteString(weight.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Sex");
            writer.WriteString(sex);
            writer.WriteEndElement();
            writer.WriteStartElement("Price");
            writer.WriteString(price.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Ammount");
            writer.WriteString(ammount.ToString());
            writer.WriteEndElement();
            writer.WriteEndElement();        

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
