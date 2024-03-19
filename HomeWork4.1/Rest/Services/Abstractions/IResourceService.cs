using Rest.Models;

namespace Rest.Services.Abstractions;
public interface IResourceService
{
    Task<Resource> GetResource(int id);
    Task<CollectionData<Resource>> GetResources();
}