using System;
using System.Collections.Generic;

namespace GS4Net
{
    public class GS4Net
    {
        // -d arguments
        private static readonly Dictionary<string, string> DEFAULTDARGS = new Dictionary<string, string>() {
         { "SAFER", "" },
         { "BATCH", "" },
         { "NOPAUSE", "" },
         //{ "NOPROMPT", "" },
         //{ "ShowAnnots", "false" },
         { "PDFSETTINGS", "/prepress" },
         { "PassThroughJPEGImages", "true" }
      };

        // -s arguments
        private static readonly Dictionary<string, string> DEFAULTSARGS = new Dictionary<string, string>() {
         { "DEVICE", "pdfwrite" },
         { "OutputFile", "output.pdf" }
      };

        public static readonly string REMOVE = "-+REMOVE+-";

        public static List<string> g_gsArgs = new List<string>();



        // More information at: https://www.ghostscript.com/doc/9.52/Use.htm#Parameter_switches
        public static void Generate64(string pdf, string pdfoutput, Dictionary<string, string> dArgs, Dictionary<string, string> sArgs)
        {
            GSAPI.GS64(CombineArgs(pdf, pdfoutput, dArgs, sArgs));
        }
        public static void Generate32(string pdf, string pdfoutput, Dictionary<string, string> dArgs, Dictionary<string, string> sArgs)
        {
            GSAPI.GS32(CombineArgs(pdf, pdfoutput, dArgs, sArgs));
        }

        public static void Generate(string pdf, string pdfoutput, Dictionary<string, string> dArgs, Dictionary<string, string> sArgs)
        {
            // 64bit, 32bit 구분
            if (IntPtr.Size == 8)
            {
                GSAPI.GS64(CombineArgs(pdf, pdfoutput, dArgs, sArgs));
            }
            else
            {
                GSAPI.GS32(CombineArgs(pdf, pdfoutput, dArgs, sArgs));
            }
        }

        private static string[] CombineArgs(string pdf, string pdfoutput, Dictionary<string, string> dArgs, Dictionary<string, string> sArgs)
        {
            List<string> gsArgs = new List<string>();

            // -d arguments
            Dictionary<string, string> allArgs = MergeDictionary(DEFAULTDARGS, dArgs);
            foreach (string key in allArgs.Keys)
            {
                if (allArgs[key].Length == 0)
                {
                    gsArgs.Add(String.Format("-d{0}", key));
                }
                else
                {
                    gsArgs.Add(String.Format("-d{0}={1}", key, allArgs[key]));
                }
            }

            // -s arguments
            allArgs = MergeDictionary(DEFAULTSARGS, sArgs);

            if (pdfoutput != null && pdfoutput.Length != 0)
            {
                allArgs["OutputFile"] = pdfoutput;
            }
            foreach (string key in allArgs.Keys)
            {
                if (allArgs[key].Length == 0)
                {
                    gsArgs.Add(String.Format("-s{0}", key));
                }
                else
                {
                    gsArgs.Add(String.Format("-s{0}={1}", key, allArgs[key]));
                }
            }
            //gsArgs.Add("-q");
            gsArgs.Add(pdf);
            g_gsArgs = gsArgs;
            return gsArgs.ToArray();
        }


        private static Dictionary<string, string> MergeDictionary(Dictionary<string, string> def, Dictionary<string, string> dic)
        {
            Dictionary<string, string> merged = new Dictionary<string, string>();
            foreach (string key in def.Keys)
            {
                merged.Add(key, def[key]);
            }
            if (dic != null)
            {
                foreach (string key in dic.Keys)
                {
                    if (merged.ContainsKey(key))
                    {
                        if (dic[key].Equals(REMOVE))
                        {
                            merged.Remove(key);
                        }
                        else
                        {
                            merged[key] = dic[key];
                        }
                    }
                    else
                    {
                        merged.Add(key, dic[key]);
                    }
                }
            }
            return merged;
        }
    }
}
