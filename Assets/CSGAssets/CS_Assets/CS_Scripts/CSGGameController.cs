#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using ColorSwitchGame.Types;
using LootLocker.Requests;
using TMPro;

namespace ColorSwitchGame
{
	public class CSGGameController:MonoBehaviour 
	{
		[Header("LeaderBoard")]
		public string leaderboardKey;

		[Header("Player")]
		public Transform playerObject;
		public string jumpButton = "Fire1";
		public Color[] colorList;
		public bool randomizeColors = true;
		internal bool isEndless = true;

		[Header("Section")]
		public Transform SectionTransform;
		public GameObject ZeroSection;
		public GameObject FirstSection;
		public GameObject SecondSection;
		public GameObject ThirtSection;
		public GameObject FourSection;
		public GameObject FiveSection;
		public GameObject SixSection;
		public GameObject SevenSection;
		public GameObject EightSection;
		public GameObject NineSection;
		public GameObject TenSection;
		public GameObject ElevenSection;
		public GameObject TwelveSection;
		public GameObject ThirteenSection;
		public GameObject FourteenSection;
		public GameObject FiveteenSection;
		public GameObject SixteenSection;
		public GameObject SeventeenSection;
		public GameObject EighteenSection;
		public GameObject NineteenSection;
		public int CS_System;
		public int SectionResume;

		[Header("Section List")]
		public Spawn[] sections;
		internal Spawn[] sectionList;
		public Spawn[] sectionsHole;
		internal float nextSectionGap;

		[Header("Gold, Miles, Gems, Analitics")]
		public int Gold;
		public int Gems;
		public int intPos;
		public int intMileHole;
		public int MilesAnalitics;
		public TextMeshProUGUI Gold_Text;
		public TextMeshProUGUI Gems_Text;

		internal float highScore = 0;
		internal float scoreMultiplier = 1;

		[Header("Player, Theme, Character, Ground")]
		public GameObject selectedSkin;
		public GameObject selectedSkinTransparancy;
		public GameObject mainPlayer;
		private Sprite playerSprite;
		public int CharacterInt;
		public int GroundInt;
		public int ThemeInt;
		public int ThemeHoleInt;

		[Header("CreenField")]
		public GameObject CreenField_Camera; 
		public GameObject CreenField_AreaColider; 
		public GameObject CreenField_Music; 
		public GameObject CreenField_Ground; 

		[Header("Flower")]
		public GameObject Flowers_Camera; 
		public GameObject Flowers_AreaColider; 
		public GameObject Flowers_Music; 
		public GameObject Flowers_Ground; 

		[Header("Pyramid")]
		public GameObject Pyramids_Camera; 
		public GameObject Pyramids_AreaColider; 
		public GameObject Pyramids_Music; 
		public GameObject Pyramids_Ground; 

		[Header("Desert")]
		public GameObject Desert_Camera; 
		public GameObject Desert_AreaColider; 
		public GameObject Desert_Music; 
		public GameObject Desert_Ground; 

		[Header("Snow")]
		public GameObject Snow_Camera; 
		public GameObject Snow_AreaColider; 
		public GameObject Snow_Music; 
		public GameObject Snow_Ground; 

		[Header("Island")]
		public GameObject Island_Camera; 
		public GameObject Island_AreaColider; 
		public GameObject Island_Music; 
		public GameObject Island_Ground; 

		[Header("Volcano")]
		public GameObject Volcano_Camera; 
		public GameObject Volcano_AreaColider; 
		public GameObject Volcano_Music; 
		public GameObject Volcano_Ground; 

		[Header("NightSky")]
		public GameObject NightSky_Camera; 
		public GameObject NightSky_AreaColider; 
		public GameObject NightSky_Music; 
		public GameObject NightSky_Ground; 

		[Header("Autumn")]
		public GameObject Autumn_Camera; 
		public GameObject Autumn_AreaColider; 
		public GameObject Autumn_Music; 
		public GameObject Autumn_Ground; 

		[Header("Dinosaur")]
		public GameObject Dinosaur_Camera; 
		public GameObject Dinosaur_AreaColider; 
		public GameObject Dinosaur_Music; 
		public GameObject Dinosaur_Ground; 

		[Header("Aquarium")]
		public GameObject Aquarium_Camera; 
		public GameObject Aquarium_AreaColider; 
		public GameObject Aquarium_Music; 
		public GameObject Aquarium_Ground; 

