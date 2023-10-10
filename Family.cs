namespace FamilyTree
{
    internal class Family
    {
        public Man father               = null;     //  Отец семейства
        public Woman mother             = null;     //  Мать скмейства
        public List<Human> listChildren = null;     //  Совместные дети


        public Family(Man father = null, Woman mother = null, params Human[] children)
        {
            this.father = father;
            this.mother = mother;

            List<Human> listChildren = new List<Human>(children);

            // Тут нужно определить - является ли ребенок совместным:
            if (listChildren != null && listChildren.Count != 0)
            {
                Console.WriteLine("Проверяем детей на то, являются ли они совместными детьми:\n");
      
                for(int i = 0; i < listChildren.Count; i++)
                {
                    // Если отец и мать текущего ребёнка совпадают,
                    // тогда ребёнок считается совместным и добавляется в массив.
                    if (listChildren[i].father == father && listChildren[i].mother == mother)
                    {
                        Console.WriteLine($"{listChildren[i].name} является ребёнком отца: {father.name} и матери {mother.name} !");
                    }
                    else
                    {
                        // Тут мы удаляем детей, которые не попадают в категорию - совместные дети
                        Console.WriteLine($"{listChildren[i].name} Не является ребёнком отца: {father.name} и матери {mother.name} !");
                        Console.WriteLine($"{listChildren[i].name} будет удален из фамильного дерева !");
                        listChildren.Remove(listChildren[i]);
                    }
                }

                this.listChildren = listChildren;
            }
        }
    }
}
