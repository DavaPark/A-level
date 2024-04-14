
using System.Collections.Generic;

namespace Rest.Models;

public class CollectionData<T> : Validation
{
    public IReadOnlyCollection<T>? Data { get; init; }
}