// VisualFilterCollection.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Filters {

    [IgnoreNamespace]
    [ScriptImport]
    public sealed class VisualFilterCollection {

        private VisualFilterCollection() {
        }

        [ScriptProperty]
        public int Length {
            get {
                return 0;
            }
        }

        [ScriptProperty]
        public VisualFilter this[int index] {
            get {
                return null;
            }
        }
    }
}
