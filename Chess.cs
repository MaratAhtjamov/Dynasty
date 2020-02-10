using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using System.IO;

public class Chess : MonoBehaviour
{
    public GameObject[] But = new GameObject[12];
    public DateTime dat0, dat, time11, time22, clock0;
    public TimeSpan time1, time2;
    public char CheiHod = ' ';
    public GameObject Panel, Input, Panel1, InpPos, Time1, Time2;
    public static int KodGame, KodGame2, Iam;
    public static string BeginPosition, txtConnect, txtConnect2, Player1, Player2;
    public GameObject KLON;
    public static GameObject[,] AAA = new GameObject[9, 9];
    public static GameObject[,] BBB = new GameObject[10, 9];
    public Transform thisCanvas;
    public string Pos, PosPast, str, str0, str8, TXT, SSSmesage, drv;
    public int ETAP, MIN, X, Y, a, AA, b, M, N, R, J1, x1, y1, x2, y2, POVTOR, MAX, BB, Limit, Limit0, Part, KF, OPAS;
    public char MyColor;
    public float X0, X1, Y0, Y1, X2, Y2;
    public string[] PART = new string[19];
    public static char[,] BOARD = new char[9, 9];
    public char[,] LAST = new char[9, 9];
    public static int[] Jmax = new int[2];
    public static Color32 Blaky = new Color32(90, 50, 50, 255);
    public static Color32 Blaky0 = new Color32(90, 50, 50, 55);
    public static bool REVERS, Avto, WhiteH, BlackH, zap, shah;
    public static int GlobalX, GlobalY, GlobalETAP;
    public static string GlobalZ;
    public GameObject TextStatus;
    public GameObject TextResult;
    public GameObject TextComment, TextParty, TextBug;
    public GameObject PanelA;
    public List<string> QRNB = new List<string>();
    public static List<List<string>> NABOR = new List<List<string>>();

    public List<string> BAD = new List<string>();
    public List<string> MyList = new List<string>();
    public List<int> BAL = new List<int>();
    public List<int> LEV = new List<int>();
    // public List<string> MyList2 = new List<string>();

    public string SSS, hod, Besthod;
    public int tt;
    public static int ttt, glub;
    public List<string> Drevo = new List<string>();
    public List<string> Party = new List<string>();
    public List<string> PartyPov = new List<string>();
    public List<string> PartyPov0 = new List<string>();
    public List<string> Hods = new List<string>();
    // Use this for initialization
    void Start()
    {
        NABOR.Add(new List<string> { }); NABOR.Add(new List<string> { }); NABOR.Add(new List<string> { }); NABOR.Add(new List<string> { });
        NABOR.Add(new List<string> { }); NABOR.Add(new List<string> { }); NABOR.Add(new List<string> { }); ;// инициализация

        Chess.Player1 = ""; Chess.Player2 = "";
        for (int i = 0; i <= 8; i++)
            for (int j = 0; j <= 8; j++)
            {

                AAA[i, j] = Instantiate(KLON, KLON.transform.position, Quaternion.identity);
                AAA[i, j].transform.SetParent(thisCanvas);
                AAA[i, j].GetComponent<Pole>().x = i;
                AAA[i, j].GetComponent<Pole>().y = j;
                AAA[i, j].transform.localScale = new Vector3(1f, 1f, 0.0f);

                var x = KLON.transform.position.x + 60 * i;
                var y = KLON.transform.position.y + 60 * j;

                AAA[i, j].transform.position = new Vector3(x, y, 0);
                /////    AAA[i, j].GetComponentInChildren<Text>().text = i + " " + j;
                if (Mathf.Repeat(i + j, 2) != 0) AAA[i, j].GetComponent<Image>().color = new Color32(236, 255, 255, 255);

                if (i == 0)
                {
                    AAA[i, j].GetComponentInChildren<Text>().text = j.ToString();
                    AAA[i, j].GetComponent<Image>().color = new Color32(236, 255, 255, 0);
                };
                if (j == 0)
                {
                    char s = Convert.ToChar(96 + i);
                    char[] c = { s };

                    AAA[i, j].GetComponentInChildren<Text>().text = new string(c);
                    AAA[i, j].GetComponent<Image>().color = new Color32(236, 255, 255, 0);
                };
            }
        for (int i = 0; i <= 9; i++)
            for (int j = 0; j <= 8; j++)
            {

                BBB[i, j] = Instantiate(KLON, KLON.transform.position, Quaternion.identity);
                BBB[i, j].transform.SetParent(thisCanvas);
                BBB[i, j].GetComponent<Pole>().x = i;
                BBB[i, j].GetComponent<Pole>().y = j; ;
                BBB[i, j].transform.localScale = new Vector3(1f, 1f, 0.0f);

                var x = KLON.transform.position.x + 60 * i;
                var y = KLON.transform.position.y + 60 * j;

                BBB[i, j].transform.position = new Vector3(x, y, 0);
                /////    AAA[i, j].GetComponentInChildren<Text>().text = i + " " + j;
                BBB[i, j].GetComponent<Image>().color = new Color32(255, 255, 255, 0);

            }




        KLON.SetActive(false);
        BeginPosition = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        // BeginPosition = "r1bqk1nr/p2p1ppp/1pp5/n3p3/1P2P3/P1PB4/2P2PPP/R1BQK1NR b KQkq b3 0 8";
        //   BeginPosition = "2k1r3/p4p1p/bpp5/3r2Pn/PP6/2P2P1N/2P4P/R1B1K2R w KQ - 1 20";
        Pos = BeginPosition;

        //  Pos = "r2qk2r/pp3ppp/2b1p3/8/2B3n1/2NQP3/PP3PP1/R1BR2K1 b - - 1 16";
        //Party.Add( Pos);

        PART[0] = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        PART[1] = "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1";
        PART[2] = "rnbqkbnr/ppp1pppp/8/3p4/4P3/8/PPPP1PPP/RNBQKBNR w KQkq d6 0 2";
        PART[3] = "rnbqkbnr/ppp1pppp/8/3p4/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 1 2";
        PART[4] = "rnbq1bnr/pppkpppp/8/3p4/4P3/5N2/PPPP1PPP/RNBQKB1R w KQ - 2 3";
        PART[5] = "rnbq1bnr/pppkpppp/8/3p4/4P3/5N2/PPPPBPPP/RNBQK11R b KQ - 2 4";
        PART[6] = "rnbq1bnr/1ppkpppp/p7/3p4/4P3/5N2/PPPPBPPP/RNBQK11R w KQ - 2 5";
        PART[7] = "rnbq1bnr/1ppkpppp/1p6/3p4/4P3/5N2/PPPPBPPP/RNBQ1RK1 b KQ - 2 6";
        PART[8] = "rnbq1bnr/1ppk1ppp/p7/3pp3/4P3/5N2/PPPPBPPP/RNBQ1RK1 w KQ - 2 7";
        /* PART[1] = "rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1";
         PART[2] = "rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 1";
         PART[3] = "rnbqkbnr/ppp1pppp/8/3p4/3P4/3Q4/PPP1PPPP/RNB1KBNR b KQkq - 0 1";
         PART[4] = "rnb1kbnr/ppp1pppp/3q4/3p4/3P4/3Q4/PPP1PPPP/RNB1KBNR w KQkq - 0 1";
         PART[5] = "rnb1kbnr/ppp1pppp/3q4/3p4/3P4/2NQ4/PPP1PPPP/R1B1KBNR b KQkq d6 0 1";
         PART[6] = "r1b1kbnr/ppp1pppp/2nq4/3p4/3P4/2NQ4/PPP1PPPP/R1B1KBNR w KQkq d6 0 1";
         PART[7] = "r1b1kbnr/ppp1pppp/2nq4/3p4/3P4/2NQ4/PPPBPPPP/R3KBNR b KQkq d6 0 1";
         PART[8] = "r3kbnr/pppbpppp/2nq4/3p4/3P4/2NQ4/PPPBPPPP/R3KBNR b KQkq d6 0 1";
         PART[9] = "r3kbnr/pppbpppp/2nq4/3p4/3P4/2NQ4/PPPBPPPP/2KR1BNR b KQkq d6 0 1";*/
        PART[10] = "2kr1bnr/pppbpppp/2nq4/3p4/3P4/2NQ4/PPPBPPPP/2KR1BNR b KQkq d6 0 1";
        PART[10] = "8/8/6Q1/3rk3/8/3B4/3K4/8 w - - 0 1";

        ETAP = 100; TextStatus.GetComponent<Text>().text = Left( Left("Kc4:d3ep", 8) + (12),10);
        a = 0; AA = 100; Avto = true;
        REVERS = false;
        /// REVERS = true;
       /* var boa = BoardLoad(BeginPosition);
        var pp = HOD_F(boa, " e2-e4 ");
        var tt = BoardSave(pp);
        TextStatus.GetComponent<Text>().text = tt;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (ETAP == 0)
        {



            StopAllCoroutines();
            KodGame = 0; KodGame2 = 0; Player2 = ""; SSSmesage = ""; Iam = 0;

            ETAP = 1;
        }
        if (ETAP == 1)
        {
            var ZHDUN = "";
            Panel.SetActive(true);
            Panel.transform.SetAsLastSibling();
            //TextStatus.GetComponent<Text>().text = "Iam=" + Iam + "{1}" + txtConnect + "{2}" ;
            TextStatus.GetComponent<Text>().text = "Iam=" + Iam + "{1}" + txtConnect + "{2}" + txtConnect2;
            if (KodGame > 0 && Iam == 1)
            {
                ZHDUN += "."; if (ZHDUN.Length > 500) ZHDUN = "";
                TextStatus.GetComponent<Text>().text = "Ждите создания игры" + ZHDUN;
                Chess.txtConnect = "https://crown.alabuga.ru/img/111.php?act=SELECT Player1 FROM `MP` WHERE ID=" + Chess.KodGame;
                StartCoroutine(GetRequest(Chess.txtConnect));
                if (SSSmesage != "")
                {

                    TextStatus.GetComponent<Text>().text = "Игра создана. Код " + KodGame + ". Ждите подключения" + SSSmesage;
                    TextResult.GetComponent<Text>().text = "Игра создана. Код " + KodGame + ". Ждите подключения:" + SSSmesage;
                    Panel.SetActive(false);
                    StopAllCoroutines();
                    ETAP = 5; SSSmesage = "";
                }

            }
            if (Chess.Player2 != "" && Iam == 2)
            {
                ZHDUN += "."; if (ZHDUN.Length > 500) ZHDUN = "";
                TextStatus.GetComponent<Text>().text = "Ждите подключения к игре" + ZHDUN;

                // Chess.txtConnect = "https://crown.alabuga.ru/img/111.php?act=SELECT Player2 FROM `MP` WHERE ID=" + Chess.KodGame2;
                // StartCoroutine(GetRequest(Chess.txtConnect));
                Chess.txtConnect = "https://crown.alabuga.ru/img/2_UPDATE.php?act=SET `Player2`= \"" + Chess.Player1 + "\" WHERE ID=" + Chess.KodGame2 + " AND `Player2`= \"\" ";
                StartCoroutine(GetRequest(Chess.txtConnect));


                if (SSSmesage == "Готово")
                {
                    SSSmesage = "";
                    TextStatus.GetComponent<Text>().text = "Вы присединились к игре " + KodGame2 + ". Ждите подключения";
                    Panel.SetActive(false);
                    /// StopAllCoroutines();
                    ETAP = 6;
                }
            }
        }

        if (ETAP == 5)////Ждать второго
        {
            Chess.txtConnect = "https://crown.alabuga.ru/img/111.php?act=SELECT Player2 FROM `MP` WHERE ID=" + Chess.KodGame;
            StartCoroutine(GetRequest(Chess.txtConnect));
            if (SSSmesage != "")
            {
                Player2 = SSSmesage;
                TextStatus.GetComponent<Text>().text = Player1 + ", Вы начинаете игру с " + SSSmesage; ETAP = 7; Iam = 1; StopAllCoroutines();
                REVERS = false; MyColor = 'w';
                BOARD = BoardLoad(BeginPosition); Board();
            }
        }
        if (ETAP == 6)////второму получить имя и позицию Инициатора игры
        {

            Chess.txtConnect = "https://crown.alabuga.ru/img/111.php?act=SELECT Player1 FROM `MP` WHERE ID=" + Chess.KodGame2;
            StartCoroutine(GetRequest(Chess.txtConnect));
            if (SSSmesage != "" && SSSmesage != "Готово")
            {
                Player1 = SSSmesage; KodGame = KodGame2;
                TextStatus.GetComponent<Text>().text = Player2 + ", Вы начинаете игру с " + SSSmesage; ETAP = 7; Iam = 2; ; StopAllCoroutines();
                REVERS = true; MyColor = 'b';
                BOARD = BoardLoad(BeginPosition); Board();
            }
            if (SSSmesage == "Error")
            {
                ////Player1 = SSSmesage;
                TextResult.GetComponent<Text>().text = Player2 + ", игра с кодом" + KodGame2 + " уже началась либо код введен неверно";

                ETAP = 0; Chess.Player1 = Chess.Player2; Chess.Player2 = "";
                KodGame = 0;
            }
        }
        if (ETAP == 7)
        {


            TextResult.GetComponent<Text>().text = a + " REVERS=" + REVERS + " / ETAP=" + ETAP + "/Iam" + Iam + "/MyColor=" + MyColor + "/Pos=" + Pos;
            a += 1;
            if (a > 50)
            {
                LoadPos(); a = 0;
                SSS = "";
                if (MyColor == 'w' && Iam == 1) SSS += "Белые " + Player1 + ": Черные " + Player2;
                if (MyColor == 'w' && Iam == 2) SSS += "Белые " + Player2 + ": Черные " + Player1;
                if (MyColor == 'b' && Iam == 1) SSS += "Белые " + Player2 + ": Черные " + Player1;
                if (MyColor == 'b' && Iam == 2) SSS += "Белые " + Player1 + ": Черные " + Player2;

                TextComment.GetComponent<Text>().text = SSS;
            }
            if (PosPast != Pos)
            {
                if ((Pos.Contains(" w ") && MyColor == 'w' && Iam != 0) ||
                (Pos.Contains(" b ") && MyColor == 'b' && Iam != 0))
                {

                    TextStatus.GetComponent<Text>().text = Pos + " Iam=" + Iam;
                    ETAP = 10;
                    PosPast = Pos;
                }
            }

            ///// if (KodGame == 0) ETAP = 10;
        }
        if (ETAP == 10)/////обрисовка доски и пространство вариантов
        { Panel1.SetActive(false);
            PanelA.SetActive(false);
            Panel.SetActive(false);
            BOARD = BoardLoad(Pos); Board();
            CheiHod = BOARD[0, 0];
            Tablo();

            InpPos.GetComponent<InputField>().text = Pos;


            /// Party.Add(Pos);

            /*    var dr = Draw(Pos);
                if (dr != "")
                {
                    TextComment.GetComponent<Text>().text = dr;
                    ETAP = 60;
                }
                else
                {*/

            AA = 15;
            //MyList = Variants(Pos, 1);
            var pb = BoardLoad(Pos);
            MyList = VariantsBOAR(pb);
            TextBug.GetComponent<Text>().text = BalSil(pb) + "/" + BalansF(Pos);
            M = MyList.Count;
            if (M == 0) ///нет ходов
            {

                if (BOARD[0, 0] == 'w')
                {
                    if (PodSHAH(Pos, -1) > 0) SSS = "Белым мат"; else SSS = "Белым ПАТ";
                }
                if (BOARD[0, 0] == 'b')
                {
                    if (PodSHAH(Pos, -1) > 0) SSS = "Черным мат"; else SSS = "Черным ПАТ";
                }
                AAA[0, 0].GetComponentInChildren<Text>().text = SSS;
                /// TextComment.GetComponent<Text>().text = SSS;
                ETAP = 60;
            }
            else
            {
                /*if (BOARD[0, 0] == 'w' && REVERS == false) ETAP = 20;
                 if (BOARD[0, 0] == 'b' && REVERS == false) ETAP = 15;
                 if (BOARD[0, 0] == 'w' && REVERS) ETAP = 20;
                 if (BOARD[0, 0] == 'b' && REVERS) ETAP = 15;*/
                if (WhiteH && BlackH) { ETAP = 20; Avto = false; }
                if (WhiteH == false && BlackH == false) { ETAP = 15; }

                if (WhiteH == false && BlackH && BOARD[0, 0] == 'b') { ETAP = 20; }
                if (WhiteH == false && BlackH && BOARD[0, 0] == 'w') { ETAP = 15; }
                if (WhiteH && BlackH == false && BOARD[0, 0] == 'b') { ETAP = 15; }
                if (WhiteH && BlackH == false && BOARD[0, 0] == 'w') { ETAP = 20; }

                if (Iam != 0) ETAP = 20;
                a = 0;


                /////   TextStatus.GetComponent<Text>().text = ETAP+"";



            }
            // }

        }
        if (ETAP == 15)
        {
            Drevo.Clear();
            dat0 = DateTime.Now;
            dat = dat0; ///TextComment.GetComponent<Text>().text = dat.ToString("hh:mm:ss");
            ////time11 = DateTime.Now; time22 = DateTime.Now;

            var nh = 40 - Hods.Count;
            if (nh <= 0) nh = 60 - Hods.Count;
            if (nh <= 0) nh = 1;
            // if (nh <= 2) dat = dat.AddSeconds(1+ nh * nh * nh );
            // if (nh > 2 ) dat = dat.AddSeconds(CountF(Pos)*100);
            //// var zzz = Convert.ToInt16(time1.ToString("ss"));
            if (CheiHod == 'w') Limit = (time1.Seconds + time1.Minutes * 60 + time1.Hours * 60 * 60) / (30);
            if (CheiHod == 'b') Limit = (time2.Seconds + time2.Minutes * 60 + time2.Hours * 60 * 60) / (30);
            /* if (MyList.Count<=20) Sec = 20 +MyList.Count*2;
             if (MyList.Count > 20 && MyList.Count<=30) Sec = 40 + MyList.Count * 4;
             if (MyList.Count > 30 && MyList.Count <= 40) Sec = 80 + MyList.Count * 8;
             if (MyList.Count > 40) Sec = 160 + MyList.Count * 16;
             /*if (CountF(Pos) >= 10) Sec = 60;
             if (CountF(Pos) >= 20  ) Sec = 90;
             if (CountF(Pos) >= 25 || (nh>15 && nh<40) ) Sec = 120;
             if (CountF(Pos) >=30) Sec = 60;*/
            Limit = Limit * MyList.Count / 40;
            dat = DateTime.Now.AddSeconds(Limit); dat0 = DateTime.Now.AddSeconds(Limit / 3);
            Part = 1;


            //Limit = 30*nh+MyList.Count*50;

            //    if (nh >=60) dat = dat.AddSeconds(nh + CountF(Pos) /2);
            ttt = 0; //dat = dat.AddSeconds(600);
            TextComment.GetComponent<Text>().text = dat0.ToString("hh:mm:ss") + "-" + dat.ToString("hh:mm:ss");
            var B = 0; var MAX = -9999;
            var b1 = 0;
            if (MyList.Count == 1) { hod = MyList[0]; ETAP = 16; } ///"=="
            else
            {
                BAL.Clear(); LEV.Clear(); ///Debug.Log("Ищу мат в 1 ход");
                hod = "";
                //////////////////////// if (Hods.Count<=20) hod = Biblio.Bib(Pos);

                if (hod == "")
                    if ((BOARD[0, 0] == 'w' && BalansF(Pos) > 400) || (BOARD[0, 0] == 'b' && BalansF(Pos) < -400))
                    {
                        var ii = UnityEngine.Random.Range(2, 4);
                        for (int i = 1; i <= ii; i++)//////////поиск мата
                        {
                            BBB[5, 5].GetComponentInChildren<Text>().text = i + " хода";
                            shah = false;
                            var t1 = DateTime.Now.AddMilliseconds(900);
                            ///Debug.Log("Ищу мат в " + i + " ход"); TextComment.GetComponent<Text>().text = "Ищу мат в " + i + " ход";
                            var pb = BoardLoad(Pos);
                            hod = MatBOAR(pb, i);
                            if (hod != "")
                            {
                                TextComment.GetComponent<Text>().text = " мат в " + i + " ход найден," + hod;
                                Debug.Log(" мат в " + i + " ход найден," + hod);
                                break;
                            }
                            if (DateTime.Now > t1) break;
                            ////////  if (shah == false ) break;

                        }
                    }



                if (hod != "") ETAP = 16;
                if (MyList.Count > 1 && ETAP != 16)
                    for (int i = 0; i < MyList.Count; i++)
                    {
                        var h1 = MyList[i];
                        var p1 = HOD(Pos, h1);
                        var pp1 = BoardLoad(p1);
                        b1 = BalSil(pp1);
                        //if (p1.Contains(" w ")) B1 = -b1; else B1 = b1;
                        if (p1.Contains(" w ")) B = -b1; else B = b1;
                        BAL.Add(B); LEV.Add(0);
                        if (B > MAX) { MAX = B; hod = MyList[i]; }
                        
                       //// MyList[i] = Left(MyList[i], 8) + "/0";
                        
                    }
            }

            //   TextStatus.GetComponent<Text>().text = hod + " Уровень "+a + " Оценка " + b1;
            //   if (Pos.Contains("PPPPPPPP") || Pos.Contains("pppppppp"))            ETAP = 16;
            if (ETAP != 16)
            {
                //if (Pos.Contains(" w ")) { Jmax[0] -= 1; if (Jmax[0] < 1) Jmax[0] = 1; J1 = Jmax[0]; }
                //if (Pos.Contains(" b ")) {Jmax[1] -= 1; if (Jmax[1] < 1) Jmax[1] = 1; J1 = Jmax[1]; }
                a = 0; ETAP = 151; KF = 1; J1 = 1; hod = "";
            }
            ///a += 1;

        }
        if (ETAP == 151)
        {

            if (MyList.Count > 1) Poradok();
            Drevo.Clear();
            /* var text = "";
             for (int j = 0; j < PartyPov0.Count; j++) text += PartyPov0[j];
             TextBug.GetComponent<Text>().text = text;*/

            BB = 0; MAX = -999999;
           //////J1 = 1;
            TXT = ""; for (int i = 0; i < MyList.Count; i++) TXT += BAL[i] + " ход " + MyList[i] + "\r\n";
            TextResult.GetComponent<Text>().text = TXT;
            ETAP = 152;

            a = 0; Poradok();



            ///
            if (MyList.Count < 2) { hod = MyList[0]; ETAP = 16; }///выход, если остался один вариант хода
        }
        if (ETAP == 152)
        {
            Tablo();
            ///  if (a > 2 || a >= MyList.Count) { a = 0; Poradok(); }

           /* a = 0;
            if (a + 1 < MyList.Count)
            {
                if (LEV[a]>LEV[a+1]+2) { a = a + 1; } else a = 0;
            }
            
           LEV[a] += 1; J1 = LEV[a];//Debug.Log(a);*/

            var h1 = MyList[a];
            Board();

            if (hod != "") { MarkRed(hod[4] - 96, hod[5] - 48); MarkOran(hod[1] - 96, hod[2] - 48); }
            Mark(MyList[a][1] - 96, MyList[a][2] - 48);
            MarkGre(MyList[a][4] - 96, MyList[a][5] - 48);
            glub = 0; ////LEV[a] += 1; J1 = LEV[a];
                      //BB = Ocenka(Pos, h1, J1);

             var p1 = HOD(Pos, h1);            var h2 = "";
                        var t1 = DateTime.Now.AddSeconds(3);
             var pp1 = BoardLoad(p1);
           /////  OPAS = 0; b = BalSil(pp1); if (OPAS<=0) TextComment.GetComponentInChildren<Text>().color = new Color32(255, 55, 55, 255); else TextComment.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255); ;
             h2 = BestRR("", pp1, 0, J1, OPAS);
            //h2 = BestR("", p1, 0, J1);
            if (DateTime.Now > dat) LEV[a] -= 1;
            else
            {



                b = Convert.ToInt32(Right(h2, 5));
                //  b = Ocenka(Pos, a, J1);
                MyList[a] += "   " + LEV[a] + Left(h2, 6);

                if (Pos.Contains(" b ")) BB = -b; else BB = b;




                AAA[4, 0].GetComponentInChildren<Text>().text = "d \r\n " + CountF(Pos) + "";

                if (MyList[a].Contains("Ke1-g1")) BB += 50; if (MyList[a].Contains("Ke1-c1")) BB += 50;
                if (MyList[a].Contains("Ke8-g8")) BB += 50; if (MyList[a].Contains("Ke8-c8")) BB += 50;
                if (CountF(Pos) > 25)///дебют
                {

                    if (MyList[a].Contains("Ke1-")) BB -= 25;
                    if (MyList[a].Contains("Ke8-")) BB -= 25;
                    if (MyList[a].Contains("Ra1-")) BB -= 25; if (MyList[a].Contains("Ra1-b1")) BB -= 25;
                    if (MyList[a].Contains("Ra8-")) BB -= 25; if (MyList[a].Contains("Ra8-b8")) BB -= 25;
                    if (MyList[a].Contains("Rh1-")) BB -= 25; if (MyList[a].Contains("Rh1-g1")) BB -= 25;
                    if (MyList[a].Contains("Rh8-")) BB -= 25; if (MyList[a].Contains("Rh8-g8")) BB -= 25;
                    if (MyList[a].Contains("Qd1-")) BB -= 25;
                    if (MyList[a].Contains("Qd8-")) BB -= 25;
                    if (MyList[a].Contains("e2-e4")) BB += 15; if (MyList[a].Contains("e7-e5")) BB += 15;
                    if (MyList[a].Contains("d2-d4")) BB += 15; if (MyList[a].Contains("d7-d5")) BB += 15;
                    if (MyList[a].Contains("c2-c4")) BB += 5; if (MyList[a].Contains("c7-c5")) BB += 5;
                    if (MyList[a].Contains("a2-a4")) BB -= 15; if (MyList[a].Contains("a7-a5")) BB -= 15;
                    if (MyList[a].Contains("h2-h4")) BB -= 15; if (MyList[a].Contains("h7-h5")) BB -= 15; if (MyList[a].Contains("h7-h5") && p1.Contains("kq")) BB -= 115;
                    if (MyList[a].Contains("g2-g4")) BB -= 25; if (MyList[a].Contains("g7-g5")) BB -= 25; if (MyList[a].Contains("g7-g5") && p1.Contains("kq")) BB -= 125;
                    if (MyList[a].Contains("Nb1-a3")) BB += -50; if (MyList[a].Contains("Nb8-a6")) BB += -50;
                    if (MyList[a].Contains("Ng1-h3")) BB += -50; if (MyList[a].Contains("Ng8-h6")) BB += -50;
                    // if (MyList[a].Contains("Bc1-b2")) BB += 10; if (MyList[a].Contains("Bc8-b7")) BB += 10;
                    // if (MyList[a].Contains("Bf1-g2")) BB += 10; if (MyList[a].Contains("Bf8-g7")) BB += 10 ;
                }
                if (CountF(Pos) < 10)//эндшпиль
                {
                    var h = MyList[a]; var n = h[2] - 48;
                    if (p1.Contains(" w ")) n = 9 - n;
                    if (h[0] == ' ') BB += 10 * n;
                    if (h[0] == ' ') BB += 10 * n;
                }

                if (DateTime.Now < dat)
                {
                    BAL[a] = BB; if (BAL[a] > MAX) { MAX = BAL[a]; hod = MyList[a]; }
                }





                var pr = MyList.Count / 100f; var proc = 0;
                ///SSS = MyList.Count + "";

                if (MyList.Count > 0) proc = Mathf.FloorToInt((a + 1) / pr);
                TextComment.GetComponent<Text>().text = proc + "% {" + (a + 1) + " из " + (MyList.Count) + "}" + MyList[a] + " gl=" + glub + "Limit =" + Limit + " ttt=" + ttt;
                /// + " BB= " + BB + "(" + hod + ")" + "\r\n ";

                TextStatus.GetComponent<Text>().text = hod + " Уровень " + J1 + " парт=" + Part + " KF=" + KF + " Оценка " + MAX + " время " + DateTime.Now + "\r\n Осталось " + (dat - DateTime.Now) + "\r\n ttt=" + ttt;
                TXT = "[" + hod + "] \r\n"; for (int i = 0; i < MyList.Count; i++) TXT += (i + 1) + ":" + BAL[i] + " ход " + MyList[i] + "\r\n";
                TextResult.GetComponent<Text>().text = TXT;

                //////////// if (BAL[a] >= 9990) { hod = MyList[a]; ETAP = 16; }
            }
           a += 1;
           //Poradok(); hod = MyList[0];
            if (MyList.Count < 2) { hod = MyList[0]; ETAP = 16; }///выход, если остался один вариант хода
            if (ETAP != 16)
            {
                if (Part == 1)
                    if (a >= MyList.Count /**/|| DateTime.Now > dat/**/)
                    {
                        if (DateTime.Now > dat0)
                        {
                            if (J1<4 || MyList.Count>3)  ETAP = 155; 
                            else
                            {
                                Poradok();
                                hod = MyList[0];
                                /*  var mx = 0; for (int i = 0; i < MyList.Count; i++) if (LEV[i]>mx) {  mx = LEV[i]; }
                                  for (int i = 0; i < MyList.Count; i++) if (LEV[i] == mx) { hod = MyList[i]; break; } */
                                ETAP = 16;
                            }
                            
                        }
                        else
                        {
                            ///if (DateTime.Now > dat) KF += 1;
                            J1 += 1; a = 0; ETAP = 151;
                            //if (MyList.Count < 2) { hod = MyList[0]; ETAP = 16; }///выход, если остался один вариант хода
                            ///if (DateTime.Now > dat0) ETAP = 155;
                        }
                        /// dat0 = DateTime.Now;
                    }
                  if (Part == 2)
                     if (a >= MyList.Count /**/|| DateTime.Now > dat/**/)
                    {
                     //   J1 += 1; a = 0; ETAP = 151; KF += 1;
                                                  // if (MyList.Count < 2) { hod = MyList[0]; ETAP = 16; }///выход, если остался один вариант хода
                     //       if (DateTime.Now > dat0)
                            ETAP = 16;
                    }
            }
            /* if (ETAP != 16)
             {
                 a = 0; ETAP = 151;
                 if ( DateTime.Now > dat)
                 {
                 Poradok();        hod = MyList[0];
                 ETAP = 16;

                 }
             }*/


        }

