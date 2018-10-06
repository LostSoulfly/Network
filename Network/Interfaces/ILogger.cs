using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Enums;

namespace Network.Interfaces
{
    public interface ILogger
    {
        bool EnableLogging { get; set; }
        
        void Log(Exception exception, LogLevel logLevel = LogLevel.Information);

        void Log(string message, Exception exception, LogLevel logLevel = LogLevel.Information);

        void Log(string message, LogLevel logLevel = LogLevel.Information);

        void Log(string message);
        
        void LogInComingPacket(byte[] packet, Packet packetObj);

        void LogOutgoingPacket(byte[] packet, Packet packetObj);

        void LogIntoStream(Stream stream);

    }
}
