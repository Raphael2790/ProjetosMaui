namespace AppMAUIGallery.Models;

public class GroupComponent : List<Components>
{
    public GroupComponent(string name, IEnumerable<Components> components) : base(components)
    {
        Name = name;
    }

    public string Name { get; set; }
}
