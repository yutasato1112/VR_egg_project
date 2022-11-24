using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class userSelectTime : MonoBehaviour
{
    public static int selectTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("one");
            selectTime = 1;
            SceneManager.LoadScene("gameScene");
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            Debug.Log("three");
            selectTime = 3;
            SceneManager.LoadScene("gameScene");
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            Debug.Log("five");
            selectTime = 5;
            SceneManager.LoadScene("gameScene");
        }
        else if (Input.GetKey(KeyCode.Alpha0))
        {
            Debug.Log("ten");
            selectTime = 10;
            SceneManager.LoadScene("gameScene");
        }
    }
}
