using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public enum MessageType
    {
        Error,
        Exception,
        Test,
        Info,
        Warning
    }
    public enum LogPart
    {
        Date,
        Time,
        Type,
        User,
        Text
    }
    public static class Logger
    {
        private static string _path;
        private static string _settingsPath;
        private static List<LogPart> _parts;
        static Logger()
        {
            _path = @"C:\Code\CSharp_Homework\HomeworkLogger\Logs\noteLog.txt";
            _settingsPath = @"C:\Code\CSharp_Homework\HomeworkLogger\Logs\Settings.ini";
            _parts = new List<LogPart>();
            File.Delete(_path);
            ReadSettings();
        }
        private static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        private static void ReadSettings()
        {
            const int BufferSize = 128;
            using (var fileStream = File.OpenRead(_settingsPath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    LogPart part = ParseEnum<LogPart>(line);
                    _parts.Add(part);
                }
            }
        }
        public static void WriteLog(string text, MessageType type)
        {
            string message = "";
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string date = DateTime.Now.ToString("M/d/yyyy");
            string time = DateTime.Now.ToString("h:mm:ss");
            foreach(LogPart logPart in _parts)
            {
                switch(logPart)
                {
                    case LogPart.Date:
                        message += date;
                        break;
                    case LogPart.Time:
                        message += time;
                        break;
                    case LogPart.Type:
                        message += type;
                        break;
                    case LogPart.User:
                        message += userName;
                        break;
                    case LogPart.Text:
                        message += text;
                        break;
                    default:
                        Console.WriteLine("Log invalid value");
                        break;
                }
                message += " ";
            }
            using (StreamWriter streamWrite = File.AppendText(_path))
            {
                streamWrite.WriteLine(message);
            }
        }
    }
}
