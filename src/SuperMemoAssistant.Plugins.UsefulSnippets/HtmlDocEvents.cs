using mshtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperMemoAssistant.Plugins.UsefulSnippets
{

  /// <summary>
  /// A COM class for handling events in HTML in C# rather than JS.
  /// You can subscribe to the events like this:
  /// ((IHTMLElement2)element).attachEvent("onmouseover", mouseOver );
  /// You could call a normal C# event from here and subscribe to that if required.
  /// </summary>
  [ComVisible(true)]
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ExampleHtmlDocEvent
  {
    [DispId(0)]
    public void handler(IHTMLEventObj e)
    {
      // Code to execute when the event happens
    }
  }
}
