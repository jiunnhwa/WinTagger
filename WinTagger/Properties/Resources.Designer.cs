using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WinTagger.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (WinTagger.Properties.Resources.resourceMan == null)
          WinTagger.Properties.Resources.resourceMan = new ResourceManager("WinTagger.Properties.Resources", typeof (WinTagger.Properties.Resources).Assembly);
        return WinTagger.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => WinTagger.Properties.Resources.resourceCulture;
      set => WinTagger.Properties.Resources.resourceCulture = value;
    }
  }
}
