using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Text.Json;
using PdfSharp;
using System.Diagnostics;
using System.Text;

namespace resume
{
    internal static class Program
    {

        [STAThread]
        static void Main(string [] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}