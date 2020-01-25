using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CPPConfuser
{
    class Confuser
    {
        List<string> ConfuseRules = new List<string>();
        public Confuser(string rules)
        {
            string[] keyWords = rules.Split('|');
            for(int i = 0; i < keyWords.Length; i++)
            {
                ConfuseRules.Add(keyWords[i]);
            }
        }
        public string DefineConfuse(string source)
        {
            List<string> AlreadyFind = ConfuseRules;
            string[] Singlewords = source.Split(' ');
            string result = source;
            
            StringBuilder finBuilder = new StringBuilder();
            for(int i = 0; i < AlreadyFind.Count; i++)
            {
                StringBuilder builder = new StringBuilder();
                for (int j = 1; j <= i + 1; j++)
                {
                    builder.Append('_');
                }
                finBuilder.Append("\n#define " + builder.ToString() + " " + AlreadyFind[i]+"\n");
            }
            for(int i = 0; i < AlreadyFind.Count; i++)
            {
                if (AlreadyFind[i].Contains("#")) continue;
                StringBuilder builder = new StringBuilder();
                for(int j=1;j<=i+1; j++)
                {
                    builder.Append('_');
                }
                result=result.Replace(AlreadyFind[i], builder.ToString());
            }
            finBuilder.Append(result);
            return finBuilder.ToString();
        }
    }
}
