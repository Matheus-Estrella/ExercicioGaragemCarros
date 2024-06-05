using Dapper;
using System.Reflection;

namespace Models
{
    public class Generic : Car
    {
        public static DynamicParameters GetParameters<T>(T obj)
        {
            DynamicParameters _parameters = new DynamicParameters();
            PropertyInfo[] _properties = typeof(T).GetProperties();

            foreach (var _property in _properties)
            {
                _parameters.Add($"@{_property.Name}", _property.GetValue(obj));
            }
            return _parameters;
        }

        public static string GenerateInsertCommand<T>(T obj, string _tableName)
        {
            PropertyInfo[] _properties = typeof(T).GetProperties();
            string _Cols = string.Join(", ", _properties.Select(o => o.Name));
            string _parameters = string.Join(", ", _properties.Select(o => $"@{o.Name}"));
            return $"INSERT INTO {_tableName} ({_Cols}) VALUES ({_parameters})";
        }

    }
}
