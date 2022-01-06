using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static timer instance;
    float currentTime;
    public int startMinutes;
    public Text currentTimeTxt;
    public Canvas curent_canvas;
    public Canvas death_canvas;

    //disable conroles var
    public GameObject controler;
    public string scr;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;
    }

    //instance
    private void Awake()
    {
        instance = this;
    }



    // Update is called once per frame
    void Update()
    {
        if (currentTime >= 0)
        {
            currentTime = currentTime - Time.deltaTime;
        }
        else
        {
            //disable controles
            (controler.GetComponent(scr) as MonoBehaviour).enabled = false;

            //free curson
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            //show death screen
            curent_canvas.enabled = false;
            death_canvas.enabled = true;
        }
        currentTimeTxt.text = currentTime.ToString();
    }

    public void addtime() {

        currentTime = currentTime + 20;
    }
    
}
