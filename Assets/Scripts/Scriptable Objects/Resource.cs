using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Resource")]
public class Resource : ScriptableObject
{
	[SerializeField]
	private IntVariable playerLevel;
	[SerializeField]
	private IntArrayVariable resourceCapacity;
	// TODO: Add reference to storage amount here? Will be a ScriptableObject that hold the base and total capacity for the current level, and will change only when 
	//   the appropriate boost changes, so I don't need to do the boost multiplication every time I add a resource

	[Header("Boosts Info")]
	[SerializeField]
	private FloatVariable elementalBoost;
	[SerializeField]
	private FloatVariable genericBoost;

	// DEBUG: public for Debug only, change back to private after
	private int currAmount = 0;

	public void AddResource(int _amount)
	{
		if (elementalBoost)
			currAmount = Mathf.RoundToInt(Mathf.Min(currAmount + _amount, resourceCapacity.GetArrayElement(playerLevel - 1) * elementalBoost * genericBoost));
		else
			currAmount = Mathf.RoundToInt(Mathf.Min(currAmount + _amount, resourceCapacity.GetArrayElement(playerLevel - 1) * genericBoost));
	}

	public void SubstractResource(int _amount)
	{
		if (_amount > currAmount)
			return;

		currAmount -= _amount;
	}

	public int GetCurrAmount()
	{
		return currAmount;
	}
}
