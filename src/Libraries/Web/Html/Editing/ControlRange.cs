// ControlRange.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using System.Html;

namespace System.Html.Editing {

    [IgnoreNamespace]
    [ScriptImport]
    public sealed class ControlRange : Range {

        private ControlRange() {
        }

        [ScriptProperty]
        public int Length {
            get {
                return 0;
            }
        }

        [ScriptProperty]
        public Element this[int index] {
            get {
                return null;
            }
        }

        public void Add(Element element) {
        }

        public void Add(Element element, int index) {
        }

        public void Remove(int index) {
        }
    }
}
