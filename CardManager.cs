using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour {
    
    public Image Button;
    public Image Button2;
    public int Kart;
    // Use this for initialization
    void Start () {
		
	}
    void OnMouseExit()
    {

    }
    void OnMouseOver()
    {
        //Dynasty.AAA[Kart].GetComponentInChildren<Text>().text = Kart+" ";
        Dynasty.AAA[Kart].GetComponent<SpriteRenderer>().color = new Color32(25, 255, 255, 15);
        Debug.Log("Kart=" + Kart);
    }
    // Update is called once per frame
    void Update () {
       /* var n = Kart;
        if (Dynasty.Past > 0) Dynasty.AAA[Dynasty.Past].transform.localScale = new Vector3(1f, 1f, 0.0f);
        Dynasty.AAA[n].transform.localScale = new Vector3(10f, 10f, 0.0f);
        Dynasty.Past = n;
        Debug.Log("n=" + n);*/
    }
    public void KNOPKA1clik()
    {
        var n = Kart;
        if (Dynasty.AAA[n].transform.position.y< 650)
        {
            
            Debug.Log("n=" + n+ "NSTOL="+ Dynasty.NSTOL+", NOMIG="+ Dynasty.NOMIG);
            if (Dynasty.Past > 0) Dynasty.AAA[Dynasty.Past].transform.localScale = new Vector3(1f, 1f, 0.0f);
            if (n != Dynasty.Past)
            {
                Dynasty.AAA[n].transform.localScale = new Vector3(2f, 2f, 0.0f);
                Dynasty.AAA[n].transform.SetAsLastSibling();
                Dynasty.Past = n;
            }
            else
            {
                Dynasty.AAA[n].transform.localScale = new Vector3(1f, 1f, 0.0f);
                Dynasty.AAA[n].transform.SetAsLastSibling();
                Dynasty.Past = 0;
            };


            //Dynasty.AAA[Kart].GetComponentInChildren<Text>().text = Kart + " ";
        }
        Dynasty.REVERS = false;
    }
    
    public void Close()
    {
        Dynasty.CLOSE = true; 
    }
    public void LEFT()
    {
        Dynasty.LEFT = true; Dynasty.NOMOVE = false; Dynasty.RIGHT = false;
    }
    public void RIGHT()
    {
        Dynasty.RIGHT = true; Dynasty.NOMOVE = false; Dynasty.LEFT = false;
    }
    public void REVERS()
    {
        Dynasty.REVERS = true; Dynasty.NOMOVE = false;
       // Debug.Log("REVERS=" + Dynasty.REVERS);
    }
    public void MOVE()
    {
        Dynasty.NSTOL = Kart;
    }
    public void PROP()
    {
        Dynasty.PROP = true;
    }
    public void VZJAT()
    {
        Dynasty.VZJAT = true;
    }
    public void YES()
    {
        Dynasty.YES = true;
    }
    public void NO()
    {
        Dynasty.NO = true;
    }
    public void SMERT()
    {
        Dynasty.SMERT = true; Debug.Log("смерть" );
    }
    public void IGROK()
    {
        Dynasty.NOMIG = Kart;
    }
    public void ZVUK()
    {
        if (Dynasty.audio.mute)
        { Dynasty.audio.mute = false; Dynasty.MuzicTXT = "ВЫКЛ.ЗВУК"; }
        else {Dynasty.audio.mute = true; Dynasty.MuzicTXT = "ВКЛ.ЗВУК"; };
    }
    
}
