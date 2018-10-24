using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	public enum swipeDirection
	{
		None=0,
		Left=1,
		Right=2,
		Up=4,
		Down=8,

		LeftDown=9,
		LeftUp=5,

		RightDown=10,
		RightUp=6
	}
public class swipemanager : MonoBehaviour {



	private static swipemanager instance;

	public static swipemanager Instance{get{return instance;}}
	public swipeDirection Direction{set;get;}
	private Vector3 touchPosition;
	private float swipeResistanceX=50.0f;
	private float swipeResistanceY=100.0f;
	void Start () {
		instance=this;
	}

	
	// Update is called once per frame
	void Update () {

		Direction = swipeDirection.None;
		if(Input.GetMouseButtonDown(0))
		{
			touchPosition=Input.mousePosition;
		}	

		if(Input.GetMouseButtonUp(0))
		{
			Vector2 deltaSwipe=	touchPosition-Input.mousePosition;
			if(Mathf.Abs(deltaSwipe.x)>swipeResistanceX)
			{
				//swipe on the x axis
				Direction |=(deltaSwipe.x<0)? swipeDirection.Right : swipeDirection.Left;
			}
			if(Mathf.Abs(deltaSwipe.y)>swipeResistanceY)
			{
				Direction |=(deltaSwipe.y<0)? swipeDirection.Up : swipeDirection.Down;
			}
			


			
		}
	}
	public bool IsSwiping(swipeDirection dir)
	{
		return (dir==Direction);
	}
}
