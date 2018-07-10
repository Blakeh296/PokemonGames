using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGameAttempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuickGame_Click_1(object sender, EventArgs e)
        {
            pbFirstPokeball.Visible = true;
            pbSecondPokeball.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pbFirstPokeball_MouseHover(object sender, EventArgs e)
        {
            pbCoolSquirtle.Visible = true;
            btnSqirtlePick.Visible = true;
        }


    }
}
