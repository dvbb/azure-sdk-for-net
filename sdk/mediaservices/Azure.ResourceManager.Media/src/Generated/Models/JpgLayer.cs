// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the settings to produce a JPEG image from the input video. </summary>
    public partial class JpgLayer : MediaLayerBase
    {
        /// <summary> Initializes a new instance of <see cref="JpgLayer"/>. </summary>
        public JpgLayer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JpgLayer"/>. </summary>
        /// <param name="width"> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </param>
        /// <param name="height"> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </param>
        /// <param name="label"> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </param>
        /// <param name="quality"> The compression quality of the JPEG output. Range is from 0-100 and the default is 70. </param>
        internal JpgLayer(string width, string height, string label, int? quality) : base(width, height, label)
        {
            Quality = quality;
        }

        /// <summary> The compression quality of the JPEG output. Range is from 0-100 and the default is 70. </summary>
        public int? Quality { get; set; }
    }
}
