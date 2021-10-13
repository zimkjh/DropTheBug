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
        Debug.Log("nowIDx" + BackGround.I.nowIdx);
        Instantiate(cloud1List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        Instantiate(cloud2List[BackGround.I.nowIdx], new Vector3(6, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
    }
    public void newCloud()
    {
        int tempIdx = Random.Range(0, 3);
        if(tempIdx == 0)
        {
            Debug.Log("cloud 0");
            Instantiate(cloud1List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        }
        else if(tempIdx == 1)
        {
            Debug.Log("cloud 1");
            Instantiate(cloud2List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        }
        else
        {
            Debug.Log("cloud 2");
            Instantiate(cloud3List[BackGround.I.nowIdx], new Vector3(4, Random.Range(-1.4f, 1f), 0), Quaternion.identity);
        }
    }
}
