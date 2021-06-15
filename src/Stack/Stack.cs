using System.Collections.Generic;
using System;
namespace Collections
{
    public class Stack<T>
    {
        private LinkedList<T> _elements;

        public int Size
        {
            get
            {
                return _elements.Count;
            }
        }

        public Stack()
        {
            _elements = new LinkedList<T>();
        }

        public bool Push(T newElement)
        {
            _elements.AddFirst(newElement);
            return true;
        }

        public T Pop()
        {
            var popedElement = _elements.First.Value;
            _elements.RemoveFirst();
            return popedElement;
        }

        public T Peak()
        {
            return _elements.First.Value;
        }

        public void Print(Action<T> d)
        {
            foreach (var item in _elements)
            {
                d(item);
            }
        }
        public void Clear()
        {
            _elements.Clear();
        }
    }
}