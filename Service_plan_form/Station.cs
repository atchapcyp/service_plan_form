using System;
using System.Collections;
using System.Collections.Generic;
using Service_plan_form.Demands;
namespace Service_plan_form
{
    public class Station : IEnumerable
    {
        public static readonly int[] distance_meter = {0, 62000, 106000, 173000, 251000};
        public List<double[]> demand_station = new List<double[]>();
        public int tf_size_min = -1;
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

        // input remaining demand , Used service station index in that List
        public void update_demand(int[,] served_demand,Service service,int station_index)
        {
            Console.WriteLine("IN UPDATE"+service.depart_time[station_index].ToShortTimeString());
            int counter = 0;
            foreach (var time in start_time)
            {
                if ( time.Hour.Equals(service.depart_time[station_index].Hour))
                {
                    Console.WriteLine("IN HERE UPDATE");
                    for (var i = 0; i < 5; i++)
                    {
                        Console.WriteLine("IN HERE UPDATE "+counter);
                        Console.WriteLine("before "+this.demand_station[counter][i]);
                        this.demand_station[counter][i] -=  served_demand[station_index,i];
                        Console.WriteLine("after " + this.demand_station[counter][i]);
                    }
                    }
                counter++;

            }
            
        }

    public static int getDistance(int s,int d){
            int distance=0;
            if (s==d){
                return distance;
            }
            if (s<d){
                distance = PhysicalData.distance[0, d] - PhysicalData.distance[0, s];
            }else if (s>d){
                distance = PhysicalData.distance[4, d] - PhysicalData.distance[4, s];
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

        public static int getDistan_Meter(int s,int d) {
            int distance_result = 0;
            if (s == d)
            {
                return distance_result;
            }
            if (s < d)
            {
                distance_result = distance_meter[d] - distance_meter[s];
            }
            else if (s > d)
            {
                distance_result = distance_meter[s] - distance_meter[d];
            }
            return distance_result;
           
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
