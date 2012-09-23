// TextMetrics.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {

    [IgnoreNamespace]
    [ScriptImport]
    public sealed class TextMetrics {

        private TextMetrics() {
        }

        [ScriptProperty]
        public double Width {
            get {
                return 0f;
            }
        }
    }
}
