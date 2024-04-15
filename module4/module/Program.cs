using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание нового питомца
        Pet newPet = CRUDMethods.CreatePet("Fluffy", 4, 1, 1);
        Console.WriteLine($"Created new pet: {newPet.Name}, Age: {newPet.Age}");

        // Получение списка питомцев
        var pets = CRUDMethods.GetPets();
        Console.WriteLine("All Pets:");
        foreach (var pet in pets)
        {
            Console.WriteLine($"Name: {pet.Name}, Age: {pet.Age}");
        }

        // Обновление возраста питомца
        CRUDMethods.UpdatePetAge(newPet.Id, 5);
        Console.WriteLine($"Updated age of pet with ID {newPet.Id}");

        // Удаление питомца
        CRUDMethods.DeletePet(newPet.Id);
        Console.WriteLine($"Deleted pet with ID {newPet.Id}");

        // Получение информации о питомцах старше 3 лет в Украине
        var olderPetsInfo = PetQueries.GetOlderPetsInfo(pets.AsQueryable());
        Console.WriteLine("Older Pets Info:");
        foreach (var info in olderPetsInfo)
        {
            Console.WriteLine($"Category: {info.CategoryName}, Breed: {info.BreedName}, Total: {info.Total}");
        }
    }
}