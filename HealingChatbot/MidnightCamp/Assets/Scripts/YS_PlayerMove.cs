using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YS_PlayerMove : MonoBehaviour
{
    public float speed = 1;
    CharacterController cc;

    // �߷°� �� �����ӵ�
    public float gravity = -20;
    public float yVel = 0;

    // �ִϸ�����
    Animator anim;

    // �÷��̾� y�����̼�
    float y_rot;

    // �÷��̾� ���� ���
    bool b_up, b_right, b_left, b_down;
    float d;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        anim.SetFloat("Speed", v);
        anim.SetFloat("Direction", h);

        //Vector3 dir = transform.forward * v + transform.right * h; // �÷��̾ �ٶ󺸴� ������ �������� ȸ��
        Vector3 dir = new Vector3(h, 0, v); // �÷��̾ �ٶ󺸴� ����� ������� ȸ��
        dir.Normalize();

        dir = Camera.main.transform.TransformDirection(dir);

        // V = V0 + at
        yVel += gravity * Time.deltaTime;

        if (cc.isGrounded == true)
        {
            yVel = 0;
        }

        dir.y = yVel;
        cc.Move(dir * speed * Time.deltaTime);

        // �÷��̾ �ٶ󺸴� ������ �������� ȸ��
        /*if (Input.anyKeyDown)
        {
            y_rot = transform.rotation.eulerAngles.y;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 rot = new Vector3(0, y_rot + 180, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 rot = new Vector3(0, y_rot + 270, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 rot = new Vector3(0, y_rot + 90, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 rot = new Vector3(0, y_rot + 335, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            Vector3 rot = new Vector3(0, y_rot + 210, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            Vector3 rot = new Vector3(0, y_rot + 150, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            Vector3 rot = new Vector3(0, y_rot + 330, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            Vector3 rot = new Vector3(0, y_rot + 30, 0);
            if (rot.y > 360)
            {
                rot.y = rot.y - 360;
            }
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rot, 3 * Time.deltaTime);
        }*/

        // �÷��̾ �ٶ󺸴� ����� ������� ȸ��
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 225, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 135, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 180, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 225, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 330, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 270, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.W))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 135, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 45, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 90, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 330, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 45, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
            else
            {
                Vector3 rot = new Vector3(0, 0, 0);
                rot.y = Mathf.LerpAngle(transform.rotation.eulerAngles.y, 20, 3 * Time.deltaTime);
                transform.eulerAngles = rot;
            }
        }
    }
}
