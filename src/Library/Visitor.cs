using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System; 

namespace Library
{
    public abstract class Visitor
    {
        public string Content
        {
            get 
            {
                return this.ContentAge.ToString(); 
            }

        }
        public int ContentAge; 


        public abstract void Visit (NodePerson nodePerson); 
    }
}