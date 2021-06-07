//using System;
//using System.Collections.Generic;
//using UnityEngine;

//[CreateAssetMenu(menuName = "Game Data/Level Up")]
//public class LevelUp : ScriptableObject
//{
//	public Resource mainResource;
//	public List<Resource> extraResources;

//	[Serializable]
//	public struct LevelUpCost
//	{
//		public int mainResourceCost;
//		// First int indicates which resource is being checked for (It alings with extraResources List)
//		// Second int indicates how much of that resource is needed
//		[SerializeField]
//		public KeyValuePair<int, int> extraResourcesCosts;
//	}

//	public List<LevelUpCost> levelUps;
//}
