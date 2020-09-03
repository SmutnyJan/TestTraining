using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.InputModel
{
    public class UserSubscription
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }

        public UserSubscription(string name, string lastName, DateTime dateOfBirth)
        {
            this.name = name;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
        public int Age(DateTime birthDate, DateTime currentDate)
        {
            int YearsDiff = new DateTime(currentDate.Subtract(birthDate).Ticks).Year - 1;
            return YearsDiff;
        }
    }
}
