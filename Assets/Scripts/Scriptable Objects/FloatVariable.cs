using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Float")]
public class FloatVariable : ScriptableObject
{
	[SerializeField]
	private float value;

	public void AddAmount(float _amount)
	{
		value += _amount;
	}

	public void SetAmount(float _amount)
	{
		value = _amount;
	}

	public static implicit operator float(FloatVariable reference)
	{
		return reference.value;
	}
}
