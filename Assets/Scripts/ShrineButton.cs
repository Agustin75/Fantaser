using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShrineButton : MonoBehaviour
{
	[SerializeField]
	private Text shrineLevel;
	[SerializeField]
	private ShrineValues shrineValues;

    // Start is called before the first frame update
    void Start()
    {
		UpdateLevel();
	}

	public void UpdateLevel()
	{
		shrineLevel.text = "Level " + shrineValues.GetShrineLevel().ToString();
	}

	public ShrineValues GetShrineValues()
	{
		return shrineValues;
	}
}
