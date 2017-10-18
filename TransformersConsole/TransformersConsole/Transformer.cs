using System;
using System.Collections.Generic;
using System.Text;

namespace TransformersConsole
{
    abstract class Transformer
    {
        public string Name;
        public List<Weapon> Weapons;
        

        public Transformer()
        {
            Weapons = new List<Weapon>();
        }

        public abstract void Transform();

        public void ShowWeapons()
        {
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine("I have a {0} --" , weapon.Name);
            }
        }
    }
}
