using System.Collections;
using System.Collections.Generic;
using UnityEngine;
























//Vector 클레스 끼리 뺄셈하기
/*public class Test : MonoBehaviour
{
	void Start()
	{
		Vector2 startPos = new Vector2(2.0f,1.0f);
		Vector2 endPos = new Vector2(8.0f,5.0f);
		Vector2 dir = endPos - startPos;
		Debug.Log(dir);

		float len = dir.magnitude;
		Debug.Log(len);
	}
}
//Player 클래스 구현하기
/*public class Player
{
	private int hp = 100;
	private int power = 50;

	public void Attack()
	{
		Debug.Log(this.power + "데미지를 입혔다");
	}

	public void Damage(int damage)
	{
		this.hp -= damage;
		Debug.Log(damage + "데미지를 입었다");
	}

	public class Test : MonoBehaviour
{
	void Start()
	{
		Player myPlayer = new Player();
		myPlayer.Attack();
		myPlayer.Damage(30);
	}

//값을 두 개 받아 합계를 반환하는 메서드
	int ADD(int a,int b)
	{
		int c = a +b;
		return c;
	}

	void Start()
	{
		int answer;
		answer =ADD(2, 3);
		Debug.Log(answer);
	}
	{/*2.7.4 인수가 있는 매서드
    void Start()
    {
		Start is called before the first frame update
		Callname("Tom");
	}

	 Update is called once per frame
    void Update()
    {
        
    }

	void Callname(string name)
	{
		Debug.Log("Hello " + name);
	}*/

