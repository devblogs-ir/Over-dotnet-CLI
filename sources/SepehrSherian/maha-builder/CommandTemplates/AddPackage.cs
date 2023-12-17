using System.Text;

namespace CommandTempaltes;

public static class AddPackage
{
  public static string Add(string packageName)
    {
        if (!string.IsNullOrEmpty(packageName))
        {
            var command = new StringBuilder();
            command.Append($"dotnet add package {packageName}");
            return command.ToString();
        }
        else return "error";
    }

}
