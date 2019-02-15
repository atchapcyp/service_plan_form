using System;
using System.Collections.Generic;
using Service_plan_form.Demands;
namespace Service_plan_form
{
    public class Station
    {
        public static int[,] arr_distance = {
                { 0, 30, 60, 85, 110},
                {30,0,30,55,80},
                {60,30,0,25,50},
                {85,55,25,0,25},
                {110,80,50,25,0}};

        public List<double[]> demand_station = new List<double[]>();
        public int tf_size_min=-1;
        public string station_name;
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
            var tf_amount = (dm.Count / numberOfStation)-1;
            var offset = tf_amount * formStation;
            for (int i =offset; i < tf_amount+offset; i++)
            {
                demand_station.Add(dm[i].ToArray());
            }
            var diff= dm[1].EndTime.Subtract(dm[1].StartTime);
            this.tf_size_min =(int)diff.TotalMinutes;
            formStation += 1;
            station_name = "Station" + formStation;
        }
    }
}
