// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.LabServices
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Image
        /// <summary> Gets an object representing a Image along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Image" /> object. </returns>
        public static Image GetImage(this ArmClient armClient, ResourceIdentifier id)
        {
            Image.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Image(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region LabPlan
        /// <summary> Gets an object representing a LabPlan along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabPlan" /> object. </returns>
        public static LabPlan GetLabPlan(this ArmClient armClient, ResourceIdentifier id)
        {
            LabPlan.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new LabPlan(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Lab
        /// <summary> Gets an object representing a Lab along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Lab" /> object. </returns>
        public static Lab GetLab(this ArmClient armClient, ResourceIdentifier id)
        {
            Lab.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Lab(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Schedule
        /// <summary> Gets an object representing a Schedule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Schedule" /> object. </returns>
        public static Schedule GetSchedule(this ArmClient armClient, ResourceIdentifier id)
        {
            Schedule.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Schedule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region User
        /// <summary> Gets an object representing a User along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="User" /> object. </returns>
        public static User GetUser(this ArmClient armClient, ResourceIdentifier id)
        {
            User.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new User(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachine
        /// <summary> Gets an object representing a VirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachine" /> object. </returns>
        public static VirtualMachine GetVirtualMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachine.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