          if (ETAP == 155)
          {
            ////  Poradok();
            var s = 0; var n = 0;
              n = MyList.Count;

            if (a == 0) a += 1;
                  for (int i = a; i < n; i++) { MyList[i] = "" + i; BAL[i] = -99999; }
                  for (int i = a; i < n; i++) { MyList.Remove("" + i); BAL.Remove(-99999); }

              

              if (n > 1)
              {
                  ETAP = 151;  Part = 2;a = 0; dat = DateTime.Now.AddSeconds(Limit); dat0 = DateTime.Now.AddSeconds(Limit/3);
                  ///if (n > 7) J1 -= 1;
              } else { hod = MyList[0]; ETAP = 16; }





                  TextStatus.GetComponent<Text>().text = hod + " Уровень " + J1 + " Part=" + Part+" вариантов "+ MyList.Count;
                  TXT = "[" + hod + "] \r\n"; for (int i = 0; i < MyList.Count; i++) TXT += (i + 1) + "_" + BAL[i] + " ход " + MyList[i] + "\r\n";
                  TextResult.GetComponent<Text>().text = TXT;

          }

        if (ETAP == 16)
        {
            //if (Pos.Contains(" w ")) { Jmax[0] = J1; }
            //if (Pos.Contains(" b ")) { Jmax[1] = J1; }

            Board(); if (hod != "") { MarkRed(hod[4] - 96, hod[5] - 48); MarkOran(hod[1] - 96, hod[2] - 48); }
            TXT = "[" + hod + "] \r\n";

            if (BAL.Count == MyList.Count) for (int i = 0; i < MyList.Count; i++) TXT += (i + 1) + ":" + BAL[i] + " ход " + MyList[i] + "\r\n";
            TextResult.GetComponent<Text>().text = TXT;
            /* var mx = -999;
              R = UnityEngine.Random.Range(0, M - 1); if (R > M) R = M - 1;
              hod = MyList[R];
             var s = 0; var b = 0;*/
            //  if (POVTOR == 0 && Avto)

            //   var hh = "";
            // if (Pos.Contains(" w ")) time1 +=  DateTime.Now - time11;
            // if (Pos.Contains(" b ")) time2 +=  DateTime.Now - time22;

            //  var dat = DateTime.Now; /////.ToString("hh:mm:ss");




            Besthod = Left(hod, 12);
            // var p1 = HOD(Pos, hod);
            /* var h1 = ""; 
             if (J1-1>=0) { h1 = BestR("", p1, 0, J1 - 1, true); Besthod += "/1/" + Left(h1, 12);  }
             if (J1 - 2 >= 0) {  p1 = HOD(p1, h1); h1 = BestR("", p1, 0, J1 - 2, true); Besthod +="/2/"+ Left(h1, 12);  }
             if (J1 - 3 >= 0) { p1 = HOD(p1, h1); h1 = BestR("", p1, 0, J1 - 3, true); Besthod += "/3/" + Left(h1, 12);  }*/
            hod = Left(hod, 12);



            var dat2 = DateTime.Now - dat0;
            SSS += Besthod + "/ С " + dat.ToString("hh:mm:ss") + " по " + DateTime.Now.ToString("hh:mm:ss") + " прошло " + dat2.ToString() + SSS; // "hh:mm:ss", DateTimeFormatInfo.InvariantInfo);

            //  for (int i = 0; i <= 4; i++) SSS+=i+".("+NABOR[i].Count+")";
            SSS += " glub=" + glub + ", t=" + ttt + ", povtor=" + POVTOR;
            TextComment.GetComponent<Text>().text = SSS;
            TextStatus.GetComponent<Text>().text = Besthod;




            if (Avto) ETAP = 30; else ETAP = 20;


            a = 0;
        }
        if (ETAP == 20)/////ВЫБОР ХОДА из пространства вариантов
        {
            Tablo();

            if (zap) { zap = false; StartCoroutine(Zapis()); Pos = BeginPosition; Party.Clear(); Hods.Clear(); ETAP = 100; }
            if (GlobalETAP == 100) ETAP = 100;

            if (a == 0)//inicializacia
            {
                BBB[2, 8].GetComponentInChildren<Text>().text = "";
                BBB[6, 8].GetComponentInChildren<Text>().text = "";
                BBB[2, 1].GetComponentInChildren<Text>().text = "";
                BBB[6, 1].GetComponentInChildren<Text>().text = "";
                BBB[7, 1].GetComponentInChildren<Text>().text = "";
                BBB[3, 1].GetComponentInChildren<Text>().text = "";
                BBB[7, 8].GetComponentInChildren<Text>().text = "";
                BBB[3, 8].GetComponentInChildren<Text>().text = "";
                for (int i = 0; i < MyList.Count; i++)
                {
                    var p = MyList[i];
                    if (REVERS)
                    {
                        if (p.Contains("Ke1-g1")) BBB[2, 8].GetComponentInChildren<Text>().text = "Castle Роки- ровка";
                        if (p.Contains("Ke1-c1")) BBB[6, 8].GetComponentInChildren<Text>().text = "Castle Роки- ровка";
                        if (p.Contains("Ke8-g8")) { BBB[2, 1].GetComponentInChildren<Text>().text = "Castle Роки-ровка"; BBB[2, 1].GetComponentInChildren<Text>().color = Blaky; }
                        if (p.Contains("Ke8-c8")) { BBB[6, 1].GetComponentInChildren<Text>().text = "castling"; BBB[6, 1].GetComponentInChildren<Text>().color = Blaky; }
                    } else
                    {
                        if (p.Contains("Ke1-g1")) BBB[7, 1].GetComponentInChildren<Text>().text = "Castle Роки- ровка";
                        if (p.Contains("Ke1-c1")) BBB[3, 1].GetComponentInChildren<Text>().text = "Castle Роки- ровка";
                        if (p.Contains("Ke8-g8")) { BBB[7, 8].GetComponentInChildren<Text>().text = "Castle Роки- ровка"; BBB[7, 8].GetComponentInChildren<Text>().color = Blaky; }
                        if (p.Contains("Ke8-c8")) { BBB[3, 8].GetComponentInChildren<Text>().text = "Castle Роки- ровка"; BBB[3, 8].GetComponentInChildren<Text>().color = Blaky; }
                    }
                }
                ////   TextComment.GetComponent<Text>().text = "ВАШ ХОД";
                GlobalX = 0; GlobalY = 0;
                a = 1;
                x1 = 0; y1 = 0; x2 = 0; y2 = 0;

            }
            if (a == 1)///ozhidanie
            {
                if (GlobalX != 0 && x1 == 0) ///1 пункт
                {
                    ///x1 = GlobalX; y1 = GlobalY;
                    if (REVERS) { x1 = 9 - GlobalX; y1 = 9 - GlobalY; } else { x1 = GlobalX; y1 = GlobalY; }
                    hod = "";
                    for (int i = 0; i < MyList.Count; i++)
                        if (x1 == MyList[i][1] - 96 && y1 == MyList[i][2] - 48)
                        {
                            hod = MyList[i]; Mark(x1, y1);

                            MarkGre(MyList[i][4] - 96, MyList[i][5] - 48);

                        } else
                        {
                            if (MyList[i].Contains("Ke1-g1") && x1 == 7 && y1 == 1) { hod = MyList[i]; a = 0; ETAP = 30; }
                            if (MyList[i].Contains("Ke1-c1") && x1 == 3 && y1 == 1) { hod = MyList[i]; a = 0; ETAP = 30; }
                            if (MyList[i].Contains("Ke8-g8") && x1 == 7 && y1 == 8) { hod = MyList[i]; a = 0; ETAP = 30; }
                            if (MyList[i].Contains("Ke8-c8") && x1 == 3 && y1 == 8) { hod = MyList[i]; a = 0; ETAP = 30; }
                        }

                    if (hod == "") { x1 = 0; y1 = 0; x2 = 0; y2 = 0; }

                    GlobalX = 0; GlobalY = 0;
                }
                if (GlobalX != 0 && x1 != 0)///2 пункт
                {
                    if (REVERS) { x2 = 9 - GlobalX; y2 = 9 - GlobalY; } else { x2 = GlobalX; y2 = GlobalY; }
                    QRNB.Clear();
                    hod = "";
                    for (int i = 0; i < MyList.Count; i++)
                        if ((x1 == MyList[i][1] - 96 && y1 == MyList[i][2] - 48) &&
                            (x2 == MyList[i][4] - 96 && y2 == MyList[i][5] - 48))
                        {
                            hod = MyList[i] + " "; Mark(x1, y1);
                            if (hod[6] == 'Q' || hod[6] == 'R' || hod[6] == 'B' || hod[6] == 'N')////если превращение
                            { a = 2; QRNB.Add(hod); }
                        };
                    if (hod == "") { x1 = 0; y1 = 0; x2 = 0; y2 = 0; Board(); };
                    if (hod != "" && a == 1) { x1 = 0; y1 = 0; x2 = 0; y2 = 0; Board(); a = 0; ETAP = 30; }; ///ход выбран
                    GlobalX = 0; GlobalY = 0;
                }
            }
            if (a == 2)///выбор фигуры превращения
            {


                if (Pos.Contains(" w ") && REVERS == false) { Figura(0, 8, 'Q'); Figura(0, 7, 'R'); Figura(0, 6, 'N'); Figura(0, 5, 'B'); }
                if (Pos.Contains(" b ") && REVERS == false) { Figura(0, 1, 'q'); Figura(0, 2, 'r'); Figura(0, 3, 'n'); Figura(0, 4, 'b'); }
                if (Pos.Contains(" w ") && REVERS) { Figura(0, 1, 'Q'); Figura(0, 2, 'R'); Figura(0, 3, 'N'); Figura(0, 4, 'B'); }
                if (Pos.Contains(" b ") && REVERS) { Figura(0, 8, 'q'); Figura(0, 7, 'r'); Figura(0, 6, 'n'); Figura(0, 5, 'b'); }



                ////   if (REVERS) { y = 9 - GlobalY; x = GlobalX; } else { y = GlobalY; x = GlobalX; }
                if (GlobalX == 0 && GlobalY != 0)
                {

                    for (int i = 0; i < QRNB.Count; i++)
                    {
                        if (REVERS && Pos.Contains(" b ") || (REVERS == false && Pos.Contains(" w ")))
                        {
                            if (GlobalY == 8 && QRNB[i].Contains("Q")) hod = QRNB[i];
                            if (GlobalY == 7 && QRNB[i].Contains("R")) hod = QRNB[i];
                            if (GlobalY == 6 && QRNB[i].Contains("N")) hod = QRNB[i];
                            if (GlobalY == 5 && QRNB[i].Contains("B")) hod = QRNB[i];
                        }
                        if (REVERS && Pos.Contains(" w ") || (REVERS == false && Pos.Contains(" b ")))
                        {
                            if (GlobalY == 1 && QRNB[i].Contains("Q")) hod = QRNB[i];
                            if (GlobalY == 2 && QRNB[i].Contains("R")) hod = QRNB[i];
                            if (GlobalY == 3 && QRNB[i].Contains("N")) hod = QRNB[i];
                            if (GlobalY == 4 && QRNB[i].Contains("B")) hod = QRNB[i];
                        }


                        x1 = 0; y1 = 0; x2 = 0; y2 = 0; Board(); a = 0; ETAP = 30; ; ///ход выбран
                        for (int j = 1; j <= 8; j++) Figura(0, j, ' ');

                    }
                }
            }
        }
        if (ETAP == 30) ///hod
        {
            if (hod.Length < 7) hod += "   ";
            hod = Left(hod, 12);

            if (hod.Contains("+")) AAA[0, 0].GetComponentInChildren<Text>().text = "ШАХ!";
            if (hod.Contains("++")) AAA[0, 0].GetComponentInChildren<Text>().text = "ДВОЙНОЙ ШАХ!";
            LAST = BoardLoad(Pos);


            /*var b1 = BoardLoad(Pos);
            var b2= HOD_F(b1, hod);
            Pos= BoardSave(b2);*/
            Pos = HOD(Pos, hod);



            BOARD = BoardLoad(Pos);
            var hh = hod;
            /* if (hh.Contains("Ke1-g1")) hh = "0-0";
             if (hh.Contains("Ke1-c1")) hh = "0-0-0";
             if (hh.Contains("Ke8-g8")) hh = "0-0";
             if (hh.Contains("Ke8-c8")) hh = "0-0-0";

             if (hh.Contains("0-0")) AAA[0, 0].GetComponentInChildren<Text>().text = "Короткая роккировка";
             if (hh.Contains("0-0-0")) AAA[0, 0].GetComponentInChildren<Text>().text = "Длинная роккировка";*/


            /*if (hh.Length > 6)
            {
                hhh = "";
                for (int i = 0; i < 11; i++) if (hh[i] != ' ') hhh += hh[i];
            }*/
            /*  if (BOARD[0, 0] == 'b') TXT2 += (int)BOARD[0, 8] + ". " + hhh;
              else
              {
                  TXT2 += " " + hhh;
                  if (!File.Exists("settings.ini")) File.Create("settings.ini");
                  File.AppendAllText("settings.ini", TXT2 + Environment.NewLine); TXT2 = "";
              }*/

            //  TextResult.GetComponent<Text>().text = TXT;
            //  if (b > 180) { TXT = ""; b = 0; }

            ETAP = 40; a = 0;
        }
        if (ETAP == 40)///анимация
        {
            if (hod != "") BoardMove(hod);
            a += 1;
            if (a > AA) { Board(); ETAP = 50; a = 0; b += 1; };
        }
        if (ETAP == 50)/// 
        {
            if ((int)BOARD[0, 7] == 0) { PartyPov.Clear(); PartyPov0.Clear(); }

            var dr = Draw(Pos);
            if (dr != "")
            {
                TextComment.GetComponent<Text>().text = dr;
                ETAP = 60; a = 0;
            }
            else
            {
                var p = Pos;
                var sp = 0; var L = 0; for (int i = 0; i < p.Length; i++) if (p[i] == ' ') { L = i; sp += 1; if (sp == 4) break; }
                //var pov3 = 0;
                //BeginPosition = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";                       
                var p0 = Left(p, L);
                var s = 0;
                for (int i = 0; i < Party.Count; i++)
                {
                    if (Party[i].Contains(p0)) s += 1;                           ///поиск повторов в партии             
                }
                if (s >= 1) PartyPov.Add(p0);
                PartyPov0.Add(p0);
            }

            Party.Add(Pos);
            var hh = hod;
            /* if (hh.Contains("Ke1-g1")) hh = "0-0";
             if (hh.Contains("Ke1-c1")) hh = "0-0-0";
             if (hh.Contains("Ke8-g8")) hh = "0-0";
             if (hh.Contains("Ke8-c8")) hh = "0-0-0";*/

            if (hh.Contains("0-0")) AAA[0, 0].GetComponentInChildren<Text>().text = "Короткая роккировка";
            if (hh.Contains("0-0-0")) AAA[0, 0].GetComponentInChildren<Text>().text = "Длинная роккировка";
            if (hh.Contains("ep")) Hods.Add(Left(hh, 8));
            else
            {
                if (hh.Contains("+")) Hods.Add(Left(hh, 8)); else Hods.Add(Left(hh, 7));
            }
            
            var text = "";
            var i1 = Hods.Count - 60; if (Mathf.Repeat(i1, 2) == 1) i1 -= 1;
            if (i1 < 0) i1 = 0;

            for (int i = i1; i < Hods.Count; i++)
            {
                if (Mathf.Repeat(i, 2) == 0) text += (i / 2 + 1) + "." + Hods[i];
                else text += " " + Hods[i] + "\r\n";
            }



            TextParty.GetComponent<Text>().text = text;

            if (ETAP == 50)
            {
                ETAP = 10; a = 0;

                //////если игра сетевая то записываем позицию на сервер
                if (KodGame > 0)
                {
                    SavePos(); ETAP = 7; a = 0;
                }
            }
        }
        if (ETAP == 60)////analiz
        {
            InpPos.GetComponent<InputField>().text = Pos;
            if (a == 0)
            {
                GlobalX = 0; GlobalY = 0; PanelA.SetActive(true); a = 1; GlobalETAP = 0;
                J1 = Party.Count - 1;
            }
            if (GlobalX == -2) { J1 -= 10; if (J1 < 0) J1 = 0; }
            if (GlobalX == -1) { J1 -= 1; if (J1 < 0) J1 = 0; }
            if (GlobalX == 1) { J1 += 1; if (J1 > Party.Count - 1) J1 = Party.Count - 1; }
            if (GlobalX == 2) { J1 += 10; if (J1 > Party.Count - 1) J1 = Party.Count - 1; }
            if (GlobalX != 0)
            {
                GlobalX = 0; Pos = Party[J1];
                BOARD = BoardLoad(Pos);
                Board();
                TextBug.GetComponent<Text>().text = Balans(Pos) + "/" + BalansF(Pos);
                MyList.Clear(); MyList = Variants(Pos, 1);
                TXT = ""; for (int i = 0; i < MyList.Count; i++) { var p = HOD(Pos, MyList[i]); TXT += Balans(p) + "/" + BalansF(p) + "/ ход " + MyList[i] + "\r\n"; }
                TextResult.GetComponent<Text>().text = TXT;
            }

            if (GlobalX == 0 && GlobalY == 1)
            {
                Avto = false;
                Pos = Party[J1];
                var B = Party.Count - 1;
                for (int i = J1; i <= B; i++) Party[i] = i + "";
                for (int i = J1; i <= B; i++) Party.Remove(i + "");
                ETAP = 10; a = 0;
            }
            if (GlobalETAP == 100) { a = 0; ETAP = 100; }
        }
        if (ETAP == 100)////редактор ///начальный вход
        {
            zap = false;
            PartyPov.Clear(); Limit = 0;
            PanelA.SetActive(false);
            Panel.SetActive(false);
            BOARD = BoardLoad(Pos); Board();

            time1 = DateTime.UtcNow.AddMinutes(30) - DateTime.UtcNow;
            time2 = DateTime.UtcNow.AddMinutes(30) - DateTime.UtcNow;
            Time1.GetComponent<InputField>().text = time1 + "";
            Time2.GetComponent<InputField>().text = time2 + "";

            ETAP = 110;
            GlobalX = 0; GlobalY = 0; GlobalZ = ""; GlobalETAP = 999; Panel1.SetActive(true);
        }
        if (ETAP == 110)////редактор  кнопки 
        {
            InpPos.GetComponent<InputField>().text = Pos;
            var sz = 1.3f;
            if (GlobalETAP != 999) { GlobalZ = ""; ETAP = GlobalETAP; a = 0; Pos = BoardSave(BOARD); Panel1.SetActive(false); }
            a += 1;
            if (a > 0) { sz = 1.3f; }
            if (a > 25) { sz = 1.5f; }
            if (a > 50) { a = 0; }
            for (int i = 0; i <= 11; i++) But[i].transform.localScale = new Vector3(1f, 1f, 1f);
            if (GlobalZ == "P") But[0].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "R") But[1].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "N") But[2].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "B") But[3].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "Q") But[4].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "K") But[5].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "p") But[6].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "r") But[7].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "n") But[8].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "b") But[9].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "q") But[10].transform.localScale = new Vector3(sz, sz, 1f);
            if (GlobalZ == "k") But[11].transform.localScale = new Vector3(sz, sz, 1f);
        }

    }

    public void Mark(int i, int j)
    {
        if (Chess.REVERS == true) { i = 9 - i; j = 9 - j; }

        if (Mathf.Repeat(i + j, 2) != 0) AAA[i, j].GetComponent<Image>().color = new Color32(155, 155, 255, 255);
        else AAA[i, j].GetComponent<Image>().color = new Color32(25, 97, 245, 255);
    }
    public void MarkGre(int i, int j)
    {
        if (Chess.REVERS == true) { i = 9 - i; j = 9 - j; }

        if (Mathf.Repeat(i + j, 2) != 0) AAA[i, j].GetComponent<Image>().color = new Color32(55, 155, 155, 255);
        else AAA[i, j].GetComponent<Image>().color = new Color32(25, 97, 145, 255);
    }
    public void MarkRed(int i, int j)
    {
        if (Chess.REVERS == true) { i = 9 - i; j = 9 - j; }

        if (Mathf.Repeat(i + j, 2) != 0) AAA[i, j].GetComponent<Image>().color = new Color32(255, 155, 155, 255);
        else AAA[i, j].GetComponent<Image>().color = new Color32(225, 97, 145, 255);
    }
    public void MarkOran(int i, int j)
    {
        if (Chess.REVERS == true) { i = 9 - i; j = 9 - j; }

        if (Mathf.Repeat(i + j, 2) != 0) AAA[i, j].GetComponent<Image>().color = new Color32(255, 155, 55, 255);
        else AAA[i, j].GetComponent<Image>().color = new Color32(225, 97, 45, 255);
    }
    public string Srubili(string pos, int side)
    {
        var Q = 1; var q = 1;
        var R = 2; var r = 2;
        var N = 2; var n = 2;
        var B = 2; var b = 2;
        var P = 8; var p = 8;
        for (int i = 0; i < pos.Length; i++)
        {//"rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1"
            var s = pos[i];

            if (s == 'Q') Q -= 1;
            if (s == 'q') q -= 1;
            if (s == 'R') R -= 1;
            if (s == 'r') r -= 1;
            if (s == 'N') N -= 1;
            if (s == 'n') n -= 1;
            if (s == 'B') B -= 1;
            if (s == 'b') b -= 1;
            if (s == 'P') P -= 1;
            if (s == 'p') p -= 1;
            if (s == ' ') break;
        }
        var v = "";
        if (side == 1)
        {
            if (P > 0) for (int i = 0; i < P; i++) v += "P";
            if (N > 0) for (int i = 0; i < N; i++) v += "N";
            if (B > 0) for (int i = 0; i < B; i++) v += "B";
            if (R > 0) for (int i = 0; i < R; i++) v += "R";
            if (Q > 0) for (int i = 0; i < Q; i++) v += "Q";
        }
        if (side == -1)
        {
            if (p > 0) for (int i = 0; i < p; i++) v += "p";
            if (n > 0) for (int i = 0; i < n; i++) v += "n";
            if (b > 0) for (int i = 0; i < b; i++) v += "b";
            if (r > 0) for (int i = 0; i < r; i++) v += "r";
            if (q > 0) for (int i = 0; i < q; i++) v += "q";
        }

        return v;
    }
    public static void Board()
    {


        var i1 = 0; var j1 = 0;
        ////  BBB[0, 0].SetActive(false); ///////загасить спрайт анимации
        ///// BBB[8, 0].SetActive(false); ///////загасить спрайт анимации

        var Q = 0; var R = 0; var B = 0; var N = 0; var P = 0;

        for (int i = 0; i <= 8; i++)
            for (int j = 0; j <= 8; j++)
            {
                //// Debug.Log( "i=" + i + " j=" + j);
                if (Mathf.Repeat(i + j, 2) != 0) AAA[i, j].GetComponent<Image>().color = new Color32(236, 255, 255, 255);
                else AAA[i, j].GetComponent<Image>().color = new Color32(145, 97, 145, 255);


                ///////////////
                i1 = i; j1 = j;
                if (REVERS) { j1 = 9 - j; i1 = 9 - i; }

                if (i > 0 && j > 0) Chess.Figura(i, j, BOARD[i1, j1]);
                if (i != 0 && j != 0)
                {
                    var s = BOARD[i, j];
                    if (s == 'Q') Q += 1;
                    if (s == 'q') Q -= 1;
                    if (s == 'R') R += 1;
                    if (s == 'r') R -= 1;
                    if (s == 'N') N += 1;
                    if (s == 'n') N -= 1;
                    if (s == 'B') B += 1;
                    if (s == 'b') B -= 1;
                    if (s == 'P') P += 1;
                    if (s == 'p') P -= 1;
                }

                if (i == 0)
                {
                    AAA[i, j].GetComponentInChildren<Text>().text = j1.ToString() + "   ";
                    AAA[i, j].GetComponentInChildren<Text>().alignment = TextAnchor.MiddleRight;
                    AAA[i, j].GetComponent<Image>().color = new Color32(236, 255, 255, 0);
                };
                if (j == 0)
                {
                    //char s = Convert.ToChar(96 + i1);
                    //char[] c = { s };
                    AAA[i, j].GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                    AAA[i, j].GetComponentInChildren<Text>().text = CharToString(Convert.ToChar(96 + i1));
                    if (i == 7) AAA[i, j].GetComponentInChildren<Text>().text = CharToString(Convert.ToChar(96 + i1)) + "\r\n (" + (int)BOARD[0, 7] + ")";
                    if (i == 8) AAA[i, j].GetComponentInChildren<Text>().text = CharToString(Convert.ToChar(96 + i1)) + "\r\n" + (int)BOARD[0, 8];


                    AAA[i, j].GetComponent<Image>().color = new Color32(236, 255, 255, 0);
                    if (i == 0 && BOARD[0, 0] == 'w') AAA[i, j].GetComponentInChildren<Text>().text = "White move " + "\r\n" + "Ход белых ";
                    if (i == 0 && BOARD[0, 0] == 'b') AAA[i, j].GetComponentInChildren<Text>().text = "Black move " + "\r\n" + "Ход черных ";

                };
            }
        var Y1 = 1; var Y8 = 8; var d1 = 1;
        if (REVERS) { Y1 = 8; Y8 = 1; d1 = -1; }
        for (int i = 1; i <= 8; i++) Figura(9, i, ' ');

        //  AAA[0, 0].GetComponentInChildren<Text>().text = "B=" + B;
        /// TextComment.GetComponent<Text>().text = ss;
        if (Q > 0) { Figura(9, Y1, 'q'); Y1 += d1; }
        if (Q < 0) { Figura(9, Y8, 'Q'); Y8 -= d1; }

        if (R > 0) { Figura(9, Y1, 'r'); Y1 += d1; R = R - 1; }
        if (R > 0) { Figura(9, Y1, 'r'); Y1 += d1; R = R - 1; }

        if (R < 0) { Figura(9, Y8, 'R'); Y8 -= d1; R = R + 1; }
        if (R < 0) { Figura(9, Y8, 'R'); Y8 -= d1; R = R + 1; }

        if (B > 0) { Figura(9, Y1, 'b'); Y1 += d1; B = B - 1; }
        if (B > 0) { Figura(9, Y1, 'b'); Y1 += d1; B = B - 1; }

        if (B < 0) { Figura(9, Y8, 'B'); Y8 -= d1; B = B + 1; }
        if (B < 0) { Figura(9, Y8, 'B'); Y8 -= d1; B = B + 1; }

        if (N > 0) { Figura(9, Y1, 'n'); Y1 += d1; N = N - 1; }
        if (N > 0) { Figura(9, Y1, 'n'); Y1 += d1; N = N - 1; }

        if (N < 0) { Figura(9, Y8, 'N'); Y8 -= d1; N = N + 1; }
        if (N < 0) { Figura(9, Y8, 'N'); Y8 -= d1; N = N + 1; }

        for (int i = 1; i <= 8; i++) if (P > 1) { Figura(9, Y1, 'd'); Y1 += d1; P = P - 2; }
        for (int i = 1; i <= 8; i++) if (P < -1) { Figura(9, Y8, 'D'); Y8 -= d1; P = P + 2; }

        for (int i = 1; i <= 8; i++) if (P > 0 && Y1 <= 8) { Figura(9, Y1, 'p'); Y1 += d1; P = P - 1; }
        for (int i = 1; i <= 8; i++) if (P < 0 && Y8 >= 1) { Figura(9, Y8, 'P'); Y8 -= d1; P = P + 1; }

        var S = "";
        S += BOARD[0, 0] + "/" + BOARD[0, 1] + "/" + BOARD[0, 2] + "/" + BOARD[0, 3] + "/" + BOARD[0, 4] + "/" + BOARD[0, 5] + BOARD[0, 6] + "/";

        for (int i = 7; i <= 8; i++) S += (int)BOARD[0, i] + "/";

        if (BOARD[0, 0] == 'w') S += "White move " + "\r\n" + "Ход белых ";
        if (BOARD[0, 0] == 'b') S += "Black move " + "\r\n" + "Ход черных ";
        S += "Короткая роккировка белых ";
        if (BOARD[0, 1] == 'K') S += " да " + "\r\n"; else S += " НЕТ" + "\r\n";
        S += "Длинная роккировка белых ";
        if (BOARD[0, 2] == 'Q') S += " да " + "\r\n"; else S += " НЕТ" + "\r\n";
        S += "Короткая роккировка черных ";
        if (BOARD[0, 3] == 'k') S += " да " + "\r\n"; else S += " НЕТ" + "\r\n";
        S += "Длинная роккировка черных ";
        if (BOARD[0, 4] == 'q') S += " да " + "\r\n"; else S += " НЕТ" + "\r\n";

        if (BOARD[0, 5] == '-') S += " Нет взятий на проходе " + "\r\n";
        else S += " Взятие на проходе на поле " + BOARD[0, 5] + BOARD[0, 6] + "\r\n";

        S += " Ходов без взятий и движения пешки " + (int)BOARD[0, 7] + "\r\n";
        S += " Ходов в партии " + (int)BOARD[0, 8] + "\r\n";
        ///////////////////////////////////////////////////////////////////////////////////////  TextStatus.GetComponent<Text>().text = S;
    }
    public void BoardMove(string p)
    { var p2 = ""; AA = 20;

        if (p.Contains("Ke1-g1")) p2 = "Rh1-f1";
        if (p.Contains("Ke1-c1")) p2 = "Ra1-d1";
        if (p.Contains("Ke8-g8")) p2 = "Rh8-f8";
        if (p.Contains("Ke8-c8")) p2 = "Ra8-d8";
        if (p2 == "") BoardMove2(p, 0); else { AA = 50; BoardMove2(p2, 0); BoardMove2(p, 8); }

    }

    public void BoardMove2(string p, int Sprite)
    {

        //// AA = 150;
        // if (a == 0)
        //   {
        /////  SSS = p;
        var x1 = p[1] - 96; var y1 = p[2] - 48;
        var z = p[3];
        var x2 = p[4] - 96; var y2 = p[5] - 48; /// z : or -

        str = CharToString(LAST[x1, y1]);
        //  if (Sprite == 0) str0 = str;
        // if (Sprite == 8) str8 = str;
        if (REVERS) { x2 = 9 - x2; y2 = 9 - y2; }
        if (REVERS) { x1 = 9 - x1; y1 = 9 - y1; }
        Figura(x1, y1, ' ');
        //BBB[x1, y1].GetComponent<Image>().color = new Color32(255, 255, 255, 155);

        X1 = BBB[x1, y1].transform.position.x;
        Y1 = BBB[y1, y1].transform.position.y;
        X2 = BBB[x2, y2].transform.position.x;
        Y2 = BBB[y2, y2].transform.position.y;


        BBB[Sprite, 0].SetActive(true);
        //  }
        //// if (Sprite == 0) str = str0;
        ////   if (Sprite == 8) str = str8;
        var X = X1 - (X1 - X2) * a / (AA);
        var Y = Y1 - (Y1 - Y2) * a / (AA);

        BBB[Sprite, 0].transform.SetAsLastSibling();
        BBB[Sprite, 0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        BBB[Sprite, 0].transform.position = new Vector3(X, Y, 0);


        if (str == " ") BBB[Sprite, 0].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        else BBB[Sprite, 0].GetComponent<Image>().sprite = Resources.Load<Sprite>(str);

        BBB[Sprite, 0].GetComponent<Image>().sprite = Resources.Load<Sprite>(str);
        BBB[Sprite, 0].transform.localScale = new Vector3(1f, 1f, 0.0f);
        if (str == "p" || str == "k" || str == "q" || str == "r" || str == "n" || str == "b") BBB[Sprite, 0].GetComponent<Image>().color = Blaky;

        var RZ = Math.Abs(x1 - x2);
        if (Math.Abs(y1 - y2) > RZ) RZ = Math.Abs(y1 - y2); //SSS = "RZ=" + RZ;


        var ii = 8; if (p.Contains("Ke1-g1") || p.Contains("Ke1-c1") || p.Contains("Ke8-g8") || p.Contains("Ke8-c8")) ii = 4;

        if (a == AA)
        {
            BBB[Sprite, 0].SetActive(false);

            for (int i = 1; i < ii; i++)
            {
                /// var di = a - (i - 1) * AA / RZ;
                X = X1 - (X1 - X2) * (i - 1) / RZ;
                Y = Y1 - (Y1 - Y2) * (i - 1) / RZ;
                if (Math.Sqrt((X - X2) * (X - X2) + (Y - Y2) * (Y - Y2)) > 40 && i <= RZ)
                {
                    var j = i; if (Sprite == 8) j = i + 3; if (j > 7) j = 7;
                    BBB[j, 0].SetActive(true);
                    BBB[j, 0].transform.position = new Vector3(X, Y, 0);
                    BBB[j, 0].GetComponent<Image>().sprite = Resources.Load<Sprite>(str);
                    BBB[j, 0].GetComponent<Image>().color = new Color32(255, 255, 255, 55);
                    if (str == "p" || str == "k" || str == "q" || str == "r" || str == "n" || str == "b")
                        BBB[j, 0].GetComponent<Image>().color = Blaky0;
                }
                else BBB[i, 0].SetActive(false);
            }
            if (p.Contains(":"))
            {
                if (REVERS) { x2 = 9 - x2; y2 = 9 - y2; }
                var str = CharToString(LAST[x2, y2]);
                if (p.Contains("ep") && y2 == 3 && REVERS == false) str = "P";
                if (p.Contains("ep") && y2 == 6 && REVERS == false) str = "p";
                if (p.Contains("ep") && y2 == 3 && REVERS) str = "p";
                if (p.Contains("ep") && y2 == 6 && REVERS) str = "P";
                BBB[8, 0].SetActive(true);
                BBB[8, 0].transform.position = new Vector3(X2 + 20, Y2 + 20, 0);
                BBB[8, 0].transform.localScale = new Vector3(0.4f, 0.4f, 0.0f);//BBB[7, 0].transform.rotation = Quaternion.Euler(0, 0, -90);
                BBB[8, 0].GetComponent<Image>().sprite = Resources.Load<Sprite>(str);
                BBB[8, 0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                if (str == "p" || str == "k" || str == "q" || str == "r" || str == "n" || str == "b")
                    BBB[8, 0].GetComponent<Image>().color = Blaky;

            }
            else { if (ii != 4) BBB[8, 0].SetActive(false); }
        }

    }
    public static void Figura(int x, int y, char st)
    {
        char[] c = { st };
        var str = new string(c);

        if (y > 8) y = 8; if (y < 1) y = 1;
        BBB[x, y].GetComponent<Image>().color = new Color32(255, 255, 255, 255);

        if (st == ' ') BBB[x, y].GetComponent<Image>().color = new Color32(255, 255, 255, 0); else BBB[x, y].GetComponent<Image>().sprite = Resources.Load<Sprite>(str);

        if (st == 'p') BBB[x, y].GetComponent<Image>().color = Blaky;
        if (st == 'k') BBB[x, y].GetComponent<Image>().color = Blaky;
        if (st == 'q') BBB[x, y].GetComponent<Image>().color = Blaky;
        if (st == 'r') BBB[x, y].GetComponent<Image>().color = Blaky;
        if (st == 'n') BBB[x, y].GetComponent<Image>().color = Blaky;
        if (st == 'b') BBB[x, y].GetComponent<Image>().color = Blaky;
        if (st == 'd') BBB[x, y].GetComponent<Image>().color = Blaky;
    }

    public static char[,] BoardLoad(string p)
    {
        var BOAR = new char[9, 9];
        for (int i = 1; i <= 8; i++) for (int j = 1; j <= 8; j++)
            {
                BOAR[i, j] = ' ';
            };
        var x = 1; var y = 8; var MIN = p.Length;
        var i1 = 0;
        for (int i = 0; i < p.Length; i++)
        {
            var s = p[i]; var n = s - 48;
            ///  var st = CharToString(s);
            if (s == '/') { y -= 1; x = 1; }
            if (s == ' ') { i1 = i; break; }
            if (n > 0 && n <= 8) x += n - 1;
            if (x > 8) { x = 1; };
            if (s != '/')
            {
                /// var X = x; var Y = y;

                if (n > 0 && n <= 8) BOAR[x, y] = ' ';
                else
                {
                    BOAR[x, y] = s;
                }
                x += 1;
            }
        }
        if (p.Contains(" w ")) BOAR[0, 0] = 'w';
        if (p.Contains(" b ")) BOAR[0, 0] = 'b';
        for (int i = 1; i <= 4; i++) { BOAR[0, i] = ' '; }; BOAR[0, 5] = '-'; BOAR[0, 6] = '-';
        var probel = 0; var i2 = 0; var i3 = 0; var i4 = 0;
        for (int i = i1 + 1; i < p.Length; i++)
        {//"rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1"
            var s = p[i];
            // if (s == 'w' || s == 'b') BOAR[0, 0] = s;
            if (s == 'K') BOAR[0, 1] = s;
            if (s == 'Q') BOAR[0, 2] = s;
            if (s == 'k') BOAR[0, 3] = s;
            if (s == 'q') BOAR[0, 4] = s;
            if (s == '-') BOAR[0, 5] = s;
            if (s == ' ')
            {
                probel += 1;
                if (probel == 2) { i2 = i; }
                if (probel == 3) { i3 = i; }
                if (probel == 4) { i4 = i; }
            }
        }
        var S = "";
        for (int i = i2 + 1; i < i3; i++) S = S + p[i];
        BOAR[0, 5] = p[i2 + 1];
        if (BOAR[0, 0] == 'w') BOAR[0, 6] = '6';
        if (BOAR[0, 0] == 'b') BOAR[0, 6] = '3';

        S = ""; for (int i = i3 + 1; i < i4; i++) S = S + p[i];

        BOAR[0, 7] = (char)Convert.ToInt32(S);

        S = ""; for (int i = i4 + 1; i < p.Length; i++) S = S + p[i];
        BOAR[0, 8] = (char)Convert.ToInt32(S);
        return BOAR;

    }
    public string BoardSave(char[,] BOAR)
    {
        var p = ""; var s = ' ';
        for (int j = 8; j >= 1; j--)
        {
            var n = 0;
            for (int i = 1; i <= 8; i++)
            {
                s = BOAR[i, j];
                if (s == ' ') { n += 1; }
                else
                {
                    if (n == 0) p = p + s;
                    if (n > 0) { p = p + n + s; n = 0; }
                }
            }
            if (n > 0) p = p + n;
            if (j != 1) p = p + "/";
        }
        p = p + " " + BOAR[0, 0];
        if (BOAR[0, 1] == ' ' && BOAR[0, 2] == ' ' && BOAR[0, 3] == ' ' && BOAR[0, 4] == ' ') p = p + " -";
        else
        {
            p = p + " ";
            for (int k = 1; k <= 4; k++) if (BOAR[0, k] != ' ') p = p + BOAR[0, k];

        }
        if (BOAR[0, 5] == '-') p = p + " -"; else p = p + " " + BOAR[0, 5] + BOAR[0, 6];
        p = p + " " + (int)BOAR[0, 7] + " " + (int)BOAR[0, 8];

        return p;
    }

    public static string PointToString(int x, int y)
    {
        char c = (char)(96 + x);
        return CharToString(c) + y;
    }
    public string Smena(string p0, char p1, char p2)
    {
        var pp = "";
        if (p0.Length > 0) for (int i = 0; i < p0.Length; i++)
                if (p0[i] == p1) pp += p2; else pp += p0[i];
        return pp;
    }
    public static string CharToString(char s)
    {
        char[] c = { s };
        return new string(c);
    }
    public static char Cvet(char s)
    {
        var v = ' ';
        if (s == 'Q' || s == 'R' || s == 'N' || s == 'B' || s == 'K' || s == 'P') v = 'w';
        if (s == 'q' || s == 'r' || s == 'n' || s == 'b' || s == 'k' || s == 'p') v = 'b';

        return v;
    }

    public List<string> Variants(string p, int side) ///side = -1 ход не в свою очередь side = 2 только взятия
    {
        var NextP = ""; var MyList = new List<string>(); var x1 = 0; var y1 = 0; //var x2 = 0; var y2 = 0;// var x3 = 0; var y3 = 0;        var z = 0;
        var h0 = ""; var BOAR = BoardLoad(p); var drug = BOAR[0, 0]; var vrag = ' '; if (BOAR[0, 0] == 'w') vrag = 'b'; if (BOAR[0, 0] == 'b') vrag = 'w';
        if (side == -1) { var d = drug; drug = vrag; vrag = d; }////варианты ходов противоположной стороны
        var Rok = false;
        if (side != 2)
        {
            if (drug == 'w' && (BOAR[0, 1] == 'K') && BOAR[5, 1] == 'K' && BOAR[6, 1] == ' ' && BOAR[7, 1] == ' ' && BOAR[8, 1] == 'R') { MyList.Add("Ke1-g1 "); Rok = true; }////короткая р белых
            if (drug == 'w' && (BOAR[0, 2] == 'Q') && BOAR[1, 1] == 'R' && BOAR[2, 1] == ' ' && BOAR[3, 1] == ' ' && BOAR[4, 1] == ' ' && BOAR[5, 1] == 'K') { MyList.Add("Ke1-c1 "); Rok = true; } ////дл р белых
            if (drug == 'b' && (BOAR[0, 3] == 'k') && BOAR[5, 8] == 'k' && BOAR[6, 8] == ' ' && BOAR[7, 8] == ' ' && BOAR[8, 8] == 'r') { MyList.Add("Ke8-g8 "); Rok = true; }////короткая р ч
            if (drug == 'b' && (BOAR[0, 4] == 'q') && BOAR[1, 8] == 'r' && BOAR[2, 8] == ' ' && BOAR[3, 8] == ' ' && BOAR[4, 8] == ' ' && BOAR[5, 8] == 'k') { MyList.Add("Ke8-c8 "); Rok = true; }////дл р ч
        }
        var p72 = false; var xK = 0; var yK = 0; var xk = 0; var yk = 0;
        for (int x = 1; x <= 8; x++) for (int y = 1; y <= 8; y++)
            {
                if (BOAR[x, y] == 'K') { xK = x; yK = y; }; if (BOAR[x, y] == 'k') { xk = x; yk = y; };////координат королей

                if (BOAR[x, y] != ' ' && Cvet(BOAR[x, y]) == drug)
                {
                    var fig = BOAR[x, y]; //if (fig == 'K') { xK = x; yK = y; }; if (fig == 'k') { xk = x; yk = y; };////координат королей
                    ///ход пешкой w
                    if (fig == 'P' && drug == 'w')
                    {
                        h0 = " " + PointToString(x, y); var EP = "";
                        if (side != 2)
                        {
                            if (BOAR[x, y + 1] == ' ') MyList.Add(h0 + "-" + PointToString(x, y + 1)); ///ход пр 
                            if (y == 2) if (BOAR[x, y + 1] == ' ' && BOAR[x, y + 2] == ' ') MyList.Add(h0 + "-" + PointToString(x, y + 2)); ///ход 2 поля
                        }
                        if (x < 8) ///бей вправо
                        {
                            if (Cvet(BOAR[x + 1, y + 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x + 1, y + 1)); ///бить без превращения
                            EP = PointToString(x + 1, y + 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x + 1, y + 1) + "ep"); ///если возможно взятие на проходе
                        }
                        if (x > 1) ///бей влево
                        {
                            if (Cvet(BOAR[x - 1, y + 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x - 1, y + 1)); ///бить
                            EP = PointToString(x - 1, y + 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x - 1, y + 1) + "ep"); ///если возможно взятие на проходе
                        }
                        if (y == 7) p72 = true;////могут быть превращения
                    }
                    ///ход пешкой b
                    if (fig == 'p' && drug == 'b')
                    {
                        h0 = " " + PointToString(x, y); var EP = "";
                        if (side != 2)
                        {
                            if (BOAR[x, y - 1] == ' ') MyList.Add(h0 + "-" + PointToString(x, y - 1)); ///ход пр
                            if (y == 7) if (BOAR[x, y - 1] == ' ' && BOAR[x, y - 2] == ' ') MyList.Add(h0 + "-" + PointToString(x, y - 2)); ///ход 2 поля
                        }
                        if (x < 8)
                        {
                            if (Cvet(BOAR[x + 1, y - 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x + 1, y - 1)); ///
                            EP = PointToString(x + 1, y - 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x + 1, y - 1) + " ep"); ///если возможно взятие на проходе
                        }
                        if (x > 1)
                        {
                            if (Cvet(BOAR[x - 1, y - 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x - 1, y - 1)); ///
                            EP = PointToString(x - 1, y - 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x - 1, y - 1) + " ep"); ///если возможно взятие на проходе
                        }
                        if (y == 2) p72 = true;////могут быть превращения
                    }
                    //if ((fig == 'N' && drug == 'w') || (fig == 'n' && drug == 'b')) //конь
                    if ((fig == 'N') || (fig == 'n')) //конь
                    {
                        h0 = 'N' + PointToString(x, y);
                        for (int dx = -2; dx <= 2; dx++) if (dx != 0) for (int dy = -2; dy <= 2; dy++) if (dy != 0 && dy != dx && dy != -dx)
                                    {
                                        x1 = x + dx; y1 = y + dy;
                                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                        {
                                            if (side != 2) if (BOAR[x1, y1] == ' ') MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                            if (Cvet(BOAR[x1, y1]) == vrag) MyList.Add(h0 + ":" + PointToString(x1, y1));
                                        }
                                    }
                    }
                    /* if ((fig == 'B' && drug == 'w') || (fig == 'b' && drug == 'b') //слон
                       || (fig == 'Q' && drug == 'w') || (fig == 'q' && drug == 'b') //ферзь
                        || (fig == 'K' && drug == 'w') || (fig == 'k' && drug == 'b')) //кр                  */
                    if ("QBKqbk".Contains(fig + ""))
                    // if (fig == 'B' || fig == 'b' || fig == 'Q' || fig == 'q' || fig == 'K' || fig == 'k' ) 
                    {
                        if (fig == 'B' || fig == 'b') h0 = 'B' + PointToString(x, y);
                        if (fig == 'Q' || fig == 'q') h0 = 'Q' + PointToString(x, y);
                        if (fig == 'K' || fig == 'k') h0 = 'K' + PointToString(x, y);
                        for (int dx = -1; dx <= 1; dx++)
                            if (dx != 0)
                                for (int dy = -1; dy <= 1; dy++)
                                    if (dy != 0)
                                    {
                                        for (int i = 1; i <= 8; i++)
                                        {
                                            if ((fig == 'K' || fig == 'k') && i > 1) break;
                                            x1 = x + dx * i; y1 = y + dy * i;
                                            if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                            if (Cvet(BOAR[x1, y1]) == drug) break;
                                            if (side != 2) if (BOAR[x1, y1] == ' ') MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                            if (Cvet(BOAR[x1, y1]) == vrag) { MyList.Add(h0 + ":" + PointToString(x1, y1)); break; }
                                        }
                                    }
                    }
                    /*if ((fig == 'R' && drug == 'w') || (fig == 'r' && drug == 'b') //ладья
                      || (fig == 'Q' && drug == 'w') || (fig == 'q' && drug == 'b') //ферзь
                      || (fig == 'K' && drug == 'w') || (fig == 'k' && drug == 'b')) //кр*/
                    if ("RQKrqk".Contains(fig + ""))
                    {
                        if (fig == 'R' || fig == 'r') h0 = 'R' + PointToString(x, y);
                        if (fig == 'Q' || fig == 'q') h0 = 'Q' + PointToString(x, y);
                        if (fig == 'K' || fig == 'k') h0 = 'K' + PointToString(x, y);
                        for (int dx = -1; dx <= 1; dx++)
                            // if (dx != 0)
                            for (int dy = -1; dy <= 1; dy++)
                                if (dy * dy != dx * dx)
                                {
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        if ((fig == 'K' || fig == 'k') && i > 1) break;
                                        x1 = x + dx * i; y1 = y + dy * i;
                                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                        if (Cvet(BOAR[x1, y1]) == drug) break;
                                        if (side != 2) if (BOAR[x1, y1] == ' ') MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                        if (Cvet(BOAR[x1, y1]) == vrag) { MyList.Add(h0 + ":" + PointToString(x1, y1)); break; }
                                    }
                                }
                    }
                }
            }
        var n = MyList.Count;
        if (p72)
            for (int i = 0; i < n; i++)////добавление превращений
                if (MyList[i][0] == ' ')///если пешка
                {
                    var c = MyList[i];
                    if ((drug == 'w' && c[5] - 48 == 8) ||
                        (drug == 'b' && c[5] - 48 == 1))
                    {

                        for (int j = 1; j <= 4; j++)
                        {
                            if (j == 1) MyList[i] = c + 'Q'; ///ход прев
                            if (j == 2) MyList.Add(c + 'R'); ///ход прев
                            if (j == 3) MyList.Add(c + 'N'); ///ход прев
                            if (j == 4) MyList.Add(c + 'B'); ///ход прев
                        }
                    }/// else if (MyList[i].Length < 7) MyList[i] += ".";
                }
        if (side != 0)////без отсечения нелегальных ходов с шахом
        {
            n = MyList.Count;

            for (int i = 0; i < n; i++)////отсев нелегальных ходов под шахом
            {
                NextP = HOD(p, MyList[i]);
                var V = 0;
                if (MyList[i][0] == 'K')
                {
                    x1 = MyList[i][4] - 96; y1 = MyList[i][5] - 48; V = PodSHAH2(x1, y1, NextP, 1);
                }
                else { if (BOAR[0, 0] == 'w') V = PodSHAH2(xK, yK, NextP, 1); else V = PodSHAH2(xk, yk, NextP, 1); }

                if (V > 0) { MyList[i] = "" + i; }
                else
                {
                    var shah = 0;
                    if (BOAR[0, 0] == 'w') shah = PodSHAH2(xk, yk, NextP, -1); else shah = PodSHAH2(xK, yK, NextP, -1);
                    ///PodSHAH(NextP, -1);
                    if (shah == 1) { MyList[i] += "+"; }
                    if (shah > 1) { MyList[i] += "++"; }
                }
            }
        }
        if (Rok)
            for (int i = 0; i < n; i++)////отсев нелегальных ходов роккировки
            {
                /////РОККИРОВКА
                if (MyList[i].Contains("Ke1-g1"))
                {
                    if (PodSHAH2(5, 1, p, -1) > 0) MyList[i] = "" + i;
                    // NextP = HOD(p, "Ke1-f1");
                    if (PodSHAH2(6, 1, p, -1) > 0) MyList[i] = "" + i;
                }
                if (MyList[i].Contains("Ke1-c1"))
                {
                    if (PodSHAH2(5, 1, p, -1) > 0) MyList[i] = "" + i;
                    //NextP = HOD(p, "Ke1-d1");
                    if (PodSHAH2(4, 1, p, -1) > 0) MyList[i] = "" + i;
                }
                if (MyList[i].Contains("Ke8-g8"))
                {
                    if (PodSHAH2(5, 8, p, -1) > 0) MyList[i] = "" + i;
                    //NextP = HOD(p, "Ke8-f8");
                    if (PodSHAH2(6, 8, p, -1) > 0) MyList[i] = "" + i;
                }
                if (MyList[i].Contains("Ke8-c8"))
                {
                    if (PodSHAH2(5, 8, p, -1) > 0) MyList[i] = "" + i;
                    //NextP = HOD(p, "Ke8-d8");
                    if (PodSHAH2(4, 8, p, -1) > 0) MyList[i] = "" + i;
                }

            }
        n = MyList.Count;
        for (int i = 0; i < n; i++)////отсев помеченных на удаление ходов
        {
            MyList.Remove("" + i);

        }
        // n = MyList.Count;
        // for (int i = 0; i < n; i++) if (MyList[i][0] == ' ' && MyList[i].Length < 7) MyList[i] += " "; ////добавление пробела пешкам при ходе без превращения
        return MyList;
    }
    public string HOD(string position, string p)
    {
        SSS = p;
        var BOAR = BoardLoad(position);

        if (p.Length >= 8) if (p[6] == 'e' && p[7] == 'p') p = Left(p, 8);

        var x1 = 0; var y1 = 0; var x2 = 0; var y2 = 0; var x3 = 0; var y3 = 0;
        var fig = ' '; var z = ' '; var figP = ' ';

        var drug = BOAR[0, 0]; var vrag = ' ';
        if (BOAR[0, 0] == 'w') vrag = 'b';
        if (BOAR[0, 0] == 'b') vrag = 'w';
        if (p.Length <= 6) p = p + " ";////если ход без хвоста
        fig = p[0];

        x1 = p[1] - 96; y1 = p[2] - 48;
        z = p[3];
        x2 = p[4] - 96; y2 = p[5] - 48; /// z : or -
        figP = p[6];////фигура превращения, если превращение
                    /// SSS = "p[2]=" + (int)p[2] + "p[5]=" + (int)p[5] + ",   x1 =" + x1 + ", y1=" + y1 + " , x2=" + x2 + ", y2=" + y2+", p="+p;
        BOAR[x2, y2] = BOAR[x1, y1];
        BOAR[x1, y1] = ' ';
        if (fig == ' ' && figP != ' ' && "QRNBqrnb".Contains(figP + ""))////фигура превращения, если превращение
        {
            if (drug == 'b')
            {
                if (figP == 'Q') figP = 'q';
                if (figP == 'R') figP = 'r';
                if (figP == 'N') figP = 'n';
                if (figP == 'B') figP = 'b';
            }
            BOAR[x2, y2] = figP;
        }
        ////роккировка

        if (p.Contains("Ke1-g1")) { BOAR[6, 1] = 'R'; BOAR[8, 1] = ' '; }
        if (p.Contains("Ke1-c1")) { BOAR[4, 1] = 'R'; BOAR[1, 1] = ' '; }
        if (p.Contains("Ke8-g8")) { BOAR[6, 8] = 'r'; BOAR[8, 8] = ' '; }
        if (p.Contains("Ke8-c8")) { BOAR[4, 8] = 'r'; BOAR[1, 8] = ' '; }

        if (p.Contains("ep"))
        {
            BOAR[x2, y1] = ' ';
        }
        //

        BOAR[0, 0] = vrag;
        if (p.Contains("Ke1-g1") && drug == 'w') { BOAR[0, 1] = ' '; BOAR[0, 2] = ' '; }//// "сделана кор.роккировка белых";
        if (p.Contains("Ke1-c1") && drug == 'w') { BOAR[0, 1] = ' '; BOAR[0, 2] = ' '; }//// "сделана дл.роккировка белых";
        if (p.Contains("Ke8-g8") && drug == 'b') { BOAR[0, 3] = ' '; BOAR[0, 4] = ' '; }//// "сделана роккировка черных";
        if (p.Contains("Ke8-c8") && drug == 'b') { BOAR[0, 3] = ' '; BOAR[0, 4] = ' '; }//// "сделана роккировка черных";
        if (fig == 'K' && drug == 'w') { BOAR[0, 1] = ' '; BOAR[0, 2] = ' '; }//// "теряется Длинная роккировка белых и короткая если сходил король";
        if (fig == 'K' && drug == 'b') { BOAR[0, 3] = ' '; BOAR[0, 4] = ' '; }//// "теряется Длинная роккировка черных и короткая если сходил король";
        if (fig == 'R' && drug == 'w' && x1 == 8 && y1 == 1) { BOAR[0, 1] = ' '; }//// "теряется кор роккировка белых если сходила ладья А1";
        if (fig == 'R' && drug == 'w' && x1 == 1 && y1 == 1) { BOAR[0, 2] = ' '; }//// "теряется дл роккировка белых если сходила ладья H1";
        if (fig == 'R' && drug == 'b' && x1 == 8 && y1 == 8) { BOAR[0, 3] = ' '; }//// "теряется кор роккировка черных если сходила ладья А8";
        if (fig == 'R' && drug == 'b' && x1 == 1 && y1 == 8) { BOAR[0, 4] = ' '; }//// "теряется дл роккировка черных если сходила ладья H8";

        if (fig == ' ' && Math.Abs(y1 - y2) == 2) { x3 = x1; y3 = (y1 + y2) / 2; var s = PointToString(x3, y3); BOAR[0, 5] = s[0]; BOAR[0, 6] = s[1]; }
        else { BOAR[0, 5] = '-'; } ///длинный ход пешкой

        if (fig == ' ' || z == ':') { BOAR[0, 7] = (char)0; }////счетчик ходов без пешек и взятия обнуляется
        else { if (drug == 'b') BOAR[0, 7] = (char)(BOAR[0, 7] + 1); }

        if (drug == 'b') BOAR[0, 8] = (char)(BOAR[0, 8] + 1); ///счетчик ходов +1 если был ход черных


        return BoardSave(BOAR);
    }

    public static int PodSHAH(string p, int side)///-1 я под шахом, 1-враг под шахом
    {
        var v = 0; var x1 = 0; var y1 = 0;
        var BOAR = BoardLoad(p);
        var drug = BOAR[0, 0]; var vrag = ' ';
        if (BOAR[0, 0] == 'w') vrag = 'b';
        if (BOAR[0, 0] == 'b') vrag = 'w';
        if (side == -1) { var d = drug; drug = vrag; vrag = d; } ///var d = drug; drug = vrag; vrag = d;///поменять местами
        for (int x = 1; x <= 8; x++)//// поиск короля
            for (int y = 1; y <= 8; y++)
                if ((BOAR[x, y] == 'K' && drug == 'b') || (BOAR[x, y] == 'k' && drug == 'w'))
                {
                    // SSS = "";
                    for (int dx = -1; dx <= 1; dx++)
                        if (dx != 0)
                            for (int dy = -1; dy <= 1; dy++)
                                if (dy != 0)
                                {
                                    x1 = x + dx; y1 = y + dy;
                                    if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                    {
                                        //SSS += BOAR[x1, y1] + PointToString(x1, y1) + ", drug=" + drug;
                                        if ((BOAR[x1, y1] == 'p' && drug == 'b' && y < y1) || (BOAR[x1, y1] == 'P' && drug == 'w' && y > y1)) v = v + 1; ///шах пешкой
                                    }
                                }

                    for (int dx = -2; dx <= 2; dx++)
                        if (dx != 0)
                            for (int dy = -2; dy <= 2; dy++)
                                if (dy != 0 && dy != dx && dy != -dx)
                                {
                                    x1 = x + dx; y1 = y + dy;
                                    if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                    {
                                        // SSS += BOAR[x1, y1]+PointToString(x1, y1)+ ", drug="+ drug+ (BOAR[x1, y1] == 'N' && drug == 'w');
                                        if ((BOAR[x1, y1] == 'n' && drug == 'b') || (BOAR[x1, y1] == 'N' && drug == 'w')) v = v + 1; ///шах конем
                                    }
                                }
                    for (int dx = -1; dx <= 1; dx++)
                        if (dx != 0)
                            for (int dy = -1; dy <= 1; dy++)
                                if (dy != 0)
                                {
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        x1 = x + dx * i; y1 = y + dy * i;
                                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                        if (Cvet(BOAR[x1, y1]) == vrag) break;
                                        if ((BOAR[x1, y1] == 'b' && drug == 'b') || (BOAR[x1, y1] == 'B' && drug == 'w')) v = v + 1; ///шах слоном
                                        if ((BOAR[x1, y1] == 'q' && drug == 'b') || (BOAR[x1, y1] == 'Q' && drug == 'w')) v = v + 1; ///шах ферзем
                                        if (i == 1) if ((BOAR[x1, y1] == 'k' && drug == 'b') || (BOAR[x1, y1] == 'K' && drug == 'w')) v = v + 1; ///сближение с королем
                                        if (BOAR[x1, y1] != ' ') break;//если фигура не С и не Ф - дальше не сканировать
                                    }
                                }
                    for (int dx = -1; dx <= 1; dx++)

                        for (int dy = -1; dy <= 1; dy++)
                            if (dy * dy != dx * dx)
                            {
                                for (int i = 1; i <= 8; i++)
                                {
                                    x1 = x + dx * i; y1 = y + dy * i;
                                    if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                    if (Cvet(BOAR[x1, y1]) == vrag) break;
                                    if ((BOAR[x1, y1] == 'r' && drug == 'b') || (BOAR[x1, y1] == 'R' && drug == 'w')) v = v + 1; ///шах ладьей
                                    if ((BOAR[x1, y1] == 'q' && drug == 'b') || (BOAR[x1, y1] == 'Q' && drug == 'w')) v = v + 1; ///шах ферзем
                                    if (i == 1) if ((BOAR[x1, y1] == 'k' && drug == 'b') || (BOAR[x1, y1] == 'K' && drug == 'w')) v = v + 1; ///сближение с королем
                                    if (BOAR[x1, y1] != ' ') break;//если фигура не Л и не Ф - дальше не сканировать
                                }
                            }

                }
        return v;
    }
    public int PodSHAH2(int x, int y, string p, int side)///-1 я под шахом, 1-враг под шахом
    {
        var v = 0;
        var BOAR = BoardLoad(p);
        var drug = BOAR[0, 0]; var vrag = ' ';
        if (BOAR[0, 0] == 'w') vrag = 'b';
        if (BOAR[0, 0] == 'b') vrag = 'w';
        if (side == -1) { var d = drug; drug = vrag; vrag = d; } ///var d = drug; drug = vrag; vrag = d;///поменять местами


        // SSS = "";
        for (int dx = -1; dx <= 1; dx++)
            if (dx != 0)
                for (int dy = -1; dy <= 1; dy++)
                    if (dy != 0)
                    {
                        x1 = x + dx; y1 = y + dy;
                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                        {
                            //SSS += BOAR[x1, y1] + PointToString(x1, y1) + ", drug=" + drug;
                            if ((BOAR[x1, y1] == 'p' && drug == 'b' && y < y1) || (BOAR[x1, y1] == 'P' && drug == 'w' && y > y1)) v = v + 1; ///шах пешкой
                        }
                    }

        for (int dx = -2; dx <= 2; dx++)
            if (dx != 0)
                for (int dy = -2; dy <= 2; dy++)
                    if (dy != 0 && dy != dx && dy != -dx)
                    {
                        x1 = x + dx; y1 = y + dy;
                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                        {
                            // SSS += BOAR[x1, y1]+PointToString(x1, y1)+ ", drug="+ drug+ (BOAR[x1, y1] == 'N' && drug == 'w');
                            if ((BOAR[x1, y1] == 'n' && drug == 'b') || (BOAR[x1, y1] == 'N' && drug == 'w')) v = v + 1; ///шах конем
                        }
                    }
        for (int dx = -1; dx <= 1; dx++)
            if (dx != 0)
                for (int dy = -1; dy <= 1; dy++)
                    if (dy != 0)
                    {
                        for (int i = 1; i <= 8; i++)
                        {
                            x1 = x + dx * i; y1 = y + dy * i;
                            if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                            if (Cvet(BOAR[x1, y1]) == vrag) break;
                            if ((BOAR[x1, y1] == 'b' && drug == 'b') || (BOAR[x1, y1] == 'B' && drug == 'w')) v = v + 1; ///шах слоном
                            if ((BOAR[x1, y1] == 'q' && drug == 'b') || (BOAR[x1, y1] == 'Q' && drug == 'w')) v = v + 1; ///шах ферзем
                            if (i == 1) if ((BOAR[x1, y1] == 'k' && drug == 'b') || (BOAR[x1, y1] == 'K' && drug == 'w')) v = v + 1; ///сближение с королем
                            if (BOAR[x1, y1] != ' ') break;//если фигура не С и не Ф - дальше не сканировать
                        }
                    }
        for (int dx = -1; dx <= 1; dx++)

            for (int dy = -1; dy <= 1; dy++)
                if (dy * dy != dx * dx)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        x1 = x + dx * i; y1 = y + dy * i;
                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                        if (Cvet(BOAR[x1, y1]) == vrag) break;
                        if ((BOAR[x1, y1] == 'r' && drug == 'b') || (BOAR[x1, y1] == 'R' && drug == 'w')) v = v + 1; ///шах ладьей
                        if ((BOAR[x1, y1] == 'q' && drug == 'b') || (BOAR[x1, y1] == 'Q' && drug == 'w')) v = v + 1; ///шах ферзем
                        if (i == 1) if ((BOAR[x1, y1] == 'k' && drug == 'b') || (BOAR[x1, y1] == 'K' && drug == 'w')) v = v + 1; ///сближение с королем
                        if (BOAR[x1, y1] != ' ') break;//если фигура не Л и не Ф - дальше не сканировать
                    }
                }


        return v;
    }
    public int BalSil(char[,] BOAR)/// 
    { var MATRW = new string[9, 9];
        var MATRB = new string[9, 9];
        var v = 0f; var x1 = 0; var y1 = 0; var shah = false;
        /// var BOAR = BoardLoad(p);
        var hodit = BOAR[0, 0]; var k10 = 10; var k100 = 70;
        var CF = 0; var p = "";///кол-во фигур
        var fig = ' '; var xK = 0; var yK = 0; var xk = 0; var yk = 0; var BBlack = false; var BWhite = false;

        for (int x = 1; x <= 8; x++) for (int y = 1; y <= 8; y++) { MATRB[x, y] = ""; MATRW[x, y] = ""; };
        for (int x = 1; x <= 8; x++)//// составление матриц MATRW и MATRB
            for (int y = 1; y <= 8; y++)
                if (BOAR[x, y] != ' ')
                {
                    fig = BOAR[x, y]; //
                                      ////подсчет цены фигур
                    CF += 1; var w = 0;
                    if (fig == 'p')
                    { w = -100;
                        if (y > 4 && (BOAR[x, y - 1] == 'p' || BOAR[x, y - 2] == 'p' || BOAR[x, y - 3] == 'p')) w = w + 50;
                        if (x == 1 || x == 8) w = -90;
                        if (x == 2 || x == 7) w = -99;
                        if (y == 4) w = w - 5; if (y == 4 && BOAR[x, y - 1] == ' ' && BOAR[x, y - 2] == ' ' && BOAR[x, y - 3] == ' ') w = w - 10;
                        if (y == 3) w = w - 10; if (y == 3 && BOAR[x, y - 1] == ' ' && BOAR[x, y - 2] == ' ') w = w - 50;
                        if (y == 2) w = w - 50; if (y == 2 && BOAR[x, y - 1] == ' ') w = w - 150;
                        w += (y - 9);
                        if (y - 1 > 0) if (BOAR[x, y - 1]==' ')
                        {       var proh = true;
                                for (int j = 0; j <= 2; j++)
                                for (int i = 1; i <= 8; i++)
                                {
                                        var jj = j; if (j == 2) jj = -1;
                                    x1 = x + jj;  y1 = y - i; if (x1 >= 1 && x1 <= 8 && y1 >= 1 && y1 <= 8 )
                                    {
                                       if ("QRNBPK".Contains(BOAR[x1, y1]+"")) { proh = false; break; }
                                    }
                                }
                                if (proh) w += (y - 9) * 10;
                        }                           
                        
                    }
                    if (fig == 'P')
                    { w += 100; if (y < 5 && (BOAR[x, y + 1] == 'P' || BOAR[x, y + 2] == 'P' || BOAR[x, y + 3] == 'P')) w = w - 50;
                        if (x == 1 || x == 8) w = 90;
                        if (x == 2 || x == 7) w = 99;
                        if (y == 5) w = w + 5; if (y == 5 && BOAR[x, y + 1] == ' ' && BOAR[x, y + 2] == ' ' && BOAR[x, y + 3] == ' ') w = w + 10;
                        if (y == 6) w = w + 10; if (y == 6 && BOAR[x, y + 1] == ' ' && BOAR[x, y + 2] == ' ') w = w + 50;
                        if (y == 7) w = w + 50; if (y == 7 && BOAR[x, y + 1] == ' ') w = w + 150;
                        w += y;
                        if (y + 1 < 9) if (BOAR[x, y + 1] == ' ')
                            {
                                var proh = true;
                                for (int j = 0; j <= 2; j++)
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        var jj = j; if (j == 2) jj = -1;
                                        x1 = x + jj; y1 = y + i; if (x1 >= 1 && x1 <= 8 && y1 >= 1 && y1 <= 8)
                                        {
                                            if ("qrnbpk".Contains(BOAR[x1, y1] + "")) { proh = false; break; }
                                        }
                                    }
                                if (proh) w += y * 10;
                            }
                    }
                    if (fig == 'n')
                    {
                        w = -299;
                        if ((x == 1 || x == 8) && (y <= 3 || y >= 6)) w = -290;
                        if ((y == 1 || y == 8) && (x <= 3 || x >= 6)) w = -290;
                        if (x >= 3 && x <= 6 && y >= 3 && y <= 6) w = -300;
                        if (x >= 4 && x <= 5 && y >= 4 && y <= 5) w = -301;
                    }
                    if (fig == 'N')
                    {
                        w = 299;
                        if ((x == 1 || x == 8) && (y <= 3 || y >= 6)) w = 290;
                        if ((y == 1 || y == 8) && (x <= 3 || x >= 6)) w = 290;
                        if (x >= 3 && x <= 6 && y >= 3 && y <= 6) w = 300;
                        if (x >= 4 && x <= 5 && y >= 4 && y <= 5) w = 301;
                    }
                    if (fig == 'b')
                    {
                        w = -300;
                        if (x == 3 && y == 8) { w = -290; if (Cvet(BOAR[2, 7]) == 'b' && Cvet(BOAR[4, 7]) == 'b') w = -290; }
                        if (x == 6 && y == 8) { w = -290; if (Cvet(BOAR[5, 7]) == 'b' && Cvet(BOAR[7, 7]) == 'b') w = -290; }
                        if (p.Contains("b")) w = w - 33; ///бонус за второго слона
                    }
                    if (fig == 'B')
                    {
                        w = 300;
                        if (x == 3 && y == 1) { w = 290; if (Cvet(BOAR[2, 2]) == 'w' && Cvet(BOAR[4, 2]) == 'w') w = 290; }
                        if (x == 6 && y == 1) { w = 290; if (Cvet(BOAR[5, 2]) == 'w' && Cvet(BOAR[7, 2]) == 'w') w = 290; }
                        if (p.Contains("B")) w = w + 33; ///бонус за второго слона
                    }
                    if (fig == 'r') w = -500;
                    if (fig == 'R') w = 500;
                    if (fig == 'q') w = -900;
                    if (fig == 'Q') w = 900;
                    // w = Cena(fig) * 100;
                    v += w;
                    p += fig;

                    if (fig == 'K') { xK = x; yK = y; };
                    if (fig == 'k') { xk = x; yk = y; };

                    if (fig == 'p' || fig == 'P')
                        for (int dx = -1; dx <= 1; dx++) if (dx != 0) for (int dy = -1; dy <= 1; dy++) if (dy != 0)
                                    {
                                        x1 = x + dx; y1 = y + dy;
                                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                        {
                                            if (BOAR[x, y] == 'p' && y > y1) MATRB[x1, y1] += 'p'; ///атака пешкой
                                            if (BOAR[x, y] == 'P' && y < y1) MATRW[x1, y1] += 'P'; ///атака пешкой
                                        }
                                    }
                    if (fig == 'n' || fig == 'N')
                        for (int dx = -2; dx <= 2; dx++) if (dx != 0) for (int dy = -2; dy <= 2; dy++) if (dy != 0 && dy != dx && dy != -dx)
                                    {
                                        x1 = x + dx; y1 = y + dy;
                                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                        {
                                            if (BOAR[x, y] == 'n') MATRB[x1, y1] += 'n'; ///атака  конем
                                            if (BOAR[x, y] == 'N') MATRW[x1, y1] += 'N'; ///атака конем                                    
                                        }
                                    }
                    if (fig == 'b' || fig == 'B' || fig == 'q' || fig == 'Q' || fig == 'k' || fig == 'K')
                        for (int dx = -1; dx <= 1; dx++) if (dx != 0) for (int dy = -1; dy <= 1; dy++) if (dy != 0)
                                    {
                                        for (int i = 1; i <= 8; i++)
                                        {
                                            x1 = x + dx * i; y1 = y + dy * i;
                                            if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;

                                            if (BOAR[x, y] == 'b') MATRB[x1, y1] += 'b'; ///атака слоном
                                            if (BOAR[x, y] == 'B') MATRW[x1, y1] += 'B'; ///атака слоном
                                            if (BOAR[x, y] == 'q') MATRB[x1, y1] += 'q'; ///атака ферзем
                                            if (BOAR[x, y] == 'Q') MATRW[x1, y1] += 'Q'; ///атака ферзем

                                            if (i == 1) if (BOAR[x, y] == 'k') MATRB[x1, y1] += 'k'; ///атака королем
                                            if (i == 1) if (BOAR[x, y] == 'K') MATRW[x1, y1] += 'K'; ///атака королем
                                            if (fig != 'K' && fig != 'k' && BOAR[x1, y1] != ' ') break;//если фигура не С и не Ф - дальше не сканировать
                                            //if (fig == 'K' && Cvet(BOAR[x1, y1]) == 'w') { MATRB[x1, y1] += "{"+BOAR[x1, y1]+"}"; break; }
                                            //  if (fig == 'K' && Cvet(BOAR[x1, y1]) == 'w') { v += -Cena(BOAR[x1, y1]) * k10; break; }
                                            //  if (fig == 'k' && Cvet(BOAR[x1, y1]) == 'b') { v += -Cena(BOAR[x1, y1]) * k10; break; }                                    
                                        }
                                    }
                    if (fig == 'r' || fig == 'R' || fig == 'q' || fig == 'Q' || fig == 'k' || fig == 'K')
                        for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++) if (dy * dy != dx * dx)
                                {
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        x1 = x + dx * i; y1 = y + dy * i;
                                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                        if (BOAR[x, y] == 'r') MATRB[x1, y1] += 'r'; ///атака ладьей
                                        if (BOAR[x, y] == 'R') MATRW[x1, y1] += 'R'; ///атака ладьей
                                        if (BOAR[x, y] == 'q') MATRB[x1, y1] += 'q'; ///атака ферзем
                                        if (BOAR[x, y] == 'Q') MATRW[x1, y1] += 'Q'; ///атака ферзем

                                        if (i == 1) if (BOAR[x, y] == 'k') MATRB[x1, y1] += 'k'; ///атака королем
                                        if (i == 1) if (BOAR[x, y] == 'K') MATRW[x1, y1] += 'K'; ///атака королем
                                        if (fig != 'K' && fig != 'k' && BOAR[x1, y1] != ' ') break;//если фигура не Л и не Ф - дальше не сканировать
                                                                                                   // if (fig == 'K' && Cvet(BOAR[x1, y1]) == 'w') { v += -Cena(BOAR[x1, y1]) * k10; break; }
                                                                                                   //  if (fig == 'k' && Cvet(BOAR[x1, y1]) == 'b') { v += -Cena(BOAR[x1, y1]) * k10; break; }
                                    }
                                }
                }
        ////безопасность бел короля
        if (p.Contains("q") || (p.Contains("r") && p.Contains("b") && p.Contains("n")))
        {
            for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++)
                {
                    x1 = xK + dx; y1 = yK + dy;
                    if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                    {
                        fig = BOAR[x1, y1]; var F = Cena(fig);
                        v += F; if (F < 0) v += F * 10;
                        var MB = MATRB[x1, y1] + ""; var MW = MATRW[x1, y1] + "";
                        v += MatrSum(MW) + MatrSum(MB) * 10;
                    }
                    //else v += 1;

                }
            if (CF > 10)
            {
                if (yK == 1 && (xK <= 3 || xk >= 6)) v += 100; if (yk == 1 && xk == 4) v -= 100;
                if (yK == 2 && (xK == 2 || xk == 7)) v += 100;
                if (yK == 2 && (xK >= 3 && xk <= 6)) v -= 100;
                if (yK >= 2) v -= 100 * yK;
            }
        }
        ////безопасность чер короля
        if (p.Contains("Q") || (p.Contains("R") && p.Contains("B") && p.Contains("N")))
        {
            for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++)
                {
                    x1 = xk + dx; y1 = yk + dy;
                    if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                    {
                        fig = BOAR[x1, y1]; var F = Cena(fig);
                        v += F; if (F > 0) v += F * 10;
                        var MB = MATRB[x1, y1] + ""; var MW = MATRW[x1, y1] + "";
                        v += MatrSum(MB) + MatrSum(MW) * 10;
                    }
                    //else v -= 1;
                }
            if (CF > 10)
            {
                if (yk == 8 && (xk <= 3 || xk >= 6)) v -= 100; if (yk == 8 && xk == 4) v += 100;
                if (yk == 7 && (xk == 2 || xk == 7)) v -= 100;
                if (yk == 7 && (xk >= 3 && xk <= 6)) v += 100;
                if (yk <= 7) v += 100 * (9 - yk);
            }
            
        }
        ///связки по черному королю
        for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++) if (dx != 0 || dy != 0)
                {
                    var ag = ' '; var zh = ' '; var s = ""; var diag = (dx * dy != 0);
                    for (int i = 1; i <= 8; i++)
                    {
                        x1 = xk + dx * i; y1 = yk + dy * i;

                        if (x1 > 8 || x1 < 1 || y1 > 8 || y1 < 1) break;
                        fig = BOAR[x1, y1]; s += fig;
                        if (fig != ' ')
                        {
                            if (zh != ' ' && Cvet(fig) == 'b') { break; }
                            if (zh != ' ' && Cvet(fig) == 'w') { ag = fig; break; }
                            if (zh == ' ' && Cvet(fig) == 'b') zh = fig;
                            if (zh == ' ' && Cvet(fig) == 'w') break;
                        }

                    }
                    if (s != "") if (("QR".Contains(ag + "") && diag == false) || ("QB".Contains(ag + "") && diag))
                        {
                            if (ag == 'Q' && zh == 'r' && diag && s[0] == ' ') v += 20;
                            if (ag == 'Q' && zh == 'b' && diag == false && s[0] == ' ') v += 10;
                            if (ag == 'Q' && zh == 'n' && s[0] == ' ') v += 10;
                            if (ag == 'R' && zh == 'q') v += 20;
                            if (ag == 'R' && zh == 'n' && s[0] == ' ') v += 15;
                            if (ag == 'R' && zh == 'b' && s[0] == ' ') v += 15;
                            if (ag == 'B' && zh == 'q') v += 30;
                            if (ag == 'B' && zh == 'r') v += 10;
                            if (ag == 'B' && zh == 'r' && s[0] == ' ') v += 10;
                            if (ag == 'B' && zh == 'n' && s[0] == ' ') v += 15;
                        }
                }
        ///связки по белому королю
        for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++) if (dx != 0 || dy != 0)
                {
                    var ag = ' '; var zh = ' '; var s = ""; var diag = (dx * dy != 0);
                    for (int i = 1; i <= 8; i++)
                    {
                        x1 = xK + dx * i; y1 = yK + dy * i;

                        if (x1 > 8 || x1 < 1 || y1 > 8 || y1 < 1) break;
                        fig = BOAR[x1, y1]; s += fig;
                        if (fig != ' ')
                        {
                            if (zh != ' ' && Cvet(fig) == 'w') { break; }
                            if (zh != ' ' && Cvet(fig) == 'b') { ag = fig; break; }
                            if (zh == ' ' && Cvet(fig) == 'w') zh = fig;
                            if (zh == ' ' && Cvet(fig) == 'b') break;
                        }

                    }
                    if (s != "") if (("qr".Contains(ag + "") && diag == false) || ("qb".Contains(ag + "") && diag))
                        {
                            if (ag == 'q' && zh == 'R' && diag && s[0] == ' ') v += -20;
                            if (ag == 'q' && zh == 'B' && diag == false && s[0] == ' ') v += -10;
                            if (ag == 'q' && zh == 'N' && s[0] == ' ') v += -10;
                            if (ag == 'r' && zh == 'Q') v += -20;
                            if (ag == 'r' && zh == 'N' && s[0] == ' ') { v += -15; Debug.Log("связка белого коня"); }
                            if (ag == 'r' && zh == 'B' && s[0] == ' ') v += -15;
                            if (ag == 'b' && zh == 'Q') v += -30;
                            if (ag == 'b' && zh == 'R') v += -10;
                            if (ag == 'b' && zh == 'R' && s[0] == ' ') v += -10;
                            if (ag == 'b' && zh == 'N' && s[0] == ' ') v += -15;
                        }
                }
        ///  SSS = Math.Sign(0)+"/"+ Cena(' ')+"!";
        for (int x = 1; x <= 8; x++)//// Анализ матриц MATRW и MATRB
            for (int y = 1; y <= 8; y++)
                if (MATRB[x, y] != "" || MATRW[x, y] != "")
                {
                    var MB = MATRB[x, y] + ""; var MW = MATRW[x, y] + ""; var MinorB = Minor(MB); var MinorW = Minor(MW); var MajorB = Major(MB); var MajorW = Major(MW);

                    fig = BOAR[x, y];
                    var F = Cena(fig);
                    var F0 = Mathf.Abs(F);
                    //  AAA[x, y].GetComponentInChildren<Text>().text = MATRW[x, y] + "/" + MATRB[x, y]; AAA[x, y].GetComponentInChildren<Text>().color = Blaky;

                    if (fig == ' ') ///если клетка пуста
                    {
                        var sum = MatrSum(MATRB[x, y] + MATRW[x, y]);
                        v += sum; AAA[x, y].GetComponentInChildren<Text>().text = MATRB[x, y] + MATRW[x, y]; AAA[x, y].GetComponentInChildren<Text>().color = Blaky;
                    }
                   /* if (CF > 25)
                    {
                        ////атака центра
                        if (x >= 4 && x <= 5 && y >= 4 && y <= 5)
                        {
                            v += 10*MatrSum(MATRW[x, y]) + 10*MatrSum(MATRB[x, y]); v += Math.Sign(F);
                            if (F == 'P' && y == 5) v += 5;
                            if (F == 'p' && y == 4) v -= 5;
                            if (F == 'P' ) v += 5;
                            if (F == 'p' ) v -= 5;
                            //if (F == 'Q' || F == 'q') v += -Math.Sign(F) * 30;
                        }
                        if (x >= 3 && x <= 6 && y >= 3 && y <= 6)
                        {
                           /// v += MatrSum(MATRW[x, y]) + MatrSum(MATRB[x, y]);
                            v += Math.Sign(F);

                            //if (F == 'Q' || F == 'q') v += -Math.Sign(F) * 30;
                        }

                    }*/


                    //не защ своими, но атакована
                 if (hodit == 'b' && MW != "" && MB == "" && F < 0) { v += -F * k10; OPAS += 1; }
                 if (hodit == 'w' && MW != "" && MB == "" && F < 0) {v += -F * k100; OPAS += 1; }

                if (hodit == 'w' && MB != "" && MW == "" && F > 0) {v += -F * k10; OPAS += 1; }
                if (hodit == 'b' && MB != "" && MW == "" && F > 0) {v += -F* k100; OPAS += 1; }
                
                    ///защищена своими и не атакована
                    if (MB == "" && MW != "" && F > 0)
                    {
                        v += F * MW.Length/10  ;
                        if (fig == 'Q' && MajorW == 'R') v += 9;
                        if (fig == 'Q' && (MajorW == 'B' || MajorW == 'N')) v += 5;
                        if (fig == 'R' && (MajorW == 'Q' || MajorW == 'R')) v += 9;
                        if (fig == 'R' && (MajorW == 'B' || MajorW == 'N')) v += 5;
                        if (fig == 'B' && (MajorW == 'Q' || MajorW == 'R' || MajorW == 'N')) v += 3;
                        if (fig == 'N' && (MajorW == 'B' || MajorW == 'R' || MajorW == 'N')) v += 3;
                    }
                        
                    if (MW == "" && MB != "" && F < 0)
                    {
                        v += F * MB.Length/10  ;
                        if (fig == 'q' && MajorB == 'r') v += -9;
                        if (fig == 'q' && (MajorB == 'b' || MajorB == 'n')) v += -5;
                        if (fig == 'r' && (MajorB == 'q' || MajorB == 'r')) v += -9;
                        if (fig == 'r' && (MajorB == 'b' || MajorB == 'n')) v += -5;
                        if (fig == 'b' && (MajorB == 'q' || MajorB == 'r' || MajorB == 'n')) v += -3;
                        if (fig == 'n' && (MajorB == 'b' || MajorB == 'r' || MajorB == 'n')) v += -3;
                    }

                    ///и защищена и атакована
                    if (MB != "" && MW != "")
                        if (BOAR[x, y] != 'K' && BOAR[x, y] != 'k')
                        {
                            var Zher = fig;
                            var s = 0; var L = 0;// MW.Length; var Lb = MB.Length;
                            MW = Porangu(MW); MB = Porangu(MB);
                            if (MW.Length > MB.Length) L = MB.Length; else L = MW.Length;

                            if (F > 0)/// если фиг бел
                                for (int i = 0; i < L; i++)
                                {
                                    if (Cena(Zher) > -Cena(MB[i]))
                                    {
                                        s += -Cena(Zher) - Cena(MB[i]);
                                        Zher = MW[i];
                                    }
                                    else break;
                                }
                            ///  if (x==2 && y==6)  SSS = "MW=" + MW + ", MB=" + MB ;
                            if (F < 0)/// если фиг чер
                                for (int i = 0; i < L; i++)
                                {
                                    //if (x == 2 && y == 6) SSS += "-Cena(Zher)=" + -Cena(Zher) + ", Cena(MW[i])" + Cena(MW[i])+" . ";
                                    if (-Cena(Zher) > Cena(MW[i]))
                                    {
                                        s += -Cena(Zher) - Cena(MW[i]);
                                        Zher = MB[i];
                                        // if (x == 2 && y == 6) SSS += "s=" + s;
                                    }
                                    else break;
                                }
                            var king = MATRW[xk, yk];
                            if (king.Contains("Q") || king.Contains("R") || king.Contains("B") || king.Contains("N") || king.Contains("P")) shah = true;
                            king = MATRB[xK, yK];
                            if (king.Contains("q") || king.Contains("r") || king.Contains("b") || king.Contains("n") || king.Contains("p")) shah = true;

                            
                            if (hodit == 'w' && F > 0) v = v + s * k10; if (hodit == 'w' && F > 0 && shah) v = v + s * k100;
                            if (hodit == 'b' && F > 0) { v = v + s * k100; OPAS += 1; }
                            if (hodit == 'b' && F < 0) v = v + s * k10; if (hodit == 'b' && F < 0 && shah) v = v + s * k100;
                            if (hodit == 'w' && F < 0) { v = v + s * k100; OPAS += 1; }
                        
                        

                    }
     
                }
        if (CF < 10)///эндшпиль
        {
            var centrK = Convert.ToInt32(50 * Math.Sqrt((xK - 4.5) * (xK - 4.5) + (yK - 4.5) * (yK - 4.5)));
            var centrk = Convert.ToInt32(50 * Math.Sqrt((xk - 4.5) * (xk - 4.5) + (yk - 4.5) * (yk - 4.5)));
            var Kk = Convert.ToInt32(50 * Math.Sqrt((xk - xK) * (xk - xK) + (yk - yK) * (yk - yK)));
            if (p.Contains("Q") == false && p.Contains("R") == false && p.Contains("B") == false && p.Contains("N") == false) ///голый король у белых
            {
                v -= centrK;
                v += Kk;
                if (centrK > centrk) v -= 50;
               // v += centrk - centrK;
            }
            if (p.Contains("q") == false && p.Contains("r") == false && p.Contains("b") == false && p.Contains("n") == false)///голый король у черных
            {
                v += centrk;
                v -= Kk;
                if (centrk > centrK) v += 50;
              //  v += centrk - centrK;
            }
        }           
        if (CF > 25) ///дебют
        {           
            if (yK > 1) v -= 9;
            if (yK == 1 && xK == 6) v -= 9;
            if (yK == 1 && xK == 4) v -= 9;
            if (yK == 1 && xK == 7) v += 9;
            if (yK == 1 && xK == 3) v += 9;
            if (yk < 8) v += 9;
            if (yk == 8 && xk == 6) v += 9;
            if (yk == 8 && xk == 4) v += 9;
            if (yk == 8 && xk == 7) v -= 9;
            if (yk == 8 && xk == 3) v -= 9;
        }
        if (CF>=10)///дебют и миттельшпиль
        {
            if (BOAR[2, 1] == 'N' && BOAR[1, 1] == 'R') v -= 25; if (BOAR[2, 8] == 'n' && BOAR[1, 8] == 'r') v += 25;///развитие легк фигур
            if (BOAR[7, 1] == 'N' && BOAR[8, 1] == 'R') v -= 25; if (BOAR[7, 8] == 'n' && BOAR[8, 8] == 'r') v += 25;
            //if (BOAR[3, 1] == 'B') v -= 25; if (BOAR[3, 8] == 'b') v += 25;
            //if (BOAR[6, 1] == 'B') v -= 25; if (BOAR[6, 8] == 'b') v += 25;
            if (BOAR[3, 1] == 'B' && BOAR[2, 2] == 'P' && BOAR[4, 2] == 'P') v -= 25;
            if (BOAR[3, 8] == 'b' && BOAR[2, 7] == 'p' && BOAR[4, 7] == 'p') v += 25;
            if (BOAR[6, 1] == 'B' && BOAR[5, 2] == 'P' && BOAR[7, 2] == 'P') v -= 25;
            if (BOAR[6, 8] == 'b' && BOAR[5, 7] == 'p' && BOAR[7, 7] == 'p') v += 25;
            if (BOAR[4, 3] == 'B' && BOAR[4, 2] == 'P') v -= 25;///запертые пешки слонами
            if (BOAR[5, 3] == 'B' && BOAR[5, 2] == 'P') v -= 25;///запертые пешки слонами
            if (BOAR[4, 6] == 'b' && BOAR[4, 7] == 'p') v += 25;///запертые пешки слонами
            if (BOAR[5, 6] == 'b' && BOAR[5, 7] == 'p') v += 25;///запертые пешки слонами
        }

        /*if ((BOAR[0, 1] == 'K') &&  BOAR[5, 1] == 'K' && BOAR[6, 1] == ' ' && BOAR[7, 1] == ' ' && BOAR[8, 1] == 'R') ////короткая р белых
            v += 10;///MyList.Add("Ke1-g1 0-0");
        if ((BOAR[0, 2] == 'Q') &&  BOAR[1, 1] == 'R' && BOAR[2, 1] == ' ' && BOAR[3, 1] == ' ' && BOAR[4, 1] == ' ' && BOAR[5, 1] == 'K') ////дл р белых
            v += 10;///MyList.Add("Ke1-c1 0-0-0");
        if ((BOAR[0, 3] == 'k') &&  BOAR[5, 8] == 'k' && BOAR[6, 8] == ' ' && BOAR[7, 8] == ' ' && BOAR[8, 8] == 'r') ////короткая р ч
            v -= 10;///MyList.Add("Ke8-g8 0-0");
        if ((BOAR[0, 4] == 'q') &&  BOAR[1, 8] == 'r' && BOAR[2, 8] == ' ' && BOAR[3, 8] == ' ' && BOAR[4, 8] == ' ' && BOAR[5, 8] == 'k') ////дл р ч
            v -= 10;/// MyList.Add("Ke8-c8 0-0-0");*/


        return Convert.ToInt32(v);
    }
    public float MatrSum(string p)
    {
        p = p + "";
        var v = 0f;
        if (p.Length > 0) for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != 'k' && p[i] != 'K') v += Math.Sign(Cena(p[i]));
 if (p[i] == 'K' && p.Contains("q") == false && p.Contains("r") == false && p.Contains("b") == false && p.Contains("n") == false && p.Contains("p") == false && p.Contains("k") == false)  v += 1;
 if (p[i] == 'k' && p.Contains("Q") == false && p.Contains("R") == false && p.Contains("B") == false && p.Contains("N") == false && p.Contains("P") == false && p.Contains("K") == false)  v += -1;
    }

                
                return v;
    }
    public string Porangu(string p)
    { var v = "";
        if (p.Length > 1)
        {
            if (p.Contains("p")) v += 'p';
            if (p.Contains("P")) v += 'P';
            if (p.Contains("n")) v += 'n';
            if (p.Contains("N")) v += 'N';
            if (p.Contains("b")) v += 'b';
            if (p.Contains("B")) v += 'B';
            if (p.Contains("r")) v += 'r';
            if (p.Contains("R")) v += 'R';
            if (p.Contains("q")) v += 'q';
            if (p.Contains("Q")) v += 'Q';
            if (p.Contains("k")) v += 'k';
            if (p.Contains("K")) v += 'K';
        }
        else v = p;
        return v;            
    }
    public char Major(string p)
    {
        var v = ' ';
        if (v == ' ' && p.Contains("q")) v = 'q';
        if (v == ' ' && p.Contains("Q")) v = 'Q';
        if (v == ' ' && p.Contains("r")) v = 'r';
        if (v == ' ' && p.Contains("R")) v = 'R';
        if (v == ' ' && p.Contains("b")) v = 'b';
        if (v == ' ' && p.Contains("B")) v = 'B';
        if (v == ' ' && p.Contains("n")) v = 'n';
        if (v == ' ' && p.Contains("N")) v = 'N';
        if (v == ' ' && p.Contains("p")) v = 'p';
        if (v == ' ' && p.Contains("P")) v = 'P';


        return v;
    }
    public char Minor(string p)
    {
        var v = ' ';
        if (v == ' ' && p.Contains("p")) v = 'p';
        if (v == ' ' && p.Contains("P")) v = 'P';
        if (v == ' ' && p.Contains("n")) v = 'n';
        if (v == ' ' && p.Contains("N")) v = 'N';
        if (v == ' ' && p.Contains("b")) v = 'b';
        if (v == ' ' && p.Contains("B")) v = 'B';
        if (v == ' ' && p.Contains("r")) v = 'r';
        if (v == ' ' && p.Contains("R")) v = 'R';
        if (v == ' ' && p.Contains("q")) v = 'q';
        if (v == ' ' && p.Contains("Q")) v = 'Q';
        return v;
    }
    public string Draw(string p)
    {
        var v = "";
        var BOAR = BoardLoad(p);
        if ((int)BOAR[0, 7] >= 50) { v = "НИЧЬЯ / В течении 50 ходов ни одна фигура не была взята и ни одна пешка не сходила"; }

        var f = 0; var b = 0; var n = 0;
        for (int i = 1; i <= 8; i++)
            for (int j = 1; j <= 8; j++)
            {
                if (BOAR[i, j] != ' ') f += 1;
                if (BOAR[i, j] == 'B' || BOAR[i, j] == 'b') b += 1;
                if (BOAR[i, j] == 'N' || BOAR[i, j] == 'n') n += 1;
            }
        if ((f == 2) || (f == 3 && b == 1) || (f == 3 && n == 1)) { v = "НИЧЬЯ / Недостаточно фигур для мата"; }

        if (PartyPov.Count > 1)
        {
              var p0 = "";
            for (int i = 0; i < PartyPov.Count; i++)
                if (p.Contains(PartyPov[i]))
                {                   
                    p0 = PartyPov[i];
                }
            if (p0!="")
            {
                v = "НИЧЬЯ / Троекратным повтором позиции. На ";
                for (int i = 0; i < Party.Count; i++)
                if (Party[i].Contains(p0))
                {
                        v += i/2+1 + "-м ";
                }
                v += "и "+ (Party.Count/2+1)+"-м ходу.";
            }
        }


        return v;
    }


    public int CountF(string p)
    {
        var v = 0;  //var v0 = 0; var v1 = 0;
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i] == 'k') v += 1;
            if (p[i] == 'q') v +=1;
            if (p[i] == 'r') v += 1;
            if (p[i] == 'n') v += 1;
            if (p[i] == 'b') v += 1;
            if (p[i] == 'p') v += 1;

            if (p[i] == 'K') v += 1;
            if (p[i] == 'Q') v += 1;
            if (p[i] == 'R') v += 1;
            if (p[i] == 'N') v += 1;
            if (p[i] == 'B') v += 1;
            if (p[i] == 'P') v += 1;
            if (p[i] == ' ') break;
        }
        return v;
    }
    
    public static int BalansF(string p)
    {
        var v = 0;  var v0 = 0f; var v1 = 0f;
        var kkk = false; var KKK = true;
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i] == 'k') { v0 += 29; kkk = true; };
            if (p[i] == 'q') v0 += 9;
            if (p[i] == 'r') v0 += 5;
            if (p[i] == 'n') v0 += 2.9f;
            if (p[i] == 'b') v0 += 3;
            if (p[i] == 'p') v0 += 1;

            if (p[i] == 'K') { v1 += 29; KKK = true; }
            if (p[i] == 'Q') v1 += 9;
            if (p[i] == 'R') v1 += 5;
            if (p[i] == 'N') v1 += 2.9f;
            if (p[i] == 'B') v1 += 3;
            if (p[i] == 'P') v1 += 1;
            if (p[i] == ' ') break;
        }
        
        v = Mathf.FloorToInt( 100 * (v1-v0));
       /* if (v1 != v0)
        {
            if (v1 != 0) if (v0 > v1) { v = Mathf.FloorToInt(100 * (v0 / v1) * (v1 - v0) ); }
            if (v0 != 0) if (v0 < v1) { v = Mathf.FloorToInt(100 * (v1 / v0) * (v1 - v0) ); }
        }
        if (kkk == false) v = 9990;
        if (KKK == false) v = -9990;*/
        return v;
    }

    public int Balans(string p)
    {
        var v = 0;
        var dr = Draw(p);
        if (dr != "")
        {
            if (p.Contains(" w ")) v = 0;
            if (p.Contains(" b ")) v = 0;
             
        }
        else
        {
            var bf = BalansF(p);
            v = bf;
           
             v = v + VariantsBal(p);
          

        }
        return v;
    }
    public int BalansBOARD( char[,] BOAR)
    {
        var v = 0;
            ///var bf = BalansBOARF(BOAR);            v = bf;

            //   v = v + VariantsBal(p);
            v = v + BalSil(BOAR);

        
        return v;
    }
    
    public string Left(string p, int n)
    {
        p += "   ";
        var v = ""; for (int i = 0; i < p.Length; i++)
        {
            v += p[i]; if (i + 1 == n) break;
        }
        return v;
    }
    public  string Right(string p, int n)
    {
        var v = "";
        if (p.Length >= n) for (int i = p.Length - n; i < p.Length; i++) v += p[i];

        return v;
    }
   /* public List<string> VarPos(string p)
    {
        var v = new List<string>();
        var Next = Variants(p, 1);
        for (int i = 0; i < Next.Count; i++) { var p1 = HOD(p, Next[i]); v.Add(p1); }
        return v;
    }*/

    public void Poradok( )
    { var n = 0;
        var b = BalansF(Pos);
       
        if ((Pos.Contains(" w ") && b > 50) || (Pos.Contains(" b ") && b < -50))/////убирание поторов ведущих к ничье для лидера
            if (MyList.Count>1 )
        for (int i = 0; i < MyList.Count-1; i++)
        {
                    var text = "";
       
            var p1 = HOD(Pos, MyList[i]);var s = 0;
            for (int j = 0; j < PartyPov0.Count; j++)
            if (p1.Contains(PartyPov0[j]) )
            {
                            text += ", Искл.ход " + MyList[i];
                            TextBug.GetComponent<Text>().text = text;
                                             
                            MyList[i] = ""+i ;s += 1;
            }
                if (MyList.Count-s<2) break;
        }

        n = MyList.Count;
        for (int i = 0; i < n; i++) MyList.Remove("" + i);/////убирание поторов
       

        while (1==1)
        {
            var h = 0;
            for (int i = 1; i < MyList.Count; i++)
            {
                var b1 = BAL[i - 1]; var b2 = BAL[i]; var hh = MyList[i - 1]; var ll = LEV[i - 1];

                if (b1 < b2)
                { BAL[i - 1]=b2; BAL[i] = b1;
                    MyList[i - 1] = MyList[i]; MyList[i] = hh;
                    LEV[i - 1] = LEV[i]; LEV[i] = ll;
                    h += 1;
                };
                //if (MIN > b && mx==false) { b = MIN; h = V[i]; };
            }
            if (h == 0) break;
        }
       

    }
    
   
    public List<string> Variants2(string p, int lev) ///side = -1 ход не в свою очередь side = 2 только взятия
    {
        var MyList = Variants(p, 1);
        var BAL = new List<int>();
        for (int i = 0; i < MyList.Count; i++)
        {
            var B = 0;
            var h1 = MyList[i];
            var p1 = HOD(p, h1);
            
            var b1 = Balans(p1); //if (p1.Contains(" w ")) B1 = -b1; else B1 = b1;
            if (p.Contains(" b ")) B = -b1; else B = b1;
            BAL.Add(B);
        }
        while (1 == 1)
        {
            var h = 0;
            for (int i = 1; i < MyList.Count; i++)
            {
                var b1 = BAL[i - 1]; var b2 = BAL[i]; var hh = MyList[i - 1];

                if (b1 < b2) { BAL[i - 1] = b2; BAL[i] = b1; MyList[i - 1] = MyList[i]; MyList[i] = hh; h += 1; };
                //if (MIN > b && mx==false) { b = MIN; h = V[i]; };
            }
            if (h == 0) break;
        }
        /*  var s = 0; var j = 0; for (int i = 1; i < MyList.Count - 7; i++) { j += 1; s += BAL[i]; }
          var SR = s / j;*/
       /// if (lev >= 2) KF = lev;
        var n = MyList.Count;
        var n1 = n/KF;
        if (n1 < 2) n1 = 2;
        if (n > 2)
        {
            for (int i = n1; i < n; i++) if (MyList[i].Contains(":")==false && MyList[i].Contains("+") == false) MyList[i] = i + "";
            for (int i = n1; i < n; i++) MyList.Remove(i + "");
        }
        
        return MyList;
    }
    public int Ocenka(string p, int A, int J)
    {
        var B = 0; //var p1 = ""; var h1 = "";
        MyList[A] = Left(MyList[A], 8)+"/0";
                var h0 = MyList[A];
                var p0 = p;
        var JJ = " 1111";
        if (J == 2) JJ = " 2111";
        if (J == 3) JJ = " 3222";
        if (J == 4) JJ = " 4333";
        if (J == 5) JJ = " 5444";
        if (J == 6) JJ = " 6555";
        if (J == 7) JJ = " 7666";
        if (J == 8) JJ = " 8777";
        if (J == 9) JJ = " 9888";
        if (J >= 9) JJ = " 9999";
        var N = 0; var p1 = ""; var h1 = "";
        for (int i = 1; i <=4; i++)
        {
            N = Convert.ToInt32(JJ[i])-48; //Debug.Log("N=" + N);
            p1 = HOD(p0, h0);
            h1 = BestR("", p1, 0, J);
            MyList[A] += Left(h1, 8) + "/"+ JJ[i];
            p0 = p1;
            h0 = h1;
            if (h0[3]!='-' && h0[3] != ':' ) break; 
        }
        //        var pb = BoardLoad(p0);
        if (h0[3] != '-' && h0[3] != ':') B = Convert.ToInt32(Right(h0, 5)); else { var pb = BoardLoad(p0); B = BalSil(pb); }


        

        return B;
    }
    public string BestRR(string H, char[,] BOAR1,  int LEV, int LEV2, int op)
    {
        var Lf = ""; var draw = false;
        var BOAR = new char[9, 9]; for (int x = 0; x <= 8; x++) for (int y = 0; y <= 8; y++)
            {
                BOAR[x, y] = BOAR1[x, y];
                if (x > 0 && x < 9 && y > 0 && y < 9 && BOAR[x, y] != ' ' && BOAR[x, y] != 'k' && BOAR[x, y] != 'K') Lf += BOAR[x, y];
            }
        if (Lf == "" || Lf == "N" || Lf == "B" || Lf == "n" || Lf == "b" ) draw = true;

        if (LEV == 0)
        {
            drv = ""; //glub = 0;
        }
        ttt += 1;
        /// else { ttt += 1; /*if (ttt > 500000 && LEV > 1) { LEV2 -= 1; }*/ }
        if (LEV > glub) glub = LEV;
        var v = "";
        var Next = new List<string>();
        //if (Next.Count<=40)  Next = Variants(p, 1); else  Next = Variants2(p, LEV);
        ///  Next = Variants(p, 1);      
        Debug.Log("Lf=" + Lf);
        if (draw ) { v = Left("  0  ", 5); AAA[8, 8].GetComponentInChildren<Text>().text = "ничья"; Debug.Log("Lf=" + Lf); }
      else
        {
            Next = VariantsBOAR(BOAR);
            if (Next.Count == 0)
            {
                var p = BoardSave(BOAR);
                if (PodSHAH(p, -1) == 0)////пат 
                {
                    v = Left("  0  ", 5);
                }
                if (PodSHAH(p, -1) > 0)////мат
                {
                    if (p.Contains(" b ")) { v = Left(9990 + "", 5); }
                    if (p.Contains(" w ")) { v = Left(-9990 + "", 5); }
                }
            }

        }


        ///////////////////////////// if (Next.Count == 1) { v = Next[0]; var h1 = Next[0]; var p1 = HOD(p, h1); var b0 = Balans1(p1); v = Left(h1, 7) + Left(b0 + "", 5); }
        if (v == "") ///если больше 2
        {
            var B = 0; var max = -9999; var min = 9999; var h2 = ""; var vmax = ""; var vmin = "";
            var nn = Next.Count;
            if (Part == 2)
            {
                ///сортировка и отбраковка
                var BL = new List<int>(); var SR = 0;
                for (int i = 0; i < nn; i++)
                {
                    var pp1 = HODBOAR(BOAR, Next[i]); BL.Add(BalSil(pp1));
                }
                for (int i = 0; i < nn; i++) SR += BL[i];
                SR = SR / nn;
                for (int i = 0; i < nn; i++)
                {
                    if (BL[i] < SR) Next[i] = i + "";
                }
                for (int i = 0; i < nn; i++) Next.Remove(i + "");
                nn = Next.Count;
            }

            for (int i = 0; i < nn; i++)              
            {
                //var t1 = DateTime.Now.AddSeconds(2);
                var h1 = Next[i] + " .";                
                var pp1 = HODBOAR(BOAR, h1);

                if (LEV < LEV2 && dat> DateTime.Now)////детальное уточнение B
                {
                    
                    h2 = BestRR(h1, pp1, LEV + 1, LEV2, op);
                    //////   SSS = "h2=(" + h2 + ")";
                    
                    B = Convert.ToInt32(Right(h2, 5));
                   /// if (ttt > Limit) break;
                }
                else
                {
                    //if (LEV >= 3) { var p1 = BoardSave(pp1); B = Balans(p1); } else                     B = BalansBOARD(pp1);
                    // if (Part == 1)
                    /* {
                         B = 0; for (int x = 1; x <= 8; x++) for (int y = 1; y <= 8; y++) if (BOAR[x, y]!=' ') B+=100*Cena(BOAR[x,y]);
                     }*/
                    ///if (Part==2)          

                    B = BalSil(pp1);
                    //var p1 = BoardSave(pp1); B = VariantsBal(p1)+BalansF(p1); 
                }
                //if (DateTime.Now > t1) KF += 1;

                if (B > max && BOAR[0,0]=='w' )
                {
                    max = B; vmax = h2 + Next[i] + " " + LEV + "." ;
                    
                }
                if (B < min && BOAR[0, 0] == 'b')
                {
                    min = B; vmin = h2 + Next[i] + " " + LEV + "." ;
                   
                }

            }
            //  Drevo.Add("p.Contains( w )" + p.Contains(" w ") + "p.Contains( b )" + p.Contains(" b "));
            if (LEV == 0)
            {
                if (BOAR[0, 0] == 'w') { v = vmax + " {"   + "} " + Left(max + "", 5); /*NABOR[LEV].Add("w MAX=" + vmax+  "max=" + max);*/ }
                if (BOAR[0, 0] == 'b') { v = vmin + " {"   + "} " + Left(min + "", 5); /*NABOR[LEV].Add("b MIN=" + vmax + "min=" + min);*/ }
            }
            else
            {
                if (BOAR[0, 0] == 'w') { v = vmax + " " + Left(max + "", 5); /*NABOR[LEV].Add("w MAX=" + vmax+  "max=" + max);*/ }
                if (BOAR[0, 0] == 'b') { v = vmin + " " + Left(min + "", 5); /*NABOR[LEV].Add("b MIN=" + vmax + "min=" + min);*/ }
            }


        }


        //if (LEV == 0) { v = v + " {" + drv + "}"; }
        return H + v;
    }
    public string BestR(string H, string p, int LEV, int LEV2)
    {
        ///var draw = "";
        if (LEV == 0)
        {
            drv = ""; //glub = 0;
        }
        ttt += 1;
        /// else { ttt += 1; /*if (ttt > 500000 && LEV > 1) { LEV2 -= 1; }*/ }
        if (LEV > glub) glub = LEV;
        var v = "";
        var Next = new List<string>();
        //if (Next.Count<=40)  Next = Variants(p, 1); else  Next = Variants2(p, LEV);
         Next = Variants(p, 1);
       
        if (Next.Count == 0)
        {
            if (PodSHAH(p, -1) == 0)////пат 
            {
                v = Left("  0  ", 5);
            }
            if (PodSHAH(p, -1) > 0)////мат
            {
                if (p.Contains(" b ")) { v = Left(9990 + "", 5); }
                if (p.Contains(" w ")) { v = Left(-9990 + "", 5); }
            }
        }

        ///////////////////////////// if (Next.Count == 1) { v = Next[0]; var h1 = Next[0]; var p1 = HOD(p, h1); var b0 = Balans1(p1); v = Left(h1, 7) + Left(b0 + "", 5); }
        if (v == "") ///если больше 2
        {
            var B = 0; var max = -9999; var min = 9999; var h2 = ""; var vmax = ""; var vmin = "";
            var nn = Next.Count;
            for (int i = 0; i < nn; i++)
            {
                //var t1 = DateTime.Now.AddSeconds(2);
                var h1 = Next[i] + " .";
                
                var p1 = HOD(p, h1);

                if (LEV < LEV2 && dat > DateTime.Now)////детальное уточнение B
                {
                    h2 = BestR(h1, p1, LEV + 1, LEV2);
                    //////   SSS = "h2=(" + h2 + ")";
                    B = Convert.ToInt32(Right(h2, 5));
                    /// if (ttt > Limit) break;
                }
                else
                {
                    B = Balans(p1);
                    ///if (Part==1) B = BalansF(p1); else B = Balans(p1);
                }
                //if (DateTime.Now > t1) KF += 1;

                if (B > max && p.Contains(" w "))
                {
                    // if (h2.Contains("Bg8-f6")  )  if (LEV == 0) Drevo.Add(h2 + "max=(" + max + ") сменяет " + draw + Next[i] + "(" + B + ")");
                    max = B; vmax = h2 ;
                    // Debug.Log(h2);
                }
                if (B < min && p.Contains(" b "))
                {
                    //  if (h2.Contains("Bg8-f6") || h2.Contains("-b7")) if (LEV == 0) Drevo.Add(h2 + "min=(" + min + ") сменяет " + draw + Next[i] + "(" + B + ")");
                    min = B; vmin = h2 ;
                    // Debug.Log(h2);
                }

            }
            //  Drevo.Add("p.Contains( w )" + p.Contains(" w ") + "p.Contains( b )" + p.Contains(" b "));
            if (LEV == 0)
            {
                if (p.Contains(" w ")) { v = vmax + " {" + p + "} " + Left(max + "", 5); /*NABOR[LEV].Add("w MAX=" + vmax+  "max=" + max);*/ }
                if (p.Contains(" b ")) { v = vmin + " {" + p + "} " + Left(min + "", 5); /*NABOR[LEV].Add("b MIN=" + vmax + "min=" + min);*/ }
            }
            else
            {
                if (p.Contains(" w ")) { v = vmax + " " + Left(max + "", 5); /*NABOR[LEV].Add("w MAX=" + vmax+  "max=" + max);*/ }
                if (p.Contains(" b ")) { v = vmin + " " + Left(min + "", 5); /*NABOR[LEV].Add("b MIN=" + vmax + "min=" + min);*/ }
            }


        }


        //if (LEV == 0) { v = v + " {" + drv + "}"; }
        return H + v;
    }
    public void NoDraw(string p)
    {
        var nodraw = false;
        //while (MyList.Count > 1 && nodraw == false)
        {
            nodraw = true;
            if (MyList.Count>1)
            for (int i = 1; i < MyList.Count; i++)
            {
                var h1 = MyList[i]; var p1 = HOD(p, h1);
                var v = Draw(p1); if (v != "") { nodraw = false; MyList[i] = i + ""; }
            }
            if (nodraw == false) for (int i = 0; i < MyList.Count; i++) MyList.Remove(i + "");
          ///  if (nodraw || MyList.Count == 1) break;
        }
    }
    
    
    public int Cena(char c)
    {
        var v = 0;
        if (c == 'p') v = -1; if (c == 'P') v = 1;
        if (c == 'n' || c == 'b') v = -3;  if (c == 'N' || c == 'B') v = 3;
        if (c == 'r') v = -5; if (c == 'R') v = 5;
        if (c == 'q') v = -9; if (c == 'Q') v = 9;
        if (c == 'k') v = -3; if (c == 'K') v = 3;
        return v;
    }
    public int VariantsBal(string p) ///side = -1 ход не в свою очередь side = 2 только взятия
    {
        var v = 0; var SumF = 0;
        var z = 0;
       /// var MyList = new List<string>();
        var x1 = 0; var y1 = 0; //var x2 = 0; var y2 = 0;// var x3 = 0; var y3 = 0;        var z = 0;
        var h0 = "";
        var BOAR = BoardLoad(p);
        var drug = BOAR[0, 0]; var vrag = ' ';
        if (BOAR[0, 0] == 'w') vrag = 'b';
        if (BOAR[0, 0] == 'b') vrag = 'w';
        var hodit = BOAR[0, 0];
        var xK = 0; var yK = 0; var xk = 0; var yk = 0;
        var xB = 0; var yB = 0; var xb = 0; var yb = 0;
        var xN = 0; var yN = 0; var xn = 0; var yn = 0;
        ///ход пешкой
        var Wprohx = 0; var Wprohy = 0;
        var Bprohx = 0; var Bprohy = 0;
        for (int x = 1; x <= 8; x++)
        {
            var pawn = "";

            for (int y = 1; y <= 8; y++)
                if (BOAR[x, y] != ' ')
                {
                    SumF += 1;
                    var fig = BOAR[x, y];
                   
                    if (fig == 'N') { xN = x; yN = y; };
                        if (fig == 'n') { xn = x; yn = y; };
                        if (fig == 'B') { xB = x; yB = y; };
                        if (fig == 'b') { xb = x; yb = y; };
                        if (fig == 'K') { xK = x; yK = y; };
                        if (fig == 'k') { xk = x; yk = y; };
                    
                    
                    
                    
                    if (fig == 'P') { pawn += fig; Wprohx = x; Wprohy = y; }
                    if (fig == 'p')
                    {
                        if (pawn == "") { Bprohx = x; Bprohy = y; };
                        pawn += fig;
                    }

                    if ("QRNBPK".Contains(fig + "")) { z = 1;  drug = 'w'; vrag = 'b'; }
                    if ("qrnbpk".Contains(fig + "")) { z = -1; drug = 'b'; vrag = 'w'; }
                    ///ход пешкой w
                    if (fig == 'P' )
                    {  h0 = " " + PointToString(x, y); var EP = "";
                        if (BOAR[x, y + 1] == ' ') v += 1;
                        if (y == 2) if (BOAR[x, y + 1] == ' ' && BOAR[x, y + 2] == ' ') v += 1; ///ход 2 поля
                        if (x < 8) ///бей вправо
                        {
                            if (Cvet(BOAR[x + 1, y + 1]) == vrag)                v += -Cena(BOAR[x + 1, y + 1]);///MyList.Add(h0 + ":" + PointToString(x + 1, y + 1)); ///бить без превращения
                            if (Cvet(BOAR[x + 1, y + 1]) == vrag && hodit==drug) v += -Cena(BOAR[x + 1, y + 1]);
                            if (Cvet(BOAR[x + 1, y + 1]) == drug) v += 1;///MyList.Add(h0 + ":" + PointToString(x + 1, y + 1)); ///бить без превращения
                                 if (BOAR[x + 1, y + 1] == 'P') v += 1;///MyList.Add(h0 + ":" + PointToString(x + 1, y + 1)); ///бить без превращения
                            EP = PointToString(x + 1, y + 1);
                        
                        }
                        if (x > 1) ///бей влево
                        {
                            if (Cvet(BOAR[x - 1, y + 1]) == vrag)                  v += -Cena(BOAR[x - 1, y + 1]);///MyList.Add(h0 + ":" + PointToString(x - 1, y + 1)); ///бить
                            if (Cvet(BOAR[x - 1, y + 1]) == vrag && hodit == drug) v += -Cena(BOAR[x - 1, y + 1]);
                            if (Cvet(BOAR[x - 1, y + 1]) == drug) v += 1;///MyList.Add(h0 + ":" + PointToString(x - 1, y + 1)); ///бить
                                 if (BOAR[x - 1, y + 1] == 'P') v += 1;
                            EP = PointToString(x - 1, y + 1);
                           
                        }                        
                        ///Потенциал
                        v += 5*y; if (y == 7) v += 450; if (y == 6) v += 150;
                        ///
                    }
                    ///ход пешкой b
                    if (fig == 'p' )
                    {                  h0 = " " + PointToString(x, y); var EP = "";
                        if (BOAR[x, y - 1] == ' ') v -= 1;
                        if (y == 7) if (BOAR[x, y - 1] == ' ' && BOAR[x, y - 2] == ' ') v -= 1; ///ход 2 поля
                        if (x < 8)
                        {
                            if (Cvet(BOAR[x + 1, y - 1]) == vrag)                  v += -Cena(BOAR[x + 1, y - 1]); ///MyList.Add(h0 + ":" + PointToString(x + 1, y - 1)); ///
                            if (Cvet(BOAR[x + 1, y - 1]) == vrag && hodit == drug) v += -Cena(BOAR[x + 1, y - 1]);
                            if (Cvet(BOAR[x + 1, y - 1]) == drug) v += -1;///MyList.Add(h0 + ":" + PointToString(x + 1, y - 1)); ///
                                 if (BOAR[x + 1, y - 1] == 'p') v += -1;
                            EP = PointToString(x + 1, y - 1);
                        
                        }
                        if (x > 1)
                        {
                            if (Cvet(BOAR[x - 1, y - 1]) == vrag)                  v += -Cena(BOAR[x - 1, y - 1]);///MyList.Add(h0 + ":" + PointToString(x - 1, y - 1)); ///
                            if (Cvet(BOAR[x - 1, y - 1]) == vrag && hodit == drug) v += -Cena(BOAR[x - 1, y - 1]);
                            if (Cvet(BOAR[x - 1, y - 1]) == drug) v += -1;///MyList.Add(h0 + ":" + PointToString(x - 1, y - 1)); ///
                                 if (BOAR[x - 1, y - 1] == 'p') v += -1;
                            EP = PointToString(x - 1, y - 1);
                         
                        }
                        //   if (y == 2) p72 = true;////могут быть превращения
                        ///Потенциал
                        v += 5*(y - 9); if (y == 2 ) v -= 450; if (y == 3) v -= 150;
                        ///
                    }

            
                    if (fig == 'N' || fig == 'n') //конь
                    {


                        h0 = 'N' + PointToString(x, y);
                        for (int dx = -2; dx <= 2; dx++)
                            if (dx != 0)
                                for (int dy = -2; dy <= 2; dy++)
                                    if (dy != 0 && dy != dx && dy != -dx)
                                    {
                                        x1 = x + dx; y1 = y + dy;
                                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                        {
                                            if (BOAR[x1, y1] == ' ') v += z;///MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                            if (Cvet(BOAR[x1, y1]) == vrag)
                                            { var c = Cena(BOAR[x1, y1]);
                                                v += z  ;///MyList.Add(h0 + ":" + PointToString(x1, y1));
                                                if (hodit == drug)
                                                {
                                                    v += z;
                                                    /*var a1 = PodSHAH2(x, y, p, 1); var a2 = PodSHAH2(x, y, p, -1);
                                                    if (p.Contains(" w ") && drug == 'w' && a1 > a2)  v += - c * (a1 - a2)*10;
                                                    if (p.Contains(" b ") && drug == 'b' && a1 > a2)  v += - c * (a1 - a2)*10;*/
                                                }
                                              //  if (c * c > 9) v += -c*10;///фигура сильнее коня
                                            }
                                            if (Cvet(BOAR[x1, y1]) == drug) v += z;///v += Cena(fig);///MyList.Add(h0 + ":" + PointToString(x1, y1));
                                        }


                                    }                       
                        
                    }
                    if ((fig == 'B' && drug == 'w') || (fig == 'b' && drug == 'b') //слон
                      || (fig == 'Q' && drug == 'w') || (fig == 'q' && drug == 'b') //ферзь
                      || (fig == 'K' && drug == 'w') || (fig == 'k' && drug == 'b')) //кр
                    {
                        if (fig == 'B' || fig == 'b') h0 = 'B' + PointToString(x, y);
                        if (fig == 'Q' || fig == 'q') h0 = 'Q' + PointToString(x, y);
                        if (fig == 'K' || fig == 'k') h0 = 'K' + PointToString(x, y);
                        for (int dx = -1; dx <= 1; dx++)
                            if (dx != 0)
                                for (int dy = -1; dy <= 1; dy++)
                                    if (dy != 0)
                                    {
                                        for (int i = 1; i <= 8; i++)
                                        {
                                            if ((fig == 'K' || fig == 'k') && i > 1) break;
                                            x1 = x + dx * i; y1 = y + dy * i;
                                            if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                            if (Cvet(BOAR[x1, y1]) == drug) break;
                                            if (BOAR[x1, y1] == ' ') v += z;///MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                            if (Cvet(BOAR[x1, y1]) == vrag)
                                            {
                                                 var c = Cena(BOAR[x1, y1]);
                                                v += z;
                                                if (hodit == drug) v += z ;
                                                // if (c * c > 9) v += -c * 10;///фигура сильнее слона
                                                break;
                                            }
                                            if (Cvet(BOAR[x1, y1]) == drug) { v += z; ; break; }
                                        }
                                    }
                    }
                    if ((fig == 'R' && drug == 'w') || (fig == 'r' && drug == 'b') //ладья
                      || (fig == 'Q' && drug == 'w') || (fig == 'q' && drug == 'b') //ферзь
                      || (fig == 'K' && drug == 'w') || (fig == 'k' && drug == 'b')) //кр
                    {
                        if (fig == 'R' || fig == 'r') h0 = 'R' + PointToString(x, y);
                        if (fig == 'Q' || fig == 'q') h0 = 'Q' + PointToString(x, y);
                        if (fig == 'K' || fig == 'k') h0 = 'K' + PointToString(x, y);
                        for (int dx = -1; dx <= 1; dx++)
                            // if (dx != 0)
                            for (int dy = -1; dy <= 1; dy++)
                                if (dy * dy != dx * dx)
                                {
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        if ((fig == 'K' || fig == 'k') && i > 1) break;
                                        x1 = x + dx * i; y1 = y + dy * i;
                                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                        if (Cvet(BOAR[x1, y1]) == drug) break;
                                        if (BOAR[x1, y1] == ' ') v += z;///MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                        if (Cvet(BOAR[x1, y1]) == vrag)
                                        {
                                            var c = Cena(BOAR[x1, y1]);
                                            v += z;
                                            if (hodit == drug) v += z ;
                                            //  if (c * c > 25) v += -c * 10;///фигура сильнее ладьи
                                            break;
                                        }
                                        if (Cvet(BOAR[x1, y1]) == drug) { v += z; ; break; }
                                    }
                                }
                    }
                }
            if (pawn != "" )////есть пешки в ряду Х и эндшпиль
            {
                var l = pawn.Length; if (pawn[l - 1] != 'P') { Wprohx = 0; Wprohy = 0; }
                if (pawn.Contains("PP")) v -= 10; if (pawn.Contains("PPP")) v -= 20;
                if (pawn.Contains("pp")) v += 10; if (pawn.Contains("ppp")) v += 20;
            }
        }

        /////дебют
        
        if (SumF>25)
        {
          /*  for (int x = 4; x <= 5; x++)
                for (int y = 4; y <= 5; y++)
                {
                    if (Cvet(BOAR[x, y]) == 'w') v += 25; if (Cvet(BOAR[x, y]) == 'b') v -= 25;
                    if (PodSHAH2(x, y, p, 1 ) > 0 && p.Contains(" w ")) v += 5;
                    if (PodSHAH2(x, y, p, 1 ) > 0 && p.Contains(" b ")) v -= 5;
                    if (PodSHAH2(x, y, p, -1) > 0 && p.Contains(" w ")) v -= 5;
                    if (PodSHAH2(x, y, p, -1) > 0 && p.Contains(" b ")) v += 5;
                }*/
            if (yK > 1) v -= 9;
            if (yK == 1 && xK == 6) v -= 9;
            if (yK == 1 && xK == 4) v -= 9;
            if (yK == 1 && xK == 7) v += 9;
            if (yK == 1 && xK == 3) v += 9;

            if (yk < 8) v += 9;
            if (yk == 8 && xk == 6) v += 9;
            if (yk == 8 && xk == 4) v += 9;
            if (yk == 8 && xk == 7) v -= 9;
            if (yk == 8 && xk == 3) v -= 9;
         if ((BOAR[0, 1] == 'K') &&
                BOAR[5, 1] == 'K' && BOAR[6, 1] == ' ' && BOAR[7, 1] == ' ' && BOAR[8, 1] == 'R') ////короткая р белых
            v += 10;///MyList.Add("Ke1-g1 0-0");
        if ((BOAR[0, 2] == 'Q') &&
                BOAR[1, 1] == 'R' && BOAR[2, 1] == ' ' && BOAR[3, 1] == ' ' && BOAR[4, 1] == ' ' && BOAR[5, 1] == 'K') ////дл р белых
            v += 10;///MyList.Add("Ke1-c1 0-0-0");
        if ((BOAR[0, 3] == 'k') &&
                BOAR[5, 8] == 'k' && BOAR[6, 8] == ' ' && BOAR[7, 8] == ' ' && BOAR[8, 8] == 'r') ////короткая р ч
            v -= 10;///MyList.Add("Ke8-g8 0-0");
        if ((BOAR[0, 4] == 'q') &&
                BOAR[1, 8] == 'r' && BOAR[2, 8] == ' ' && BOAR[3, 8] == ' ' && BOAR[4, 8] == ' ' && BOAR[5, 8] == 'k') ////дл р ч
            v -= 10;/// MyList.Add("Ke8-c8 0-0-0");
            
                 
                 if (BOAR[2, 1] == 'N') v -= 50; if (BOAR[2, 8] == 'n') v += 50;///развитие легк фигур
                 if (BOAR[7, 1] == 'N') v -= 50; if (BOAR[7, 8] == 'n') v += 50;
                 if (BOAR[3, 1] == 'B') v -= 50; if (BOAR[3, 8] == 'b') v += 50;
                 if (BOAR[6, 1] == 'B') v -= 50; if (BOAR[6, 8] == 'b') v += 50;
                 
                 


            if (BOAR[4, 3] == 'B' && BOAR[4, 2] == 'P') v -= 25;///запертые пешки слонами
            if (BOAR[5, 3] == 'B' && BOAR[5, 2] == 'P') v -= 25;///запертые пешки слонами
            if (BOAR[4, 6] == 'b' && BOAR[4, 7] == 'p') v += 25;///запертые пешки слонами
            if (BOAR[5, 6] == 'b' && BOAR[5, 7] == 'p') v += 25;///запертые пешки слонами
        }
        if (BOAR[3, 1] == 'B' && Cvet(BOAR[2, 2]) == 'w' && Cvet(BOAR[4, 2]) == 'w') v -= 75;///запертые слоны
        if (BOAR[6, 1] == 'B' && Cvet(BOAR[5, 2]) == 'w' && Cvet(BOAR[7, 2]) == 'w') v -= 75;
        if (BOAR[3, 8] == 'b' && Cvet(BOAR[2, 7]) == 'b' && Cvet(BOAR[4, 7]) == 'b') v += 75;
        if (BOAR[6, 8] == 'b' && Cvet(BOAR[5, 7]) == 'b' && Cvet(BOAR[7, 7]) == 'b') v += 75;

        if (BOAR[2, 1] == 'N' && Cvet(BOAR[1, 3]) == 'w' && Cvet(BOAR[3, 3]) == 'w' && Cvet(BOAR[4, 2]) == 'w') v -= 75;///запертые кони
        if (BOAR[7, 1] == 'N' && Cvet(BOAR[6, 3]) == 'w' && Cvet(BOAR[8, 3]) == 'w' && Cvet(BOAR[5, 2]) == 'w') v -= 75;///запертые кони
        if (BOAR[2, 8] == 'n' && Cvet(BOAR[1, 6]) == 'b' && Cvet(BOAR[3, 6]) == 'b' && Cvet(BOAR[4, 7]) == 'b') v += 75;///запертые кони
        if (BOAR[7, 8] == 'n' && Cvet(BOAR[6, 6]) == 'b' && Cvet(BOAR[8, 6]) == 'b' && Cvet(BOAR[5, 7]) == 'b') v += 75;///запертые кони

        /////эндшпиль
        if (SumF < 10)
        {
            if (Wprohx != 0) v += Wprohy * Wprohy;
            if (Bprohx != 0) v -= (9 - Bprohy) * (9 - Bprohy);

            

            if (Wprohx != 0 && Wprohy != 0)
            {
                v -= Convert.ToInt32(Math.Sqrt((Wprohx - xK) * (Wprohx - xK) + (Wprohy - yK) * ( Wprohy - yK)));
            }
            if (Bprohx != 0 && Bprohy != 0)
            {
                v += Convert.ToInt32(Math.Sqrt((Bprohx - xk) * (Bprohx - xk) + (Bprohy - yk) * ( Bprohy - yk)));
            }

            var centrK = Convert.ToInt32(50 * Math.Sqrt((xK - 4.5) * (xK - 4.5) + (yK - 4.5) * (yK - 4.5)));
            var centrk = Convert.ToInt32(50 * Math.Sqrt((xk - 4.5) * (xk - 4.5) + (yk - 4.5) * (yk - 4.5)));
            var Kk = Convert.ToInt32(50 * Math.Sqrt((xk - xK) * (xk - xK) + (yk - yK) * (yk - yK)));
            if (p.Contains("Q") == false && p.Contains("R") == false && p.Contains("B") == false && p.Contains("N") == false) ///голый король у белых
            {
                v -= centrK; v += Kk;
                if (centrK > centrk) v -= 50; AAA[1, 3].GetComponentInChildren<Text>().text = "F="+ SumF;
                AAA[1, 1].GetComponentInChildren<Text>().text = "";
                AAA[8, 1].GetComponentInChildren<Text>().text = "";
                AAA[1, 8].GetComponentInChildren<Text>().text = "";
                AAA[8, 8].GetComponentInChildren<Text>().text = "";

                if (p.Contains("b") && p.Contains("n") && SumF==4 )///если конь и слон
                if (xK == 1 || xK == 8 || yK == 1 || yK == 8)
                    {
                    var Polusx1 = 0; var Polusy1 = 0; var Polusx2 = 0; var Polusy2 = 0; var v1 = 0;var v2 = 0;
                        if (Mathf.Repeat(xb + yb, 2) == 0)
                        {
                            Polusx1 = 1; Polusy1 = 1; Polusx2 = 8; Polusy2 = 8;
                            if (xn == 2 && (yn == 2 || yn == 4 || yn == 6)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                            if (yn == 7 && (xn == 3 || xn == 5 || xn == 7)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                            if (xn == 7 && (yn == 5 || yn == 3)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                            if (yn == 2 && (yn == 6 || yn == 4)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                        };
                    if (Mathf.Repeat(xb + yb, 2) == 1)
                        {
                            Polusx1 = 1; Polusy1 = 8; Polusx2 = 8; Polusy2 = 1;
                            if (xn == 7 && (yn == 2 || yn == 4 || yn == 6)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                            if (yn == 2 && (xn == 3 || xn == 5 || xn == 7)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                            if (xn == 2 && (yn == 5 || yn == 3)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                            if (yn == 7 && (yn == 6 || yn == 4)) { v -= 20; AAA[xn, yn].GetComponentInChildren<Text>().text = "n"; }
                        }
                    AAA[Polusx1, Polusy1].GetComponentInChildren<Text>().text = "1";
                    AAA[Polusx1, Polusy1].GetComponentInChildren<Text>().color = Blaky;
                    AAA[Polusx2, Polusy2].GetComponentInChildren<Text>().text = "2";
                    AAA[Polusx2, Polusy2].GetComponentInChildren<Text>().color = Blaky;
                        AAA[1, 3].GetComponentInChildren<Text>().text = "";
                    v1 = Convert.ToInt32(50 * Math.Sqrt((xK - Polusx1) * (xK - Polusx1) + (yK - Polusy1) * (yK - Polusy1)));
                    v2 = Convert.ToInt32(50 * Math.Sqrt((xK - Polusx2) * (xK - Polusx2) + (yK - Polusy2) * (yK - Polusy2)));
                    if (v1 < v2) v += v1; else v += v2;
                   
                }


            }
            if (p.Contains("q") == false && p.Contains("r") == false && p.Contains("b") == false && p.Contains("n") == false)///голый король у черных
            {
                v += centrk; v -= Kk;
                if (centrk > centrK) v += 50;
            }

            /*if (p.Contains("Q") == false && p.Contains("R") == false && p.Contains(" w ") && (p.Contains("q") || p.Contains("r")))

            {
                ///if (PodSHAH(p, -1) > 0) v -= 1;
                v += Convert.ToInt32(5 * Math.Sqrt((xK - xk) * (xK - xk) + (yK - yk) * (yK - yk)));

            }
            if (p.Contains("q") == false && p.Contains("r") == false && p.Contains(" b ") && (p.Contains("Q") || p.Contains("R")))
            {
                //if (PodSHAH(p, -1) > 0) v += 1;
                v -= Convert.ToInt32(5 * Math.Sqrt((xK - xk) * (xK - xk) + (yK - yk) * (yK - yk)));

            }*/


        }
        


        return v;
    }
    /// <summary>
    /// ////////////////
    /// </summary>
    public int VerMat(string p)
    {
        var v = 0f;
        var BOAR = BoardLoad(p);
        for (int x = 1; x <= 8; x++) for (int y = 1; y <= 8; y++)
            if ((p.Contains(" w ") && BOAR[x, y] == 'k') || (p.Contains(" b ") && BOAR[x, y] == 'K'))
            {
                    if (x == 1 || x == 8) v += 2f;
                    if (y == 1 || y == 8) v += 1f;
                    for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++) if (dx != 0 || dy != 0)
                            {
                                var x1 = x + dx; var y1 = y + dy;
                                if (x1 >= 1 && x <= 8 && y1 >= 1 && y1 <= 8)
                                {
                                    if (PodSHAHBOARD(x1, y1, BOAR, 1) == 0) v = v - 1; else v = v + 1;
                                }
                            }
                    break;
            }
        return Convert.ToInt32(v);
    }
    public string MatBOAR(char[,] BOAR1, int deep)
    {
        var v = "";
        if (deep > 0)
        {
            var BOAR =  new char[9, 9]; for (int x = 0; x <= 8; x++) for (int y = 0; y <= 8; y++) BOAR[x, y] = BOAR1[x, y];
            var Next = VariantsBOAR(BOAR);
            for (int i = 0; i < Next.Count; i++)
            {
                v = Next[i]; if (Next[i].Contains("+")) shah = true;
                    var pp1 = HODBOAR(BOAR, Next[i]); ////////////////////////var b1 = Balans(p1); if (p1.Contains(" w ")) b1 = -b1;
                var Next1 = VariantsBOAR(pp1);

                if (Next1.Count == 0) /// && PodSHAH(p1, -1) == 0) { v = ""; }
                {
                    //var p1 = BoardSave(pp1);
                    if (Next[i].Contains("+")==false) { v = ""; }
                    if (Next[i].Contains("+")) { break; }
                }
                else ///если мат в 1 ход не найден
                {
                    for (int j = 0; j < Next1.Count; j++) ///ответы оппонента
                    {
                        var pp2 = HODBOAR(pp1, Next1[j]);
                        var v2 = MatBOAR(pp2, deep - 1);
                        if (v2=="") { v = "";break; }
                    }
                }
                if (v != "") break;
            }
        }
        
            return v;
    }
    public List<string> VariantsBOAR(char[,] BOAR) /// 
    {
        var MyList = new List<string>(); var x1 = 0; var y1 = 0; //var x2 = 0; var y2 = 0;// var x3 = 0; var y3 = 0;        var z = 0;
        var h0 = ""; ///var BOAR = BoardLoad(p);
        var drug = BOAR[0, 0]; var vrag = ' '; if (BOAR[0, 0] == 'w') vrag = 'b'; if (BOAR[0, 0] == 'b') vrag = 'w';
       // if (side == -1) { var d = drug; drug = vrag; vrag = d; }////варианты ходов противоположной стороны
        var Rok = false;
       
            if (drug == 'w' && (BOAR[0, 1] == 'K') && BOAR[5, 1] == 'K' && BOAR[6, 1] == ' ' && BOAR[7, 1] == ' ' && BOAR[8, 1] == 'R') { MyList.Add("Ke1-g1 "); Rok = true; }////короткая р белых
            if (drug == 'w' && (BOAR[0, 2] == 'Q') && BOAR[1, 1] == 'R' && BOAR[2, 1] == ' ' && BOAR[3, 1] == ' ' && BOAR[4, 1] == ' ' && BOAR[5, 1] == 'K') { MyList.Add("Ke1-c1 "); Rok = true; } ////дл р белых
            if (drug == 'b' && (BOAR[0, 3] == 'k') && BOAR[5, 8] == 'k' && BOAR[6, 8] == ' ' && BOAR[7, 8] == ' ' && BOAR[8, 8] == 'r') { MyList.Add("Ke8-g8 "); Rok = true; }////короткая р ч
            if (drug == 'b' && (BOAR[0, 4] == 'q') && BOAR[1, 8] == 'r' && BOAR[2, 8] == ' ' && BOAR[3, 8] == ' ' && BOAR[4, 8] == ' ' && BOAR[5, 8] == 'k') { MyList.Add("Ke8-c8 "); Rok = true; }////дл р ч
       
        var p72 = false; var xK = 0; var yK = 0; var xk = 0; var yk = 0;
        for (int x = 1; x <= 8; x++) for (int y = 1; y <= 8; y++)
            {
                if (BOAR[x, y] == 'K') { xK = x; yK = y; }; if (BOAR[x, y] == 'k') { xk = x; yk = y; };////координат королей

                if (BOAR[x, y] != ' ' && Cvet(BOAR[x, y]) == drug)
                {
                    var fig = BOAR[x, y]; //if (fig == 'K') { xK = x; yK = y; }; if (fig == 'k') { xk = x; yk = y; };////координат королей
                    ///ход пешкой w
                    if (fig == 'P' && drug == 'w')
                    {
                        h0 = " " + PointToString(x, y); var EP = "";
                       
                            if (BOAR[x, y + 1] == ' ') MyList.Add(h0 + "-" + PointToString(x, y + 1)); ///ход пр 
                            if (y == 2) if (BOAR[x, y + 1] == ' ' && BOAR[x, y + 2] == ' ') MyList.Add(h0 + "-" + PointToString(x, y + 2)); ///ход 2 поля
                       
                        if (x < 8) ///бей вправо
                        {
                            if (Cvet(BOAR[x + 1, y + 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x + 1, y + 1)); ///бить без превращения
                            EP = PointToString(x + 1, y + 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x + 1, y + 1) + "ep"); ///если возможно взятие на проходе
                        }
                        if (x > 1) ///бей влево
                        {
                            if (Cvet(BOAR[x - 1, y + 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x - 1, y + 1)); ///бить
                            EP = PointToString(x - 1, y + 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x - 1, y + 1) + "ep"); ///если возможно взятие на проходе
                        }
                        if (y == 7) p72 = true;////могут быть превращения
                    }
                    ///ход пешкой b
                    if (fig == 'p' && drug == 'b')
                    {
                        h0 = " " + PointToString(x, y); var EP = "";
                        
                            if (BOAR[x, y - 1] == ' ') MyList.Add(h0 + "-" + PointToString(x, y - 1)); ///ход пр
                            if (y == 7) if (BOAR[x, y - 1] == ' ' && BOAR[x, y - 2] == ' ') MyList.Add(h0 + "-" + PointToString(x, y - 2)); ///ход 2 поля
                        
                        if (x < 8)
                        {
                            if (Cvet(BOAR[x + 1, y - 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x + 1, y - 1)); ///
                            EP = PointToString(x + 1, y - 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x + 1, y - 1) + " ep"); ///если возможно взятие на проходе
                        }
                        if (x > 1)
                        {
                            if (Cvet(BOAR[x - 1, y - 1]) == vrag) MyList.Add(h0 + ":" + PointToString(x - 1, y - 1)); ///
                            EP = PointToString(x - 1, y - 1);
                            if (BOAR[0, 5] == EP[0] && BOAR[0, 6] == EP[1]) MyList.Add(h0 + ":" + PointToString(x - 1, y - 1) + " ep"); ///если возможно взятие на проходе
                        }
                        if (y == 2) p72 = true;////могут быть превращения
                    }
                    //if ((fig == 'N' && drug == 'w') || (fig == 'n' && drug == 'b')) //конь
                    if ((fig == 'N') || (fig == 'n')) //конь
                    {
                        h0 = 'N' + PointToString(x, y);
                        for (int dx = -2; dx <= 2; dx++) if (dx != 0) for (int dy = -2; dy <= 2; dy++) if (dy != 0 && dy != dx && dy != -dx)
                                    {
                                        x1 = x + dx; y1 = y + dy;
                                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                                        {
                                              if (BOAR[x1, y1] == ' ') MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                            if (Cvet(BOAR[x1, y1]) == vrag) MyList.Add(h0 + ":" + PointToString(x1, y1));
                                        }
                                    }
                    }
                    /* if ((fig == 'B' && drug == 'w') || (fig == 'b' && drug == 'b') //слон
                       || (fig == 'Q' && drug == 'w') || (fig == 'q' && drug == 'b') //ферзь
                        || (fig == 'K' && drug == 'w') || (fig == 'k' && drug == 'b')) //кр                  */
                    if ("QBKqbk".Contains(fig + ""))
                    // if (fig == 'B' || fig == 'b' || fig == 'Q' || fig == 'q' || fig == 'K' || fig == 'k' ) 
                    {
                        if (fig == 'B' || fig == 'b') h0 = 'B' + PointToString(x, y);
                        if (fig == 'Q' || fig == 'q') h0 = 'Q' + PointToString(x, y);
                        if (fig == 'K' || fig == 'k') h0 = 'K' + PointToString(x, y);
                        for (int dx = -1; dx <= 1; dx++)
                            if (dx != 0)
                                for (int dy = -1; dy <= 1; dy++)
                                    if (dy != 0)
                                    {
                                        for (int i = 1; i <= 8; i++)
                                        {
                                            if ((fig == 'K' || fig == 'k') && i > 1) break;
                                            x1 = x + dx * i; y1 = y + dy * i;
                                            if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                            if (Cvet(BOAR[x1, y1]) == drug) break;
                                            if (BOAR[x1, y1] == ' ') MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                            if (Cvet(BOAR[x1, y1]) == vrag) { MyList.Add(h0 + ":" + PointToString(x1, y1)); break; }
                                        }
                                    }
                    }
                    /*if ((fig == 'R' && drug == 'w') || (fig == 'r' && drug == 'b') //ладья
                      || (fig == 'Q' && drug == 'w') || (fig == 'q' && drug == 'b') //ферзь
                      || (fig == 'K' && drug == 'w') || (fig == 'k' && drug == 'b')) //кр*/
                    if ("RQKrqk".Contains(fig + ""))
                    {
                        if (fig == 'R' || fig == 'r') h0 = 'R' + PointToString(x, y);
                        if (fig == 'Q' || fig == 'q') h0 = 'Q' + PointToString(x, y);
                        if (fig == 'K' || fig == 'k') h0 = 'K' + PointToString(x, y);
                        for (int dx = -1; dx <= 1; dx++)
                            // if (dx != 0)
                            for (int dy = -1; dy <= 1; dy++)
                                if (dy * dy != dx * dx)
                                {
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        if ((fig == 'K' || fig == 'k') && i > 1) break;
                                        x1 = x + dx * i; y1 = y + dy * i;
                                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                                        if (Cvet(BOAR[x1, y1]) == drug) break;
                                          if (BOAR[x1, y1] == ' ') MyList.Add(h0 + "-" + PointToString(x1, y1)); ///ход пр
                                        if (Cvet(BOAR[x1, y1]) == vrag) { MyList.Add(h0 + ":" + PointToString(x1, y1)); break; }
                                    }
                                }
                    }
                }
            }
        var n = MyList.Count;
        if (p72)
            for (int i = 0; i < n; i++)////добавление превращений
                if (MyList[i][0] == ' ')///если пешка
                {
                    var c = MyList[i];
                    if ((drug == 'w' && c[5] - 48 == 8) ||
                        (drug == 'b' && c[5] - 48 == 1))
                    {

                        for (int j = 1; j <= 4; j++)
                        {
                            if (j == 1) MyList[i] = c + 'Q'; ///ход прев
                            if (j == 2) MyList.Add(c + 'R'); ///ход прев
                            if (j == 3) MyList.Add(c + 'N'); ///ход прев
                            if (j == 4) MyList.Add(c + 'B'); ///ход прев
                        }
                    }/// else if (MyList[i].Length < 7) MyList[i] += ".";
                }
        
            n = MyList.Count;

            for (int i = 0; i < n; i++)////отсев нелегальных ходов под шахом
            {
            //   var pb = HODBOAR( BOAR, MyList[i]);
            //   NextP = BoardSave(pb);
            var NextP = HODBOAR(BOAR, MyList[i]);
            var V = 0;
                if (MyList[i][0] == 'K')
                {
                    x1 = MyList[i][4] - 96; y1 = MyList[i][5] - 48; V = PodSHAHBOARD(x1, y1, NextP, 1);
                }
                else { if (BOAR[0, 0] == 'w') V = PodSHAHBOARD(xK, yK, NextP, 1); else V = PodSHAHBOARD(xk, yk, NextP, 1); }

                if (V > 0) { MyList[i] = "" + i; }
                else
                {
                    var shah = 0;
                    if (BOAR[0, 0] == 'w') shah = PodSHAHBOARD(xk, yk, NextP, -1); else shah = PodSHAHBOARD(xK, yK, NextP, -1);
                    ///PodSHAH(NextP, -1);
                    if (shah == 1) { MyList[i] += "+"; }
                    if (shah > 1) { MyList[i] += "++"; }
                }
            }
        
        if (Rok)
            for (int i = 0; i < n; i++)////отсев нелегальных ходов роккировки
            {
                ///var p = BoardSave(BOAR);
                /////РОККИРОВКА
                if (MyList[i].Contains("Ke1-g1"))
                {
                    if (PodSHAHBOARD(5, 1, BOAR, -1) > 0) MyList[i] = "" + i;
                    if (PodSHAHBOARD(6, 1, BOAR, -1) > 0) MyList[i] = "" + i;
                }
                if (MyList[i].Contains("Ke1-c1"))
                {
                    if (PodSHAHBOARD(5, 1, BOAR, -1) > 0) MyList[i] = "" + i;
                    if (PodSHAHBOARD(4, 1, BOAR, -1) > 0) MyList[i] = "" + i;
                }
                if (MyList[i].Contains("Ke8-g8"))
                {
                    if (PodSHAHBOARD(5, 8, BOAR, -1) > 0) MyList[i] = "" + i;
                    if (PodSHAHBOARD(6, 8, BOAR, -1) > 0) MyList[i] = "" + i;
                }
                if (MyList[i].Contains("Ke8-c8"))
                {
                    if (PodSHAHBOARD(5, 8, BOAR, -1) > 0) MyList[i] = "" + i;
                    if (PodSHAHBOARD(4, 8, BOAR, -1) > 0) MyList[i] = "" + i;
                }

            }
        n = MyList.Count;
        for (int i = 0; i < n; i++)////отсев помеченных на удаление ходов
        {
             MyList.Remove("" + i);

        }
        // n = MyList.Count;
        // for (int i = 0; i < n; i++) if (MyList[i][0] == ' ' && MyList[i].Length < 7) MyList[i] += " "; ////добавление пробела пешкам при ходе без превращения
        return MyList;
    }
    public int PodSHAHBOARD(int x, int y, char[,] BOAR, int side)///-1 я под шахом, 1-враг под шахом
    {
        var v = 0;
        
        var drug = BOAR[0, 0]; var vrag = ' ';
        if (BOAR[0, 0] == 'w') vrag = 'b';
        if (BOAR[0, 0] == 'b') vrag = 'w';
        if (side == -1) { var d = drug; drug = vrag; vrag = d; } ///var d = drug; drug = vrag; vrag = d;///поменять местами
        // SSS = "";
        for (int dx = -1; dx <= 1; dx++) if (dx != 0) for (int dy = -1; dy <= 1; dy++) if (dy != 0)
                    {
                        x1 = x + dx; y1 = y + dy;
                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                        {
                            //SSS += BOAR[x1, y1] + PointToString(x1, y1) + ", drug=" + drug;
                            if ((BOAR[x1, y1] == 'p' && drug == 'b' && y < y1) || (BOAR[x1, y1] == 'P' && drug == 'w' && y > y1)) v = v + 1; ///шах пешкой
                        }
                    }
        for (int dx = -2; dx <= 2; dx++) if (dx != 0) for (int dy = -2; dy <= 2; dy++) if (dy != 0 && dy != dx && dy != -dx)
                    {
                        x1 = x + dx; y1 = y + dy;
                        if (x1 > 0 && x1 < 9 && y1 > 0 && y1 < 9)
                        {
                            // SSS += BOAR[x1, y1]+PointToString(x1, y1)+ ", drug="+ drug+ (BOAR[x1, y1] == 'N' && drug == 'w');
                            if ((BOAR[x1, y1] == 'n' && drug == 'b') || (BOAR[x1, y1] == 'N' && drug == 'w')) v = v + 1; ///шах конем
                        }
                    }
        for (int dx = -1; dx <= 1; dx++) if (dx != 0) for (int dy = -1; dy <= 1; dy++)  if (dy != 0)
                    {
                        for (int i = 1; i <= 8; i++)
                        {
                            x1 = x + dx * i; y1 = y + dy * i;
                            if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                            if (Cvet(BOAR[x1, y1]) == vrag) break;
                            if ((BOAR[x1, y1] == 'b' && drug == 'b') || (BOAR[x1, y1] == 'B' && drug == 'w')) v = v + 1; ///шах слоном
                            if ((BOAR[x1, y1] == 'q' && drug == 'b') || (BOAR[x1, y1] == 'Q' && drug == 'w')) v = v + 1; ///шах ферзем
                            if (i == 1) if ((BOAR[x1, y1] == 'k' && drug == 'b') || (BOAR[x1, y1] == 'K' && drug == 'w')) v = v + 1; ///сближение с королем
                            if (BOAR[x1, y1] != ' ') break;//если фигура не С и не Ф - дальше не сканировать
                        }
                    }
        for (int dx = -1; dx <= 1; dx++) for (int dy = -1; dy <= 1; dy++)  if (dy * dy != dx * dx)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        x1 = x + dx * i; y1 = y + dy * i;
                        if (x1 < 1 || x1 > 8 || y1 < 1 || y1 > 8) break;
                        if (Cvet(BOAR[x1, y1]) == vrag) break;
                        if ((BOAR[x1, y1] == 'r' && drug == 'b') || (BOAR[x1, y1] == 'R' && drug == 'w')) v = v + 1; ///шах ладьей
                        if ((BOAR[x1, y1] == 'q' && drug == 'b') || (BOAR[x1, y1] == 'Q' && drug == 'w')) v = v + 1; ///шах ферзем
                        if (i == 1) if ((BOAR[x1, y1] == 'k' && drug == 'b') || (BOAR[x1, y1] == 'K' && drug == 'w')) v = v + 1; ///сближение с королем
                        if (BOAR[x1, y1] != ' ') break;//если фигура не Л и не Ф - дальше не сканировать
                    }
                }


        return v;
    }
    public char[,] HODBOAR(char[,] BOAR1, string p)
    {
        var BOAR = new char[9, 9]; for (int x = 0; x <= 8; x++) for (int y = 0; y <= 8; y++) BOAR[x, y] = BOAR1[x, y];
                SSS = p;
      ///  var BOAR = BoardLoad(position);

        if (p.Length >= 8) if (p[6] == 'e' && p[7] == 'p') p = Left(p, 8);

        var x1 = 0; var y1 = 0; var x2 = 0; var y2 = 0; var x3 = 0; var y3 = 0;
        var fig = ' '; var z = ' '; var figP = ' ';

        var drug = BOAR[0, 0]; var vrag = ' ';
        if (BOAR[0, 0] == 'w') vrag = 'b';
        if (BOAR[0, 0] == 'b') vrag = 'w';
        if (p.Length <= 6) p = p + " ";////если ход без хвоста
        fig = p[0];

        x1 = p[1] - 96; y1 = p[2] - 48;
        z = p[3];
        x2 = p[4] - 96; y2 = p[5] - 48; /// z : or -
        figP = p[6];////фигура превращения, если превращение
                    /// SSS = "p[2]=" + (int)p[2] + "p[5]=" + (int)p[5] + ",   x1 =" + x1 + ", y1=" + y1 + " , x2=" + x2 + ", y2=" + y2+", p="+p;
        BOAR[x2, y2] = BOAR[x1, y1];
        BOAR[x1, y1] = ' ';
        if (fig == ' ' && figP != ' ' && "QRNBqrnb".Contains(figP + ""))////фигура превращения, если превращение
        {
            if (drug == 'b')
            {
                if (figP == 'Q') figP = 'q';
                if (figP == 'R') figP = 'r';
                if (figP == 'N') figP = 'n';
                if (figP == 'B') figP = 'b';
            }
            BOAR[x2, y2] = figP;
        }
        ////роккировка

        if (p.Contains("Ke1-g1")) { BOAR[6, 1] = 'R'; BOAR[8, 1] = ' '; }
        if (p.Contains("Ke1-c1")) { BOAR[4, 1] = 'R'; BOAR[1, 1] = ' '; }
        if (p.Contains("Ke8-g8")) { BOAR[6, 8] = 'r'; BOAR[8, 8] = ' '; }
        if (p.Contains("Ke8-c8")) { BOAR[4, 8] = 'r'; BOAR[1, 8] = ' '; }

        if (p.Contains("ep"))
        {
            BOAR[x2, y1] = ' ';
        }
        //

        BOAR[0, 0] = vrag;
        if (p.Contains("Ke1-g1") && drug == 'w') { BOAR[0, 1] = ' '; BOAR[0, 2] = ' '; }//// "сделана кор.роккировка белых";
        if (p.Contains("Ke1-c1") && drug == 'w') { BOAR[0, 1] = ' '; BOAR[0, 2] = ' '; }//// "сделана дл.роккировка белых";
        if (p.Contains("Ke8-g8") && drug == 'b') { BOAR[0, 3] = ' '; BOAR[0, 4] = ' '; }//// "сделана роккировка черных";
        if (p.Contains("Ke8-c8") && drug == 'b') { BOAR[0, 3] = ' '; BOAR[0, 4] = ' '; }//// "сделана роккировка черных";
        if (fig == 'K' && drug == 'w') { BOAR[0, 1] = ' '; BOAR[0, 2] = ' '; }//// "теряется Длинная роккировка белых и короткая если сходил король";
        if (fig == 'K' && drug == 'b') { BOAR[0, 3] = ' '; BOAR[0, 4] = ' '; }//// "теряется Длинная роккировка черных и короткая если сходил король";
        if (fig == 'R' && drug == 'w' && x1 == 8 && y1 == 1) { BOAR[0, 1] = ' '; }//// "теряется кор роккировка белых если сходила ладья А1";
        if (fig == 'R' && drug == 'w' && x1 == 1 && y1 == 1) { BOAR[0, 2] = ' '; }//// "теряется дл роккировка белых если сходила ладья H1";
        if (fig == 'R' && drug == 'b' && x1 == 8 && y1 == 8) { BOAR[0, 3] = ' '; }//// "теряется кор роккировка черных если сходила ладья А8";
        if (fig == 'R' && drug == 'b' && x1 == 1 && y1 == 8) { BOAR[0, 4] = ' '; }//// "теряется дл роккировка черных если сходила ладья H8";

        if (fig == ' ' && Math.Abs(y1 - y2) == 2) { x3 = x1; y3 = (y1 + y2) / 2; var s = PointToString(x3, y3); BOAR[0, 5] = s[0]; BOAR[0, 6] = s[1]; }
        else { BOAR[0, 5] = '-'; } ///длинный ход пешкой

        if (fig == ' ' || z == ':') { BOAR[0, 7] = (char)0; }////счетчик ходов без пешек и взятия обнуляется
        else { if (drug == 'b') BOAR[0, 7] = (char)(BOAR[0, 7] + 1); }

        if (drug == 'b') BOAR[0, 8] = (char)(BOAR[0, 8] + 1); ///счетчик ходов +1 если был ход черных


        return BOAR;
    }
    public void Tablo()
    {
        //Time1.GetComponent<InputField>().text = time1.Seconds+""; // ToString("mm:ss:ff") + "";
        //Time2.GetComponent<InputField>().text = time1.Seconds + "";
        var dateAndTime = DateTime.Now;
        time11 = dateAndTime.Date.Add(time1); 


        Time1.GetComponentInChildren<Text>().color = new Color32(162, 73, 165, 255);
        Time1.GetComponent<InputField>().text = time11.ToString("mm:ss") + "";
        if (time1.Minutes < 1)
        {
            if (time1.Seconds <= 40) Time1.GetComponentInChildren<Text>().color = new Color32(63, 72, 203, 255);

            if (time1.Seconds <= 30) Time1.GetComponentInChildren<Text>().color = new Color32(33, 177, 77, 255);

            if (time1.Seconds <= 20) Time1.GetComponentInChildren<Text>().color = new Color32(255, 127, 38, 255);

            if (time1.Seconds <= 10)
            {
                Time1.GetComponentInChildren<Text>().color = new Color32(236, 28, 36, 255);
                Time1.GetComponent<InputField>().text = time11.ToString("mm:ss:ff") + "";
            }
            
            if (time1.Seconds < 0) Time1.GetComponent<InputField>().text = "время";
        }
        dateAndTime = DateTime.Now;
        time22 = dateAndTime.Date.Add(time2);
        Time2.GetComponentInChildren<Text>().color = new Color32(162, 73, 165, 255);
        Time2.GetComponent<InputField>().text = time22.ToString("mm:ss") + "";
        if (time2.Minutes < 1)
        {
            if (time2.Seconds <= 40) Time1.GetComponentInChildren<Text>().color = new Color32(63, 72, 203, 255);

            if (time2.Seconds <= 30) Time1.GetComponentInChildren<Text>().color = new Color32(33, 177, 77, 255);

            if (time2.Seconds <= 20) Time1.GetComponentInChildren<Text>().color = new Color32(255, 127, 38, 255);

            if (time2.Seconds <= 10)
            {
                Time2.GetComponentInChildren<Text>().color = new Color32(236, 28, 36, 255);
                Time2.GetComponent<InputField>().text = time22.ToString("mm:ss:ff") + "";
            }

            if (time2.Seconds < 0) Time2.GetComponent<InputField>().text = "время";
        }
    }
    void OnGUI()
    {
        var t = DateTime.UtcNow - clock0;

        if (CheiHod == 'w') {  time1 -= t; }
        if (CheiHod == 'b') {  time2 -= t; }
        clock0 = DateTime.UtcNow;
    }

    /// <summary>
    /// ////////////////////////////////////////////////
    /// </summary>




    public void LoadPos()
    {
        Chess.txtConnect = "https://crown.alabuga.ru/img/111.php?act=SELECT Position FROM `MP` WHERE ID=" + Chess.KodGame;
        StartCoroutine(GetRequest(Chess.txtConnect));

        if (SSSmesage != "" && SSSmesage != Pos && (SSSmesage.Contains(" w ") || SSSmesage.Contains(" b "))) Pos = SSSmesage;
    }
    public void SavePos()
    {
        Chess.txtConnect = "https://crown.alabuga.ru/img/2_UPDATE.php?act=SET `Position`= \"" + Pos + "\" WHERE ID=" + Chess.KodGame;
        StartCoroutine(GetRequest(Chess.txtConnect));

        ////if (SSSmesage != "" && SSSmesage != Pos && (SSSmesage.Contains(" w ") || SSSmesage.Contains(" b "))) Pos = SSSmesage;
    }
    IEnumerator Pausa()
    {

        yield return new WaitForSeconds(0.1f); // продолжить примерно через 100ms
    }
    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri); ///        //UnityWebRequest uwr = UnityWebRequest.Get("https://crown.alabuga.ru/img/222.php?act=getquestions");

        yield return uwr.Send();
        Debug.Log("{" + uwr.downloadHandler.text + "} в ответ на " + uri);
        TextResult.GetComponent<Text>().text = System.DateTime.Now.ToString("hh:mm:ss") + uwr.downloadHandler.text + " в ответ на " + uri + "/ETAP=" + ETAP + "/Iam" + Iam + "/MyColor=" + MyColor;

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);

        }
        else
        {
            ////// JSONNode RQ = SimpleJSON.JSON.Parse(uwr.downloadHandler.text);

            if (uwr.downloadHandler.text != "") SSSmesage = uwr.downloadHandler.text;
        }
    }
    IEnumerator Zapis()
    {
        if (!File.Exists("settings.ini")) File.Create("settings.ini");
        var ii =  Hods.Count;
        if (ii > 0)
        {
            File.AppendAllText("settings.ini", BeginPosition + Environment.NewLine);
            for (int i = 0; i < ii; i++)
            {
                File.AppendAllText("settings.ini", Hods[i] + Environment.NewLine);
              if (i<ii-1)  File.AppendAllText("settings.ini", Party[i] + Environment.NewLine);
            }
        }






        yield return new WaitForSeconds(1);
        
        
        

        
        ///BBB4.GetComponentInChildren<Text>().text = "время вышло";
    }
}