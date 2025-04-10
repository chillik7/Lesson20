using WatchlistApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace WatchlistApp.Services
{
    public class WatchlistService : IWatchlistService
    {
        private readonly List<WatchlistItemViewModel> _items = new();

        public void AddItem(WatchlistItemViewModel item)
        {
            _items.Add(item);
        }

        public void RemoveItem(string title)
        {
            var item = _items.FirstOrDefault(i => i.Title == title);
            if (item != null)
                _items.Remove(item);
        }

        public List<WatchlistItemViewModel> GetAll()
        {
            return _items;
        }
    }
}
