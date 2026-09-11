namespace StudentEnrollmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentNumber1 = "2026-00123-BN-0";

            string courseA = "Introduction to Computing", courseB = "Basic Computer Hardware Servicing",
                courseC = "PATHFIT 1", courseD = "Advanced Programming";

            bool courseA_Status = false, courseB_Status = false, courseC_Status = false, courseD_Status = false;

            Console.WriteLine("1 - Login as Student");
            Console.WriteLine("2 - Logout");
            Console.Write("User Input: ");
            int checkLogin = Convert.ToInt16(Console.ReadLine());

            while (checkLogin != 2)
            {
                Console.WriteLine("Enter Student Number: ");
                string studentNumberInput = Console.ReadLine();


                if (studentNumberInput == studentNumber1)
                {
                    Console.WriteLine("Welcome, Juan Dela Cruz!");

                    Console.WriteLine("1 - Enroll to a Course");
                    Console.WriteLine("2 - View Enrolled Courses");
                    Console.WriteLine("Select an action: ");
                    int userAction = Convert.ToInt16(Console.ReadLine());


                    switch (userAction)
                    {
                        case 1:
                            Console.WriteLine("""
                            Select a Course to enroll in: 
                            A. Introduction to Computing
                            B. Basic Computer Hardware Servicing
                            C. PATHFIT 1
                            D. Advanced Programming
                            """);
                            Console.Write("User Input: ");
                            string courseOption = Console.ReadLine();

                            if (courseOption == "A")
                            {
                                courseA_Status = true;
                                Console.WriteLine($"You are now enrolled in {courseA}.");
                            }

                            else if (courseOption == "B")
                            {
                                courseB_Status = true;
                                Console.WriteLine($"You are now enrolled in {courseB}.");
                            }

                            else if (courseOption == "C")
                            {
                                courseC_Status = true;
                                Console.WriteLine($"You are now enrolled in {courseC}.");
                            }

                            else if (courseOption == "D")
                            {
                                courseD_Status = true;
                                Console.WriteLine($"You are now enrolled in {courseD}.");
                            }

                            break;


                        case 2:
                            Console.WriteLine("Enrolled Courses: ");
                            if (courseA_Status == true)
                            {
                                Console.WriteLine(courseA);
                            }
                            if (courseB_Status == true)
                            {
                                Console.WriteLine(courseB);
                            }
                            if (courseC_Status == true)
                            {
                                Console.WriteLine(courseC);
                            }
                            if (courseD_Status == true)
                            {
                                Console.WriteLine(courseD);
                            }
                            break;


                        default:
                            Console.WriteLine("Invalid Action...");
                            break;

                    }

                }
                Console.WriteLine("1 - Login as Student");
                Console.WriteLine("2 - Logout");
                Console.Write("User Input: ");
                checkLogin = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}
