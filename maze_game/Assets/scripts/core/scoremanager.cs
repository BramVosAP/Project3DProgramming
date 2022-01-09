using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;
    public int scoremax;

    public Text scoretext;

    public int score = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "points: " + score.ToString() + "/" + scoremax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addpoint() {
        score += 1;
        scoretext.text = "points:" + score.ToString() + "/" + scoremax; 
    }
    public int returnpoints()
    {

        return score;
    }
}
