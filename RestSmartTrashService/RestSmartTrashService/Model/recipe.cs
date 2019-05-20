using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSmartTrashService.Model
{
    public class recipe
    {
        public int id { get; set; }
        public string dato { get; set; }
        public string recipeDescription { get; set; }
        public string recipeTitle { get; set; }
        
        public recipe(int id, string dato, string recipeDescription, string recipeTitle)
        {
            this.id = id;
            this.dato = dato;
            this.recipeDescription = recipeDescription;
            this.recipeTitle = recipeTitle;
        }

        public recipe() { }
    }
}
