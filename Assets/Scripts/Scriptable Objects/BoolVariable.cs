using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Bool")]
public class BoolVariable : ScriptableObject
{
	[SerializeField]
	private bool value;

	public void SetValue(bool _value)
	{
		value = _value;
	}

	public static implicit operator bool(BoolVariable reference)
	{
		return reference.value;
	}
}
