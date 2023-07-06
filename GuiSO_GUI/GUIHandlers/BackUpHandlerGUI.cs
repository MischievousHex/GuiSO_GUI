using GuiSO_GUI.Services;

namespace GuiSO_GUI.GUIHandlers;

public class BackUpHandlerGUI
{
    public static bool MakeBackUp(string userName)
    {
        if (!CampBackUpExiste())
            FileSystemService.MakeDirectory("C:\\CAMP_BACKUP");
        if (!FileSystemService.DirectoryExists($"C:\\CAMP_BACKUP\\{userName}"))
            FileSystemService.MakeDirectory($"C:\\CAMP_BACKUP\\{userName}");
        if (FileSystemService.DirectoryExists($"C:\\Users\\{userName}"))
        {
            FileSystemService.CopyDirectory($"C:\\Users\\{userName}", $"C:\\CAMP_BACKUP\\{userName}\\", true);
        }

        return FileSystemService.DirectoryExists($"C:\\CAMP_BACKUP\\{userName}");
    }

    private static bool CampBackUpExiste()
    {
        return FileSystemService.DirectoryExists("C:\\CAMP_BACKUP");
    }
}