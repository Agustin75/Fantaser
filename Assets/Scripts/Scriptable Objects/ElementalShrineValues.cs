using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Elemental Shrine Values")]
public class ElementalShrineValues : ShrineValues
{
	[Header("Elemental Resources")]
	public Elements shrineElement;

	[SerializeField]
	private ElementChooser elementalEssences;

	public override Resource GetMainResource()
	{
		return elementalEssences.GetElementalResource(shrineElement);
	}

	public override string GetShrineType()
	{
		return shrineElement.ToString();
	}
}
