using System;
namespace MVCBasicsAssignment1.Models

{
    public class FeverUtillity
    {
        private static double temperature;
        private static string feverStatus;

        public FeverUtillity()
        {

        }
        public FeverUtillity(string temp) {
            double number;
            if(Double.TryParse(temp, out number))
        {
            temperature = Double.Parse(temp) ;
        }
            
            feverStatus = FeverStatus();
        
        }


        private static string FeverStatus()
        {
        
           if(temperature < 13)
            {
                return "If your body tempertur is " + temperature + " your dead!";
            }else if(temperature < 28.0)
            {
                return "If your body tempertur is " + temperature + " your have life-threatning hypothermia";
            }else if(temperature <= 32.0)
            {
                return "If your body tempertur is " + temperature + " your have hypothermia";

            }else if(temperature <= 35.0)
            {
                return "If your body tempertur is " + temperature + " your have mild hypothermia";
            }
            else if(temperature <= 37.6)
            {
               
                return "If your body tempertur is " + temperature + " your have no fever";
            }
            else if (temperature <= 38.5)
            {
                
                return "If your body tempertur is " + temperature + " your have mild fever";
            }
            else
            {
                return "If your body tempertur is " + temperature + " your have high fever";
            }
          
        }

        public void SetTempature(string temp)
        {
            double number;
            if (double.TryParse(temp, out number ))
            {
                temperature = number;
            }

            feverStatus = FeverStatus();
           
        }

        public string GetFever()
        {
            return feverStatus;
        }

        public void reset()
        {
            temperature = 0;
            feverStatus = null;
        }

    }
}
