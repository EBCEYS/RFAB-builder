using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft;

namespace RFAB_builder
{
    static class Logger
    {
        public static JsonSerializerSettings SerializerSettings { get; } = new JsonSerializerSettings()
        {
            Converters = { new StringEnumConverter() },
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
        public static string Path { get; } = System.IO.Path.Combine(GetBasePath(), "logs", $"{Environment.UserName}.log");
        public static string DirPath { get; } = System.IO.Path.Combine(GetBasePath(), "logs");
        public static void Info<T>(T obj)
        {
            WriteLog(LogType.Info, JsonConvert.SerializeObject(obj, SerializerSettings));
        }
        public static void Info(params string[] strs)
        {
            WriteLog(LogType.Info, strs);
        }
        public static void Debug(object obj)
        {
            WriteLog(LogType.Debug, JsonConvert.SerializeObject(obj, SerializerSettings));
        }
        public static void Debug(params string[] strs)
        {
            WriteLog(LogType.Debug, strs);
        }
        public static void Error(object obj)
        {
            WriteLog(LogType.Error, JsonConvert.SerializeObject(obj, SerializerSettings));
        }
        public static void Error(params string[] strs)
        {
            WriteLog(LogType.Error, strs);
        }
        public static void Error(Exception ex)
        {
            WriteLog(LogType.Error, ex.Message, ex.StackTrace, ex.Source);
        }

        private static void WriteLog(LogType type, params string[] strs)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(type.ToString());
            sb.Append($"\t{DateTime.Now}]\t");
            foreach (string str in strs)
            {
                sb.Append(str + "\t");
            }
            sb.Append(Environment.NewLine);
            try
            {
                if (!System.IO.Directory.Exists(DirPath))
                {
                    System.IO.Directory.CreateDirectory(DirPath);
                }
                if (!System.IO.File.Exists(Path))
                {
                    System.IO.File.Create(Path);
                    System.IO.File.SetAttributes(Path, System.IO.FileAttributes.Normal);
                }
                System.IO.File.AppendAllText(Path, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine
                    + ex.StackTrace + Environment.NewLine
                    + ex.Source);
            }
        }

        private enum LogType
        {
            Info,
            Error,
            Debug
        }

        private static string GetBasePath()
        {
            return Environment.CurrentDirectory;
        }
    }
}
