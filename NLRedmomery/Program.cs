﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLRedmomery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.UtcNow.ToString());
            NLPIR_ICTCLAS_C nlpir = new NLPIR_ICTCLAS_C();
            string s1 = "ICTCLAS在国内973专家组组织的评测中活动获得了第一名，在第一届国际中文处理研究机构SigHan组织的评测中都获得了多项第一名。";
            s1 = redmomery.command.createlog.readTextFrompath(@"D:\题库系统\redMomery\redmomery\调试\新建文本文档.txt");
            int count = nlpir.GetParagraphProcessAWordCount(s1);
            result_t[] results = nlpir.ParagraphProcessAW(count);
            int i = 1;
            byte[] bytes = Encoding.Default.GetBytes(s1);
            foreach (result_t r in results)
            {
                string sWhichDic = "";
                switch (r.word_type)
                {
                    case 0:
                        sWhichDic = "核心词典";
                        break;
                    case 1:
                        sWhichDic = "用户词典";
                        break;
                    case 2:
                        sWhichDic = "专业词典";
                        break;
                    default:
                        break;
                }
                Console.WriteLine(r.sPos + "," + Encoding.Default.GetString(bytes, r.start, r.length));
                Console.WriteLine("No.{0}:start:{1},length:{2},POS_ID:{3}\n" +
                    "Word_ID:{4},UserDefine:{5},Weight:{6},word type:{7},workspose{8}",
                    i++, r.start, r.length, r.POS_id, r.word_ID, sWhichDic, r.weight, r.sPos,NLPIR_ICTCLAS_C.nominal(r.sPos));
            }
            Console.WriteLine("下面开始测试关键词提取功能");   
            string keys = nlpir.KeyExtractGetKeyWords(s1, 10, true);
            Console.WriteLine(keys);
            Console.WriteLine("测试发现新词功能：");
            string newwords = nlpir.FinerSegment("中华人名共和国");
            Console.WriteLine(newwords);
            
            Console.Read();
        }
    }
}
