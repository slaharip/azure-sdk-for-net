// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The parameters Azure uses to set debug settings for console output.
    /// </summary>
    public partial class DebugSettings
    {
        private bool _bootDiagnosticsEnabled;
        
        /// <summary>
        /// Required. Enable or disable boot diagnostics.
        /// </summary>
        public bool BootDiagnosticsEnabled
        {
            get { return this._bootDiagnosticsEnabled; }
            set { this._bootDiagnosticsEnabled = value; }
        }
        
        private Uri _consoleScreenshotBlobUri;
        
        /// <summary>
        /// Optional. Blob uri for console screen shot.
        /// </summary>
        public Uri ConsoleScreenshotBlobUri
        {
            get { return this._consoleScreenshotBlobUri; }
            set { this._consoleScreenshotBlobUri = value; }
        }
        
        private Uri _serialOutputBlobUri;
        
        /// <summary>
        /// Optional. Blob uri for serial output.
        /// </summary>
        public Uri SerialOutputBlobUri
        {
            get { return this._serialOutputBlobUri; }
            set { this._serialOutputBlobUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DebugSettings class.
        /// </summary>
        public DebugSettings()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DebugSettings class with required
        /// arguments.
        /// </summary>
        public DebugSettings(bool bootDiagnosticsEnabled)
            : this()
        {
            this.BootDiagnosticsEnabled = bootDiagnosticsEnabled;
        }
    }
}
