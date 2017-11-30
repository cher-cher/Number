using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    float timer = 30;
    private Text txt;
    
	GameObject TimeObj;
    
    void Start () {
        txt = GetComponent <Text> ();
	}
    
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            int oclock = (int)timer;
            txt.text = oclock.ToString();
        }
        else{
            SceneManager.LoadScene("GameOver");
        }
    }
}
