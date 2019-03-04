using System;
using System.Collections.Generic;
namespace Service_plan_form
{
    public class Service 

    {

        public string ServiceId { get; set; }
        public int[] StopStation { get; set; }
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
            ServiceId = id;
            this.StopStation= stop_station ;
            max_util = train_cap*Station.getDistance(getSourceStation(), getDestinationStation());
            last_stop_index = getDestinationStation();
            first_stop_index = getSourceStation();
        }
        public Service(string id, int[] stop_station,int depart_hour,int depart_min)
        {
            depart_time = new DateTime[stop_station.Length];
            ServiceId = id;
            this.StopStation = stop_station;
            max_util = train_cap * Station.getDistance(getSourceStation(), getDestinationStation());
            last_stop_index = getDestinationStation();
            first_stop_index = getSourceStation();
            this.AddScheduleFromStart(depart_hour, depart_min);
        }

        public void AddSchedulePeriod(int first_depart,int last_arrive)
        {   
            if (last_arrive - first_depart != StopStation.Length-1)
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

        public void AddScheduleFromStart(int depart_hour,int depart_min)
        {
            DateTime time=new DateTime();
            float in_min = 60.0f;
            int sum_from_start = 0;
            time = new DateTime(1, 1, 1, depart_hour, depart_min, 0);
            depart_time.SetValue(time, 0);
            Console.WriteLine("DEPART_ " + time);
            //travel time in hour 
            for (int i = 1; i <= StopStation.Length-1; i++)
            {
                Console.WriteLine("DEPART_ STATION" + i);
                float travel_time = (PhysicalData.distance_meter[i] - PhysicalData.distance_meter[i-1]) / PhysicalData.service_speed;
                int travel_time_miniute = (int)(travel_time * in_min);
                Console.WriteLine("TRAVEL_TIME : " + travel_time);
                Console.WriteLine("TRAVEL_TIME in min : " + travel_time_miniute);
                int travel_time_hour =(sum_from_start+ travel_time_miniute+depart_min )/ 60;
                
                if (this.StopStation[i] == 1&&i!=last_stop_index)
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

        public void AddScheduleFromStart_MANUAL(int depart_hour, int depart_min) // set start time for 1st start station then trace back
        {
            DateTime time = new DateTime();
            DateTime time2 = new DateTime(1, 1, 1, depart_hour, depart_min, 0);
            float in_min = 60.0f;
            int sum_from_start = 0;
            int sum_from_start2 = 0;
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
                float travel_time = (PhysicalData.distance_meter[i] - PhysicalData.distance_meter[i - 1]) / PhysicalData.service_speed;
                int travel_time_miniute = (int)(travel_time * in_min);
                Console.WriteLine("TRAVEL_TIME : " + travel_time);
                Console.WriteLine("TRAVEL_TIME in min : " + travel_time_miniute);
                int travel_time_hour = (sum_from_start + travel_time_miniute + depart_min) / 60;

                if (this.StopStation[i] == 1 && i != last_stop_index)
                {
                    time.AddMinutes(PhysicalData.dwell_time);
                    sum_from_start += travel_time_miniute + PhysicalData.dwell_time;
                }
                else
                {
                    sum_from_start += travel_time_miniute;
                }

                if (depart_hour + travel_time_hour <= 23)
                {
                    time = new DateTime(1, 1, 1, depart_hour + travel_time_hour, (depart_min + sum_from_start) % 60, 0);
                }
                else
                {
                    time = new DateTime(1, 1, 2, (depart_hour + travel_time_hour) % 24, (depart_min + sum_from_start) % 60, 0);
                }
                Console.WriteLine("DEPART_ " + time);
                depart_time.SetValue(time, i);
            }
            for (int i = first_stop_index; i > 0; i--)
            {

                float travel_time = (PhysicalData.distance_meter[i] - PhysicalData.distance_meter[i - 1]) / PhysicalData.service_speed;
                int travel_time_miniute = (int)(travel_time * in_min);
                sum_from_start2 += travel_time_miniute;
                int travel_time_hour = ((60 * depart_hour) - sum_from_start2 + depart_min - PhysicalData.dwell_time) / 60;
                Console.WriteLine("ODD_DEPART_ " + travel_time_hour);
                time2 = new DateTime(1, 1, 1, travel_time_hour, (depart_min - sum_from_start2 - PhysicalData.dwell_time + 240) % 60, 0);
                Console.WriteLine("ODD_DEPART_ " + time2);
                depart_time.SetValue(time2, i - 1);
            }

        }

        public void AddTrain(int capacity)
        {
            Train_obj _train = new Train_obj(capacity);
            trains.Add(_train);
        }

    
        public void show(){
            Console.WriteLine(this.ServiceId);

            foreach(int i in this.StopStation)
                Console.Write(string.Format("[{0}]\t ", i));

            Console.WriteLine();
        }

        public int getLength(){
            return this.StopStation.Length;
        }

        public int getSourceStation()
        {
            for (int i = 0; i < this.getLength(); i++)
            {
                if (this.StopStation[i] == 1) 

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
                if (this.StopStation[i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

       
    }
}
