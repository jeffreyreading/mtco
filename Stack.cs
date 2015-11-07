
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class MStack
    {
        Stack<Card> theStack = new Stack<Card>;
        
        public void ontoStack(Card inStack)
        {
            theStack.Push(inStack);
        }

        public Card resolveObject()     //Card correct object? Or make Effect class?
        {
            return theStack.Pop();
        }

        public bool empty()
        {
            if(theStack.Count == 0)
            {
                return true;
            }
            return false;
        }


    }
}
