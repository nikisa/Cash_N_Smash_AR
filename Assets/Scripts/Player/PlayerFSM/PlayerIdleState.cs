﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{

    public override void Enter() {
        player.MovementReset();
    }

    public override void Tick() {

        if (player.characterController != null) {
            player.characterController.Move(player.velocityVector);
        }

        if (player.checkDeadZone()) {
            animator.SetTrigger(MOVEMENT);
        }
    }

}
