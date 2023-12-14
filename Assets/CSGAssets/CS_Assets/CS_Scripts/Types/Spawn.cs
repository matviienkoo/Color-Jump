using UnityEngine;
using System;

namespace ColorSwitchGame.Types
{
	/// <summary>
	/// This class defines an object that can be spawned, and its chance of apperance.
	/// </summary>
	[Serializable]
	public class Spawn
	{
		[Tooltip("The object we spawn")]
		public Transform spawnObject;

		[Tooltip("How often the object appears. The minimum value is 1")]
		public int spawnChance = 1;
	}
}