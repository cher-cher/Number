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

    private bool clicked;

    void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;
            //gameName.gameObject.SetActive(false);
            //playTxt.gameObject.SetActive(false);
            //buttons.GetComponent<ScrollObjects>().speed = -5f;
            //buttons.GetComponent<ScrollObjects>().checkPos = -140f;
            SceneManager.LoadScene("level1");
        } 
    }
}
