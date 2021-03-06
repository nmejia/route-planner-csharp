﻿/*
 | Version 10.1.84
 | Copyright 2013 Esri
 |
 | Licensed under the Apache License, Version 2.0 (the "License");
 | you may not use this file except in compliance with the License.
 | You may obtain a copy of the License at
 |
 |    http://www.apache.org/licenses/LICENSE-2.0
 |
 | Unless required by applicable law or agreed to in writing, software
 | distributed under the License is distributed on an "AS IS" BASIS,
 | WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 | See the License for the specific language governing permissions and
 | limitations under the License.
 */

using System;

namespace ESRI.ArcLogistics.Threading
{
    /// <summary>
    /// Provides facilities for simplifying parallel code execution.
    /// </summary>
    internal interface ITaskRunner
    {
        /// <summary>
        /// Executes a for loop with possibly parallel iterations.
        /// </summary>
        /// <param name="fromInclusive">The starting loop index.</param>
        /// <param name="toExclusive">The ending loop index.</param>
        /// <param name="body">The delegate representing loop body.</param>
        /// <exception cref="T:System.AggregateException">
        /// Contains exceptions thrown by one or more iterations.</exception>
        void For(int fromInclusive, int toExclusive, Action<int> body);

        /// <summary>
        /// Executes specified actions possibly in parallel.
        /// </summary>
        /// <param name="actions">The reference to the collection of actions
        /// to be executed.</param>
        /// <exception cref="T:System.AggregateException">
        /// Contains exceptions thrown by one or more actions.</exception>
        void Invoke(params Action[] actions);
    }
}