		[Header("Space")]
		public GameObject Space_Camera; 
		public GameObject Space_AreaColider; 
		public GameObject Space_Music; 
		public GameObject Space_Ground; 

		[Header("Rain")]
		public GameObject Rain_Camera; 
		public GameObject Rain_AreaColider; 
		public GameObject Rain_Music; 
		public GameObject Rain_Ground; 

		[Header("Character")]
		public Sprite Ball_Skin;
		public Sprite Star_Skin;
		public Sprite Cupcake_Skin;
		public Sprite Cupcake_Skin_Transparency;
		public Sprite Heart_Skin;
		public Sprite Crab_Skin;
		public Sprite Balloon_Skin;
		public Sprite Ghost_Skin;
		public Sprite Squid_Skin;
		public Sprite Flame_Skin;
		public Sprite Strawberry_Skin;
		public Sprite Strawberry_Skin_Transparency;
		public Sprite Head_Skin;
		public Sprite Head_Skin_Transparency;
		public Sprite Slime_Skin;
		public Sprite Bunny_Skin;
		public Sprite Bunny_Skin_Transparency;
		public Sprite Mushroom_Skin;
		public Sprite Mushroom_Skin_Transparency;
		public Sprite IceCream_Skin;
		public Sprite IceCream_Skin_Transparency;
		public Sprite Bear_Skin;
		public Sprite Bear_Skin_Transparency;
		public Sprite Flower_Skin;
		public Sprite Flower_Skin_Transparency;
		public Sprite Jellyfish_Skin;
		public Sprite Jellyfish_Skin_Transparency;

		[Header("Game Over")]
		public GameObject NavigationPanel;
		public GameObject GameOverPanel;

		public int int_dead;
		internal bool  isGameOver = false;

		internal int index = 0;

		[Header("Ads System")]
		public int int_resume;
		public int NoAds;

		[Header("Resume System")]
		public Button ResumeButton;
		public int ResumeInt;
		public int IntSafeBonus;
		public int IntStartBubble;

		[Header("Sounds")]
		public AudioSource GameOverSound;
		public AudioSource JumpSound;

		void Awake()
		{
			if (SectionResume == 0)
			{
				CS_System = PlayerPrefs.GetInt("CS_System");
				ChangesSystem();
				SectionResume = 1;
			}

			// Randomize the colors in the list. This affects the color order in blocks, color balls, and the player.
			if ( randomizeColors ) colorList = Shuffle(colorList);
		}

		/// <summary>
		/// Start is only called once in the lifetime of the behaviour.
		/// The difference between Awake and Start is that Start is only called if the script instance is enabled.
		/// This allows you to delay any initialization code, until it is really needed.
		/// Awake is always called before any Start functions.
		/// This allows you to order initialization of scripts
		/// </summary>
		private void Start()
		{	
			CS_System = PlayerPrefs.GetInt("CS_System");
			ResumeInt = PlayerPrefs.GetInt("ResumeInt");
			CharacterInt = PlayerPrefs.GetInt("CharacterInt");
			ThemeInt = PlayerPrefs.GetInt("ThemeInt");
			Gold = PlayerPrefs.GetInt("Gold");

			int_dead = 0;
			PlayerPrefs.SetInt("int_dead",int_dead);

			intMileHole = 90;
			PlayerPrefs.SetInt("intMileHole",intMileHole);

			if (ResumeInt == 0){
			ThemeHoleInt = 0;
			PlayerPrefs.SetInt("ThemeHoleInt",ThemeHoleInt);
			}

			//Change the skin to the one which player has chosen
			Theme_Characters_System();
			ChangeSkin();
			ChangesSystem();
			Theme_Hole_System();

			//Get the highscore for the player
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			highScore = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name + "HighScore", 0);
			#else
			highScore = PlayerPrefs.GetFloat(Application.loadedLevelName + "HighScore", 0);
			#endif

			// Calculate the chances for the objects to spawn
			int totalSpawns = 0;
			int totalSpawnsIndex = 0;
			
			// Calculate the total number of sections with their chances
			for( index = 0; index < sections.Length; index++)
			{
				totalSpawns += sections[index].spawnChance;
			}
			
			// Create a new list of the objects that can be dropped
			sectionList = new Spawn[totalSpawns];
			
