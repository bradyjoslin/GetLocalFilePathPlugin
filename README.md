# GetLocalFilePathPlugin
Xamarin plugin which gets the local path location for a database file on Android and iOS.

This plugin abstracts the platform specific ways in which you derive the local filepath to store data on the phone.

Used [James Montemagno's VS Template](https://visualstudiogallery.msdn.microsoft.com/afead421-3fbf-489a-a4e8-4a244ecdbb1e) which is a great time saver.  Platform specific code was provided in Xamarin Univerty course Working with SQLite and Mobile Data [XAM160].

Sample usage:

<pre><code>
Console.WriteLine (CrossGetLocalFilePath.Current.GetLocalPath("mydb.db3"));
</code></pre>
