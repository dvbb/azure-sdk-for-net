﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents
{
    /// <summary>
    /// Options for <see cref="SearchClient.GetDocumentAsync"/>.
    /// </summary>
    public class GetDocumentOptions
    {
        /// <summary>
        /// Throws a <see cref="RequestFailedException"/> if the document is missing. This is the default behavior.
        /// If set to <c>false</c>, a <c>default</c> <see cref="Response{T}.Value"/> is instead returned.
        /// </summary>
        public bool ThrowOnMissingDocument { get; set; } = true;

        /// <summary>
        /// A list of field names to retrieve.  Only fields marked as
        /// retrievable can be included in this clause.  Any field not
        /// retrieved will be missing from the returned document.  If empty,
        /// all fields marked as retrievable in the schema are returned.
        /// </summary>
        public IList<string> SelectedFields { get; internal set; } = new List<string>();

        /// <summary>
        /// Gets the selected fields.  If the collection is null or empty, we
        /// return null.
        /// </summary>
        internal IEnumerable<string> SelectedFieldsOrNull =>
            SelectedFields?.Count > 0 ? SelectedFields : null;
    }
}
