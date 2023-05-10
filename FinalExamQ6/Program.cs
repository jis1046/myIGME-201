using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinalExamQ6
{
    internal class Program
    {
        public class PlayerSetting
        {
            public PlayerSetting() { }

            string name;
            int level;
            int hp;
            List<string> inventory;
            string licenseKey;

            public void saveFile(string fileName) 
            {
                using (StreamWriter file = File.CreateText(fileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, this);
                }
            }

            public void loadFile(string fileName) 
            {
                using (StreamReader file = File.OpenText(fileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    PlayerSetting loadPlayerSetting = new PlayerSetting();

                    this.name = loadPlayerSetting.name;
                    this.level = loadPlayerSetting.level;
                    this.hp = loadPlayerSetting.hp;
                    this.inventory = loadPlayerSetting.inventory;
                    this.licenseKey = loadPlayerSetting.licenseKey;
                }
            }

            public void clear()
            {
                this.name=null;
                this.level=0;
                this.hp=0;
                this.inventory=null;
                this.licenseKey=null;
            }

        }
        static void Main(string[] args)
        {

            playerSetting.name = "";

        }
    }
}
