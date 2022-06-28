
namespace BookStore
{
    class Author
    {
        static void Main(String[] args)
        {
            Array objAuthorID = Array.CreateInstance(typeof(int), 3);
            Array objAuthorName = Array.CreateInstance(typeof(string), 3);
            Array objAddress = Array.CreateInstance(typeof(string), 3);
            Array objState = Array.CreateInstance(typeof(string), 3);

            String input = "";

            for (int i = 0; i < objAuthorName.Length; i++)
            {
                Console.Write("Enter ID of the Author :");
                input = Console.ReadLine();
                objAuthorID.SetValue(Convert.ToInt32(input), i);
                Console.Write("Enter the name of author :");
                input = Console.ReadLine();
                objAuthorName.SetValue(input, i);
                Console.Write("Enter the address:");
                input =Console.ReadLine();
                objAddress.SetValue(input, i);
                Console.Write("Enter the name of state:");
                input=Console.ReadLine();
                objState.SetValue(input, i);
                Console.WriteLine();
            }

            Console.WriteLine("\nDetails if the author :\n");
            Console.WriteLine("Author ID \tname\t\tAddress\t\t\tState");
            for (int i = 0; i < objAuthorName.GetUpperBound(0); i++)
            {
                Console.Write(objAuthorID.GetValue(i) + "\t\t");
                Console.Write(objAuthorName.GetValue(i) + "\t");
                Console.Write(objAddress.GetValue(i) + "\t");
                Console.WriteLine(objState.GetValue(i));
            }
 
            Array.Sort(objAuthorName);

            Console.WriteLine("\n Author names afer sorting :\n");
            for(int i = 0; i < objAuthorName.GetUpperBound(0); i++)
            {
                Console.WriteLine(objAuthorName.GetValue(i) + "\t");
            }

        }
    }
}