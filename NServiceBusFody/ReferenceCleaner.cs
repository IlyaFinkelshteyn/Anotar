using System.Linq;

public partial class ModuleWeaver
{
    
    public void RemoveReference()
    {
        var referenceToRemove = ModuleDefinition.AssemblyReferences.FirstOrDefault(x => x.Name == "Anotar.NServiceBus");
        if (referenceToRemove == null)
        {
            LogInfo("\tNo reference to 'Anotar.NServiceBus.dll' found. References not modified.");
            return;
        }

        ModuleDefinition.AssemblyReferences.Remove(referenceToRemove);
        LogInfo("\tRemoving reference to 'Anotar.NServiceBus.dll'.");
    }
}