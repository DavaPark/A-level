using module.DAL;
using module.Model;

namespace module.BusinessLogic
{
    public class CRUDMethods
    {
        public static Pet CreatePet(string name, int age, int breedId, int locationId, PetRepository petRepository)
        {
            return petRepository.CreatePet(name, age, breedId, locationId);
        }

        internal static object CreatePet(string name, int age, int breedId, int locationId)
        {
            throw new NotImplementedException();
        }

        internal static void DeletePet(object id)
        {
            throw new NotImplementedException();
        }

        internal static object GetPetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
