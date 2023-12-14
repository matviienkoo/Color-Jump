using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CurrenciesManager : MonoBehaviour
{//SAVE ALL THE CURRENCY INTO PLAYERPREFS WHEN USER EXITS THE GAME, LOAD IT IN AWAKE
    #region SINGLETION
    private static CurrenciesManager instance;
    public static CurrenciesManager myInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CurrenciesManager>();
            }
            return instance;
        }
    }
    #endregion
    [SerializeField] int coins;
    [SerializeField] int gems;
    
    public int GetCoins()
    {
        int tempCoins = coins;
        return tempCoins;
    }
    public void AddCoins(int amount)
    {
        coins += amount;
    }
    public void SubstractCoins(int amount)
    {
        coins -= amount;
    }


    public int GetGems()
    {
        int tempGems = gems;
        return tempGems;
    }
    public void AddGems(int amount)
    {
        gems += amount;
    }
    public void SubstractGems(int amount)
    {
        gems -= amount;
    }

}
