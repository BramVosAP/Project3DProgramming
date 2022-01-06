using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class addtime_upgrade : MonoBehaviour
{
    public Text upgrade_text;
    // Start is called before the first frame update
    void Start()
    {
        upgrade_text.CrossFadeAlpha(0.0f, 0.05f, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        upgrade_text.CrossFadeAlpha(1.0f, 0.05f, false);
        upgrade_text.CrossFadeAlpha(0.0f, 3.50f, false);
        upgrade_text.text = "extra time added";
        Destroy(gameObject);
        timer.instance.addtime();



    }

  
}
