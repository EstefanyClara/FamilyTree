using System;

namespace Library
{
    public class VisitorPerson : Visitor
    {
        public override void Visit(NodePerson nodePerson)
        {
           ContentAge+= nodePerson.Person.Age; 

            foreach(NodePerson lista in nodePerson.Children)
            {
               foreach(NodePerson nodo in lista.Children)
               {
                   ContentAge+= nodePerson.Person.Age; 
                          
               }
               ContentAge += lista.Person.Age; 
            }
            Console.WriteLine("La suma total de edades de la familia es de: "+ ContentAge);  
        }

    }
}
