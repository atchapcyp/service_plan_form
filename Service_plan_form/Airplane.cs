using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form
{
    class Airplane
    {
        public Airplane(string model, int fuelKg)
        {
            _id = ++lastID; Model = model; _fuelKg = fuelKg;
        }
        private static int lastID = 0;
        public int _id;
        public int ID { get { return _id; } }
        public int _fuelKg;
        public int FuelLeftKg { get { return _fuelKg; } set { _fuelKg = value; } }
        public string _model;
        public string Model { get { return _model; } set { _model = value; } }
        
    }
}
