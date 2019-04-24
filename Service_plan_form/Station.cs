using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Service_plan_form.Demands;
namespace Service_plan_form
{
    public class Station : IEnumerable
    {
        public static readonly int[] distance_meter = {0, 62000, 106000, 173000, 251000};
        public List<double[]> demand_station = new List<double[]>();
        public List<double[]> remaining_demand = new List<double[]>();
        public List<double[]> served_demand = new List<double[]>();
        
        public int tf_size_min = -1;
        public List<DateTime> start_time = new List<DateTime>();
        public List<DateTime> stop_time = new List<DateTime>();
        public string station_name;
        public int tf_count;
        public double sum_waiting_time;
        public double sum_passenger;
       

        // input remaining demand , Used service station index in that List
        

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
            tf_count = tf_amount-1; // -1 is to exclude table header of when reader
            var offset = tf_amount * formStation;
            for (int i =offset+1; i < tf_amount+offset; i++)
            {
                
                demand_station.Add(dm[i].ToArray());
                start_time.Add(dm[i].StartTime);
                stop_time.Add(dm[i].EndTime);
            }

            demand_station[0].Clone();
            var diff= dm[1].EndTime.Subtract(dm[1].StartTime);
            this.tf_size_min =(int)diff.TotalMinutes;
            formStation += 1;
            station_name = "Station" + formStation;
           

           
            for (int index = 0; index < demand_station.Count; index++)
            {
                served_demand.Add(new double[numberOfStation]);
                remaining_demand.Add(new double[numberOfStation]);
            }

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

        public void calWaiting(int station_index)
        {
            var demArr = sumDemArray(station_index);
            var servedArr = sumServedArray(station_index);
            double[] must_served = new double[tf_count];
            double[] wait_to_next_tf = new double[tf_count];
            must_served[0] = demArr[0]; // init must served
            wait_to_next_tf[0] = must_served[0] - servedArr[0]; // init wait passenger counter

            for (int i = 1; i < tf_count; i++)
            {
                must_served[i] = wait_to_next_tf[i-1] + demArr[i];
                wait_to_next_tf[i] = must_served[i] - servedArr[i];
            }

            this.sum_waiting_time = wait_to_next_tf.Sum(); // hours
            this.sum_passenger = servedArr.Sum();
        }

        public double[] sumDemArray(int station_index)
        {
            double[] result_set = new double[tf_count];
           for (int i = 0; i < tf_count; i++)
            {
                for (int j = station_index; j <  demand_station[0].Length; j++)
                {
                    result_set[i] += served_demand[i][j];
                }
            }
            return result_set;
        }

        public double[] sumServedArray(int station_index)
        {
            double[] result_set = new double[tf_count];
            for (int i = 0; i < tf_count; i++)
            {
                for (int j = station_index; j <  demand_station[0].Length; j++)
                {
                    result_set[i] += remaining_demand[i][j];
                }
            }
            return result_set;
         }
    }
}
