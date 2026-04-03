using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class DateFormatter
    {
        //method to format date
        public string FormatDate(string inputDate)
        {
            //check if input is empty
            if (string.IsNullOrEmpty(inputDate))
            {
                //throw exception if input is empty
                throw new ArgumentException("Date is empty");
            }

            //split date 
            string[] parts = inputDate.Split('-');

            //check correct format
            if (parts.Length != 3)
            {
                //throw exception if format is wrong
                throw new FormatException("Invalid date format");
            }

            //rearrange date to dd-MM-yyyy
            string formattedDate = parts[2] + "-" + parts[1] + "-" + parts[0];

            //return formatted date
            return formattedDate;
        }
    }
}
