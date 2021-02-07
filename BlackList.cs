using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class BlackList <TCode,TName>
    {
        TCode[] Codes;
        TName[] names;

        public BlackList()
        {
            Codes = new TCode[0];
            names = new TName[0];
        }
        public void Add(TCode code, TName name)
        {
            TCode[] tempCode = Codes;
            TName[] tempnames = names;

            Codes = new TCode[Codes.Length + 1];
            names = new TName[names.Length + 1];
            for (int i = 0; i < tempCode.Length; i++) 
            {
                Codes[i] = tempCode[i];
            }

            Codes[Codes.Length - 1] = code;

            for (int i = 0; i < tempnames.Length; i++)
            {
                names[i] = tempnames[i];
            }

            names[names.Length - 1] = name;

            Console.WriteLine("Blacklist Code : {0} --- Name/Surname : {1}", code, name);
        }


    }
}
