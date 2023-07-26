using Microsoft.AspNetCore.Mvc;

namespace AppContainer.Models
{
    public class AppContainerModel
    {
        public string? Image { get; set; }
        public string? AppController { get; set; }
        public string? AppAction { get; set; }
    }
}
