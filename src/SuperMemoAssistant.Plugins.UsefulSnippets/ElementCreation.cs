using Anotar.Serilog;
using SuperMemoAssistant.Interop.SuperMemo.Content.Contents;
using SuperMemoAssistant.Interop.SuperMemo.Elements.Builders;
using SuperMemoAssistant.Interop.SuperMemo.Elements.Models;
using SuperMemoAssistant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMemoAssistant.Plugins.UsefulSnippets
{
  public static class ElementCreation
  {
    public static void CreateArticleElement(string Title, string Author, double priority = -1)
    {
      bool ret = false;
      var contents = new List<ContentBase>();
      contents.Add(new TextContent(true, string.Empty));
      var currentElement = Svc.SM.UI.ElementWdw.CurrentElement;

      if (currentElement == null)
      {
        LogTo.Error("Failed to CreateSMElement beacuse element was null");
        return;
      }

      if (priority < 0 || priority > 100)
      {
        priority = 30;
      }

      ret = Svc.SM.Registry.Element.Add(
        out var value,
        ElemCreationFlags.ForceCreate,
        new ElementBuilder(ElementType.Topic, contents.ToArray())
          .WithParent(currentElement)
          .WithLayout("")
          .WithPriority(priority)
          .WithTitle(Title)
          .WithReference(r => r.WithAuthor(Author)
                               .WithTitle(Title))
          .DoNotDisplay()
      );

      if (ret)
      {
        LogTo.Debug("Successfully created SM Element");
      }
      else
      {
        LogTo.Error("Failed to CreateSMElement");
      }
    }
  }
}
