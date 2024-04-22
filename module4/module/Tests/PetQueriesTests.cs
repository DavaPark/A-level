using module.BusinessLogic;
using module.Model;
using NUnit.Framework;


namespace module.Tests
{

    [TestFixture]
    public class PetQueriesTests
    {
        [Test]
        public void GetOlderPetsInfo_ShouldReturnCorrectInfo()
        {
            IQueryable<Pet> pets = new List<Pet>
        {
            new Pet { Name = "Fluffy", Age = 4, Breed = new Breed { Name = "Labrador" }, Category = new Category { Name = "Dog" }, Location = new Location { Name = "Ukraine" } },
          
        }.AsQueryable();

            
            var olderPetsInfo = PetQueries.GetOlderPetsInfo(pets);

           
        }

      
    }
}
