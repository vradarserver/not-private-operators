using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    class WaitCursor : IDisposable
    {
        private Cursor _CurrentCursor;

        public WaitCursor()
        {
            _CurrentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        ~WaitCursor()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing) {
                Cursor.Current = _CurrentCursor;
            }
        }
    }
}
