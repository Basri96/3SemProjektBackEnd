using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSmartTrashService.Model
{
    public class weightMeassure
    {
        DateTime date { get; set; }
        float weight { get; set; }

        public weightMeassure(DateTime date, float weight)
        {
            this.date = date;
            this.weight = weight;
        }
        public weightMeassure() { }
    }
}
