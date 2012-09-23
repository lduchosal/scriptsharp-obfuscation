// MapEventArgs.cs
// Script#/Libraries/Microsoft/BingMaps
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    // TODO: Make properties

    [ScriptImport]
    [IgnoreNamespace]
    public class MapEventArgs : EventArgs {

        internal MapEventArgs() {
        }

        public string EventName;
        public ElementEvent OriginalEvent;
    }
}
