#region Union
using System.Xml.Linq;
Console.Write("Union\n---------------\n");

string[] names1 = { "Alice", "Bob", "Charlie", "David" };
string[] names2 = { "Charlie", "Eve", "Frank", "Alice" };

IEnumerable<string> union = names1.Union(names2);
foreach (string name in union)
{
    Console.Write("{0}\n", name);
}
#endregion

#region Cast
Console.WriteLine("\nCast\n---------------");

System.Collections.ArrayList fruits = new System.Collections.ArrayList();
fruits.Add("mango");
fruits.Add("apple");
fruits.Add("lemon");

IEnumerable<string> query =
    fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

foreach (string fruit in query)
{
    Console.WriteLine(fruit);
}

#endregion

#region OfType
Console.WriteLine("\nOfType\n---------------");

System.Collections.ArrayList types = new System.Collections.ArrayList(4);
fruits.Add("Mango");
fruits.Add("Orange");
fruits.Add("Apple");
fruits.Add(3.0);
fruits.Add("Banana");

IEnumerable<string> query1 = fruits.OfType<string>();

Console.WriteLine("Elements of type 'string' are:");
foreach (string fruit in query1)
{
    Console.WriteLine(fruit);
}

IEnumerable<string> query2 =
    fruits.OfType<string>().Where(fruit => fruit.ToLower().Contains("n"));

Console.WriteLine("\nThe following strings contain 'n':");
foreach (string fruit in query2)
{
    Console.WriteLine(fruit);
}
#endregion



#region Empty
Console.WriteLine("\nEmpty\n---------------");

string[] names4 = { "Hartono, Tommy" };
string[] names5 = { "Adams, Terry", "Andersen, Henriette Thaulow",
                      "Hedlund, Magnus", "Ito, Shu" };
string[] names6 = { "Solanki, Ajay", "Hoeing, Helge",
                      "Andersen, Henriette Thaulow",
                      "Potra, Cristina", "Iallo, Lucio" };

List<string[]> namesList =
    new List<string[]> { names4, names5, names6 };

IEnumerable<string> allNames =
    namesList.Aggregate(Enumerable.Empty<string>(),
    (current, next) => next.Length > 3 ? current.Union(next) : current);

foreach (string name in allNames)
{
    Console.WriteLine(name);
}
#endregion

#region First FirstOrDefault

Console.Write("First FirstOrDefault\n---------------\n");

List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
int firstNumber1 = numbers.DefaultIfEmpty(1).First();
Console.WriteLine("The value of the firstNumber1 variable is {0}", firstNumber1);

int notInList = 7;
int firstNumber2 = numbers.FirstOrDefault(x => x == notInList);
if (firstNumber2 == 0)
{
    firstNumber2 = 1;
}
Console.WriteLine("The value of the firstNumber2 variable is {0}", firstNumber2);

#endregion

#region Where
Console.Write("Where\n---------------\n");

List<string> flowers = new List<string>
        {
            "rose", "tulip", "daisy", "lily", "orchid", "sunflower", "iris"
        };

IEnumerable<string> filter = flowers.Where(flower => flower.Length < 6);

Console.WriteLine("Names of flowers (less than 6 feet tall):\n");
foreach (string flower in query)
{
    Console.WriteLine(flower);
}
#endregion

#region Any
Console.Write("Any\n---------------\n");

Queue<string> tasks = new Queue<string>();
tasks.Enqueue("Task 1");
tasks.Enqueue("Task 2");
tasks.Enqueue("Task 3");

bool hasElements = tasks.Any();

Console.WriteLine("The collection {0} empty.",
    hasElements ? "is not" : "is");
#endregion

#region All
Console.Write("All\n---------------\n");

List<string> householdItems = new List<string>
        {
            "vacuum cleaner", "microwave", "washing machine", "toaster", "dishwasher"
        };

int minLength = 10;

// Are all household items at least minLength characters long?
bool allMeetMinLength = householdItems.All(item => item.Length >= minLength);

if (allMeetMinLength)
{
    Console.WriteLine("All household items are at least {0} characters long.", minLength);
}
else
{
    Console.WriteLine("Not all household items are at least {0} characters long.", minLength);
}
#endregion