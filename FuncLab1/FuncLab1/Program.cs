using System.Collections.Generic;

static List<object> Singleton1(object a)
{
    List<object> List = new List<object>();
    List.Add(a);
    return List;
}
int a = 1;
List<object> List1 = Singleton1(a);
foreach (object o in List1)
{
    Console.WriteLine(o);
}

static Boolean Null1(List<object> b)
{
    if (b.ElementAt(0) == null)
    {
        return true;
    }
    else return false;
}


Console.WriteLine(Null1(List1));

static int Lenght1(List<object> a)
{
    int i = 0;
    foreach (object o in a)
    {
        if (o != null)
        {
            i++;
        }
    }
    return i;
}
Console.WriteLine(Lenght1(List1));

static List<object> Snoc(List<object> a, object b)
{
    a.Insert(Lenght1(a), b);
    return a;
}

Snoc(List1, 29);
foreach (object o in List1)
{
    Console.WriteLine(o);
}
