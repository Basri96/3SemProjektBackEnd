using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSmartTrashService.Model
{
    public class weight
    {
        public int id { get; set; }
        public string date { get; set; }
        public string weightMeasure { get; set; }

        public weight(string date, string weight)
        {
            this.date = date;
            this.weightMeasure = weight;
        }
        public weight() { }
    }
}
