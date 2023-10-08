

using System.Collections.Generic;
using System.Xml.Linq;

namespace task8_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //Student student1 = new Student("Zulfiyya", "Qurbanova", "AB104", 90);
            //student1.GetInfo();
            //student1.GetDiplomDegree();
            //student1.CheckGraduation();

            //task2_1

            //Console.WriteLine("Resadin xallarini daxil edin");
            //int[]resad= new int[3];
            //for (int i=0;i<resad.Length;i++)
            //{
            //restart:
            //    resad[i] = int.Parse(Console.ReadLine());
            //    if (resad[i] > 100 || resad[i]<0)
            //    {
            //        Console.WriteLine("duzgun eded daxil edin");
            //        goto restart;
            //    }
            //}

            //Console.WriteLine("Aydanin xallarini daxil edin");
            //int[]aydan= new int[3];
            //for (int i = 0; i < aydan.Length; i++)
            //{
            //restart:
            //    aydan[i] = int.Parse(Console.ReadLine());
            //    if (aydan[i] > 100 || aydan[i] < 0)
            //    {
            //        Console.WriteLine("duzgun eded daxil edin");
            //        goto restart;
            //    }
            //}
            //Sport(resad, aydan);

            //task2_2

            //Players player1 = NewPlayers();
            //Players player2 = NewPlayers();
            //PlayersScores(player1,player2);


            //task3


            //task4
            Console.WriteLine("String qeyd edin");
            string String = Console.ReadLine();
            string trimStart = CustomTrimStart(String);
            string trimEnd = CustomTrimEnd(String);
            string trimBoth = CustomTrim(String);

            Console.WriteLine($"Original String: '{String}'");
            Console.WriteLine($"TrimStart Result: '{trimStart}'");
            Console.WriteLine($"TrimEnd Result: '{trimEnd}'");
            Console.WriteLine($"Trim Result: '{trimBoth}'");


        }
        //------------------------------------------------------------------------------------------
        //task2_1
        //public static void Sport(int[]resad,int[]aydan)
        //{
        //    int ResadXal=0;
        //    int AydanXal = 0;

        //    for(int i=0;i<resad.Length;i++)
        //    {
        //        if (resad[i] > aydan[i])
        //        {
        //            ResadXal++;
        //        }
        //        else if (resad[i] < aydan[i])
        //        {
        //            AydanXal++;
        //        }
        //    }
        //    Console.WriteLine($"ResadXal {ResadXal} \n  AydanXal {AydanXal}" );
        //}


        //task2_2

        //public static Players NewPlayers()
        //{
        //    Console.WriteLine( "Oyunchu daxil edin:");
        //    string name = Console.ReadLine();
        //    int[] sport = new int[3];


        //    for(int i=0;i<3;i++)
        //    {
        //        Console.WriteLine($"Playerin {i + 1} xalini daxil edin:");
        //    restart:
        //        if (int.TryParse(Console.ReadLine(),out int Xal))
        //        {
        //            if(Xal>=0&&Xal<=100)
        //            {
        //                sport[i] = Xal;
        //            }
        //            else
        //            {
        //                Console.WriteLine( "Duzgun Xal qeyd edin");
        //                goto restart;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine( "yalnis melumat");
        //            goto restart;
        //        }
        //    }return new(name, sport[0], sport[1], sport[2]);
        //}


        //public static void PlayersScores(Players player1, Players player2)
        //{
        //    int[] player1points = { player1.sport1, player1.sport2, player1.sport3 };
        //    int[] player2points = { player2.sport1, player2.sport2, player2.sport3 };
        //    int score1 = 0;
        //    int score2 = 0;
        //    for(int i=0;i<player1points.Length;i++)
        //    {
        //        if (player1points[i]> player2points[i])
        //        {
        //            score1++;
        //        }
        //        else if (player1points[i]< player2points[i])
        //        {
        //            score2++;
        //        }
        //    }
        //    Console.WriteLine($"player1 {score1 }\n player2 {score2}");
        //}


        //task3

        //task4

        static string CustomTrimStart(string input, char space = ' ')
        {
            int startIndex = 0;
            string newtext = "";

            while (startIndex < input.Length && input[startIndex] == space)
            {
                startIndex++;
            }

            for (int i = startIndex; i < input.Length; i++)
            {
                newtext += input[i];
            }
            return newtext;
        }

        static string CustomTrimEnd(string input, char space = ' ')
        {
            int last = input.Length - 1;
            string newtext = "";

            while (last >= 0 && input[last] == space)
            {
                last--;
            }

            for (int i = 0; i <= last; i++)
            {
                newtext += input[i];
            }
            return newtext;
        }

        public static string CustomTrim(string input, char space = ' ')
        {
            string newtext = CustomTrimStart(input, space);
            newtext = CustomTrimEnd(newtext, space);
            return newtext;
        }






    }//-------------------------------------------------------------------------------------------------
    //task2_2

    //class Players
    //{
    //    public string name;
    //    public int sport1;
    //    public int sport2;
    //    public int sport3;
    //    public int  totalScore;



    //    public Players (string name, int sport1, int sport2, int sport3)
    //    {
    //        this.name = name;
    //        this.sport1 = sport1;
    //        this.sport2 = sport2;
    //        this.sport3 = sport3;
    //        this.totalScore = 0;

    //    }
    //}


    //task1
    //class Student
    //{
    //    public string name;
    //    public string surname;
    //    public string group;
    //    public int point;
    //    public bool isGraduated;

    //    public Student(string name, string surname, string group, int point)
    //    {
    //        this.name = name;
    //        this.surname = surname;
    //        this.group = group;
    //        this.point = point;
    //        this.isGraduated = point >= 65;
    //    }
    //    public void GetInfo()
    //    {
    //        Console.WriteLine($"{name} {surname} {group} {point} {isGraduated}");
    //    }
    //    public void CheckGraduation()
    //    {
    //        if(isGraduated)
    //        {
    //            Console.WriteLine("telebe mezun olub");
    //        }
    //        else
    //        {
    //            Console.WriteLine( "Mezun olmayib");
    //        }
    //    }
    //    public void GetDiplomDegree()
    //    {
    //        if(point<65&&point>0)
    //        {
    //            Console.WriteLine("Diplomu yoxdur");
    //        }
    //        else if(point>=65&&point<80)
    //        {
    //            Console.WriteLine("Adi diplomu var");
    //        }
    //        else if (point >= 80 && point < 90)
    //        {
    //            Console.WriteLine("Sheref diplomu var");
    //        }
    //        else if (point >= 90 && point <=100)
    //        {
    //            Console.WriteLine("Yuksek sheref diplomu var");
    //        }
    //    }
    //}









































































}