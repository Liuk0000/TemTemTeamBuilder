using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemTemTeamBuilder.Util
{
    public class LocalStorageHandler
    {
        public static Dictionary<string, string> PropertiesDict { get; } = Properties();

        public static void JsonTemDataWriter(string str)
        {

            StreamWriter writer = new StreamWriter(PropertiesDict["DownloadedDataPath"]);

            writer.Write(str);

            writer.Dispose();
        }

        public static JsonDocument JsonTemDataReader()
        {
            StreamReader reader = new StreamReader(PropertiesDict["DownloadedDataPath"]);

            string fileContent = reader.ReadToEnd();

            if (String.IsNullOrEmpty(fileContent)){
                reader.Dispose();
                reader.Close();
                return null;
            }
            else
            {
                var json = JsonDocument.Parse(fileContent);
                reader.Dispose();
                reader.Close();
                return json;
            }
        }

        public static void CreateNewTeam(string teamName)
        {
            string thisPath = PropertiesDict["TeamsFolderPath"] + "\\" + teamName + ".json";

            if (!GetTeamsFileNames().Contains(thisPath))
            {
                File.Create(PropertiesDict["TeamsFolderPath"] + "\\" + teamName + ".json").Close();
            }
            else
            {
                throw new Exception();
            }
        }

        public static string[] GetTeamsFileNames()
        {
            return Directory.GetFiles(PropertiesDict["TeamsFolderPath"]);
        }

        public static Dictionary<string, string> Properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string dir = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\TemTemBuilder";

            DirectoryCheck(dir);
            JsonDataCheck(dir);
            PropertiesFileCheck(dir);

            foreach (string row in File.ReadAllLines($@"{dir}\TemTemBuilder.properties"))
            {
                properties.Add(row.Split('=')[0].Trim(), row.Split('=')[1].Trim());
            }

            dir = null;
            return properties;
        }

        private static void DirectoryCheck(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                Directory.CreateDirectory($@"{dir}\Teams");
            }
        }

        private static void PropertiesFileCheck(string dir)
        {
            if (!Directory.GetFiles(dir).Contains("TemTemBuilder.properties"))
            {
                File.Create($@"{dir}\TemTemBuilder.properties").Close();

                StreamWriter sw = new StreamWriter($@"{dir}\TemTemBuilder.properties");
                sw.WriteLine("GetAllLink = https://temtem-api.mael.tech/api/temtems");
                sw.WriteLine($@"DownloadedDataPath = {dir}\TemTems.json");
                sw.WriteLine($@"TeamsFolderPath = {dir}\Teams");

                sw.Dispose();

            }
        }

        private static void JsonDataCheck(string dir)
        {
            if (!Directory.GetFiles(dir).Contains($@"{dir}\TemTems.json"))
            {
                File.Create($@"{dir}\TemTems.json").Close();
            }
        }

        public static void TeamUpdate(string path, string json)
        {
            FileStream stream = File.Open(path, FileMode.Open);
            stream.SetLength(0);
            stream.Close();//Flusing the stream and content
            stream = null;

            StreamWriter sw = new StreamWriter(path);
            sw.Write(json);
            sw.Flush();
            sw.Close();
            sw = null;
        }

        public static JsonDocument TeamReader(string path)
        {
            StreamReader reader = new StreamReader(path);
            string str = reader.ReadToEnd();
            reader.Close();

            if (String.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                return JsonDocument.Parse(str);
            }
        }
    }
}
