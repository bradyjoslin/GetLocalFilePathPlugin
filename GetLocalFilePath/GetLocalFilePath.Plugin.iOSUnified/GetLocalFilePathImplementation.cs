using GetLocalFilePath.Plugin.Abstractions;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif
using System;


namespace GetLocalFilePath.Plugin
{
  /// <summary>
  /// Implementation for GetLocalFilePath
  /// </summary>
  public class GetLocalFilePathImplementation : IGetLocalFilePath
  {
        public string GetLocalPath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library");

            if (!System.IO.Directory.Exists(libFolder))
            {
                System.IO.Directory.CreateDirectory(libFolder);
            }

            return System.IO.Path.Combine(libFolder, fileName);
        }
  }
}