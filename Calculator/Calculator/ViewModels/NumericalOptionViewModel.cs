using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.ViewModels
{
    public class NumericalOptionViewModel
    {
        private double _slope;
        private double _deckEmitt;
        private double _floorEmitt;
        private double _thermalConductivity;

        public string Slope
        {
            get { return _slope.ToString(); }
            set { try { _slope = double.Parse(value); } catch { } }
        }
        public string DeckEmitt
        {
            get { return _deckEmitt.ToString(); }
            set { try { _deckEmitt = double.Parse(value); } catch { } }
        }
        public string FloorEmitt
        {
            get { return _floorEmitt.ToString(); }
            set { try { _floorEmitt = double.Parse(value); } catch { } }
        }
        public string ThermalConductivity
        {
            get { return _thermalConductivity.ToString(); }
            set { try { _thermalConductivity = double.Parse(value); } catch { } }
        }

        public NumericalOptionViewModel()
        {
            _slope = 3;
            _deckEmitt = 0.03;
            _floorEmitt = 0.05;
            _thermalConductivity = 0.02;
        }
    }
}
