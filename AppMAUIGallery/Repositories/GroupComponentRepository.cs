using AppMAUIGallery.Models;

namespace AppMAUIGallery.Repositories;

public partial class GroupComponentRepository : IGroupComponentRepository
{
    private List<GroupComponent> _groups;
    private List<Components> _components;

    public GroupComponentRepository()
    {
        LoadData();
    }

    public List<Components> GetComponents() 
        => _components;

    public List<GroupComponent> GetGroupComponents() 
        => _groups;
}
