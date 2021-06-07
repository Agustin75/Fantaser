using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shrine : MonoBehaviour
{
	[SerializeField]
	private Image background, generateResourceButton;

	[SerializeField]
	private Text title, levelText, currLevelGains, nextLevelGains, mainResourceAmount, mainResource;
	[SerializeField]
	private Button levelUpButton;

	private Resource resourceToIncrease;
	private IntArrayVariable gainsPerLevel;
	private ShrineValues currShrineValues;
	private ShrineButton shrineOpened;
	private int currLevel;
	private int currGain;

	// Start is called before the first frame update
	void Start()
	{

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void GainResource()
	{
		resourceToIncrease.AddResource(currGain);

		mainResourceAmount.text = resourceToIncrease.GetCurrAmount().ToString();
	}

	public void LevelUp()
	{
		// TODO: Remove the Level Up cost before reaching this function
		currLevel++;

		SetShrineLevel(currLevel);
	}

	public void OpenShrine(ShrineButton _shrineOpened)
	{
		shrineOpened = _shrineOpened;
		currShrineValues = shrineOpened.GetShrineValues();

		currLevel = currShrineValues.GetShrineLevel();

		// Set Shrine title based on Shrine's Type (Elemental, Clear, Energy)
		title.text = currShrineValues.GetShrineType() + " Shrine";

		resourceToIncrease = currShrineValues.GetMainResource();
		background.color = currShrineValues.backgroundColor;
		generateResourceButton.color = currShrineValues.buttonColor;
		gainsPerLevel = currShrineValues.gainsPerLevel;
		mainResource.text = currShrineValues.GetMainResource().name;
		mainResourceAmount.text = resourceToIncrease.GetCurrAmount().ToString();

		SetShrineLevel(currLevel);

		// Make the Level Up button interactable only if the Shrine isn't max Level yet
		levelUpButton.interactable = currLevel < currShrineValues.GetShrineMaxLevel();

		gameObject.SetActive(true);
	}

	public void CloseShrine()
	{
		currShrineValues.SetShrineLevel(currLevel);
		shrineOpened.UpdateLevel();
		gameObject.SetActive(false);
	}

	///////////////////////////////////
	// Helpers
	///////////////////////////////////
	// Updates the information for the Shrine based on the new Level
	private void SetShrineLevel(int _level)
	{
		// Update the amount of Essence the Shrine gives per click
		currGain = gainsPerLevel.GetArrayElement(_level - 1);
		levelText.text = "Level " + _level.ToString();
		currLevelGains.text = "+" + currGain.ToString();
		switch (currShrineValues.GetShrineType())
		{
			case "Clear":
				currLevelGains.text += " Shards";
				break;
			case "Energy":
				currLevelGains.text += " Energy";
				break;
			default:
				currLevelGains.text += " Essence";
				break;
		}

		if (_level != gainsPerLevel.GetArrayLength())
			nextLevelGains.text = "+" + gainsPerLevel.GetArrayElement(_level);
		else
		{
			nextLevelGains.text = "---";
			// TODO: Replace this to a whole message saying "Max Level" on the "Level Up Info" tab of the Shrine
			levelUpButton.interactable = false;
		}
	}
}
