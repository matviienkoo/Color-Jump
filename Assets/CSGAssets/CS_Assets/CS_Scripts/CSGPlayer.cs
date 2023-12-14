using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using ColorSwitchGame.Types;

namespace ColorSwitchGame
{
	/// <summary>
	/// This script defines a player, which 
	/// </summary>
	public class CSGPlayer:MonoBehaviour 
	{
		// Various variables we will access often during the game, so we cache them
		internal Transform thisTransform;
		static CSGGameController gameController;
		internal CSGShop shopObject;
		internal Rigidbody2D rigidBody;
		internal Transform cameraObject;

		[Tooltip("The index of the color of this object. It corresponds to the color list defined in the gamecontroller ( 0 is the first color, 1 is the seconds color, etc)")]
		public int colorIndex = 0;

		[Tooltip("The object that will be colored when this player touches a color ball")]
		public Transform coloredObject;

		[Tooltip("How high this player can jump")]
		public float jumpPower = 10;

		// The player is dead now. When dead, the player can't move.
		internal bool isDead = false;
		public GameObject DeadObject;

		[Tooltip("The effect that is created at the location of this object when it is destroyed")]
		public Transform deathEffect;

		[Tooltip("Various sounds that play when the enemy touches the target, or when it gets hurt")]
		public AudioClip soundJump;
		public string soundSourceTag = "Sound";
		internal GameObject soundSource;

		// Use this for initialization
		void Start() 
		{
			thisTransform = transform;

			// Register the game controller for easier access
			if ( gameController == null )    gameController = (CSGGameController) FindObjectOfType(typeof(CSGGameController));

			// Register the rigidbody for easier access
			if ( GetComponent<Rigidbody2D>() )    rigidBody = GetComponent<Rigidbody2D>();

			// Register the camera for easier access
			if ( Camera.main.transform )    cameraObject = Camera.main.transform;

			//Assign the sound source for easier access
			if ( GameObject.FindGameObjectWithTag(soundSourceTag) )    soundSource = GameObject.FindGameObjectWithTag(soundSourceTag);

			// Check if we have a shop in this level and get the current player sprite from it
			if ( shopObject == null && FindObjectOfType(typeof(CSGShop)) )    
			{
				shopObject = (CSGShop) FindObjectOfType(typeof(CSGShop));

				coloredObject.GetComponent<SpriteRenderer>().sprite = shopObject.playerBalls[PlayerPrefs.GetInt("PlayerIndex", 0)].icon;
			}

			// Set the current color of the object, based on the index
			SetColor(0);
		}

		void Update() 
		{
			// Set the local scale based on the movement speed of the player. This gives a bouncy effect to the player object, like a squishy ball.
			if ( coloredObject )    coloredObject.parent.localScale = new Vector2( 1 - rigidBody.velocity.y * 0.05f, 1 + rigidBody.velocity.y * 0.05f);
		}
		void LateUpdate()
		{
			// Make the camera follow the position of the player
			if ( thisTransform.position.y > cameraObject.position.y )    cameraObject.position = new Vector3( cameraObject.position.x, thisTransform.position.y, cameraObject.position.z);
		}

		void Jump()
		{
			// Add to the vertical velocity of the object
			rigidBody.velocity = Vector2.up * jumpPower;

			// If there is a sound source and audio to play, play the sound from the audio source
			if ( soundSource && soundJump )    soundSource.GetComponent<AudioSource>().PlayOneShot(soundJump);
		}

		public void NextColor()
		{
			ChangeColor(1);
		}

		public void ChangeColor( int changeValue )
		{
			// Loop through the color list
			if ( colorIndex < gameController.colorList.Length - 1 )    colorIndex++;
			else    colorIndex = 0;
			
			// Set the color of the object based on the index
			SetColor(colorIndex);
		}

		public void RandomColor( int[] possibleValues )
		{
			// Choose a random value from the list of possible color indexes
			int randomColorIndex = Mathf.FloorToInt(Random.Range(0, possibleValues.Length));

			// If the new color is the same as the old one, go to the next color in the list
			if ( colorIndex == possibleValues[randomColorIndex] )
			{
				if ( randomColorIndex < possibleValues.Length - 1 )    randomColorIndex++;
				else    randomColorIndex = 0;
			}

			SetColor(possibleValues[randomColorIndex]);
		}

		public void SetColor( int setValue )
		{
			colorIndex = setValue;
			
			// Assign the color of this block from the list of colors in the gamecontroller
			if ( setValue < gameController.colorList.Length )    coloredObject.GetComponent<SpriteRenderer>().color = gameController.colorList[colorIndex];
		}

		public void Die()
		{
			if ( isDead == false )
			{
				isDead = true;

				GameObject.FindGameObjectWithTag("GameController").SendMessage("GameOver", 0.5f);

				// If there is a death effect, create it at the position of the player
				if( deathEffect )    Instantiate(deathEffect, transform.position, transform.rotation);

				// Remove the object from the game
				DeadObject.SetActive(true);
				Destroy(this.gameObject); 
			}
		}
	}
}
