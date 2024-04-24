string folderPath = @"Users/miko/Projects";
string fileName = "shoppinglist.rtf";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, fileName);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}


List<string> myShoppingList = GetItemsFromUser();
ShowItemsFromList(myShoppingList);

static List<string> GetItemsFromUser()
{
    List<string> myShoppingList = new List<string>();

while (true)
{
    Console.WriteLine("Add an item (add)/ Exit (exit):");
    string userChoice = Console.ReadLine();

    if (userChoice == "add")
    {
        Console.WriteLine("Enter an item:");
        string userItem = Console.ReadLine();
        myShoppingList.Add(userItem);

    }
    else
    {
        Console.WriteLine("Bye!");
        break;
    }
    return myShoppingList;
}

static void ShowItemsFrom(List<string someList>
{
        Console.Clear()

int listLength = someList.Count;
        Console.WriteLine($"You have added {listLength} items to your shopping list. ");

        int i = 1;
        foreach (string item in myShoppingList)
        {
            Console.WriteLine($"{i}. {item}");
            i++;
        }
    }
