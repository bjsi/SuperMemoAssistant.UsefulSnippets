using Forge.Forms.Annotations;
using Newtonsoft.Json;
using SuperMemoAssistant.Services.UI.Configuration;
using SuperMemoAssistant.Sys.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMemoAssistant.Plugins.UsefulSnippets.Config
{
  [Form(Mode = DefaultFields.None)]
  [Title("Dictionary Settings",
   IsVisible = "{Env DialogHostContext}")]
  [DialogAction("cancel",
          "Cancel",
          IsCancel = true)]
  [DialogAction("save",
          "Save",
          IsDefault = true,
          Validates = true)]
  public class CfgTemplate : CfgBase<CfgTemplate>, INotifyPropertyChangedEx
  {

    /// <summary>
    /// Look at Forge.Forms documentation / other plugins to understand the field syntax
    /// </summary>
    /// Eg:

    [Field(Name = "Username")]
    public string Username { get; set; }


    [JsonIgnore]
    public bool IsChanged { get; set; }

    public override string ToString()
    {
      // Human-readable Plugin name
      return "Useful Snippets";
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
