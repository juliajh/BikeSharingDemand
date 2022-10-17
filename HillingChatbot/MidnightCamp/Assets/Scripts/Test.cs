using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class Test : MonoBehaviour
{
    public void ExecuteCommand()
    {
        Process cmd = new Process();
        cmd.StartInfo.FileName = "conda.exe";
        cmd.StartInfo.RedirectStandardInput = true;
        cmd.StartInfo.RedirectStandardOutput = true;
        cmd.StartInfo.CreateNoWindow = false;
        cmd.StartInfo.UseShellExecute = false;
        cmd.Start();

        cmd.StandardInput.WriteLine("cd C:/Users/HP/Desktop/MidnightCamp/Chatbot-main");
        cmd.StandardInput.WriteLine("python tatal_test.py");
        cmd.StandardInput.Flush();
        cmd.StandardInput.Close();
        cmd.WaitForExit();
        Console.WriteLine(cmd.StandardOutput.ReadToEnd());
    }

    public void test2()
    {
        try
        {
            Process psi = new Process();
            psi.StartInfo.FileName = "C:\\Users\\HP\\miniconda3\\envs\\flaskchat\\python.exe";
            // 파이썬 환경 연결
            psi.StartInfo.Arguments = "C:\\Users\\HP\\Desktop\\MidnightCamp\\Chatbot-main\\tatal_test.py";
            // 실행할 파이썬 파일
            psi.StartInfo.CreateNoWindow = false;
            // 새창에서 시작 걍 일케 두는듯

            psi.StartInfo.UseShellExecute = false;
            // 프로세스를 시작할때 운영체제 셸을 사용할지 이것도 걍 일케 두는듯
            psi.Start();

            UnityEngine.Debug.Log("[알림] .py file 실행");
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogError("[알림] 에러발생: " + e.Message);
        }
    }

}
