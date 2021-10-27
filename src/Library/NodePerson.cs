using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NodePerson
    {
        private Person person;

        private List<NodePerson> children = new List<NodePerson>();

        public Person Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<NodePerson> Children{ 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public NodePerson(Person person)
        {
            this.person = person;
        }

        public void AddChildren(NodePerson n)
        {
            this.children.Add(n);
        }
          public void Accept(Visitor visitor)
        {
            visitor.Visit(this); 
        }
        
    }
}
