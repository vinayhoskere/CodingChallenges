namespace CodingChallenges
{
    ////This is in C++. So will not compile
    //public interface ICustomHash
    //{
    //    int Hash(string key);
    //    void AddItem(string name, string drink);
    //    int NumberOfItemsInIndex(int index);
    //    void PrintTable();
    //    void PrintItemsInIndex(int index);
    //    string FindDrink(string name);
    //    void RemoveItem(string name);
    //}

    //struct item
    //{
    //    string name;
    //    private string drink;
    //    private item* next;
    //}

    //internal class CustomHashTable : ICustomHash
    //{
    //    private int TableSize { get; set; }
    //    private item* hashTableItem [TableSize];

    //    public CustomHashTable()
    //    {
    //        TableSize = 10;

    //        for (int i = 0; i < TableSize; i++)
    //        {
    //            hashTableItem[i] = new item();
    //            hashTableItem[i]->name = "empty";
    //            hashTableItem[i]->drink = "empty";
    //            hashTableItem[i]->next = null;
    //        }
    //    }

    //    public int Hash(string key)
    //    {
    //        int hash = 0;
    //        int index;

    //        for (int i = 0; i < key.Length; i ++)
    //        {
    //            hash += (int) key[i];
    //        }

    //        index = hash%TableSize;

    //        return index;
    //    }

    //    public void AddItem(string name, string drink)
    //    {
    //        int index = Hash(name);

    //        //Now check if the returned index is empty
    //        if (hashTableItem[index]->name == "empty")
    //        {
    //            hashTableItem[index]->name = name;
    //            hashTableItem[index]->drink = drink;
    //        }
    //        else
    //        {
    //            //get the first position in that index
    //            item* ptr = hashTableItem[index];
    //            item* newPtr = new item;

    //            //Create a new item with the values and have the next pointer set to null for now
    //            newPtr->name = name;
    //            newPtr->drink = drink;
    //            newPtr->next = null;

    //            //Check if the next pointer is null and loop through till the next pointer is null
    //            //This will give the last element
    //            while (ptr->next != null)
    //            {
    //                ptr = ptr->next;
    //            }

    //            ptr->next = newPtr;
    //        }
    //    }

    //    public int NumberOfItemsInIndex(int index)
    //    {
    //        int count = 0;

    //        if (hashTableItem[index]->name == "empty")
    //        {
    //            return count;
    //        }

    //        count++;
    //        item* ptr = hashTableItem[index];

    //        while (ptr->next != null)
    //        {
    //            count++;
    //            ptr = ptr->next;
    //        }

    //        return count;
    //    }

    //    public void PrintTable()
    //    {
    //        int number;
    //        for (int i = 0; i < TableSize; i++)
    //        {
    //            number = NumberOfItemsInIndex(i);
    //            Console.WriteLine("---------------------------\n");
    //            Console.WriteLine("index: " + i);
    //            Console.WriteLine(hashTableItem[i]->name);
    //            Console.WriteLine(hashTableItem[i]->drink);
    //            Console.WriteLine("# of items = ", number);
    //            Console.WriteLine("---------------------------\n");
    //        }
    //    }

    //    public void PrintItemsInIndex(int index)
    //    {
    //        item* ptr = hashTableItem[index];

    //        if (ptr->name == "empty")
    //        {
    //            Console.WriteLine("Index is empty");
    //            return;
    //        }

    //        Console.WriteLine("index: " + index + " contains");

    //        while (ptr->next != null)
    //        {
    //            Console.WriteLine("---------------------------\n");
    //            Console.WriteLine(ptr->name);
    //            Console.WriteLine(ptr->drink);
    //            Console.WriteLine("---------------------------\n");
    //            ptr = ptr->next;

    //        }
    //    }

    //    public string FindDrink(string name)
    //    {
    //        int index = Hash(name);
            
    //        item* ptr = hashTableItem[index];

    //        while (ptr->next)
    //        {
    //            if (name == ptr->name)
    //            {
    //                return ptr->drink;
    //            }
    //            ptr = ptr->next;
    //        }

    //        return string.Empty;
    //    }

    //    public void RemoveItem(string name)
    //    {
    //        int index = Hash(name);

    //        item* p1;
    //        item* delPtr;
    //        item* p2;

    //        //No items
    //        if (hashTableItem[index]->name == "empty")
    //        {
    //            Console.WriteLine("No Items found");
    //        }
    //            //only 1 item is contained in the bucket and that has a matching name
    //        else if (hashTableItem[index]->name == name && hashTableItem[index]->next == null)
    //        {
    //            hashTableItem[index]->name = "empty";
    //            hashTableItem[index]->drink = "empty";
    //        }
    //            //match is found and is the first item in the bucket and there are more items in the bucket
    //        else if (hashTableItem[index]->name == name)
    //        {
    //            delPtr = hashTableItem[index];
    //            hashTableItem[index] = hashTableItem[index]->next;
    //            //keyword in c++ to delete ptr
    //            delete delPtr;
    //        }
    //            //bucket contains items but first item is not a match
    //        else
    //        {
    //            p1 = hashTableItem[index]->next;
    //            p2 = hashTableItem[index];

    //            //we already know first is not a match as checked in before conditions
    //            //as long as we do not find a match keep going
    //            while (p1 != null && p1->name != name)
    //            {
    //                p2 = p1;
    //                p1 = p1->next;
    //            }
    //            if (p1 == null)
    //            {
    //                Console.WriteLine("not found");
    //            }
    //            else
    //            {
    //                delPtr = p1;
    //                p1 = p1->next;
    //                p2->next = p1;

    //                //keyword in c++ to delete ptr
    //                delete delPtr;
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        CustomHashTable cht = new CustomHashTable();

    //        int index = cht.Hash("Vinay");

    //        Console.WriteLine("Index : " + index);

    //        Console.ReadKey();
    //    }
    //}
}
