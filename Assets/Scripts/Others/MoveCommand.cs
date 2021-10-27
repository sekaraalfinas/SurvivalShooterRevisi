﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    PlayerMovement playerMovement;
    float h, v;

    public MoveCommand(PlayerMovement _playerMovement, float _h, float _v)
    {
        this.playerMovement = _playerMovement;
        this.h = _h;
        this.v = _v;
    }

    // trigger perintah movement
    public override void Execute()
    {
        playerMovement.Move(h, v);
        // menganimasikan player
        playerMovement.Animating(h, v);
    }

    public override void UnExecute()
    {
        // Invers arah dari movement player
        playerMovement.Move(-h, -v);

        // menganimasikan player
        playerMovement.Animating(h, v);
    }
}
