using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Mtk.Smartconfig.RNMtkSmartconfig
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMtkSmartconfigModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMtkSmartconfigModule"/>.
        /// </summary>
        internal RNMtkSmartconfigModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMtkSmartconfig";
            }
        }
    }
}
