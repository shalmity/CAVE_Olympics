using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update()
    {
        
    }

    public void MoveMain()
    {
        // �ƹ� Ű�� ������ Main ������ �Ѿ��
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Main");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene("Main");
        }
    }

    public void Restart()
    {
        // �ƹ� Ű�� ������ Main ������ �Ѿ��
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Main");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
