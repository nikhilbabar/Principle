using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Common.Factories
{
    public static class ServiceObjectFactory
    {
        #region Declaration(s)
        #endregion

        #region Constructor(s)
        #endregion

        #region Method(s)
        public static object GetObject(string name)
        {
            //Type type = Type.GetType(name);
            //return Activator.CreateInstance(type);

            Type type = Type.GetType(name);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = assembly.GetType(name);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }
        #endregion

        #region Function(s)
        #endregion
    }

}
