using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Animations;
using AppMAUIGallery.Views.Cells;
using AppMAUIGallery.Views.CommunityMaui;
using AppMAUIGallery.Views.Componentes.Forms;
using AppMAUIGallery.Views.Componentes.Mains;
using AppMAUIGallery.Views.Componentes.Visuals;
using AppMAUIGallery.Views.Layouts;
using AppMAUIGallery.Views.Lists;
using AppMAUIGallery.Views.Styles;
using AppMAUIGallery.Views.Utils;

namespace AppMAUIGallery.Repositories;

public partial class GroupComponentRepository : IGroupComponentRepository
{
    private void LoadData()
    {
        _groups = new List<GroupComponent>();
        _components = new List<Components>();

        LoadLayout();
        LoadComponents();
        LoadVisuals();
        LoadForms();
        LoadCells();
        LoadCollections();
        LoadStyles();
        LoadAnimations();
        LoadUtils();
        LoadCommunity();
    }

    private void LoadCommunity()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "Snack Bar e Toast",
                Description = "Show alerts to user",
                Page = typeof(AlertsPage)
            },
            new Components
            {
                Title = "Community Toolkit Behaviors",
                Description = "Add behaviors to components",
                Page = typeof(CommunityBehaviorsPage)
            }
        };

        _groups.Add(new GroupComponent("Community", components));
        _components.AddRange(components);
    }

    private void LoadUtils()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "Behaviors",
                Description = "Add behaviors to components",
                Page = typeof(BehaviorsPage)
            },
            new Components
            {
                Title = "Triggers",
                Description = "Add triggers to components",
                Page = typeof(TriggerPage)
            },
            new Components
            {
                Title = "Platform/Idiom",
                Description = "Add platform/idiom to components",
                Page = typeof(PlatformIdiomPage)
            },
            new Components
            {
                Title = "Fontes",
                Description = "Add fonts to components",
                Page = typeof(FontPage)
            },
            new Components
            {
                Title = "Colors",
                Description = "Add colors to components",
                Page = typeof(ColorPage)
            }
        };

        _groups.Add(new GroupComponent("Utils", components));
        _components.AddRange(components);
    }

    private void LoadLayout()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "StackLayout",
                Description = "The StackLayout is used to arrange views in a single line which can be oriented vertically or horizontally.",
                Page = typeof(StackLayoutPage)
            },
            new Components
            {
                Title = "Grid",
                Description = "The Grid is used to arrange views in rows and columns.",
                Page = typeof(GridLayoutPage)
            },
            new Components
            {
                Title = "AbsoluteLayout",
                Description = "The AbsoluteLayout is used to position and size views in a layout using absolute values or proportional values.",
                Page = typeof(AbsoluteLayoutPage)
            },
        };

        _groups.Add(new GroupComponent("Layouts", components));
        _components.AddRange(components);   
    }

    private void LoadComponents()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "BoxView",
                Description = "The BoxView is a simple view that is useful for rendering a solid color as its background.",
                Page = typeof(BoxViewPage)
            },
            new Components
            {
                Title = "Label",
                Description = "The Label is used to present text on the screen.",
                Page = typeof(LabelPage)
            },
            new Components
            {
                Title = "Button",
                Description = "The Button is a basic button control that responds to touch.",
                Page = typeof(ButtonPage)
            },
            new Components
            {
                Title = "Image",
                Description = "The Image control displays a non-interactive image to the user.",
                Page = typeof(ImagePage)
            },
            new Components
            {
                Title = "ImageButton",
                Description = "The ImageButton is a button control that displays an image and has a customized appearance.",
                Page = typeof(ImageButtonPage)
            }
        };

        _groups.Add(new GroupComponent("Componentes (Views)", components));
        _components.AddRange(components);
    }

    private void LoadVisuals()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "Frame",
                Description = "The Frame is a layout control that allows you to add a border around a view.",
                Page = typeof(FramePage)
            },
            new Components
            {
                Title = "Border",
                Description = "The Border is a layout control that allows you to add a border around a view.",
                Page = typeof(BorderPage)
            },
            new Components
            {
                Title = "Shadow",
                Description = "The Shadow is a layout control that allows you to add a shadow around a view.",
                Page = typeof(ShadowPage)
            }
        };

        _groups.Add(new GroupComponent("Visuais", components));
        _components.AddRange(components);
    }

    private void LoadForms()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "Entry",
                Description = "The Entry is used for single-line text input.",
                Page = typeof(EntryPage)
            },
            new Components
            {
                Title = "Editor",
                Description = "The Editor is used for multi-line text input.",
                Page = typeof(EditorPage)
            },
            new Components
            {
                Title = "CheckBox",
                Description = "The CheckBox is a button that can be checked or unchecked.",
                Page = typeof(CheckBoxPage)
            },
            new Components
            {
                Title = "RadioButton",
                Description = "The RadioButton is a button that can be checked or unchecked.",
                Page = typeof(RadioButtonPage)
            },
            new Components
            {
                Title = "Switch",
                Description = "The Switch is a button that can be checked or unchecked.",
                Page = typeof(SwitchPage)
            },
            new Components
            {
                Title = "Stepper",
                Description = "The Stepper is a control that allows you to increase or decrease a value in a small amount.",
                Page = typeof(StepperPage)
            },
            new Components
            {
                Title = "Slider",
                Description = "The Slider is a control that allows you to select from a range of values by moving a Thumb control along a track.",
                Page = typeof(SliderPage)
            },
            new Components
            {
                Title = "TimePicker",
                Description = "The TimePicker is a control that allows you to pick a time value.",
                Page = typeof(TimePickerPage)
            },
            new Components
            {
                Title = "DatePicker",
                Description = "The DatePicker is a control that allows you to pick a date value.",
                Page = typeof(DatePickerPage)
            },
            new Components
            {
                Title = "SearchBar",
                Description = "The SearchBar is a control that allows you to search for a text value.",
                Page = typeof(SearchBarPage)
            },
            new Components
            {
                Title = "Picker",
                Description = "The Picker is a control that allows you to pick an item among a list of items.",
                Page = typeof(PickerPage)
            }
        };

        _groups.Add(new GroupComponent("Formulários", components));
        _components.AddRange(components);
    }

    private void LoadCells()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "TextCell",
                Description = "The TextCell is a cell that displays text.",
                Page = typeof(TextCellPage)
            },
            new Components
            {
                Title = "ImageCell",
                Description = "The ImageCell is a cell that displays an image.",
                Page = typeof(ImageCellPage)
            },
            new Components
            {
                Title = "SwitchCell",
                Description = "The SwitchCell is a cell that displays a switch.",
                Page = typeof(SwitchCellPage)
            },
            new Components
            {
                Title = "EntryCell",
                Description = "The EntryCell is a cell that displays an entry.",
                Page = typeof(EntryCellPage)
            },
            new Components
            {
                Title = "ViewCell",
                Description = "The ViewCell is a cell that displays a view.",
                Page = typeof(ViewCellPage)
            }
        };

        _groups.Add(new GroupComponent("Células", components));
        _components.AddRange(components);
    }

    private void LoadCollections()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "TableView",
                Description = "The TableView is a view for displaying scrollable lists of data or choices where there are rows that don't share the same template.",
                Page = typeof(TableViewPage)
            },
            new Components
            {
                Title = "PickerList",
                Description = "The PickerList is a view for displaying scrollable lists of data or choices where there are rows that don't share the same template.",
                Page = typeof(PickerListPage)
            },
            new Components
            {
                Title = "CollectionView",
                Description = "The CollectionView is a view for displaying scrollable lists of data or choices where there are rows that don't share the same template.",
                Page = typeof(CollectionViewPage)
            },
            new Components
            {
                Title = "CarouselView",
                Description = "The CarouselView is a view for displaying scrollable lists of data or choices where there are rows that don't share the same template.",
                Page = typeof(CarouselViewPage)
            },
            new Components
            {
                Title = "BindableLayout (Atributo)",
                Description = "The BindableLayout is a view for displaying scrollable lists of data or choices where there are rows that don't share the same template.",
                Page = typeof(BindableLayoutPage)
            },
            new Components
            {
                Title = "DataTemplateSelector",
                Description = "The DataTemplateSelector is a view for displaying scrollable lists of data or choices where there are rows that don't share the same template.",
                Page = typeof(DataTemplateSelectorPage)
            }
        };

        _groups.Add(new GroupComponent("Coleções", components));
        _components.AddRange(components);
    }

    private void LoadStyles()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "Implicit & Explicit Styles",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(ImplicitExplicitStyles)
            },
            new Components
            {
                Title = "Global Styles",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(GlobalStyles)
            },
            new Components
            {
                Title = "Derived Types Styles",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(ApplyDerivedTypes)
            },
            new Components
            {
                Title = "Inheritance Styles",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(InheritanceStyle)
            },
            new Components
            {
                Title = "Style Classes",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(StyleClassPage)
            },
            new Components
            {
                Title = "Dynamic Styles",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(StaticDynamicResource)
            },
            new Components
            {
                Title = "Theme Styles",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(Theme)
            },
            new Components
            {
                Title = "App Theme Binding",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(AppThemeBindingPage)
            },
            new Components
            {
                Title = "Visual State Manager",
                Description = "Explicar funcionamento de estilos",
                Page = typeof(VisualStateManagerPage)
            }
        };

        _groups.Add(new GroupComponent("Styles", components));
        _components.AddRange(components);
    }

    private void LoadAnimations()
    {
        var components = new List<Components>
        {
            new Components
            {
                Title = "Basic Animation",
                Description = "Animações básicas em .net Maui",
                Page = typeof(BasicAnimations)
            }
        };

        _groups.Add(new GroupComponent("Animation", components));
        _components.AddRange(components);
    }
}
