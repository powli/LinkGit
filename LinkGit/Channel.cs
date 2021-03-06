﻿//-----------------------------------------------------------------------
// <copyright file="Channel.cs">
//    This file is part of LinkGit.
//
//    LinkGit is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    LinkGit is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with LinkGit.  If not, see http://www.gnu.org/licenses/.
// </copyright>
//-----------------------------------------------------------------------
namespace LinkGit
{
    using System;
    using SQLite;

    /// <summary>
    /// Class for a database object that represents a Discord Channel
    /// </summary>
    [Table("Channels")]
    public class Channel
    {
        /// <summary>
        /// Gets or sets the ID of the Discord channel
        /// </summary>
        [Unique, PrimaryKey]
        public long ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the Discord channel
        /// </summary>
        public string Name { get; set; }
    }
}