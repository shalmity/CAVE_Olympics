using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update()
    {
        // �ƹ� Ű�� ������ Main ������ �Ѿ��
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
