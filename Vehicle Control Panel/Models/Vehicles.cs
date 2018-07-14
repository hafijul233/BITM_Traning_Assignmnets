using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Control_Panel.Models
{
    class Vehicles
    {
        private string _vehicleName;
        private string _regiNumber;

        private double[] _speed = new double[20];

        private double _minSpeed;
        private double _maxSpeed;
        private double _avgSpeed;

        private int _speedCounter = 0;

        public Vehicles(string _vehicleName, string _regiNumber)
        {
            this._vehicleName = _vehicleName;
            this._regiNumber = _regiNumber;
        }

        public string AddSpeed {
            set => _speed[_speedCounter++] = Convert.ToDouble(value);
        }

        public string Name => _vehicleName;
        public string RegNo => _regiNumber;

        public void GetMinMaxAvgSpeed()
        {
            double _totalSpeed = 0;

            _minSpeed = _speed[0];
            _maxSpeed = _speed[0];

            for (int i =0; i<_speedCounter; i++)
            {
                if (_speed[i] > _maxSpeed) _maxSpeed = _speed[i];

                if (_speed[i] < _minSpeed) _minSpeed = _speed[i];

                _totalSpeed += _speed[i];
            }
            _avgSpeed = _totalSpeed / _speedCounter;
        }

        public string MinSpeed => Convert.ToString(_minSpeed);

        public string MaxSpeed => Convert.ToString(_maxSpeed);

        public string AvgSpeed => String.Format("{0:F2}", _avgSpeed);


    }
}
