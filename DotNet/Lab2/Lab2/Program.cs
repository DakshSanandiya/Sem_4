using Lab2;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a program number (1-10) : ");
        int programNO = int.Parse(Console.ReadLine());


        // 1.
        if (programNO == 1)
        {
            Candidate candidate = new Candidate();
            candidate.GetCandidateDetails();
            candidate.DisplayCandidateDetails();
        }

        // 2.
        else if (programNO == 2)
        {

            Staff[] arr = new Staff[5];
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter a Data of staff {i + 1}");
                arr[i] = new Staff();
                arr[i].GetStaffData();
            }
            for (int i = 0; i < 5; i++)
            {

                if (arr[i].StaffDesignation.ToLower() == "hod")
                {
                    arr[i].DisplayStaff();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Here , no any staff which has HOD Designation");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // 3.
        else if (programNO == 3)
        {
            Bank_Account bank_Account = new Bank_Account();
            bank_Account.GetAccountDetails();
            bank_Account.DisplayAccountDetails();
        }
        //4
else if (programNO == 4)
{
    Student student = new Student();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    student.DisplayStudentDetails();
    Console.ForegroundColor = ConsoleColor.White;
}
//5
else if (programNO == 5)
{
    AreaofRectangle obj = new AreaofRectangle();
}
//6
else if (programNO == 6)
{
    Interest interest = new Interest();
    interest.Account_Details1();
    interest.Interest1();
}
else
{
    Console.WriteLine("Invalid Input Pls Try Again...");
}
    }
}
