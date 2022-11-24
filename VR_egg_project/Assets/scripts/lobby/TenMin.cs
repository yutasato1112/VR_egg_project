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
    public static bool selectTenMin = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hand")
        {
            Debug.Log("ten");
            selectTenMin = true;
            SceneManager.LoadScene("gameScene");
        }
    }
}
