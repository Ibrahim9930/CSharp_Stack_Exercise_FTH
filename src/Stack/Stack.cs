using System.Collections.Generic;
namespace Collections
{
    public class Stack<T>
    {
        private LinkedList<T> _dataList;

        public int Size
        {
            get
            {
                return _dataList.Count;
            }
        }

        public Stack()
        {
        }

        public bool Push(T newElement)
        {
            //TODO: implement
            return false;
        }

        public T Pop()
        {
            //TODO: implement
            return default(T);
        }

        public void Print()
        {
            //TODO: implement
        }

        public T Peak()
        {
            //TODO: implement
            return default(T);
        }

        public void Clear()
        {
            //TODO: implement
        }
    }
}