using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

[CustomEditor(typeof(AdministartorScript))]
public class EditorSystem : Editor 
{
    private int Gold;
    private int Gems;
    private int NoAds;

    private void Start(){
    }
    
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Delet All"))
        {
            PlayerPrefs.DeleteAll();
        }

        if (GUILayout.Button("Premium Version"))
        {
            NoAds = 1;
            PlayerPrefs.SetInt("NoAds",NoAds);

            SceneManager.LoadScene(1);
        }

        if (GUILayout.Button("Add Gold"))
        {
            Gold += 100000;
            PlayerPrefs.SetInt("Gold",Gold);
        }

        if (GUILayout.Button("Add Gems"))
        {
            Gems += 1000;
            PlayerPrefs.SetInt("Gems",Gems);
        }
    }
}