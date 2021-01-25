using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample.Lib
{
    public class IntegerLinkedList
    {
        IntegerNode _head;

        public IntegerLinkedList(int n)
        {
            _head = new IntegerNode(n, null);
        }
        public IntegerLinkedList()
        {
            _head = null;
        }

        public int Count { 
            get 
            {
                if (_head == null)
                    return 0;
                else
                    return _head.Count;
            } 
        }

        public int Sum {
            get 
            {
                IntegerNode current = _head;
                int total = 0;
                while (current != null)
                {
                    total += current.Value;
                    current = current.Next;
                }
                return total;
                
            } 
        }

        public void Append(int v)
        {
            if (_head == null)
            {
                _head = new IntegerNode(v);
            }
            else
            {
                _head.Append(v);
            }
        }

        public bool Remove(int v)
        {
            if (_head == null)
                return false;
            else if (_head.Value == v)
            {
                _head = _head.Next;
                return true;
            }
            else
            {
                return _head.Remove(v, null);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("{");
            IntegerNode current = _head;
            while (current != null)
            {
                result.Append(current.Value.ToString());
                current = current.Next;
                if (current != null)
                {
                    result.Append(", ");
                }

            }
            result.Append("}");
            return result.ToString();
        }

        class IntegerNode
        {
            int _value;
            IntegerNode _next;

            public int Count 
            { 
                get
                {
                    if (_next == null)
                        return 1;
                    else
                        return 1 + _next.Count;
                }
            }

            public int Value { get { return _value; } }
            public IntegerNode Next { get { return _next; } set { _next = value; } }

            public IntegerNode(int v)
            {
                _value = v;
                _next = null;
            }

            public IntegerNode(int v, IntegerNode n)
            {
                _value = v;
                _next = n;
            } 
            
            public void Append(int v)
            {
                if (_next == null)
                {
                    _next = new IntegerNode(v);
                    
                }
                else
                {
                    _next.Append(v);
                }
            }

            public bool Remove(int v, IntegerNode previous)
            {
                if (_value == v)
                {
                    previous.Next = _next;
                    return true;
                }
                else if(_next == null)
                {
                    return false;
                }
                else
                {
                    return _next.Remove(v, this);
                } 

            }

        }
    }
}
