namespace class_battle
{
  
    // Hero superclass
    public abstract class Hero
    {
        public string? Name { get; set; }

        public abstract void Attack();
        public abstract void Defend();
    }

    // Knight Hero subclass
    public class Knight : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("The Knight swings his sword!");
        }

        public override void Defend()
        {
            Console.WriteLine("The Knight blocks the attack with his shield!");
        }
    }
    
    // Crossbowman Hero subclass
    public class Crossbowman : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("The Crossbowman fires an arrow!");
        }

        public override void Defend()
        {
            Console.WriteLine("The Crossbowman casts a defensive spell!");
        }
    }

    // Pincher Hero subclass
    public class Pincher : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("The Pincher throw spear!");
        }

        public override void Defend()
        {
            Console.WriteLine("The Pincher deflects the attack with his shield!");
        }
    }

    // Enemy superclass
    public abstract class Enemy
    {
        public string? Name { get; set; }

        public abstract void Attack();
        public abstract void Defend();
    }

    // Ogr Enemy subclass
    public class Ogr : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("The Ogr swings his axe!");
        }

        public override void Defend()
        {
            Console.WriteLine("The Ogr blocks the attack with his shield!");
        }
    }

    // Elf Enemy subclass
    public class Elf : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("The Elf throws a rock!");
        }

        public override void Defend()
        {
            Console.WriteLine("The Elf cowers behind a rock!");
        }
    }

    // Spirit Enemy subclass
    public class Spirit : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("The Spirit swings his club!");
        }

        public override void Defend()
        {
            Console.WriteLine("The Spirit block hits");
        }
            
        
            
        
    }
    
}
