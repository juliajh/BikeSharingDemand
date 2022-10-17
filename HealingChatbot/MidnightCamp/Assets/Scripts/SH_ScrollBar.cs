using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SH_ScrollBar : MonoBehaviour
{
    Vector2 start;
    RectTransform curr;
    public float speed;
    public float loadingTime = 3;
    float currTime = 0;

    void Start()
    {
        start = GetComponent<RectTransform>().anchoredPosition;
    }

    
    void Update()
    {
        curr = GetComponent<RectTransform>();
        currTime += Time.deltaTime;
        // �ε��ð����� ��ũ�ѹ� ���������� �̵�
        if (currTime < loadingTime)
        {
            curr.anchoredPosition += Vector2.right * speed * Time.deltaTime;
            if (curr.anchoredPosition.x > 80)
            {
                curr.anchoredPosition = start;
            }
        }
        else
        {
            // �ε� â �Ϸ�Ǹ� MainScene���� �̵�
            SceneManager.LoadScene(2);
        }
        
    }
}
