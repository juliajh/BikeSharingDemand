using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YS_ChatUI : MonoBehaviour
{
    public Image chat_UI;
    public TextMeshProUGUI t1, t2, t3, t4, t5;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > 5 && currentTime < 8)
        {
            chat_UI.enabled = true;
            t1.enabled = true;
        }
        else if(currentTime > 8 && currentTime < 12)
        {
            t1.enabled = false;
            t2.enabled = true;
        }
        else if (currentTime > 12 && currentTime < 16)
        {
            t2.enabled = false;
            t3.enabled = true;
        }
        else if (currentTime > 16 && currentTime < 20)
        {
            t3.enabled = false;
            t4.enabled = true;
        }
        else if (currentTime > 20 && currentTime < 30)
        {
            t4.enabled = false;
            t5.enabled = true;
        }
        else if (currentTime > 30)
        {
            t5.enabled = false;
            currentTime = 5;
        }
    }
}
