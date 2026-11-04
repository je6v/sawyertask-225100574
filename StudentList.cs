// Name: Mahmoud Mohamed Ramadan Mahfouz
// Student ID: 225100574

using System;

namespace sawyertask
{
    public class StudentList
    {
        public Student? First;
        public Student? Last;
        public int Count;

        public void AddFront(int id)
        {
            Student s = new Student(id);
            s.Next = First;
            First = s;
            if (Last == null)
                Last = s;
            Count++;
        }

        public void AddEnd(int id)
        {
            Student s = new Student(id);
            if (Last == null)
            {
                First = s;
                Last = s;
            }
            else
            {
                Last.Next = s;
                Last = s;
            }
            Count++;
        }

        public bool Remove(int id)
        {
            if (First == null)
                return false;

            if (First.Id == id)
            {
                First = First.Next;
                if (First == null)
                    Last = null;
                Count--;
                return true;
            }

            Student? prev = First;
            while (prev.Next != null && prev.Next.Id != id)
                prev = prev.Next;

            if (prev.Next == null)
                return false;

            Student target = prev.Next;
            prev.Next = target.Next;
            if (target == Last)
                Last = prev;
            Count--;
            return true;
        }

        public void Reverse()
        {
            Student? prev = null;
            Student? current = First;

            while (current != null)
            {
                Student? next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            Last = First;
            First = prev;
        }

        public void Print()
        {
            Student? current = First;
            while (current != null)
            {
                Console.Write(current.Id);
                if (current.Next != null)
                    Console.Write(" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}