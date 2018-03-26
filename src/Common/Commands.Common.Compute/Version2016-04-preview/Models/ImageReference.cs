// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies information about the image to use. You can specify
    /// information about platform images, marketplace images, or virtual
    /// machine images. This element is required when you want to use a
    /// platform image, marketplace image, or virtual machine image, but is not
    /// used in other creation operations.
    /// </summary>
    public partial class ImageReference : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="publisher">The image publisher.</param>
        /// <param name="offer">Specifies the offer of the platform image or
        /// marketplace image used to create the virtual machine.</param>
        /// <param name="sku">The image SKU.</param>
        /// <param name="version">Specifies the version of the platform image
        /// or marketplace image used to create the virtual machine. The
        /// allowed formats are Major.Minor.Build or 'latest'. Major, Minor,
        /// and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use
        /// 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.</param>
        public ImageReference(string id = default(string), string publisher = default(string), string offer = default(string), string sku = default(string), string version = default(string))
            : base(id)
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the image publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets specifies the offer of the platform image or
        /// marketplace image used to create the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the image SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets specifies the version of the platform image or
        /// marketplace image used to create the virtual machine. The allowed
        /// formats are Major.Minor.Build or 'latest'. Major, Minor, and Build
        /// are decimal numbers. Specify 'latest' to use the latest version of
        /// an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new
        /// version becomes available.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
