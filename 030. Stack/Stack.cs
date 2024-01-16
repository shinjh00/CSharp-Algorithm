using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /******************************************************************
     * 어댑터 패턴 (Adapter)
     * 
     * 한 클래스의 인터페이스를 사용하고자 하는 다른 인터페이스로 변환
     ******************************************************************/

    //    [List]        [Stack]
    //     Add()         Push()
    //     Pop()       RemoveAt()
    //    Peek()   list[list.Count-1]

    public class Stack<T>
    {
        private List<T> container;

        public Stack()
        {
            container = new List<T>();
        }

        public int Count { get { return container.Count; } }

        public void Push(T item)
        {
            container.Add(item);
        }

        public T Pop()
        {
            T item = container[container.Count - 1];  // 삭제 전에 먼저 확인하기 위해
            container.RemoveAt(container.Count - 1);
            return item;
        }

        public T Peek()
        {
            return container[container.Count - 1];
        }
    }
}