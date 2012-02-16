#region License

/*
 * Copyright � 2002-2011 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;
using System.Collections.Generic;

namespace Spring.Collections.Generic
{
    /// <summary>
    /// Implements an ordered <c>Set</c> based on a dictionary.
    /// </summary>
    [Serializable]
    public class OrderedSet<T> : DictionarySet<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderedSet{T}" /> class.
        /// </summary>
        public OrderedSet()
        {
            InternalDictionary = new Dictionary<T, object>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderedSet{T}"/> class.
        /// </summary>
        /// <param name="initialValues">A collection of elements that defines the initial set contents.</param>
        public OrderedSet(ICollection<T> initialValues)
            : this()
        {
            AddAll(initialValues);
        }
    }
}
