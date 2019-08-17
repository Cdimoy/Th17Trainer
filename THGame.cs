using System;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TH17Trainer
{
    class THGame
    {
        const uint PROCESS_ALL_ACCESS = (0x000F0000 | 0x00100000 | 0xFFF);

        public readonly IntPtr livesAddress = new IntPtr(0x004B5A40);
        public readonly IntPtr powerAddress = new IntPtr(0x004B5A30);
        public readonly IntPtr bombsAddress = new IntPtr(0x004B5A4C);

        bool isAttached;
        IntPtr hProcess;

        readonly string procName = "";
        
        public THGame(string name)
        {
            procName = name;
            hProcess = (IntPtr)0;
            isAttached = false;
        }

        public bool IsRuning()
        {
            return Process.GetProcessesByName(procName).Length != 0;
        }

        public void Attach()
        {
            var process = Process.GetProcessesByName(procName).First();

            hProcess = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);
            isAttached = true;
        }

        public bool IsAttached()
        {
            return isAttached;
        }

        public void Detach()
        {
            if (IsRuning())
                CloseHandle(hProcess);
            isAttached = false;
        }

        public int ReadInt(IntPtr address)
        {
            uint nBytesRead = 0;

            byte[] lpBuffer = new byte[4];

            ReadProcessMemory(hProcess, address, lpBuffer, 4, ref nBytesRead);

            return BitConverter.ToInt32(lpBuffer, 0);
        }

        public void WriteInt(IntPtr address, int value)
        {
            uint lpNumberOfBytesWritten = 0;

            byte[] lpBuffer = BitConverter.GetBytes(value);

            WriteProcessMemory(hProcess, address, lpBuffer, 4, ref lpNumberOfBytesWritten);
        }

        ~THGame()
        {
            if (isAttached)
                CloseHandle(hProcess);
        }


        // Mapped WinAPI functions

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, ref uint lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, ref uint lpNumberOfBytesRead);
    }
}
