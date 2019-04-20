using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form
{
    class PhysicalData
    {
        public static readonly int[,] distance ={
            { 0, 30, 60, 85, 110},
            {30,0,30,55,80},
            {60,30,0,25,50},
            {85,55,25,0,25},
            {110,80,50,25,0}};
        public static readonly int[,] ticket_price =  {
        { 0,    278,    320,    393,    535},
        { 278,  0,      278,    320,    393},
        { 320,  278,    0,      278,    320},
        { 393,  320,    278,    0,      278},
        { 535,  393,    320,    278,    0}
        };

        public static readonly int[] distance_meter = {0,62000,106000,173000,251000 };
        public static readonly float operation_cost_per_meter = 1.0f;
        public static readonly float service_speed = 100000; // meter per hour
        public static readonly int dwell_time=5; // miniute
        public static readonly int headway = 10; //miniute
        public static readonly int utilize_percent = 50;
        public static readonly int under_util_plus_min = 5;
        public static readonly int TrainSize = 200;

    }
}

