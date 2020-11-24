using Newtonsoft.Json;
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

namespace Pokedex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokedex = new List<Pokemon>();
        private Pokemon searchedPokemon = null;
        private int searchedPokemonPos = -1;
        private string JsonData;

        public Form1()
        {
            InitializeComponent();
        }

        public Pokemon SearchOnPokemonArray(string name)
        {
            for (int i = 0; i < pokedex.Count; i++)
            {
                if (pokedex[i].name.Equals(name))
                {
                    searchedPokemonPos = i;
                    searchedPokemon = pokedex[i];
                    return pokedex[i];
                }
            }
            searchedPokemonPos = -1;
            return null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillPokedex();
            showPokemonsListToUser();
        }

        private void showPokemonsListToUser()
        {
            pokemonListBox.Items.Clear();
            for (int i = 0; i < pokedex.Count; i++)
            {
                pokemonListBox.Items.Add(pokedex[i].name.ToString()); 
               
            }
        }

        private void labelSerachInput_Click(object sender, EventArgs e)
        {

        }

        private void fillPokedex()
        {

            //Creating pokemons to fill the pokedex
            Pokemon pokemon0 = new Pokemon("Pichu", 7, "Electric", 5, "Female", 15, 2);
            Pokemon pokemon1 = new Pokemon("Pikachu", 14, "Electric", 18, "Male", 25, 3);
            Pokemon pokemon2 = new Pokemon("Raichu", 23, "Electric", 31, "Female", 35, 2);
            Pokemon pokemon3 = new Pokemon("Turtwig", 6, "GRASS", 6, "Male", 11, 1);
            Pokemon pokemon4 = new Pokemon("Grotle", 15, "GRASS", 56, "Female", 22, 2);
            Pokemon pokemon5 = new Pokemon("Torterra", 24, "GRASS", 120, "Male", 34, 1);
            Pokemon pokemon6 = new Pokemon("Chimchar", 8, "FIRE", 9, "Female", 7, 3);
            Pokemon pokemon7 = new Pokemon("Monferno", 16, "FIRE", 34, "Male", 18, 2);
            Pokemon pokemon8 = new Pokemon("Infernape", 25, "FIRE", 63, "Female", 26, 1);
            Pokemon pokemon9 = new Pokemon("Piplup", 5, "WATER", 4, "Male", 9, 1);
            Pokemon pokemon10 = new Pokemon("Prinplup", 18, "WATER", 17, "Female", 14, 2);
            Pokemon pokemon11 = new Pokemon("Empoleon", 26, "WATER", 52, "Male", 19, 1);

            pokedex.Add(pokemon0);
            pokedex.Add(pokemon1);
            pokedex.Add(pokemon2);
            pokedex.Add(pokemon3);
            pokedex.Add(pokemon4);
            pokedex.Add(pokemon5);
            pokedex.Add(pokemon6);
            pokedex.Add(pokemon7);
            pokedex.Add(pokemon8);
            pokedex.Add(pokemon9);
            pokedex.Add(pokemon10);
            pokedex.Add(pokemon11);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void levelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchedPokemon = SearchOnPokemonArray(searchInput.Text);
            if (searchedPokemon != null)
            {
                {
                    nameTextBox.Text = searchedPokemon.name;
                    levelTextBox.Text = searchedPokemon.level.ToString();
                    TypeTextBox.Text = searchedPokemon.type;
                    WeightTextBox.Text = searchedPokemon.weight.ToString();
                    SexTextBox.Text = searchedPokemon.sex;
                    PriceTextBox.Text = searchedPokemon.price.ToString();
                    AmmountTextBox.Text = searchedPokemon.ammount.ToString();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pokedex.Count; i++)
            {
                if (pokedex[i].name.Equals(pokemonListBox.SelectedItem.ToString()))
                {
                    pokedex.RemoveAt(i);
                }
            }
            searchedPokemon = null;
            searchedPokemonPos = -1;
            showPokemonsListToUser();
        }

        private void editPokemonBtn_Click(object sender, EventArgs e)
        {
            if (searchedPokemon != null && Validate())
            {
                try
                {
                    pokedex[searchedPokemonPos].name = nameTextBox.Text;
                    pokedex[searchedPokemonPos].level = int.Parse(levelTextBox.Text);
                    pokedex[searchedPokemonPos].type = TypeTextBox.Text;
                    pokedex[searchedPokemonPos].weight = int.Parse(WeightTextBox.Text);
                    pokedex[searchedPokemonPos].sex = SexTextBox.Text;
                    pokedex[searchedPokemonPos].price = float.Parse(PriceTextBox.Text);
                    pokedex[searchedPokemonPos].ammount = int.Parse(AmmountTextBox.Text);
                    showPokemonsListToUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pokemonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchOnPokemonArray(pokemonListBox.SelectedItem.ToString());
            if (searchedPokemon != null)
            {
                nameTextBox.Text = searchedPokemon.name;
                levelTextBox.Text = searchedPokemon.level.ToString();
                TypeTextBox.Text = searchedPokemon.type;
                WeightTextBox.Text = searchedPokemon.weight.ToString();
                SexTextBox.Text = searchedPokemon.sex;
                PriceTextBox.Text = searchedPokemon.price.ToString();
                AmmountTextBox.Text = searchedPokemon.ammount.ToString();
            }
        }

        private new bool Validate()
        {


            String regExpNumberTo = @"(^[1-9]{1}$|^[1-4]{1}[0-9]{1}$|^50$)";
            string regExpFloat = @"^[0-9]*(?:\.[0-9]+)?$";


            Regex RegExpText = new Regex(@"^[a-zA-Z]+$");
            Regex RegExpNumberTo = new Regex(regExpNumberTo);
            Regex RegExpFloat = new Regex(regExpFloat);

            bool resultado = false;

            resultado = RegExpText.IsMatch(nameTextBox.Text) && RegExpNumberTo.IsMatch(levelTextBox.Text) && RegExpNumberTo.IsMatch(WeightTextBox.Text) &&
                RegExpText.IsMatch(SexTextBox.Text) && RegExpText.IsMatch(TypeTextBox.Text) && RegExpFloat.IsMatch(PriceTextBox.Text) && RegExpNumberTo.IsMatch(AmmountTextBox.Text);

            if (resultado) { return true; ; }
            else
            {
                MessageBox.Show("Not valid chars");
                return false;
            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool succesName = true;
            try
            {
                Pokemon pokemon = new Pokemon(nameTextBox.Text, int.Parse(levelTextBox.Text), TypeTextBox.Text, int.Parse(WeightTextBox.Text), SexTextBox.Text, float.Parse(PriceTextBox.Text), int.Parse(AmmountTextBox.Text));
                for (int i = 0; i < pokedex.Count; i++)
                {
                    if (pokedex[i].name == pokemon.name)
                    {
                        succesName = false;
                        break;
                    }

                }
                if (Validate())
                {
                    if (succesName)
                    {
                        pokedex.Add(pokemon);
                        showPokemonsListToUser();
                        succesName = true;
                    }
                    else
                    {
                        MessageBox.Show("Repeated Pokemon ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            convertPokedexToJSON();

        }

        private void convertPokedexToJSON()
        {
            for (int i = 0; i < pokedex.Count; i++)
            {
                if (i != pokedex.Count - 1)
                {
                    JsonData += JsonConvert.SerializeObject(pokedex[i]) + ",";
                }
                else
                {
                    JsonData += JsonConvert.SerializeObject(pokedex[i]);
                }
            }
            try
            {
                File.WriteAllText("pokedexJSON.json", JsonData);
                MessageBox.Show("JSON File created ! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form3 settingsForm = new Form3(pokedex);


            settingsForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 aboutForm = new Form4();
            aboutForm.Show();
        }
    }
}
