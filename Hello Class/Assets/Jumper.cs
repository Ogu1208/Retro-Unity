using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.AddForce(0, 500, 0);  // 힘을 주는 기능
        // x, y, z방향으로 입력한 값만큼 힘을 준다.ㄴ
    }


}
