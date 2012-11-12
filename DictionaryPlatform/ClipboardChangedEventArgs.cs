using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryPlatform
{

    public class ClipboardChangedEventArgs : EventArgs
    {
        public readonly string ClipboardContent;

        public ClipboardChangedEventArgs(string dataObject)
        {
            ClipboardContent = dataObject;
        }

        private ClipboardChangedEventArgs()
        {

        }

    }
}

