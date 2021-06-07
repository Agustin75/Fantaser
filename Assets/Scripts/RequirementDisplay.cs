using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequirementDisplay : MonoBehaviour
{
	[SerializeField]
	private Color readyCheckmarkColor, notReadyCheckmarkColor, notReadyNumberColor;
	[SerializeField]
	private Text currentAmountText, requiredAmountText, checkmark, resourceName;
	[SerializeField]
	private Resource resourceToCheck;

	private int requiredAmount;

    // Start is called before the first frame update
    void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void SetNewRequirement(Resource _newResource, int _requirement)
	{
		resourceToCheck = _newResource;
		requiredAmount = _requirement;

		if (resourceToCheck)
		{
			resourceName.text = resourceToCheck.name;

			if (resourceToCheck.GetCurrAmount() >= requiredAmount)
			{
				currentAmountText.color = Color.white;
				checkmark.color = readyCheckmarkColor;
				checkmark.text = "=";
			}
			else
			{
				currentAmountText.color = notReadyNumberColor;
				checkmark.color = notReadyCheckmarkColor;
				checkmark.text = "X";
			}

			currentAmountText.text = resourceToCheck.GetCurrAmount().ToString();
			requiredAmountText.text = requiredAmount.ToString();
		}
		else
		{
			resourceName.text = "----------";
			currentAmountText.color = Color.white;
			checkmark.color = Color.white;
			checkmark.text = "-";
			currentAmountText.text = "------";
			requiredAmountText.text = "------";
		}
	}

	public void UpdateDisplay()
	{
		if (!resourceToCheck)
			return;

		if (resourceToCheck.GetCurrAmount() >= requiredAmount)
		{
			currentAmountText.color = Color.white;
			checkmark.color = readyCheckmarkColor;
			checkmark.text = "=";
		}
		else
		{
			currentAmountText.color = notReadyNumberColor;
			checkmark.color = notReadyCheckmarkColor;
			checkmark.text = "X";
		}

		currentAmountText.text = resourceToCheck.GetCurrAmount().ToString();
		requiredAmountText.text = requiredAmount.ToString();
	}
}
