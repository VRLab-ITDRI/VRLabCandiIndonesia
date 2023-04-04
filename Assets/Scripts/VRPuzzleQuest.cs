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
            StartCoroutine(DelayBeforeDestroy());
        }
    }

    public void CheckIsEnter()
    {
        nextSceneBtn.SetActive(true);
    }

    IEnumerator DelayBeforeDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
