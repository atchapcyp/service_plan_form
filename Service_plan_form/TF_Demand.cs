﻿using System;
using System.Collections.Generic;
namespace Service_plan_form
{
    public class TF_Demand
    {
        
        public int interval;
        public int dimension;
        public List<int[,]> demand=new List<int[,]>();
        public List<int[,]> unserve_demand = new List<int[,]>();
        public int[,] cal_demand = {
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0}};
        public int[,] carry_matrix = {
            {-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1}};

        public TF_Demand() { }
        public TF_Demand(int[,] composed_demand) // minute
        {
            this.dimension = composed_demand.GetLength(0);
            
                int[,] subdemand = new int[this.dimension, this.dimension];
                int[,] unserve_subdemand = new int[this.dimension, this.dimension];
                for (int i = 0; i < this.dimension; i++)
                {
                    for (int j = 0; j < this.dimension; j++)
                    {

                        subdemand[i, j] = composed_demand[i,j];
                        unserve_subdemand[i, j] = 0;
                        if (i == j)
                        {
                            subdemand[i, j] = 0;
                            unserve_subdemand[i, j] = 0;
                        }
                    }

                }
                this.demand.Add(subdemand);
                this.unserve_demand.Add(unserve_subdemand);
        }

        public TF_Demand(int dimension){
            int[,] subdemand = new int[dimension,dimension];
            int[,] unserve_subdemand = new int[dimension, dimension];
            this.dimension = dimension;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {

                    subdemand[i, j] = GetRandomNumber(10, 100);
                    unserve_subdemand[i, j] = 0;
                    if (i == j)
                    {
                        subdemand[i, j] = 0;
                        unserve_subdemand[i, j] = 0;
                    }
                }

            }
            this.demand.Add(subdemand);
            this.unserve_demand.Add(unserve_subdemand);
        }

        public TF_Demand(int timeframe_interval, int dimension) // minute
        {
            this.dimension = dimension;
            this.interval = timeframe_interval;
            int m = 24 * 60 / timeframe_interval;
            for (int k = 0; k < m; k++)
            {
                int[,] subdemand = new int[dimension, dimension];
                int[,] unserve_subdemand = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {

                        subdemand[i, j] = GetRandomNumber(100  , 100);
                        unserve_subdemand[i, j] = 0;
                        if (i == j)
                        {
                            subdemand[i, j] = 0;
                            unserve_subdemand[i, j] = 0;
                        }
                    }

                }
                this.demand.Add(subdemand);
                this.unserve_demand.Add(unserve_subdemand);
            }
        }

        public TF_Demand(int day,int timeframe_interval, int dimension) // minute
        {
            this.dimension = dimension;
            int m = 24 * 60 *day/ timeframe_interval;
            for (int k = 0; k < m; k++)
            {
                int[,] subdemand = new int[dimension, dimension];
                int[,] unserve_subdemand = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                       
                        subdemand[i, j] = GetRandomNumber(10, 100);
                        unserve_subdemand[i, j] = 0;
                        if (i == j)
                        {
                            subdemand[i, j] = 0;
                            unserve_subdemand[i, j] = 0;
                        }
                    }

                }
                this.demand.Add(subdemand);
                this.unserve_demand.Add(unserve_subdemand);
            }
        }
        public void set_unserve(int[,] unserve,int index){
            Array.Copy(unserve, this.unserve_demand[index],unserve.Length);
        }

        public int getTF_amount(){
            return this.demand.Count;
        }
        public int[,] getDemand(int i){
            return this.demand[i];
        }
        public int[,] getUnserveDemand(int i){
            return this.unserve_demand[i];
        }


        // dont forget to add unittest
        public void commit_update_demand(int[,] latest_demand,int i){ 
            if (demand.Count > i)
            {
                demand.RemoveAt(i);
                demand.Insert(i, latest_demand);
            }else{
               // throw Exception;
            }
        }
        public void sum_to_unserve_demand(int i){
            // throw error when i>dimension
            for (int j = 0; j < this.dimension;j++){
                for (int k = 0; k < this.dimension;k++){
                    demand[i][j, k]+=unserve_demand[i-1][j,k];
                }
            }
        }

        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public TF_Demand(int timeframe_interval, int dimension,string fortest) // minute
        {
            this.dimension = dimension;
            this.interval = timeframe_interval;
            int m = 24 * 60 / timeframe_interval;
            for (int k = 0; k < m; k++)
            {
                int[,] subdemand = new int[dimension, dimension];
                int[,] unserve_subdemand = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        subdemand[i, j] = GetRandomNumber(100, 100);
                        unserve_subdemand[i, j] = 50;
                        if (i == j)
                        {
                            subdemand[i, j] = 0;
                            unserve_subdemand[i, j] = 25;
                        }
                    }

                }
                this.demand.Add(subdemand);
                this.unserve_demand.Add(unserve_subdemand);
            }
        }

        public TF_Demand Gen_Outbound_demand()
        {
            TF_Demand outbound = new TF_Demand(1440, this.dimension,"O","B");
          
            
            
                for (int i = 0; i < this.dimension; i++)
                {
                    for (int j = 0; j < this.dimension; j++)
                    {
                        if (i < j)
                        {
                            outbound.demand[0][i, j] = this.demand[0][i, j];
                        }else{
                            outbound.demand[0][i, j]= 0;
                        }
                    }
                }
            
            return outbound;
        }

        public TF_Demand Gen_Inbound_demand()
        {
            TF_Demand inbound = new TF_Demand(this.interval, this.dimension,"I","B");

            for (int k = 0; k < 1; k++)
            {

                for (int i = 0; i < this.dimension; i++)
                {
                    for (int j = 0; j < this.dimension; j++)
                    {

                        if (i > j)
                        {
                            int m = this.dimension-1 - i;
                            int l = dimension-1 - j;
                            inbound.demand[k][m, l] = this.demand[k][i, j];
                        }
                        else
                        {
                            inbound.demand[k][j, i] = 0;
                        }
                    }
                }
            }
                return inbound;
            
        }

        public TF_Demand(int timeframe_interval, int dimension,String a,String b) // minute
        {
            this.dimension = dimension;
            
                int[,] subdemand = new int[dimension, dimension];
                int[,] unserve_subdemand = new int[dimension, dimension];
                this.demand.Add(subdemand);
                this.unserve_demand.Add(unserve_subdemand);

            
        }

        public void get_demand(int i){
            int[,] current_demand = this.demand[i];
            for (int out_loop = 0; out_loop < this.dimension; out_loop++)
            {
                for (int in_loop = out_loop + 1; in_loop < this.dimension; in_loop++)
                {
                    cal_demand[out_loop, in_loop] += current_demand[out_loop, in_loop];
                }
            }
        }

        public int[,] To_station_class(int arrived_station){
            int[,] demand_class = new int[demand.Count, this.dimension];
           
            for (int i = 0; i < demand.Count; i++)
            {

                    for (int k = 0; k < this.dimension; k++)
                {
                    Console.WriteLine("i : %d arrive station : %d k : %d"+ i + arrived_station + k);
                        demand_class[i,k] = this.demand[i][arrived_station, k];
                    }
                   

            }
            
            return demand_class;
        }
    }
}
