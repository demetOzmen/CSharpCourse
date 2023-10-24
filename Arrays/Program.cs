//string student1 = "Demet";
//string student2 = "Ayşegül";
//string student3 = "Enes";


string[] students = new string[3];
students[0] = "Demet";
students[1] = "Ayşegül";
students[2] = "Enes";

string[] students2 = new string[] {"Demet","Ayşegül","Enes" };
//students2[3] = "Ahmet";
//foreach (string student in students)
//{
//    Console.WriteLine(student);
//}
string[,] regions = new string[5, 3]
//regions[0, 0] = "istanbul";
{
    {"İstanbul","izmit","Balıkesir" },
    {"Ankara","Kkonya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Aydın" },
    
};
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("**************");
}

Console.WriteLine();
Console.ReadLine();