﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service_plan_form
{
    public class Train_obj
    {
        public int cap = 150;
        public int remain_cap = 150;
        public int[] passenger = new int[20];
        public DateTime[] HourTimes = new DateTime[20];
        public Train_obj()
        { }
        public Train_obj(int c)
        {
            cap = c;
            remain_cap = cap;
        }
        public Train_obj(string name,int c)
        {
            cap = c;
            remain_cap = cap;
        }

        public void getOn(int amount, int i){
            this.remain_cap -= amount;
            passenger[i] += amount;
        }
        public void getOff(int i){
            this.remain_cap += passenger[i];
            passenger[i] = 0;
        }

        public void getOn(int amount, DateTime getOn_hour,int i)
        {
            this.remain_cap -= amount;
            passenger[i] += amount;
            this.HourTimes[i] = getOn_hour;
        }
    }
}
