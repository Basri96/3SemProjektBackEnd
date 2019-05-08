using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSmartTrashService.Model
{
    public class recipe
    {
        int id { get; set; }
        DateTime date { get; set; }
        string recipeDescription { get; set; }
        string recipeTitle { get; set; }
        
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
