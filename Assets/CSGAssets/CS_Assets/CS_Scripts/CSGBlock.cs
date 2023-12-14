using System.Collections;
using UnityEngine;
using ColorSwitchGame.Types;
using ColorSwitchGame;

namespace ColorSwitchGame
{
	[ExecuteInEditMode]
	public class CSGBlock:MonoBehaviour
	{
		internal Transform thisTransform;
		static CSGGameController GameController;
		static CSGPlayer PlayerObject;

		[Header("Shape color")]
		public int colorIndex = 0;
		public bool colorChange;

		[Header("Safe bonus")]
		public int Safe_Bonus;
		public int BonusEnd;

		[Header("Tag")]
		public string touchTargetTag = "Player";

		void Start()
		{
			thisTransform = transform;

			// Register the game controller for easier access
			if ( GameController == null )    GameController = (CSGGameController) FindObjectOfType(typeof(CSGGameController));
			if ( PlayerObject == null )    PlayerObject = (CSGPlayer) FindObjectOfType(typeof(CSGPlayer));

			// Assign the color of this block from the list of colors in the gamecontroller
			if ( colorIndex < GameController.colorList.Length )    GetComponent<SpriteRenderer>().color = GameController.colorList[colorIndex];

			// Сhange color
			if (colorChange == true) StartCoroutine(IEnumeratorColor());
		}

		IEnumerator IEnumeratorColor ()
    	{
    		yield return new WaitForSeconds(1f);
    		if (colorIndex == 3) colorIndex = 0;
    		else
    		colorIndex += 1;

    		if (GameController && colorIndex < GameController.colorList.Length) GetComponent<SpriteRenderer>().color = GameController.colorList[colorIndex];
    		StartCoroutine(IEnumeratorColor());
    	}

        private void OnValidate()
        {
            // Assign the color of this block from the list of colors in the gamecontroller
            if (GameController && colorIndex < GameController.colorList.Length) GetComponent<SpriteRenderer>().color = GameController.colorList[colorIndex];
        }

        void OnTriggerEnter2D(Collider2D other)
		{	
			Safe_Bonus = PlayerPrefs.GetInt("Safe_Bonus");

			// Check if the object that was touched has the correct tag
			if (Safe_Bonus == 1){
			if( other.tag == touchTargetTag )
			{	
				if ( PlayerObject.colorIndex != colorIndex ) 
				{
					BonusEnd = 1;
					PlayerPrefs.SetInt("BonusEnd", BonusEnd);
				}
			}
			}

			if (Safe_Bonus == 0){
			if( other.tag == touchTargetTag )
			{
				// If the color of the player does not match the color of the block, kill it
				if ( PlayerObject.colorIndex != colorIndex )    other.SendMessage("Die", transform);
			}
			}
		}

		void OnDrawGizmos()
		{
			// Register the game controller for easier access
			if ( GameController == null )    GameController = (CSGGameController) FindObjectOfType(typeof(CSGGameController));
		}
	}
}