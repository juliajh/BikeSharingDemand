using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SH_Start : MonoBehaviour
{
    [Header("���� �ε��� �� �ѹ�")]
    public int sceneNum;
    public void OnStartButton()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
