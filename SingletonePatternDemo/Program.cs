namespace SingletonePatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singletone employee = Singletone.Getinstance;
            employee.printDetaild("FROM EMPLOYEE");

            Singletone student = Singletone.Getinstance;
            student.printDetaild("FROM SUDENT");
        }
    }
}
