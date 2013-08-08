using System.ComponentModel;

namespace SampleProject.Module.Infrastructure
{
    public interface IModelNavigationItemSeparator
    {
        [Category("Appearance")]
        bool BeginGroup { get; set; }
    }

}
