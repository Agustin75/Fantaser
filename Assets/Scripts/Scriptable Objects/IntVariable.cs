using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Int")]
public class IntVariable : ScriptableObject
{
	[SerializeField]
	private int value;

	public void AddAmount(int _amount)
	{
		value += _amount;
	}

	public void SetAmount(int _amount)
	{
		value = _amount;
	}

	public static implicit operator int(IntVariable reference)
	{
		return reference.value;
	}
}
