using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dynasty : MonoBehaviour
{ 
    public AudioClip impact0, impact1, impact2, impact3;
    public int[] Music = new int[4];
    public static AudioSource audio;
    ///AudioSource audio0;
    public static GameObject[] AAA = new GameObject[91];
    public bool[] OTKR = new bool[91];
    public static GameObject lab;
    public GameObject KLON, KLON2, KLON3, REVERS_knopka, VZJAT_knopka, label0;
    public GameObject Muzic;
    public static string MuzicTXT = "выкл.ЗВУК";
    public GameObject[] STR = new GameObject[7];
    public GameObject[] STR2 = new GameObject[7];
    public GameObject[] DOP = new GameObject[7];
    public int[] XX = new int[7];
    public int[] YY = new int[7];
    public static int[] Kart70 = new int[91];
    public static int NSTOL, NOMIG;
    public string TEXT1, TEXT2, TEXT0;
    public Transform thisCanvas;
        
    public int[] STOL1 = new int[11];
    public int[] STOL2 = new int[11];
    public int[] STOL3 = new int[11];
    public int[] STOL4 = new int[11];
    public int[] STOL5 = new int[11];
    public int[] STOL6 = new int[11];
    public int[] Status = new int[7];
    public int[] Din = new int[7]; public int[] Dophod = new int[7];
    public int[] Shortwin_1 = new int[7];
    public int[] Brat_2 = new int[7];
    public int[] Anycart_3 = new int[7];
    public int[] Morecart_4 = new int[7];
    public int[] Egalitewin_5 = new int[7];
    public int[] Smert_6 = new int[7];
    public bool[] XPOHOD = new bool[7];
    public static int Past = 0;
    public List<int> MyList = new List<int>();
    public List<int> Sbros = new List<int>();
    public List<int> VAR,VAR0, VAR1, VAR2 = new List<int>();

    public List<string> HISTORY, VAR3 = new List<string>();
    public int ROTATE, WIN, GAMEOVER, ETAP, MIN, MAX, N, R, S, SF, J, J1, I, a, AA, b, BB, Ig, HUMAN, LimitKart, LimitIg, Timer, Melody, LimitWin;
    public int LIM, KOL, XOD;
    public static bool REVERS, LEFT, RIGHT, NOMOVE, PROP, VZJAT, YES, NO, SMERT, CLOSE;
    public float FFF;
    public GameObject[] But = new GameObject[7]; public GameObject[] Kand = new GameObject[7];
    public GameObject Smert_knopka, TextV, Dom, Panel, Panel_Left, Panel_Right, Panel0, Panel0_Karta, Panel0_Text, Panel0_Button1, Panel0_Button2, PanelBIG;
    public GameObject Panel1, Panel1_Karta, Panel1_Karta2, Panel1_Text, Panel1_Button1, Panel1_Button2, Statistika, Ocered;
    public static List<List<int>> NABOR = new List<List<int>>();
    public static List<List<int>> Stol = new List<List<int>>();
    public string S1, SSS;
    public string[] Name = new string[7];
    public string[] Perk = new string[7];
    public string[] NaborS = new string[7];
    public string[] Kart20 = new string[21];
    public Texture2D BA;
    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        Kart70[1] = 106; Kart70[2] = 107; Kart70[3] = 111; Kart70[4] = 113; Kart70[5] = 114; Kart70[6] = 119; Kart70[7] = 120; Kart70[8] = 203; Kart70[9] = 204; Kart70[10] = 207;
        Kart70[11] = 215; Kart70[12] = 317; Kart70[13] = 318; Kart70[14] = 320; Kart70[15] = 405; Kart70[16] = 410; Kart70[17] = 415; Kart70[18] = 420; Kart70[19] = 514;
        Kart70[20] = 609; Kart70[21] = 610; Kart70[22] = 612; Kart70[23] = 615; Kart70[24] = 617; Kart70[25] = 619; Kart70[26] = 710; Kart70[27] = 711; Kart70[28] = 714; Kart70[29] = 717;
        Kart70[30] = 308; Kart70[31] = 508; Kart70[32] = 809; Kart70[33] = 810; Kart70[34] = 813; Kart70[35] = 820; Kart70[36] = 509; Kart70[37] = 910; Kart70[38] = 919; Kart70[39] = 1015;
        Kart70[40] = 311; Kart70[41] = 1113; Kart70[42] = 1117; Kart70[43] = 212; Kart70[44] = 312; Kart70[45] = 412; Kart70[46] = 1112; Kart70[47] = 1217; Kart70[48] = 913; Kart70[49] = 1317;
        Kart70[50] = 1319; Kart70[51] = 1320; Kart70[52] = 214; Kart70[53] = 1419; Kart70[54] = 1420; Kart70[55] = 216; Kart70[56] = 516; Kart70[57] = 716; Kart70[58] = 816; Kart70[59] = 1116;
        Kart70[60] = 1216; Kart70[61] = 1516; Kart70[62] = 517; Kart70[63] = 418; Kart70[64] = 518; Kart70[65] = 918; Kart70[66] = 1018; Kart70[67] = 1418; Kart70[68] = 1518; Kart70[69] = 1519;
        Kart70[70] = 1920;
        Kart70[71] = 71; Kart70[72] = 72; Kart70[73] = 73; Kart70[74] = 74; Kart70[75] = 75; Kart70[76] = 76;
        Kart70[77] = 77; Kart70[78] = 78; Kart70[79] = 79; Kart70[80] = 80; Kart70[81] = 81; Kart70[82] = 82; Kart70[83] = 83; Kart70[84] = 84;
        Kart70[85] = 85; Kart70[86] = 86; Kart70[87] = 87; Kart70[88] = 88; Kart70[89] = 89; Kart70[90] = 90;
        Name[0] = "Все";
        Name[1] = "Борджиа"; Name[2] = "Бофорты"; Name[3] = "Валуа"; Name[4] = "Веттины"; Name[5] = "Гогенцоллерны"; Name[6] = "Медичи";
        Perk[0] = "никакой";
        Perk[1] = "-1 к длине династии для победы";
        Perk[2] = "добирают из колоды по 2 карты";
        Perk[3] = "Начинают игру с любой карты";
        Perk[4] = "+1 карта на руке";
        Perk[5] = "+1 при равной длине династии";
        Perk[6] = "Один раз за игру могут применить Смерть";
        Kart20[1] = "Брак";
        Kart20[2] = "Смерть";
        Kart20[3] = "Суд";
        Kart20[4] = "Охота";
        Kart20[5] = "Связи";
        Kart20[6] = "Флирт";
        Kart20[7] = "Война";
        Kart20[8] = "Ересь";
        Kart20[9] = "Обучение";
        Kart20[10] = "Путешествие";
        Kart20[11] = "Измена";
        Kart20[12] = "Дуэль";
        Kart20[13] = "Монастырь";
        Kart20[14] = "Наследство";
        Kart20[15] = "Болезнь";
        Kart20[16] = "Заговор";
        Kart20[17] = "Оскорбление";
        Kart20[18] = "Турнир";
        Kart20[19] = "Дети";
        Kart20[20] = "Развод";
        audio = GetComponent<AudioSource>();
        Stol.Clear();//очистка стола
        Stol.Add(new List<int> { }); Stol.Add(new List<int> { }); Stol.Add(new List<int> { }); Stol.Add(new List<int> { });
        Stol.Add(new List<int> { }); Stol.Add(new List<int> { }); Stol.Add(new List<int> { }); ;// инициализация стола


        lab = Instantiate(label0, label0.transform.position, Quaternion.identity);
        for (int i = 1; i <= 90; i++)
        {

            AAA[i] = Instantiate(KLON, KLON.transform.position, Quaternion.identity);
            AAA[i].transform.SetParent(thisCanvas);
            AAA[i].GetComponent<CardManager>().Kart = i;
            AAA[i].transform.localScale = new Vector3(1f, 1f, 0.0f);
            AAA[i].transform.position = new Vector3(KLON.transform.localPosition.x, KLON.transform.localPosition.y, 0);
             
            GetSprite(i);
        }
        for (int i = 1; i <= 6; i++)
        {
            var X = 0; var Y = 0;
            STR[i] = Instantiate(KLON2, KLON2.transform.position, Quaternion.identity);
            STR[i].transform.SetParent(thisCanvas);
            STR[i].GetComponent<CardManager>().Kart = i;
            STR[i].transform.rotation = Quaternion.Euler(0, 0, 180);

            STR2[i] = Instantiate(KLON3, KLON3.transform.position, Quaternion.identity);
            STR2[i].transform.SetParent(thisCanvas);
            STR2[i].GetComponent<CardManager>().Kart = -i;

            But[i] = Instantiate(But[0], But[0].transform.position, Quaternion.identity);
            But[i].transform.SetParent(thisCanvas);
            But[i].GetComponent<CardManager>().Kart = i;
            But[i].transform.localScale = new Vector3(1f, 1f, 0.0f);
            X = i * 120 - 60;
            Y = Mathf.RoundToInt(But[1].transform.position.y);
            But[i].transform.position = new Vector3(X, Y, 0);

            DOP[i] = Instantiate(DOP[0], DOP[0].transform.position, Quaternion.identity);
            DOP[i].transform.SetParent(thisCanvas);
            DOP[i].GetComponent<CardManager>().Kart = i;
            DOP[i].transform.localScale = new Vector3(1f, 1f, 0.0f);
            X = i * 120 - 60;
            Y = Mathf.RoundToInt(DOP[0].transform.position.y);
            DOP[i].transform.position = new Vector3(X, Y, 0);
        }
        ETAP = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (ETAP == 0)
        {
            NABOR.Clear();//очистка набора
            NABOR.Add(new List<int> { }); NABOR.Add(new List<int> { }); NABOR.Add(new List<int> { }); NABOR.Add(new List<int> { });
            NABOR.Add(new List<int> { }); NABOR.Add(new List<int> { }); NABOR.Add(new List<int> { }); ;// инициализация
            NABOR[0].Clear(); NABOR[1].Clear(); NABOR[2].Clear(); NABOR[3].Clear(); NABOR[4].Clear(); NABOR[5].Clear(); NABOR[6].Clear();
            LimitKart = 5;
            LimitIg = 6;


            ETAP = 5;
        }

        if (ETAP == 5)
         {   /////
            LimitWin = 10;
            TEXT1 = "Перетасовка"; HISTORY.Add(TEXT1);
            MyList.Clear(); for (int i = 1; i <= 84; i++) { MyList.Add(Kart70[i]); }; ////формирование колоды
            MIX(); /// перетасовка
            /////розыгрыш карт династии
            Sbros.Clear(); for (int i = 1; i <= 6; i++) { Status[i] = i; Sbros.Add(i); };
            for (int i = 1; i <= 99; i++)
            {
                S = UnityEngine.Random.Range(0, 6); if (S < 0) S = 0; if (S > 5) S = 5;
                R = Sbros[S]; Sbros.Remove(R); Sbros.Add(R);
            };

            for (int i = 1; i <= LimitIg; i++)
                if (Sbros.Count > 0)
                {
                    S = UnityEngine.Random.Range(1, Sbros.Count); if (S < 1) S = 1; if (S > Sbros.Count - 1) S = Sbros.Count - 1;
                    Din[i] = Sbros[S]; Sbros.Remove(Sbros[S]);

                };
            Sbros.Clear();
            ///////

            ///

            
            //////Распределение перков
            for (int i = 1; i <= LimitIg; i++)
            {
                if (Din[i] == 1) Shortwin_1[i] = 1; else Shortwin_1[i] = -1;
                if (Din[i] == 2) Brat_2[i] = 1; else Brat_2[i] = -1;
                if (Din[i] == 3) Anycart_3[i] = 1; else Anycart_3[i] = -1;
                if (Din[i] == 4) Morecart_4[i] = 1; else Morecart_4[i] = -1;
                if (Din[i] == 5) Egalitewin_5[i] = 1; else Egalitewin_5[i] = -1;
                if (Din[i] == 6) Smert_6[i] = 1; else Smert_6[i] = -1;
            }

            /////// Розыгрыш номера человека
            S = UnityEngine.Random.Range(1, LimitIg + 1); if (S == 0) S = 1; if (S > LimitIg) S = LimitIg;
            Status[S] = 0; HUMAN = S;

           // for (int i = 1; i <= LimitIg; i++) { Din[i] = i; Status[i] = i; }; Status[3] = 0;//// без смешения

            for (int i = 1; i <= LimitIg; i++) { Stol[i].Add(Din[i] + 84); But[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties2/" + (Din[i]).ToString()); };
            /////// Розыгрыш первого хода
            S = UnityEngine.Random.Range(1, LimitIg + 1); if (S == 0) S = 1; if (S > LimitIg) S = LimitIg;
            Ig = S;
            /////////////
            AA = 100; a = 0; ETAP = 10;
            Panel0.SetActive(false); Panel1.SetActive(false); PanelBIG.SetActive(false); Smert_knopka.SetActive(false);



            /////////////////////////////////////////   for (int i = 1; i <= 33; i++) { R = MyList[0]; Sbros.Add(R); MyList.Remove(R); };
            /*  for (int i = 1; i <= 6; i++)
              {
                  S = UnityEngine.Random.Range(0, 5);
                  if (S>0) for (int j = 1; j <= S; j++) { R = MyList[0]; NABOR[i].Add(R); MyList.Remove(R); };
              }
                  ETAP = 84;*/
            // audio.PlayOneShot(impact0, 0.7F);
            Zvuk();
        }
        if (ETAP == 10)
        {
            a += 1;

            ShowStol(); ShowSbros();
            if (a > AA)
            {
                a = 0; ETAP = 30; AA = 250; /////if (MAX > 4) { a = 0; ETAP = 20; };
                for (int i = 1; i <= 6; i++)
                    if (Stol[i].Count > 0)
                        for (int j = 0; j < Stol[i].Count; j++)
                        {
                            R = Stol[i][j];
                            ///////////////// if (R >= 77 && R <= 82) { Stol[i].Remove(R); MyList.Add(R); };
                        }
            }
            //   if (Mathf.Repeat(a, 100) == 0) MyList.Remove(MyList[0]);

            for (int i = 1; i <= 6; i++)
            {
                if (Dophod[i] < 0) DOP[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop1");
                if (Dophod[i] > 0) DOP[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop2");
                if (Dophod[i] == 0) DOP[i].SetActive(false); else DOP[i].SetActive(true);
                if (Dophod[i] == 0 && favorit() == i)
                { DOP[i].SetActive(true); DOP[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop0"); }
            }

        }
        if (ETAP == 20)
        {
            for (int i = 1; i <= 10; i++)
            {
                S = UnityEngine.Random.Range(0, 7);
                if (S > 0 && S <= 6)
                    if (Stol[S].Count <= 10) break;
            }
            R = MyList[0]; //if (UnityEngine.Random.Range(0, 2)==1) R=Revers(R);
            if (Legal(S, R) && (R < 77 || R > 84))
            {
                MyList.Remove(R); Stol[S].Add(R); ETAP = 10; a = 0; AA = 50;
            }
            else
            {
                MyList.Remove(R); R = Revers(R); MyList.Add(R);
            }

            for (int i = 1; i <= Stol[1].Count; i++) { STOL1[i] = Stol[1][i - 1]; };
            for (int i = 1; i <= Stol[2].Count; i++) { STOL2[i] = Stol[2][i - 1]; };
            for (int i = 1; i <= Stol[3].Count; i++) { STOL3[i] = Stol[3][i - 1]; };
            for (int i = 1; i <= Stol[4].Count; i++) { STOL4[i] = Stol[4][i - 1]; };
            for (int i = 1; i <= Stol[5].Count; i++) { STOL5[i] = Stol[5][i - 1]; };
            for (int i = 1; i <= Stol[6].Count; i++) { STOL6[i] = Stol[6][i - 1]; };

            ///  S1 = Stol[1].Count + "/" + Stol[2].Count + "/" + Stol[3].Count + "/" + Stol[4].Count + "/" + Stol[5].Count + "/" + Stol[6].Count;

        }
        if (ETAP == 30) ///раздача изначальная
        {
            for (int i = 1; i <= LimitIg; i++)
            {                 
                        Brat(i, 5);
                      
                        a = 0; AA = NABOR[i].Count * 10 + 10;       //  ETAP = 40;  break;
                if (Status[i] == 0) OpenSpisok(NABOR[i]);
            }
            
                
                a = 0; ETAP = 40; /*NABOR[Ig].Add(80); Ig = Next(Ig); NABOR[Ig].Add(80); MyList.Remove(80);   */
             
            TEXT1 = "Раздача"; HISTORY.Add(TEXT1);

        }
        if (ETAP == 40) ///анимация раздачи
        {
            a += 1; TEXT1 += ".";
            ShowNabor(0);
            if (a > AA)
            {
                a = 0;
                ETAP = 50;

            }
        }
        if (ETAP == 50)//////НАЧАЛО ОСНОВНОГО ЦИКЛА
        {
            if (Timer <= 0 && Melody != 0) Zvuk();

          //  if (Status[Ig] != 0) Ocered.GetComponent<Text>().text = "Ход игрока " + Name[Din[Ig]];
          //  if (Status[Ig] == 0) Ocered.GetComponent<Text>().text = "ВАШ ХОД, " + Name[Din[Ig]];
            if (Status[Ig] == 0) OpenSpisok(NABOR[Ig]);

            for (int i = 1; i <= 6; i++) if (i == Ig) But[i].GetComponent<Button>().interactable = true; else But[i].GetComponent<Button>().interactable = false;
            ////.GetComponent<Button>().interactable = false;
            REVERS_knopka.GetComponentInChildren<Text>().text = "Перевернуть";
            a += 1; AA = 55; 
            ShowNabor(0); ////ShowPanelIg(HUMAN);
            ShowSbros();
            if (a > AA)
            {
                if (Status[Ig] != 0) TEXT1 =  Ig + ". Ход династии " + Name[Din[Ig]];
                if (Status[Ig] == 0)
                {
					TEXT1 =  Ig + ". ВАШ ХОД, " + Name[Din[Ig]];
                    var v = HodII(Ig); if (v < 0) TEXT1 += ". (ходить нечем)";
                }
                
                Ocered.GetComponent<Text>().text = TEXT1;
                
                ////предходовая подготовка кнопок
                NOMOVE = false; REVERS = false; NSTOL = 0; PROP = false; VZJAT = false; SMERT = false; CLOSE = false;
                Panel1_Button2.SetActive(false);
                for (int i = 1; i <= 6; i++) STR[i].SetActive(false); ////обнуление кнопок-стрелок
                LIM = LimitKart;
                if (Morecart_4[Ig] > 0) LIM = LimitKart + 1;  ////перк взять на две карты больше
                KOL = 0;
                if (NABOR[Ig].Count + 1 <= LIM) KOL = 1;
                if (Brat_2[Ig] > 0 && NABOR[Ig].Count + 2 <= LIM) KOL = 2;
                if (KOL == 0) VZJAT_knopka.SetActive(false); else VZJAT_knopka.SetActive(true);
                if (KOL == 1 ) { VZJAT_knopka.GetComponentInChildren<Text>().text = "Взять 1 карту"; }
                if (KOL == 2 ) { VZJAT_knopka.GetComponentInChildren<Text>().text = "Взять 2 карты"; }
                if (Status[Ig] != 0) VZJAT_knopka.SetActive(false);
                ETAP = 65; a = 0; b = 0; BB = 0;

            }
        }
		if (ETAP == 65 && Status[Ig] != 0)
        { 
            var v = HodII(Ig);
          ///////////////////////  SSS = "v=" + v;
            var lider = favorit();
            if (Smert_6[Ig] > 0)
            {
                 if (lider != Ig && lider!=0 && (Risk(lider)>3 || (Risk(lider)>0 && Stol[lider].Count>7) ) )
                 {
                    ETAP = 102; NSTOL = lider;  Smert_6[Ig] = 0; GAMEOVER = 0;
                    ZvukSmert(); AA = 800; TEXT1 += " ПРИМЕНЯЕТ СМЕРТЬ к лидеру."; Ocered.GetComponent<Text>().text = TEXT1;
                }
                
                if (ETAP == 65 && lider!=Ig)
                {
                    var max = -1;
                    for (int i = 1; i <= LimitIg; i++)
                        if (i != Ig)
                        {
                            if (max < Risk(i)) { NSTOL = i; max = Risk(i); }
                        }
                    if (max > 3 || GAMEOVER>5)
                    {
                        ETAP = 102;  Smert_6[Ig] = 0; GAMEOVER = 0;
                        ZvukSmert(); AA = 800; TEXT1 += " ПРИМЕНЯЕТ СМЕРТЬ."+ GAMEOVER; Ocered.GetComponent<Text>().text = TEXT1;
                    }
                }
                    

            }




			if (ETAP == 65 && KOL > 0 && lider==Ig && MAX<=0) { a = 0; ETAP = 69; AA = 100; }///не делать активных ходов если ты фаворит

			if (ETAP == 65 && KOL == 0 && lider == Ig && MAX <= 0 && NABOR[Ig].Count<7 && GAMEOVER>3) { ETAP = 150; GAMEOVER += 1; TEXT1 += " намеренно ПРОПУСКАЕТ ХОД."; Ocered.GetComponent<Text>().text = TEXT1; };
			///не делать активных ходов если ты фаворит

            if (ETAP == 65 && KOL > 0 && v == -1) { a = 0; ETAP = 69; AA = 100; }
            if (ETAP == 65 && KOL > 0 && MAX <= 0 && (GAMEOVER <= 3 || lider == 0)) { a = 0; ETAP = 69; AA = 100; }
			if (ETAP == 65 && KOL == 0 && v == -1) { ETAP = 150; GAMEOVER += 1; TEXT1 += " вынужденно ПРОПУСКАЕТ ХОД."; Ocered.GetComponent<Text>().text = TEXT1; };
            if (ETAP==65 && MAX <= -100 && (GAMEOVER <= 3 || lider == 0)) { ETAP = 150; GAMEOVER += 1; TEXT1 += " ПРОПУСКАЕТ ХОД."; Ocered.GetComponent<Text>().text = TEXT1; };
			if (ETAP==65 && MAX <= -7000 && GAMEOVER <= 7 ) { ETAP = 150; GAMEOVER += 1; TEXT1 += " ПРОПУСКАЕТ ХОД."; Ocered.GetComponent<Text>().text = TEXT1; };

            if (ETAP == 65 )
            {
                NSTOL = VAR[v]; R = VAR0[v]; SSS += "R=" + R;
                var s = 0; for (int i = 0; i < NABOR[Ig].Count; i++) if (NABOR[Ig][i] == R) s += 1;
                if (s == 0) { for (int i = 0; i < NABOR[Ig].Count; i++) NABOR[Ig][i] = Revers(NABOR[Ig][i]); };
                ETAP = 70; a = 0;
            };
         ////////////////   SSS += "/NSTOL=" + NSTOL + "/"; for (int i = 0; i < NABOR[Ig].Count; i++) SSS = SSS + NABOR[Ig][i] + ", ";
             
        }
            if (ETAP == 65000000 && Status[Ig] >= 2 )
        {
            var A = 0; var B = 0; var r = 0;
            var lider = favorit(); if (lider == 0 || lider == Ig) lider = HUMAN;
            R = -1; a = 0;
            if (KOL > 0 && GAMEOVER <= 3) { a = 0; ETAP = 69; AA = 100; }
            if (KOL > 0 && favorit() == Ig) { a = 0; ETAP = 69; AA = 100; }

            if (KOL == 0 || GAMEOVER > 3)
            {
                var k = Stol[HUMAN].Count;
                var z = 0;
                R = -1; NSTOL = Ig;
                ///подгадить человеку или лидеру

                for (int i = 0; i < NABOR[Ig].Count; i++)
                {
                    r = NABOR[Ig][i];
                    A = Mathf.RoundToInt(r / 100);
                    B = r - A * 100;
                    if (Legal(lider, r))
                    {
                        if (B == 13) { R = r; NSTOL = lider; }
                    }
                }
                if (R == -1)
                {
                    for (int i = 0; i < NABOR[Ig].Count; i++) NABOR[Ig][i] = Revers(NABOR[Ig][i]);
                    for (int i = 0; i < NABOR[Ig].Count; i++)
                    {
                        r = NABOR[Ig][i];
                        A = Mathf.RoundToInt(r / 100);
                        B = r - A * 100;
                        if (Legal(lider, r))
                        {
                            if (B == 13) { R = r; NSTOL = lider; }
                        }
                    }
                }
                if (R == -1)
                {
                    if (k > 1) z = Stol[lider][k - 1];
                    if (z > 100)
                    {
                        for (int i = 0; i < NABOR[Ig].Count; i++)
                        {
                            r = NABOR[Ig][i];
                            A = Mathf.RoundToInt(r / 100);
                            B = r - A * 100;
                            if (Legal(lider, r))
                            {
                                if (B == 2) { R = r; NSTOL = lider; }
                            }
                        }
                    }
                }
                if (R == -1)
                {
                    for (int i = 0; i < NABOR[Ig].Count; i++) NABOR[Ig][i] = Revers(NABOR[Ig][i]);
                    if (k > 1) z = Stol[lider][k - 1];
                    if (z > 100)
                    {
                        for (int i = 0; i < NABOR[Ig].Count; i++)
                        {
                            r = NABOR[Ig][i];
                            A = Mathf.RoundToInt(r / 100);
                            B = r - A * 100;
                            if (Legal(lider, r))
                            {
                                if (B == 2) { R = r; NSTOL = lider; }
                            }
                        }
                    }
                }

                if (R == -1)
                {
                    if (k > 1) z = Stol[lider][k - 1];
                    if (z < 100)
                        for (int i = 0; i < NABOR[Ig].Count; i++)
                        {
                            r = NABOR[Ig][i];
                            A = Mathf.RoundToInt(r / 100);
                            B = r - A * 100;
                            if (Legal(lider, r))
                            {
                                if (B == 7) { R = r; NSTOL = lider; }
                            }
                        }
                }
                if (R == -1)
                {
                    for (int i = 0; i < NABOR[Ig].Count; i++) NABOR[Ig][i] = Revers(NABOR[Ig][i]);
                    if (k > 1) z = Stol[lider][k - 1];
                    if (z < 100)
                        for (int i = 0; i < NABOR[Ig].Count; i++)
                        {
                            r = NABOR[Ig][i];
                            A = Mathf.RoundToInt(r / 100);
                            B = r - A * 100;
                            if (Legal(lider, r))
                            {
                                if (B == 7) { R = r; NSTOL = lider; }
                            }
                        }
                }
                if (R == -1)
                    for (int i = 0; i < NABOR[Ig].Count; i++)///сходить к себе
                    {
                        NSTOL = Ig;
                        r = NABOR[Ig][i];
                        A = Mathf.RoundToInt(r / 100);
                        B = r - A * 100;
                        if (Legal(Ig, r))
                        {
                            if (r >= 71 && r <= 76 && Stol[Ig].Count > 1) R = r;
                            if (r >= 71 && r <= 76 && favorit() != Ig && GAMEOVER > 2) R = r;
                            if (r > 100 && B != 13 && B != 2 && B != 7) R = r;
                        }
                    }
                if (R == -1)
                {
                    NSTOL = Ig;
                    for (int i = 0; i < NABOR[Ig].Count; i++) NABOR[Ig][i] = Revers(NABOR[Ig][i]);
                    for (int i = 0; i < NABOR[Ig].Count; i++)
                    {
                        r = NABOR[Ig][i];
                        A = Mathf.RoundToInt(r / 100);
                        B = r - A * 100;
                        if (Legal(Ig, r))
                        {
                            if (r >= 71 && r <= 76 && Stol[Ig].Count > 1) R = r;
                            if (r >= 71 && r <= 76 && favorit() != Ig && GAMEOVER > 2) R = r;
                            if (r > 100 && B != 13 && B != 2) R = r;
                        }
                    }
                }
                if (R == -1)/// supercart
                {
                    for (int i = 0; i < NABOR[Ig].Count; i++)
                    {
                        r = NABOR[Ig][i];
                        if (Legal(Ig, r))
                        {
                            if (r >= 71 && r <= 84) { R = r; NSTOL = Ig; ETAP = 70; a = 0; AA = 100; };
                        }

                    }
                }

                if (R == -1)////на чужие
                {
                    for (int j = 1; j <= LimitIg; j++)
                        for (int i = 0; i < NABOR[Ig].Count; i++)
                        {
                            // S = UnityEngine.Random.Range(0, 7); if (S > 3) NABOR[Ig][i] = Revers(NABOR[Ig][i]);
                            r = NABOR[Ig][i];
                            A = Mathf.RoundToInt(r / 100);
                            B = r - A * 100;
                            if (Legal(j, r))
                            {
                                if (r > 100) { R = r; NSTOL = j; }
                            }
                        }
                }
                if (R == -1)////на чужие
                {
                    for (int i = 0; i < NABOR[Ig].Count; i++) NABOR[Ig][i] = Revers(NABOR[Ig][i]);
                    for (int j = 1; j <= LimitIg; j++)
                        for (int i = 0; i < NABOR[Ig].Count; i++)
                        {
                            r = NABOR[Ig][i];
                            A = Mathf.RoundToInt(r / 100);
                            B = r - A * 100;
                            if (Legal(j, r))
                            {
                                if (r > 100) { R = r; NSTOL = j; }
                            }
                        }
                }
            }

            if (ETAP == 65 && GAMEOVER > 3 && favorit() == Ig) { ETAP = 150; GAMEOVER += 1; };
            if (ETAP == 65 && KOL > 0 && R == -1) { a = 0; ETAP = 69; AA = 100; }
            if (ETAP == 65 && R == -1) { ETAP = 150; GAMEOVER += 1; TEXT1 += " ПРОПУСКАЕТ ХОД."; Ocered.GetComponent<Text>().text = TEXT1; };
            if (ETAP == 65 && R > 0) { ETAP = 70; a = 0; };
            var kk = Stol[lider].Count;
            if (kk > 4 && Smert_6[Ig] > 0 && Stol[lider][kk - 1] > 100 && Stol[lider][kk - 2] > 100)
            { ETAP = 102; NSTOL = lider;  Smert_6[Ig] = 0; ZvukSmert(); AA = 800; TEXT1 += " ПРИМЕНЯЕТ СМЕРТЬ."; Ocered.GetComponent<Text>().text = TEXT1; }
        }
        if (ETAP == 65 && Status[Ig] == 0)
        { //////if (NOMOVE == false) a = 10;
            if (a == 0)
            {
                AA = 50;
                if (NABOR[Ig].Count > 6) { Panel_Left.SetActive(true); Panel_Right.SetActive(true); }
                else { Panel_Left.SetActive(false); Panel_Right.SetActive(false); }
                R = Vibor(NABOR[Ig], "переверни");
                if (R > 0) for (int i = 0; i < NABOR[Ig].Count; i++)
                        if (KartToNum(NABOR[Ig][i]) == Past) { NABOR[Ig][i] = Revers(NABOR[Ig][i]); a = 10; R = 0; break; }

                if (Past > 70 && Past < 100) { REVERS_knopka.SetActive(false); };
                if (LEFT) { GoLeft(NABOR[Ig]); GoLeft(NABOR[Ig]); GoLeft(NABOR[Ig]); LEFT = false; a = 1; };
                if (RIGHT && NABOR[Ig].Count > 0) { GoRight(NABOR[Ig]); GoRight(NABOR[Ig]); GoRight(NABOR[Ig]); RIGHT = false; a = 1; }

                if (Past > 0)
                    for (int i = 0; i < NABOR[Ig].Count; i++)
                        if (KartToNum(NABOR[Ig][i]) == Past)
                            for (int j = 1; j <= 6; j++)
                            {
                                var x = 0; var y = 0;
                                if (Legal(j, NABOR[Ig][i]))
                                {
                                    x = XX[j]; /// Mathf.RoundToInt(But[j].transform.localPosition.x) + (j - 1) * 27 ;
                                    y = YY[j] + 160;
                                    STR[j].transform.position = new Vector3(x, y, 0);
                                    STR[j].SetActive(true);
                                    if (Ig == j) STR[j].GetComponent<Image>().sprite = Resources.Load<Sprite>("ArrowY"); else STR[j].GetComponent<Image>().sprite = Resources.Load<Sprite>("Arrow");
                                }
                                else STR[j].SetActive(false);
                                var r = Revers(NABOR[Ig][i]);

                                if (r > 100 && Legal(j, r) && Legal(j, NABOR[Ig][i]) == false)
                                {
                                    x = XX[j]; /// Mathf.RoundToInt(But[j].transform.localPosition.x) + (j - 1) * 27 ;
                                    y = YY[j] + 80;
                                    STR2[j].transform.position = new Vector3(x, y, 0);
                                    STR2[j].SetActive(true);
                                    if (Ig == j) STR2[j].GetComponent<Image>().sprite = Resources.Load<Sprite>("ArrowY"); else STR2[j].GetComponent<Image>().sprite = Resources.Load<Sprite>("Arrow");
                                }
                                else STR2[j].SetActive(false);
                            }

                if (Past >= 71 && Past <= 84) REVERS_knopka.SetActive(false);

                if (Past == 0 && SMERT == false) for (int i = 1; i <= 6; i++) { STR[i].SetActive(false); STR2[i].SetActive(false); } ////обнуление кнопок-стрелок

                if (SMERT && NSTOL == 0) for (int j = 1; j <= 6; j++)
                    {
                        var x = XX[j]; /// Mathf.RoundToInt(But[j].transform.localPosition.x) + (j - 1) * 27 ;
                        var y = YY[j] + 160;
                        STR[j].transform.position = new Vector3(x, y, 0);
                        STR[j].SetActive(true);
                        if (Ig == j) STR[j].GetComponent<Image>().sprite = Resources.Load<Sprite>("ArrowY");
                        else STR[j].GetComponent<Image>().sprite = Resources.Load<Sprite>("ArrowR");

                    }

                if ((Past != 0) && NSTOL != 0) for (int i = 0; i < NABOR[Ig].Count; i++) ///если выбор номера стола сделан 
                        if (KartToNum(NABOR[Ig][i]) == Past)
                        { a = 0; ETAP = 70; R = NABOR[Ig][i]; if (NSTOL == 0) NSTOL = Ig; }/////////////////
                if (SMERT && NSTOL > 0)
                { ETAP = 102;  Smert_6[Ig] = 0; ZvukSmert(); AA = 800; TEXT1 += " ПРИМЕНЯЕТ СМЕРТЬ."; Ocered.GetComponent<Text>().text = TEXT1; }

                if (PROP) { a = AA + 1; Past = 0; ETAP = 150; GAMEOVER += 1; TEXT1 += " ПРОПУСКАЕТ ХОД."; Ocered.GetComponent<Text>().text = TEXT1; } ///пропуск хода
                if (VZJAT) ///взять
                {
                    VZJAT_knopka.SetActive(false);
                    
                    ETAP = 69; a = AA + 1; AA = 100;
                }
                if (Past == 0) REVERS_knopka.SetActive(false);
            }

            if (a >= 1)
            {
                ShowPanelIg(Ig); a += 1;
                if (NOMOVE && REVERS == false) a = AA + 1;
                if (PROP || VZJAT) a = AA + 1;
            }
            if (a > AA)
            {
                a = 0; ; REVERS = false;
                NOMOVE = true; LEFT = false; RIGHT = false;
              ///////////////  SSS = ""; for (int i = 0; i < NABOR[Ig].Count; i++) SSS = SSS + NABOR[Ig][i] + ", ";
            }
        }

        if (ETAP == 69) ////взять анимация
        {

            if (a == 0)
            {
                TEXT1 += " Берет из колоды."; Ocered.GetComponent<Text>().text = TEXT1;
                GAMEOVER += 1;
                var L = LimitKart;
                if (Morecart_4[Ig] > 0) L = LimitKart + 1;  ////перк взять на две карты больше
                var K = 1;
                if (Brat_2[Ig] > 0 && NABOR[Ig].Count + 2 <= L) K = 2;
                Brat(Ig, K); ///брать из колоды игроку Иг К карт
            }
            a += 1; ShowNabor(0);
            if (a > AA) { ETAP = 150; a = 0; };
        }
        if (ETAP == 70) /// собственно сам ход
        {

            if (a == 0)
            {                
                TEXT1 += " Ходит картой "+ TextKart(R); Ocered.GetComponent<Text>().text = TEXT1;
                for (int i = 1; i <= 6; i++) { STR[i].SetActive(false); STR2[i].SetActive(false); }////обнуление кнопок-стрелок
                if (NSTOL < 0)
                {
                    for (int i = 0; i < NABOR[Ig].Count; i++) if (R == NABOR[Ig][i]) { NABOR[Ig][i] = Revers(NABOR[Ig][i]); }
                    NSTOL = -NSTOL; R = Revers(R); REVERS = true;
                    ROTATE = KartToNum(R);
                }
                var A = Mathf.RoundToInt(R / 100);
                var B = R - A * 100;
                if (B == 2) { ZvukSmert(); AA = 300; }//
                if (B == 7 || R == 77 || R == 78) { ZvukKnigt(); AA = 300; }//ZvukKnigt()
                if (R == 81 || R == 82) { ZvukSator(); AA = 300; }

                GAMEOVER = 0;
                REVERS_knopka.SetActive(false);

                if (R >= 77 && R <= 84)
                { Stol[0].Add(R); NABOR[Ig].Remove(R); } ////если суперкарта (не замок)
                else
                { Stol[NSTOL].Add(R); NABOR[Ig].Remove(R); Past = 0; } ////если замок или обычная карта

            }
            a += 1;
            ShowStol(); S1 = "R=" + R + "/ NSTOL=" + NSTOL + ", REVERS=" + REVERS;
            if (a > AA)
            {
                S = NSTOL;
                //   if (R >= 77 && R <= 84)
                //   { Stol[NSTOL].Remove(R); S1 = S1 + "R=" + R + "/ NSTOL=" + NSTOL + ", REVERS=" + REVERS; }///очистка сыгравшей суперкарты
                ROTATE = 0; ShowStol();
                ETAP = 75; a = 0;
            }
        }
        if (ETAP == 75) ///последствия хода - uzel raspredelenia
        {
            a = 0;
            LEFT = false; RIGHT = false;
            if (R >= 77 && R <= 84)
            { Stol[0].Remove(R); Sbros.Add(R); S1 = S1 + "R=" + R + "/ NSTOL=" + NSTOL + ", REVERS=" + REVERS; }///очистка сыгравшей суперкарты
            if (R >= 71 && R <= 76) ETAP = 150; ///замок, нет последствий
            if (R == 77 || R == 78)
            {
                S = 0; for (int i = 1; i <= LimitIg; i++) if (XPOHOD[i]) S += 1;
                if (S == 0) { ETAP = 77; a = 0; b = 0; Past = 0; LEFT = false; RIGHT = false; YES = false; NO = false; J1 = Ig; }
                else ETAP = 78;///поход закончен
            }; //крестовый поход
            if (R >= 80 && R <= 83) { ETAP = 80; a = 0; YES = false; NO = false; }///Суперкарты без заморочек
            if (R == 79) ETAP = 79; /////Возрождение
            if (R == 84) ETAP = 84;

            if (R > 100) ETAP = 100; ///последствия обычных карт

        }
        if (ETAP == 77) //KP начинается
        {
            Panel0_Button1.GetComponentInChildren<Text>().text = "Да"; Panel0_Button2.GetComponentInChildren<Text>().text = "Нет";
            if (a == 0)
            {
                AA = 300;
                Panel0.SetActive(true); Panel0.transform.SetAsLastSibling();
                Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                SSS = ""; AA = 100;
                SSS = Name[Din[J1]] + ", Вы объявили крестовый поход";
                Panel0_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("super/77");
                Past = 0; XPOHOD[J1] = true; a = 20;
                if (NABOR[Ig].Count == 0) { SSS += "но у вас нет карт. Поход отменен."; XPOHOD[J1] = false; a = 40; AA = 200; }
                else { DOP[J1].SetActive(true); DOP[J1].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop3"); }
                Panel0_Text.GetComponentInChildren<Text>().text = SSS;
                SF = 0;
                
            }
            if (a == 10)
            {
                ///AA = 20;

                //if (NOMOVE == false)
                // {
                if (Status[J1] == 0) { ShowPanelIg(J1); ShowNabor(0); }
                else { ShowNabor(0); }
                //  }

                Panel0_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + (Din[J1]).ToString());
                SF = ViborYesNo(J1, Name[Din[J1]] + ", Вы хотите присоединиться к крестовому походу?");
                if (NABOR[J1].Count == 0) SF = -1;
                ////если робот
                if (Status[J1] != 0)
                {
                    if (Cena(SbrosII(NABOR[J1])) < 50) SF = 1; else SF = -1;
                    if (NABOR[J1].Count <= 3) SF = -1;
                    ///Panel0_Text.GetComponentInChildren<Text>().text = SSS;
                    Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                }
                ///
                if (SF == -1) SSS = SSS + "/" + Name[Din[J1]] + "-нет/ " ;
                if (SF == 1) SSS = SSS + "/" + Name[Din[J1]] + "-да/ ";
                if (SF!=0) Panel0_Text.GetComponentInChildren<Text>().text = SSS;
                if (SF > 0) { a = 20; SF = 0; AA = 100; XPOHOD[J1] = true; DOP[J1].SetActive(true); DOP[J1].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop3"); }
                else
                if (SF < 0 || NABOR[J1].Count == 0) { a = 30; SF = 0; XPOHOD[J1] = false; DOP[J1].SetActive(true); DOP[J1].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop4"); }
            }
            if (a == 20 && Status[J1] == 0)
            {
                if (NABOR[J1].Count > 6) { Panel_Left.SetActive(true); Panel_Right.SetActive(true); }
                AA = 100;
                Panel0_Text.GetComponentInChildren<Text>().text = Name[Din[J1]] + ", Вы вступили в крестовый поход. Скиньте одну карту";
                SF = Vibor(NABOR[J1], "сбросить в поход");
                if (LEFT) { GoLeft(NABOR[J1]); LEFT = false; };
                if (RIGHT) { GoRight(NABOR[J1]); RIGHT = false; };
                if (NOMOVE == false) ShowPanelIg(J1);
                if (SF != 0) { NABOR[J1].Remove(SF); Sbros.Add(SF); a = 30; }
            }
            if (a == 20 && Status[J1] != 0)
            {
                Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                SF = 0;
                Panel0_Text.GetComponentInChildren<Text>().text = Name[Din[J1]] + ", Вы вступили в крестовый поход. Скиньте одну карту";
                SF = SbrosII(NABOR[J1]);

                if (SF != 0) { NABOR[J1].Remove(SF); Sbros.Add(SF); a = 30; }
            }
            if (a == 30) { J1 = Next(J1); a = 40; }
            if (a >= 40)
            {
                a += 1; ShowSbros(); /*ShowPanelIg(J1);/* ShowNabor(J1);*/
                SF = 0; 
            }
            if (a > 100)
            {
                Panel0_Text.GetComponentInChildren<Text>().text = SSS;
                if (J1 == Ig) { a += 1; } else { a = 10; AA = 20; NOMOVE = false; }
            }
            if (a > 300) ETAP = 150;
            ////////////////  ETAP = 150; ///// убрать после написания
        }


        if (ETAP == 78) ///поход закончен
        {
            if (a == 0)
            {
                var txt = "КРЕСТОВЫЙ ПОХОД закончен " + "\r\n";
                AA = 400;
                J1 = Ig;
                Panel0.SetActive(true); Panel0.transform.SetAsLastSibling();
                Panel0_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("super/77");
                var s0 = S;
                if (MyList.Count + Sbros.Count <= S * S + 12 && S > 1) { S -= 1; txt = "КРЕСТОВЫЙ ПОХОД закончен неудачно, добыча снижена на 1 карту." + "\r\n"; }
                if (MyList.Count + Sbros.Count <= S * S + 12 && S > 1) { S -= 1; txt = "КРЕСТОВЫЙ ПОХОД закончен неудачно, добыча снижена на 2 карты." + "\r\n"; }

                if (MyList.Count + Sbros.Count > S * S + 12)
                {
                    if (S == 1) Panel0_Text.GetComponentInChildren<Text>().text = txt + " Все участники получают одну карту.";
                    if (S > 1) Panel0_Text.GetComponentInChildren<Text>().text = txt + " Все участники получают " + S + " карты.";
                    if (S > 3) Panel0_Text.GetComponentInChildren<Text>().text = txt + " Все участники получают " + S + " карт.";
                    Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);

                    for (int i = 1; i <= LimitIg; i++)
                    {
                        if (XPOHOD[J1]) Brat(J1, S);
                        J1 = Next(J1);

                    }
                }
                else
                {
                    Panel0_Text.GetComponentInChildren<Text>().text = "Крестовый поход закончился разгромом, сарацины торжествуют";
                    Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                    for (int i = 1; i <= 6; i++) XPOHOD[i] = false;
                }

            }
            a += 1; ShowNabor(Ig); ShowPanelIg(Ig);
            if (a > AA)
            {
                for (int i = 1; i <= 6; i++) XPOHOD[i] = false;
                ETAP = 150; a = 0; Panel0.SetActive(false);
            }

        }
        if (ETAP == 79) //Возрождение
        {
            var txt = "";
            if (Melody != 0) Zvuk();
            if (a == 0)
            {
                AA = 150; a = 50; for (int i = 1; i <= 99; i++) ShowSbros(); a = 0;
                Sbros.Remove(79);//// убрать карту из сброса, так как карта сама не может быть восстановлена
                Panel1_Karta2.SetActive(false);
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("super/79");
                txt = "ЭПОХА ВОЗРОЖДЕНИЯ. Каждый из игроков, начиная с инициатора, может выбрать себе карту из сноса.  ";
                J1 = Ig;
                a = 10;
                if (Sbros.Count < 1)
                {
                    txt = "ЭПОХА ВОЗРОЖДЕНИЯ. Поскольку в сносе нет карт, карта просто уходит в сброс"; a = 51;
                }
                Panel1_Text.GetComponentInChildren<Text>().text = txt;
                if (Status[J1] == 0) OpenSpisok(Sbros); else CloseSpisok(Sbros);
                AA = 75;
            }
            if (a == 10)
            {
                

                Panel1_Karta2.SetActive(false);
                txt += Name[Din[J1]] + ", выберите по 1 карте ИЗ сброса.";
                Panel1_Text.GetComponentInChildren<Text>().text = txt;
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[J1]);
                ///ShowNabor(NOMIG);
                Panel1_SPISOK(Sbros);
                if (LEFT) GoLeft(Sbros);
                SF = Vibor(Sbros, "забрать ");
                //если робот//
                if (Status[J1] != 0) SF = ZahvatII(Sbros);
                /////
                if (SF > 0)
                {
                    NABOR[J1].Add(SF); Sbros.Remove(SF);
                    J1 = Next(J1); SF = 0;
                    a = 11;////для анимации улета отданой карты

                    if (J1 == Ig || Sbros.Count == 0) { a = AA + 1; }////круг сделан или карты кончились
                    if (Status[J1] == 0) OpenSpisok(Sbros); else CloseSpisok(Sbros);
                }
            }
            if (a >= 11 && a < 50) { a += 1; ShowNabor(0); }
            if (a == 50) { a = 10; }

            if (a >= 51) { a += 1; ShowNabor(0); }

            if (a > AA)
            {
                ETAP = 150; Sbros.Add(79); ////окончание хода
            }
        }


        if (ETAP == 80)
        {  ////Суперкарты без заморочек
            if (a == 0)
            {
                Panel0.SetActive(true); Panel0.transform.SetAsLastSibling(); AA = 200;
                Panel0_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("super/" + (R).ToString());
                if (R == 81)
                {
                    Panel0_Karta.GetComponentInChildren<Text>().text = "ИНКВИЗИЦИЯ";
                    Panel0_Text.GetComponentInChildren<Text>().text = "ИНКВИЗИЦИЯ. Со стола удаляются все карты с ересью";
                    Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                    InkRef(8);/// инквизиция InkRef(8), реформация InkRef(13)
                    a = 1;
                }
                if (R == 83)
                {
                    Panel0_Karta.GetComponentInChildren<Text>().text = "РЕФОРМАЦИЯ";
                    Panel0_Text.GetComponentInChildren<Text>().text = "РЕФОРМАЦИЯ. Со стола удаляются все карты с монастырями";
                    Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                    InkRef(13);/// инквизиция InkRef(8), реформация InkRef(13)
                    a = 1;
                }
                if (R == 82)
                {
                    Panel0_Karta.GetComponentInChildren<Text>().text = "ЧУМА";
                    Panel0_Text.GetComponentInChildren<Text>().text = "ЧУМА. У всех династий снимается со стола по одной карте";
                    Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false);
                    Pesta();
                    a = 1;

                }
                if (R == 80) //////////XWar(1)
                {
                    Panel0_Text.GetComponentInChildren<Text>().text = "КРЕСТЬЯНСКАЯ ВОЙНА. Все меняются картами с руки по кругу";
                    Panel0_Button1.SetActive(true); Panel0_Button2.SetActive(true);
                    Panel0_Button1.GetComponentInChildren<Text>().text = "Отдать карты налево"; Panel0_Button2.GetComponentInChildren<Text>().text = "Отдать карты направо";
                    if (YES) { a = 1; Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false); XWar(1); }
                    else
                    if (NO) { a = 1; Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false); XWar(-1); }
                    ////если робот
                    if (Status[Ig] != 0) { var i1 = Last(Ig); var i2 = Next(Ig); if (NABOR[i1].Count > NABOR[i2].Count) YES = true; else NO = true; }
                    ///
                }

            }
            if (a > 0) { a += 1; ShowNabor(0); ShowSbros(); }
            if (a > AA) { ShowStol(); ETAP = 150; a = 0; Panel0.SetActive(false); }
        }

        if (ETAP == 84) ///выборы императора
        {
            if (a == 0)
            {
                var txt = "";
                PanelBIG.SetActive(true); PanelBIG.transform.SetAsLastSibling();
                PanelBIG.transform.position = new Vector3(500, 400, 0);
                Kand[0].GetComponentInChildren<Text>().text = "Выборы императора";
                for (int j = 1; j <= LimitIg; j++) Kand[j].GetComponentInChildren<Text>().text = "нет";

                for (int i = 1; i <= LimitIg; i++)
                {
                    var j = Din[i];
                    var k = NABOR[i].Count;
                    if (k > 0) Kand[j].GetComponentInChildren<Text>().text = k + " карт.";
                    if (k == 1 || k == 21 || k == 31) Kand[j].GetComponentInChildren<Text>().text = k + " картa.";
                    if (k > 1 && k < 5) Kand[j].GetComponentInChildren<Text>().text = k + " карты.";
                    if (k > 21 && k < 25) Kand[j].GetComponentInChildren<Text>().text = k + " карты.";
                }
                MAX = -1; for (int i = 1; i <= LimitIg; i++) if (NABOR[i].Count > MAX) { MAX = NABOR[i].Count; };
                S = 0; J1 = 0; for (int i = 1; i <= LimitIg; i++) if (NABOR[i].Count == MAX) { J1 = i; S += 1; }
                if (S > 1) ////если максимальных больше 2 кандидитов, проверка на перк
                {
                    S = 0; J1 = 0; for (int i = 1; i <= LimitIg; i++) if (NABOR[i].Count == MAX && Egalitewin_5[i] > 0) { J1 = i; S += 1; }
                    if (S > 1) { txt = "\r\n" + "Выборы императора не состоялись. Ничья. Перк '+1 при равной длине' сразу у двух кандидатов....."; J1 = 0; }
                    if (S == 1) { var j = Din[J1]; txt = "Несмотря на равное количество голосов, у династии " + Name[j] + " сработал Перк '+1 при равной длине'"; }
                }
                if (J1 == 0) { txt = "\r\n" + "Выборы императора не состоялись. Ничья."; }
                if (J1 > 0) { var j = Din[J1]; txt = txt + "\r\n" + "ИМПЕРАТОР ВЫБРАН. Правящая династия " + Name[j]; }

                TextV.GetComponentInChildren<Text>().text = txt;
                if (J1 > 0)
                {
                    Kand[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + (Din[J1]).ToString());

                    if (NABOR[J1].Count > 0) for (int i = 0; i < NABOR[J1].Count; i++) { Sbros.Add(NABOR[J1][i]); };
                    NABOR[J1].Clear(); ///сброс карт императора
                } else Kand[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("super/84");
                a = 1; AA = 500; REVERS = false;
            }
            if (a > 0)
            {
                a += 1;
                REVERS_knopka.SetActive(true); REVERS_knopka.GetComponentInChildren<Text>().text = "Продолжить игру или ждать " + (AA - a);
                var X = Kand[0].transform.localPosition.x;
                var Y = Kand[0].transform.localPosition.y;
                REVERS_knopka.transform.localPosition = new Vector3(X, Y, 0); REVERS_knopka.transform.SetAsLastSibling();
                if (REVERS) a = AA + 1;
            }

            if (a > AA) { a = 0; if (J1 == 0) { ETAP = 150; PanelBIG.SetActive(false); } else { ETAP = 85; b = 1000; a = 0; REVERS = false; REVERS_knopka.SetActive(false); } }


        }
        if (ETAP == 85)
        {
            if (a == 0)
            {

                PanelBIG.SetActive(true);

                for (int i = 1; i <= 6; i++)
                {

                    Kand[i].GetComponent<Button>().interactable = true;
                    var j = J1;
/////если перков свободных больше нет они обновляются зново
if (Shortwin_1[j]!=-1 && Brat_2[j] != -1 && Anycart_3[j]!=-1 && Morecart_4[j]!=-1 && Egalitewin_5[j]!=-1 && Smert_6[j]!=-1)
{ Shortwin_1[j] = -1; Brat_2[j] = -1; Anycart_3[j] = -1; Morecart_4[j] = -1; Egalitewin_5[j] = -1; Smert_6[j] = -1; };
///


                    if (i == 1 && Shortwin_1[j] >= 0) Kand[i].GetComponent<Button>().interactable = false;
                    if (i == 2 && Brat_2[j] >= 0) Kand[i].GetComponent<Button>().interactable = false;
                    if (i == 3 && Anycart_3[j] >= 0) Kand[i].GetComponent<Button>().interactable = false;
                    if (i == 4 && Morecart_4[j] >= 0) Kand[i].GetComponent<Button>().interactable = false;
                    if (i == 5 && Egalitewin_5[j] >= 0) Kand[i].GetComponent<Button>().interactable = false;
                    if (i == 6 && Smert_6[j] >= 0) Kand[i].GetComponent<Button>().interactable = false;
                }
                NSTOL = 0;
                if (Status[J1] == 0) a = 1; else a = 2;
            }
            if (a == 1)
            {
                AA = 400;
                b -= 1; if (b < 0) a = 3;
                Kand[0].GetComponentInChildren<Text>().text = "Ваше императорское величество, выберите династию, перк которой вы хотите взять.  Время на раздумье " + b;
                if (NSTOL > 0)
                {
                    var j = J1; var i = NSTOL;
                    if (i == 1) Shortwin_1[j] = 1;
                    if (i == 2) Brat_2[j] = 1;
                    if (i == 3) Anycart_3[j] = 1;
                    if (i == 4) Morecart_4[j] = 1;
                    if (i == 5) Egalitewin_5[j] = 1;
                    if (i == 6) Smert_6[j] = 1;
                    a = 3;
                }
            }
            if (a == 2)
            {
                var v = 0;
                AA = 500;
                if (v == 0 && Smert_6[J1] == -1) { v = 6; Smert_6[J1] = 1; }
                if (v == 0 && Shortwin_1[J1] == -1) { v = 1; Shortwin_1[J1] = 1; }
                if (v == 0 && Egalitewin_5[J1] == -1) { v = 5; Egalitewin_5[J1] = 1; }
                if (v == 0 && Morecart_4[J1] == -1) { v = 4; Morecart_4[J1] = 1; }
                if (v == 0 && Brat_2[J1] == -1) { v = 2; Brat_2[J1] = 1; }
                if (v == 0 && Anycart_3[J1] == -1) { v = 3; Anycart_3[J1] = 1; }
                NSTOL = v; a = 3;

            }
            if (a > 2)
            {
                a += 1;
                var L = Perk[NSTOL].Length;
                var ost = Mathf.RoundToInt(a * L / 250);
                if (ost < L / 2) { Kand[NSTOL].GetComponent<Button>().interactable = true; }
                if (ost > L / 2) { Kand[NSTOL].GetComponent<Button>().interactable = false; }
                if (ost > L) ost = L;
                var txt = "";
                for (int i = 0; i < ost; i++) txt += Perk[NSTOL][i];
                Kand[0].GetComponentInChildren<Text>().text = "Император выбрал перк " + txt;


            }
            if (a > AA) { ETAP = 150; PanelBIG.SetActive(false); }
        }
        if (ETAP == 100) ////
        {

            for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = false;
            a = 0; ETAP = 150;///по умолчанию
            REVERS = false;
            var A = Mathf.RoundToInt(R / 100);
            var B = R - A * 100;



            if (B == 1) ETAP = 101; ///брак
            if (B == 2) ETAP = 102; ///смерть
            if (B == 3) ETAP = 103; ///суд
            if (B == 4) ETAP = 104; ///охота
            if (B == 5) ETAP = 105; ///связи
            if (B == 6) ETAP = 106; ///флирт
            if (B == 7) ETAP = 107; ///война
            if (B == 8) ETAP = 108; ///ересь
            if (B == 9) ETAP = 109; ///обучение
            if (B == 10) ETAP = 110; ///пут-ие
            if (B == 11) ETAP = 111; ///измена
            if (B == 12) ETAP = 112; ///дуэль
            if (B == 13) ETAP = 150; ////монастырь, явных последствий нет 
            if (B == 14) ETAP = 114; ///наследство
            if (B == 15) ETAP = 115; ///болезнь
            if (B == 16) ETAP = 116; ///заговор
            if (B == 17) ETAP = 117; ///оскорбление
            if (B == 18) ETAP = 118; ///турнир
            if (B == 19) ETAP = 119; ///дети
            if (B == 20) ETAP = 120; ///развод
        }
        if (ETAP == 119) ///дети
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/19"); Panel1_Karta2.SetActive(true);
                NOMIG = Next(NSTOL);
                // if (NABOR[NOMIG].Count == 0) { NOMIG = Next(NSTOL); }


                a = 10;
                SF = 0;

            }

            if (a == 10)
            {
                Panel1_Text.GetComponentInChildren<Text>().text = " Все игроки  отдают по 1 карте династии " + Name[Din[NSTOL]] + ". " + Name[Din[NOMIG]] + ", отдайте вашу карту";
                Panel1_Karta2.SetActive(false);
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]); Panel1_Karta.SetActive(true);
                /////////// ShowNabor(NOMIG);
                if (NABOR[NOMIG].Count > 0)
                {
                    Panel1_SPISOK(NABOR[NOMIG]);
                    if (LEFT) GoLeft(NABOR[NOMIG]);
                    SF = Vibor(NABOR[NOMIG], "отдать " + Name[Din[NSTOL]]);
                    ////Если робот
                    if (Status[NOMIG] != 0) { SF = SbrosII(NABOR[NOMIG]); }
                    ///
                    if (SF > 0)
                    {
                        NABOR[NOMIG].Remove(SF); NABOR[NSTOL].Add(SF); a = 11;

                        NOMIG = Next(NOMIG); SF = 0;

                    }
                }
                else { NOMIG = Next(NOMIG); SF = 0; }

                if (NOMIG == NSTOL) { a = AA + 1; }

            }
            if (a >= 11 && a < 50) { a += 1; ShowNabor(0); }//анимация сброса
            if (a == 50) a = 10;

            if (a > AA)
            {

                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 108) ///ересь
        {
            if (a == 0)
            {

                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/8"); Panel1_Karta2.SetActive(true);
                NOMIG = Next(NSTOL);
                // if (NABOR[NOMIG].Count == 0) { NOMIG = Next(NSTOL); }

                ///  Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " все игроки, кроме вас скидывают в сброс по 1 карте";
                a = 10;
                SF = 0;

            }

            if (a == 10)
            {
                Panel1_Text.GetComponentInChildren<Text>().text = " Все игроки кроме " + Name[Din[NSTOL]] + " скидывают в сброс по 1 карте. " + Name[Din[NOMIG]] + ", сбросьте вашу карту";
                Panel1_Karta2.SetActive(false);
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]); Panel1_Karta.SetActive(true);
                /////////// ShowNabor(NOMIG);
                if (NABOR[NOMIG].Count > 0)
                {
                    Panel1_SPISOK(NABOR[NOMIG]);
                    if (LEFT) GoLeft(NABOR[NOMIG]);
                    SF = Vibor(NABOR[NOMIG], "сбросить ересь");
                    ////Если робот
                    if (Status[NOMIG] != 0) { SF = SbrosII(NABOR[NOMIG]); }
                    ///
                    if (SF > 0)
                    {
                        NABOR[NOMIG].Remove(SF); Sbros.Add(SF); a = 11;

                        NOMIG = Next(NOMIG); SF = 0;

                    }
                }
                else { NOMIG = Next(NOMIG); SF = 0; }

                if (NOMIG == NSTOL) { a = AA + 1; }

            }
            if (a >= 11 && a < 50) { a += 1; ShowNabor(0); ShowSbros(); }//анимация сброса
            if (a == 50) a = 10;

            if (a > AA)
            {

                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 111 && Status[NSTOL] != 0)///измена
        {
            if (a == 0)
            {
                AA = 100;

                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/11"); Panel1_Karta2.SetActive(true);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " вы раздаете всем по 1 карте";
                NOMIG = NSTOL;
                SSS = "";
                for (int i = 1; i <= LimitIg; i++)
                    if (NABOR[NSTOL].Count > 0)
                    {
                        NOMIG = Next(NOMIG);
                        SF = NABOR[NSTOL][0]; if (Status[NOMIG] == 0) SF = SbrosII(NABOR[NSTOL]);

                        SSS = SSS + i + ". [" + NOMIG + "] " + SF+", ";

                        NABOR[NSTOL].Remove(SF); NABOR[NOMIG].Add(SF);

                    }
            }
            a += 1; ShowNabor(0);
            if (a > AA) { a = 0; ETAP = 150; }
        }
        if (ETAP == 111 && Status[NSTOL] == 0)///измена
        {
            if (a == 0)
            {

                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/11"); Panel1_Karta2.SetActive(true);
                NOMIG = Next(NSTOL);

                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " вы раздаете всем по 1 карте";
                a = 10;
                SF = 0;
                if (NABOR[NSTOL].Count == 0) { Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + "у вас нет ни одной карты"; a = AA + 1; }
            }

            if (a == 10)
            {
                Panel1_Karta2.SetActive(false);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + ", вы раздаете всем по 1 карте. Карта для " + Name[Din[NOMIG]];
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]);
                ///ShowNabor(NOMIG);
                Panel1_SPISOK(NABOR[NSTOL]);
                if (LEFT) GoLeft(NABOR[NSTOL]);
                SF = Vibor(NABOR[NSTOL], "отдать " + Name[Din[NOMIG]]);
                if (SF > 0)
                {
                    NABOR[NSTOL].Remove(SF); NABOR[NOMIG].Add(SF);

                    NOMIG = Next(NOMIG); SF = 0;
                    a = 11;////для анимации улета отданой карты

                    if (NOMIG == NSTOL || NABOR[NSTOL].Count == 0) { a = AA + 1; }////круг сделан или карты кончились

                }

            }
            if (a >= 11 && a < 50) { a += 1; ShowNabor(HUMAN); }
            if (a == 50) { a = 10; }
            if (a > AA)
            {

                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }

        if (ETAP == 115 && Status[NSTOL] != 0)///болезнь
        {
            Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
            Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/15"); Panel1_Karta2.SetActive(true);
            if (NABOR[NSTOL].Count > 0)
            {
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " сбрасывает 1 карту с руки";
                SF = SbrosII(NABOR[NSTOL]);
                NABOR[NSTOL].Remove(SF); Sbros.Add(SF);
            }
            ETAP = 150;
        }
        if (ETAP == 115 && Status[NSTOL] == 0)///болезнь
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/15"); Panel1_Karta2.SetActive(true);
                NOMIG = NSTOL;

                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " вы сбрасываете 1 карту с руки";
                a = 10;
                SF = 0;
                if (NABOR[NSTOL].Count == 0) { Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + "у вас нет ни одной карты"; a = AA + 1; }
            }

            if (a == 10)
            {
                Panel1_Karta2.SetActive(false);
                Panel1_SPISOK(NABOR[NOMIG]);
                if (LEFT) GoLeft(NABOR[NOMIG]);
                SF = Vibor(NABOR[NOMIG], "сбросить в отбой");
                if (SF > 0) { a = AA + 1; NABOR[NOMIG].Remove(SF); Sbros.Add(SF); }
            }

            if (a > AA)
            {

                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 117 && Status[NSTOL] == 0) ETAP = 150;
        if (ETAP == 117 && Status[NSTOL] != 0) //////оскорбление
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/17"); Panel1_Karta2.SetActive(true);
                NOMIG = NSTOL;

                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " вы показываете всем свои карты";
                a = 10; CLOSE = false;
                SF = 0;
                if (NABOR[NSTOL].Count == 0) { Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + "у вас нет ни одной карты"; a = AA + 1; }
                OpenSpisok(NABOR[NSTOL]);
            }

            if (a == 10)
            {
                Panel1_Karta2.SetActive(false);
                Panel1_SPISOK(NABOR[NOMIG]);
                if (LEFT) GoLeft(NABOR[NOMIG]);
                SF = Vibor(NABOR[NOMIG], "зАКОНЧИТЬ ПРОСМОТР");
                if (SF > 0 || CLOSE) a = AA + 1;
                //if (SF == 0) { REVERS_knopka.transform.localPosition = new Vector3(10, 100, 0); REVERS_knopka.SetActive(true); }
                if (CLOSE == false) Panel1_Button2.SetActive(true); else Panel1.SetActive(false);
            }

            if (a > AA)
            {
                Panel1_Button2.SetActive(false);
                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 109 && Status[NSTOL] != 0) ETAP = 150;
        if (ETAP == 109 && Status[NSTOL] == 0)
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/9"); Panel1_Karta2.SetActive(true);
                NOMIG = 0;
                for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = true;
                for (int i = 1; i <= 6; i++) if (i == NSTOL || NABOR[i].Count == 0) But[i].GetComponent<Button>().interactable = false;
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " нажмите внизу на кнопку игрока, у которого вы хотите посмотреть карты";
                a = 1;
                SF = 0; CLOSE = false;
            }
            if (a == 1)
            {
                SF = 0;
                if (NOMIG != 0)
                { a = 10; for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = false;
                    OpenSpisok(NABOR[NOMIG]);
                }
            }
            if (a == 10)
            {
                Panel1_Karta2.SetActive(false);
                Panel1_SPISOK(NABOR[NOMIG]);
                if (LEFT) GoLeft(NABOR[NOMIG]);
                SF = Vibor(NABOR[NOMIG], "зАКОНЧИТЬ ПРОСМОТР");
                if (SF > 0 || CLOSE) a = AA + 1;
                if (CLOSE == false) Panel1_Button2.SetActive(true); else Panel1.SetActive(false);
            }

            if (a > AA)
            {
                Panel1_Button2.SetActive(false);
                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 120)///развод
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/20"); Panel1_Karta2.SetActive(true);
                NOMIG = 0;
                for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = true;
                for (int i = 1; i <= 6; i++) if (i == NSTOL) But[i].GetComponent<Button>().interactable = false;
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " нажмите внизу на кнопку игрока, которому вы отдадите 1 свою карту";
                a = 1;
                if (NABOR[NSTOL].Count == 0)
                {
                    Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " у вас нет карт, чтоб отдать";
                    a = AA + 1;
                }
            }
            if (a == 1)
            {    ////если робот
                if (Status[NSTOL] != 0) { NOMIG = MINnabor(NSTOL); }
                ///
                if (NOMIG != 0)
                {
                    for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = false;
                    a = 10;
                }
            }
            if (a == 10)
            {
                Panel1_Text.GetComponentInChildren<Text>().text = "Выберите карту для отдачи " + Name[Din[NOMIG]];
                Panel1_Karta2.SetActive(false);
                Panel1_SPISOK(NABOR[NSTOL]);
                if (LEFT) GoLeft(NABOR[NSTOL]);
                SF = Vibor(NABOR[NSTOL], "отдать " + Name[Din[NOMIG]]);
                ////если робот
                if (Status[NSTOL] != 0) { SF = SbrosII(NABOR[NSTOL]); }
                ///
                if (SF > 0)
                {
                    a = 11;
                    NABOR[NSTOL].Remove(SF);
                    NABOR[NOMIG].Add(SF);
                }
            }
            if (a > 10) { a += 1; ShowNabor(0); }
            if (a > AA)
            {
                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 112)
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/12"); Panel1_Karta2.SetActive(true);
                NOMIG = 0;
                for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = true;
                for (int i = 1; i <= 6; i++) if (i == NSTOL || NABOR[i].Count == 0) But[i].GetComponent<Button>().interactable = false;
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " нажмите внизу на кнопку игрока, с которым вы хотите втемную поменяться";
                a = 1;
                if (NABOR[NSTOL].Count == 0)
                {

                    Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " у вас нет карт, чтоб меняться";
                    a = 2;
                }
            }
            if (a == 1)
            {
                ////если робот
                if (Status[NSTOL] != 0) { NOMIG = MINnabor1(NSTOL); }
                ///
                if (NOMIG != 0)
                {
                    for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = false;
                    Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]);
                    S = UnityEngine.Random.Range(0, NABOR[NOMIG].Count); if (S < 0) S = 0; if (S > NABOR[NOMIG].Count - 1) S = NABOR[NOMIG].Count - 1;
                    var r1 = NABOR[NOMIG][S];
                    S = UnityEngine.Random.Range(0, NABOR[NSTOL].Count); if (S < 0) S = 0; if (S > NABOR[NSTOL].Count - 1) S = NABOR[NSTOL].Count - 1;
                    var r2 = NABOR[NSTOL][S]; S1 = S1 + "r1=" + r1 + ", r2=" + r2;
                    NABOR[NOMIG].Remove(r1); NABOR[NSTOL].Remove(r2);
                    NABOR[NOMIG].Add(r2); NABOR[NSTOL].Add(r1);
                    a = 2;
                }
            }
            if (a > 1)
            {
                Panel1_Karta2.SetActive(false);
                a += 1; ShowNabor(HUMAN); ShowPanelIg(HUMAN);
            }
            if (a > AA)
            {
                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 101)
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/1"); Panel1_Karta2.SetActive(true);
                NOMIG = 0;
                for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = true;
                for (int i = 1; i <= 6; i++) if (i == NSTOL || NABOR[i].Count == 0) But[i].GetComponent<Button>().interactable = false;
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " нажмите внизу на кнопку игрока, у которого вы хотите забрать карту";
                a = 1;

            }
            if (a == 1)
            {
                ////если робот
                if (Status[NSTOL] != 0) { NOMIG = MAXnabor(NSTOL); }
                ///
                if (NOMIG != 0)
                {
                    for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = false;
                    Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + ", возьмите карту у " + Name[Din[NOMIG]];
                    Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]);
                    a = 10;
                    if (Status[NOMIG] == 0)
                        Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " берет карту у вас, " + Name[Din[NOMIG]];

                    if (Status[NSTOL] == 0) OpenSpisok(NABOR[NOMIG]); 
                }

            }
            if (a == 10)
            {
                Panel1_Karta2.SetActive(false);
                Panel1_SPISOK(NABOR[NOMIG]);
                if (LEFT) GoLeft(NABOR[NOMIG]);
                SF = Vibor(NABOR[NOMIG], "взять карту");
                ////если робот
                if (Status[NSTOL] != 0) { SF = ZahvatII(NABOR[NOMIG]); }
                ///

                if (SF > 0) { a = 11; NABOR[NOMIG].Remove(SF); NABOR[NSTOL].Add(SF); }
            }
            if (a > 10) { a += 1; ShowNabor(HUMAN); }

            if (a > AA)
            {
                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }
        if (ETAP == 118)
        {
            if (a == 0)
            {
                AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/18"); Panel1_Karta2.SetActive(true);
                NOMIG = 0;
                for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = true;
                for (int i = 1; i <= 6; i++) if (i == NSTOL || NABOR[i].Count == 0) But[i].GetComponent<Button>().interactable = false;
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " нажмите внизу на кнопку игрока, с которым вы хотите поменяться картами";
                a = 1;


				if (NABOR[NSTOL].Count == 0)
				{

					Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " у вас нет карт, чтоб меняться";
					ETAP = 150;a = 51;AA = 200;
				}
            }
            if (a == 1)
            {////если робот
                if (Status[NSTOL] != 0)
                {
                    NOMIG = MAXnabor(NSTOL); if (NABOR[HUMAN].Count>0) NOMIG = HUMAN;
                }
                ///
                if (NOMIG != 0)
                {
                    for (int i = 1; i <= 6; i++) But[i].GetComponent<Button>().interactable = false;
                    Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]);
                    a = 10; b = 0;
                    if (Status[NSTOL] == 0) OpenSpisok(NABOR[NOMIG]);
                    if (Status[NOMIG] == 0) OpenSpisok(NABOR[NSTOL]);
                }
            }
            if (a == 10)
            {
                if (Status[NSTOL] == 0)  Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + ", возьмите карту у династии " + Name[Din[NOMIG]];
                if (Status[NOMIG] == 0) Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " БЕРЕТ КАРТУ У ВАС, " + Name[Din[NOMIG]];
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NOMIG]);
                Panel1_Karta2.SetActive(false);
                Panel1_SPISOK(NABOR[NOMIG]);
                if (LEFT) GoLeft(NABOR[NOMIG]);
                SF = Vibor(NABOR[NOMIG], "взять карту у " + Name[Din[NOMIG]]);

                ////если робот
                if (Status[NSTOL] != 0) { SF = ZahvatII(NABOR[NOMIG]); }
                ///

                if (SF > 0)
                {
                    a = 11; NABOR[NOMIG].Remove(SF); ;
                    if (b == 0) J1 = SF;
                }
            }
            if (a >= 11 && a < 50) { a += 1; ShowNabor(0); Kart(80 + b * 160, 1400, 0, KartToNum(SF)); }
            if (a == 50)
            {
                b += 1;
                if (b == 1) { BB = NSTOL; NSTOL = NOMIG; NOMIG = BB; a = 10; }
				if (b > 1) 
				{
					a = AA + 1;
					BB = NSTOL; NSTOL = NOMIG; NOMIG = BB;
					NABOR[NSTOL].Add(J1);
					NABOR[NOMIG].Add(SF);
				}
            }
			if (a > 50)	a += 1;
            if (a > AA)
            {
                
                ETAP = 150; a = 0; LEFT = false; REVERS = false;
            }
        }

        if (ETAP == 102) ////смерть 
        {
            if (a == 0)
            {
                 Smert(NSTOL); 
                SMERT = false;

                a = 1; AA = 80; TEXT1 = TEXT1 + "   СМЕРТЬ";
            }
            if (a > 0) { a += 1; ShowStol(); ShowSbros(); }
            if (a > AA) { a = 0; ETAP = 150; }
        }
        
        if (ETAP == 105)  ///связи
        {
            if (a == 0)
            {
                b = 0;
                NOMOVE = false;
                AA = 50;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/5"); Panel1_Karta2.SetActive(true);
                NABOR[0].Clear();
                Brat(0, 3); a = 10; SF = 0; REVERS = false;
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + ", заберите одну из 3 карт";
                TEXT1 = "105: " + NABOR[0].Count;
                if (NABOR[0].Count > 0) for (int i = 0; i < NABOR[0].Count; i++) { TEXT1 += "/" + i + "=" + NABOR[0][i]; };
                if (Status[NSTOL] == 0) OpenSpisok(NABOR[0]); else CloseSpisok(NABOR[0]);
            }

            if (a == 10)
            {
                ///если робот
                b += 1;
                if (Status[NSTOL] != 0 && NOMOVE && b>100) SF = ZahvatII(NABOR[0]);
                ///
                
                Panel1_Karta2.SetActive(false);
                if (SF == 0) Panel1_SPISOK(NABOR[0]);
                if (SF == 0 && Status[NSTOL]==0) SF = Vibor(NABOR[0], "забрать");
                if (SF > 0)
                {
                    NABOR[NSTOL].Add(SF); NABOR[0].Remove(SF);
                    if (NABOR[0].Count > 0) { var r = NABOR[0][0]; Sbros.Add(r); NABOR[0].Remove(r); }
                    if (NABOR[0].Count > 0) { var r = NABOR[0][0]; Sbros.Add(r); NABOR[0].Remove(r); }

                    NABOR[0].Clear();
                    SF = -1; AA = 100; a = 11;
                    TEXT1 += "/SF=" + SF;
                };
                //if (SF == -1) { ShowPanelIg(HUMAN); ShowNabor(HUMAN); ShowSbros(); a = a + 1; REVERS = false; };
            }
            if (a > 10) { a += 1; ShowPanelIg(HUMAN); ShowNabor(HUMAN);  REVERS = false; }
            if (a > 40) { a += 1; ShowPanelIg(HUMAN); ShowSbros(); REVERS = false; }
            if (a > AA)
            {

                ETAP = 100; a = 1;
                if (SF == -1)
                {

                    ETAP = 150;
                }
            }
        }
        if (ETAP == 106) ////flirt 
        {
            if (a == 0) { Dophod[NSTOL] += 1; a = 1; AA = 30; TEXT1 = TEXT1 + "   Флирт+1 ход"; }
            if (a > 0) { a += 1; ShowStol(); ShowSbros(); }
            if (a > AA) { a = 0; ETAP = 150; }
        }
        if (ETAP == 110) ////путешествие 
        {
            if (a == 0) { Dophod[NSTOL] -= 1; a = 1; AA = 100; TEXT1 = TEXT1 + "  путеш-ие -1 ход"; }
            if (a > 0) { a += 1; ShowStol(); ShowSbros(); }
            if (a > AA) { a = 0; ETAP = 150; }
        }
        if (ETAP == 107) ///война
        {
            if (a == 0) { War(NSTOL); a = 1; AA = 200; TEXT1 = TEXT1 + "   война"; }
            if (a > 0) { a += 1; ShowStol(); ShowSbros(); }
            if (a > AA) { a = 0; ETAP = 150; }
        }
        if (ETAP == 116) ///заговор
        {
            if (a == 0)
            {
                zagovor(NSTOL); a = 1; AA = 200; TEXT1 = TEXT1 + "   заговор";
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/16"); Panel1_Karta2.SetActive(true);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " меняет все карты с руки, но не более 5";
            }
            if (a > 0) { a += 1; ShowSbros(); if (NSTOL == Ig) ShowPanelIg(NSTOL); }

            if (a > AA)
            {
                Panel1.SetActive(false); Panel1_Karta2.SetActive(false);
                a = 0; ETAP = 150;
            }
        }
        if (ETAP == 114) ///наследство
        {
            if (a == 0)
            {
                Brat(NSTOL, 2); a = 1; AA = 200; TEXT1 = TEXT1 + "   НАСЛЕДСТВО";
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/14"); Panel1_Karta2.SetActive(true);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " берет 2 карты из колоды";
            }
            if (a > 0) { a += 1; ShowSbros(); if (NSTOL == Ig) ShowPanelIg(NSTOL); }
            if (a > AA)
            {
                Panel1.SetActive(false); Panel1_Karta2.SetActive(false);
                a = 0; ETAP = 150;
            }
        }
        if (ETAP == 103) ///суд
        {
            if (a == 0)
            {
                AA = 200; SF = 0;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/3"); Panel1_Karta2.SetActive(true);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " уберите любую последнюю карту на столе";
                var s = 0; for (int i = 1; i <= LimitIg; i++) if (Stol[i].Count > 1) s += 1;
                if (s < 2) { Panel1_Text.GetComponentInChildren<Text>().text = " На столе нет карт, которых можно было убрать"; a = 2; }
                else { a = 1; SF = 0; REVERS = false; }
            }
            if (a == 1 && Status[NSTOL] == 0) ////ожидание
            {
                if (Past > 0 && Past != KartToNum(R)) for (int i = 1; i <= 6; i++) if (Stol[i].Count >= 2)
                            if (KartToNum(Stol[i][Stol[i].Count - 1]) == Past)
                            {
                                REVERS_knopka.SetActive(true); REVERS_knopka.GetComponentInChildren<Text>().text = "СБРОСИТЬ";
                                var X = AAA[Past].transform.localPosition.x;
                                var Y = AAA[Past].transform.localPosition.y;
                                REVERS_knopka.transform.localPosition = new Vector3(X, Y, 0); REVERS_knopka.transform.SetAsLastSibling();
                                
                            }
                if (REVERS) for (int i = 1; i <= 6; i++) if (Stol[i].Count >= 2) ////for (int j = 1; j < Stol[i].Count; j++)
                            if (KartToNum(Stol[i][Stol[i].Count - 1]) == Past)
                            {
                                var r = Stol[i][Stol[i].Count - 1]; Stol[i].Remove(r); Sbros.Add(r); SF = r;
                                REVERS = false; REVERS_knopka.SetActive(false);
                                a = 2;
                            }
                b += 1; if (b > 100) b = 0;
                for (int i = 1; i <= 6; i++) if (Stol[i].Count >= 2 && KartToNum(R) != KartToNum(Stol[i][Stol[i].Count - 1]))
                    {
                        var n = KartToNum(Stol[i][Stol[i].Count - 1]);
                        var kf = 255 - b * 8; if (kf < 0) kf = 255;
                        if (Past != 0) kf = 255;
                            AAA[n].GetComponent<Image>().color = new Color32(255, 255, 255, Convert.ToByte(kf));
                        
                    }

            }
            if (a == 1 && Status[NSTOL] != 0) ////если робот
            {
                var n = 0; var A = 0; var B = 0; var h = 0; var sum = 0;
                MAX = -9999;
                for (int i = 1; i <= LimitIg; i++) if (Stol[i].Count > 1 && KartToNum(R) != KartToNum(Stol[i][Stol[i].Count - 1]))
                    {
                        h = Stol[i].Count - 1;
                        n = Stol[i][h]; A = Mathf.RoundToInt(n / 100); B = n - A * 100;
                        sum = h * 100 + Cena(n);
                        if (B == 13 && n > 100) sum -= 500;
                        if (n < 100) sum += 500;

                        if (MAX < sum) { MAX = sum; SF = n; NOMIG = i; }
                    }///////////*/
                Stol[NOMIG].Remove(SF); Sbros.Add(SF);////сброс в отбой
                a = 2;
            }
            if (a > 1)
            {
                a += 1; ShowSbros();
               if (SF!=0) Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " удаляет карту " + SF + " на столе " + Name[Din[NOMIG]];
            }


            if (a > AA)
            {
                Panel1.SetActive(false); Panel1_Karta2.SetActive(false);
                a = 0; ETAP = 150;
            }
        }
        if (ETAP == 104) ///охота
        {
            if (a == 0)
            {
                AA = 200; SF = 0; b = 0;BB = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[NSTOL]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/4"); Panel1_Karta2.SetActive(true);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " заберите себе любую последнюю карту на столе";
                var s = 0; for (int i = 1; i <= LimitIg; i++) if (Stol[i].Count > 1) s += 1;
                if (s < 2) { Panel1_Text.GetComponentInChildren<Text>().text = " На столе нет карт, которых можно было забрать"; a = 2; }
                else { a = 1; SF = 0; REVERS = false; }
            }
            if (a == 1 && Status[NSTOL] == 0) ////ожидание
            {
                if (Past > 0 && Past != KartToNum(R)) for (int i = 1; i <= 6; i++) if (Stol[i].Count >= 2)
                            if (KartToNum(Stol[i][Stol[i].Count - 1]) == Past)
                            {
                                REVERS_knopka.SetActive(true); REVERS_knopka.GetComponentInChildren<Text>().text = "забрать";
                                var X = AAA[Past].transform.localPosition.x;
                                var Y = AAA[Past].transform.localPosition.y;
                                REVERS_knopka.transform.localPosition = new Vector3(X, Y, 0); REVERS_knopka.transform.SetAsLastSibling();
                                
                            }
                if (REVERS) for (int i = 1; i <= 6; i++) if (Stol[i].Count >= 2) ////for (int j = 1; j < Stol[i].Count; j++)
                            if (KartToNum(Stol[i][Stol[i].Count - 1]) == Past)
                            {
                                var r = Stol[i][Stol[i].Count - 1]; Stol[i].Remove(r); NABOR[NSTOL].Add(r); SF = r;
                                REVERS = false; REVERS_knopka.SetActive(false);
                                a = 20;
                            }
                ///// ShowPanelIg(NSTOL); ShowNabor(NSTOL);
                b += 1; if (b > 100) b = 0;
                for (int i = 1; i <= 6; i++) if (Stol[i].Count >= 2 && KartToNum(R) != KartToNum(Stol[i][Stol[i].Count - 1]))
                    {
                        var n = KartToNum(Stol[i][Stol[i].Count - 1]);
                        var kf = 255 - b * 8; if (kf < 0) kf = 255;
                        if (Past != 0) kf = 255;
                        AAA[n].GetComponent<Image>().color = new Color32(255, 255, 255, Convert.ToByte(kf));

                    }

            }
            if (a == 1 && Status[NSTOL] != 0) ////если робот
            {
                
                var n = 0; var A = 0; var B = 0; var h = 0;var sum = 0;
                MAX = -9999;
                for (int i = 1; i <= LimitIg; i++) if (Stol[i].Count > 1 && KartToNum(R) != KartToNum(Stol[i][Stol[i].Count - 1]))
                    {
                        h = Stol[i].Count - 1;
                        n = Stol[i][h];  A = Mathf.RoundToInt(n / 100); B = n - A * 100;
                        sum = h * 100 + Cena(n);
                        if (B == 13 && n>100) sum -= 500;
                        if (n < 100) sum += 500;

                        if (MAX<sum) { MAX = sum;SF = n; NOMIG = i; }
                    }///////////*/


                        Stol[NOMIG].Remove(SF); NABOR[NSTOL].Add(SF);////присвоение карты
                 
                a = 2;
            }
            if (a > 1)
            {
                a += 1; ShowNabor(0);
                if (SF != 0) Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[NSTOL]] + " забирает себе карту " + SF + " на столе " + Name[Din[NOMIG]];
            }
            if (a > AA)
            {
                Panel1.SetActive(false); Panel1_Karta2.SetActive(false);
                a = 0; ETAP = 150;
            }
        }
        if (ETAP == 150)
        {

            a += 1; AA = 50;
            Panel0.SetActive(false);
            Panel1.SetActive(false);
            PanelBIG.SetActive(false);

            ShowSbros(); ShowNabor(0);
            if (a > AA)
            {
                a = 0;
                for (int i = 1; i <= 6; i++)
                {
                    if (Dophod[i] < 0) DOP[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop1");
                    if (Dophod[i] > 0) DOP[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop2");
                    if (Dophod[i] == 0) DOP[i].SetActive(false); else DOP[i].SetActive(true);
                    if (Dophod[i] == 0 && favorit() == i)
                    { DOP[i].SetActive(true); DOP[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("dop0"); }
                }



                if (Dophod[Ig] > 0) { ETAP = 151; a = 0; };///повтор хода
                if (Dophod[Ig] <= 0) { ETAP = 152; a = 0; } ///переход хода
                History();
            }

        }
        if (ETAP == 151)///повтор хода
        {
            if (a == 0)
            {
                Dophod[Ig] -= 1; AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[Ig]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/6"); Panel1_Karta2.SetActive(true);
                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[Ig]] + " получает дополнительный ход";
            }
            a += 1; ShowSbros();
            if (a > AA)
            {
                Panel1.SetActive(false); Panel1_Karta2.SetActive(false);
                ETAP = 200; a = 0;
            }

        }
        if (ETAP == 152)///переход хода
        {
            Ig = Next(Ig);////передача хода
            if (Dophod[Ig] >= 0) { ETAP = 200; a = 0; AA = 100; }; ///в начало
            if (Dophod[Ig] < 0) { ETAP = 153; a = 0; AA = 100; }; ///пропуск
        }
        if (ETAP == 153)///пропуск хода
        {
            if (a == 0)
            {
                Dophod[Ig] += 1; AA = 100;
                Panel1.SetActive(true); Panel1.transform.SetAsLastSibling();
                Panel1_Karta.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties/" + Din[Ig]); Panel1_Karta.SetActive(true);
                Panel1_Karta2.GetComponent<Image>().sprite = Resources.Load<Sprite>("20/10"); Panel1_Karta2.SetActive(true);

                Panel1_Text.GetComponentInChildren<Text>().text = Name[Din[Ig]] + " пропускает ход";
            }
            a += 1; ShowSbros();
            if (a > AA)
            {
                Panel1.SetActive(false); Panel1_Karta2.SetActive(false);
                Ig = Next(Ig);////передача хода
                if (Dophod[Ig] >= 0) { ETAP = 200; a = 0; AA = 100; }; ///в начало
                if (Dophod[Ig] < 0) { Dophod[Ig] -= 1; ETAP = 153; a = 0; AA = 100; }; ///пропуск
            }

        }
        if (ETAP == 200) ///проверка конца игры
        {
            WIN = 0; for (int i = 1; i <= 6; i++) ///не достиг ли 10
            {
                LIM = LimitWin;
                if (Shortwin_1[i] > 0) LIM -= 1;
                if (Stol[i].Count - 1 >= LIM) WIN = i;
            }
            if (WIN > 0) { ETAP = 250; a = 0; } else ETAP = 210;
        }
        if (ETAP == 210) ///проверка конца игры при рыбе
        {

            if (favorit() > 0 && GAMEOVER < 7) WIN = 0;
            if (favorit() > 0 && GAMEOVER >= 7) WIN = favorit();
            if (favorit() == 0 && GAMEOVER >= 12) WIN = -1;

            if (WIN == 0) { ETAP = 50; a = 0; } else ETAP = 250;
        }
        if (ETAP == 250)
		{   
			if (a == 0) 
			{

				for (int i = 1; i <= 6; i++)
					Kand [i].GetComponent<Button> ().interactable = true;
				var txt = "";
				PanelBIG.SetActive (true);
				PanelBIG.transform.SetAsLastSibling ();
				PanelBIG.transform.position = new Vector3 (500, 400, 0);
				if (GAMEOVER >= 7)
					Kand [0].GetComponentInChildren<Text> ().text = "ИГРА ОКОНЧЕНА ДОСРОЧНО";
				else
					Kand [0].GetComponentInChildren<Text> ().text = "ИГРА ОКОНЧЕНА";
				if (WIN > 0)
					txt = txt + "\r\n" + "ПОБЕДИЛИ " + Name [Din [WIN]];
				if (WIN == -1)
					txt = txt + "\r\n" + "НИЧЬЯ ";
				TextV.GetComponentInChildren<Text> ().text = txt;
				if (WIN > 0)
					Kand [0].GetComponent<Image> ().sprite = Resources.Load<Sprite> ("dynasties/" + Din [WIN].ToString ());
				if (WIN == -1)
					Kand [0].GetComponent<Image> ().sprite = Resources.Load<Sprite> ("super/80");
				for (int j = 1; j <= LimitIg; j++)
					Kand [j].GetComponentInChildren<Text> ().text = "нет";

				for (int i = 1; i <= LimitIg; i++) 
				{
					var j = Din [i];
					var k = Stol [i].Count - 1;
					if (k > 0)
						Kand [j].GetComponentInChildren<Text> ().text = k + " карт.";
					if (k == 1 || k == 21 || k == 31)
						Kand [j].GetComponentInChildren<Text> ().text = k + " картa.";
					if (k > 1 && k < 5)
						Kand [j].GetComponentInChildren<Text> ().text = k + " карты.";
					if (k > 21 && k < 25)
						Kand [j].GetComponentInChildren<Text> ().text = k + " карты.";
				}
			}
			a += 1;
			if (a > 300) {		PanelBIG.SetActive (false);	}
			if (a > 1000) 	a = 0;
        }
    }
    public int Cena(int k)
    {
        var v = 0; var A = 0; var B = 0;
        if (k > 100)
        {
            A = Mathf.RoundToInt(k / 100); B = k - A * 100;
            if (A == 2 || A == 13 || A == 7 || A == 6 || A == 3 || A == 4 || A == 19) v += 7;
            if (A == 1 || A == 5 || A == 12 || A == 14 || A == 18 || A == 20) v += 5;
            if (A == 8 || A == 9 || A == 10 || A == 11 || A == 15 || A == 16 || A == 17 ) v += 1;
            if (B == 2 || B == 13 || B == 7 || B == 6 || B == 3 || B == 4 || B == 19) v += 7;
            if (B == 1 || B == 5 || B == 12 || B == 14 || B == 18 || B == 20) v += 5;
            if (B == 8 || B == 9 || B == 10 || B == 11 || B == 15 || B == 16 || B == 17) v += 1;
        }
        
        if (k >= 71 && k <= 76) v = k;
        if (k == 84) v = 50;
        if (k == 77 || k == 78) v = 51;
        if (k == 79 && Sbros.Count == 0) v = 1;
        if (k == 79 && Sbros.Count > 0) v = 52;
        if (k >= 80 && k <= 82) v = 53;
        if (k == 83) v = 60;
        return v;
    }
    public int SbrosII(List<int> SPISOK)
    {
        var v = 0;
        var MIN = 999; if (SPISOK.Count > 0) for (int i = 0; i < SPISOK.Count; i++)
            {
                if (Cena(SPISOK[i]) < MIN) { v = SPISOK[i]; MIN = Cena(SPISOK[i]); }
            }
        return v;
    }
    public int ZahvatII(List<int> SPISOK)
    {
        var v = 0;
        MAX = -999; if (SPISOK.Count > 0) for (int i = 0; i < SPISOK.Count; i++)
            {
                if (Cena(SPISOK[i]) > MAX) { v = SPISOK[i]; MAX = Cena(SPISOK[i]); }
            }
        return v;
    }
    public int MAXnabor(int ig)////у кого максимум карт на руках у соперников
    {
        var v = 0;
        MAX = -999; for (int i = 1; i <= LimitIg; i++)
            if (i != ig)
            {
                if (NABOR[i].Count > MAX) { v = i; MAX = NABOR[i].Count; }
            }
        return v;
    }
    public int MINnabor(int ig)////у кого минимум карт на руках у соперников 
    {
        var v = 0;
        MIN = 999; for (int i = 1; i <= LimitIg; i++)
            if (i != ig)
            {
                if (NABOR[i].Count < MIN) { v = i; MIN = NABOR[i].Count; }
            }
        return v;
    }
    public int MINnabor1(int ig)////у кого минимум карт на руках у соперников но не нуль
    {
        var v = 0;
        MIN = 999; for (int i = 1; i <= LimitIg; i++)
            if (i != ig)
            {
                if (NABOR[i].Count < MIN && NABOR[i].Count > 0) { v = i; MIN = NABOR[i].Count; }
            }
        return v;
    }
    public int ViborYesNo(int ig, string txt)
    {
        var v = 0;
        Panel0_Button1.SetActive(true); Panel0_Button2.SetActive(true);
        Panel0_Text.GetComponentInChildren<Text>().text = txt;
        if (YES) v = 1;
        if (NO) v = -1;
        if (v != 0) { Panel0_Button1.SetActive(false); Panel0_Button2.SetActive(false); YES = false; NO = false; }
        return v;
    }
    public int Vibor(List<int> SPISOK, string txt)
    {
        var v = 0;
        /* if (LEFT) SPISOK = GoLeft(SPISOK);
         if (RIGHT) SPISOK = GoRight(SPISOK);*/
        if (Past != 0)
            for (int i = 0; i < SPISOK.Count; i++) if (Past == KartToNum(SPISOK[i]))
                {
                    REVERS_knopka.SetActive(true); REVERS_knopka.GetComponentInChildren<Text>().text = txt;
                    var X = AAA[Past].transform.localPosition.x;
                    var Y = AAA[Past].transform.localPosition.y;
                    REVERS_knopka.transform.localPosition = new Vector3(X, Y, 0);
                    REVERS_knopka.transform.SetAsLastSibling(); ///Debug.Log("REVERS=" + Dynasty.REVERS);
                    if (REVERS) { REVERS_knopka.SetActive(false); v = SPISOK[i]; }
                }
        return v;
    }

    public List<int> GoLeft(List<int> SPISOK)
    {
        var r = 0;
        if (SPISOK.Count > 1) { r = SPISOK[0]; SPISOK.Remove(r); SPISOK.Add(r); LEFT = false; }
        return SPISOK;
    }
    public List<int> GoRight(List<int> SPISOK)
    {
        var r = 0;
        if (SPISOK.Count > 1) for (int i = 1; i < SPISOK.Count; i++) { r = SPISOK[0]; SPISOK.Remove(r); SPISOK.Add(r); RIGHT = false; };
        return SPISOK;
    }
    void Panel1_SPISOK(List<int> SPISOK)
    {
        var dx = 110; var x = 0; var y = 0;
        if (SPISOK.Count == 4) dx = 120;
        if (SPISOK.Count <= 3) dx = 150;
        var x0 = Mathf.CeilToInt(Panel1_Karta.transform.position.x);
        var y0 = Mathf.CeilToInt(Panel1_Karta.transform.position.y) - 10;
        if (SPISOK.Count >= 1) for (int i = 0; i < SPISOK.Count; i++) //if (Sbros[i]!=77)
            {
                var k = 5;
                if (i < k) { x = x0 + dx * (i + 1); y = y0; };
                if (i >= k) { x = x0 + dx * k + i / 1; y = y0 + i / 1; };

                var n = KartToNum(SPISOK[i]);
                if (OTKR[n]) GetSprite(n);
                Kart(x, y, 0, SPISOK[i]);

            };
    }
    void Brat(int Igrok, int kolvo)
    {
        for (int i = 1; i <= kolvo; i++)
        {
            if (MyList.Count == 0) Obnovit();
            if (MyList.Count > 0)
            {
                var R = MyList[MyList.Count - 1]; MyList.Remove(R); NABOR[Igrok].Add(R);
            }
        }
       /// if (Igrok != 0) if (Status[Igrok] == 0 ) OpenSpisok(NABOR[Igrok]);
    }
    void Obnovit()
    {
        for (int i = 0; i < Sbros.Count; i++) { MyList.Add(Sbros[i]); }; Sbros.Clear();
        MIX();
    }
    void MIX()
    {
        for (int k = 1; k <= 3; k++)
            for (int i = 0; i < MyList.Count; i++)
            {
                var S = UnityEngine.Random.Range(0, MyList.Count - 1); if (S < 0 || S > MyList.Count - 1) S = 0;
                var R = MyList[S];
                MyList.Remove(R);
                S = UnityEngine.Random.Range(0, 4); if (S > 0 || S < 4) R = Revers(R);
                MyList.Add(R);
                ////TEXT1 += ".";
            }
    }
    void ShowSbros()
    {
        Past = 0;
        if (MyList.Count > 0) for (int i = MyList.Count - 1; i >= 0; i--)
            {
                var x = Mathf.CeilToInt(Panel.transform.position.x + i / 10) - 50;
                var y = Mathf.CeilToInt(750 + i / 10);
                GetSprite(-MyList[i]);
                Kart(x, y, 0, MyList[i]);
            };

        if (Sbros.Count > 0) for (int i = Sbros.Count - 1; i >= 0; i--)
            {
                var x = Mathf.CeilToInt(Panel.transform.position.x + i / 20);
                var y = Mathf.CeilToInt(750 + i / 20);
                if (Past == KartToNum(Sbros[i])) Past = 0;
               ///GetSprite(-Sbros[i]);
                Kart(x, y, 0, Sbros[i]);
            };

    }
    void ShowNabor(int h) ///h-  не казать 
    {
        Past = 0;
        NOMOVE = true;
        for (int i = 1; i <= 6; i++)
        {
            if (Status[i] != 0 && h != i)
            {
                if (NABOR[i].Count > 0)
                    for (int j = 0; j < NABOR[i].Count; j++)
                    {
                        var kf = 18 * 5 / NABOR[i].Count;
                        var x = Mathf.RoundToInt(But[i].transform.localPosition.x) + (i - 1) * 27 + 400 + j * kf;
                        var y = 740;
                        GetSprite(-NABOR[i][j]);
                        Kart(x, y, 0, NABOR[i][j]);
                    }
            }
            if (Status[i] == 0 && h != i) ShowPanelIg(i);
        }


    }
    void ShowPanelIg(int h)
    {
        var n = NABOR[h].Count;
        Dom.GetComponent<Image>().sprite = Resources.Load<Sprite>("dynasties2/" + (Din[h]).ToString());
        if (Smert_6[h] > 0) Smert_knopka.SetActive(true); else Smert_knopka.SetActive(false);
        if (n > 0 && Status[h] == 0)
        {  ////////b = Mathf.CeilToInt(Mathf.Repeat(n-1, 3));
           ////////////if (b > BB) b = 0;
           ////  var k = 0;
            for (int j = 0; j < n; j++)
            {

                var dy = 165; var x = 0; var y = 0;
                var ost = Mathf.CeilToInt(UnityEngine.Mathf.Repeat(j, 3)); ///остаток от деления на 3
                x = 833 + Mathf.CeilToInt(j / 3) * 110; y = Mathf.CeilToInt(Panel.transform.position.y) - ost * dy + dy;
                var KartN = KartToNum(NABOR[h][j]);
                if (KartN == Past && REVERS) { Kart(x, y, 180 - 180 * a / AA, NABOR[h][j]); } else Kart(x, y, 0, NABOR[h][j]);
               // GetSprite(NABOR[h][j]);
                var nn = KartToNum(NABOR[h][j]);
                /////  k = k + 1; if (k > n - 1) k = 0;
            }
            for (int j = 0; j < n; j++) if (KartToNum(NABOR[h][j]) == Past) AAA[KartToNum(NABOR[h][j])].transform.SetAsLastSibling();
        }
        if (a <= 1) OpenSpisok(NABOR[h]);
    }
    void ShowStol()
    {
        for (int i = 1; i <= 10; i++) { STOL1[i] = 0; };
        for (int i = 1; i <= 10; i++) { STOL2[i] = 0; };
        for (int i = 1; i <= 10; i++) { STOL3[i] = 0; };
        for (int i = 1; i <= 10; i++) { STOL4[i] = 0; };
        for (int i = 1; i <= 10; i++) { STOL5[i] = 0; };
        for (int i = 1; i <= 10; i++) { STOL6[i] = 0; };

        for (int i = 1; i <= Stol[1].Count; i++) { STOL1[i] = Stol[1][i - 1]; };
        for (int i = 1; i <= Stol[2].Count; i++) { STOL2[i] = Stol[2][i - 1]; };
        for (int i = 1; i <= Stol[3].Count; i++) { STOL3[i] = Stol[3][i - 1]; };
        for (int i = 1; i <= Stol[4].Count; i++) { STOL4[i] = Stol[4][i - 1]; };
        for (int i = 1; i <= Stol[5].Count; i++) { STOL5[i] = Stol[5][i - 1]; };
        for (int i = 1; i <= Stol[6].Count; i++) { STOL6[i] = Stol[6][i - 1]; };



        MAX = 0; for (int i = 1; i <= 6; i++) if (Stol[i].Count > MAX) { MAX = Stol[i].Count; };
        //if (MAX)

        if (MAX > 0)
            for (int i = 1; i <= 6; i++)
                if (Stol[i].Count > 0)
                    for (int j = 0; j < Stol[i].Count; j++)
                    {
                        FFF = 1f - 0.1f * (MAX - 1f);
                        /// if (MAX > 0 ) But[i].transform.localScale = new Vector3(1f, FFF, 0.0f);

                        var x = 0;
                        x = Mathf.RoundToInt(But[i].transform.position.x);//// +(i-1)*27 ;
                        var y = 0;

                        var h = But[i].GetComponent<Transform>().localScale.y * 140;
                        ///var y0 = Mathf.RoundToInt(h + 2*But[i].GetComponent<Transform>().position.y)+40;
                        var y0 = 140;

                        if (MAX <= 3) y = y0 + j * 160;
                        var jj = (500 / MAX);

                        if (MAX > 3) y = y0 + j * jj;

                        var n = Stol[i][j];
                        GetSprite(n); OTKR[KartToNum(n)] = true;
                        if (n >= 77 && n <= 84) { x = 400; y = 450; AAA[n].transform.localScale = new Vector3(3f, 3f, 0.0f); AAA[n].transform.SetAsLastSibling(); }

                        if (ROTATE == KartToNum(n)) { Kart(x, y, 180 - 180 * a / AA, n); } else Kart(x, y, 0, n);
                        XX[i] = x; YY[i] = y;
                    }
        if (Stol[0].Count > 0)
        {
            var n = Stol[0][0];
            if (n >= 77 && n <= 84)
            {
                GetSprite(n); OTKR[KartToNum(n)] = true;
                Kart(400, 450, 0, n); AAA[n].transform.localScale = new Vector3(3f, 3f, 0.0f);
                AAA[n].transform.SetAsLastSibling();
            }
        }

    }
    public void Kart(float x, float y, int z, int n1)
    {

        var A = 0; var B = 0; var R = false; //var zz = 0;
        var n = n1;
        if (n1 < 0)
        {
            n = -n1;

        }
        if (n > 100)
        {
            A = Mathf.RoundToInt(n / 100);
            B = n - A * 100;
            if (A > B) { n = B * 100 + A; R = true; } else R = false;
            
            for (int i = 1; i <= 70; i++) if (n == Kart70[i])
                {
                    if (R) AAA[i].transform.rotation = Quaternion.Euler(0, 0, 180 - z);
                    else AAA[i].transform.rotation = Quaternion.Euler(0, 0, z);
                    if (R) AAA[i].GetComponentInChildren<Text>().transform.rotation = Quaternion.Euler(0, 0, z);
                    else AAA[i].GetComponentInChildren<Text>().transform.rotation = Quaternion.Euler(0, 0, z);

                    if (OTKR[i]) AAA[i].GetComponentInChildren<Text>().text = Kart20[B] + "\r\n" + "\r\n" + "\r\n" + Kart20[A];
                    else AAA[i].GetComponentInChildren<Text>().text ="";

                    n = i; break;
                }
            

        } 


        var X0 = AAA[n].GetComponent<Transform>().position.x;
        var Y0 = AAA[n].GetComponent<Transform>().position.y;
        var X = X0 - (X0 - x) * a / (AA);
        var Y = Y0 - (Y0 - y) * a / (AA);
        if ((X0 - x) * (X0 - x) + (Y0 - y) * (Y0 - y) > 3) NOMOVE = false; else NOMOVE = true;
        AAA[n].transform.position = new Vector3(X, Y, 0);
        if (n != Past)
        {
            AAA[n].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            AAA[n].transform.localScale = new Vector3(1f, 1f, 0.0f);
            if (Y > 650) AAA[n].transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
            if (Y > 675) AAA[n].transform.localScale = new Vector3(0.2f, 0.2f, 0.0f);
            if (Y > 700) AAA[n].transform.localScale = new Vector3(0.1f, 0.1f, 0.0f);
        }


        if (n <= 84 || n > 100) AAA[n].transform.SetAsLastSibling();


    }
    public int KartToNum(int n)
    {
        var v = n;
        if (n > 100)
        {
            var A = Mathf.RoundToInt(n / 100);
            var B = n - A * 100;
            if (A > B) { n = B * 100 + A; };
            for (int i = 1; i <= 70; i++) if (n == Kart70[i])
                {
                    v = i; break;
                }
        }
        return v;
    }
    void OpenSpisok(List<int> SPISOK) {if (SPISOK.Count > 0) for (int i = 0; i < SPISOK.Count; i++) { OTKR[KartToNum(SPISOK[i])] = true; GetSprite(SPISOK[i]); } }
    void CloseSpisok(List<int> SPISOK) { if (SPISOK.Count > 0) for (int i = 0; i < SPISOK.Count; i++) { OTKR[KartToNum(SPISOK[i])] = false; GetSprite(-SPISOK[i]); } }
    public void GetSprite(int nn)
    {
        if (nn < 0) nn = -nn; //открыть карты
        var n = 0; var A = 0; var B = 0; var N = 0; var R = false;
    
        if (nn < 0) n = -nn; else n = nn;
        if (n >= 1 && n <= 70)
        {
            N = Kart70[n];
            A = Mathf.RoundToInt(N / 100);
            B = N - A * 100;
            ////// AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("20/" + B.ToString());
            /////  AAA[n].GetComponent<CardManager>().Button2.sprite = Resources.Load<Sprite>("20/" + A.ToString());
            AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("70/" + Kart70[n].ToString());
            if (nn > 0) AAA[n].GetComponentInChildren<Text>().text = Kart20[B] + "\r\n" + "\r\n" + "\r\n" + Kart20[A];
            else AAA[n].GetComponentInChildren<Text>().text = "";



            if (nn < 0) AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("70/0");
        }
        if (n >= 71 && n <= 84)
        {
            AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("super/" + (n).ToString());
            if (nn < 0) AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("70/0");
        }
        if (n >= 85 && n <= 99)
        {
            AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("dynasties/" + (n - 84).ToString());
        }
        if (n > 100)
        {
            A = Mathf.RoundToInt(n / 100);
            B = n - A * 100;
            if (A > B) { n = B * 100 + A; R = true; } else R = false;
            
            for (int i = 1; i <= 70; i++) if (n == Kart70[i])
                {
                    if (R) AAA[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    else AAA[i].transform.rotation = Quaternion.Euler(0, 0, 0);
                    n = i; break;
                }
            if (nn > 0) AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("70/" + Kart70[n].ToString());
            if (nn < 0) AAA[n].GetComponent<CardManager>().Button.sprite = Resources.Load<Sprite>("70/0");
        }

    }

    public int Revers(int n)
    {
        var A = Mathf.RoundToInt(n / 100);
        var B = n - A * 100;
        if (n > 100) return B * 100 + A; else return n;
    }
    public bool Legal(int s, int n)
    {
        var v = false;
      ////  SSS = "s=" + s;
        var max = Stol[s].Count;
        var m = Stol[s][max - 1];

        if (n >= 77 && n <= 84) ///если кладут суперкарту
        {
            if (Ig == s) v = true; ///только на свой ряд
        }
        else
        {
               

            var A = Mathf.RoundToInt(n / 100);
            var B = n - A * 100;
            if (max == 1) ///если карта кладется на герб
            {
                if (m == 85 && (A == 11 || A == 6 || A == 8)) v = true; //Борджия - изм, флир, ер
                if (m == 86 && (A == 12 || A == 3 || A == 20)) v = true; //Бофорты - дуэль, суд, развод
                if (m == 87) v = true; //Валуа 
                if (m == 88 && (A == 18 || A == 19 || A == 15)) v = true; //Веттины - тур, дети, болезнь
                if (m == 89 && (A == 5 || A == 13 || A == 4)) v = true; //Гогг - связи, мон, охота
                if (m == 90 && (A == 9 || A == 14 || A == 10)) v = true; //Медичи - обуч, нас, пут

            }
            var A0 = Mathf.RoundToInt(m / 100);
            var B0 = m - A0 * 100;
            if (max > 1)
            {
                if (A == B0) v = true;
            }


            if (n >= 71 && n <= 76) v = true; // если замок     
            if (m >= 71 && m <= 76) v = true; // если на замок 
            ////запрет
            if (B == 7 && Ig == s) v = false; ///не объявлять войну самому себе
            //////////////////////////////////////////  if (B == 2 && Ig == s) v = false; ///не самоубиваться
            //if (B == 13 && Ig == s  ) v = false; ///не ставить себе монастырь
            if (B0 == 13 && Ig == s ) v = false; ////не ставить карт себе, если монастырь
                                                                         ///////       if (NABOR[Ig].Count < 2 && (n == 77 || n = 78)) v = false; ///
        }

        return v;
    }
    void Pesta() /// чума 
    {
        for (int i = 1; i <= 6; i++) if (Stol[i].Count > 1)
            {
                var k = Stol[i].Count;
                var n = Stol[i][k - 1];
                Stol[i].Remove(n); Sbros.Add(n);
            };
    }
    void InkRef(int del) /// инквизиция InkRef(8), реформация InkRef(13)
    {
        for (int k = 1; k <= 10; k++)
            for (int i = 1; i <= 6; i++)
                if (Stol[i].Count > 1)
                    for (int j = 1; j < Stol[i].Count; j++)
                    {
                        var n = Stol[i][j];
                        if (n > 100)
                        {
                            var A = Mathf.RoundToInt(n / 100);
                            var B = n - A * 100;
                            if (A == del || B == del) { Stol[i].Remove(n); Sbros.Add(n); break; }
                        }
                        
                    };
    }
    void XWar(int shag) /// крестьянская война XWar(1)-по часовой, XWar(-1)-против
    {


        for (int i = 0; i <= LimitIg; i++) NaborS[i] = "";

        if (shag < 0)
        {
            NABOR[0].Clear();
            if (NABOR[LimitIg].Count > 0)
                for (int j = 0; j < NABOR[LimitIg].Count; j++)
                {
                    var r = NABOR[LimitIg][j];
                    NABOR[0].Add(r);
                }
            for (int i = LimitIg; i > 0; i--)
            {

                NABOR[i].Clear();
                if (NABOR[i - 1].Count > 0)
                    for (int j = 0; j < NABOR[i - 1].Count; j++)
                    {
                        var r = NABOR[i - 1][j];
                        NABOR[i].Add(r);
                    }

            }
        }
        if (shag > 0)
        {

            for (int i = 0; i < LimitIg; i++)
            {
                NABOR[i].Clear();
                if (NABOR[i + 1].Count > 0)
                    for (int j = 0; j < NABOR[i + 1].Count; j++)
                    {
                        var r = NABOR[i + 1][j];
                        NABOR[i].Add(r);
                    }

            }
            NABOR[LimitIg].Clear();
            if (NABOR[0].Count > 0)
                for (int j = 0; j < NABOR[0].Count; j++)
                {
                    var r = NABOR[0][j];
                    NABOR[LimitIg].Add(r);
                }
        }

        for (int i = 0; i <= LimitIg; i++)
            if (NABOR[i].Count > 0)
                for (int j = 0; j < NABOR[i].Count; j++)
                {
                    NaborS[i] += NABOR[i][j] + ".";
                }
         
    }

    
    void Smert(int s) //// применение перка смерть
    {
        var zamok = false;
        var r = 0;
        var k = Stol[s].Count;
        if (k > 1)
            for (int i = k - 1; i > 0; i--)
            {
                r = Stol[s][i];
                if (r >= 71 && r <= 76) zamok = true;
                if (zamok == false) { Stol[s].Remove(r); Sbros.Add(r); };
            }
    }
    void War(int s)   ////// 7
    {
        var zamok = 0;
        var r = 0;
        var k = Stol[s].Count - 1;
        
        for (int i = 1; i < k; i++)
        {
            r = Stol[s][i];
            if (r >= 71 && r <= 76) { zamok = r; };
        }
        if (zamok > 0) { Stol[s].Remove(zamok); Sbros.Add(zamok); }
    }
    void zagovor(int ig)   ////// 7
    {
        var r = 0;
        var k = NABOR[ig].Count;
        for (int i = 0; i < k; i++)
        {
            r = NABOR[ig][i];
            Sbros.Add(r); 
        }
        NABOR[ig].Clear();
        if (k > 5) k = 5;
        Brat(ig, k);

    }
    public int HodII(int ig)
    {
        var maxS = 0;
           var v = -1; VAR.Clear(); VAR0.Clear(); VAR1.Clear(); VAR2.Clear(); VAR3.Clear();
        var maxStol = 0; for (int i = 1; i <= LimitIg; i++) if (maxStol<Stol[i].Count) { maxStol = Stol[i].Count; }
        if (NABOR[ig].Count > 0) ///если у игрока есть хот одна карта
        {
             maxS = 0; for (int i = 1; i <= 6; i++) if (Stol[i].Count > maxS) { maxS = Stol[i].Count; };////определение самого высокго столба
            for (int i = 1; i <= LimitIg; i++)
                for (int j = 0; j < NABOR[ig].Count; j++)
                {
                    var n = 0; var A = 0; var B = 0;
                    S1 = "ig=" + ig+"/ j="+j;
                    n = NABOR[ig][j]; A = Mathf.RoundToInt(n / 100); B = n - A * 100;
                    if (Legal(i, n)) { VAR.Add(i); VAR0.Add(n); VAR1.Add(A); VAR2.Add(B); VAR3.Add("/"); }
                    n = Revers(n); A = Mathf.RoundToInt(n / 100); B = n - A * 100;
                    if (Legal(i, n) && n > 100) { VAR.Add(i); VAR0.Add(n); VAR1.Add(A); VAR2.Add(B); VAR3.Add("/"); }
                } /////заполнение массива легальных ходов
            MAX = -9999;///нач оценки вариантов
            if (VAR.Count > 0) ///если варианты имеются
            {
                for (int i = 0; i < VAR.Count; i++)
                {
                    var s = VAR[i]; var n = VAR0[i]; var A = VAR1[i]; var B = VAR2[i]; var sum = 0;
                    
                    
                    if (s == ig) ///если на свой столб
                    {
                        sum += 1;
                        if (n == 77 || n == 78) sum += 1;  ///крестовый поход
                        if ((n == 77 || n == 78) && Stol[ig].Count<=2) sum -= 1000;  ///крестовый поход когда нет карт
                        if (n == 79)                     ///эпоха возрождения
                        {
                            if (Sbros.Count == 0) sum -= 1000;
                            if (Sbros.Count > 0) sum -= Sbros.Count;
                        }
                        if (n == 80) sum += 5-NABOR[ig].Count-KolZam(ig) * 1000;                      ///крестьянская война
                        if (n == 81)                       /// инквизиция
                        {
                            sum -= 200;
                            var n0 = Stol[ig][Stol[ig].Count - 1]; var A0 = Mathf.RoundToInt(n0 / 100); var B0 = n0 - A0 * 100;
                            if (B0 == 13 && A0 == 8) sum += 1000; ///если сверху монастырь и ересь
                            for (int j = 1; j <= LimitIg; j++) for (int k = 1; k < Stol[j].Count; k++) ///подсчет ересей у себя и других
                                {
                                     n0 = Stol[j][Stol[j].Count - 1];  A0 = Mathf.RoundToInt(n0 / 100); B0 = n0 - A0 * 100;
                                    if (j == ig && (A0 == 8 || B0 == 8)) sum -= 1;
                                    if (j != ig && (A0 == 8 || B0 == 8)) sum += 1;
                                }
                        }
                        if (n == 83)                       /// реформация
                        {
                            sum -= 200;
                            var n0 = Stol[ig][Stol[ig].Count - 1]; var A0 = Mathf.RoundToInt(n0 / 100); var B0 = n0 - A0 * 100;
                            if (B0 == 13) sum += 1000; ///если сверху монастырь 

                            for (int j = 1; j <= LimitIg; j++) ///если монастырь у других
                            {
                                n0 = Stol[j][Stol[j].Count - 1]; A0 = Mathf.RoundToInt(n0 / 100); B0 = n0 - A0 * 100;
                                if (B0 == 13) sum -= 100;
                            }

                            for (int j = 1; j <= LimitIg; j++) for (int k = 1; k < Stol[j].Count; k++) ///подсчет ересей у себя и других
                            {
                                    n0 = Stol[j][k]; A0 = Mathf.RoundToInt(n0 / 100); B0 = n0 - A0 * 100;
                                    if (j == ig && (A0 == 8 || B0 == 8)) sum -= 1;
                                    if (j != ig && (A0 == 8 || B0 == 8)) sum += 1;
                            }
                        }
                        if (n == 84) ////выборы императора
                        {
                            var mx = 0; var win = 0;
                            for (int j = 1; j <= LimitIg; j++)  if (NABOR[j].Count>mx) { mx = NABOR[j].Count; win = j; }

                            var ss = 0;  for (int j = 1; j <= LimitIg; j++) if (NABOR[j].Count == mx) ss += 1;
                            if (ss == 1 && mx == NABOR[ig].Count) sum+=1000 ;
                            if (ss > 1 && mx == NABOR[ig].Count && Egalitewin_5[ig] > 0) sum += 1000;
                            if (mx != NABOR[ig].Count) sum -= 100;
                        }
                        if (n == 82) ////чума
                        {
                            sum -= 200;
                            var n0 = Stol[ig][Stol[ig].Count - 1]; var A0 = Mathf.RoundToInt(n0 / 100); var B0 = n0 - A0 * 100;
                            if (B0 == 13) sum += 1000; ///если сверху монастырь 
                            var mn = 999; var mx = 0;
                            for (int j = 1; j <= LimitIg; j++) if (NABOR[j].Count > mx) { mx = NABOR[j].Count; }
                            for (int j = 1; j <= LimitIg; j++) if (NABOR[j].Count < mn) { mn = NABOR[j].Count; }
                            if (NABOR[ig].Count == mn && mx-mn>4) sum += 10; else sum -= 300;
                        }

                        if (n >= 71 && n <= 76) ////если ставит замок
                        {
                            sum += 1750 + Risk(s) * 1000; ///чем больше ломкость тем лучше
                           ////////// sum += (KolZam(s) - 1) * 10; ///если замок у игрока не последний
                        }
                        if (n > 100) /// если обычная карта
                        {
                            if (B == 2) { sum -= 1; sum -= Risk(s) * 1000; } ///смерть чем больше ломкость тем хуже }
                            if (B == 13) { sum -= 9999;  } ///если монастырь}
                            if (B == 13 && Stol[s].Count==LimitWin ) { sum += 9999; }; ///если монастырь но с победой
                            if (B == 13 && Stol[s].Count == LimitWin-1 && Shortwin_1[s] > 0) { sum += 9999; } ///если монастырь но с победой

                            if (B == 1 || B == 5 || B == 14) { sum += 100; sum += 5 - NABOR[s].Count; } ////брк свзи
                            if (B == 3) ////суд
                            {
                                for (int j = 1; j <= LimitIg; j++) if (Stol[j].Count > 1) sum += 10 * (Stol[j].Count - 1);
                            }
                            if (B == 4) ////охота
                            {
                                for (int j = 1; j <= LimitIg; j++) if (Stol[j].Count > 1) sum += 10 * (Stol[j].Count - 1);
                                sum += 5 - NABOR[s].Count;
                            }
                            if (B == 6) { sum += 500; sum += NABOR[s].Count; if (A == 2 || A == 7 || A == 13) sum += 100; } ////флирт+1 ход
                            
                            if (B == 8) { sum += 200 - 10 * NABOR[s].Count; }////////////////ересь
                            if (B == 9) { sum += 20; }////////////////обучение - глянуть в карты
                            if (B == 10) { sum += 10; }////////////////путешествие - пропуск хода
                            if (B == 11) { sum += NABOR[s].Count - 7 * KolZam(s); }////////////////измена - раздача всем своих карт
                            if (B == 12)
                            {
                                sum += NABOR[s].Count - (KolZam(s) * KolZam(s));
                            }////////////////дуэль - в темную поменяться
                            if (B == 15 || B == 20)
                            {
                                if (KolZam(s) == 0) sum += NABOR[s].Count * 10;
                                if (KolZam(s) == 1) sum += (NABOR[s].Count - 3) * 100;
                                if (KolZam(s) > 1) sum += (NABOR[s].Count - KolZam(s) - 2) * 100;
                            }////////////////скинуть 1 карту
                            if (B == 16)   /////заговор - поменять все карты
                            {
                                sum += NABOR[s].Count - 10 * KolZam(s);
                            }
                            if (B == 17) { sum += 10; }////////////////оскорбление - покзать всем карты
                            if (B == 18)   /////турнир - поменяться картами в светлую
                            {
                                sum += NABOR[s].Count - 20 * KolZam(s);
                            }
                            if (B == 19) { sum += 300; }////////////////дети - получить со всех по карте
                        }
                    }
                    //if (s != ig) { sum = -sum; }
                    if (s != ig)
                    {
                        sum -= 1;
                        if (n >= 71 && n <= 76) ////если ставит замок
                        {
                            sum -= 7000 + Risk(s) * 1000; ///чем больше ломкость тем хуже
                            sum += (KolZam(s) - 1) * 10; ///если замок у игрока не последний
                            sum -= NABOR[s].Count * 1000;
                        }
                        if (n > 100) /// если обычная карта
                        {
                            if (B == 2) { sum += Risk(s) * 1000 + Stol[s].Count * 10; if (Status[s] == 0) sum += 10; } ///смерть чем больше ломкость тем хуже }
                            if (B == 13) { sum += 999 +  Stol[s].Count * 50; if (Status[s] == 0) sum += 10; } ///если монастырь}
                            if (B == 13 && Stol[s].Count == LimitWin) { sum -= 9999; }; ///если монастырь но с победой для врага
                            if (B == 13 && Stol[s].Count == LimitWin - 1 && Shortwin_1[s] > 0) { sum -= 9999; } ///если монастырь но с победой для врага с перком

                            if (B == 7 && KolZamStol(s)>0)
                            { sum += KolZamStol(s)* 100 + Stol[s].Count*10;
                                if (Status[s] == 0) sum += 100;
                                if (favorit()==s) sum += 100;
                            }

                            if (B == 1 || B == 3 || B == 4 || B == 5 || B == 6 || B == 8 || B == 9 || B == 10 || B == 11 || B == 12 || B > 13)
                            { sum += Cena(n) - Stol[s].Count * 10; if (Status[s] == 0) sum -= 100; }
                        }


                    }

                    if (s != ig && favorit() == s) { sum = sum - 1; }
                    if (s != ig && maxS == Stol[s].Count) { sum = sum - 1; }

                    if (s != ig && Stol[s].Count == LimitWin-1 && Shortwin_1[s] > 0) { sum = -9999; }///такой ход вообще нельзя делать, так как он приносит победу чужому
                    if (s != ig && Stol[s].Count == LimitWin) { sum = -9999; }///такой ход вообще нельзя делать, так как он приносит победу чужому
                    VAR3[i] = "KolZamStol("+s+")="+KolZamStol(s)+" / " +sum;
                    if (sum>MAX) { MAX = sum;v = i; }
                }/////конец цикла
            }
        }
        return v;
    }
    public int KolZamStol(int s) ////количество замков на столбе
    {
        var v = 0; if (Stol[s].Count > 0) for (int i = 0; i < Stol[s].Count; i++) if (Stol[s][i] >= 71 && Stol[s][i] <= 76) v += 1;
        return v;
    }
    public int KolZam(int ig) ////количество замков у игрока
    {
        var v = 0; if (NABOR[ig].Count>0) for(int i = 0; i < NABOR[ig].Count; i++) if (NABOR[ig][i] >= 71 && NABOR[ig][i] <= 76) v += 1;
        return v;
    }
    public int Risk(int s) ///ломкость ряда
    {
        var v= 0;
        if (Stol[s].Count >= 2)
            for (int i = Stol[s].Count-1; i > 0; i--)
            {
                var r = Stol[s][i];
                if (r > 100) v += 1; else break;
            }
       return v;
    }
    public int Next(int I)
    {
        I += 1; if (I > LimitIg) I = 1; ///peredaca 
        return I;
    }

    public int Last(int I)
    {
        I -= 1; if (I == 0) I = LimitIg; ///peredaca 
        return I;
    }
    public string TextKart(int r)
        {
        var A = Mathf.RoundToInt(R / 100); var B = R - A * 100;
        var txt = "";
                if (R>100) txt= Kart20[A] + "/" + Kart20[B];
                if (R >= 71 && R <= 76) txt = "ЗАМОК";
                if (R == 77 || R == 78) txt = "Крестовый поход";
                if (R == 79) txt = "Эпоха возрождения";
                if (R == 80) txt = "Крестьянская война";
                if (R == 81) txt = "Инквизиция";
                if (R == 82) txt = "Чума";
                if (R == 83) txt = "Реформация";
                if (R == 84) txt = "Выборы императора";
        return txt;
        }


public int favorit()
    {
        var v = 0;
        var s = 0;
        var max = 0;
        var sum = 0;
        for (int i = 1; i <= 6; i++)
        {
            s = (Stol[i].Count - 1) * 10; if (Egalitewin_5[i] > 0) s += Egalitewin_5[i];////
            if (max < s) { max = s; };
        }
        for (int i = 1; i <= 6; i++)
        {
            s = (Stol[i].Count - 1) * 10; if (Egalitewin_5[i] > 0) s += Egalitewin_5[i];////
            if (max == s) { v = i; sum += 1; };
        }
        if (sum > 1) v = 0; ////ничья, лидер не определен
        return v;
    }


    void Zvuk()
    {
        //Timer = 10000;
        Melody = 0;
        audio.Stop(); audio.PlayOneShot(impact0, 0.8F);


    }
    void ZvukSmert()
    {
         var s = UnityEngine.Random.Range(1, Music[1]+1);
        if (Melody != 1 && s==1)
        {
            Music[1] += 1;
            Timer = 7000; Melody = 1;
            audio.Stop(); audio.PlayOneShot(impact1, 0.4F);
        }

    }
    void ZvukSator()
    {
         var s = UnityEngine.Random.Range(1, Music[2]+1);
        if (Melody != 2 && s == 1)
        {
            Music[2] += 1;
            Timer = 5000; Melody = 2;
            audio.Stop(); audio.PlayOneShot(impact2, 0.4F);
        }

    }
    void ZvukKnigt()
    {
         var s = UnityEngine.Random.Range(1, Music[3]+1);
        if (Melody != 3 && s == 1)
        {
            Music[3] += 1;
            Timer = 9000; Melody = 3;
            audio.Stop(); audio.PlayOneShot(impact3, 0.4F);
        }

    }
    
    public int SumStol()
    {
        var v = 0; for (int i = 0; i <= 6; i++) if (Stol[i].Count > 0) v += Stol[i].Count;
        return v;
    }
    public int SumNab()
    {
        var v = 0; for (int i = 1; i <= 6; i++) if (NABOR[i].Count > 0) v += NABOR[i].Count;
        return v;
    }
    public int SumAll()
    {

        return MyList.Count + Sbros.Count + SumNab() + SumStol();
    }
    void History()
    {
        if (TEXT1 != "") { TEXT1 = XOD + ". " + TEXT1; HISTORY.Add(TEXT1); TEXT1 = ""; }
        // хронология
        TEXT2 = "БАЛАНС " + (SumAll() - 90) + "\r\n";
        if (GAMEOVER >= 3 && favorit() > 0)
        {
            TEXT2 = "ВНИМАНИЕ! Если в ближайшие " + (1 + LimitIg - GAMEOVER) + " хода не будет сделано результативного хода - игра будет остановлена!" + "\r\n" + "Победителями будут объявлены " + Name[Din[favorit()]];
            HISTORY.Add(TEXT1); TEXT1 = "";
			Ocered.GetComponent<Text>().text = TEXT2;
        };
        if (GAMEOVER >= 9 && favorit() == 0)
        {
            TEXT2 = "ВНИМАНИЕ! Если в ближайшие " + (1 + 2 * LimitIg - GAMEOVER) + " хода не будет сделано результативного хода - игра будет остановлена, и объявлена ничья";
            HISTORY.Add(TEXT1); TEXT1 = "";
			Ocered.GetComponent<Text>().text = TEXT2;
        };
        //if ((SumAll() - 90) != 0) { TEXT2 = "БАЛАНС " + (SumAll() - 90)+ "\r\n"; }



        XOD += 1; TEXT0 = ""; for (int i = HISTORY.Count - 3; i < HISTORY.Count; i++)
        { TEXT0 += HISTORY[i] + "\r\n"; };

    }
    void OnGUI()
    {
        if (Timer > 0) Timer -= 1;
        if (ETAP != 84 && ETAP != 85)
        {

            GUI.Box(new Rect(30, 10, 700, 65), TEXT2 + TEXT0);
            Statistika.GetComponent<Text>().text = "В колоде " + MyList.Count + "/ В сбросе " + Sbros.Count;
        }
        Muzic.GetComponentInChildren<Text>().text = MuzicTXT;
    }

}

