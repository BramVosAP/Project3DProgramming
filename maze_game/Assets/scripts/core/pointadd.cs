using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointadd : MonoBehaviour
{
    public AudioSource ticksource;

    //var disabling render

    private void OnTriggerEnter(Collider collision)
    {
        scoremanager.instance.addpoint();
        ticksource.Play();
        GetComponent<Collider>().enabled = false;
        GetComponent<Renderer>().enabled = false;


    }


}
