using System.Collections.Generic;

namespace KalCulate.Api.App.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Coach(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
