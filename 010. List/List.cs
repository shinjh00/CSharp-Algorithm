using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class List<T>
    {
        private const int DefaultCapacity = 4;  // 처음 기본 capacity는 4로 정의 (후에 수정될 수도 있음)

        private T[] items;  // 아이템을 담을 통
        private int count;  // 현재 통에 담겨있는 아이템 개수


        // List 생성자 함수
        public List()
        {
            items = new T[DefaultCapacity];
            count = 0;
        }

        public List(int capacity)
        {
            items = new T[capacity];  // 현재 통의 크기로 List 인스턴스 만들기
            count = 0;
        }


        // private 선언되어있는 변수들 get 할 수 있게 프로퍼티 생성
        public int Capacity { get { return items.Length; } }
        public int Count { get { return count; } }
        public bool IsFull { get { return count == items.Length; } }


        /* 접근 */
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }


        /* 맨 뒤에 추가 */
        public void Add(T item)
        {
            if (IsFull)  // 가득 차 있을 때
                Grow();

            items[count++] = item;
        }

        /* 중간에 추가 */
        public void Insert(int index, T item)
        {
            // 예외처리 필요 : 크기를 벗어난 곳에 끼워넣는 것은 불가능
            if (index < 0 || count < index)
            {
                Console.WriteLine("=ERROR=");
                throw new ArgumentOutOfRangeException("index");
            }

            if (IsFull)
                Grow();

            // Insert(1, X) => item[1]에 X 넣기
            // Copy ( items 배열의,  index 위치에 있는 요소를,  items 배열의,  index+1 위치로 옮겨라,  몇 개 )
            // count - index => (가지고 있는 개수) - (넣을 곳의 인덱스)
            Array.Copy(items, index, items, index + 1, count - index);
            // ┌─┬─┬─┬─┬─┐    ┌─┬─┬─┬─┬─┐ 
            // │1│2│3│4│ │ -> │1│ │2│3│4│  중간에 추가하기 위해 뒤로 밀기
            // └─┴─┴─┴─┴─┘    └─┴─┴─┴─┴─┘  
            items[index] = item;
            count++;
        }


        /* 삭제 */
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)         // 찾아졌을 때만
            {
                RemoveAt(index);    // 지우기
                return true;
            }
            else                    // 못 찾았을 땐
            {
                return false;       // 지우기 않기
            }
        }

        /* 특정 자리에 있는 것 삭제 */
        public void RemoveAt(int index)
        {
            // 예외처리 필요 : 크기를 벗어난 곳에 있는 것은 삭제 불가능
            if (index < 0 || count <= index)
            {
                Console.WriteLine("=ERROR=");
                throw new ArgumentOutOfRangeException("index");
            }

            count--;
            Array.Copy(items, index + 1, items, index, count - index);
            // ┌─┬─┬─┬─┬─┐    ┌─┬─┬─┬─┬─┐ 
            // │1│2│3│4│5│ -> │1│ │3│4│5│  중간에 있는거 지웠으니 자리 당겨오기
            // └─┴─┴─┴─┴─┘    └─┴─┴─┴─┴─┘  
        }


        /* 인덱스 찾기 */
        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                // ==은 값이 같으냐를 묻고, .Equals는 주소값이 같으냐를 묻는다.
                if (item.Equals(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }


        /* 배열 용량 늘리기 */
        private void Grow()
        {
            // 2. 새로운 더 큰 배열 생성
            T[] newItems = new T[items.Length * 2];

            // 3. 새로운 배열에 기존의 데이터 복사
            Array.Copy(items, newItems, items.Length);  // 이게 더 빠름
            //for (int i = 0; i < items.Length; i++) { newItems[i] = items[i]; }

            // 4. 기본 배열 대신 새로운 배열을 사용
            items = newItems;
        }

    }
}
