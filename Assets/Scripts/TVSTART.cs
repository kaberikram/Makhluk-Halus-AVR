using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVSTART : MonoBehaviour
{
    public GameObject TV;
    public float sec = 14f;
    void Start()
    {
        TV.gameObject.SetActive(true);
        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        TV.gameObject.SetActive(false);
        //Do Function here...
    }

}
