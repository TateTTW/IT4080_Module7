using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFireRate : BasePowerUp
{
    public float timeBetweenCannonFire = 0.1f;
    protected override bool ApplyToPlayer(Player player)
    {
        player.frontRightCannonBallSpawner.timeBetweenCannonFire = timeBetweenCannonFire;
        return true;
    }
}
