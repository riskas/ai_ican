using System;
using System.Collections;
using TMPro;
using UnityEngine;

public struct MatchData
{
    public int teamAId;
    public string teamAName;
    public int teamBId;
    public string teamBName;
    public int winner;
    public int rounds;
    public int[] Scores;
    public RoundData[] games;
}

public class MatchMaster : MonoBehaviour
{
    [SerializeField] private MatchSettings settings;
    [SerializeField] private RoundMaster roundMaster;
    [SerializeField] private TextMeshProUGUI redTeamName;
    [SerializeField] private TextMeshProUGUI blueTeamName;
    
    private MatchData data;
    private bool finished;

    public void Init(Tuple<int,string> teamA, Tuple<int,string> teamB)
    {
        this.data = new MatchData();
        
        this.data.teamAId = teamA.Item1;
        this.data.teamAName = teamA.Item2;
        this.data.teamBId = teamB.Item1;
        this.data.teamBName = teamB.Item2;
        this.data.rounds = 0;
        this.data.winner = -1;
        this.data.games = new RoundData[this.settings.Rounds];

        redTeamName.text = this.data.teamAName;
        blueTeamName.text = this.data.teamBName;
        finished = false;
    }
  
    public IEnumerator StartMatch()
    {
        while (!this.finished)
        {
            InitRound();
            yield return StartCoroutine(this.roundMaster.StartRound());     
            EndRound();
            yield return null;
        }
    }
    
    public void InitRound(){
        this.data.rounds ++;
        this.roundMaster.Init(this.data.teamAName,this.data.teamBName);
    }

    public void EndRound()
    {
        //collect data
        if (this.data.rounds >= this.settings.Rounds)
        {
            finished = true;
        }
    }

    
    
}
