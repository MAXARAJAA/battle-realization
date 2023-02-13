using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    // Hero superclass
    public abstract class Hero
    {
        public string Name { get; set; }

        public abstract void Attack();
        public abstract void Defend();
    }

    // Knight Hero subclass
    public class Knight : Hero
    {
        public override void Attack()
        {
            //MessageBox.Show.Show("The Knight swings his sword!");
            MessageBox.Show("The Knight swings his sword!");
        }

        public override void Defend()
        {
            MessageBox.Show("The Knight blocks the attack with his shield!");
        }
    }

    // Crossbowman Hero subclass
    public class Crossbowman : Hero
    {
        public override void Attack()
        {
            MessageBox.Show("The Crossbowman fires an arrow!");
        }

        public override void Defend()
        {
            MessageBox.Show("The Crossbowman casts a defensive spell!");
        }
    }

    // Pincher Hero subclass
    public class Pincher : Hero
    {
        public override void Attack()
        {
            MessageBox.Show("The Pincher throw spear!");
        }

        public override void Defend()
        {
            MessageBox.Show("The Pincher deflects the attack with his shield!");
        }
    }

    // Enemy superclass
    public abstract class Enemy
    {
        public string Name { get; set; }

        public abstract void Attack();
        public abstract void Defend();
    }

    // Ogr Enemy subclass
    public class Ogr : Enemy
    {
        public override void Attack()
        {
            MessageBox.Show("The Ogr swings his axe!");
        }

        public override void Defend()
        {
            MessageBox.Show("The Ogr blocks the attack with his shield!");
        }
    }

    // Elf Enemy subclass
    public class Elf : Enemy
    {
        public override void Attack()
        {
            MessageBox.Show("The Elf throws a rock!");
        }

        public override void Defend()
        {
            MessageBox.Show("The Elf cowers behind a rock!");
        }
    }

    // Spirit Enemy subclass
    public class Spirit : Enemy
    {
        public override void Attack()
        {
            MessageBox.Show("The Spirit swings his club!");
        }

        public override void Defend()
        {
            MessageBox.Show("The Spirit block hits");
        }




    }
}
