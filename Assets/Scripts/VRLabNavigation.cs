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
    public VideoPlayer videoPlayer;

    void Start()
    {
        popUpObject.SetActive(false);
        miniMapObject.SetActive(false);
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ShowVideo()
    {
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
}
