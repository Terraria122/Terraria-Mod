using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Big_Boy.Mounts
{
    public class Mount : ModMountData
    {
        public override void SetDefaults()
        {
            mountData.buff = mod.BuffType("PhoenixMountBuff");
            mountData.heightBoost = 20;          //how high is the mount from the ground 
            mountData.fallDamage = 0f;
            mountData.runSpeed = 20f;
            mountData.dashSpeed = 20f;
            mountData.flightTimeMax = 1000000;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 10;
            mountData.acceleration = 10f;
            mountData.jumpSpeed = 6f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 8;            //mount frame/animation
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = 1;
            }
            mountData.playerYOffsets = array;
            mountData.xOffset = 13;
            mountData.yOffset = -3;          //how high is the mount from the player
            mountData.bodyFrame = 0;          //player frame when it's on the mount
            mountData.playerHeadOffset = 22;
            mountData.standingFrameCount = 4;
            mountData.standingFrameDelay = 12;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 4;
            mountData.runningFrameDelay = 12;
            mountData.runningFrameStart = 0;
            mountData.flyingFrameCount = 0;
            mountData.flyingFrameDelay = 0;
            mountData.flyingFrameStart = 0;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 12;
            mountData.inAirFrameStart = 0;
            mountData.idleFrameCount = 4;
            mountData.idleFrameDelay = 12;
            mountData.idleFrameStart = 0;
            mountData.idleFrameLoop = true;
            mountData.swimFrameCount = mountData.inAirFrameCount;
            mountData.swimFrameDelay = mountData.inAirFrameDelay;
            mountData.swimFrameStart = mountData.inAirFrameStart;
        }
    }
}