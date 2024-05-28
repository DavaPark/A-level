using module.Model;

namespace module.BusinessLogic
{
    public class PetQueries
    {
        public static IQueryable<PetInfo> GetOlderPetsInfo(IQueryable<Pet> pets)
        {
            var olderPets = pets.Where(p => p.Age > 3 && p.Location.Name == "Ukraine")
                                .GroupBy(p => new NewClass(p.Category.Name, p.Breed.Name))
                                .Select(g => new PetInfo
                                {
                                    CategoryName = g.Key.Name,
                                    BreedName = g.Key.Name,
                                    Total = g.Count()
                                });
            return olderPets;
        }
    }

    internal class NewClass
    {
        public string Name { get; }
        public object Item { get; }

        public NewClass(string name, object item)
        {
            Name = name;
            Item = item;
        }

        public override bool Equals(object? obj)
        {
            return obj is NewClass other &&
                   Name == other.Name &&
                   EqualityComparer<object>.Default.Equals(Item, other.Item);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Item);
        }
    }
}
