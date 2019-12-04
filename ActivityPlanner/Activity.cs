using System;

namespace ActivityPlanner
{
    public enum TypeOfActivity { Air, Water, Land }
    public class Activity : IComparable<Activity>
    {
        // Properties
        public string Name { get; set; }
        public DateTime ActivityDate { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public TypeOfActivity ActivityType { get; set; }

        

        // Constructors
        public Activity(string name, DateTime activityDate, double cost, string description, TypeOfActivity activityType)
        {
            Name = name;
            ActivityDate = activityDate;
            Cost = cost;
            Description = description;
            ActivityType = activityType;
        }

        // Methods
        public override string ToString()
        {
            return $"{Name} - {ActivityDate.ToShortDateString()} - {Cost:C}";
        }

        // This method is for sorting by date.
        public int CompareTo(object obj)
        {
            return ActivityDate.CompareTo(obj);
        }
        /* whenever i try to implement this method to compare each 
         * listbox by date it causes the program to crash. */
         public int CompareTo(Activity other)
        {
            return this.ActivityDate.CompareTo(other.ActivityDate);
        }
    }
}
