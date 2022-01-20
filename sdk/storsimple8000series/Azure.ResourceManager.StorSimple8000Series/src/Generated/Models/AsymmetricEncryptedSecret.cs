// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> Represent the secrets intended for encryption with asymmetric key pair. </summary>
    public partial class AsymmetricEncryptedSecret
    {
        /// <summary> Initializes a new instance of AsymmetricEncryptedSecret. </summary>
        /// <param name="value"> The value of the secret. </param>
        /// <param name="encryptionAlgorithm"> The algorithm used to encrypt &quot;Value&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AsymmetricEncryptedSecret(string value, EncryptionAlgorithm encryptionAlgorithm)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            EncryptionAlgorithm = encryptionAlgorithm;
        }

        /// <summary> Initializes a new instance of AsymmetricEncryptedSecret. </summary>
        /// <param name="value"> The value of the secret. </param>
        /// <param name="encryptionCertThumbprint"> Thumbprint certificate that was used to encrypt &quot;Value&quot;. If the value in unencrypted, it will be null. </param>
        /// <param name="encryptionAlgorithm"> The algorithm used to encrypt &quot;Value&quot;. </param>
        internal AsymmetricEncryptedSecret(string value, string encryptionCertThumbprint, EncryptionAlgorithm encryptionAlgorithm)
        {
            Value = value;
            EncryptionCertThumbprint = encryptionCertThumbprint;
            EncryptionAlgorithm = encryptionAlgorithm;
        }

        /// <summary> The value of the secret. </summary>
        public string Value { get; set; }
        /// <summary> Thumbprint certificate that was used to encrypt &quot;Value&quot;. If the value in unencrypted, it will be null. </summary>
        public string EncryptionCertThumbprint { get; set; }
        /// <summary> The algorithm used to encrypt &quot;Value&quot;. </summary>
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }
    }
}
