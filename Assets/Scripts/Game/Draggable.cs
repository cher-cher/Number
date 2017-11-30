using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Draggable : MonoBehaviour
{
    public Sprite red;
    public Sprite green;
    public Sprite black;
    public SpriteRenderer squareBottom;
    public SpriteRenderer squareLeft;
    public SpriteRenderer squareTop;
    public SpriteRenderer squareRight;
    
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    
    public Vector3 posLeftBottom = new Vector3(-0.2f, -1.6f, 0);
    public Vector3 posRightBottom = new Vector3(0.8f, -2.3f, 0);
        
    public Vector3 posLeftLeft = new Vector3(-1.9f, 0.3f, 0);
    public Vector3 posRightLeft = new Vector3(-1.0f, -0.3f, 0);
        
    public Vector3 posLeftTop = new Vector3(-0.3f, 1.7f, 0);
    public Vector3 posRightTop = new Vector3(0.6f, 1.1f, 0);
        
    public Vector3 posLeftRight = new Vector3(1.4f, 0.3f, 0);
    public Vector3 posRightRight = new Vector3(2.3f, -0.3f, 0);
    
    public string win;
    
    float distance = 10;
    
    void Start()
    {
        squareBottom.gameObject.GetComponent<SpriteRenderer>().sprite = black;
    }
    
    void OnMouseDrag()
    {        
        bool gameOver = false;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objectPosition;
        
        if (objectPosition.x > posLeftBottom.x && objectPosition.x < posRightBottom.x && objectPosition.y < posLeftBottom.y && objectPosition.y > posRightBottom.y)
        {
            squareBottom.gameObject.GetComponent<SpriteRenderer>().sprite = green;
            gameOver = false;
        }
        else if (objectPosition.x > posLeftLeft.x && objectPosition.x < posRightLeft.x && objectPosition.y < posLeftLeft.y && objectPosition.y > posRightLeft.y)
        {
            squareLeft.gameObject.GetComponent<SpriteRenderer>().sprite = red;
            gameOver = true;
        }
        else if (objectPosition.x > posLeftTop.x && objectPosition.x < posRightTop.x && objectPosition.y < posLeftTop.y && objectPosition.y > posRightTop.y)
        {
            squareTop.gameObject.GetComponent<SpriteRenderer>().sprite = red;
            gameOver = true;
        }
        else if (objectPosition.x > posLeftRight.x && objectPosition.x < posRightRight.x && objectPosition.y < posLeftRight.y && objectPosition.y > posRightRight.y)
        {
            squareRight.gameObject.GetComponent<SpriteRenderer>().sprite = red;
            gameOver = true;
        }
        else 
        {
            squareBottom.gameObject.GetComponent<SpriteRenderer>().sprite = black;
            squareLeft.gameObject.GetComponent<SpriteRenderer>().sprite = black;
            squareTop.gameObject.GetComponent<SpriteRenderer>().sprite = black;
            squareRight.gameObject.GetComponent<SpriteRenderer>().sprite = black;
        }
        if (gameOver)
        {
            SceneManager.LoadScene("GameOver");
            var music = GameObject.FindGameObjectsWithTag("Music");
            foreach (var obj in music)
            {
                Destroy(obj);
            }
            
        }
        if (one.transform.position.x > posLeftBottom.x && one.transform.position.x < posRightBottom.x && one.transform.position.y < posLeftBottom.y && one.transform.position.y > posRightBottom.y
        && two.transform.position.x > posLeftLeft.x && two.transform.position.x < posRightLeft.x && two.transform.position.y < posLeftLeft.y && two.transform.position.y > posRightLeft.y
        && three.transform.position.x > posLeftTop.x && three.transform.position.x < posRightTop.x && three.transform.position.y < posLeftTop.y && three.transform.position.y > posRightTop.y
        && four.transform.position.x > posLeftRight.x && four.transform.position.x < posRightRight.x && four.transform.position.y < posLeftRight.y && four.transform.position.y > posRightRight.y)
        {
            SceneManager.LoadScene(win);
        }
    }    
}
