using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(DocSignCollection.collection[0].Name);
            //Console.WriteLine(DocSignCollection.collection[0].Oper);
            //Console.WriteLine( DocSignCollection.collection.Contains());

            List<string> list = new List<string>() { "VKCaseDocSign","VKReqDocSign","VKBCDocSign",};

            //DocSignCollection.dictOper.Values.

            foreach (var item in DocSignCollection.dictOper)
            {
                Console.WriteLine(DocSignCollection.dictOper.Keys.ToList().IndexOf(item.Key) + $" {item.Key} {item.Value}");
            }
        }
    }

    public static class DocSignCollection
    {
        public static List<DocSign> collection = new List<DocSign>() { new DocSign { Name = "VKCaseDocSign", Oper = "o:RvcValutOper.o_VKCaseDocSign" }, new DocSign { Name = "VKReqDocSign", Oper = "o:RvcValutOper.o_VKReqDocSign" }, new DocSign { Name = "VKBCDocSign", Oper = "o:RvcValutOper.o_VKBCDocSign" }, new DocSign { Name = "VKCaseJourSign", Oper = "o:RvcValutOper.o_VKCaseJourSign" }, new DocSign { Name = "VKReqJourSign", Oper = "o:RvcValutOper.o_VKReqJourSign" }, new DocSign { Name = "VKBCJourSign", Oper = "o:RvcValutOper.o_VKBCJourSign" }, };


        public static Dictionary<string, string> dictOper = new Dictionary<string, string>()
        {
            {"VKCaseDocSign",   "o:RvcValutOper.o_VKCaseDocSign"},
            {"VKReqDocSign",    "o:RvcValutOper.o_VKReqDocSign" },
            {"VKBCDocSign",     "o:RvcValutOper.o_VKBCDocSign" },
            {"VKCaseJourSign",  "o:RvcValutOper.o_VKCaseJourSign" },
            {"VKReqJourSign",   "o:RvcValutOper.o_VKReqJourSign" },
            {"VKBCJourSign",    "o:RvcValutOper.o_VKBCJourSign" }

        };



    }
    //o:RvcValutOper.o_VKCaseDocSign,
    //o:RvcValutOper.o_VKReqDocSign,
    //o:RvcValutOper.o_VKBCDocSign,

    //o:RvcValutOper.o_VKCaseJourSign,
    //o:RvcValutOper.o_VKReqJourSign,
    //o:RvcValutOper.o_VKBCJourSign

    public class DocSign
    {
        public string Name { get; set; }
        public string Oper { get; set; }

    }
}
