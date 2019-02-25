﻿using System;
namespace Service_plan_form
{
    public class Service 

    {
        public string service_id { get; set; }
        public int[] stop_station { get; set; }
        public int service_quantity { get; set; }
        public int max_util { get; set; }
        const int train_cap = 200;

        public Service(string id,int[] stop_station)
        {
            service_id = id;
            this.stop_station= stop_station ;
            max_util = train_cap*Station.getDistance(getSourceStation(), getDestinationStation());

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