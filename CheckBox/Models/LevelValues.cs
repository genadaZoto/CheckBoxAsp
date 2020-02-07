using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckBox.Models
{
    public class LevelValues
    {
        private string _value1;
        private string _value2;
        private string _value3;

        public string Value1
        {
            get
            {
                return _value1;
            }

            set
            {
                _value1 = "not good";
            }
        }

        public string Value2
        {
            get
            {
                return _value2;
            }

            set
            {
                _value2 = "good";
            }
        }

        public string Value3
        {
            get
            {
                return _value3;
            }

            set
            {
                _value3 = "very good";
            }
        }
    }
}