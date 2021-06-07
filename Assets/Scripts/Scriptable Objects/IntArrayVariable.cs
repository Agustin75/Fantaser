using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Int Array")]
public class IntArrayVariable : ScriptableObject
{
	[SerializeField]
	private int[] array;

	public int GetArrayElement(int _id)
	{
		return array[_id];
	}

	public int GetArrayLength()
	{
		return array.Length;
	}
}
