using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Legendary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            
            bool keyMaterialObtained = false;
            while (!keyMaterialObtained)
            {
                string input = Console.ReadLine().ToLower();

                string[] splittedInpute = input.Split(' ').ToArray();

                for (int i = 0; i < splittedInpute.Length - 1; i += 2)
                {
                    if (splittedInpute[i+1] == "shards" || splittedInpute[i+1] == "fragments" || splittedInpute[i+1] == "motes")
                    {
                        if (!keyMaterials.ContainsKey(splittedInpute[i+1]))
                        {
                            keyMaterials.Add(splittedInpute[i+1], int.Parse(splittedInpute[i]));
                            if (keyMaterials[splittedInpute[i + 1]] >= 250)
                            {
                                keyMaterials[splittedInpute[i+1]] = Math.Abs(keyMaterials[splittedInpute[i + 1]] - 250);
                                if (splittedInpute[i + 1] == "fragments")
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                }
                                else if (splittedInpute[i + 1] == "shards")
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                }
                                else if (splittedInpute[i + 1] == "motes")
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                }
                                keyMaterialObtained = true;
                                break;
                            }
                        }
                        else
                        {
                            keyMaterials[splittedInpute[i+1]] += int.Parse(splittedInpute[i]);
                            if (keyMaterials[splittedInpute[i + 1]] >= 250)
                            {
                                keyMaterials[splittedInpute[i + 1]] = Math.Abs(keyMaterials[splittedInpute[i + 1]] - 250);
                                if (splittedInpute[i + 1] == "fragments")
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                }
                                else if (splittedInpute[i + 1] == "shards")
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                }
                                else if (splittedInpute[i + 1] == "motes")
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                }
                                keyMaterialObtained = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(splittedInpute[i+1]))
                        {
                            junk.Add(splittedInpute[i+1], int.Parse(splittedInpute[i]));
                        }
                        else
                        {
                            junk[splittedInpute[i+1]] += int.Parse(splittedInpute[i]);
                        }
                    }
                }
            }
            foreach (var kMat in (keyMaterials.OrderBy(x => x.Key)).OrderByDescending(x => x.Value)) //right to left...
            {
                Console.WriteLine($"{kMat.Key}: {kMat.Value}");
            }
            foreach (var jMat in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{jMat.Key}: {jMat.Value}");
            }
        }
    }
}
