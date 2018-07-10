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

                        // TODO: NEEDS PUSHED TO GITHUB
namespace Pokemon
{
    public partial class Form1 : Form
    {
        // Declared Array to hold Pokemon Names
        public string[] PokeNames = new string[20];

        // Declared Instance of Pokemon Class
        Pokemon PlayerPokemon = new Pokemon();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string nameVar; // Used in the while loop
            int count = 0;  // Used in the while loop

            try
            {
                // Declare a stream reader
                StreamReader namesFile;

                // Open the file
                namesFile = File.OpenText("PokeNames.txt");

                // Read contents of the file into PokeNames[] and add them to ComboBox
                while (!namesFile.EndOfStream)
                {
                    // Get the first line from the Text File
                    nameVar = namesFile.ReadLine();

                    // Save the name to the Array
                    PokeNames[count] = nameVar;

                    // Add the name to the Combo Box
                    cbPokeNames.Items.Add(PokeNames[count]);

                    // Increment counter
                    count++;
                }

                // Show the first choice in the Combo Box
                cbPokeNames.Text = PokeNames[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            // Save Players Pokemon choice to the Pokemon Class
            PlayerPokemon.PokemonName = cbPokeNames.Text;
            // Get rid of the Combo Box
            cbPokeNames.Visible = false;
            // Display the Players Pokemon Choice
            lblPlayerPokemon.Text = PlayerPokemon.PokemonName;

            if (PlayerPokemon.PokemonName = PokeNames[0])
            // TODO: Carry on Working on POKEMON CLASS
            PlayerPokemon.
        }
    }
}
