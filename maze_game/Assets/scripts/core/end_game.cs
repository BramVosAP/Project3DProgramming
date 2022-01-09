using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class end_game : MonoBehaviour
{
    //disable controler vars
    //disable conroles var
    public GameObject controler;
    public string scr;

    //ouput text
    public Text currentTimeTxt; //tijd
    public Text scoretext; //score

    //canvas
    public Canvas curent_canvas;
    public Canvas end_canvas;

    //time
    float time = 0;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {

        //disable controles
        (controler.GetComponent(scr) as MonoBehaviour).enabled = false;

        //free curson
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        //show death screen
        curent_canvas.enabled = false;
        end_canvas.enabled = true;

        currentTimeTxt.text = currentTimeTxt.text + time.ToString();
        int curentscore =scoremanager.instance.score;
        scoretext.text = scoretext.text + (curentscore).ToString();
       


    }

    void Update()
    {
        time = time + Time.deltaTime;
    }
}
