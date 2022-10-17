using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YS_PlayerOn : MonoBehaviour
{
    public GameObject player, chatbot, cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if(cam.transform.position == new Vector3(16, 29.0000305f, 24.0001221f))
        {
            player.SetActive(true);
            chatbot.SetActive(true);
        }
    }
}
