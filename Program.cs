namespace FamilyTree
{
    internal class Program
    {
        static void Main()
        {


            Man GodFather   = new Man("GodFather", DateTime.Parse("01.01.1901"));
            Man manAdam     = new Man("Adam", DateTime.Parse("01.01.1920"), GodFather);
            Woman womanEva  = new Woman("Eva", DateTime.Parse("01.01.1910"), GodFather);
            Man manAvel     = new Man("Avel", DateTime.Parse("01.01.1945"), manAdam, womanEva);
            Man manKain     = new Man("Kain", DateTime.Parse("01.01.1946"), manAdam, womanEva);
            Man manEnoh     = new Man("Enoh", DateTime.Parse("01.01.1946"));

            Family firstFamily = new Family(manAdam, womanEva, manAvel, manKain, manEnoh);

            FamilyTree familyTree = new FamilyTree(firstFamily);    


            familyTree.getFamilyTree();

            Console.ReadLine(); 
        }
    }
}