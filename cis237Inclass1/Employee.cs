﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Employee
    {
        //***
        //Backing Fields
        //***
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        //***
        //Properties
        //***
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //****
        //Public methods
        //****

        public override string ToString()
        {
            return this._firstName + " " + this._lastName;
        }

        public decimal YearlySalary()
        {
            return this._weeklySalary * 52;
        }
        //***
        //Constructor
        //***
        public Employee(string _firstName, string _lastName, decimal _weeklySalary)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.WeeklySalary = _weeklySalary;
        }
        public Employee()
        {
            //Do nothing
        }

    }
}