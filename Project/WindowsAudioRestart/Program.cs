using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAudioRestart
{
    internal class Program
    {
        static void Main()
        {
            // コマンドとパラメータを設定
            string command = "cmd.exe";
            string arguments = "/c net stop \"Windows Audio\" && net start \"Windows Audio\"";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(command, arguments)
            {
                // 管理者権限で実行するための設定
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            try
            {
                // プロセスを起動
                using (Process process = Process.Start(processStartInfo))
                {
                    process.WaitForExit(); // プロセスが終了するまで待機
                    Console.WriteLine("Windows Audio service has been restarted successfully.");
                }
            }
            catch (Exception ex)
            {
                // エラー処理
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}