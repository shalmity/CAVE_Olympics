using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update()
    {
        // �ƹ� Ű�� ������ Main ������ �Ѿ��
        //��ŧ������ A ��ư ������ �Ѿ
        if (Input.anyKeyDown || OVRInput.GetDown(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
