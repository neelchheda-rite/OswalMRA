using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON
{
    public static class ExtensionMethod
    {
        #region Get Enum Description
        /// <summary>
        /// This method give Enum Description
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (field != null && Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }
        /// <summary>
        /// This method give Value by description
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>

        public static T GetEnumValueByDescription<T>(this string description) where T : Enum
        {
            foreach (Enum enumItem in Enum.GetValues(typeof(T)))
            {
                if (enumItem.GetEnumDescription() == description)
                {
                    return (T)enumItem;
                }
            }
            throw new ArgumentException("Not found.", nameof(description));
        }

        public static T TrimStringProperties<T>(this T input)
        {

            var stringProperties = input.ToSafeString().GetType().GetProperties()
                .Where(p => p.PropertyType == typeof(string) && p.CanWrite);

            foreach (var stringProperty in stringProperties)
            {
                string currentValue = (string)stringProperty.GetValue(input, null);
                if (currentValue != null)
                    stringProperty.SetValue(input, currentValue.Trim(), null);
            }
            return input;
        }
        #endregion

        #region DataType conversion
        public static string ToSafeString(this object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                    return string.Empty;
                else
                    return obj.ToString().Trim();
            }
            catch
            {
                return string.Empty;
            }
        }
        public static DateTime ToDateTime(this object obj)
        {
            try
            {
                if (obj == null)
                    return new DateTime(1900, 01, 01);
                else
                    return Convert.ToDateTime(obj);
            }
            catch
            {
                return new DateTime(1900, 01, 01);
            }
        }
        public static decimal ToDecimal(this object obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToSafeString()))
                    return 0.00M;
                return Convert.ToDecimal(obj);
            }
            catch
            {
                return 0.00M;
            }
        }
        public static int ToInt(this object obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToSafeString()))
                    return 0;

                return Convert.ToInt32(obj);
            }
            catch
            {
                return 0;
            }
        }
        public static Int64 ToLong(this object obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToSafeString()))
                    return 0;

                return Convert.ToInt64(obj);
            }
            catch
            {
                return 0;
            }
        }
        public static bool ToBool(this string obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToSafeString()))
                    return false;
                else if (obj.ToSafeString().ToUpper() == "TRUE")
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public static string ToString(this DateTime? dt, string format) => (dt == null || Convert.ToString(dt) == "") ? "" : ((DateTime)dt).ToString(format);

        public static bool IsNumeric(this string text) => double.TryParse(text, out _);
        public static string ToTitleCase(this string s) => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(s.ToSafeString().ToLower());
        public static DateTime ToDateTime(this string dateTimeString, string dateTimeFormat, DateTimeKind dateTimeKind)
        {
            if (string.IsNullOrEmpty(dateTimeString))
            {
                return DateTime.MinValue;
            }

            DateTime dateTime;
            try
            {
                dateTime = DateTime.SpecifyKind(DateTime.ParseExact(dateTimeString, dateTimeFormat, CultureInfo.InvariantCulture), dateTimeKind);
            }
            catch (FormatException)
            {
                dateTime = DateTime.MinValue;
            }
            return dateTime;
        }
        #endregion

        #region DATA ENCRYPTION AND DECRYPTION
        static byte[] Encrypt(string simpletext, byte[] key, byte[] iv)
        {
            byte[] cipheredtext;
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);
                using (MemoryStream memoryStream = new())
                {
                    using (CryptoStream cryptoStream = new(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new(cryptoStream))
                        {
                            streamWriter.Write(simpletext);
                        }

                        cipheredtext = memoryStream.ToArray();
                    }
                }
            }
            return cipheredtext;
        }

        static string Decrypt(byte[] cipheredtext, byte[] key, byte[] iv)
        {
            string simpletext = String.Empty;
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(key, iv);
                using (MemoryStream memoryStream = new(cipheredtext))
                {
                    using (CryptoStream cryptoStream = new(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new(cryptoStream))
                        {
                            simpletext = streamReader.ReadToEnd();
                        }
                    }
                }
            }
            return simpletext;
        }
        #endregion
    }
}
