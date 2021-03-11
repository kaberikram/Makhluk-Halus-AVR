using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restartsound : MonoBehaviour
{
    public AudioSource ReSource;
    public AudioClip ReClip;
    public void bunyiClick()
    {
        ReSource.PlayOneShot(ReClip);
    }
}
