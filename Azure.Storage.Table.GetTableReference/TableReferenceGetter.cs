// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;
using static Azure.Storage.Table.GetTableClient.TableClientGetter;

namespace Azure.Storage.Table.GetTableReference
{
    /// <summary>Function returns a reference of a Microsoft Azure CloudTable using the given connection string and table name</summary>
    public static class TableReferenceGetter
    {
        /// <summary>Returns a reference of a Microsoft Azure CloudTable using the given connection string and table name</summary>
        public static CloudTable TableReference(string connectionString, string tableName) => TableClient(connectionString).GetTableReference(tableName);
    }
}
