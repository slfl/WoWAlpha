﻿namespace Common.Constants
{
    public enum ObjectFields
    {
        OBJECT_FIELD_GUID = 0x0, //0
        OBJECT_FIELD_TYPE = 0x2, //2
        OBJECT_FIELD_ENTRY = 0x3, //3
        OBJECT_FIELD_SCALE_X = 0x4, //4
        OBJECT_FIELD_PADDING = 0x5, //5
        OBJECT_END = 0x6
    };

    public enum ItemFields
    {
        ITEM_FIELD_OWNER         = 0x0, //0
        ITEM_FIELD_CONTAINED     = 0x2, //2
        ITEM_FIELD_CREATOR       = 0x4, //4
        ITEM_FIELD_STACK_COUNT   = 0x6, //6
        ITEM_FIELD_DURATION      = 0x7, //7
        ITEM_FIELD_SPELL_CHARGES = 0x8, //8 - 12 (Total : 5)
        ITEM_FIELD_FLAGS         = 0xD, //13
        ITEM_FIELD_ENCHANTMENT   = 0xE, //14 - 28 (Total : 15)
        ITEM_FIELD_PAD           = 0x1D, //29
        ITEM_END                 = 0x1E
    };

    public enum ContainerFields
    {
        CONTAINER_FIELD_NUM_SLOTS = 0x0, //0
        CONTAINER_ALIGN_PAD       = 0x1, //1
        CONTAINER_FIELD_SLOT_1    = 0x2, //2 - 41 (Total : 40)
        CONTAINER_END             = 0x2A //42
    };

    public enum UnitFields
    {
        UNIT_FIELD_CHARM                      = 0x0,
        UNIT_FIELD_SUMMON                     = 0x2,
        UNIT_FIELD_CHARMEDBY                  = 0x4,
        UNIT_FIELD_SUMMONEDBY                 = 0x6,
        UNIT_FIELD_CREATEDBY                  = 0x8,
        UNIT_FIELD_TARGET                     = 0xA,
        UNIT_FIELD_COMBO_TARGET               = 0xC,
        UNIT_FIELD_CHANNEL_OBJECT             = 0xE,
        UNIT_FIELD_HEALTH                     = 0x10,
        UNIT_FIELD_POWER1                     = 0x11,
        UNIT_FIELD_POWER2                     = 0x12,
        UNIT_FIELD_POWER3                     = 0x13,
        UNIT_FIELD_POWER4                     = 0x14,
        UNIT_FIELD_MAXHEALTH                  = 0x15,
        UNIT_FIELD_MAXPOWER1                  = 0x16,
        UNIT_FIELD_MAXPOWER2                  = 0x17,
        UNIT_FIELD_MAXPOWER3                  = 0x18,
        UNIT_FIELD_MAXPOWER4                  = 0x19,
        UNIT_FIELD_LEVEL                      = 0x1A,
        UNIT_FIELD_FACTIONTEMPLATE            = 0x1B,
        UNIT_FIELD_BYTES_0                    = 0x1C,
        UNIT_FIELD_STAT0                      = 0x1D,
        UNIT_FIELD_STAT1                      = 0x1E,
        UNIT_FIELD_STAT2                      = 0x1F,
        UNIT_FIELD_STAT3                      = 0x20,
        UNIT_FIELD_STAT4                      = 0x21,
        UNIT_FIELD_BASESTAT0                  = 0x22,
        UNIT_FIELD_BASESTAT1                  = 0x23,
        UNIT_FIELD_BASESTAT2                  = 0x24,
        UNIT_FIELD_BASESTAT3                  = 0x25,
        UNIT_FIELD_BASESTAT4                  = 0x26,
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY        = 0x27,
        UNIT_VIRTUAL_ITEM_INFO                = 0x2A,
        UNIT_FIELD_FLAGS                      = 0x30,
        UNIT_FIELD_COINAGE                    = 0x31,
        UNIT_FIELD_AURA                       = 0x32,
        UNIT_FIELD_AURAFLAGS                  = 0x6A,
        UNIT_FIELD_AURASTATE                  = 0x71,
        UNIT_FIELD_MOD_DAMAGE_DONE            = 0x72,
        UNIT_FIELD_MOD_DAMAGE_TAKEN           = 0x78,
        UNIT_FIELD_MOD_CREATURE_DAMAGE_DONE   = 0x7E,
        UNIT_FIELD_BASEATTACKTIME             = 0x86,
        UNIT_FIELD_RESISTANCES                = 0x88,
        UNIT_FIELD_BOUNDINGRADIUS             = 0x8E,
        UNIT_FIELD_COMBATREACH                = 0x8F,
        UNIT_FIELD_WEAPONREACH                = 0x90,
        UNIT_FIELD_DISPLAYID                  = 0x91,
        UNIT_FIELD_MOUNTDISPLAYID             = 0x92,
        UNIT_FIELD_DAMAGE                     = 0x93,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = 0x94,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = 0x9A,
        UNIT_FIELD_RESISTANCEITEMMODS         = 0xA0,
        UNIT_FIELD_BYTES_1                    = 0xA6, //StandState, NPCFlags, ShapeshiftForm, WeaponMode
        UNIT_FIELD_PETNUMBER                  = 0xA7,
        UNIT_FIELD_PET_NAME_TIMESTAMP         = 0xA8,
        UNIT_FIELD_PETEXPERIENCE              = 0xA9,
        UNIT_FIELD_PETNEXTLEVELEXP            = 0xAA,
        UNIT_DYNAMIC_FLAGS                    = 0xAB,
        UNIT_EMOTE_STATE                      = 0xAC,
        UNIT_CHANNEL_SPELL                    = 0xAD,
        UNIT_MOD_CAST_SPEED                   = 0xAE,
        UNIT_CREATED_BY_SPELL                 = 0xAF,
        UNIT_FIELD_BYTES_2                    = 0xB0, //Combo Points, pad, pad, pad
        UNIT_FIELD_PADDING                    = 0xB1,
        UNIT_END                              = 0xB2
    };

    public enum PlayerFields
    {
        PLAYER_FIELD_INV_SLOT_1     = 0x0,
        PLAYER_FIELD_PACK_SLOT_1    = 0x2E,
        PLAYER_FIELD_BANK_SLOT_1    = 0x4E,
        PLAYER_FIELD_BANKBAG_SLOT_1 = 0x7E,
        PLAYER_SELECTION            = 0x8A, //Uint64 GUID
        PLAYER_FARSIGHT             = 0x8C, //Uint64 GUID ?
        PLAYER_DUEL_ARBITER         = 0x8E, //Uint64 GUID ?
        PLAYER_FIELD_NUM_INV_SLOTS  = 0x90,
        PLAYER_GUILDID              = 0x91,
        PLAYER_GUILDRANK            = 0x92,
        PLAYER_BYTES                = 0x93,
        PLAYER_XP                   = 0x94,
        PLAYER_NEXT_LEVEL_XP        = 0x95,
        PLAYER_SKILL_INFO_1_1       = 0x96,
        PLAYER_BYTES_2              = 0x156,
        PLAYER_QUEST_LOG_1_1        = 0x157,
        PLAYER_CHARACTER_POINTS1    = 0x1B7,
        PLAYER_CHARACTER_POINTS2    = 0x1B8,
        PLAYER_TRACK_CREATURES      = 0x1B9,
        PLAYER_TRACK_RESOURCES      = 0x1BA,
        PLAYER_CHAT_FILTERS         = 0x1BB,
        PLAYER_DUEL_TEAM            = 0x1BC,
        PLAYER_BLOCK_PERCENTAGE     = 0x1BD,
        PLAYER_DODGE_PERCENTAGE     = 0x1BE,
        PLAYER_PARRY_PERCENTAGE     = 0x1BF,
        PLAYER_BASE_MANA            = 0x1C0,
        PLAYER_GUILD_TIMESTAMP      = 0x1C1,
        PLAYER_END                  = 0x1C2
    };

    public enum GameObjectFields
    {
        GAMEOBJECT_DISPLAYID = 0x0,
        GAMEOBJECT_FLAGS     = 0x1,
        GAMEOBJECT_ROTATION  = 0x2,
        GAMEOBJECT_STATE     = 0x6,
        GAMEOBJECT_TIMESTAMP = 0x7,
        GAMEOBJECT_POS_X     = 0x8,
        GAMEOBJECT_POS_Y     = 0x9,
        GAMEOBJECT_POS_Z     = 0xA,
        GAMEOBJECT_FACING    = 0xB,
        GAMEOBJECT_DYN_FLAGS = 0xC,
        GAMEOBJECT_FACTION   = 0xD,
        GAMEOBJECT_END       = 0xE
    };

    public enum DynamicObjectFields
    {
        DYNAMICOBJECT_CASTER  = 0x0,
        DYNAMICOBJECT_BYTES   = 0x2,
        DYNAMICOBJECT_SPELLID = 0x3,
        DYNAMICOBJECT_RADIUS  = 0x4,
        DYNAMICOBJECT_POS_X   = 0x5,
        DYNAMICOBJECT_POS_Y   = 0x6,
        DYNAMICOBJECT_POS_Z   = 0x7,
        DYNAMICOBJECT_FACING  = 0x8,
        DYNAMICOBJECT_PAD     = 0x9,
        DYNAMICOBJECT_END     = 0xA
    };

}
