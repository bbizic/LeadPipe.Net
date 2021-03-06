﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Lead Pipe Software. All rights reserved.
// Licensed under the MIT License. Please see the LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------------------------

using Lucene.Net.Index;
using Lucene.Net.Store;
using Lucene.Net.Util;

namespace LeadPipe.Net.Lucene
{
    /// <summary>
    /// Optimizes the search index.
    /// </summary>
    public interface ISearchIndexOptimizer
    {
        /// <summary>
        /// Optimizes the Lucene index.
        /// </summary>
        /// <param name="luceneVersion">The lucene version.</param>
        /// <param name="directory">The lucene directory.</param>
        /// <param name="maxFieldLength">Maximum length of the field.</param>
        void Optimize(Version luceneVersion, Directory directory, IndexWriter.MaxFieldLength maxFieldLength);
    }
}