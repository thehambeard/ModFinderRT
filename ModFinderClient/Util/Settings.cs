namespace ModFinder.Util
{
  public class Settings
  {
    public string AutoRTPath { get; set; }
    public string RTPath { get; set; }

    private static Settings _Instance;
    public static Settings Load()
    {
      if (_Instance == null)
      {
        if (Main.TryReadFile("Settings.json", out var settingsRaw))
          _Instance = IOTool.FromString<Settings>(settingsRaw);
        else
          _Instance = new();
      }

      return _Instance;
    }

    public void Save()
    {
      IOTool.SafeRun(() =>
      {
        IOTool.Write(this, Main.AppPath("Settings.json"));
      });
    }
  }
}
