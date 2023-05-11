using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinalExamQ6
{
    internal class Program
    {
        public class SingletonClass
        {
            private static SingletonClass instance = new SingletonClass();

            private SingletonClass() { }

            public static SingletonClass getInstance() 
            { 
                return instance;
            }

            public PlayerSettings Load()
            {

                string filePath = "player_settings.json";
                if(File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<PlayerSettings>(json);
                }

                else
                {
                    Console.WriteLine("File not found: " + filePath);
                    return null;
                }
            }

            public void Save(PlayerSettings playerSettings) 
            {
                string filePath = "player_settings.json";
                string json = JsonConvert.SerializeObject(playerSettings);
                File.WriteAllText(filePath, json);
            }
        }

        public class PlayerSettings
        {
            public string name;
            public int level;
            public int hp;
            public List<string> inventory;
            public string licenseKey;
        }
        static void Main(string[] args)
        {
            SingletonClass singleton = SingletonClass.getInstance(); 

            PlayerSettings playerSettings = singleton.Load();

            if(playerSettings != null)
            {
                Console.WriteLine("Loaded player settings:");
                Console.WriteLine("Player Name: " + playerSettings.name);
                Console.WriteLine("Level: " + playerSettings.level);
                Console.WriteLine("HP: " + playerSettings.hp);
                Console.WriteLine("Inventory: " + string.Join(",", playerSettings.inventory));
                Console.WriteLine("License Key: " + playerSettings.licenseKey);
                Console.WriteLine();
            }

            playerSettings = new PlayerSettings
            {
                name = "dschuh",
                level = 4,
                hp = 99,
                inventory = new List<string> { "spear", "water bottle", "hammer", "sonic screwdriver", "cannonball", "wood", "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder" },
                licenseKey = "DFGU99-1454"
            };

            singleton.Save(playerSettings);

            Console.WriteLine("Saved player settings:");
            Console.WriteLine("Player Name: " + playerSettings.name);
            Console.WriteLine("Level: " + playerSettings.level);
            Console.WriteLine("HP: " + playerSettings.hp);
            Console.WriteLine("Inventory: " + string.Join(",", playerSettings.inventory));
            Console.WriteLine("License Key: " + playerSettings.licenseKey);


        }
    }
}
