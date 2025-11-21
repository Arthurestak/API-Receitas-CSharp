using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlazorAPI.Shared
{
    public class Produto
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<string> ingredients { get; set; }
        public List<string> instructions { get; set; }
        public int prepTimeMinutes { get; set; }
        public int cookTimeMinutes { get; set; }
        public int servings { get; set; }
        public string difficulty { get; set; }
        public string cuisine { get; set; }
        public int caloriesPerServing { get; set; }
        public List<string> tags { get; set; }
        public int userId { get; set; }
        public string image { get; set; }
        public double rating { get; set; }
        public int reviewCount { get; set; }
        public List<string> mealType { get; set; }
        // public int id {get; set;}
        // public string nome {get; set;} = "";
        // public double preco {get; set;}
        // public double quantidade {get; set;}
        // public string urlimagem {get; set;} = "";
    }
}