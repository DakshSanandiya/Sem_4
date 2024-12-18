
using System;
using System.Collections;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter a number bitween 1-10 :");
        int ProgramNo = int.Parse(Console.ReadLine());

        if (ProgramNo == 1)
        {

            ArrayList StudentName = new ArrayList();

            
            //add Student
            StudentName.Add("Daksh");
            StudentName.Add("Sanandiya");
            StudentName.Add("Abhi");
            StudentName.Add("Daksh");
            StudentName.Add("Daksh");
            Console.WriteLine("Student name is " + string.Join(", ", StudentName.ToArray()));

            //remove student
            StudentName.RemoveAt(2);
            Console.WriteLine("Student name is " + string.Join(", ", StudentName.ToArray()));

            //remove student in range

            StudentName.RemoveRange(0, 3);
            Console.WriteLine("Student name is " + string.Join(", ", StudentName.ToArray()));

            // Clear all students
            StudentName.Clear();
            Console.WriteLine("ArrayList is Clear");

        }

        else if (ProgramNo == 2)
        {
            List<string> StudentName = new List<string>();


            // Add students
            StudentName.Add("Daksh");
            StudentName.Add("Sanandiya");
            StudentName.Add("Abhi");
            Console.WriteLine("Student Name is : " + string.Join(", ", StudentName));

            // Remove Student
            StudentName.RemoveAt(2);
            Console.WriteLine("Student Name is : " + string.Join(", ", StudentName));

            //Remove Student with range
            StudentName.RemoveRange(0, 3);
            Console.WriteLine("Student name is " + string.Join(", ", StudentName.ToArray()));

            // Clear all students
            StudentName.Clear();
            Console.WriteLine("List is Clear");
        }
        else if (ProgramNo == 3)
        {
            Stack<int> stack = new Stack<int>();


            // Add students
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("stack : " + string.Join(", ", stack));

            // Remove Student
            stack.Pop();
            Console.WriteLine("stack : " + string.Join(", ", stack));

            //Remove Student with range
            stack.Peek();
            Console.WriteLine("stack : " + string.Join(", ", stack.ToArray()));

            // Clear all students
            bool iscontains = stack.Contains(10);
            Console.WriteLine($"Is stack Contains 10 :{iscontains} ");

            stack.Clear();
            Console.WriteLine("stack is Clear");
        }
        else if (ProgramNo == 4)
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue items
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("After Enqueuing: " + string.Join(", ", queue));

            // Dequeue item
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            // Peek item
            Console.WriteLine("Peek: " + queue.Peek());

            // Check contains
            Console.WriteLine("Contains 20: " + queue.Contains(20));

            // Clear items
            queue.Clear();
            Console.WriteLine("After Clearing: Count = " + queue.Count);
        }

        else if(ProgramNo == 5)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Add key-value pairs
            students.Add(1, "Daksh");
            students.Add(2, "Sanandiya");
            Console.WriteLine("After Adding: " + string.Join(", ", students.Select(kv => kv.Key + "=" + kv.Value)));

            // Remove a key-value pair
            students.Remove(1);
            Console.WriteLine("After Removing: " + string.Join(", ", students.Select(kv => kv.Key + "=" + kv.Value)));

            // Check key and value existence
            Console.WriteLine("Contains Key 2: " + students.ContainsKey(2));
            Console.WriteLine("Contains Value 'Sanandiya': " + students.ContainsValue("Sanandiya"));

            // Clear dictionary
            students.Clear();
            Console.WriteLine("After Clearing: Count = " + students.Count);
        }

    }
}
