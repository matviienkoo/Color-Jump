using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using ColorSwitchGame.Types;
using ColorSwitchGame;

namespace ColorSwitchGame
{
	/// <summary>
	/// This script defines a block, which can be touched by the player. If the player is the same color as the block, it passes through. If not, it dies.
	/// </summary>
	//[ExecuteInEditMode]
	public class CSGShop:MonoBehaviour
	{
		[Tooltip("How much money we have left")]
		public float moneyLeft = 0;
		public Text moneyText;

		[Tooltip("The default player ball button which all other player balls are duplicated from and displayed in the shop grid")]
		public RectTransform defaultButton;
		
		[Tooltip("A list of player balls you can unlock with gems")]
		public Unlockable[] playerBalls;

		// The currently selected unlockable
		internal RectTransform currentSelection;

		// The index number of the current player
		internal int playerIndex;
		
		[Tooltip("Animations for unlocking and errors in the unlockable")]
		public AnimationClip selectAnimation;
		public AnimationClip unlockAnimation;
		public AnimationClip errorAnimation;

		[Tooltip("The sound that plays when you lose the game")]
		public AudioClip soundSelect;
		public AudioClip soundUnlock;
		public AudioClip soundError;
		public string soundSourceTag = "Sound";
		internal GameObject soundSource;
		
		// A general use index
		internal int index;
		
		/// <summary>
		/// Start is only called once in the lifetime of the behaviour.
		/// The difference between Awake and Start is that Start is only called if the script instance is enabled.
		/// This allows you to delay any initialization code, until it is really needed.
		/// Awake is always called before any Start functions.
		/// This allows you to order initialization of scripts
		/// </summary>
		void Start()
		{
			//Assign the sound source for easier access
			if ( GameObject.FindGameObjectWithTag(soundSourceTag) )    soundSource = GameObject.FindGameObjectWithTag(soundSourceTag);
			
			// Get the saved money value
			moneyLeft = PlayerPrefs.GetFloat("Money", moneyLeft);
			PlayerPrefs.SetFloat("Money", moneyLeft);
			
			// Set the text of the money
			if ( moneyText )    moneyText.text = moneyLeft.ToString();
			
			// If we have a default button assigned and we have a list of player balls, duplicate the button and display all the balls in the shop grid
			if ( defaultButton && playerBalls.Length > 0 )
			{
				// Create the shop buttons by duplicating the default one
				for ( index = 0 ; index < playerBalls.Length ; index++ )
				{
					// Create a new button
					RectTransform newButton = Instantiate( defaultButton ) as RectTransform;
					
					// Put it inside the button grid
					newButton.transform.SetParent(defaultButton.transform.parent);
					
					// Set the scale to the default button's scale
					newButton.localScale = defaultButton.localScale;
					
					// Set the position to the default button's position
					newButton.position = defaultButton.position;
					
					// Assign the button object for this shop item
					playerBalls[index].buttonObject = newButton;
				}
				
				// Calculate the size of the shop scroller so that it can fit all the items. This depends on the height of the default button multiplied by the number of buttons we have, then divided by the number of columns in the grid
				defaultButton.transform.parent.GetComponent<RectTransform>().sizeDelta = Vector2.up * (defaultButton.transform.parent.GetComponent<GridLayoutGroup>().cellSize.y * Mathf.FloorToInt((playerBalls.Length+1)/defaultButton.transform.parent.GetComponent<GridLayoutGroup>().constraintCount));
				
				// Deactivate the default button as we don't need it anymore
				defaultButton.gameObject.SetActive(false);
			}
			
			// Update the list of unlockables in the shop ( name, icon, price, lock state )
			UpdateUnlockables(playerBalls);
			
			// Don't destroy this shop when a level is loaded. This is done to allow the player in the level to be updated with our player choice from the shop.
			DontDestroyOnLoad(gameObject);
		}
		
