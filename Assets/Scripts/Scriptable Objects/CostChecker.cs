//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[CreateAssetMenu(menuName = "Game Data/Cost Checker")]
//public class CostChecker : ScriptableObject
//{
//	[System.Serializable]
//	public struct ResourceCost
//	{
//		public Resource resourceNeeded;
//		public int amountNeeded;
//	}

//	[SerializeField]
//	private List<ResourceCost> costs;

//	public bool HasEnoughResources()
//	{
//		foreach (ResourceCost resourceCost in costs)
//		{
//			if (resourceCost.resourceNeeded.GetCurrAmount() < resourceCost.amountNeeded)
//				return false;
//		}

//		return true;
//	}

//	public void DeductCost()
//	{
//		foreach (ResourceCost resourceCost in costs)
//		{
//			resourceCost.resourceNeeded.SubstractResource(resourceCost.amountNeeded);
//		}
//	}
//}
