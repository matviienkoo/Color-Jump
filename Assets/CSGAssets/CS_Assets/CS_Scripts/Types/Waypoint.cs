using UnityEngine;
using System;

namespace ColorSwitchGame.Types
{
	/// <summary>
	/// This script defines a waypoint in the game. An object can move through waypoints, stopping at each one for a limited time.
	/// </summary>
	[Serializable]
	public class Waypoint
	{
		[Tooltip("A point you can move to")]
		public Vector2 waypoint;

		[Tooltip("How many seconds to wait at this point")]
		public float waitTime = 0;
	}
}