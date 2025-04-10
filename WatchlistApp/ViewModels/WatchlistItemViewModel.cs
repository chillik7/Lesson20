using System.ComponentModel.DataAnnotations;

namespace WatchlistApp.ViewModels
{
    public class WatchlistItemViewModel
    {
        [Required(ErrorMessage = "Название обязательно")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Жанр обязателен")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Тип обязателен")]
        [Display(Name = "Тип (Фильм/Сериал)")]
        public string Type { get; set; } 
    }
}
