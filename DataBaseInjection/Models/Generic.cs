using Dapper;
using System.IO;
using System.Reflection;

namespace Models
{
    public abstract class Generic
    {
        public static DynamicParameters GetParameters<T>(T obj)
        {
            DynamicParameters _parameters = new DynamicParameters();
            PropertyInfo[] _properties = obj.GetType().GetProperties();

            foreach (var _property in _properties)
            {
                _parameters.Add($"@{_property.Name}", _property.GetValue(obj));
            }
            return _parameters;
        }

        public static string GenerateInsertCommand<T>(T obj, string _tableName, string _inforRestrained) // Colocar variável string para ignorar
        {
            PropertyInfo[] _properties = obj.GetType().GetProperties().ToArray();

            string _Cols = string.Join(", ", _properties.Where(o=> o.Name != "_id").Select(o => o.Name));
            string _parameters = string.Join(", ", _properties.Where(o => o.Name != "_id").Select(o => $"@{o.Name}"));

            return $"INSERT INTO {_tableName} ({_Cols}) VALUES ({_parameters})"; 
        }

        public virtual string GetPath() { return string.Empty; }
        public virtual string GetFile() { return string.Empty; }
        public virtual string GetTableName() { return string.Empty; }
        public virtual string GetRestrained() { return string.Empty; }
    }
}
