using System.Collections;
using UnityEngine;
using ColorSwitchGame.Types;
using ColorSwitchGame;

namespace ColorSwitchGame
{
	/// <summary>
	/// This script defines an item, which spawns within the game area and can be picked up by the player. 
	/// </summary>
	public class CSGColorBall:MonoBehaviour
	{
		//The index of the color of this object. It corresponds to the color list defined in the gamecontroller ( 0 is the first color, 1 is the seconds coloe, etc)
		internal int colorIndex = 0;
		public int ColorBall_sound;

		[Tooltip("A list of possible indexes for the colors. It corresponds to the color list defined in the gamecontroller ( 0 is the first color, 1 is the seconds coloe, etc). If the player touches this color ball it will change into one of the colors in this list")]
		public int[] possibleColors;

		[Tooltip("How many seconds to wait before switching to the next color")]
		public float switchColorTime = 0.3f;

		// Various variables we will access often during the game, so we cache them
		static CSGGameController gameController;
		internal int index = 0;

		[Tooltip("The tag of the object that this enemy can touch")]
		public string touchTargetTag = "Player";

		[Tooltip("The effect that is created at the location of this item when it is picked up")]
		public Transform pickupEffect;

		// The object has been touched, it can't be touched again
		internal bool isTouched = false;
	
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
			if ( gameController == null )    gameController = (CSGGameController) FindObjectOfType(typeof(CSGGameController));

			// Set the current color of the object, based on the index
			SetColor(colorIndex);

			// Go to the next color every few moments
			InvokeRepeating("NextColor", 2, switchColorTime);
		}

		/// <summary>
		/// Goes to the next color from the list of possible colors
		/// </summary>
		public void NextColor()
		{
			ChangeColor(1);
		}

		/// <summary>
		/// Changes the color based on the list of possible colors
		/// </summary>
		/// <param name="changeValue">Change value.</param>
		public void ChangeColor( int changeValue )
		{
			// Loop through the color list
			if ( index < possibleColors.Length - 1 )    index++;
			else    index = 0;

			// Assign the current color index. This corresponds to the list of colors in the gamecontroller
			colorIndex = possibleColors[index];

			// Set the color of the object based on the index
			SetColor(colorIndex);
		}

		/// <summary>
		/// Sets the color of the object based on the index. This corresponds to the list of colors in the gamecontroller
		/// </summary>
		/// <param name="setValue">Set value.</param>
		public void SetColor( int setValue )
		{
			// Assign the color of this object from the list of colors in the gamecontroller
			if ( setValue < gameController.colorList.Length )    GetComponent<SpriteRenderer>().color = gameController.colorList[setValue];
		}
	
		/// <summary>
		/// Is executed when this object touches another object with a trigger collider
		/// </summary>
		/// <param name="other"><see cref="Collider"/></param>
		void OnTriggerEnter2D(Collider2D other)
		{	
			// Check if the object that was touched has the correct tag
			if( other.tag == touchTargetTag && isTouched == false )
			{
				// The object has been touched, it can't be touched again
				isTouched = true;
				ColorBall_sound += 1;
				PlayerPrefs.SetInt("ColorBall_sound",ColorBall_sound);

				// Send the list of colors to the target, so that it can be turned into one of them randomly
				other.SendMessage("RandomColor", possibleColors);

				// Deactive the ball
				gameObject.SetActive(false);

				// Create a pickup effect, if we have one assigned
				if( pickupEffect )    Instantiate(pickupEffect, transform.position, Quaternion.identity);
			}
		}

		void Update ()
		{
			ColorBall_sound = PlayerPrefs.GetInt("ColorBall_sound");
		}
	}
}