			// Go through the list again and fill out each type of drop based on its drop chance
			for( index = 0; index < sections.Length; index++)
			{
				int sectionsChanceCount = 0;
				
				while( sectionsChanceCount < sections[index].spawnChance )
				{
					sectionList[totalSpawnsIndex] = sections[index];
					sectionsChanceCount++;
					totalSpawnsIndex++;
				}
			}

		}
		private void ChangeSkin()
        {
        	playerSprite = selectedSkin.GetComponent<SpriteRenderer>().sprite;
			mainPlayer.GetComponent<SpriteRenderer>().sprite = playerSprite;
        }
       
        public void Resume()
        {
        	MilesAnalitics = PlayerPrefs.GetInt("MilesAnalitics");
        	NoAds = PlayerPrefs.GetInt("NoAds");
        	intPos = PlayerPrefs.GetInt("intPos");

        		// Ads
        		if (NoAds == 0)
        		{
        			int_resume = 1;
        			PlayerPrefs.SetInt("int_resume",int_resume);
        		}

        		// Premium
        		if (NoAds == 1)
        		{
		        	MilesAnalitics -= intPos;
		        	ResumeInt = 1;
		        	PlayerPrefs.SetInt("ResumeInt",ResumeInt);
		        	PlayerPrefs.SetInt("MilesAnalitics",MilesAnalitics);
		        	SceneManager.LoadScene ("CSGGame");
        		}
        }

		/// <summary>
		/// Update is called every frame, if the MonoBehaviour is enabled.
		/// </summary>
		private void  Update()
		{
			IntStartBubble = PlayerPrefs.GetInt("IntStartBubble");
			intMileHole = PlayerPrefs.GetInt("intMileHole");
			IntSafeBonus = PlayerPrefs.GetInt("IntSafeBonus");
			intPos = PlayerPrefs.GetInt("intPos");
			int_dead = PlayerPrefs.GetInt("int_dead");

			Gold = PlayerPrefs.GetInt("Gold");
			Gems = PlayerPrefs.GetInt("Gems");
        	Gold_Text.text = Gold.ToString();
        	Gems_Text.text = Gems.ToString();

        	if (isGameOver == false)
        	{	
        		if (IntStartBubble == 1){
        		if ( playerObject && !EventSystem.current.IsPointerOverGameObject() && Input.GetButtonDown(jumpButton) )
				{
					JumpSound.Play();
					playerObject.SendMessage("Jump");
				}
				}

				if (intPos < intMileHole){
				// If the player moves close enough to the current section, create another section
				if ( sectionList.Length > 0 && playerObject.position.y > SectionTransform.position.y + nextSectionGap - 10 )    SpawnObject(sectionList);
				}

				if (intPos >= intMileHole){
				// If the player moves close enough to the current section, create another section
				if ( sectionsHole.Length > 0 && playerObject.position.y > SectionTransform.position.y + nextSectionGap - 10) 
				{
					SpawnObject(sectionsHole);
					intMileHole += 90;
					PlayerPrefs.SetInt("intMileHole",intMileHole);
				}   
				}
			}

		}

		/// <summary>
		/// Changes the distance to the next section position
		/// </summary>
		/// <param name="changeValue">Change value.</param>
		void ChangeGap( float changeValue )
		{
			nextSectionGap = changeValue;
		}

		/// <summary>
		/// Creates a new enemy at the end of a random lane 
		/// </summary>
		public Transform SpawnObject( Spawn[] currentSpawnList )
		{
			// Create a new random target from the target list
			Transform newSpawn = Instantiate( currentSpawnList[Mathf.FloorToInt(Random.Range(0,currentSpawnList.Length))].spawnObject ) as Transform;
			
			// Place the target at a random position along the throw height
			newSpawn.position = new Vector2( 0, SectionTransform.position.y + nextSectionGap);

			SectionTransform = newSpawn;

			return newSpawn;
		}

		/// <summary>
		/// Sends a SetSpeedMultiplier command to the player, which makes it either faster or slower
		/// </summary>
		void SetSpeedMultiplier( float setValue )
		{
			if ( playerObject ) playerObject.SendMessage("SetSpeedMultiplier", setValue);
		}
		
		/// <summary>
		/// Set the score multiplier
		/// </summary>
		void SetScoreMultiplier( int setValue )
		{
			// Set the score multiplier
			scoreMultiplier = setValue;
		}

