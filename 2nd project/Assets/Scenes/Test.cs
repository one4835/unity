using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
	//2.7.4 인수가 있는 매서드
	void Callname(string name)
	{
		Debug.Log("Hello " + name);
	}
    void Start()
    {
		Callname("Tom");
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
