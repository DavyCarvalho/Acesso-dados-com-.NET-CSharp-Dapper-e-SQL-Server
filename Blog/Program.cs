using System;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=NT-03072\SQLEXPRESS;Database=Blog;Integrated Security=SSPI";
        static void Main(string[] args)
        {
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {

            }
        }
    }
}
