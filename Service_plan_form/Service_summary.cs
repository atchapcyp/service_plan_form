using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form
{
    class Service_summary : IEnumerable<int>
    {

        public int[] StopStation { get; set; }
        public DateTime[] departure_time;
        public int[,] actual_serve_demand;
        public float profitability;




        public IEnumerator<int> GetEnumerator()
        {
            yield return 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
