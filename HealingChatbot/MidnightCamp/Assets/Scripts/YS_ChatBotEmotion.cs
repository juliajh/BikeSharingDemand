using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YS_ChatBotEmotion : MonoBehaviour
{
    GameObject chatbotPos;
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        chatbotPos = GameObject.Find("ChatbotPos");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, chatbotPos.transform.position, speed * Time.deltaTime);
    }
}
