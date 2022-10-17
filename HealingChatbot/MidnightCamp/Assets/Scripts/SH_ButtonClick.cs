using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SH_ButtonClick : MonoBehaviour
{
    SH_TypingEffect type;

    private void Start()
    {
        type = GetComponent<SH_TypingEffect>();
    }
    public void OnPlayButtonDown()
    {
        type.isPlay = true;
    }

    public void OnGoButtonDown()
    {
        type.isGo = true;
    }

    public void OnClickButtonDown()
    {
        type.isUpload = true;
    }
}
