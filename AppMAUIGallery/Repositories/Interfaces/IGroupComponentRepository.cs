using AppMAUIGallery.Models;

namespace AppMAUIGallery.Repositories;

public interface IGroupComponentRepository
{
    List<GroupComponent> GetGroupComponents();
    List<Components> GetComponents();
}
