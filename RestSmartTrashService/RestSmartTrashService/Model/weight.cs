using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSmartTrashService.Model
{
    public class weight
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public float weightMeasure { get; set; }

        public weight(DateTime date, float weight)
        {
            this.date = date;
            this.weightMeasure = weight;
        }
        public weight() { }
    }
}
