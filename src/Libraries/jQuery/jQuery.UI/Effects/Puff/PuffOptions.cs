// PuffOptions.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Options used to initialize or customize Puff.
    /// </summary>
    [ScriptImport]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class PuffOptions {

        public PuffOptions() {
        }

        public PuffOptions(params object[] nameValuePairs) {
        }

        /// <summary>
        /// A callback function, executed when the effect completes
        /// </summary>
        [ScriptProperty]
        public Action Complete {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// The number of ms the animation will run for
        /// </summary>
        [ScriptProperty]
        public int Duration {
            get {
                return 0;
            }
            set {
            }
        }

        /// <summary>
        /// The easing function to use
        /// </summary>
        [ScriptProperty]
        public string Easing {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// The mode of the effect. Can be "show" or "hide"
        /// </summary>
        [ScriptProperty]
        public string Mode {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// The percentage to scale to.
        /// </summary>
        [ScriptProperty]
        public int Percent {
            get {
                return 0;
            }
            set {
            }
        }
    }
}
