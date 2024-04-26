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
                RedirectStandardOutput = true, // 標準出力をリダイレクト
                RedirectStandardError = true, // 標準エラーをリダイレクト
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            try
            {
                // プロセスを起動
                using (Process process = Process.Start(processStartInfo))
                {
                    string output = process.StandardOutput.ReadToEnd(); // 出力を読み取る
                    string errors = process.StandardError.ReadToEnd(); // エラーを読み取る
                    process.WaitForExit(); // プロセスが終了するまで待機
                    Console.WriteLine("Windows Audio service has been restarted successfully.");
                    if (!string.IsNullOrEmpty(errors))
                    {
                        Console.WriteLine("Error: " + errors);
                    }
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