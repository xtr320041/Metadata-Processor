using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace mediaFileProcessor
{
    public static class Util
    {
        public static string GetMeta(string fileName)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"exiftool.exe";
            process.StartInfo.Arguments = "\"" + fileName + "\""; // Note the /c command (*)
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            output = output.Replace("|", " ");
            output = output.Replace("\r\n", "|");
            //output = getXml(output);
            //Console.WriteLine(output);
            process.WaitForExit();
            return output;
        }

        public static string getXml(string rsStr)
        {
            string xStr = "";
            bool logged = false;
            string[] rs = rsStr.Split(new char[] { '|' });
            for (int i = 0; i < rs.Length; i++)
            {
                if ((rs[i].Trim().Length > 0) && !rs[i].StartsWith("ExifTool Version Number") && !rs[i].StartsWith("File Not Found"))
                {
                    rs[i] = rs[i].Replace(": ", "|");
                    string[] ls = rs[i].Split(new char[] { '|' });
                    if (ls.Length > 1)
                        xStr = xStr + "<" + ls[0].Trim() + ">" + ls[1].Trim() + "</" + ls[0].Trim() + ">" + "\r\n";
                    else
                    {
                        if (!logged)
                        {
                            Util.LogErr("getXml Paser Error: " + rsStr);
                            logged = true;
                        }
                    }
                }
            }
            return xStr;
        }

        public static List<ValuePair> getValuePair(string rsStr)
        {
            List<ValuePair> vp = new List<ValuePair>();
            bool logged = false;
            string[] rs = rsStr.Split(new char[] { '|' });
            for (int i = 0; i < rs.Length; i++)
            {
                if ((rs[i].Trim().Length > 0) && !rs[i].StartsWith("ExifTool Version Number") && !rs[i].StartsWith("File Not Found"))
                {
                    rs[i] = rs[i].Replace(": ", "|");
                    string[] ls = rs[i].Split(new char[] { '|' });
                    if (ls.Length > 1)
                    {
                        vp.Add(new ValuePair(ls[0].Trim(), ls[1].Trim()));
                    }
                    else
                    {
                        if (!logged)
                        {
                            Util.LogErr("getXml Paser Error: " + rsStr);
                            logged = true;
                        }
                    }
                }
            }
            return vp;
        }

        //for display from file system
        public static string getXml2(string rsStr)
        {
            List<string> listStr = new List<string>();
            string xStr = "";
            string[] rs = rsStr.Split(new char[] { '|' });
            for (int i = 0; i < rs.Length; i++)
            {
                if ((rs[i].Trim().Length > 0) && !rs[i].StartsWith("ExifTool Version Number") && !rs[i].StartsWith("File Not Found"))
                {
                    rs[i] = rs[i].Replace(": ", "|");
                    string[] ls = rs[i].Split(new char[] { '|' });
                    listStr.Add("<" + ls[0].Trim() + ">  " + ls[1].Trim());
                }
            }
            listStr = listStr.OrderBy(q => q).ToList();
            for (int i = 0; i < listStr.Count; i++)
            {
                xStr = xStr + listStr[i] + "\r\n";
            }
            return xStr;
        }

        //for saving from file system
        public static string getXml4(string rsStr)
        {
            List<string> listStr = new List<string>();
            string xStr = "";
            string[] rs = rsStr.Split(new char[] { '|' });
            for (int i = 0; i < rs.Length; i++)
            {
                if ((rs[i].Trim().Length > 0) && !rs[i].StartsWith("ExifTool Version Number") && !rs[i].StartsWith("File Not Found"))
                {
                    rs[i] = rs[i].Replace(": ", "|");
                    string[] ls = rs[i].Split(new char[] { '|' });
                    string v = ls[1].Trim();
                    if (v.Length == 0)
                        v = " ";
                    listStr.Add(ls[0].Trim() + "|" + v);
                }
            }
            if (listStr.Count > 1)
            {
                for (int i = 0; i < listStr.Count - 1; i++)
                {
                    xStr = xStr + listStr[i] + "||";
                }
                xStr = xStr + listStr[listStr.Count - 1];
            }
            return xStr;
        }

        //for display from database
        public static string getXml3(string rsStr)
        {
            List<string> listStr = new List<string>();
            rsStr = rsStr.Replace("\r\n", "|");
            string xStr = "";
            string[] rs = rsStr.Split(new char[] { '|' });
            for (int i = 0; i < rs.Length; i++)
            {
                int p = rs[i].IndexOf("</");
                if (p > 0)
                {
                    string l = rs[i].Substring(0, p);
                    int p2 = l.IndexOf(">");
                    string l2 = l.Substring(0, p2 + 1) + "  " + l.Substring(p2 + 1);
                    listStr.Add(l2);
                }
            }

            listStr = listStr.OrderBy(q => q).ToList();
            for (int i = 0; i < listStr.Count; i++)
            {
                xStr = xStr + listStr[i] + "\r\n";
            }
            return xStr;
        }
        public static void LogErr(string msg)
        {
            string path = @"Error.log";           
            using (StreamWriter sw = File.AppendText(path))
            {
                DateTime dt = DateTime.Now;
                sw.WriteLine(dt.ToShortDateString() + " " + dt.ToLongTimeString() + " " + msg);
            }
        }

        public static string GetDBcnn()
        {
            string cnn = mediaFileProcessor.Properties.Settings.Default.dbString;
            #if DEBUG
                        cnn = mediaFileProcessor.Properties.Settings.Default.dbStringDebug;
            #endif
            return cnn;
        }
    }
}
