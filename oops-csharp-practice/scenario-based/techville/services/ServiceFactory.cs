using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

namespace techville.services
{
    //M-7 Using Service Factory Pattern
    public class ServiceFactory
    {
        //method to create service 
         public static Service CreateService(string type)
        {
            //healthcare service
            if (type.ToLower() == "healthcare")
            {
                return new HealthcareService(5000, true);
            }
            //education service
            else if (type.ToLower() == "education")
            {
                return new EducationService(8000, 10);
            }
            //premium healthcare service
            else if (type.ToLower() == "premiumhealthcare")
            {
                return new PremiumHealthcareService(10000, true, true);
            }
            else
            {
                return null;
            }
               
        }
    }
}