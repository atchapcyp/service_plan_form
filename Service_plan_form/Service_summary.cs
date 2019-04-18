using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form
{
    public class Service_summary : IEnumerable<int[]>
    {
        public string Service_name;
        public int[] StopStation { get; set; }
        public DateTime[] departure_time;
        public int[,] actual_serve_demand;
        public float profitability;
        public float utilization_percent;
        public int income;

        public Service_summary()
        {

        }



        public IEnumerator<int[]> GetEnumerator()
        {
            yield return StopStation;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
