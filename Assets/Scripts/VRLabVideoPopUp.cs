using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VRLabVideoPopUp : MonoBehaviour
{
    public GameObject videoPlayButton;
    public VideoPlayer videoPlayer;

    void Update()
    {
        CheckVideoIsPlay();
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
