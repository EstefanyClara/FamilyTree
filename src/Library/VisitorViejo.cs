using System;

namespace Library
{
    public class VisitorViejo: Visitor
    {
        public override void Visit(NodePerson nodePerson)
        {
            int edad =0; 
            foreach(NodePerson lista in nodePerson.Children)
            {
               foreach(NodePerson nodo in lista.Children)
               {
                   if (nodo.Person.Age > edad )
                   {
                       
                       
                   }
               }
            
            }
            

        }   
        

    }
}
