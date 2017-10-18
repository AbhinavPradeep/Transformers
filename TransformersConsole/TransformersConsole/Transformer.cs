using System;
using System.Collections.Generic;
using System.Text;

namespace TransformersConsole
{
    class Transformer
    {
        public string Name;
        public List<Weapon> Weapons;
        

        public Transformer()
        {
            Weapons = new List<Weapon>();
        }

        public void Transform()
        {
            Console.WriteLine( "{0} is transforming", Name);
        }

        public void ShowWeapons()
        {
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine("I have a {0} --" , weapon.Name);
            }
        }
    }
}
