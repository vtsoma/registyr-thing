using Microsoft.Win32;

RegistryKey Root =  Registry.ClassesRoot;
List<string> matches = new List<string>{};

foreach (string subkeyName in Root.GetSubKeyNames())
{
    if (subkeyName.Substring(0, 1).Equals("."))
    {
        matches.Add(subkeyName);
    }
}

foreach (string subkeyName in matches)
{
    Console.WriteLine(subkeyName);
}