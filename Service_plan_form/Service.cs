﻿using System;
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

        public Service(string id,int[] stop_station)
        {
            depart_time = new DateTime[stop_station.Length];
            service_id = id;
            this.stop_station= stop_station ;
            max_util = train_cap*Station.getDistance(getSourceStation(), getDestinationStation());
           
        }

        public void addDatePeriod(int first_depart,int last_arrive)
        {   
            if (last_arrive - first_depart != 4)
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
