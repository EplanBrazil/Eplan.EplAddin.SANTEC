using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.DataModel;
using Eplan.EplApi.Gui;

namespace Eplan.EplAddin.DatabaseSync
{
    public class AddInModule : IEplAddIn
    {
        public bool OnRegister(ref bool bLoadOnStart)
        {
            bLoadOnStart = true;

            using (var faixaSuperior = new RibbonBar())
            {
                using (RibbonTab home = faixaSuperior.GetDefaultTab(RibbonTab.DefaultRibbonTabs.Start))
                {
                    using (var newGroup = home.AddCommandGroup(Empty.Properties.Resources.FormGroup))
                    {
                        var novoComando = newGroup.AddCommand("Abrir", "Action");
                    }
                }

            }

            return true;
        }

        public bool OnUnregister()
        {
            using (var faixaSuperior = new RibbonBar())
            {
                using (var home = faixaSuperior.GetDefaultTab(RibbonTab.DefaultRibbonTabs.Start))
                {
                    using (var groupActions = home.GetCommandGroup(Empty.Properties.Resources.FormGroup))
                    {
                        groupActions?.Remove();
                    }
                    using (var groupActions = home.GetCommandGroup("Formulário"))
                    {
                        groupActions?.Remove();
                    }
                    using (var groupActions = home.GetCommandGroup("Test"))
                    {
                        groupActions?.Remove();
                    }
                }
                return true;
            }
        }

        public bool OnInit()
        {
            return true;
        }

        public bool OnInitGui()
        {
            return true;
        }

        public bool OnExit()
        {
            return true;
        }
    }
}