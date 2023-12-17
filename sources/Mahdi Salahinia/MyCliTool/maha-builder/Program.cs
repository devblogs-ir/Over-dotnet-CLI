using maha_builder;

var folderName = ArgumentSetting.ParseArgumentValue(args, "-n");

InputValidation(folderName);

CommandsSetting.WriteCommands(folderName);


static void InputValidation(string folderName)
{
    if (string.IsNullOrEmpty(folderName))
    {
        Console.WriteLine("Error: The -n argument is null or invalid");
        Console.WriteLine("Info: maha-builder -n \"YourName\"");
        return;
    }

    if (Directory.Exists(folderName))
    {
        Console.WriteLine($"The folder '{folderName}' is already exists");
        return;
    }
}