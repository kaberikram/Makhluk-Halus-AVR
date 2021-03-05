using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{


    public GameObject m_GotHitScreen;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("vrPlayer"))
        {

            gotHurt();


        }
    }


    public void Update()
    {
       
        if (m_GotHitScreen != null)
        {
            if(m_GotHitScreen.GetComponent<Image>().color.a > 0)
            {
                var color = m_GotHitScreen.GetComponent<Image>().color;
                color.a -= 0.005f;

                m_GotHitScreen.GetComponent<Image>().color = color;

            }
        }
    }

    void gotHurt()
    {
        var color = m_GotHitScreen.GetComponent<Image>().color;
        color.a = 0.6f;

        m_GotHitScreen.GetComponent<Image>().color = color;
    }




    
}
