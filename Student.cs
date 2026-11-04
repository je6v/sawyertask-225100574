namespace sawyertask
{
    public class Student
    {
        public int Id;
        public Student? Next;

        public Student(int id)
        {
            Id = id;
            Next = null;
        }
    }
}