		/// <summary>
		/// Shuffles the specified Color list, and returns it
		/// </summary>
		/// <param name="colors">A list of colors</param>
		Color[] Shuffle( Color[] colors )
		{
			// Go through all the colors and shuffle them
			for ( index = 0 ; index < colors.Length ; index++ )
			{
				// Hold the text in a temporary variable
				Color tempNumber = colors[index];
				
				// Choose a random index from the text list
				int randomIndex = UnityEngine.Random.Range( index, colors.Length);
				
				// Assign a random text from the list
				colors[index] = colors[randomIndex];
				
				// Assign the temporary text to the random question we chose
				colors[randomIndex] = tempNumber;
			}
			
			return colors;
		}

		IEnumerator GameOver(float delay)
		{
			ResumeInt = PlayerPrefs.GetInt("ResumeInt");

			GameOverSound.Play();
			isGameOver = true;
			int_dead = 1;
			PlayerPrefs.SetInt("int_dead",int_dead);

			yield return new WaitForSeconds(delay);
			
			//Remove the pause and game screens
			NavigationPanel.SetActive(false);
			int miles = PlayerPrefs.GetInt("intPos");

			// Send relust in the leaderboard
			if(Application.internetReachability == NetworkReachability.NotReachable){
	        }
	        else
			PlayfabManager.Instance.SendScore(miles);
		}

