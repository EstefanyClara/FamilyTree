using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name=name; 
            this.Age=age; 
        }

        private string name; 
        private string age; 

        public string Name{get; set; }

        public int Age{get; set; }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this); 
        }
    }

}