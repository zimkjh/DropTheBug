using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public List<Sprite> backgroundImageList;
    public List<Sprite> backTreeImageList;
    public int nowIdx = 0;
    private bool firstTime = true;
    private static int changeTerm = 50;
    private int changeCheckScore = 0;
    public static BackGround I;
    private void Awake()
    {
        I = this;
        nowIdx = 0;
    }
    void Update()
    {
        int score = GameManager.I.getScore();
        if ((score - changeCheckScore) >= changeTerm && score > 0 && firstTime)
        {
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
        changeColorAlpha("background_temp");
        changeColorAlpha("backgroundTree_temp");
    }
    private void changeColorAlpha(string objectName)
    {
        if(GameObject.Find(objectName).GetComponent<SpriteRenderer>().color.a >= 0f)
        {
            GameObject.Find(objectName).GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 7 / 255f);
        }
    }
}
