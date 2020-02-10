using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;

public class Pole : MonoBehaviour {
    public int x;
    public int y;
    public string z;
    public GameObject Inp1;
    public GameObject Input;
    public GameObject But1;
    public GameObject But2;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void zap()
    {
        Chess.zap = true; //But1.SetActive(false);
    }
    public void Net()
    {
        Chess.GlobalETAP = 0;
    }
    public void Redaktor()
    {
        Chess.GlobalETAP = 100;
    }
    public void WH()
    {
        Chess.WhiteH = true; Chess.BlackH = false; Chess.REVERS = false; Chess.GlobalETAP = 10;
    }
    public void BH()
    {
        Chess.WhiteH = false; Chess.BlackH = true; Chess.REVERS = true; Chess.GlobalETAP = 10;
    }
    public void H_H()
    {
        Chess.WhiteH = true; Chess.BlackH = true; Chess.GlobalETAP = 10;
    }
    public void M_M()
    {
        Chess.WhiteH = false; Chess.BlackH = false; Chess.GlobalETAP = 10;
    }
    public void Figura()
    {
        var s = Convert.ToInt32(DateTime.Now.ToString("ss"));

        if (Chess.GlobalZ == z) { Chess.GlobalZ = ""; But1.transform.localScale = new Vector3(1f, 1f, 1f); }
        else { Chess.GlobalZ = z; /*But1.transform.localScale = new Vector3(1.5f, 1.5f, 1.1f);*/ }///*180/60

    }
    public void OceredHoda()
    {
        if (z == "w") { But1.GetComponent<Button>().interactable = false; But2.GetComponent<Button>().interactable = true; }
        if (z == "b") { But2.GetComponent<Button>().interactable = false; But1.GetComponent<Button>().interactable = true; }

        Chess.BOARD[0, 0] = z[0];
        Chess.Board();
    }
    public void ClearBoard()
    {
        for (int i = 1; i <= 8; i++)
            for (int j = 1; j <= 8; j++) Chess.BOARD[i, j] = ' ';
        Chess.Board();
    }
    public void BeginBoard()
    {
        Chess.BOARD = Chess.BoardLoad(Chess.BeginPosition);
        Chess.Board();
        
    }
    public void KNOPKA1clik()
    {
   //////if (Chess.REVERS==true) {x = 9 - x;y = 9 - y;}
           Chess.GlobalX = x; Chess.GlobalY = y;
       /// Debug.Log("x=" + x+ ", y=" + y+ " REVERS="+ Chess.REVERS); 
      if (Chess.GlobalZ != "")
        {
            if (Chess.BOARD[x, y] != Chess.GlobalZ[0] && Chess.GlobalZ!="") Chess.BOARD[x, y] = Chess.GlobalZ[0];
            else Chess.BOARD[x, y] = ' ';
           Chess.Board();
        }

    }
    public void Revers()
    {
        Chess.REVERS = !Chess.REVERS;
        Chess.Board();
    }
    
    public void InputName()
    {
        ///Chess.Inp1.GetComponent<InputField>().text =   .InPlayer1 = "---";

      Chess.Player1 = Inp1.GetComponent<InputField>().text ;
        But1.GetComponent<Button>().interactable = true;
        //Debug.Log("Кнопка1");
        
        Input.GetComponent<InputField>().interactable = true;
        ///Debug.Log("Ввод кода ожидается");
    }
    public void NewGame()
    {
        /////Chess.Player1 = Inp1.GetComponent<InputField>().text;
        ///// Chess.txtConnect = "Введи имя!";
        if (Chess.Player1.Length > 2 && Chess.Iam == 0)
        {

            ////стирание старых игр
            ///   Chess.txtConnect = "https://crown.alabuga.ru/img/222.php?act=DELETE FROM `MP` WHERE `Player2`=\"\"";
            //   StartCoroutine(GetRequest(Chess.txtConnect));

            //StartCoroutine(GetRequest(""));


            Chess.KodGame = UnityEngine.Random.Range(1, 1000);
            Chess.Iam = 1;////ПЕРВЫМ ИГРОКОМ
            Chess.txtConnect2 = "https://crown.alabuga.ru/img/1_INSERT.php?act=(`Position`,`id`,`Player1`) VALUES(\"" + Chess.BeginPosition + "\"," + Chess.KodGame + ",\"" + Chess.Player1 + "\")";

            Chess.txtConnect = "";
            StartCoroutine(GetRequest(Chess.txtConnect2));
            
            ///Chess.KodGame = 0; Chess.Iam = 0; ///Chess.txtConnect2 = "/" + Chess.txtConnect + "/не удалось создать игру"+ Chess.txtConnect2; };

        }
       //// else Chess.txtConnect = "Введи имя!";

    }


    public void InputKod()
    {
        ///Chess.Inp1.GetComponent<InputField>().text =   .InPlayer1 = "---";
        Chess.Iam = 2;////ВТОРЫМ ИГРОКОМ
        Chess.KodGame2 = Mathf.RoundToInt(Convert.ToInt16((Input.GetComponent<InputField>().text)));
        //Chess.KodGame2 =
        But2.GetComponent<Button>().interactable = true;
        But1.GetComponent<Button>().interactable = false;
    }
    public void ToGame()
    {
        if (Chess.Player1 != "" && Chess.Player2=="")
        {
            Debug.Log("Начало=");
            Chess.txtConnect = "";

           // var t = "https://crown.alabuga.ru/img/2_UPDATE.php?act=SET `Player2`= \"" + Chess.Player1 + "\" WHERE ID=" + Chess.KodGame2 + " AND `Player2`= \"\" ";
           // StartCoroutine(GetRequest(t));
            
            Chess.Player2 = Chess.Player1;
            Chess.KodGame = Chess.KodGame2;
            Chess.Iam = 2;
        }

    }
    public void ExitGame()
    {
        Debug.Log("Выйди из игры");
        Application.Quit();

    }
    public void AvtoGame()
    {
        if (Chess.Avto) Chess.Avto = false; else Chess.Avto = true;
        if (Chess.Avto) But1.GetComponentInChildren<Text>().text = "АВТО";
        else But1.GetComponentInChildren<Text>().text = "Ручной";
    }
    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri); ///        //UnityWebRequest uwr = UnityWebRequest.Get("https://crown.alabuga.ru/img/222.php?act=getquestions");

        yield return uwr.Send();
        Debug.Log(uwr.downloadHandler.text);

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            ////// JSONNode RQ = SimpleJSON.JSON.Parse(uwr.downloadHandler.text);
            Debug.Log("O"+ uwr.downloadHandler.text+"K");
            Chess.txtConnect = uwr.downloadHandler.text;
        }   
    }
}
