using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUIStateInput : StateInput {
    public UIAnimationHandler AnimationHandler;
    public CharacterActor actor;
    
    //Freezes all UI response
    public bool Locked;
}
