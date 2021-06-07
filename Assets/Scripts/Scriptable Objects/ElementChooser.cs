using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Element Chooser")]
public class ElementChooser : ScriptableObject
{
	[SerializeField]
	private List<Resource> elementalResource = new List<Resource>((int)Elements.NumElements);

	public Resource GetElementalResource(Elements _element)
	{
		return elementalResource[(int)_element];
	}
}
