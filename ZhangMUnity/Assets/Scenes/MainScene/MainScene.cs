using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ZhangM;

public class MainScene : MonoBehaviour
{
    public PlayerPanel playerPanel;
    public SubsidiaryPanel subsidiaryPanel;
    public DatePanel datePanel;

    public MainTimer mainTimer;

    // Start is called before the first frame update
    void Start()
    {
        NewGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        Facade.BuildRunData();

        playerPanel.gmData = Facade.player;
        subsidiaryPanel.gmData = Facade.player.ownedSubsidiary;
        datePanel.gmData = Facade.date;

        mainTimer.StartTimer();
    }
}
