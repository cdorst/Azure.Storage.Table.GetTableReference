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
