using UnityEngine;

public class MatchCanvasSize : MonoBehaviour
{
    public GameObject originalObject; // ���� ��ü�� Inspector���� ����

    void Start()
    {
        // ���� ��ü�� RectTransform ������Ʈ ��������
        RectTransform originalRectTransform = originalObject.GetComponent<RectTransform>();

        // ���� ��ü�� ũ�� ��������
        Vector2 originalSize = originalRectTransform.sizeDelta;

        // Canvas�� RectTransform ������Ʈ ��������
        RectTransform canvasRectTransform = GetComponent<RectTransform>();

        // Canvas�� ũ�⸦ ���� ��ü�� ũ��� ����
        canvasRectTransform.sizeDelta = originalSize;
    }
}
