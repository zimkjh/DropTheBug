using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    private AudioSource selectAudio;
    private void Start()
    {
        selectAudio = gameObject.GetComponent<AudioSource>();
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("MainScene");
        selectAudio.Play();
    }
}
