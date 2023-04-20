using VC_InheritanceEg;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student(21,"Sydney",23,"ST100");
        Person student1 = new Student(34, "Thato", 12, "ST555");
        
        student.displayResult();
    }
}