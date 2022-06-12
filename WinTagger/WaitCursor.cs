using System;
using System.Windows.Forms;

namespace WinTagger
{
  internal class WaitCursor : IDisposable
  {
    private Control _control = (Control) null;

    public WaitCursor(Control control)
    {
      this._control = control;
      this._control.Cursor = Cursors.WaitCursor;
      Application.DoEvents();
    }

    public void Dispose() => this._control.Cursor = Cursors.Default;
  }
}
