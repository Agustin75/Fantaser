using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Shrine Values")]
public class ShrineValues : ScriptableObject
{
	[SerializeField]
	private string shrineType;

	[SerializeField]
	private Resource mainResource;

	public Color backgroundColor, buttonColor;

	[Header("Resource Info")]
	public IntArrayVariable gainsPerLevel;

	[Header("Shrine Info")]
	[SerializeField]
	private int shrineLevel;

	///////////////////////////////////
	// Accessors
	///////////////////////////////////
	public virtual Resource GetMainResource()
	{
		return mainResource;
	}

	public virtual string GetShrineType()
	{
		return shrineType;
	}

	public int GetShrineLevel()
	{
		return shrineLevel;
	}

	public int GetShrineMaxLevel()
	{
		return gainsPerLevel.GetArrayLength();
	}

	///////////////////////////////////
	// Mutators
	///////////////////////////////////
	public void SetShrineLevel(int _newLevel)
	{
		shrineLevel = _newLevel;
	}
}
