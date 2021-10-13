using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCloud : MonoBehaviour
{
    public GameObject[] cloud1List;
    public GameObject[] cloud2List;
    public GameObject[] cloud3List;
    void Start()
    {
        Instantiate(cloud1List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        Instantiate(cloud2List[BackGround.I.nowIdx], new Vector3(6, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
    }
    public void newCloud()
    {
        int tempIdx = Random.Range(0, 3);
        if(tempIdx == 0)
        {
            Instantiate(cloud1List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        }
        else if(tempIdx == 1)
        {
            Instantiate(cloud2List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        }
        else
        {
            Instantiate(cloud3List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        }
    }
}
