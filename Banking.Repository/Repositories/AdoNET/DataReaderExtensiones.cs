using System;
using System.Data;

namespace Banking.Repository.Repositories.AdoNET
{
    public static class DataReaderExtensiones
    {
        public static short GetValueInt16(this IDataReader reader, int ordinal)
        {
            short value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetInt16(ordinal);
            }

            return value;
        }

        public static int GetValueInt32(this IDataReader reader, int ordinal)
        {
            var value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetInt32(ordinal);
            }

            return value;
        }

        public static decimal GetValueDecimal(this IDataReader reader, int ordinal)
        {
            decimal value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetDecimal(ordinal);
            }

            return value;
        }

        public static string GetValueString(this IDataReader reader, int ordinal)
        {
            var value = string.Empty;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetString(ordinal);
            }

            return value;
        }

        public static DateTime GetValueDateTime(this IDataReader reader, int ordinal)
        {
            var value = DateTime.MinValue;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetDateTime(ordinal);
            }

            return value;
        }

        public static Boolean GetValueBoolean(this IDataReader reader, int ordinal)
        {
            var value = false;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetBoolean(ordinal);
            }

            return value;
        }

        public static Guid GetValueGuid(this IDataReader reader, int ordinal)
        {
            Guid value = default(Guid);

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetGuid(ordinal);
            }

            return value;
        }

        public static byte GetValueByte(this IDataReader reader, int ordinal)
        {
            byte value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetByte(ordinal);
            }

            return value;
        }
    }
}
