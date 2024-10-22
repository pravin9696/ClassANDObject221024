
using ClassANDObject221024Old;


namespace ClassANDObject221024
{
    struct student
    {
       public int roll;
        string name;
        int total_marks;
        string dept;
    }
    struct mystruct
    {
        //all variables
        public int x;
        public int y;


        //methods
        public void method1()
        {
            Console.WriteLine("hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            student s1=new student();
            s1.roll = 11;
        }
        
    }
}
