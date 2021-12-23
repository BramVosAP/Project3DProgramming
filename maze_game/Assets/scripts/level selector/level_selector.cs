using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level_selector : MonoBehaviour
{


    public void loadlevel(string level) {

        SceneManager.LoadScene("level" + level);

    }

}