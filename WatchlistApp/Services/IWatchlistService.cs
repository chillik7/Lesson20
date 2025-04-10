using WatchlistApp.ViewModels;
using System.Collections.Generic;

namespace WatchlistApp.Services
{
    public interface IWatchlistService
    {
        void AddItem(WatchlistItemViewModel item);
        void RemoveItem(string title);
        List<WatchlistItemViewModel> GetAll();
    }
}
