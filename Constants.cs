using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiBike4Rent
{
    class Constants
    {
        public static List<String> status = new List<string>() { "available", "rented", "sold", "maintenance" };
        public static List<String> asscessories = new List<string>() { "trailers", "baby seats", "car racks" };
        public static List<String> categories = new List<string>() { "electric", "mountain", "city", "kids" };
        public static List<String> roles = new List<string>() { "admin", "management", "check-out" };

    }
}
