﻿using UnityEngine;
using System.Collections;
using TinyTeam.UI;
using UnityEngine.UI;

public class UISkillPage : TTUIPage {

    public UISkillPage() : base(UIWindowType.Normal, UIWindowShowMode.HideOther, UIWindowColliderMode.None)
    {
        uiPath = "UIPrefab/UISkill";
    }

    public override void Awake()
    {

    }


}
