BinarySearchTree_DataStructures.Binary_Search_tree_DataStructures<int> tree = new BinarySearchTree_DataStructures.Binary_Search_tree_DataStructures<int>(0);
Console.WriteLine("Binary Search Tree Operations : \n0.Exit\n1.Add node\n2.Display tree\nEnter your choice:");
int option = Convert.ToInt32(Console.ReadLine());
while (option != 0)
{
    switch (option)
    {
        case 1:
            Console.WriteLine("Number of nodes you want to add.");
            int numberOfNodes = Convert.ToInt32(Console.ReadLine());
            while (numberOfNodes != 0)
            {
                Console.Write("Enter node:");
                int node = Convert.ToInt32(Console.ReadLine());

                tree.AddNode(node);
                numberOfNodes--;
            }
            break;
        case 2:
            tree.Display();
            break;
        default:
            Console.WriteLine("Enter valid option.");
            break;
    }
    Console.WriteLine("BST Operations\n0.Exit\n1.Add node\n2.Display tree\nEnter your choice:");
    option = Convert.ToInt32(Console.ReadLine());
}