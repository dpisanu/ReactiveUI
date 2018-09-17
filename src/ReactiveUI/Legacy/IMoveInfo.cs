﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace ReactiveUI.Legacy
{
    /// <summary>
    /// Information when a item has been moved inside a collection.
    /// </summary>
    /// <typeparam name="T">The item type inside the collection.</typeparam>
    public interface IMoveInfo<out T>
    {
        /// <summary>
        /// Gets a enumerable of the moved items.
        /// </summary>
        IEnumerable<T> MovedItems { get; }

        /// <summary>
        /// Gets the old index where the item has moved from.
        /// </summary>
        int From { get; }

        /// <summary>
        /// Gets the new index where the item has moved to.
        /// </summary>
        int To { get; }
    }
}
