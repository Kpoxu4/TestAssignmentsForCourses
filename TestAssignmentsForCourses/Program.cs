using TestAssignmentsForCourses;
//test 1
Console.WriteLine(new ComputerNamer(25).ResultString);
Console.WriteLine(new ComputerNamer(3).ResultString);
Console.WriteLine(new ComputerNamer(8).ResultString);
Console.WriteLine();
// test 2
Console.WriteLine(new CommonDivisors(new int[] { 42, 12, 18 }).StringResult);
Console.WriteLine(new CommonDivisors(new int[] { 48, 58, 26 }).StringResult);
Console.WriteLine();
// test 3
Console.WriteLine(new PrimeNumbers(11, 20).Result);
Console.WriteLine(new PrimeNumbers(1, 9).Result);
Console.WriteLine();
// test 4
Console.WriteLine(new MultiplicationTable(5).Result);
Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
Console.WriteLine(new MultiplicationTable(8).Result);
Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");


Console.ReadLine(); 


    

