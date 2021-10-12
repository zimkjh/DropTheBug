using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public List<Sprite> backgroundImageList;
    public List<Sprite> backTreeImageList;
    public Sprite backgroundFever;
    public Sprite backTreeFever;
    private int nowIdx = 0;
    private bool firstTime = true;
    private static int changeTerm = 5;
    private bool feverFirstTime = true;
    private int changeCheckScore = 0;
    void Update()
    {
        int score = GameManager.I.getScore();
        if (!GameManager.I.feverTime)
        {
            if ((score - changeCheckScore) >= changeTerm && score > 0 && firstTime)
            {
                Debug.Log("original " + nowIdx + " " + score + " " + changeTerm);
                GameObject.Find("background_temp").GetComponent<SpriteRenderer>().sprite = backgroundImageList[nowIdx];
                GameObject.Find("background_temp").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                GameObject.Find("background").GetComponent<SpriteRenderer>().sprite = backgroundImageList[(nowIdx + 1) % 4];
                GameObject.Find("backgroundTree").GetComponent<SpriteRenderer>().sprite = backTreeImageList[(nowIdx + 1) % 4];
                GameObject.Find("backgroundTree_temp").GetComponent<SpriteRenderer>().sprite = backTreeImageList[nowIdx];
                GameObject.Find("backgroundTree_temp").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                changeCheckScore = score;
                nowIdx = (nowIdx + 1) % 4;
                firstTime = false;
            }
            if (GameManager.I.getScore() % changeTerm == 1 && firstTime == false)
            {
                firstTime = true;
            }
            if(feverFirstTime == false)
            {
                feverFirstTime = true;
                GameObject.Find("background").GetComponent<SpriteRenderer>().sprite = backgroundImageList[nowIdx];
                GameObject.Find("backgroundTree").GetComponent<SpriteRenderer>().sprite = backTreeImageList[nowIdx];
            }
        }
        changeColorAlpha("background_temp");
        changeColorAlpha("backgroundTree_temp");
        if (GameManager.I.feverTime && feverFirstTime)
        {
            Debug.Log("fever");
            GameObject.Find("background").GetComponent<SpriteRenderer>().sprite = backgroundFever;
            GameObject.Find("backgroundTree").GetComponent<SpriteRenderer>().sprite = backTreeFever;
            feverFirstTime = false;
        }
    }
    private void changeColorAlpha(string objectName)
    {
        if(GameObject.Find(objectName).GetComponent<SpriteRenderer>().color.a >= 0f)
        {
            GameObject.Find(objectName).GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 7 / 255f);
        }
    }
}
