using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // 동물에 대한 변수
    public string name;
    public string sound;

    // 울음소리를 재생하는 메서드
    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}

// MonoBehaviour 클래스
// - 게임 오브젝트의 컴포넌트로서 필요한 기능들 제공,
// 따라서 이 클래스를 포합하지 않은 Animal 클래스는 게임 오브젝트에 컴포넌트로서 추가할 수 없다.