using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service_plan_form.Attributes;

namespace Service_plan_form.Demands
{
    public class Demand_blueprint_inbound
    {

        [DataNames("Column0")]
        public DateTime StartTime { get; set; }

        [DataNames("Column1")]
        public DateTime EndTime { get; set; }

        [DataNames("Column2")]
        public double Station5 { get; set; }

        [DataNames("Column3")]
        public double Station4 { get; set; }

        [DataNames("Column4")]
        public double Station3 { get; set; }

        [DataNames("Column5")]
        public double Station2 { get; set; }

        [DataNames("Column6")]
        public double Station1 { get; set; }


        public double[] ToArray()
        {
            double[] a = { this.Station5, this.Station4, this.Station3, this.Station2, this.Station1 };
            return a;
        }
    }
}
