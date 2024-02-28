using AuctionWebApp.Models;

namespace AuctionWebApp.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
