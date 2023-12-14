using UnityEngine;
using UnityEngine.UI;
using System;

namespace ColorSwitchGame.Types
{
	/// <summary>
	/// This script defines an unlockable item which has a name, icon, price, and lock state. Each item is registered in the PlayerPrefs by its name and lock state
	/// </summary>
	[Serializable]
	public class Unlockable
	{
		[Tooltip("The tab object which is used to display the name, icon, price, and unlock state of the unlockable")]
		internal RectTransform buttonObject;

		[Tooltip("The name of the unlockable item")]
		public string name;

		[Tooltip("The icon of the unlockable item")]
		public Sprite icon;

		[Tooltip("The price needed to unlock this item")]
		public float price = 0;

		[Tooltip("The lock state of this unlockable. 0 is locked, 1 is unlocked")]
		public int lockState = 0;

		// The index of this unlockable in a list
		internal int index;
	}
}