// See https://aka.ms/new-console-template for more information

// Cody Allen
// IT112 
// NOTES: the classes do work but shipper does not 
// BEHAVIORS NOT IMPLEMENTED AND WHY: The shipper class was giving me problems so I put everything in main
// but the program itself is not finished. I'm not sure how to implement everthing together into a manifest 
// 

using Allen_Inventory;

int userInput = Convert.ToInt32(Console.ReadLine());
int userList = 0;
int totalAmount;
bool h = true;

Console.WriteLine("Choose an option: ");
Console.WriteLine("1) Bicycles");
Console.WriteLine("2) Lawn Mowers");
Console.WriteLine("3) Crackers");
Console.WriteLine("4) BaseBall Gloves");
Console.WriteLine("5) Exit");

while (h)
{
    if (userInput == 1)
    {
        
    }
    else if (userInput == 2)
    {
        
    }
    else if (userInput == 3)
    {

    }
    else if(userInput == 4)
    {

    }
    else if (userInput == 5)
            {
        
    }
}
//Console.WriteLine("Your total amount of items is: " + totalAmount);






IShippable[] Items = new IShippable[10];
        Items[0] = new Baseball_Gloves();
        Items[1] = new Crackers();
        Items[2] = new Lawn_Mowers();
        Items[3] = new Baseball_Gloves();
        Items[4] = new Lawn_Mowers();
        Items[5] = new Lawn_Mowers();
        Items[6] = new Bicycle();
        Items[7] = new Crackers();
        Items[8] = new Lawn_Mowers();
        Items[9] = new Bicycle();

//for (int i = 0; i < Items.Length; i++)
//{
//    Console.WriteLine(Items[i].Product);
//    Console.WriteLine(Items[i].ShipCost);
//}





//int count = 0; 
//foreach (IShippable item in Items) { count++; }
//Console.WriteLine(count);
