using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiketrap : MonoBehaviour
{
    [SerializeField] private Animator myanimationcontroler;


    private void OnMouseUp()
    {

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        myanimationcontroler.SetBool("enabler", true);
        Debug.Log("this");
    }

    private void OnTriggerExit(Collider other)
    {
        myanimationcontroler.SetBool("enabler", false);
    }

}
