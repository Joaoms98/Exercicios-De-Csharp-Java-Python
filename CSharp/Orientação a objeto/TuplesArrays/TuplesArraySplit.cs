using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string[] nums = phoneNumber.Split('-');
            return (nums[0] == "212", nums[1] == "555", nums[2]);
            //PhoneNumber.Analyze("631-555-1234");
            // => (false, true, "1234")
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            return phoneNumberInfo.IsFake == true;
            //PhoneNumber.IsFake(PhoneNumbers.Analyze("631-555-1234"));
            // => true
        }
    }
}
