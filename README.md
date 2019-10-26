ai_framework


On BotBehaviour

     bot = permet de récuperer le component Bot

     master = permet d'acceder au GameMaster de la partie pour utiliser des fonctions outils
     master.TimeLeft = permet de récuperer le temps restant pour le round
     master.TimeSinceStart = permet récuperer le temps restant ecoulé depuis le debut du round
     
     teamBehaviour = permet de contacter votre script de comportement de votre équipe
     
     bot.agent = permet de contacter l'agent sur votre bot ( navmesh)
     bot.agent.SetDestination( vector3 destination ) = Permet de dire au bot de se rendre sur une position ( un repere dans l'espace en 3D )
     bot.agent.destination = permet de recuperer la destination du bot
     
     bot.is_dead = permet de recuperer si le bot est mort
     bot.can_shoot = permet de recuperer si le bot peut tirer
     bot.visibleEnemyBots = permet de récuperer les liste des ennemies visibles par le bot
     bot.visibleAlliedBots = permet de récuperer les liste des alliés visibles par le bot
     bot.visibleRockets = permet de récuperer les liste des rockets visibles par le bot
     bot.flagVisible = permet de recuperer si le bot voit ou non son drapeau
     bot.enemyFlagVisible = permet de recuperer si le bot voit ou non le drapeau ennemie
     bot.Health = permet de recuperer les points de vie du bot
    
     botTeam = permet d'acceder à la team du bot
     enemyTeam = permet d'acceder à la team ennemie
     botTeam.Places = permet de recuperer les positions associé à la team
     enemyTeam.Places = permet de recuperer les positions associés à la team adverse
     botTeam.flag = permet de recuperer le drapeau de la team
     enemyTeam.flag = permet de recuperer le drapeau de la team ennemie
     .....flag.Carrier = permet de récuperer l'id de celui qui porte le flag
     .....flag.Stolen = permet de récuperer si le flag est porté ou non 
     .....flag.AtBase = permet de récuperer si le flag est à la base ou non
     .....flag.Spawned = permet de récuperer si le drapeau est sur le terrain ou non
    
      master.GetBotFromBotId(int ID) = permet de recuperer le component Bot a partir de l'id du bot
      master.GetBotTeamIdFromBotId(int ID) = permet de recuperer l'id de la team du bot a partir de l'id du bot
      master.GetEnemyTeamIdFromBotId(int ID) = permet de recuperer l'id de la team ennemie du bot a partir de l'id du bot
      master.GetBotTeamFromBotId(int ID) = permet de recuperer le component Team de la team du bot a partir de l'id du bot
      master.GetEnemyTeamFromBotId(int ID) = permet de recuperer le component Team de la team ennemie du bot a partir de l'id du bot
      master.GetEnemyTeamIdFromTeamId(int ID) = permet de recuperer l'id de la team ennemie a partir de l'id de la team
      master.GetEnemyTeamFromTeamId(int ID) = permet de recuperer le component Team de la team ennemie a partir de l'id de la team
     
     Ajouter vos etat dans l'enum
     public enum BotState { IDLE, STATE_A, STATE_B }
     
     methode à contacter avec en paramètre le nouvelle etat du bot pour lui permettre de changer d'etat'
     SwitchState(BotState newState)
         
     Permet de dire au bot de se rendre sur une position appartenant à l'équipe ( ici la ou se trouve le drapeau )
     bot.agent.SetDestination(botTeam.Places.GetPlacePosition(KeyPlaces.FLAG));
    
     Permet de tirer une roquete dans une direction ( vector3 )
     bot.ShootInDirection(direction); 
     
    
    
On TeamBehaviour
     
    Fonction appelée sur chaque Team quand le match commence
    public override void OnMatchStart() {        
    }
    Fonction appelée sur chaque Team quand un dreapeau est volé (volé à la base ou ramassé au sol)
    public override void OnFlagStolen(Team teamStolen){     
    }
    Fonction appelée sur chaque Team quand un drapeau est sauvé
    public override void OnFlagSaved(Team teamStolen){       
    }
    Fonction appelée sur chaque Team quand une équipe marque un point
    public override void OnTeamScored(Team teamStolen){     
    }
     
     
