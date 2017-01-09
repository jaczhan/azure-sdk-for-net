// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a storage profile.
    /// </summary>
    public partial class StorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the StorageProfile class.
        /// </summary>
        public StorageProfile() { }

        /// <summary>
        /// Initializes a new instance of the StorageProfile class.
        /// </summary>
        /// <param name="imageReference">the image reference.</param>
        /// <param name="osDisk">the OS disk.</param>
        /// <param name="dataDisks">the data disks.</param>
        public StorageProfile(ImageReference imageReference = default(ImageReference), OSDisk osDisk = default(OSDisk), System.Collections.Generic.IList<DataDisk> dataDisks = default(System.Collections.Generic.IList<DataDisk>))
        {
            ImageReference = imageReference;
            OsDisk = osDisk;
            DataDisks = dataDisks;
        }

        /// <summary>
        /// Gets or sets the image reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets the OS disk.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osDisk")]
        public OSDisk OsDisk { get; set; }

        /// <summary>
        /// Gets or sets the data disks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataDisks")]
        public System.Collections.Generic.IList<DataDisk> DataDisks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.OsDisk != null)
            {
                this.OsDisk.Validate();
            }
            if (this.DataDisks != null)
            {
                foreach (var element in this.DataDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}