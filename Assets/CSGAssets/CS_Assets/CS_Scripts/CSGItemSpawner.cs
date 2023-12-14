using UnityEngine;

namespace ColorSwitchGame
{
	/// <summary>
	/// This script spawns an item at the position of this object. It's used to allow us to edit one prefab instead of having to edit each object in each sections individually
	/// </summary>
	public class CSGItemSpawner:MonoBehaviour
	{
		[Tooltip("The item that will be spawned here. We use this method because now we can edit one item in the project and it will replace all the items in all sections without having to edit each one")]
		public Transform itemToSpawn;

		void Start()
		{
			// If we have an item assigned, spawn it at the position of this object
			if ( itemToSpawn )    Instantiate( itemToSpawn, transform.position, Quaternion.identity);
		}
	}
}