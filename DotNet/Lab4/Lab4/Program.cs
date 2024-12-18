using Lab4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a program number (1-6) : ");
        int programNO = int.Parse(Console.ReadLine());

        if (programNO == 1)
        {
            AdditionOfTwoNumbers sum = new AdditionOfTwoNumbers();
            sum.addTwonum(1, 2);
            sum.addTwonum(1.5f, 5.5f);
        }
        else if (programNO == 2)
        {
            CalculateAreaOfSquareAndRectangle area = new CalculateAreaOfSquareAndRectangle();
            area.area(10f);
            area.area(20f,30f);
        }
        else if (programNO == 3)
        {
            RBI RbiInterest = new RBI();
            RbiInterest.calculateInterest(10f,15f,19f);

            HDFC HdfcInterest = new HDFC();
            HdfcInterest.calculateInterest(10f, 15f, 19f);

            SBI SbiInterest = new SBI();
            SbiInterest.calculateInterest(10f, 15f, 19f);

            ICICI IciciInterest = new ICICI();
            IciciInterest.calculateInterest(10f, 15f, 19f);
        }
        else if (programNO == 4)
        {
            Hospital hospital = new Hospital();
            hospital.HospitalDetails();

            Apollo apollo = new Apollo();
            apollo.HospitalDetails();

            Wockhardt wockhardt = new Wockhardt();
            wockhardt.HospitalDetails();

            Gokul_Superspeciality gokul_superspeciality = new Gokul_Superspeciality();
            gokul_superspeciality.HospitalDetails();
        }
        else if (programNO == 5)
        {
            FindArea area = new FindArea();
            area.area(15);
            area.area(15f);
            area.area(15f, 18f);
        }
        else if (programNO == 6)
        {
            
        }
    }
}