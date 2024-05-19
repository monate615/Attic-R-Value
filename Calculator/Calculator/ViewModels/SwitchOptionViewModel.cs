using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.ViewModels
{
    public class SwitchOptionViewModel
    {
        private bool _isHeatFlowDown;
        private bool _isDeck;
        private bool _isIPUnits;

        public bool IsHeatFlowDown
        { get { return _isHeatFlowDown; } set { _isHeatFlowDown = value; } }

        public bool IsDeck 
        { get { return _isDeck; } set { _isDeck = value; } }

        public bool IsIPUnits
        { get { return _isIPUnits; } set { _isIPUnits = value; } }

        public SwitchOptionViewModel()
        {
            _isHeatFlowDown = true;
            _isDeck = true;
            _isIPUnits = true;
        }
    }
}
