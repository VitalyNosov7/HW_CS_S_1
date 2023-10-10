namespace FamilyTree
{
    internal class FamilyTree
    {
        public Family family;
        public FamilyTree(Family family)
        {
            this.family = family;
        }
        public void print(Human o)
        {
            Console.WriteLine($"Имя {o.name}, день рождения {o.birthday}");
        }

        public void getFamilyTree()
        {
            Console.WriteLine(new String('=', 80));
            Console.WriteLine("Генеалогическое древо:\n");
            Console.WriteLine("Родители:\n");
            if (family.father != null)
            {
                Console.WriteLine("Отец:");

                print(family.father);
            }
            if (family.mother != null)
            {
                Console.WriteLine("Мать:");

                print(family.mother);
            }
            Console.WriteLine(new String('=', 80));
            if (family.listChildren != null && family.listChildren.Count != 0)
            {
                Console.WriteLine("Дети:\n");
                foreach (var child in family.listChildren)
                {
                    print(child);
                }
            }
            Console.WriteLine(new String('=', 80));
        }

    }
}
