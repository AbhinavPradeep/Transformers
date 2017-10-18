using System;

namespace TransformersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer t = new Transformer();
            t.Name = "Megatron";
            t.Transform();

            Weapon StarSabre = new Weapon();
            StarSabre.Name = "Starsabre";

            Autobots optimus = new Autobots();
            optimus.Name = "Optimus Prime";
            optimus.Weapons.Add(StarSabre);
            

            optimus.Transform();
            optimus.ShowWeapons();

        }
    }
}
