using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int love = 80;

        if(love>90)
        {
            Debug.Log("Ʈ�翣��: �����ΰ� ��ȥ�ߴ�!");
        }
        else if(love>70)
        {
            // love�� 90���� �۰ų� ����. 70���� ū ���
            Debug.Log("�¿���: �����ΰ� ��Ͱ� �Ǿ���!");
        }
        else
        {
            Debug.Log("��忣��: �����ο��� ������.");
        }
    }

  
}