		/// <summary>
		/// Updates the unlockables, duplicating as many tabs as needed, and filling them with info (name,icon,price,unlock state)
		/// </summary>
		/// <param name="unlockables">Unlockables.</param>
		void UpdateUnlockables( Unlockable[] unlockables )
		{
			// Go through all the unlockable tabs, update their lock state, and display the icon or price accordingly
			for ( index = 0 ; index < unlockables.Length ; index++ )
			{
				// Check the lock state; 0 means locked, 1 means unlocked
				unlockables[index].lockState = PlayerPrefs.GetInt(unlockables[index].name, unlockables[index].lockState);
				
				// Set the index of the unlockable based on the index of the object
				unlockables[index].index = index;
				
				// Set the icon
				unlockables[index].buttonObject.Find("Icon").GetComponent<Image>().sprite = unlockables[index].icon;
				
				// If the state is locked
				if ( unlockables[index].lockState == 0 )
				{
					// Hide the icon
					unlockables[index].buttonObject.Find("Icon").gameObject.SetActive(false);
					
					// Show the price
					unlockables[index].buttonObject.Find("Text").GetComponent<Text>().text = unlockables[index].price.ToString();
				}
				else
				{
					// Show the icon object
					unlockables[index].buttonObject.Find("Icon").gameObject.SetActive(true);
					
					// Hide the price
					unlockables[index].buttonObject.Find("Text").GetComponent<Text>().text = "";
					
				}
			}
		}
		
		/// <summary>
		/// Tries to unlock or select a shop item
		/// </summary>
		public void TryUnlock()
		{
			// Check which button from the shop we have clicked
			currentSelection = EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>();

			// Go through all the player buttons and check the index of the button we pressed
			for ( index = 0 ; index < playerBalls.Length ; index++ )
			{
				// Check the status of the button we pressed ( unlocked, or can be bought, or not enough money )
				if ( currentSelection == playerBalls[index].buttonObject && currentSelection.GetComponent<Animation>().isPlaying == false )
				{
					// If the we already unlocked this item, select it as the player
					if ( playerBalls[index].lockState > 0 )
					{
						// If there is an animation, play it
						if ( selectAnimation )    
						{
							// Stop the previous animation
							playerBalls[index].buttonObject.GetComponent<Animation>().Stop();

							// Play the select animation
							playerBalls[index].buttonObject.GetComponent<Animation>().Play(selectAnimation.name);
						}

						// Save the index of the current player, so that the player object can be updated in game
						PlayerPrefs.SetInt("PlayerIndex", index);
						
						//If there is a source and a sound, play it from the source
						if ( soundSource && soundSelect )    soundSource.GetComponent<AudioSource>().PlayOneShot(soundSelect);
					}
					else if ( moneyLeft - playerBalls[index].price > 0 ) // If we have enough money, buy and unlock the item
					{
						// If there is an animation, play it
						if ( unlockAnimation )    playerBalls[index].buttonObject.GetComponent<Animation>().Play(unlockAnimation.name);

						// Save the index of the current player, so that the player object can be updated in game
						PlayerPrefs.SetInt("PlayerIndex", index);

						// Show the icon of the player button
						playerBalls[index].buttonObject.Find("Icon").gameObject.SetActive(true);

						// Set the item to "unklocked"
						playerBalls[index].lockState = 1;

						// Save the unlock state of the item
						PlayerPrefs.SetInt(playerBalls[index].name, 1);
						
						// Reduce the price from the money we have
						moneyLeft -= playerBalls[index].price;

						// Save the money we have left
						PlayerPrefs.SetFloat("Money", moneyLeft);

						// Update the text of the money we have
						if ( moneyText )    moneyText.text = moneyLeft.ToString();

						//If there is a source and a sound, play it from the source
						if ( soundSource && soundUnlock )    soundSource.GetComponent<AudioSource>().PlayOneShot(soundUnlock);
					}
					else // If we don't have enough money, show error
					{
						// If there is an animation, play it
						if ( errorAnimation )    playerBalls[index].buttonObject.GetComponent<Animation>().Play(errorAnimation.name);
						
						//If there is a source and a sound, play it from the source
						if ( soundSource && soundError )    soundSource.GetComponent<AudioSource>().PlayOneShot(soundError);
					}
				}
			}
		}
	}
}