using System;
using System.Collections.Generic;

namespace RiderIssue.Api.Tests.Data
{
    public class Generator
    {
        private readonly Random _random;
        
        public Generator()
        {
            _random = new Random();
        }

        public Boolean RandomBoolean()
        {
            return Convert.ToBoolean(_random.Next(0, 1));
        }

        public String RandomNumber()
        {
            return _random.Next(0, Int32.MaxValue).ToString();
        }

        public Decimal RandomPrice()
        {
            return Convert.ToDecimal(_random.Next(0, 10000) / 100);
        }
        
        public string RandomEventName()
        {
            var left = new List<String>
            {
                "admiring",
                "adoring",
                "affectionate",
                "agitated",
                "amazing",
                "angry",
                "awesome",
                "beautiful",
                "blissful",
                "bold",
                "boring",
                "brave",
                "busy",
                "charming"
            };
            var right = new List<String>
            {
                // Muhammad ibn Jābir al-Ḥarrānī al-Battānī was a founding father of astronomy. https://en.wikipedia.org/wiki/Mu%E1%B8%A5ammad_ibn_J%C4%81bir_al-%E1%B8%A4arr%C4%81n%C4%AB_al-Batt%C4%81n%C4%AB
                "albattani",

                // Frances E. Allen, became the first female IBM Fellow in 1989. In 2006, she became the first female recipient of the ACM's Turing Award. https://en.wikipedia.org/wiki/Frances_E._Allen
                "allen",

                // June Almeida - Scottish virologist who took the first pictures of the rubella virus - https://en.wikipedia.org/wiki/June_Almeida
                "almeida",

                // Kathleen Antonelli, American computer programmer and one of the six original programmers of the ENIAC - https://en.wikipedia.org/wiki/Kathleen_Antonelli
                "antonelli",

                // Maria Gaetana Agnesi - Italian mathematician, philosopher, theologian and humanitarian. She was the first woman to write a mathematics handbook and the first woman appointed as a Mathematics Professor at a University. https://en.wikipedia.org/wiki/Maria_Gaetana_Agnesi
                "agnesi",

                // Archimedes was a physicist, engineer and mathematician who invented too many things to list them here. https://en.wikipedia.org/wiki/Archimedes
                "archimedes",

                // Maria Ardinghelli - Italian translator, mathematician and physicist - https://en.wikipedia.org/wiki/Maria_Ardinghelli
                "ardinghelli",

                // Aryabhata - Ancient Indian mathematician-astronomer during 476-550 CE https://en.wikipedia.org/wiki/Aryabhata
                "aryabhata",

                // Wanda Austin - Wanda Austin is the President and CEO of The Aerospace Corporation, a leading architect for the US security space programs. https://en.wikipedia.org/wiki/Wanda_Austin
                "austin",

                // Charles Babbage invented the concept of a programmable computer. https://en.wikipedia.org/wiki/Charles_Babbage.
                "babbage",

                // Stefan Banach - Polish mathematician, was one of the founders of modern functional analysis. https://en.wikipedia.org/wiki/Stefan_Banach
                "banach"
            };
            var leftIndex = _random.Next(0, left.Count);
            var rightIndex = _random.Next(0, right.Count);
            return $"{left[leftIndex]}_{right[rightIndex]}";
        }
    }
}