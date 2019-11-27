using System;
using System.Text;

namespace ZD_ADO_Connector
{
    internal static class Tools
    {
        internal static string Base64Encode(this string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
