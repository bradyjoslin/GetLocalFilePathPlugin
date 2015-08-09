using GetLocalFilePath.Plugin.Abstractions;
using System;


namespace GetLocalFilePath.Plugin
{
  /// <summary>
  /// Implementation for Feature
  /// </summary>
  public class GetLocalFilePathImplementation : IGetLocalFilePath
    {
        public string GetLocalPath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, fileName);
        }
    }
}