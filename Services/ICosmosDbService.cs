namespace Hike
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Hike.Models;

    public interface ICosmosDbService
    {
        Task AddHikeAsync(Trail trail); 
    }
}
