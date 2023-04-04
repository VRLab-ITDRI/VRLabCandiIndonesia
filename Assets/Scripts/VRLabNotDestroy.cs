using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLabNotDestroy : MonoBehaviour
{
    private static VRLabNotDestroy instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
}
