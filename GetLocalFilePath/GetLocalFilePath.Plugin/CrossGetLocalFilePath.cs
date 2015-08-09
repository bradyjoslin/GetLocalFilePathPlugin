using GetLocalFilePath.Plugin.Abstractions;
using System;

namespace GetLocalFilePath.Plugin
{
  /// <summary>
  /// Cross platform GetLocalFilePath implemenations
  /// </summary>
  public class CrossGetLocalFilePath
  {
    static Lazy<IGetLocalFilePath> Implementation = new Lazy<IGetLocalFilePath>(() => CreateGetLocalFilePath(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static IGetLocalFilePath Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static IGetLocalFilePath CreateGetLocalFilePath()
    {
#if PORTABLE
        return null;
#else
        return new GetLocalFilePathImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
