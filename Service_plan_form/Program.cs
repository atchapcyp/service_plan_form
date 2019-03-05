using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Service_plan_form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // START CONSOLE SECTION 
            String[] str1 = { "xxxx", "YYY" };
            Console.WriteLine(Service_algo.PrettyPrintArrays(Form1.stations[0].demand_station[0]));
            Console.WriteLine(Form1.stations[0].demand_station[0][3]);
            Console.WriteLine(Form1.stations[0].tf_count);

            List<Service> outbound_services = new List<Service>();
            List<int[]> backward = new List<int[]>();
            Train_obj train = new Train_obj(100);
            int[] service = { 1, 1, 1, 1, 1 };
            int[] service2 = { 1, 0, 1, 1, 1 };
            int[] service3 = { 1, 0, 0, 0, 1 };
            int[] service4 = { 0, 1, 1, 1, 1 };
            Service aService;
            int dep_hour = 9;int dep_min = 0;

            aService = new Service("All_station", service,dep_hour,dep_min);
            //add service to list
            outbound_services.Add(aService);
            outbound_services[0].show();
            aService = new Service("4_station_outbound_ex_2", service2,dep_hour,dep_min);
            outbound_services.Add(aService);
            outbound_services[1].show();
            aService = new Service("4_station_outbound_start_at_2", service4,dep_hour,dep_min);
            outbound_services.Add(aService);
            outbound_services[2].show();
            aService =new Service("1_to_5", service3,dep_hour,dep_min);
            outbound_services.Add(aService);
            outbound_services[3].show();
            Service_algo.genService(outbound_services);



            Console.WriteLine("-----------------\n\n\n\n\n\n\n\n");
            Console.ReadLine();
            //add demand to be time frame demand


            LogWriter log = new LogWriter(str1[0] + str1[1]);
            // END CONSOLE SECTION
        }
    }
}
