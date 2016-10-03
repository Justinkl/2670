using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RecycleComponent : MonoBehaviour 
{

	private Vector3 newLocation;
	/*private int i = 0;
	public List<Recycler> recycleAbleList;

	void Start()
	{
		recycleAbleList = new List<Recycler>();
		Recycler.RecycleAction += RecycleActionHandler;
	}

	private void RecycleActionHandler(Recycler obj)
	{
		recycleAbleList.Add(obj);
	}

*/
	void OnTriggerEnter ()
	{
		newLocation.z = StaticVar.nextSectionPos;
		transform.localPosition = newLocation; //---->recycleAbleList[i].cube.position = newLocation;
		StaticVar.nextSectionPos += StaticVar.distance;

		//if(i == recycleAbleList.Count-1)
		//{i++;
		//}
	}
}