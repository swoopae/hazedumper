' Sat, 15 Jul 2017 12:02:49 +0200

Namespace hazedumper
    Public Shared Class netvars
        Public Const m_ArmorValue as Integer = &HB248
        Public Const m_Collision as Integer = &H318
        Public Const m_CollisionGroup as Integer = &H470
        Public Const m_Local as Integer = &H2FAC
        Public Const m_MoveType as Integer = &H258
        Public Const m_OriginalOwnerXuidHigh as Integer = &H316C
        Public Const m_OriginalOwnerXuidLow as Integer = &H3168
        Public Const m_aimPunchAngle as Integer = &H301C
        Public Const m_aimPunchAngleVel as Integer = &H3028
        Public Const m_bGunGameImmunity as Integer = &H38B0
        Public Const m_bHasDefuser as Integer = &HB258
        Public Const m_bHasHelmet as Integer = &HB23C
        Public Const m_bInReload as Integer = &H3245
        Public Const m_bIsDefusing as Integer = &H38A4
        Public Const m_bIsScoped as Integer = &H389C
        Public Const m_bSpotted as Integer = &H939
        Public Const m_bSpottedByMask as Integer = &H97C
        Public Const m_dwBoneMatrix as Integer = &H2698
        Public Const m_fAccuracyPenalty as Integer = &H32C0
        Public Const m_fFlags as Integer = &H100
        Public Const m_flFallbackWear as Integer = &H3178
        Public Const m_flFlashDuration as Integer = &HA308
        Public Const m_flFlashMaxAlpha as Integer = &HA304
        Public Const m_flNextPrimaryAttack as Integer = &H31D8
        Public Const m_hActiveWeapon as Integer = &H2EE8
        Public Const m_hMyWeapons as Integer = &H2DE8
        Public Const m_hObserverTarget as Integer = &H3380
        Public Const m_hOwner as Integer = &H29BC
        Public Const m_hOwnerEntity as Integer = &H148
        Public Const m_iAccountID as Integer = &H2FA8
        Public Const m_iClip1 as Integer = &H3204
        Public Const m_iCompetitiveRanking as Integer = &H1A44
        Public Const m_iCompetitiveWins as Integer = &H1B48
        Public Const m_iCrosshairId as Integer = &HB2B4
        Public Const m_iEntityQuality as Integer = &H2F8C
        Public Const m_iFOVStart as Integer = &H31D8
        Public Const m_iGlowIndex as Integer = &HA320
        Public Const m_iHealth as Integer = &HFC
        Public Const m_iItemDefinitionIndex as Integer = &H2F88
        Public Const m_iItemIDHigh as Integer = &H2FA0
        Public Const m_iObserverMode as Integer = &H336C
        Public Const m_iShotsFired as Integer = &HA2C0
        Public Const m_iState as Integer = &H31F8
        Public Const m_iTeamNum as Integer = &HF0
        Public Const m_lifeState as Integer = &H25B
        Public Const m_nFallbackPaintKit as Integer = &H3170
        Public Const m_nFallbackSeed as Integer = &H3174
        Public Const m_nFallbackStatTrak as Integer = &H317C
        Public Const m_nForceBone as Integer = &H267C
        Public Const m_nTickBase as Integer = &H3424
        Public Const m_rgflCoordinateFrame as Integer = &H440
        Public Const m_szCustomName as Integer = &H301C
        Public Const m_szLastPlaceName as Integer = &H35A8
        Public Const m_vecOrigin as Integer = &H134
        Public Const m_vecVelocity as Integer = &H110
        Public Const m_vecViewOffset as Integer = &H104
        Public Const m_viewPunchAngle as Integer = &H3010
    End Class
    Public Shared Class signatures
        Public Const dwClientState as Integer = &H5A3334
        Public Const dwClientState_GetLocalPlayer as Integer = &H180
        Public Const dwClientState_Map as Integer = &H28C
        Public Const dwClientState_MapDirectory as Integer = &H188
        Public Const dwClientState_MaxPlayer as Integer = &H310
        Public Const dwClientState_PlayerInfo as Integer = &H5240
        Public Const dwClientState_State as Integer = &H108
        Public Const dwClientState_ViewAngles as Integer = &H4D10
        Public Const dwClientState_IsHLTV as Integer = &H4CC8
        Public Const dwEntityList as Integer = &H4A8C724
        Public Const dwForceAttack as Integer = &H2ECEAF0
        Public Const dwForceAttack2 as Integer = &H2ECEAFC
        Public Const dwForceBackward as Integer = &H2ECEAD8
        Public Const dwForceForward as Integer = &H2ECEACC
        Public Const dwForceJump as Integer = &H4F236BC
        Public Const dwForceLeft as Integer = &H2ECEAB4
        Public Const dwForceRight as Integer = &H2ECEAC0
        Public Const dwGameDir as Integer = &H641BD0
        Public Const dwGameRulesProxy as Integer = &H4F8DFDC
        Public Const dwGetAllClasses as Integer = &H4F8E0B0
        Public Const dwGlobalVars as Integer = &H5A3038
        Public Const dwGlowObjectManager as Integer = &H4FA9700
        Public Const dwInput as Integer = &H4ED7338
        Public Const dwInterfaceLinkList as Integer = &H6EAAA4
        Public Const dwLocalPlayer as Integer = &HAAFFFC
        Public Const dwMouseEnable as Integer = &HAB5860
        Public Const dwMouseEnablePtr as Integer = &HAB5830
        Public Const dwPlayerResource as Integer = &H2ECCE2C
        Public Const dwRadarBase as Integer = &H4EC141C
        Public Const dwSensitivity as Integer = &HAB56FC
        Public Const dwSensitivityPtr as Integer = &HAB56D0
        Public Const dwViewMatrix as Integer = &H4A7E184
        Public Const dwWeaponTable as Integer = &H4ED38E4
        Public Const dwWeaponTableIndex as Integer = &H3270
        Public Const dwYawPtr as Integer = &HAB54C0
        Public Const dwZoomSensitivityRatioPtr as Integer = &HABA528
        Public Const dwbSendPackets as Integer = &HCAA6A
        Public Const dwppDirect3DDevice9 as Integer = &H9CF40
        Public Const dwSetClanTag as Integer = &H84880
        Public Const m_pStudioHdr as Integer = &H293C
    End Class
End Namespace
