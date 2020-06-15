using SuperMemoAssistant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMemoAssistant.Plugins.UsefulSnippets.Config
{
  public static class ConfigHelpers
  {

    /// <summary>
    /// Get a reference to the Config when you are in a class other than the main Plugin class.
    /// </summary>
    /// <returns></returns>
    public static object GetConfig()
    {
      return Svc<UsefulSnippetsPlugin>.Plugin.Config;
    }


  }
}
