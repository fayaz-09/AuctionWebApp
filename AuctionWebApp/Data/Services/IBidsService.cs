using AuctionWebApp.Models;

namespace AuctionWebApp.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
