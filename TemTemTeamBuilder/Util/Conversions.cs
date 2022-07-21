using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TemTemTeamBuilder.Models;
using static System.Text.Json.JsonElement;

namespace TemTemTeamBuilder.Util
{
    public class Conversions
    {
        public static IList<TemTem> GetTemsList(JsonDocument json)
        {
            if (json != null) {
                ArrayEnumerator list = json.RootElement.EnumerateArray();

                IList<TemTem> tems = new List<TemTem>();

                foreach (JsonElement item in list)
                {

                    var traits = item.GetProperty("traits").EnumerateArray().ToArray();

                    TemTem tem = new TemTem()
                    {
                        Name = item.GetProperty("name").GetString(),
                        Number = item.GetProperty("number").GetInt32(),
                        Traits = new TemTrait[]{
                            new TemTrait() {Name = traits[0].GetString(), Description = null },
                            new TemTrait() {Name = traits[1].GetString(), Description = null }
                            },
                        Stats = new double[]
                        {
                        item.GetProperty("stats").GetProperty("hp").GetDouble(),
                        item.GetProperty("stats").GetProperty("sta").GetDouble(),
                        item.GetProperty("stats").GetProperty("spd").GetDouble(),
                        item.GetProperty("stats").GetProperty("atk").GetDouble(),
                        item.GetProperty("stats").GetProperty("def").GetDouble(),
                        item.GetProperty("stats").GetProperty("spatk").GetDouble(),
                        item.GetProperty("stats").GetProperty("spdef").GetDouble(),
                        item.GetProperty("stats").GetProperty("total").GetDouble()
                        }
                    };

                    traits = null;

                    tem.Techniques = new List<TemTechnique>();

                    ArrayEnumerator techinuqesList = item.GetProperty("techniques").EnumerateArray();

                    foreach (JsonElement element in techinuqesList)
                    {
                        tem.Techniques.Add(new TemTechnique()
                        {
                            Name = element.GetProperty("name").GetString()
                        });
                    }

                    tems.Add(tem);
                    tem = null;
                }
                return tems;
            }
            else
            {
                return null;
            }

        }
        /* Dumb Made by Hand method for Deserializing
        public static TemTem[] TeamJsonToArray(JsonDocument json)
        {
            if(json == null)
            {
                return new TemTem[8];
            }
            TemTem[] array = new TemTem[json.RootElement.GetArrayLength()];

            ArrayEnumerator content = json.RootElement.EnumerateArray();

            for(int i = 0; i < content.Count(); i++)
            {
                if (content.ElementAt(i).Deserialize<object>() != null)
                {
                    array[i] = new TemTem()
                    {
                        Number = content.ElementAt(i).GetProperty("Number").GetInt32(),
                        Name = content.ElementAt(i).GetProperty("Name").GetString(),
                        Level = content.ElementAt(i).GetProperty("Level").GetDouble(),
                        Traits = new TemTrait[] {
                        new TemTrait { Name = content.ElementAt(i).GetProperty("Traits").EnumerateArray().ToArray()[0].GetProperty("Name").GetString(), Description = null },
                        new TemTrait { Name = content.ElementAt(i).GetProperty("Traits").EnumerateArray().ToArray()[1].GetProperty("Name").GetString(), Description = null }
                    },
                        Techniques = new List<TemTechnique>(),
                        Stats = new double[]
                    {
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[0].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[1].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[2].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[3].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[4].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[5].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[6].GetDouble(),
                        content.ElementAt(i).GetProperty("Stats").EnumerateArray().ToArray()[7].GetDouble()
                    },
                        Svs = new double[]
                    {
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[0].GetDouble(),
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[1].GetDouble(),
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[2].GetDouble(),
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[3].GetDouble(),
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[4].GetDouble(),
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[5].GetDouble(),
                        content.ElementAt(i).GetProperty("Svs").EnumerateArray().ToArray()[6].GetDouble()
                    },
                        Tvs = new double[]
                    {
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[0].GetDouble(),
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[1].GetDouble(),
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[2].GetDouble(),
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[3].GetDouble(),
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[4].GetDouble(),
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[5].GetDouble(),
                        content.ElementAt(i).GetProperty("Tvs").EnumerateArray().ToArray()[6].GetDouble()
                    },
                        TrueStats = new int[]
                    {
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[0].GetDouble(),
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[1].GetDouble(),
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[2].GetDouble(),
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[3].GetDouble(),
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[4].GetDouble(),
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[5].GetDouble(),
                        (int)content.ElementAt(i).GetProperty("TrueStats").EnumerateArray().ToArray()[6].GetDouble()
                    }
                    };
                    foreach(JsonElement element in content.ElementAt(i).GetProperty("Techniques").EnumerateArray())
                    {
                        array[i].Techniques.Add(new TemTechnique()
                        {
                            Name = element.GetProperty("Name").GetString(),
                        });
                    }
                }
            }
            return array;
        }*/

        public static TemTem[] TeamJsonToArray(JsonDocument json)
        {
            TemTem[] team = new TemTem[8];
            int i = 0;
            foreach(JsonElement element in json.RootElement.EnumerateArray())
            {
                team[i]= element.Deserialize<TemTem>();
                i++;
            }
            return team;
        }
    }
}
