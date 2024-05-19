using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.ViewModels
{
    public class ResultViewModel
    {
        private double _result;
        private string _unit;

        public string Result
        {
            get { return _result.ToString(); }
            set 
            {
                try
                {
                    _result = double.Parse(value);
                }
                catch
                {
                }
            }
        }

        public string Unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }

        public ResultViewModel() 
        {
            _unit = "ft2.h.oF/BTU";
            _result = 34.34;
        }
    }
}
