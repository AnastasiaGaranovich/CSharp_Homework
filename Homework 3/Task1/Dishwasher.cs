using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Dishwasher
    {
        private string _model;
        private double _operatingTime;
        private double _waterConsumption;
        private double _powerConsumption;
        private int _waterTemperature;
        private int _maxLoading;
        private double _useCount;
        private static int _warranty;
        private static string _serviceCenterAddress;
        
        public Dishwasher()
        {

        }

        public Dishwasher(string model)
        {
            _model = model;
        }

        public Dishwasher(string model, int maxLoading)
        {
            _model = model;
            _maxLoading = maxLoading;
        }

        public Dishwasher(string model, double waterConsumption, double powerConsumption)
        {
            _model = model;
            _waterConsumption = waterConsumption;
            _powerConsumption = powerConsumption;
        }

        static Dishwasher()
        {
            _warranty = 24;
            _serviceCenterAddress = "Minsk city Lenin street building 10";
        }

        public void EcoMode()
        {
            _powerConsumption += 0.70;
            _waterConsumption += 6.55;
            _operatingTime = 40.0;
            _waterTemperature = _waterConsumption * _operatingTime / 4;
        }

        public void EveryDayMode()
        {

        }

        public void FastMode(int operatingTime)
        {

        }





    }
}
