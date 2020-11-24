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
            if(xml == false) {
                try
                {
                    addToCsv();

                }
             catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                try
                {
                    addToXml();

                    XmlDataDocument xmldoc = new XmlDataDocument();
                    XmlNodeList xmlnode;
                    int i = 0;
                    string str = null;
                    FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    str = xmldoc.InnerXml;
                    //xmlnode = xmldoc.GetElementsByTagName("Table");
                    /*
                    for (i = 0; i <= xmlnode.Count - 1; i++)
                    {
                        //str = xmlnode[0].ChildNodes.Item(i).InnerXml.Trim();
                        //xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                        //str = "Name" + xmlnode[i].ChildNodes.Item(0) + " : " + xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + "Level"+ xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + "Type " +xmlnode[i].ChildNodes.Item(2).InnerText.Trim() + "Weight " + xmlnode[i].ChildNodes.Item(3).InnerText.Trim() + "Sex " + xmlnode[i].ChildNodes.Item(4).InnerText.Trim() + "Price " + xmlnode[i].ChildNodes.Item(5).InnerText.Trim() + "Tipo " + xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
                      
                    }*/
                    textBox1.Text = str.ToString();
                    //MessageBox.Show(str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        /* this.name = name;
            this.level = level;
            this.type = type;
            this.weight = weight;
            this.sex = sex;
            this.price = price;
            this.ammount = ammount;*/
       public void addToXml()
        {
            XmlTextWriter writer = new XmlTextWriter("product.xml", System.Text.Encoding.UTF8);
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
            // Use a StringBuilder to accumulate your output
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

            // Write everything with a single command 
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
