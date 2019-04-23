using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form
{
    public class Service_summary : IEnumerable<int[]>
    {
        private static int lastID = 0;
        public int ID
        {
            get;
            set;
        }
        public string Service_name
        {
            get;
            set;
        }

        public int[] StopStation { get; set; }

        public DateTime[] Departure_time
        {
            get;
            set;
        }
        public int[,] Actual_serve_demand
        {
            get;
            set;
        }
        public float Profitability
        {
            get;
            set;
        }
        public float Utilization_percent
        {
            get;
            set;
        }
        public int Income
        {
            get;
            set;
        }

        public float operation_cost;
        public double[,] over_serve;

        public int indexOfFirstStation()
        {
            for (var i = 0; i < this.StopStation.Length; i++)
            {
                if (StopStation[i] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public Service_summary(String name, int[] Stopstation, DateTime[] departure, int[,] actual_dem, float utilizationPercent, int income)
        {
            this.ID = ++lastID; 
            Service_name = name;
            Departure_time = departure;
            Actual_serve_demand = actual_dem;
           
            Utilization_percent = utilizationPercent;
            this.Income = income;
            this.StopStation = Stopstation;
            this.operation_cost = PhysicalData.operation_cost_per_meter * getDistance(this.StopStation);
            this.Profitability = this.Income - this.operation_cost;
            Console.WriteLine(Profitability +" Profit " + Income+" Income "+operation_cost+" operation");
            setOverDemand();
            Console.WriteLine("______________________________________");
            Service_algo.showarray(this.over_serve);
            Console.WriteLine("______________________________________");
        }

        public void setOverDemand()
        {
            over_serve = new double[this.Actual_serve_demand.GetLength(0),this.Actual_serve_demand.GetLength(0)];
            var size = Actual_serve_demand.GetLength(0);
            var (source_index, des_index) = getSouceDesIndex();
            for (int z = source_index; z < des_index; z++)
            {
                var result = 0;
               for (int i = source_index; i < z+1 ; i++)
                {
                    for (int j = size-1 ; j > z; j--)
                    {
                        Console.WriteLine("____LOOP__{0}_{1}_{2}_"+ Actual_serve_demand[i,j],z,i,j);
                        Console.WriteLine("______________________________________ actual "+ Actual_serve_demand[i,j]);
                        result += Actual_serve_demand[i,j];
                    }
                }
               Console.WriteLine("______________________________________ RESULT "+ result);
               this.over_serve[z, z+1]=500-result;
            }

        } 

        public int getDistance(int[] StopStation)
        {
            Console.WriteLine("___GETDISTANT "+Service_algo.PrettyPrintArrays(StopStation));
            int source_index=0, des_index=0;
            for (var i = StopStation.Length-1; i >= 0 ; i--)
            {
                if (StopStation[i] ==1 )
                {
                    des_index = i;
                    break;
                }
            }
            for (var i = 0; i <StopStation.Length; i++)
            {
                if (StopStation[i] == 1)
                {
                    source_index = i;
                    break;
                }
            }
            Console.WriteLine("souce_index " + source_index+ " Des_index "+des_index);
            var result = Math.Abs(PhysicalData.distance_meter[source_index] - PhysicalData.distance_meter[des_index]);
            return result;
        }

        public (int,int) getSouceDesIndex()
        {
            Console.WriteLine("__GET SOURCE_DEST "+Service_algo.PrettyPrintArrays(StopStation));
            int source_index=0, des_index=0;
            for (var i = StopStation.Length-1; i >= 0 ; i--)
            {
                if (StopStation[i] ==1 )
                {
                    des_index = i;
                    break;
                }
            }
            for (var i = 0; i <StopStation.Length; i++)
            {
                if (StopStation[i] == 1)
                {
                    source_index = i;
                    break;
                }
            }
            Console.WriteLine("souce_index " + source_index+ " Des_index "+des_index);
            return (source_index,des_index);
        }

        public double[] getDemandWithStation(int station_index)
        {
            double[] result=new double[this.StopStation.Length];
            for (int i = 0; i < Actual_serve_demand.GetLength(0); i++)
            {
                result.SetValue(Actual_serve_demand[station_index, i],i);
                
            }
       return result;
        }

        public IEnumerator<int[]> GetEnumerator()
        {
            yield return StopStation;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
