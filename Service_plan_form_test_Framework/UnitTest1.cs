﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service_plan_form;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Service_plan_form_test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void PassingTest()
        {
           
            Assert.AreEqual(4, Add(2, 2));
        }
       

        int Add(int x, int y)
        {
            return x + y;
        }

        [TestMethod]
        public void Test_read_xlsx_data()
        { List<Station> listOfStation = new List<Station>();
           listOfStation = Form1.readxlsx();
            double[] expected_station2 = { 210, 0, 230, 240, 250 };
            for (var i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected_station2[i], listOfStation[1].demand_station[0][i]);
            }
        }

        //[TestMethod]
        //public void Test_retreive_demand_of_service()
        //{
        //    List<Station> stations = new List<Station>();
        //    int[,] actual = Service_algo.demand_of_this_service();

        //}

        [TestMethod]
        public void Test_Gen_outbound_TF_Demand_method()
        {
            TF_Demand demand = new TF_Demand(720, 5);
            int[,] A ={{ 00, 01, 02, 03, 04 },
            { 10, 11, 12, 13, 14 },
            { 20, 21, 22, 23, 24 },
            { 30, 31, 32, 33, 34 },
            { 40, 41, 42, 43, 44 } };
            demand.demand[0] = A;
            TF_Demand outbound_demand = demand.Gen_Outbound_demand();
            int[,] expected = {
            { 0, 01, 02, 03, 04 },
            { 0, 0 , 12, 13, 14 },
            { 0, 0 , 0 , 23, 24 },
            { 0, 0 , 0 , 0,  34 },
            { 0, 0 , 0 , 0,  0 } };
            for (int k = 0; k < 1; k++)
            {
                for (int i = 0; i < outbound_demand.dimension; i++)
                {
                    for (int j = 0; j < outbound_demand.dimension; j++)
                    {
                        Assert.AreEqual(expected[i, j], outbound_demand.demand[k][i, j]);
                    }
                }
            }
        }

        [TestMethod]
        public void Test_sum_to_unserve_demand_Assign()
        {
            TF_Demand demand = new TF_Demand(720, 5, "xxx");
            int[,] expected = demand.getDemand(1);

            demand.sum_to_unserve_demand(1);
            int[,] actual = demand.getDemand(1);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
        [TestMethod]
        public void Test_sum_to_unserve_demand_unassign()
        {
            TF_Demand demand = new TF_Demand(720, 5);
            int[,] expected = demand.getDemand(1);
            demand.sum_to_unserve_demand(1);
            int[,] actual = demand.getDemand(1);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
        [TestMethod]
        public void Test_cal_service_util_must_reply_index()
        {
            Train_obj train = new Train_obj(200);
            TF_Demand demand = new TF_Demand(1440, 5, "test");
            int[,] outbound_demand = new int[5, 5];
            List<Service> outbound_services = new List<Service>();
            int[] service = { 1, 0, 1, 1, 1 };
            int[] service2 = { 0, 0, 1, 0, 1 };
            int[] service3 = { 1, 1, 1, 1, 1 };
            int[] service4 = { 0, 1, 1, 1, 1 };
            List<int[]> test1 = new List<int[]>();
            test1.Add(service);
            test1.Add(service2);
            Service aService;
            aService = new Service("aaa", service);
            outbound_services.Add(aService);
            aService = new Service("3_station_outbound", service2);
            outbound_services.Add(aService);
            aService = new Service("2_station_outbound", service3);
            outbound_services.Add(aService);
            aService = new Service("4_station_outbound_start_at_1", service4);
            outbound_services.Add(aService);
            //outbound_demand = demand.getOutbound_demand(0);
            int actual = Service_algo.cal_all_service_util(outbound_demand, train, outbound_services);
            int expected = 0;
            Assert.AreEqual(expected, actual);

        }

        //[TestMethod]
        //public void Test_maxUtilze()
        //{
        //    Train_obj train = new Train_obj(100);

        //    int[] service = { 1, 1, 1, 1, 0 };
        //    Service services = new Service("test", service);
        //    float actual = Service_algo.max_utilize_of_service(train.cap, services);
        //    float expected = 8500;
        //    Assert.AreEqual(expected, actual);
        //}
        

        [TestMethod]
        public void Test_getOff_TrainClass()
        {
            Train_obj train = new Train_obj(100);

            train.getOn(50, 1);
            train.getOff(1);
            int actual = train.remain_cap;
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_getOn_TrainClass()
        {
            Train_obj train = new Train_obj(100);
            train.getOn(50, 1);
            int actual = train.remain_cap;
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_getDistance()
        {
            int actual = Station.getDistance(4, 0);
            int expected = 110;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_isDemandEmpty_With_Service_01111()
        {
            int[] service = { 0, 1, 1, 1, 1 };
            Service A = new Service("test", service);
            int[,] demand = {
            { 0, 10, 10,10, 10 },
            { 0, 0,0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0,0, 0, 0 } };

            bool actual = Service_algo.isDemandEmpty_with_service(demand, A);
            Assert.IsTrue(actual);
            
        }

        [TestMethod]
        public void Test_isDemandEmpty_With_Service_10101()
        {
            int[] service = { 1, 0, 1, 0, 1 };
            Service A = new Service("test", service);
            int[,] demand = {
            { 0, 10, 0, 10, 0 },
            { 0, 0, 10, 10, 10 },
            { 0, 0, 0, 10, 0 },
            { 0, 0, 0, 0, 10 },
            { 0, 0,0, 0, 0 } };

            bool actual = Service_algo.isDemandEmpty_with_service(demand, A);
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void Test_isDemandEmpty_Must_be_False()
        {
            int[,] demand = {
            { 0, 0, 0, 0, 0 },
            { 0, 0,0, 0, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0,0, 0, 0 } };

            bool actual = Service_algo.isDemandEmpty(demand);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_isDemandEmpty_Must_be_True()
        {
            int[,] demand = {
            { 0, 0, 0, 0, 0 },
            { 0, 0,0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0,0, 0, 0 } };

            bool actual = Service_algo.isDemandEmpty(demand);
            Assert.IsTrue(actual);
        }

        //[TestMethod]
        public void Train_service_3_station()
        {
            TF_Demand tfd = new TF_Demand(1440, 5);

            int[,] demand = {
            { 0, 10, 10, 10, 10 },
            { 0, 0, 10, 10, 10 },
            { 0, 0, 0, 10, 10 },
            { 0, 0, 0, 0, 10 },
            { 0, 0, 0, 0, 0 } };

            tfd.demand[0] = demand;
            Train_obj train = new Train_obj(10);
            List<Service> forward = new List<Service>();
            int[] service_3_station = { 1, 0, 1, 0, 1 };
            Service testService = new Service("3_station_outbound", service_3_station);
            forward.Add(testService);

            int[,] expected =
            {
                { 0,  10,  5, 10, 5 },
                { 0, 0,  10, 10, 10 },
                { 0, 0, 0, 10, 5 },
                { 0, 0, 0, 0, 10 },
                { 0, 0, 0, 0, 0 } };
            Service_algo.test_orchestrator_of_service(tfd, train, forward);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], tfd.demand[0][i, j]);
                }
            }

        }

        //[TestMethod]
        public void Train_service_3_station_no_overcap()
        {
            TF_Demand tfd = new TF_Demand(1440, 5, "TEST");

            int[,] demand = {
            { 0, 10, 10, 10, 10 },
            { 10, 0, 10, 10, 10 },
            { 10, 10, 0, 10, 10 },
            { 10, 10, 10, 0, 10 },
            { 10, 10, 10, 10, 0 } };

            tfd.demand[0] = demand;
            Train_obj train = new Train_obj(30);
            List<Service> forward = new List<Service>();
            int[] service_3_station = { 1, 0, 1, 0, 1 };
            Service testService = new Service("All_station_outbound", service_3_station);
            forward.Add(testService);

            int[,] expected =
            {
                { 0,  10,  0, 10, 0 },
                { 10, 0,  10, 10, 10 },
                { 10, 10, 0, 10, 0 },
                { 10, 10, 10, 0, 10 },
                { 10, 10, 10, 10, 0 } };
            Service_algo.test_orchestrator_of_service(tfd, train, forward);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], tfd.demand[0][i, j]);
                }
            }
        }
        //[TestMethod]
        public void Train_service_4_station()
        {
            TF_Demand tfd = new TF_Demand(1440, 5);

            int[,] demand = {
            { 0, 10, 10, 10, 10 },
            { 10, 0, 10, 10, 10 },
            { 10, 10, 0, 10, 10 },
            { 10, 10, 10, 0, 10 },
            { 10, 10, 10, 10, 0 } };

            tfd.demand[0] = demand;

            Train_obj train = new Train_obj(30);
            int[] service_4_station = { 1, 1, 1, 0, 1 };
            List<Service> forward = new List<Service>();
            Service testService = new Service("All_station_outbound", service_4_station);
            forward.Add(testService);

            int[,] expected =
            {
                { 0,  0,  0, 10, 0 },
                { 10, 0,  5, 10, 5 },
                { 10, 10, 0, 10, 0 },
                { 10, 10, 10, 0, 10 },
                { 10, 10, 10,10, 0 } };
            Service_algo.test_orchestrator_of_service(tfd, train, forward);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], tfd.demand[0][i, j]);
                }
            }
        }

        //[TestMethod]
        public void Train_service_4_station_no_overcap()
        {
            TF_Demand tfd = new TF_Demand(1440, 5, "TEST");

            int[,] demand = {
            { 0, 10, 10, 10, 10 },
            { 10, 0, 10, 10, 10 },
            { 10, 10, 0, 10, 10 },
            { 10, 10, 10, 0, 10 },
            { 10, 10, 10, 10, 0 } };

            tfd.demand[0] = demand;

            Train_obj train = new Train_obj(40);
            int[] service_4_station = { 1, 1, 1, 0, 1 };
            List<Service> forward = new List<Service>();
            Service testService = new Service("All_station_outbound", service_4_station);
            forward.Add(testService);

            int[,] expected =
            {
                { 0,  0,  0, 10, 0 },
                { 10, 0,  0, 10, 0 },
                { 10, 10, 0, 10, 0 },
                { 10, 10, 10, 0, 10 },
                { 10, 10, 10, 10, 0 } };
            Service_algo.Train_a_b_c_d_e(tfd, train, forward[0], 0);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], tfd.demand[0][i, j]);
                }
            }


        }


        //[TestMethod]
        public void Train_service_all_station()
        {
            TF_Demand tfd = new TF_Demand(1440, 5, "TEST");

            int[,] demand = {
            { 0, 10, 10, 10, 10 },
            { 10, 0, 10, 10, 10 },
            { 10, 10, 0, 10, 10 },
            { 10, 10, 10, 0, 10 },
            { 10, 10, 10, 10, 0 } };

            tfd.demand[0] = demand;

            Train_obj train = new Train_obj(40);
            int[] service_all_station = { 1, 1, 1, 1, 1 };
            List<Service> forward = new List<Service>();
            Service testService = new Service("All_station_outbound", service_all_station);
            forward.Add(testService);

            int[,] expected =
            {
                { 0,  0,  0, 0, 0 },
                { 10, 0,  6, 7, 7 },
                { 10, 10, 0, 3, 3 },
                { 10,10, 10, 0, 0 },
                { 10, 10,10, 10, 0 } };
            Service_algo.test_orchestrator_of_service(tfd, train, forward);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], tfd.demand[0][i, j]);
                }
            }


        }
        [TestMethod]
        public void test_get_distant_meter_0_to_4()
        {
            int actual = Station.getDistan_Meter(0, 4);
            Assert.AreEqual(251000, actual);
        }

        [TestMethod]
        public void test_get_distant_meter_3_to_4()
        {
            int actual = Station.getDistan_Meter(3, 4);
            Assert.AreEqual(78000, actual);
        }

        [TestMethod]
        public void test_get_distant_meter_4_to_3()
        {
            int actual = Station.getDistan_Meter(4, 3);
            Assert.AreEqual(78000, actual);
        }
    }
}
