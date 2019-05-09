using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSmartTrashService.Model
{
    public class recipe
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string recipeDescription { get; set; }
        public string recipeTitle { get; set; }
        
        public recipe(int id, DateTime date, string recipeDescription, string recipeTitle)
        {
            this.id = id;
            this.date = date;
            this.recipeDescription = recipeDescription;
            this.recipeTitle = recipeTitle;
        }

        public recipe() { }
    }
}
