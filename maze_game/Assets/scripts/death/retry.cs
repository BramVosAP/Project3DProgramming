using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    // Start is called before the first frame update

    public void loadlevel(string level)
    {

        SceneManager.LoadScene(level);

    }
}
