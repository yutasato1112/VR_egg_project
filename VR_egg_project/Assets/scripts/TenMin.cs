using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TenMin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static int selectTime = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hand")
        {
            Debug.Log("ten");
            selectTime = 10;
            SceneManager.LoadScene("gameScene");
        }
    }
}
