namespace CodingChallenges
{
    //public interface ILinkedList
    //{
    //    void AddNode(int addData);
    //    void DeleteNode(int delData);
    //    void PrintList();
    //}

    //class LinkedList : ILinkedList
    //{
    //    public struct node
    //    {
    //        private int data;
    //        private node* next;
    //    };

    //    private node* head = null;
    //    private node* curr = null;
    //    private node* trail = null;

    //    public void AddNode(int addData)
    //    {
    //        node* n = new node;
    //        n->next - null;
    //        n->data = addData;

    //        //this means that there is already a list set up
    //        if (head != null)
    //        {
    //            //set the current pointer to head to go to the end
    //            curr = head;

    //            while (curr->next != null)
    //            {
    //                curr = curr->next;
    //            }
    //            //Once it exits it means the last element
    //            curr->next = n;
    //        }
    //        else
    //        {
    //            head = n;
    //        }
    //    }

    //    public void DeleteNode(int delData)
    //    {
    //        //case 1 - empty list
    //        if (head == 0)
    //        {
    //            Console.WriteLine("Node cannot be deleted in an empty list");
    //            return;
    //        }

    //        curr = head;

    //        while (curr != null)
    //        {
    //            if (curr->data == delData)
    //            {
    //                break;
    //            }
    //            else
    //            {
    //                trail = curr;
    //                curr = curr->next;
    //            }
    //        }

    //        //if data is not found
    //        if (curr == null)
    //        {
    //            Console.WriteLine("Node cannot be deleted in an empty list");
    //            return;
    //        }

    //        //delete from head node
    //        if (head == curr)
    //        {
    //            if (head->next != null)
    //                head = head->next;
    //        }
    //        else
    //        {
    //            trail->next = curr->next;
    //        }

    //        delete curr;
    //    }

    //    public void PrintList()
    //    {
    //        curr = head;

    //        while (curr != null)
    //        {
    //            Console.WriteLine(curr);
    //            curr = curr->next;
    //        }
    //    }
    //}
}
