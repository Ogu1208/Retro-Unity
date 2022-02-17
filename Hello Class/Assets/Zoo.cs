using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "냐옹!";

        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍!";

        jerry = tom;
        jerry.name = "미키";

        tom.PlaySound();
        jerry.PlaySound();
    }


    // 변수는 tom과 jerry 두개지만
    // 두 변수가 참조값을 통해 가리키는 Animal 오브젝트는 하나뿐
    // jerry를 통해 Animal 오브젝트를 수정하는 것은 tom을 통해 Animal 오브젝트를 수정하는 것과 같은 의미
    // -> 참조타입(클래스타입변수) <-> 값타입(내장변수)
}
