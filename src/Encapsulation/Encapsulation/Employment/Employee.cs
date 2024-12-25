using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private double _monthlySalary;

        public string FirstName
        {
            get => _firstName;
            set => _firstName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        }

        public double MonthlySalary
        {
            get => _monthlySalary;
            set => _monthlySalary = value > 0 ? value : _monthlySalary;
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary > 0 ? monthlySalary : 0.0;
        }

        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary *= (1 + raisePercentage / 100.0);
            }
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}