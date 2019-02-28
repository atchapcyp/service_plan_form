using System;
using System.Collections.Generic;
namespace Service_plan_form
{
    public class Service 

    {

        public string service_id { get; set; }
        public int[] stop_station { get; set; }
        public int service_quantity { get; set; }
        public int max_util { get; set; }
        const int train_cap = 200;
        public enum Type { INBOUND=1, OUTBOUND=0 }; // inbound outbound
        public DateTime[] depart_time;
        public List<Train_obj> trains = new List<Train_obj>();
        public int last_stop_index;
        public int first_stop_index;
        


        public Service(string id,int[] stop_station)
        {
            depart_time = new DateTime[stop_station.Length];
            service_id = id;
            this.stop_station= stop_station ;
            max_util = train_cap*Station.getDistance(getSourceStation(), getDestinationStation());
            last_stop_index = getDestinationStation();
            first_stop_index = getSourceStation();
        }

        public void addSchedulePeriod(int first_depart,int last_arrive)
        {   
            if (last_arrive - first_depart != stop_station.Length-1)
            {
                return;
            }
            int counter=0;
            DateTime time;
            for (int i = first_depart; i <= last_arrive; i++)
            {
                if (i < 24)
                {
                   time = new DateTime(1, 1, 1, i, 0, 0);
                }
                else
                {
                    time = new DateTime(1, 1, 2, i % 24, 0, 0);
                }
                depart_time.SetValue(time, counter++);
            }
        }

        public void addScheduleFromStart(int depart_hour,int depart_min)
        {
            DateTime time=new DateTime();
            int counter = 0;
            float in_min = 60.0f;
            int sum_from_start = 0;
            //travel time in hour 
            for (int i = first_stop_index; i <= last_stop_index; i++)
            {
                Console.WriteLine("DEPART_ STATION" + i);
                if (i == first_stop_index)
                {
                    time = new DateTime(1, 1, 1, depart_hour, depart_min, 0);
                    depart_time.SetValue(time, i);
                    Console.WriteLine("DEPART_ " + time);
                    continue;
                }
                float travel_time = (PhysicalData.distance_meter[i] - PhysicalData.distance_meter[i-1]) / PhysicalData.service_speed;
                int travel_time_miniute = (int)(travel_time * in_min);
                Console.WriteLine("TRAVEL_TIME : " + travel_time);
                Console.WriteLine("TRAVEL_TIME in min : " + travel_time_miniute);
                int travel_time_hour =(sum_from_start+ travel_time_miniute+depart_min )/ 60;
                
                time.AddHours(travel_time_hour);
                time.AddMinutes(travel_time_miniute);
                if (this.stop_station[i] == 1&&i!=last_stop_index)
                {
                    time.AddMinutes(PhysicalData.dwell_time);
                    sum_from_start += travel_time_miniute + PhysicalData.dwell_time;
                }else{
                    sum_from_start += travel_time_miniute;
                }
                if (depart_hour + travel_time_hour <= 23)
                {
                    time = new DateTime(1, 1, 1, depart_hour + travel_time_hour, (depart_min + sum_from_start) % 60, 0);
                }
                else
                {
                    time = new DateTime(1, 1, 2, (depart_hour + travel_time_hour)%24, (depart_min + sum_from_start) % 60, 0);
                }
                Console.WriteLine("DEPART_ "+time);
                depart_time.SetValue(time, i);
            }
        }

        public void addTrain(int capacity)
        {
            Train_obj _train = new Train_obj(capacity);
            trains.Add(_train);
        }

    
        public void show(){
            Console.WriteLine(this.service_id);

            foreach(int i in this.stop_station)
                Console.Write(i + " ");
         
            Console.WriteLine();
        }

        public int getLength(){
            return this.stop_station.Length;
        }

        public int getSourceStation()
        {
            for (int i = 0; i < this.getLength(); i++)
            {
                if (this.stop_station[i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int getDestinationStation()
        {
            for (int i = this.getLength()-1; i >= 0; i--)
            {
                if (this.stop_station[i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

       
    }
}
