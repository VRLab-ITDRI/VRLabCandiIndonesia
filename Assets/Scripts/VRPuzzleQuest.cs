using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPuzzleQuest : MonoBehaviour
{
    public GameObject nextSceneBtn;

    private void Start()
    {
        nextSceneBtn.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TriggerPoint")
        {
            CheckIsEnter();
        }
    }

    public void CheckIsEnter()
    {
        nextSceneBtn.SetActive(true);
    }
}
