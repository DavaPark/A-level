using module.BusinessLogic;
using module.Model;
using NUnit.Framework;


[TestClass]
public class CRUDMethodsTests
{
    [TestMethod]
    public void CreatePet_ShouldCreateNewPet()
    {
        // Arrange
        string name = "Fluffy";
        int age = 5;
        int breedId = 1;
        int locationId = 1;

        // Act
        Pet newPet;
        try
        {
            newPet = CRUDMethods.CreatePet(name, age, breedId, locationId);
        }
        catch (Exception ex)
        {
            // Assert
            Assert.Fail($"Failed to create new pet: {ex.Message}");
            return;
        }

        // Assert
        Assert.IsNotNull(newPet);
        Assert.AreEqual(name, newPet.Name);
        Assert.AreEqual(age, newPet.Age);
    }

    // Другие тесты для методов CRUD

    [TestMethod]
    public void DeletePet_ShouldDeletePet()
    {
        // Arrange
        string name = "ToDelete";
        int age = 3;
        int breedId = 2;
        int locationId = 3;
        var newPet = CRUDMethods.CreatePet(name, age, breedId, locationId);

        // Act
        CRUDMethods.DeletePet(newPet.Id);

        // Assert
        // Проверяем, что питомец удалён, например, путём попытки его получения из базы данных
        try
        {
            var deletedPet = CRUDMethods.GetPetById(newPet.Id);
            Assert.IsNull(deletedPet);
        }
        catch (Exception ex)
        {
            Assert.Fail($"Failed to delete pet: {ex.Message}");
        }
    }
}