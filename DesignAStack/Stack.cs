using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignAStack
{
    public class Stack
    {
        public List<object> myCollection { get; set; } = new List<object>();

        public void Push(object randomObject)
        {
            if (randomObject != null)
            {
                // if the rondomwObject pass in is other type other than object
                // then the upcasting will implicitly happens
                // at the same time, boxing will also happen if the parameter is not object type
                myCollection.Add(randomObject);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Pop()
        {
            if (myCollection.Count() > 0)
            {
                var valueToPop = myCollection[myCollection.Count() - 1];
                myCollection.RemoveAt(myCollection.Count - 1);
                return valueToPop;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Clear()
        {
            myCollection.Clear();
        }
    }
}
