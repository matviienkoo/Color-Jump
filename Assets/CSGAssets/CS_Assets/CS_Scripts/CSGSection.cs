using UnityEngine;
using System;

namespace ColorSwitchGame
{
	/// <summary>
	/// This class defines a section, which is spawned along the game area with a gap between each two sections
	/// </summary>
	public class CSGSection:MonoBehaviour
	{
		internal GameObject gameController;

		[Tooltip("The gap between this section and the one after it. Set this based on the height of the section you built")]
		public float sectionGap = 5;

		/// <summary>
		/// Start is only called once in the lifetime of the behaviour.
		/// The difference between Awake and Start is that Start is only called if the script instance is enabled.
		/// This allows you to delay any initialization code, until it is really needed.
		/// Awake is always called before any Start functions.
		/// This allows you to order initialization of scripts
		/// </summary>
		void Start()
		{
			// Register the game controller for easier access
			gameController = GameObject.FindGameObjectWithTag("GameController");

			// Set the gap to the next section
			gameController.SendMessage("ChangeGap", sectionGap);
		}

		void OnDrawGizmos()
		{
			Gizmos.color = Color.red;
			
			// The gap line that shows where the next section will be created, relative to this section
			Gizmos.DrawLine( new Vector2(-10, transform.position.y + sectionGap), new Vector2(10, transform.position.y + sectionGap));
		}
	}
}