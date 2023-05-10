using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLabAdsPopUp : MonoBehaviour
{
    public GameObject qrImage;

    // Start is called before the first frame update
    void Start()
    {
        qrImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQRToActive()
    {
        qrImage.SetActive (true);
    }
}
