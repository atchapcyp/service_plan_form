using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form
{
    public class Service_summary : IEnumerable<int[]>
    {
        private static int lastID = 0;
        public int ID
        {
            get;
            set;
        }
        public string Service_name
        {
            get;
            set;
        }

        public int[] StopStation { get; set; }

        public DateTime[] Departure_time
        {
            get;
            set;
        }
        public int[,] Actual_serve_demand
        {
            get;
            set;
        }
        public float Profitability
        {
            get;
            set;
        }
        public float Utilization_percent
        {
            get;
            set;
        }
        public int Income
        {
            get;
            set;
        }

        public int indexOfFirstStation()
        {
            for (var i = 0; i < this.StopStation.Length; i++)
            {
                if (StopStation[i] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public Service_summary(String name, int[] Stopstation, DateTime[] departure, int[,] actual_dem, float profitability, float utilizationPercent, int income)
        {
            this.ID = ++lastID; 
            Service_name = name;
            Departure_time = departure;
            Actual_serve_demand = actual_dem;
            this.Profitability = profitability;
            Utilization_percent = utilizationPercent;
            this.Income = income;
            this.StopStation = Stopstation;
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
