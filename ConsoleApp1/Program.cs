// See https://aka.ms/new-console-template for more information

//ring name = Console.ReadLine();

//nsole.WriteLine("My Name: " + name);



Double salaray = 10.500;

//decimal _salary = 12.33;

string name = "ANas 1233";

char key = 'c';


DateTime dateTime = DateTime.Now;

DateTime dateonly = new DateTime(2024, 1, 1, 0, 0, 0);



/*
if(YEAR == 2024)
{
    Console.WriteLine("Current Year..");
}
else if(YEAR == 2025)
{
    Console.WriteLine("Next Year..");
}
else
{
    Console.WriteLine("Opps!!!");
}
*/

//while(true) {
//    int YEAR = Convert.ToInt32(Console.ReadLine());

//    switch(YEAR)
//    {
//        case 2024:
//        {
//            Console.WriteLine("Current Year..");

//            break;
//        }
//        case
//         2025:
//        {
//            Console.WriteLine("Next Year..");

//            break;
//        }
//        default:
//        {
//            Console.WriteLine("Opps!!!");
//            return;
//            break;

//        }
//    }
//}

bool active = true;

//do
//{
//    int YEAR = Convert.ToInt32(Console.ReadLine());

//    switch(YEAR)
//    {
//        case 2024:
//        {
//            Console.WriteLine("Current Year..");

//            break;
//        }
//        case
//         2025:
//        {
//            Console.WriteLine("Next Year..");

//            break;
//        }
//        default:
//        {
//            Console.WriteLine("Opps!!!");
//            active = false;
//            break;

//        }
//    }

//} while(active == true);








//for(int i = 0;i < 3;i++)
//{
//    int YEAR = Convert.ToInt32(Console.ReadLine());

//    switch(YEAR)
//    {
//        case 2024:
//        {
//            Console.WriteLine("Current Year..");

//            break;
//        }
//        case
//         2025:
//        {
//            Console.WriteLine("Next Year..");

//            break;
//        }
//        default:
//        {
//            Console.WriteLine("Opps!!!");
//            active = false;
//            break;

//        }
//    }
//}


//for(int i = 0;i < 3;i++)
//{
//    if(i == 1)
//        continue;
//}

//int[] array = new int[3] { 1, 2, 3 };

//foreach(var item in array)
//{
//    if(item == 2)
//        continue;
//}



string[] names = new string[3];
names[0] = "Anas";
names[1] = "Ahmad";
names[2] = "Ali";
Console.WriteLine("Foreach");

foreach(var item in names)
{
    if(item == "Ahmad")
        continue;    
    Console.WriteLine(item);
}


Console.WriteLine("For");
for(int i = 0;i < names.Length;i++)
{
    if(names[i] == "Ahmad")
        break;
    Console.WriteLine(names[i]);
}
string[] _names = new string[3];
List<string> list = new List<string>(); ;

while(true)
{
    string _name = Console.ReadLine();
    if(_name == "Exit")
        break;
    list.Add(_name);
}

Console.WriteLine("namesss");
foreach(var item in list)
{
    Console.WriteLine(item);
}


List<int> listOfInt = new List<int>();
List<double> listOfdouble = new List<double>();
List<dynamic> listOfDynamic = new List<dynamic>();

dynamic age = Console.ReadLine();

listOfDynamic.Add(age);

foreach(dynamic item in listOfDynamic)
{
    Console.WriteLine(item);
}
