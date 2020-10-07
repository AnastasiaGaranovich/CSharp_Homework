using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal partial class Dishwasher
    {
        private string _model;
        private double _operatingTime;
        private double _waterConsumption;
        private double _powerConsumption;
        private double _waterTemperature;
        private int _maxLoading;
        private double _useCount;
        private static double _warranty;
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
            _warranty = 36.0;
            _serviceCenterAddress = "Minsk city Lenin street building 10";
        }

        public void EcoMode()
        {
            _powerConsumption -= 0.70;
            _waterConsumption += 6.55;
            _operatingTime = 40.0;
            _waterTemperature = _waterConsumption * _operatingTime / _maxLoading;
            _useCount += 0.01;
            _warranty -= _useCount;
        }

        public void EveryDayMode()
        {
            _powerConsumption += 0.98;
            _waterConsumption += 9.2;
            _operatingTime = 70.0;
            _waterTemperature = _waterConsumption * _operatingTime / _maxLoading;
            _useCount += 0.01;
            _warranty -= _useCount;
        }

        public void FastMode(double operatingTime, ref double temperature)
        {
           _operatingTime = operatingTime;
           _powerConsumption += 0.95;
           _waterConsumption += 8.1;
           _waterTemperature = _waterConsumption * _operatingTime / _maxLoading;
           temperature = _waterTemperature;
        }

        public double WaterConsumption => _waterConsumption;
        public double PowerConsumption => _powerConsumption;
        public int MaxLoading => _maxLoading;
        public static double Warranrty => _warranty;
        public static string ServiceCenterAddress => _serviceCenterAddress;





    }
}
