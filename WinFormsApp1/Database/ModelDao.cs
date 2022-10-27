using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using WinFormsApp1.Services;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Database
{
    public abstract class ModelDao<T>
    {
        protected abstract string Table { get; }
        protected abstract Dictionary<string, Func<T, object>> Columns { get; }

        private string ColumnsStatement =>
            string.Join(",", Columns.Keys);

        private string SelectStatement => $"select * from {Table}";

        private string GetColumnsValuesStatement(T obj)
        {
            return string.Join(
                ",",
                Columns.Values
                    .Select(value => value(obj))
                    .Select(value => value is DateTime dt ? dt.ToString("yyyy-MM-dd H:mm:ss") : value)
                    .Select(value => value is string ? $"'{value}'" : value.ToString())
            );
        }
        
        private string GetInsertStatement(T obj) =>
            $"insert into {Table}({ColumnsStatement}) values({GetColumnsValuesStatement(obj)})";

        protected abstract T GetFromReader(MySqlDataReader reader);
        
        public OperationResult<int> Insert(T obj) =>
            MySqlService.ExecNonQuery(GetInsertStatement(obj));

        public OperationResult<T> Get(int id) =>
            MySqlService.ExecQuery(
                $"{SelectStatement} where id = {id} limit 1",
                reader =>
                {
                    while (reader.Read())
                    {
                        return GetFromReader(reader);
                    }

                    return default;
                }
            );
    }
}