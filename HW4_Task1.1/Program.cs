// Alexandra Camarena
// MIS 3013
// HW4 Task 1

//Q1

Console.WriteLine("m=?");
string mStr = Console.ReadLine();
double m = Convert.ToDouble(mStr);

Console.WriteLine("x=?");
string xStr = Console.ReadLine();
double x = Convert.ToDouble(xStr);

Console.WriteLine("b=?");
string bStr = Console.ReadLine();
double b = Convert.ToDouble(bStr);


double result = LineValueForY(m, x, b);//m = 2, x = 3, b = 4
string outMesStr = String.Format($"Y={m:F2}*{x:F2}+{b:F2}={result:F2}");
Console.WriteLine(outMesStr);

double r2 = LineValueForY(2, 3, 6);
double r3 = LineValueForY(6, 3, 6);
double r4 = LineValueForY(10, 3, 6);


Console.ReadKey();

// define function here 
//datatype function_name(double x1, int age1, ....)
//{
//  //function body
//    return datetype_var;
//}
// functions methods
double LineValueForY(double m, double x, double b)//; here is wrong
{
    double result = m * x * b;
    return result;
}