using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LBUIController : MonoBehaviour
{
    [SerializeField] List<LBUIElement> m_ItemList;

    [Serializable]
    public class LBUIElement
    {
        public Text TXT_Rank;
        public TextMeshProUGUI TXT_Name;
        public TextMeshProUGUI TXT_Score;
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    private void OnEnable()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable){

        }
        else
        ShowLB();
    }

    public void ShowLB()
    {
        PlayfabManager.Instance.GetMonthlyLeaderBoardData((data) =>
        {
        if (data == null) return;
        for(int i = 0; i < data.Count; i++)
        {
            if(i < m_ItemList.Count)
            {
                m_ItemList[i].TXT_Rank.text = data[i].Rank.ToString();
                m_ItemList[i].TXT_Name.text = data[i].PlayerName;
                m_ItemList[i].TXT_Score.text = data[i].Value.ToString();
            }
        }
        });
    }
}
