using System;
using System.Collections;
using System.Collections.Generic;
using Service_plan_form.Demands;
namespace Service_plan_form
{
    public class Station : IEnumerable
    {
        public static int[,] arr_distance = {
                { 0, 30, 60, 85, 110},
                {30,0,30,55,80},
                {60,30,0,25,50},
                {85,55,25,0,25},
                {110,80,50,25,0}};

        public List<double[]> demand_station = new List<double[]>();
        public int tf_size_min=-1;
        public List<DateTime> start_time = new List<DateTime>();
        public List<DateTime> stop_time = new List<DateTime>();
        public string station_name;
        public int tf_count;
        
        /*public Station(TF_Demand tf_demand)
        {
              for (int i = 0; i < tf_demand.dimension;i++){
                demand_station.Add(tf_demand.To_station_class(i));
            }
        }*/

        public static int getDistance(int s,int d){
            int distance=0;
            if (s==d){
                return distance;
            }
            if (s<d){
                distance = arr_distance[0, d] - arr_distance[0, s];
            }else if (s>d){
                distance = arr_distance[4, d] - arr_distance[4, s];
            }
            return distance;
        }

        public Station() { }
        public Station(List<Demand_blueprint> dm,int formStation,int numberOfStation)
        {
           // Console.WriteLine("dm.count " + dm.Count + "number of station " + numberOfStation);
            var tf_amount = (dm.Count / numberOfStation);
            tf_count = tf_amount;
            var offset = tf_amount * formStation;
            for (int i =offset+1; i < tf_amount+offset; i++)
            {
                //Console.WriteLine("tf_amount " + tf_amount + " offset" + offset + " formstation " + formStation);
                demand_station.Add(dm[i].ToArray());
                start_time.Add(dm[i].StartTime);
                stop_time.Add(dm[i].EndTime);
               // Console.WriteLine(demand_station.Count);
                //Console.WriteLine("INSERT COMPLETE"+i);

            }
            var diff= dm[1].EndTime.Subtract(dm[1].StartTime);
            this.tf_size_min =(int)diff.TotalMinutes;
            formStation += 1;
            station_name = "Station" + formStation;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (DateTime val in start_time)
            {
                yield return val;
            }
        }
    }
}
