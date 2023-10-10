using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Lists.Utils;

public class MovieTemplateSelector : DataTemplateSelector
{
    public DataTemplate TemplateDefault { get; set; }
    public DataTemplate TemplateTooLongMovie { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container) 
        => ((Movie)item).Duration.Hours > 1 ? TemplateTooLongMovie : TemplateDefault;
}
