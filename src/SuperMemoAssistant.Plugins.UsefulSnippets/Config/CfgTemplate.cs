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
  public class Cfg : CfgBase<Cfg>, INotifyPropertyChangedEx
  {

    [Title("Plugin Name")]

    [Heading("By Jamesb | Experimental Learning")]

    [Heading("Features:")]
    [Text(@"- Feature1
- Feature2
- Feature3")]

    [Heading("Settings Section 1")]
    [Field(Name = "Setting 1")]
    public string Name { get; set; }

    [Field(Name = "Setting 2")]
    public int Age { get; set; }

    [Heading("Setting Section 2")]
    [Field(Name = "Setting 1")]
    public string Blah { get; set; }

    [Field(Name = "Setting 2")]
    public int Gah { get; set; }


    [JsonIgnore]
    public bool IsChanged { get; set; }

    public override string ToString()
    {
      return "";
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
