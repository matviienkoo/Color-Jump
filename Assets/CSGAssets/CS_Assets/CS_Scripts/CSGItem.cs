using System.Collections;
using UnityEngine;
using ColorSwitchGame.Types;
using ColorSwitchGame;
	
	public class CSGItem:MonoBehaviour
	{
		[Header("Gold Gems")]
	    [SerializeField] int Gold;
	    [SerializeField] int Gold_GameOver;
	    [SerializeField] int Gold_Analitics;
	    [SerializeField] int Gold_Remove;
	    [SerializeField] int Gold_sound;
	    [SerializeField] int Ten_Gold_Animation;
	    
	    [SerializeField] int Gems;

    	public int ResumeInt;
		internal Transform thisTransform;
		internal GameObject GameController;

		[Tooltip("The tag of the object that this enemy can touch")]
		public string touchTargetTag = "Player";

		[Tooltip("A list of functions that run when this enemy touches the target")]
		public TouchFunction[] touchFunctions;

		[Tooltip("The effect that is created at the location of this item when it is picked up")]
		public Transform pickupEffect;

		[Tooltip("Should the object be removed when picked up?")]
		public bool removeOnPickup = true;
		public bool boolGems;
		internal bool isPickedUp = false;

		[SerializeField] int coinValue;

		// The enemy is still spawning, it won't move until it finises spawning
		internal bool isSpawning = true;

		void Start()
		{
			thisTransform = transform;

			// Register the game controller for easier access
			GameController = GameObject.FindGameObjectWithTag("GameController");
		}
	
		void OnTriggerEnter2D(Collider2D other)
		{	
			// Check if the object that was touched has the correct tag
			if( isPickedUp == false && other.tag == touchTargetTag )
			{
				isPickedUp = true;

				// Go through the list of functions and runs them on the correct targets
				foreach( var touchFunction in touchFunctions )
				{
					// Check that we have a target tag and function name before running
					if( touchFunction.functionName != string.Empty )
					{
						// If the targetTag is "TouchTarget", it means that we apply the function on the object that touched this target
						if ( touchFunction.targetTag == "TouchTarget" )
						{
							// Run the function
							other.SendMessage(touchFunction.functionName, transform);
						}
					}
				}

				// Create a pickup effect, if we have one assigned
				if( pickupEffect )    Instantiate(pickupEffect, transform.position, Quaternion.identity);

				// Remove the item
				if ( removeOnPickup ) 
				{	
					if (boolGems == false)
					{
						if (coinValue >= 10){
							Ten_Gold_Animation = 1;
						}

						if (ResumeInt == 0){
							Gold += coinValue;
							Gold_GameOver += coinValue;
							Gold_Analitics += coinValue;
							Gold_Remove += coinValue;
							Gold_sound += 1;
						}
						if (ResumeInt == 1){
							Gold += coinValue;
							Gold_Remove += coinValue;
							Gold_Analitics += coinValue;
							Gold_GameOver = Gold_Remove;
							Gold_sound += 1;
						}
					}
					
					if (boolGems == true)
					{
						Gems += coinValue;
						Gold_sound += 1;
					}

					PlayerPrefs.SetInt("Ten_Gold_Animation",Ten_Gold_Animation);
					PlayerPrefs.SetInt("Gold_Remove",Gold_Remove);
					PlayerPrefs.SetInt("Gold_sound",Gold_sound);
					PlayerPrefs.SetInt("Gold",Gold);
					PlayerPrefs.SetInt("Gems",Gems);
					PlayerPrefs.SetInt("Gold_GameOver",Gold_GameOver);
					PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);
					Destroy(gameObject);
				}  
			}
		}

		public void Update ()
		{
			Gold = PlayerPrefs.GetInt("Gold");
			Gems = PlayerPrefs.GetInt("Gems");
			Gold_GameOver = PlayerPrefs.GetInt("Gold_GameOver");
			Gold_Remove = PlayerPrefs.GetInt("Gold_Remove");
			Gold_Analitics = PlayerPrefs.GetInt("Gold_Analitics");
			Gold_sound = PlayerPrefs.GetInt("Gold_sound");
			ResumeInt = PlayerPrefs.GetInt("ResumeInt");
		}
	}
