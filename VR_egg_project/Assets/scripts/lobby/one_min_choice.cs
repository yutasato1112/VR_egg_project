using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_min_choice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //選択した分数を共有するためのpublic変数
    public static int select_min = 0;
    //手との接触を感知し、画面遷移
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="hand"){
            Debug.Log("1min");
            select_min=1;
            SceneManager.LoadScene("lobbyScene");
        }
    }
}