		private void Theme_Characters_System ()
		{
			// Change Theme
			if (ThemeInt == 0)
			{
				CreenField_Camera.SetActive(true);
				CreenField_AreaColider.SetActive(true);
				CreenField_Music.SetActive(true);
				if (ResumeInt == 1){
					CreenField_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 1)
			{
				Flowers_Camera.SetActive(true);
				Flowers_AreaColider.SetActive(true);
				Flowers_Music.SetActive(true);
				if (ResumeInt == 1){
					Flowers_Ground.SetActive(false);
				}
			} 
			if (ThemeInt == 2)
			{
				Pyramids_Camera.SetActive(true);
				Pyramids_AreaColider.SetActive(true);
				Pyramids_Music.SetActive(true);
				if (ResumeInt == 1){
					Pyramids_Ground.SetActive(false);
				}
			}  
			if (ThemeInt == 3)
			{
				Desert_Camera.SetActive(true);
				Desert_AreaColider.SetActive(true);
				Desert_Music.SetActive(true);
				if (ResumeInt == 1){
					Desert_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 4)
			{
				Snow_Camera.SetActive(true);
				Snow_AreaColider.SetActive(true);
				Snow_Music.SetActive(true);
				if (ResumeInt == 1){
					Snow_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 5)
			{
				Island_Camera.SetActive(true);
				Island_AreaColider.SetActive(true);
				Island_Music.SetActive(true);
				if (ResumeInt == 1){
					Island_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 6)
			{
				Volcano_Camera.SetActive(true);
				Volcano_AreaColider.SetActive(true);
				Volcano_Music.SetActive(true);
				if (ResumeInt == 1){
					Volcano_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 7)
			{
				NightSky_Camera.SetActive(true);
				NightSky_AreaColider.SetActive(true);
				NightSky_Music.SetActive(true);
				if (ResumeInt == 1){
					NightSky_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 8)
			{
				Autumn_Camera.SetActive(true);
				Autumn_AreaColider.SetActive(true);
				Autumn_Music.SetActive(true);
				if (ResumeInt == 1){
					Autumn_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 9)
			{
				Dinosaur_Camera.SetActive(true);
				Dinosaur_AreaColider.SetActive(true);
				Dinosaur_Music.SetActive(true);
				if (ResumeInt == 1){
					Dinosaur_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 10)
			{
				Aquarium_Camera.SetActive(true);
				Aquarium_AreaColider.SetActive(true);
				Aquarium_Music.SetActive(true);
				if (ResumeInt == 1){
					Aquarium_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 11)
			{
				Space_Camera.SetActive(true);
				Space_AreaColider.SetActive(true);
				Space_Music.SetActive(true);
				if (ResumeInt == 1){
					Space_Ground.SetActive(false);
				}
			}
			if (ThemeInt == 12)
			{
				Rain_Camera.SetActive(true);
				Rain_AreaColider.SetActive(true);
				Rain_Music.SetActive(true);
				if (ResumeInt == 1){
					Rain_Ground.SetActive(false);
				}
			}

			// Change Characters
			if (CharacterInt == 0)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Ball_Skin;
			}
			if (CharacterInt == 1)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Star_Skin;
			}
			if (CharacterInt == 2)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Cupcake_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Cupcake_Skin_Transparency;
			}
			if (CharacterInt == 3)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Heart_Skin;
			}
			if (CharacterInt == 4)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Crab_Skin;
			}
			if (CharacterInt == 5)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Balloon_Skin;
			}
			if (CharacterInt == 6)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Ghost_Skin;
			}
			if (CharacterInt == 7)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Squid_Skin;
			}
			if (CharacterInt == 8)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Flame_Skin;
			}
			if (CharacterInt == 9)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Strawberry_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Strawberry_Skin_Transparency;
			}
			if (CharacterInt == 10)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Head_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Head_Skin_Transparency;
			}
			if (CharacterInt == 11)
			{
				selectedSkinTransparancy.SetActive(false);
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Slime_Skin;
			}
			if (CharacterInt == 12)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Bunny_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Bunny_Skin_Transparency;
			}
			if (CharacterInt == 13)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Mushroom_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Mushroom_Skin_Transparency;
			}
			if (CharacterInt == 14)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = IceCream_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = IceCream_Skin_Transparency;
			}
			if (CharacterInt == 15)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Bear_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Bear_Skin_Transparency;
			}
			if (CharacterInt == 16)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Flower_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Flower_Skin_Transparency;
			}
			if (CharacterInt == 17)
			{
				selectedSkin.GetComponent<SpriteRenderer>().sprite = Jellyfish_Skin;
				selectedSkinTransparancy.GetComponent<SpriteRenderer>().sprite = Jellyfish_Skin_Transparency;
			}
		}

		public void Theme_Hole_System ()
		{
			ThemeHoleInt = PlayerPrefs.GetInt("ThemeHoleInt");
			ResumeInt = PlayerPrefs.GetInt("ResumeInt");

			if (ThemeHoleInt >= 1){
			CreenField_Camera.SetActive(false);
			CreenField_AreaColider.SetActive(false);
			CreenField_Music.SetActive(false);
			CreenField_Ground.SetActive(false);

			Flowers_Camera.SetActive(false);
			Flowers_AreaColider.SetActive(false);
			Flowers_Music.SetActive(false);
			Flowers_Ground.SetActive(false);

			Pyramids_Camera.SetActive(false);
			Pyramids_AreaColider.SetActive(false);
			Pyramids_Music.SetActive(false);
			Pyramids_Ground.SetActive(false);

			Desert_Camera.SetActive(false);
			Desert_AreaColider.SetActive(false);
			Desert_Music.SetActive(false);
			Desert_Ground.SetActive(false);

			Snow_Camera.SetActive(false);
			Snow_AreaColider.SetActive(false);
			Snow_Music.SetActive(false);
			Snow_Ground.SetActive(false);

			Island_Camera.SetActive(false);
			Island_AreaColider.SetActive(false);
			Island_Music.SetActive(false);
			Island_Ground.SetActive(false);

			Volcano_Camera.SetActive(false);
			Volcano_AreaColider.SetActive(false);
			Volcano_Music.SetActive(false);
			Volcano_Ground.SetActive(false);

			NightSky_Camera.SetActive(false);
			NightSky_AreaColider.SetActive(false);
			NightSky_Music.SetActive(false);
			NightSky_Ground.SetActive(false);

			Autumn_Camera.SetActive(false);
			Autumn_AreaColider.SetActive(false);
			Autumn_Music.SetActive(false);
			Autumn_Ground.SetActive(false);

			Dinosaur_Camera.SetActive(false);
			Dinosaur_AreaColider.SetActive(false);
			Dinosaur_Music.SetActive(false);
			Dinosaur_Ground.SetActive(false);

			Aquarium_Camera.SetActive(false);
			Aquarium_AreaColider.SetActive(false);
			Aquarium_Music.SetActive(false);
			Aquarium_Ground.SetActive(false);

			Space_Camera.SetActive(false);
			Space_AreaColider.SetActive(false);
			Space_Music.SetActive(false);
			Space_Ground.SetActive(false);

			Rain_Camera.SetActive(false);
			Rain_AreaColider.SetActive(false);
			Rain_Music.SetActive(false);
			Rain_Ground.SetActive(false);
			}

			if (ThemeHoleInt == 1)
			{
				CreenField_Camera.SetActive(true);
				CreenField_AreaColider.SetActive(true);
				CreenField_Music.SetActive(true);
				if (ResumeInt == 1){
					CreenField_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 2)
			{
				Flowers_Camera.SetActive(true);
				Flowers_AreaColider.SetActive(true);
				Flowers_Music.SetActive(true);
				if (ResumeInt == 1){
					Flowers_Ground.SetActive(false);
				}
			} 
			if (ThemeHoleInt == 3)
			{
				Pyramids_Camera.SetActive(true);
				Pyramids_AreaColider.SetActive(true);
				Pyramids_Music.SetActive(true);
				if (ResumeInt == 1){
					Pyramids_Ground.SetActive(false);
				}
			}  
			if (ThemeHoleInt == 4)
			{
				Desert_Camera.SetActive(true);
				Desert_AreaColider.SetActive(true);
				Desert_Music.SetActive(true);
				if (ResumeInt == 1){
					Desert_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 5)
			{
				Snow_Camera.SetActive(true);
				Snow_AreaColider.SetActive(true);
				Snow_Music.SetActive(true);
				if (ResumeInt == 1){
					Snow_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 6)
			{
				Island_Camera.SetActive(true);
				Island_AreaColider.SetActive(true);
				Island_Music.SetActive(true);
				if (ResumeInt == 1){
					Island_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 7)
			{
				Volcano_Camera.SetActive(true);
				Volcano_AreaColider.SetActive(true);
				Volcano_Music.SetActive(true);
				if (ResumeInt == 1){
					Volcano_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 8)
			{
				NightSky_Camera.SetActive(true);
				NightSky_AreaColider.SetActive(true);
				NightSky_Music.SetActive(true);
				if (ResumeInt == 1){
					NightSky_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 9)
			{
				Autumn_Camera.SetActive(true);
				Autumn_AreaColider.SetActive(true);
				Autumn_Music.SetActive(true);
				if (ResumeInt == 1){
					Autumn_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 10)
			{
				Dinosaur_Camera.SetActive(true);
				Dinosaur_AreaColider.SetActive(true);
				Dinosaur_Music.SetActive(true);
				if (ResumeInt == 1){
					Dinosaur_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 11)
			{
				Aquarium_Camera.SetActive(true);
				Aquarium_AreaColider.SetActive(true);
				Aquarium_Music.SetActive(true);
				if (ResumeInt == 1){
					Aquarium_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 12)
			{
				Space_Camera.SetActive(true);
				Space_AreaColider.SetActive(true);
				Space_Music.SetActive(true);
				if (ResumeInt == 1){
					Space_Ground.SetActive(false);
				}
			}
			if (ThemeHoleInt == 13)
			{
				Rain_Camera.SetActive(true);
				Rain_AreaColider.SetActive(true);
				Rain_Music.SetActive(true);
				if (ResumeInt == 1){
					Rain_Ground.SetActive(false);
				}
			}
		}

		private void ChangesSystem ()
		{
			if (CS_System == 0){
				ZeroSection.SetActive(true);
			}
			if (CS_System == 1){
				FirstSection.SetActive(true);
			}
			if (CS_System == 2){
				SecondSection.SetActive(true);
			}
			if (CS_System == 3){
				ThirtSection.SetActive(true);
			}
			if (CS_System == 4){
				FourSection.SetActive(true);
			}
			if (CS_System == 5){
				FiveSection.SetActive(true);
			}
			if (CS_System == 6){
				SixSection.SetActive(true);
			}
			if (CS_System == 7){
				SevenSection.SetActive(true);
			}
			if (CS_System == 8){
				EightSection.SetActive(true);
			}
			if (CS_System == 9){
				NineSection.SetActive(true);
			}
			if (CS_System == 10){
				TenSection.SetActive(true);
			}
			if (CS_System == 11){
				ElevenSection.SetActive(true);
			}
			if (CS_System == 12){
				TwelveSection.SetActive(true);
			}
			if (CS_System == 13){
				ThirteenSection.SetActive(true);
			}
			if (CS_System == 14){
				FourteenSection.SetActive(true);
			}
			if (CS_System == 15){
				FiveteenSection.SetActive(true);
			}
			if (CS_System == 16){
				SixteenSection.SetActive(true);
			}
			if (CS_System == 17){
				SeventeenSection.SetActive(true);
			}
			if (CS_System == 18){
				EighteenSection.SetActive(true);
			}
			if (CS_System == 19){
				NineteenSection.SetActive(true);
			}
		}
	}
}
