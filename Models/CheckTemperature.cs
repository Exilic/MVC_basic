using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCBasicsAssignment.Models
{
    public class CheckTemperature
    {

        public static string message = "";

        public static string Evaluate(string degreeValue, string scale)
        {
            
            double degreeNumber = Convert.ToDouble(degreeValue);
            if (scale == "Celsius")
            {
                if (degreeNumber > 37.5)
                {
                    message = "A body temperature of " + degreeValue + " \u00B0C puts you in the range of having a fever.";
                } else if (degreeNumber < 36.5 && degreeNumber >= 35.0)
                {
                    message = "A body temperature of " + degreeValue + " \u00B0C puts you in the range of having a mild hypothermia.";
                }
                else if (degreeNumber < 35.0)
                {
                    message = "A body temperature of " + degreeValue + " \u00B0C puts you in the range of having hypothermia.";
                } else
                {
                    message = "A body temperature of " + degreeValue + " \u00B0C is in the normal range.";
                }
            } else
            {
                if (degreeNumber > 99.5)
                {
                    message = "A body temperature of " + degreeValue + " \u00B0F puts you in the range of having a fever.";
                }
                else if (degreeNumber < 97.7 && degreeNumber >= 95.0)
                {
                    message = "A body temperature of " + degreeValue + " \u00B0F puts you in the range of having a mild hypothermia.";
                }
                else if (degreeNumber < 95.0)
                {
                    message = "A body temperature of " + degreeValue + " \u00B0F puts you in the range of having hypothermia.";
                }
                else
                {
                    message = "A body temperature of " + degreeValue + " \u00B0F is in the normal range.";
                }
            }
            
            
            return message;
        }
        
    }
}
