using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLabRelicSystem : MonoBehaviour
{
    public GameObject objRelic1;
    public GameObject objRelic2;
    public GameObject objRelic3;
    public GameObject objRelic4;

    public GameObject relic1;
    public GameObject relic2;
    public GameObject relic3;
    public GameObject relic4;

    private void Start()
    {
        objRelic1.SetActive(false);
        objRelic2.SetActive(false);
        objRelic3.SetActive(false);
        objRelic4.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Relic1")
        {
            objRelic1.SetActive(true);
            Destroy(relic1);
        }
        if (other.gameObject.tag == "Relic2")
        {
            objRelic2.SetActive(true);
            Destroy(relic2);
        }
        if (other.gameObject.tag == "Relic3")
        {
            objRelic3.SetActive(true);
            Destroy(relic3);
        }
        if (other.gameObject.tag == "Relic4")
        {
            objRelic4.SetActive(true);
            Destroy(relic4);
        }
    }
}
