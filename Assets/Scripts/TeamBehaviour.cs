using UnityEngine;

public abstract class TeamBehaviour : MonoBehaviour {

    protected GameMaster master;
    protected Team team;
    protected int teamId;
    protected Team enemyTeam;
    protected int enemyTeamId;
 
    public void Init(GameMaster master, Team team) {
        this.master = master;
        this.team = team;
        this.teamId = this.team.Id;
        this.enemyTeam = team.EnemyTeam;
        this.enemyTeamId =team.EnemyTeamId;
    }

    public abstract void RegisterBot(Bot[] bots);
    
    public virtual void OnMatchStart() {
        Debug.Log(this.teamId + " th match has started");
    }
  
}