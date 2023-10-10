namespace FamilyTree
{
    internal class Woman : Human
    {
        public Woman(string name, DateTime birthday, Human father = null, Human mother = null)
                   : base(name, birthday, father, mother)
        {
        }
    }
}
