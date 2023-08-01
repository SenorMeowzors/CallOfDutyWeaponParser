using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CallOfDutyWeaponParser
{
    class WeaponFileUtilities
    { 
        public static Dictionary<string,string> GetWeaponDictionary(string weaponString)
        {
            var weaponDict = new Dictionary<string, string>();

            var stuff = weaponString.Split('\\').ToList();

            stuff.RemoveAt(0);

            for (int i = 0; i < stuff.Count; i += 2)
            {
                if (i >= stuff.Count || i + 1 >= stuff.Count)
                {
                    break;
                }
                weaponDict[stuff[i]] = stuff[i + 1];
            }

            return weaponDict;
        }

        public static void WriteToPath(FlowLayoutPanel panel, string filepath)
        {
            var file = new System.IO.StreamWriter(filepath);

            file.Write(CreateWeaponStringFromCollection(panel.Controls));
            file.Close();
        }

        public static KeyValueDisplay CreateKVDisplay(string key, string value, int yValue)
        {
            var display = new KeyValueDisplay(key, value);

            display.Location = new System.Drawing.Point(3, yValue);
            display.Name = "keyValueDisplay1";
            display.Size = new System.Drawing.Size(410, 21);
            display.TabIndex = 0;
            return display;
        }

        public static string CreateWeaponStringFromCollection(Control.ControlCollection collection)
        {
            string result = "WEAPONFILE\\";

            foreach (var control in collection)
            {
                var kvd = (KeyValueDisplay)control;

                if(kvd != null)
                {
                    result += kvd.GetString();
                }
            }

            result = result.Remove(result.Length - 1, 1);
            return result;
        }
    }
}
