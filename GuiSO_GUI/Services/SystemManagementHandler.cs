using System.Reflection;
using GuiSO_GUI.Model;

namespace GuiSO_GUI.Services;
using System.Management;
using System.Diagnostics;
using System.Linq;

public class SystemManagementHandler
{

    public List<UsuarioModel> QueryUsuarios()
    {
        ManagementObjectSearcher usersSearcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_UserAccount");
        ManagementObjectCollection users = usersSearcher.Get();

        List<UsuarioModel> usuarios = new();
        
        var localUsers = users.Cast<ManagementObject>().Where(
            u => (bool)u["LocalAccount"] == true &&
                 (bool)u["Disabled"] == false &&
                 (bool)u["Lockout"] == false &&
                 int.Parse(u["SIDType"].ToString()) == 1 &&
                 u["Name"].ToString() != "HomeGroupUser$");
        foreach (var userObject in users)
        {
            PropertyInfo[] aa = userObject.GetType().GetProperties();
            string nombre = userObject["Name"].ToString();
            //string ultimoAcceso = userObject["lastlogin"].ToString();
            UsuarioModel usuario = new UsuarioModel(nombre, false, new []{"Grupo1"}, "ultimoAcceso");
            usuarios.Add(usuario);
        }

        return usuarios;
    }

    public List<ProcesoModel> QueryProcesos()
    {
        Process[] processlist = Process.GetProcesses();
        List<ProcesoModel> procesoModels = new();
        
        foreach(Process process in processlist)
        {
            procesoModels.Add(new ProcesoModel(process));
        }

        return procesoModels.Where(procesoM => !procesoM.IsDead).ToList();
    }
    
}