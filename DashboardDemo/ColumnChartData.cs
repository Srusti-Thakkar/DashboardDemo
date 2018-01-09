using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashboardDemo
{
    public class ColumnChartData
    {
        public ColumnChartData(string xval, double yvalue)
        {
            this.Xvalue = xval;
            this.YValue = yvalue;
        }
        //public ColumnChartData(string xval, double yvalue1, double yvalue2, double yvalue3)
        //{
        //    this.Xvalue = xval;
        //    this.YValue1 = yvalue1;
        //    this.YValue2 = yvalue2;
        //    this.YValue3 = yvalue3;
        //}
        public string Xvalue
        {
            get;
            set;
        }
        public double YValue
        {
            get;
            set;
        }

    }
}