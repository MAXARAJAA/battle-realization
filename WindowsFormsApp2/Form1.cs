using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Knight knight = new Knight();
            knight.Attack();
            //knight.Defend();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Knight knight = new Knight();
            knight.Defend();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Crossbowman crossbowman = new Crossbowman();
            crossbowman.Attack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Crossbowman crossbowman = new Crossbowman();
            crossbowman.Defend();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pincher pincher = new Pincher();
            pincher.Attack();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pincher pincher = new Pincher();
            pincher.Defend();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ogr ogr = new Ogr();
            ogr.Attack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ogr ogr = new Ogr();
            ogr.Defend();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Elf elf = new Elf();
            elf.Attack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Elf elf = new Elf();
            elf.Defend();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Spirit spirit = new Spirit();
            spirit.Attack();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Spirit spirit = new Spirit();
            spirit.Defend();
        }
    }
}
