using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Service_plan_form.Demands;
using DateTime = System.DateTime;

namespace Service_plan_form
{
    public static class Service_algo
    {

        public static void showarray(int[,] passeng_num)
        {
            //show 5x5 array
            int rowLength = passeng_num.GetLength(0);
            int colLength = passeng_num.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}\t ", passeng_num[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            
        }
        public static void showarray(double[,] passeng_num)
        {
            //show 5x5 array
            int rowLength = passeng_num.GetLength(0);
            int colLength = passeng_num.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}\t ", passeng_num[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            
        }

        public static string showarray_toStr(int[,] passeng_num)
        {
            //show 5x5 array
            int rowLength = passeng_num.GetLength(0);
            int colLength = passeng_num.GetLength(1);
            string a="";
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (passeng_num[i, j] >= 1000)
                    {
                        a += passeng_num[i, j].ToString().PadRight(4);
                    }
                    else if (passeng_num[i, j] < 1000 && passeng_num[i, j] >= 100)
                    {
                        a += passeng_num[i, j].ToString().PadRight(5);
                    }
                    else if (passeng_num[i,j]<100 && passeng_num[i,j]>=10)
                    {
                        a += passeng_num[i, j].ToString().PadRight(7);
                    }
                    else
                    {
                        a += passeng_num[i, j].ToString().PadRight(8);
                    }
                }
                a += "\n";
            }
            return a;

        }
        public static void Train_a_b_c_d_e(TF_Demand demands, Train_obj train, Service aService, int timeframe)
        {
            int[,] actual_getoff = new int[5, 5];
            int get_off_next_station = 0;
            int i, j, k, next_station_index = -1;
            for (i = 0; i < 5; i++)
            {
                if (aService.StopStation[i] == 0)
                {
                    continue;
                }
                for (int a = 4; a > i; a--)
                {
                    if (aService.StopStation[a] == 1)
                    {
                        next_station_index = a;
                    }
                }

                int demand_at_station = 0;
                Console.WriteLine("Remainning Seat : " + train.remain_cap);
                get_off_next_station = train.passenger[i];
                Console.WriteLine("Number of getting off passenger at station " + i + " = " + get_off_next_station);
                train.getOff(i);
                Console.WriteLine("Remainning Seat after get off : " + train.remain_cap);
                for (k = i + 1; k < 5; k++) // sum of demand at station i
                {
                    if (aService.StopStation[k] == 0) { continue; }
                    demand_at_station += demands.cal_demand[i, k];
                    Console.WriteLine("Demand at station " + i + " to station " + k + " is " + demands.cal_demand[i, k]);
                }
                Console.WriteLine("All of Demand at station " + i + " is " + demand_at_station);
                if (demand_at_station < train.remain_cap)
                {
                    for (j = i + 1; j < 5; j++)
                    {
                        if (aService.StopStation[j] == 0) { continue; }
                        train.getOn(demands.cal_demand[i, j], j);

                        demands.cal_demand[i, j] = 0;
                        clear_remain_demand(demands, timeframe, i, j);
                    }
                }
                else
                {
                    double ratio = 1.0 * train.remain_cap / demand_at_station;
                    demand_at_station = 0;
                    int fill_demand;
                    for (j = i + 1; j < 5; j++)
                    {
                        if (aService.StopStation[j] == 0) { continue; }

                        fill_demand = (int)(demands.cal_demand[i, j] * ratio);


                        demand_at_station += fill_demand;

                    }
                    int remain_cap = train.remain_cap;
                    remain_cap -= demand_at_station;
                    for (j = i + 1; j < 5; j++)
                    {
                        if (aService.StopStation[j] == 0) { continue; }
                        Console.WriteLine("..............Debug train remainning seat  " + train.remain_cap);
                        Console.WriteLine("..............Debug Demand at station      " + demands.cal_demand[i, j]);
                        Console.WriteLine("..............Debug ratio      " + ratio);
                        fill_demand = (int)(demands.cal_demand[i, j] * ratio);

                        Console.WriteLine("..............Debug fill_demand  " + fill_demand);
                        actual_getoff[i, j] = fill_demand;
                        if (remain_cap > 0 && demands.cal_demand[i, j] > fill_demand)
                        {
                            demands.cal_demand[i, j] -= (fill_demand + 1);
                            train.getOn(fill_demand + 1, j);
                            update_remain_demand(demands, timeframe, fill_demand + 1, i, j);
                            remain_cap -= 1;
                        }
                        else
                        {
                            demands.cal_demand[i, j] -= fill_demand;
                            train.getOn(fill_demand, j);
                            update_remain_demand(demands, timeframe, fill_demand, i, j);
                        }
                        demand_at_station += fill_demand;

                    }
                    Console.WriteLine("..............train remainning seat AFTER  " + train.remain_cap);
                }
            }
        }  

        public static void update_remain_demand(TF_Demand demands, int timeframe, int fill_demand, int i, int j) {
            if (demands.carry_matrix[i, j] == -1) {
                demands.demand[timeframe][i, j] -= fill_demand;
            }
            else {
                for (int k = demands.carry_matrix[i, j]; k <= timeframe; k++) {
                    if (demands.demand[k][i, j] < fill_demand) {
                        fill_demand -= demands.demand[k][i, j];
                        demands.demand[k][i, j] = 0;
                    }
                    else {
                        demands.demand[k][i, j] -= fill_demand;
                        return;
                    }
                }
            }
        }
        public static void clear_remain_demand(TF_Demand demands, int timeframe, int i, int j)
        {
            if (demands.carry_matrix[i, j] == -1)
            {
                demands.demand[timeframe][i, j] = 0;
            }
            else
            {
                for (int k = demands.carry_matrix[i, j]; k <= timeframe; k++)
                {
                    demands.demand[k][i, j] = 0;

                }
            }
        }

        public static Boolean isDemandEmpty_with_service(int[,] demand, Service services)
        {
            for (int i = 0; i < 5; i++)
            {
                if (services.StopStation[i] == 0)
                    continue;
                else
                {
                    for (int j = i + 1; j < 5; j++)
                    { if (services.StopStation[j] == 0)
                            continue;
                        if (demand[i, j] != 0)
                            return false;
                    }
                }
            }
            return true;
        }

        public static Boolean isDemandEmpty(int[,] demand)
        {
            foreach (int value in demand)
            {
                if (value != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static public void fixedValue_5x5(int[,] passeng_num, int num)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    passeng_num[i, j] = num;

                    if (i == j)
                    {
                        passeng_num[i, j] = 0;
                    }
                }

            }
        }
        static public void all_service_n_time(int[,] outbound_demand, Train_obj train, List<Service> services) {
            int indexOfMaxUtilize;
            float most_utilize = 0;
            while (!isDemandEmpty(outbound_demand)) {
                for (int i = 0; i < services.Count; i++) {
                    float service_util = Utilize_service(outbound_demand, train, services[i]);
                    float max_util = max_utilize_of_service(train.cap, services[i]);
                    float util_percent = service_util / max_util * 100;
                    if (util_percent > most_utilize) {
                        indexOfMaxUtilize = i;
                    }
                }

            }
        }

        static public (int, float) index_of_most_utilize_service(int[,] outbound_demand, Train_obj train, List<Service> services)
        {
            int counter = 0;
            int index_of_max_util = 0;
            float util_percent = 0;
            for (int i = 0; i < services.Count; i++)
            {
                services[i].show();
                Console.WriteLine("----- ROUND " + ++counter + " ----- ");
                showarray(outbound_demand);
                float service_util = Utilize_service(outbound_demand, train, services[i]);
                float max_util = max_utilize_of_service(train.cap, services[i]);
                float new_util_percent = service_util / max_util * 100;
                Console.WriteLine("This service utilize : " + service_util);
                Console.WriteLine("MAX service utilize : " + max_util);
                Console.WriteLine("Percent service utilize : " + new_util_percent);
                if (Math.Abs(100 - new_util_percent) <= float.Epsilon) {//float compare
                    Console.WriteLine("FLOAT CHECK EQUAL 100");
                    return (i, 100);
                }
                if (new_util_percent > util_percent) {
                    util_percent = new_util_percent;
                    index_of_max_util = i;
                }
            }

            return (index_of_max_util, util_percent);
        }
        static public (int, float) new_index_of_most_utilize_service(List<int[,]> outbound_demand, Train_obj train, List<Service> services)
        {
            int counter = 0;
            int index_of_max_util = 0;
            float util_percent = 0;
            for (int i = 0; i < services.Count; i++)
            {
                if (isDemandEmpty(outbound_demand[i]))
                {
                    continue;
                }
                Console.WriteLine("----- ROUND " + ++counter + " ----- ");
                services[i].show();
                showarray(outbound_demand[i]);
                float service_util = Utilize_service(outbound_demand[i], train, services[i]);
                float max_util = max_utilize_of_service(train.cap, services[i]);
                float new_util_percent = service_util / max_util * 100;
                Console.WriteLine("This service utilize : " + service_util);
                Console.WriteLine("MAX service utilize : " + max_util);
                Console.WriteLine("Percent service utilize : " + new_util_percent);
                if (Math.Abs(100 - new_util_percent) <= float.Epsilon)
                {//float compare
                    Console.WriteLine("FLOAT CHECK EQUAL 100");
                    return (i, 100);
                }
                if (new_util_percent > util_percent)
                {
                    util_percent = new_util_percent;
                    index_of_max_util = i;
                }
            }

            return (index_of_max_util, util_percent);
        }
        static public void actual_run(TF_Demand demands, Train_obj train, Service service, int timeframe) {
            Console.WriteLine("ACTUAL_RUN . ");
            Console.WriteLine(service.ServiceId);
            Train_a_b_c_d_e(demands, train, service, timeframe);
            Console.WriteLine("This is remainning demand . ");
            showarray(demands.cal_demand);
            Console.WriteLine("This is CURRENT demand . ");
            showarray(demands.demand[timeframe]);
            Console.WriteLine("------------------ ");
        }

        static public void orchestrator_of_service(TF_Demand outbound_demand, Train_obj train, List<Service> services) {
            for (int i = 0; i < outbound_demand.demand.Count; i++)
            {
                outbound_demand.get_demand(i);
                while (!isDemandEmpty(outbound_demand.demand[i]))
                {

                    float p;
                    int s = 0;
                    (s, p) = index_of_most_utilize_service(outbound_demand.cal_demand, train, services);
                    Console.WriteLine("\n\nthis is CARRY_matrix \n\n\n");
                    showarray(outbound_demand.carry_matrix);
                    Console.WriteLine("this is PERCENT " + p);
                    if (p <= 60)
                    {
                        for (int out_loop = 0; out_loop < outbound_demand.dimension; out_loop++) {
                            for (int in_loop = out_loop + 1; in_loop < outbound_demand.dimension; in_loop++) {
                                if (outbound_demand.demand[i][out_loop, in_loop] > 0)
                                {
                                    outbound_demand.carry_matrix[out_loop, in_loop] = i;
                                }
                            }
                        }
                        break;
                    }
                    Console.WriteLine("----IN ACTUAL ---- " + "\n\n");
                    actual_run(outbound_demand, train, services[s], i);
                    Console.WriteLine("----OUT ACTUAL ---- " + "\n\n");
                }
                Console.WriteLine("----END--OF--orchestrate----LOOP--- " + i + "\n\n\n\n\n");
            }
            Console.WriteLine("----END--OF--orchestrate-------- ");
        }

        static public void test_orchestrator_of_service(TF_Demand outbound_demand, Train_obj train, List<Service> services)
        {
            for (int i = 0; i < outbound_demand.demand.Count; i++)
            {
                outbound_demand.get_demand(i);
                while (!isDemandEmpty(outbound_demand.demand[i]))
                {

                    float p;
                    int s = 0;
                    (s, p) = index_of_most_utilize_service(outbound_demand.cal_demand, train, services);
                    Console.WriteLine("\n\nthis is CARRY_matrix \n\n\n");
                    showarray(outbound_demand.carry_matrix);
                    Console.WriteLine("this is PERCENT " + p);
                    if (p <= 60)
                    {
                        for (int out_loop = 0; out_loop < outbound_demand.dimension; out_loop++)
                        {
                            for (int in_loop = out_loop + 1; in_loop < outbound_demand.dimension; in_loop++)
                            {
                                if (outbound_demand.demand[i][out_loop, in_loop] > 0)
                                {
                                    outbound_demand.carry_matrix[out_loop, in_loop] = i;
                                }
                            }
                        }
                        break;
                    }
                    Console.WriteLine("----IN ACTUAL ---- " + "\n\n");
                    actual_run(outbound_demand, train, services[s], i);
                    Console.WriteLine("----OUT ACTUAL ---- " + "\n\n");
                    break;
                }
                Console.WriteLine("----END--OF--orchestrate----LOOP--- " + i + "\n\n\n\n\n");
            }
            Console.WriteLine("----END--OF--orchestrate-------- ");
        }


        public static float cal_utilize_percent(int[,] demand, Train_obj train, Service service) {
            float a = Utilize_service(demand, train, service);
            float b = max_utilize_of_service(train.cap, service);
            return a / b * 100;
        }

        public static int cal_all_service_util(int[,] demand, Train_obj train, List<Service> services) {
            int most_util_index = -1;
            float most_percent = -1;
            for (int i = 0; i < services.Count; i++) {
                float temp = cal_utilize_percent(demand, train, services[i]);
                if (temp > most_percent) {
                    most_percent = temp;
                    most_util_index = i;
                }
            }
            return most_util_index;
        }

        public static float max_utilize_of_service(int train_cap, Service service) {

            int source = 0, destination = 0;
            for (int i = 0; i < service.getLength(); i++) {
                if (service.StopStation[i] == 1) {
                    source = i;
                    break;
                }
            }
            for (int i = service.getLength() - 1; i > 0; i--) {
                if (service.StopStation[i] == 1) {
                    destination = i;
                    break;
                }
            }
            return train_cap * Station.getDistan_Meter(source, destination);
        }

        //Cal_remain_seat returns utilization (sum of passenger*distance)
        public static float Utilize_service(int[,] demand, Train_obj train, Service service)
        {
            int[,] actual_getoff = new int[5, 5];
            int get_off_next_station = 0;
            int i, j, k, next_station_index = 0;
            float train_util = 0;
            int[,] cal_demand = (int[,])demand.Clone();
            for (i = 0; i < 5; i++)
            {
                if (service.StopStation[i] == 0)
                {
                    continue;
                }
                for (int a = 4; a > i; a--) {
                    if (service.StopStation[a] == 1) {
                        next_station_index = a;
                    }
                }

                int demand_at_station = 0;
                get_off_next_station = sum_get_off(i);



                train.remain_cap += get_off_next_station;

                get_off_next_station = 0;
                for (k = i + 1; k < 5; k++) // sum of demand at station i
                {
                    if (service.StopStation[k] == 0) { continue; }
                    demand_at_station += cal_demand[i, k];

                }

                if (demand_at_station < train.remain_cap)
                {
                    train.remain_cap -= demand_at_station;
                    for (j = i + 1; j < 5; j++)
                    {
                        if (service.StopStation[j] == 0) { continue; }
                        actual_getoff[i, j] = cal_demand[i, j];
                        cal_demand[i, j] = 0;
                    }
                }
                else
                {

                    double ratio = 1.0 * train.remain_cap / demand_at_station;
                    demand_at_station = 0;
                    for (j = i + 1; j < 5; j++)
                    {
                        if (service.StopStation[j] == 0) { continue; }

                        int fill_demand = (int)(cal_demand[i, j] * ratio);

                        actual_getoff[i, j] = fill_demand;
                        cal_demand[i, j] -= fill_demand;
                        demand_at_station += fill_demand;

                    }

                    train.remain_cap -= demand_at_station;

                    int round_up_count = train.remain_cap;
                    for (j = next_station_index; j < round_up_count + next_station_index; j++)
                    {
                        actual_getoff[i, j] += 1;
                        cal_demand[i, j] -= 1;
                        demand_at_station++;
                        train.remain_cap--;
                    }

                }
                //Console.WriteLine("CALCULATE UTIL--- Traincap : " + train.cap);
                //Console.WriteLine("CALCULATE UTIL--- Remaincap : " + train.remain_cap);
                //Console.WriteLine("CALCULATE UTIL--- StationDistance : (METER) " + Station.getDistan_Meter(i, next_station_index));
                train_util += (train.cap - train.remain_cap) * Station.getDistan_Meter(i,next_station_index);
                Console.WriteLine("Train_util : " + train_util);

            }

            int sum_get_off(int station)
            {
                if (station == 0) { return 0; }
                int l;
                int sum = 0;
                for (l = 0; l < station; l++)
                {

                    sum += actual_getoff[l, station];
                   // Console.WriteLine("in_sum get off At  station : " + station + " form station : " + l + " = " + actual_getoff[l, station]);
                }
                return sum;
            }

            return train_util;
        }


        public static (List<Service_summary>,float) genService(List<Service> _services)
        {
            float sum_waiting_time=0;
            Train_obj train = new Train_obj(PhysicalData.TrainSize);
            List<Station> stations = new List<Station>();
            List<int[,]> demStation = new List<int[,]>();
            List<Service_summary> summaries = new List<Service_summary>();
            stations.InsertRange(0, Form1.stations); // copy demand form 1 TF of each station
           
            int[] tf_memo = init_memo(stations,0); // index of start(depart)_time
            int[,] carry_demand = init_carry_demand(tf_memo, stations);
            List<Service> services = new List<Service>();
            services = _services;

            Console.WriteLine("____demand_of_this_service");
            showarray(carry_demand);
            var k = 0;
            float last_util_percent_memo=1;
            while (services[0].depart_time[0].TimeOfDay<=stations[0].start_time.Last().TimeOfDay || last_util_percent_memo>=PhysicalData.utilize_percent)
            {
                Console.WriteLine("CONDITION 1 : " + (services[0].depart_time[0].TimeOfDay <= stations[0].start_time.Last().TimeOfDay).ToString());
                Console.WriteLine("CONDITION 2 : " + (last_util_percent_memo >= PhysicalData.utilize_percent).ToString());
                Console.WriteLine(" " + services[0].depart_time[0].TimeOfDay);
                Console.WriteLine("-------------NEWLOOP-----station-- : " + stations[0].start_time[0]);
                Console.WriteLine("-------------NEWLOOP-----service-- : " + services[0].depart_time[0]);
                //    Console.WriteLine(" " +last_util_percent_memo);
                Console.WriteLine("-------------NEWLOOP------------ : " +k);

                if (services[0].depart_time[0].Day != 1) break; // new day not allow
            
                for (var i = 0; i < services.Count; i++)
                {   
                    Console.WriteLine(services[i].depart_time[0].ToShortTimeString());
                    Console.WriteLine(services[i].depart_time[1].ToShortTimeString());
                    Console.WriteLine(services[i].depart_time[2].ToShortTimeString());
                    Console.WriteLine(services[i].depart_time[3].ToShortTimeString());
                    Console.WriteLine(services[i].depart_time[4].ToShortTimeString());
                    demStation.Insert(i,
                        demand_of_this_service(services[i].depart_time, stations, carry_demand, tf_memo));
                }
                

                for (var i = 0; i < services.Count; i++)
                {
                    Console.WriteLine("SERVICE : " + services[i].ServiceId);
                    
                    if (!isDemandEmpty(demStation[i]))
                    {
                        showarray(demStation[i]);
                    }
                    else
                    {
                        Console.WriteLine("-------------THIS DEMAND EMPTY------------ : ");
                    }
                }

                var (s, p) = new_index_of_most_utilize_service(demStation, train, services);

                Console.WriteLine("S and P index : " + s + " _ " + p);
                last_util_percent_memo = p; //set lastest utilize percent
               
                if (p >= PhysicalData.utilize_percent) //util handle
                {
                    TF_Demand outboundDemand = new TF_Demand(demStation[s]).Gen_Outbound_demand();
                    var (served_demand,served_demand_income) = serve_demand_form_station(outboundDemand, train, services[s], 0);
                    Console.WriteLine("__ REMAINNING \n");
                    showarray(outboundDemand.demand[0]);
                    Console.WriteLine("__ REMAINNING 22222222\n");
                    Console.WriteLine(services[s].depart_time[0].ToShortTimeString());
                    update_memo(services[s].depart_time, stations, tf_memo); //set memo
                    Console.WriteLine(services[s].depart_time[0].ToShortTimeString());
               
                    Console.WriteLine("UPDATED_ MEMO "+PrettyPrintArrays(tf_memo));
                    Console.WriteLine("REMAIN CARRY DEMAND");
                    carry_demand = outboundDemand.demand[0]; //set carry demand
                    showarray(carry_demand);
                    Console.WriteLine("NEXT" + PhysicalData.headway + "  MINUTE\n");

                    var test_depart = services[s].depart_time.Clone() as DateTime[];
                    int income = calIncome(served_demand_income);
                    Service_summary _summary =new Service_summary(services[s].ServiceId,services[s].StopStation,test_depart,served_demand,p,income,served_demand_income);

                    foreach (var _service in services)
                    {
                        _service.add_starttime(PhysicalData.headway);
                    }
                    k++;
                    
                    summaries.Add(_summary);
                }
                else
                {
                    Console.WriteLine("-------BELOW UTIL PERCENT ------- ");
                    
                    foreach (var _service in services)
                    {
                        _service.add_starttime(PhysicalData.under_util_plus_min);
                    }
                    
                }
            }

            update_remaining_demand(summaries, stations);
            return (summaries,sum_waiting_time);
        }

        public static void update_remaining_demand(List<Service_summary> results,List<Station> stations)
        {
            int station_index=0;
            foreach (Station station in stations)
            {   
                foreach (Service_summary summary in results)
                {
                    for (var n = 0; n < station.start_time.Count; n++)
                    {
                        if (summary.Departure_time[station_index].Hour == station.start_time[n].Hour)
                        {   var temp = summary.getDemandWithStation(station_index);
                            for (int i = 0; i < temp.Length; i++)
                            {
                                station.served_demand[n][i] += temp[i];
                            }
                            break;
                        }
                    }
                }
                station.calWaiting(station_index);
                station_index++;
                
            }


        }

        public static int calIncome(int[,] demand)
        {
            int sum=0;
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    sum += demand[i, j] * PhysicalData.ticket_price[i, j];
                }
            }

            return sum;

        }

        public static int[] init_memo(List<Station> stations,int index)
        { int[] memo = new int[stations.Count];
            for (var i = 0; i < stations.Count; i++)
            {
                memo[i] = index;
            }

            return memo;
        }

        public static void update_memo(DateTime[] depart_time, List<Station> stations, int[] tf_memo)
        {
            int counter = 0;
            int count_memo = 0;
            foreach (Station _station in stations)
            {
                int index_of_table = -1;
                foreach (DateTime table in _station)
                {
                    index_of_table++;
                    if (depart_time[counter].Hour == table.Hour)
                    {
                        if (tf_memo[count_memo] == index_of_table)
                        {
                            count_memo++;
                            continue;
                        }
                        else
                        {
                            tf_memo[count_memo] = index_of_table;
                            count_memo++;
                        }
                    }
                    
                }
                counter++;
            }
        }

        public static void update_carry_demand(int[,] carry_demand,int[,] served_demand)
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    carry_demand[i, j] -= served_demand[i, j];
                }
            }
        }
        public static (int[,],int[,]) serve_demand_form_station(TF_Demand demands, Train_obj train, Service aService, int timeframe)
        {
            Console.WriteLine("\n\nACTUAL_RUN __ serve_demand_form_station ");
            Console.WriteLine(aService.ServiceId);
            showarray(demands.demand[0]);

            int[,] actual_getoff = new int[5, 5];
            int[,] actual_getoff_income = new int[5, 5];
            int get_off_next_station = 0;
            int i, j, k, next_station_index = -1;
            int fill_demand;
            for (i = 0; i < 5; i++)
            {
                if (aService.StopStation[i] == 0)
                {
                    continue;
                }
                for (int a = 4; a > i; a--)
                {
                    if (aService.StopStation[a] == 1)
                    {
                        next_station_index = a;
                    }
                }

                int demand_at_station = 0;
                //Console.WriteLine("Remainning Seat : " + train.remain_cap);
                get_off_next_station = train.passenger[i];
               // Console.WriteLine("Number of getting off passenger at station " + i + " = " + get_off_next_station);
                train.getOff(i);
               // Console.WriteLine("Remainning Seat after get off : " + train.remain_cap);
                for (k = i + 1; k < 5; k++) // sum of demand at station i
                {
                    if (aService.StopStation[k] == 0) { continue; }
                    demand_at_station += demands.demand[0][i, k];
                  //  Console.WriteLine("Demand at station " + i + " to station " + k + " is " + demands.demand[0][i, k]);
                }
             //  Console.WriteLine("All of Demand at station " + i + " is " + demand_at_station);
                if (demand_at_station < train.remain_cap)
                {
                    for (j = i + 1; j < 5; j++)
                    {
                        if (aService.StopStation[j] == 0) { continue; }
                        train.getOn(demands.demand[0][i, j], j);
                        actual_getoff[i, j] = demands.demand[0][i, j];
                        actual_getoff_income[i,j] = demands.demand[0][i, j]; // set for income calculation
                        demands.demand[0][i, j] = 0;
                        clear_remain_demand(demands, timeframe, i, j);
                    }

                    if (i + 1 < 5)
                    {
                        actual_getoff[i, i + 1] += train.remain_cap;
                    }
                }
                else
                {
                    double ratio = 1.0 * train.remain_cap / demand_at_station;
                    demand_at_station = 0; //reset
                    fill_demand = 0; //reset
                    for (j = i + 1; j < 5; j++)
                    {
                        if (aService.StopStation[j] == 0) { continue; }
                        fill_demand = (int)(demands.demand[0][i, j] * ratio);
                        demand_at_station += fill_demand;
                    }
                    int remain_cap = train.remain_cap;
                   // Console.WriteLine("..............Debug demand at station  " + demand_at_station);
                    remain_cap -= demand_at_station;
                    for (j = i + 1; j < 5; j++)
                    {
                        if (aService.StopStation[j] == 0) { continue; }
                        //Console.WriteLine("..............Debug train remainning seat  " + train.remain_cap);
                        //Console.WriteLine("..............Debug train remainning seat  " + remain_cap);
                        //Console.WriteLine("..............Debug Demand at station      " + demands.demand[0][i, j]);
                        //Console.WriteLine("..............Debug ratio      " + ratio);
                        fill_demand = (int)(demands.demand[0][i, j] * ratio);
                      //  Console.WriteLine("..............Debug fill_demand  " + fill_demand);
                        
                        if (remain_cap > 0 && demands.demand[0][i, j] > fill_demand)
                        {// ROUND UP IN CASE OF REMAINING a few demand
                    //        Console.WriteLine("ROUND UP AT : " + i+"_"+j);
                            train.getOn(fill_demand + 1, j);
                            update_remain_demand(demands, timeframe, fill_demand + 1, i, j);
                            remain_cap -= 1;
                            actual_getoff[i, j] = fill_demand+1;
                            actual_getoff_income[i, j] = fill_demand + 1;
                        }
                        else
                        {// NO FEW demand left
                            train.getOn(fill_demand, j);
                            update_remain_demand(demands, timeframe, fill_demand, i, j);
                            actual_getoff[i, j] = fill_demand;
                            actual_getoff_income[i, j] = fill_demand;
                        }
                        demand_at_station += fill_demand;
                    }
                //    Console.WriteLine("..............train remainning seat AFTER  " + train.remain_cap);
                }
                
            }
            Console.WriteLine("ACTUAL GETOFF  ");
            showarray(actual_getoff); //served demand
            return (actual_getoff,actual_getoff_income);
        }

        public static int[,] demand_of_this_service(DateTime[] depart_time, List<Station> stations,int[,] carry_demand,int[] tf_memo)
        {
            int[,] result = carry_demand.Clone() as int[,];
            int counter = 0;
            int count_memo = 0;
            foreach (Station _station in stations)
            {
                int index_of_table=-1;
                foreach (DateTime table in _station)
                {
                    index_of_table++;
                    if (depart_time[counter].Hour == table.Hour)
                    {   Console.WriteLine("this service index : "+index_of_table+" memo "+tf_memo[count_memo]);
                        if (tf_memo[count_memo] == index_of_table)
                        {
                            count_memo++;
                            continue;
                        }
                        else
                        {   
                            var dif_index = index_of_table - tf_memo[count_memo];
                            if (dif_index < 0)
                            {
                                Console.WriteLine("DIFF INDEX"+dif_index);
                               for(var c = 0; c > dif_index; c--)
                                {
                                    for (int b = 0; b < stations.Count; b++)
                                    {
                                        result[counter, b] -= (int)_station.demand_station[tf_memo[count_memo] + c][b];
                                    }
                                }
                            }
                            else
                            {
                                for (var c = 0; c < dif_index; c++)
                                {
                                    for (int b = 0; b < stations.Count; b++)
                                    {
                                        result[counter, b] += (int) _station.demand_station[index_of_table - c][b];
                                    }
                                }
                            }

                            count_memo++;
                        }
                    }
                }
                counter++;
            }
            return result;
        }

        static public void new_orchestrator_of_service(TF_Demand outbound_demand, Train_obj train, List<Service> services) {
            for (int i = 0; i < outbound_demand.demand.Count; i++)
            {
                outbound_demand.get_demand(i);
                while (!isDemandEmpty(outbound_demand.demand[i]))
                {
                    float p;
                    int s = 0;
                    (s, p) = index_of_most_utilize_service(outbound_demand.cal_demand, train, services);
                    Console.WriteLine("\n\nthis is CARRY_matrix \n\n\n");
                    showarray(outbound_demand.carry_matrix);
                    Console.WriteLine("this is PERCENT " + p);
                    if (p <= 60)
                    {
                        for (int out_loop = 0; out_loop < outbound_demand.dimension; out_loop++) {
                            for (int in_loop = out_loop + 1; in_loop < outbound_demand.dimension; in_loop++) {
                                if (outbound_demand.demand[i][out_loop, in_loop] > 0)
                                {
                                    outbound_demand.carry_matrix[out_loop, in_loop] = i;
                                }
                            }
                        }
                        break;
                    }
                    Console.WriteLine("----IN ACTUAL ---- " + "\n\n");
                    actual_run(outbound_demand, train, services[s], i);
                    Console.WriteLine("----OUT ACTUAL ---- " + "\n\n");
                }
                Console.WriteLine("----END--OF--orchestrate----LOOP--- " + i + "\n\n\n\n\n");
            }
            Console.WriteLine("----END--OF--orchestrate-------- ");
        }

        public static int[,] init_carry_demand(int[] memo,List<Station> stations)
        { int[,] result = new int[stations.Count, stations.Count];
            int counter = 0;
            foreach (Station a in stations)
            {
                
                for (int b = 0; b < stations.Count; b++)
                {
                    result[counter, b] = (int)a.demand_station[memo[b]][b];
                }
                counter++;
            }
            return result;
        }

        public static string PrettyPrintArrayOfArrays(int[][] arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "";

            var prettyArrays = new string[arrayOfArrays.Length];

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                prettyArrays[i] = "[" + String.Join(",", arrayOfArrays[i]) + "]";
            }

            return "[" + String.Join(",", prettyArrays) + "]";
        }

        public static string PrettyPrintArrays(double[] arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "EMPTY";

            var prettyArrays = new string[arrayOfArrays.Length];

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                prettyArrays[i] = "[" + String.Join(",", arrayOfArrays[i]) + "]";
            }

            return "[" + String.Join(",", prettyArrays) + "]";
        }

        public static string PrettyPrintArraysFormat(int[] arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "EMPTY";

            var prettyArrays = new string[arrayOfArrays.Length];

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                if (arrayOfArrays[i] == 1)
                {
                    prettyArrays[i] = "[" + String.Join(",", i+1) + "]";
                }
                else
                {
                    prettyArrays[i] = "[" + String.Join(",","-") + "]";
                }

            }

                return  String.Join(", ", prettyArrays);
        }

        public static string PrettyPrintArrays(int[] arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "";

            var prettyArrays = new string[arrayOfArrays.Length];

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                prettyArrays[i] = " [" + String.Join(",", arrayOfArrays[i]) + "]";
            }

            return " " + String.Join(",", prettyArrays) + " ";
        }
    }
}
