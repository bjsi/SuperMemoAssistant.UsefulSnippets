using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Forge.Forms;

namespace SuperMemoAssistant.Plugins.UsefulSnippets
{
  /// <summary>
  /// Uses the Forge.Forms library to create simple 
  /// </summary>
  public static class PopupHelpers
  {

    /// <summary>
    /// Show an alert window.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="title"></param>
    public static void ShowAlertWdw(string message, string title)
    {
      Application.Current.Dispatcher.Invoke(() =>
      {
        Show.Window().For(new Alert(message, title));
      });
    }
  }
}
