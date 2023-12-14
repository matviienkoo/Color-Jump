using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorSwitchGame
{
public class HoleScript : MonoBehaviour
{
  [Header("Hole")]
  public GameObject CansavTranstion;
  public Animation AnimationTranstion;
  public bool BoolTranstion;
  private int IntPlatform;

  [Header("Script")]
  public CSGGameController ScriptChangeTheme;

  float timer;

  private void SelectTheme ()
  {
      int ThemeHoleInt = Random.Range(1, 14);
      PlayerPrefs.SetInt("ThemeHoleInt", ThemeHoleInt);

      // Trasntion
      CansavTranstion.SetActive(true);
      AnimationTranstion.Play();
      BoolTranstion = true;

      // Change Theme
      StartCoroutine(ExampleCoroutine());
  }

  IEnumerator ExampleCoroutine()
  {
      yield return new WaitForSeconds(0.5f);

      ScriptChangeTheme.Theme_Hole_System(); 
  }

  private void Update ()
  {
      IntPlatform = PlayerPrefs.GetInt("IntPlatform");

      if (BoolTranstion == true){
      timer += Time.deltaTime;
      if (timer >= 1){
        CansavTranstion.SetActive(false);
        BoolTranstion = false;
        timer = 0;
      }
      }

      if (IntPlatform == 1)
      {
        SelectTheme();

        IntPlatform = 0;
        PlayerPrefs.SetInt("IntPlatform", IntPlatform);
      }
  }
}
}