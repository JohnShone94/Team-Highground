﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class s_Constants
{
    public static readonly int rows = 8;
    public static readonly int columns = 8;
    public static readonly float animationTime = 0.2f;

    public static readonly float minMovingAnimTime = 0.05f;

    public static readonly float removeAnimTime = 0.3f;

    public static readonly float timeBeforeMatchCheck = 2.0f;
    public static readonly float animOpacityFrameDelay = 0.05f;

    public static readonly int minTilesToMatch = 3;
    public static readonly int minTilesToBonusMatch = 4;

    public static readonly int scoreBasicMatch = 60;
    public static readonly int scoreSubsequentMatch = 500;

}
