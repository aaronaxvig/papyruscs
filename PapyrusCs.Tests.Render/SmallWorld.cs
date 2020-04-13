using NUnit.Framework;
using System;
using System.Diagnostics;

namespace PapyrusCs.Tests.Render
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SmallWorldFullRender()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "PapyrusCs.exe",
                    Arguments = "--world worlds/SmallWorld/db",
                    UseShellExecute = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false
                }
            };

            PapyrusCs.Program.Main(new string[] { "--world", "worlds/SmallWorld/db" });
        }
    }
}