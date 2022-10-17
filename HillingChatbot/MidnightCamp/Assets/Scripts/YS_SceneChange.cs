using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YS_SceneChange : MonoBehaviour
{
    GameObject cam;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        /*if(cam.transform.position == new Vector3(6.19999981f, 5.4000001f, 3.9000001f))
        {
            currentTime += Time.deltaTime;
            if(currentTime > 6)
            {
                SceneManager.LoadScene(3);
            }
        }*/

        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(3);
        }
    }
}
