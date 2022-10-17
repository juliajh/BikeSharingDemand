using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YS_Camera : MonoBehaviour
{
    public GameObject camPos, startCam, playerCam, bg, bg2;
    float speed = 1;
    float rotSpeed = 0.5f;

    public int camNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        camPos = GameObject.Find("CamPos");
    }

    // Update is called once per frame
    void Update()
    {
        KeyNum();

        if(camNum == 0)
        {
            Basic();
        }
        else if(camNum == 1)
        {
            Good();
        }
        else if (camNum == 2)
        {
            Bad();
        }
        else if (camNum == 3)
        {
            Talk();
        }

        if(Input.anyKeyDown)
        {
            playerCam.SetActive(true);
            bg.SetActive(false);
            bg2.SetActive(true);
        }
    }

    void Basic()
    {
        
        speed = 1;
        //Vector3 basicPos = new Vector3(1.48000002f, 3.32999992f, 5.5f);
        //camPos.transform.localPosition = basicPos;
        //Vector3 rot = new Vector3(19.7950039f, 180, 0);
        //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, rotSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, camPos.transform.position, speed * Time.deltaTime);
    }

    void Good()
    {
        speed = 1f;
        float rotSpeed = 0.5f;

        Vector3 goodPos = new Vector3(0.910000026f, 1.47000003f, -2.04999995f);
        camPos.transform.localPosition = goodPos;
        Vector3 rot = new Vector3(0, 120f, 0f);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, rotSpeed * Time.deltaTime);
    }

    void Bad()
    {
        speed = 0.8f;
        float rotSpeed = 0.5f;

        Vector3 badPos = new Vector3(-0.159999996f, 3.9000001f, -0.319999993f);
        camPos.transform.localPosition = badPos;
        Vector3 rot = new Vector3(53.5279007f, 130f, 85.8437119f);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, rotSpeed * Time.deltaTime);
    }

    void Talk()
    {
        speed = 0.8f;
        float rotSpeed = 1f;

        Vector3 talkPos = new Vector3(4.30999994f, 4.5999999f, -1.09000003f);
        camPos.transform.localPosition = talkPos;
        Vector3 rot = new Vector3(32.3305664f, 90, 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, rotSpeed * Time.deltaTime);
    }

    void KeyNum()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            camNum = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            camNum = 1;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            camNum = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camNum = 3;
        }
    }
}
