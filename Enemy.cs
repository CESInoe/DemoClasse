using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasse
{
    using System;
    using System.Collections.Generic;

    class Enemy
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public string FavoriteBiome { get; set; }

        public Enemy(string name, int attack, int defense, int health, string favoriteBiome)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            Health = health;
            FavoriteBiome = favoriteBiome;
        }

        public String DescribeSelf()
        {
            return $"I am a {Name} I have {Attack} Attack point, {Health} Health point and {Defense} defense. I love the {FavoriteBiome}";
        }

        public Task<string?>? Test()
        {
            return Task.Run( () => Console.ReadLine() );            
        }

        public static List<Enemy> InitList()
        {
            List<Enemy> enemies = new List<Enemy>();
            // create 30 different enemies and add them to the list
            enemies.Add(new Enemy("Goblin", 5, 3, 30, "Forest"));
            enemies.Add(new Enemy("Orc", 8, 5, 50, "Mountain"));
            enemies.Add(new Enemy("Troll", 9, 8, 60, "Cave"));
            enemies.Add(new Enemy("Skeleton", 3, 2, 20, "Graveyard"));
            enemies.Add(new Enemy("Zombie", 4, 4, 25, "Swamp"));
            enemies.Add(new Enemy("Vampire", 10, 7, 55, "Castle"));
            enemies.Add(new Enemy("Werewolf", 7, 6, 45, "Forest"));
            enemies.Add(new Enemy("Dragon", 10, 10, 60, "Mountain"));
            enemies.Add(new Enemy("Giant", 8, 9, 55, "Hills"));
            enemies.Add(new Enemy("Ghost", 6, 3, 15, "Haunted House"));
            enemies.Add(new Enemy("Mummy", 4, 7, 35, "Desert"));
            enemies.Add(new Enemy("Witch", 7, 4, 30, "Forest"));
            enemies.Add(new Enemy("Warlock", 9, 6, 45, "Cave"));
            enemies.Add(new Enemy("Demon", 10, 8, 50, "Hell"));
            enemies.Add(new Enemy("Imp", 3, 1, 10, "Volcano"));
            enemies.Add(new Enemy("Kraken", 10, 9, 60, "Ocean"));
            enemies.Add(new Enemy("Minotaur", 7, 6, 45, "Labyrinth"));
            enemies.Add(new Enemy("Harpy", 5, 4, 25, "Mountain"));
            enemies.Add(new Enemy("Cerberus", 9, 8, 55, "Hell"));
            enemies.Add(new Enemy("Chimera", 8, 7, 50, "Mountain"));
            enemies.Add(new Enemy("Medusa", 6, 5, 40, "Cave"));
            enemies.Add(new Enemy("Cyclops", 7, 9, 50, "Mountain"));
            enemies.Add(new Enemy("Griffin", 9, 6, 45, "Mountain"));
            enemies.Add(new Enemy("Hydra", 10, 10, 60, "Swamp"));
            enemies.Add(new Enemy("Basilisk", 6, 7, 35, "Desert"));
            enemies.Add(new Enemy("Gargoyle", 5, 6, 30, "Castle"));
            enemies.Add(new Enemy("Succubus", 8, 5, 40, "Hell"));
            enemies.Add(new Enemy("Incubus", 7, 6, 35, "Cave"));
            enemies.Add(new Enemy("Kobold", 4, 3, 20, "Mines"));
            enemies.Add(new Enemy("Naga", 6, 7, 45, "Jungle"));
            enemies.Add(new Enemy("Ghoul", 5, 5, 30, "Graveyard"));
            enemies.Add(new Enemy("Banshee", 6, 4, 25, "Haunted House"));
            enemies.Add(new Enemy("Siren", 7, 5, 35, "Ocean"));
            enemies.Add(new Enemy("Mermaid", 5, 7, 40, "Ocean"));
            enemies.Add(new Enemy("Giant Spider", 5, 6, 35, "Cave"));
            enemies.Add(new Enemy("Giant Scorpion", 7, 7, 40, "Desert"));
            enemies.Add(new Enemy("Giant Bat", 4, 3, 20, "Cave"));
            enemies.Add(new Enemy("Mothman", 8, 4, 35, "Forest"));
            enemies.Add(new Enemy("Chupacabra", 6, 5, 30, "Desert"));
            enemies.Add(new Enemy("Bigfoot", 7, 6, 45, "Forest"));
            enemies.Add(new Enemy("Yeti", 8, 7, 50, "Mountain"));
            enemies.Add(new Enemy("Sasquatch", 6, 8, 45, "Forest"));
            enemies.Add(new Enemy("Thunderbird", 9, 5, 40, "Mountain"));
            enemies.Add(new Enemy("Wendigo", 7, 7, 40, "Forest"));
            enemies.Add(new Enemy("Skinwalker", 5, 8, 30, "Desert"));
            enemies.Add(new Enemy("Jersey Devil", 6, 5, 35, "Forest"));
            enemies.Add(new Enemy("Changeling", 4, 3, 25, "Forest"));
            enemies.Add(new Enemy("El Chupacabra", 7, 6, 40, "Jungle"));
            enemies.Add(new Enemy("Black Shuck", 8, 6, 45, "Coast"));
            enemies.Add(new Enemy("Gnome", 3, 4, 20, "Forest"));
            enemies.Add(new Enemy("Goblin King", 10, 7, 55, "Cave"));
            enemies.Add(new Enemy("Skeleton Warrior", 5, 4, 30, "Graveyard"));
            enemies.Add(new Enemy("Zombie Pirate", 6, 6, 35, "Ocean"));
            enemies.Add(new Enemy("Vampire Lord", 10, 8, 55, "Castle"));
            enemies.Add(new Enemy("Werewolf Alpha", 9, 7, 50, "Forest"));
            enemies.Add(new Enemy("Fire Elemental", 8, 7, 45, "Volcano"));
            enemies.Add(new Enemy("Ice Elemental", 7, 8, 45, "Mountain"));
            enemies.Add(new Enemy("Thunder Elemental", 9, 6, 40, "Stormy Plains"));
            enemies.Add(new Enemy("Skinwalker", 5, 8, 30, "Desert"));
            enemies.Add(new Enemy("Jersey Devil", 6, 5, 35, "Forest"));
            enemies.Add(new Enemy("Changeling", 4, 3, 25, "Forest"));
            enemies.Add(new Enemy("El Chupacabra", 7, 6, 40, "Jungle"));
            enemies.Add(new Enemy("Wind Elemental", 6, 9, 40, "Desert"));
            enemies.Add(new Enemy("Earth Elemental", 7, 10, 50, "Cave"));
            enemies.Add(new Enemy("Dark Elemental", 9, 9, 55, "Graveyard"));
            enemies.Add(new Enemy("Light Elemental", 8, 8, 50, "Mountaintop"));
            enemies.Add(new Enemy("Slime", 2, 2, 15, "Swamp"));
            enemies.Add(new Enemy("Giant Ant", 4, 3, 25, "Grasslands"));
            enemies.Add(new Enemy("Giant Centipede", 6, 5, 35, "Cave"));
            enemies.Add(new Enemy("Giant Rat", 3, 2, 15, "Sewer"));
            enemies.Add(new Enemy("Giant Slug", 2, 7, 50, "Swamp"));
            enemies.Add(new Enemy("Giant Snail", 3, 8, 55, "Forest"));
            enemies.Add(new Enemy("Giant Crab", 5, 6, 35, "Coast"));
            enemies.Add(new Enemy("Giant Octopus", 7, 9, 55, "Ocean"));
            enemies.Add(new Enemy("Giant Squid", 8, 8, 50, "Ocean"));
            enemies.Add(new Enemy("Kraken", 10, 10, 60, "Ocean"));
            enemies.Add(new Enemy("Sea Serpent", 9, 8, 55, "Ocean"));
            enemies.Add(new Enemy("Hydra", 8, 9, 50, "Swamp"));
            enemies.Add(new Enemy("Manticore", 9, 7, 50, "Desert"));
            enemies.Add(new Enemy("Minotaur", 10, 9, 55, "Labyrinth"));
            enemies.Add(new Enemy("Cerberus", 10, 10, 60, "Underworld"));
            enemies.Add(new Enemy("Sphinx", 8, 10, 55, "Desert"));
            enemies.Add(new Enemy("Medusa", 7, 8, 40, "Cave"));
            enemies.Add(new Enemy("Harpy", 6, 4, 30, "Mountain"));
            enemies.Add(new Enemy("Gorgon", 9, 7, 50, "Cave"));
            enemies.Add(new Enemy("Cyclops", 10, 8, 55, "Mountain"));
            enemies.Add(new Enemy("Satyr", 5, 3, 25, "Forest"));
            enemies.Add(new Enemy("Dryad", 3, 5, 20, "Forest"));
            enemies.Add(new Enemy("Dragon Hatchling", 6, 7, 45, "Volcano"));
            enemies.Add(new Enemy("Young Dragon", 8, 8, 50, "Mountaintop"));
            enemies.Add(new Enemy("Adult Dragon", 10, 10, 60, "Mountaintop"));
            enemies.Add(new Enemy("Ancient Dragon", 12, 12, 70, "Dragon's Den"));
            enemies.Add(new Enemy("Demon Imp", 4, 2, 20, "Underworld"));
            enemies.Add(new Enemy("Demon Warrior", 9, 6, 45, "Underworld"));
            enemies.Add(new Enemy("Demon Lord", 12, 10, 60, "Underworld"));
            enemies.Add(new Enemy("Fallen Angel", 11, 11, 70, "Heaven"));
            enemies.Add(new Enemy("Archangel", 12, 12, 70, "Heaven"));
            enemies.Add(new Enemy("Lich", 8, 8, 50, "Graveyard"));
            enemies.Add(new Enemy("Necromancer", 7, 6, 35, "Graveyard"));
            enemies.Add(new Enemy("Wraith", 6, 9, 30, "Graveyard"));
            enemies.Add(new Enemy("Skeleton", 4, 2, 20, "Graveyard"));
            enemies.Add(new Enemy("Zombie", 3, 4, 25, "Graveyard"));
            enemies.Add(new Enemy("Ghoul", 5, 7, 35, "Graveyard"));
            enemies.Add(new Enemy("Vampire Bat", 2, 3, 20, "Castle"));
            enemies.Add(new Enemy("Vampire", 10, 8, 50, "Castle"));
            enemies.Add(new Enemy("Werewolf", 7, 5, 40, "Forest"));
            enemies.Add(new Enemy("Goblin", 3, 2, 15, "Cave"));
            enemies.Add(new Enemy("Hobgoblin", 5, 4, 30, "Mountain"));
            enemies.Add(new Enemy("Orc", 6, 5, 35, "Forest"));
            enemies.Add(new Enemy("Troll", 8, 7, 45, "Mountain"));
            enemies.Add(new Enemy("Giant", 10, 10, 60, "Mountain"));
            enemies.Add(new Enemy("Cave Bear", 7, 9, 50, "Cave"));
            enemies.Add(new Enemy("Grizzly Bear", 8, 8, 45, "Forest"));
            enemies.Add(new Enemy("Polar Bear", 9, 7, 40, "Snow"));
            enemies.Add(new Enemy("Dire Wolf", 6, 6, 30, "Forest"));
            enemies.Add(new Enemy("Mountain Lion", 5, 4, 25, "Mountain"));
            enemies.Add(new Enemy("Wild Boar", 4, 6, 30, "Forest"));
            enemies.Add(new Enemy("Giant Spider", 5, 8, 40, "Cave"));
            enemies.Add(new Enemy("Tarantula", 7, 6, 35, "Cave"));
            enemies.Add(new Enemy("Scorpion", 6, 5, 30, "Desert"));
            enemies.Add(new Enemy("Fire Elemental", 8, 6, 45, "Volcano"));
            enemies.Add(new Enemy("Ice Elemental", 7, 8, 40, "Snow"));
            enemies.Add(new Enemy("Storm Elemental", 9, 7, 50, "Sky"));
            enemies.Add(new Enemy("Earth Elemental", 6, 10, 55, "Mountain"));
            enemies.Add(new Enemy("Water Elemental", 7, 9, 50, "Ocean"));
            return enemies;
        }
    }
}
