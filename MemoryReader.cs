using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CsGoRadar
{
    public class MemoryReader
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, UInt32 nSize, ref UInt32 lpNumberOfBytesRead);

        private readonly int PROCESS_WM_READ = 0x0010;
        private readonly IntPtr processHandler;
        private readonly Process process;

        public MemoryReader(String pName)
        {
            try
            {
                process = Process.GetProcessesByName(pName)[0];
            }
            catch (Exception e)
            {
                throw new Exception("Process is not open, please open the process first and then open this project again.");
            }

            processHandler = OpenProcess(PROCESS_WM_READ, false, process.Id);
        }

        public int readInt(int a)
        {

            bool success;
            byte[] buffer = new byte[4];
            UInt32 nBytesRead = 0;
            success = ReadProcessMemory(processHandler, (IntPtr)a, buffer, 4, ref nBytesRead);
            return BitConverter.ToInt32(buffer, 0);
        }

        public float readFloat(int a)
        {
            bool success;
            byte[] buffer = new byte[4];
            UInt32 nBytesRead = 0;
            success = ReadProcessMemory(processHandler, (IntPtr)a, buffer, 4, ref nBytesRead);
            return BitConverter.ToSingle(buffer, 0);
        }

        public int getEngine()
        {
            foreach (ProcessModule pm in process.Modules)
            {
                if (pm.ModuleName == "engine.dll")
                {
                    return (int)pm.BaseAddress;
                }
            }

            throw new Exception("engine not found");
        }

        public int getClient()
        {
            foreach (ProcessModule m in process.Modules)
            {
                if (m.ModuleName == "client_panorama.dll")
                {
                    return (int)m.BaseAddress;
                }
            }

            throw new Exception("client not found");
        }
    }
}
