using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SH_ButtonManager : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public Camera cam1;
    public Camera cam2;

    [Header("���� �ε��� �� �ѹ�")]
    public int sceneNum;


    public void OnEnter()
    {
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
    }
    
    public void OnExit()
    {
        SceneManager.LoadScene(sceneNum);
    }
    
}
