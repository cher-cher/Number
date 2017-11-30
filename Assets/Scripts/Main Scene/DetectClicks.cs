using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectClicks : MonoBehaviour
{
    public Text gameName;
    public Text playTxt;
    public GameObject buttons;
    public string level;

    private bool clicked;

    void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;
            SceneManager.LoadScene(level);
        } 
    }
}
