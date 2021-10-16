using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    private AudioSource audio;
    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("MainScene");
        audio.Play();
    }
}
