namespace FamilyTree
{
    internal class Man : Human
    {
        public Man(string name, DateTime birthday, Human father = null, Human mother = null)
                   : base(name, birthday, father, mother)
        {
        }
    }
}
