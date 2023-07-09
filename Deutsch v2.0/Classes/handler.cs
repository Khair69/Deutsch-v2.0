using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Deutsch_v2._0.Classes
{
    internal class handler
    {
        public int id;
        public string name;
        public bool dtoe;
        public string path;
        public int from;
        public int to;
        public List<string> dWords = new List<string>();
        public List<string> eWords = new List<string>();

        public void loadSave(int idl)
        {
            String line;
            try
            {
                line = File.ReadLines(@"..\..\..\Save files\saves.txt").Skip(idl - 1).Take(1).First();
                string[] aline = line.Split();
                id = int.Parse(aline[0]);
                name = aline[1];
                if (aline[2] == "dtoe") dtoe = true;
                else dtoe = false;
                path = aline[3];
                from = int.Parse(aline[4]);
                to = int.Parse(aline[5]);

            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
        }

        public void loadQuestions()
        {
            String line;
            int[] r = rngBetween();
            for (int i = 0; i < r.Length; i++)
            {
                try
                {
                    line = File.ReadLines(@"..\..\..\words\" + path + ".txt").Skip(r[i] - 1).Take(1).First();
                    string[] wline = line.Split();
                    dWords.Add(wline[1]);
                    eWords.Add(wline[2]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        public int[] rngBetween()
        {
            int[] er = { -1 };
            if (from <= 0 || to <= 0) return er;
            Random rnd = new Random();
            int size = to - from + 1;
            int[] rngs = new int[size];
            int rplc;
            for (int i = 0; i < size; i++)
            {
                rplc = rnd.Next(from, to + 1);
                while (rngs.Contains(rplc) == true) rplc = rnd.Next(from, to + 1);
                rngs[i] = rplc;
            }
            return rngs;
        }

        public List<string> getSaves()
        {
            string save;
            List<string> saves = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\Save files\saves.txt");
                save = sr.ReadLine();
                while (save != null)
                {
                    saves.Add(save.Split()[1]);
                    save = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            return saves;
        }

        public void newSave(string nName, bool nDtoe, string nPath, int nFrom, int nTo)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\Save files\saves.txt");
                id = 1;
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    id++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            line = id + "\t" + nName + "\t" + "dtoe" + "\t" + nPath + "\t" + nFrom + "\t" + nTo;
            try
            {
                File.AppendAllText(@"..\..\..\Save files\saves.txt", Environment.NewLine + line);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
        }

        //public void delSave(int idr)
        //{
        //    loadSave(idr);
        //    try
        //    {
        //        var tempFile = Path.GetTempFileName();
        //        var linesToKeep = File.ReadLines(@"..\..\..\Save files\saves.txt").Where(l => l != this.id + "\t" + name + "\t" + "dtoe" + "\t" + path + "\t" + from + "\t" + to);

        //        File.WriteAllLines(tempFile, linesToKeep);

        //        File.Delete(@"..\..\..\Save files\saves.txt");
        //        File.Move(tempFile, @"..\..\..\Save files\saves.txt");

        //        //string text = File.ReadAllText(@"..\..\..\Save files\saves.txt");
        //        //string result = Regex.Replace(text, @"(^\p{Zs}*\r\n){2,}", "\r\n", RegexOptions.Multiline);
        //        //File.WriteAllText(@"..\..\..\Save files\saves.txt", result);
        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine("Exception: " + e.Message);
        //    }

        //}

        public int getnOfWords(string fpath)
        {
            string line;
            int nOfWords = 0;
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\words\" + fpath + ".txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    nOfWords++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            return nOfWords;
        }

    }
}
