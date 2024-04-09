using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace listboxtest
{
    internal class Meal
    {
        


        [Name("Type")] public string Type { get; set; }
        [Name("Name")] public string Name { get; set; }
        [Name("Description")] public string Description { get; set; }
        [Name("Calories")] public string Calories { get; set; }
        [Name("Fat")] public string Fat { get; set; }
        [Name("Carbs")] public string Carbs { get; set; }
        [Name("Protein")] public string Protein { get; set; }
        [Name("Ingredient1")] public string Ingredient1 { get; set; }
        [Name("Ingredient2")] public string Ingredient2 { get; set; }
        [Name("Ingredient3")] public string Ingredient3 { get; set; }
        [Name("Ingredient4")] public string Ingredient4 { get; set; }
        [Name("Ingredient5")] public string Ingredient5 { get; set; }
        [Name("Ingredient6")] public string Ingredient6 { get; set; }
        [Name("Ingredient7")] public string Ingredient7 { get; set; }
        [Name("Ingredient8")] public string Ingredient8 { get; set; }
        [Name("Ingredient9")] public string Ingredient9 { get; set; }
    }
}
