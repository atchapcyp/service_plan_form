using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service_plan_form.Attributes;

namespace Service_plan_form.Demands
{
    public class Demand
    {

        [DataNames("Column0")]
        public DateTime StartTime { get; set; }

        [DataNames("Column1")]
        public DateTime EndTime { get; set; }

        [DataNames("C2", "Column2")]
        public double Station1 { get; set; }

        [DataNames("C3", "Column3")]
        public double Station2 { get; set; }

        [DataNames("C4", "Column4")] //"Column5 is NameTag of dataset"
        public double Station3 { get; set; }
        
    }
}

