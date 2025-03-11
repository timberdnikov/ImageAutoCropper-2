using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ImageAutoCropper
{
    public class Preset
    {
        public string name = "";
        public Settings settings = new Settings();
        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }
        public void Load(string path)
        {
            Preset p = JsonConvert.DeserializeObject<Preset>(File.ReadAllText(path));
            name = p.name;
            settings = p.settings;
        }
    }
}
