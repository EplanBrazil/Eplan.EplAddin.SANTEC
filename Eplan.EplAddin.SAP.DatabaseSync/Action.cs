using Eplan.EplAddin.Santec;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.DataModel;
using Eplan.EplApi.DataModel.E3D;
using Eplan.EplApi.HEServices;
using System;

namespace Eplan.EplAddin.Empty
{
	public class Action : IEplAction
    {
        public bool Execute(ActionCallingContext ctx)
        {
            new PartsManagementForm().ShowDialog();

            return true;
        }

        private void CreateInstallationSpaceWithComponents(Project project, int layoutIndex, int layoutCount, int compntCount)
        {
            using (var oInstallationSpace = new InstallationSpace())
            {
                oInstallationSpace.Create(project, $"{layoutIndex + 1}/{layoutCount}");

                for (int j = 0; j < compntCount; j++)
                {
                    CreateComponent(project, oInstallationSpace, j, compntCount);
                }
            }
        }

        private void CreateComponent(Project project, InstallationSpace installationSpace, int layoutIndex, int compntCount)
        {
            using (var oTerminal = new Component())
            {
                oTerminal.Create(project, "PXC.3022276", "1");
                oTerminal.Parent = installationSpace;
                oTerminal.VisibleName = $"teste {layoutIndex}/{compntCount}";
                oTerminal.Name = $"teste {layoutIndex}/{compntCount}";
            }
        }

        public bool OnRegister(ref string Name, ref int Ordinal)
        {
            Name = "Action";
            Ordinal = 20;
            return true;
        }

        public void GetActionProperties(ref ActionProperties actionProperties)
        {
        }
    }
}