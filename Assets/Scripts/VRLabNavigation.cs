using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VRLabNavigation : MonoBehaviour
{
    public GameObject videoObject;
    public GameObject popUpObject;
    public GameObject miniMapObject;
    public GameObject videoPlayButton;

    public VideoPlayer videoPlayer;

    void Start()
    {
       // videoObject.SetActive(false);
        popUpObject.SetActive(false);
        miniMapObject.SetActive(false);

        videoPlayer.Stop();
    }

    private void Update()
    {
        CheckVideoIsPlay();
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ShowVideo()
    {
       // videoObject.SetActive(true);
        videoPlayer.Play();
    }

    public void ShowPopUp()
    {
        popUpObject.SetActive(true);
    }

    public void OpenMap()
    {
        miniMapObject.SetActive(true);
    }

    public void ExitTour()
    {
        Application.Quit();
    }

    internal void CheckVideoIsPlay()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayButton.SetActive(false);
        }
        else
        {
            videoPlayButton.SetActive(true);
        }
    }
}
