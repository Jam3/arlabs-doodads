//-----------------------------------------------------------------------
// <copyright file="DepthModeOverride.cs" company="Google LLC">
//
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace Google.XR.ARCoreExtensions
{
    /// <summary>
    /// Desired depth mode to override the setting in ARFoundation.
    /// </summary>
    public enum DepthModeOverride
    {
        /// <summary>
        /// Do not override the current DepthMode used by AR Foundation.
        /// </summary>
        DoNotOverride,

        /// <summary>
        /// On <a href="https://developers.google.com/ar/discover/supported-devices">ARCore
        /// supported devices</a> that also support the Depth API, provides a "raw", mostly
        /// unfiltered, depth image (<c>Frame.UpdateRawDepthTexture</c>) and depth confidence image
        /// (<c>Frame.UpdateRawDepthConfidenceTexture</c>).
        ///
        /// The raw depth image is sparse and does not provide valid depth for all pixel. Pixels
        /// without a valid depth estimate have a pixel value of 0.
        ///
        /// Raw depth data is also available when <c><see cref="Automatic"/></c> is selected,
        /// however <c>RawDepthOnly</c> has a lower runtime performance cost.
        ///
        /// Raw depth is intended to be used in cases that involve understanding of the geometry in
        /// the environment.
        /// </summary>
        RawDepthOnly,
    }
}
