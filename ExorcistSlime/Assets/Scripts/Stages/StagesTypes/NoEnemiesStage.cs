using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NoEnemiesStage : SceneController {

    public override void Awake()
    {
        base.Awake();
        playerCanNextStage = true;
    }

    public override void Start()
    {
        base.Start();
        FindObjectOfType<AudioManager>().PlayFirstLevelSong();
    }

}