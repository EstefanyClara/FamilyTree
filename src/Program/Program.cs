using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí*/
            Person p1= new Person("Estefany", 26); 
            Person p2= new Person("Juan", 80); //padre de estefany y carlos
            Person p3= new Person("Carlo", 34); 
            Person p4= new Person("Wanda", 30); 
            Person p5= new Person("Icardi", 10); 
            Person p6= new Person("Josema", 50); 
            Person p7= new Person("Rapha", 35); 
            Person p8= new Person("Maria", 55); 
            NodePerson n1= new NodePerson(p1); 
            NodePerson n2= new NodePerson(p2); 
            NodePerson n3= new NodePerson(p3); 
            n2.AddChildren(n1); 
            n2.AddChildren(n3); 
        }
    }
}
