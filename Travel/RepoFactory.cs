using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class RepoFactory
    {
        public static IRepository GetRepo(string repo)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var repoType = assembly.GetTypes().FirstOrDefault(t => t.Name == repo);
            Logging.Instance.Log("Returning instance of called class");
            return (IRepository)Activator.CreateInstance(repoType);
        }
    }
}
