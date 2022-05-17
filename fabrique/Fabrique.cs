using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.dao.ado.net;

namespace WindowsFormsGestionCommandes.fabrique
{
    class Fabrique
    {
        public static IService getInstanceService()
        {
            return new Service()
            {
                Context = new MasterEntities(),
            };
        }
    }
}
