namespace FamilyTree
{
    internal abstract class Human
    {
        public readonly string name = string.Empty;
        public readonly DateTime birthday;
        public Human father = null;     //  Отец текущего экцемпляра класса
        public Human mother = null;     //  Мать текущего экземпляра класса
        
        public Human(   string name,
                        DateTime birthday,
                        Human father,
                        Human mother
                    )
        {
            this.name = name;

           // Проверка даты дня рождения. Исключаем день рождения из будущего.
            if (birthday <= DateTime.Now)
            {
                this.birthday = birthday;
            }
            else
            {
                Console.WriteLine($"Дата {birthday}, не верна! Присваивает текущую дату! ");
                this.birthday = DateTime.Now;
            }
            this.father = father;
            this.mother = mother;
        }
    }
}
