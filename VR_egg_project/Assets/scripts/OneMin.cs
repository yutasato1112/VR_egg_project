using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OneMin : MonoBehaviour
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hand")
        {
            Debug.Log("one");
            selectTime = 1;
            SceneManager.LoadScene("gameScene");
        }
    }
}
