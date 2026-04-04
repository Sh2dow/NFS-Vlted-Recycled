using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public static class GClass487
{
    public sealed class GClass488
    {
        [CompilerGenerated]
        private Type type_0;

        [CompilerGenerated]
        private byte byte_0;

        public Type Type
        {
            [CompilerGenerated]
            get
            {
                return type_0;
            }
            [CompilerGenerated]
            set
            {
                type_0 = value;
            }
        }

        public byte Alignment
        {
            [CompilerGenerated]
            get
            {
                return byte_0;
            }
            [CompilerGenerated]
            set
            {
                byte_0 = value;
            }
        }
    }

    private static IDictionary<uint, GClass488> idictionary_0;

    private static IDictionary<GEnum1, IDictionary<uint, GClass488>> idictionary_1;

    public static readonly IDictionary<Type, bool> idictionary_2 = new Dictionary<Type, bool>();

    private static GEnum1 genum1_0;

    private static readonly uint uint_0 = GClass486.smethod_8("MODEL");

    private static readonly uint uint_1 = GClass486.smethod_8("Attrib::StringKey");

    public static void smethod_0()
    {
        idictionary_1 = new Dictionary<GEnum1, IDictionary<uint, GClass488>>
        {
            [GEnum1.const_3] = new Dictionary<uint, GClass488>(),
            [GEnum1.const_4] = new Dictionary<uint, GClass488>(),
            [GEnum1.const_5] = new Dictionary<uint, GClass488>(),
            [GEnum1.const_6] = new Dictionary<uint, GClass488>(),
            [GEnum1.const_7] = new Dictionary<uint, GClass488>(),
            [GEnum1.const_8] = new Dictionary<uint, GClass488>()
        };
        smethod_1<GClass296>("Curve",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass173>("Curve", [GEnum1.const_5]);
        smethod_1<GClass234>("CollisionReactionRecord",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass156>("CollisionReactionRecord", [GEnum1.const_6]);
        smethod_1<GClass235>("ControllerDataRecord",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass157>("ControllerDataRecord", [GEnum1.const_3]);
        smethod_1<GClass288>("TireEffectRecord",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass170>("TireEffectRecord",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass301>("JunkmanMod",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass163>("JunkmanMod", [GEnum1.const_3]);
        smethod_1<GClass236>("CopCountRecord",
        [
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass158>("CopCountRecord", [GEnum1.const_3]);
        smethod_1<GClass241>("EffectLinkageRecord",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass159>("EffectLinkageRecord",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5
        ]);
        smethod_1<GClass304>("Attrib::StringKey",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass168>("Attrib::StringKey", [GEnum1.const_3]);
        smethod_1<GClass212>("GMapRegionInfo", [GEnum1.const_6]);
        smethod_1<GClass162>("GMapRegionInfo", [GEnum1.const_4]);
        smethod_1<GClass267>("PhysicsUpgrade", [GEnum1.const_6]);
        smethod_1<GClass164>("PhysicsUpgrade", [GEnum1.const_5]);
        smethod_1<GClass246>("FEPartCamera", [GEnum1.const_6]);
        smethod_1<GClass161>("FEPartCamera", [GEnum1.const_5]);
        smethod_1<GClass201>("FECarPartInfo",
        [
            GEnum1.const_4,
            GEnum1.const_8
        ]);
        smethod_1<GClass160>("FECarPartInfo", [GEnum1.const_3]);
        smethod_1<GClass270>("PresetRidePart", [GEnum1.const_6]);
        smethod_1<GClass167>("PresetRidePart", [GEnum1.const_5]);
        smethod_1<GClass165>("PresetRideAutosculpt", [GEnum1.const_6]);
        smethod_1<GClass268>("PresetRideAutosculpt", [GEnum1.const_5]);
        smethod_1<GClass269>("PresetRidePaint", [GEnum1.const_6]);
        smethod_1<GClass166>("PresetRidePaint", [GEnum1.const_5]);
        smethod_1<GClass462>("EA::Reflection::Bool", [GEnum1.const_9]);
        smethod_1<GClass464>("EA::Reflection::Float", [GEnum1.const_9]);
        smethod_1<GClass466>("EA::Reflection::Int16", [GEnum1.const_9]);
        smethod_1<GClass467>("EA::Reflection::Int32", [GEnum1.const_9]);
        smethod_1<GClass469>("EA::Reflection::Int8", [GEnum1.const_9]);
        smethod_1<GClass306>("EA::Reflection::Text", [GEnum1.const_9]);
        smethod_1<GClass471>("EA::Reflection::UInt16", [GEnum1.const_9]);
        smethod_1<GClass472>("EA::Reflection::UInt32", [GEnum1.const_9]);
        smethod_1<GClass474>("EA::Reflection::UInt8", [GEnum1.const_9]);
        smethod_1<GClass463>("EA::Reflection::Double", [GEnum1.const_9]);
        smethod_1<GClass468>("EA::Reflection::Int64", [GEnum1.const_9]);
        smethod_1<GClass303>("Attrib::RefSpec", [GEnum1.const_9]);
        smethod_2<GClass302>("Attrib::Types::Matrix", 128, [GEnum1.const_9]);
        smethod_1<GClass309>("Attrib::Types::Vector2", [GEnum1.const_9]);
        smethod_1<GClass310>("Attrib::Types::Vector3", [GEnum1.const_9]);
        smethod_2<GClass311>("Attrib::Types::Vector4", 128, [GEnum1.const_9]);
        smethod_1<GClass216>("AICollisionReactionRecord", [GEnum1.const_9]);
        smethod_1<GClass297>("AxlePair", [GEnum1.const_9]);
        smethod_1<GClass299>("CarBodyMotion", [GEnum1.const_9]);
        smethod_1<GClass261>("ParticleAnimationInfo", [GEnum1.const_9]);
        smethod_1<GClass262>("ParticleTextureRecord", [GEnum1.const_9]);
        smethod_1<GClass240>("DamageScaleRecord", [GEnum1.const_9]);
        smethod_1<GClass406>("eDRIVE_BY_TYPE", [GEnum1.const_9]);
        smethod_1<GClass431>("EffectParticleConstraint", [GEnum1.const_9]);
        smethod_1<GClass251>("FFBWaveRecord", [GEnum1.const_9]);
        smethod_1<GClass278>("RoadNoiseRecord", [GEnum1.const_9]);
        smethod_1<GClass420>("type_bStringHash", [GEnum1.const_9]);
        smethod_1<GClass451>("SPCHType_1_EventID", [GEnum1.const_9]);
        smethod_1<GClass460>("SurfaceEffectType", [GEnum1.const_9]);
        smethod_1<GClass352>("Csis::Type_NIS_Career_Scene", [GEnum1.const_4]);
        smethod_1<GClass204>("GStringHash", [GEnum1.const_4]);
        smethod_1<GClass365>("GRace::PrimaryRole", [GEnum1.const_4]);
        smethod_1<GClass366>("GRace::SecondaryRole", [GEnum1.const_4]);
        smethod_1<GClass333>("eTURN_DIRECTION", [GEnum1.const_5]);
        smethod_1<GClass334>("eTURN_INDICATORS", [GEnum1.const_5]);
        smethod_1<GClass411>("ePS_NIS_en_index", [GEnum1.const_5]);
        smethod_1<GClass197>("FEVinylRegionData", [GEnum1.const_5]);
        smethod_1<GClass335>("Gameplay::Region", [GEnum1.const_5]);
        smethod_1<GClass336>("GRace::AI_AggressionLevel", [GEnum1.const_5]);
        smethod_1<GClass337>("GRace::AI_MistakeLevel", [GEnum1.const_5]);
        smethod_1<GClass339>("GRace::CareerElementDrawStyle", [GEnum1.const_5]);
        smethod_1<GClass340>("GRace::Difficulty", [GEnum1.const_5]);
        smethod_1<GClass341>("GRace::EventStyle", [GEnum1.const_5]);
        smethod_1<GClass342>("GRace::HandicapMode", [GEnum1.const_5]);
        smethod_1<GClass343>("GRace::Mode", [GEnum1.const_5]);
        smethod_1<GClass344>("GRace::OpponentGender", [GEnum1.const_5]);
        smethod_1<GClass345>("GRace::OpponentTeam", [GEnum1.const_5]);
        smethod_1<GClass346>("GRace::OpponentType", [GEnum1.const_5]);
        smethod_1<GClass338>("GRace::Behaviour", [GEnum1.const_5]);
        smethod_1<GClass198>("HelpBarButtonGroup", [GEnum1.const_5]);
        smethod_1<GClass347>("Hub::HubLocation", [GEnum1.const_5]);
        smethod_1<GClass348>("Hub::HubType", [GEnum1.const_5]);
        smethod_1<GClass349>("Hub::LocationType", [GEnum1.const_5]);
        smethod_1<GClass437>("Hub::OrgBody", [GEnum1.const_5]);
        smethod_1<GClass350>("Hub::PlayType", [GEnum1.const_5]);
        smethod_1<GClass436>("GRace::Variant", [GEnum1.const_5]);
        smethod_1<GClass440>("NIS::eMULTICLASS_GROUP", [GEnum1.const_5]);
        smethod_1<GClass441>("NIS::eNIS_STYLE", [GEnum1.const_5]);
        smethod_1<GClass199>("PhysicsTuningPreset", [GEnum1.const_5]);
        smethod_1<GClass200>("PhysicsTuningSliderUnlock", [GEnum1.const_5]);
        smethod_1<GClass330>("Attrib::Types::Colour", [GEnum1.const_5]);
        smethod_1<GClass331>("Audio::CornerType", [GEnum1.const_5]);
        smethod_1<GClass332>("Audio::State", [GEnum1.const_5]);
        smethod_1<GClass425>("Csis::Type_CarTypeA", [GEnum1.const_5]);
        smethod_1<GClass426>("Csis::Type_CarTypeB", [GEnum1.const_5]);
        smethod_1<GClass427>("Csis::Type_CarTypeC", [GEnum1.const_5]);
        smethod_1<GClass428>("Csis::Type_FishOutOfWater", [GEnum1.const_5]);
        smethod_1<GClass429>("Csis::Type_SameMake", [GEnum1.const_5]);
        smethod_1<GClass300>("DefinitionKey", [GEnum1.const_5]);
        smethod_1<GClass433>("EnginePosition", [GEnum1.const_5]);
        smethod_1<GClass196>("DriverAssistLevelValues", [GEnum1.const_5]);
        smethod_1<GClass453>("SPEECH_CAR_GENERATION", [GEnum1.const_5]);
        smethod_1<GClass454>("SPEECH_RIVAL_MAKE", [GEnum1.const_5]);
        smethod_1<GClass177>("SlotStats", [GEnum1.const_5]);
        smethod_1<GClass247>("FEPartData", [GEnum1.const_5]);
        smethod_1<GClass217>("AI::GlueCurve", [GEnum1.const_6]);
        smethod_1<GClass213>("AIDriverSubclass", [GEnum1.const_6]);
        smethod_1<GClass370>("CarClassType", [GEnum1.const_6]);
        smethod_1<GClass228>("CarPaintSwatch", [GEnum1.const_6]);
        smethod_1<GClass229>("CCarDamageEntry", [GEnum1.const_6]);
        smethod_1<GClass386>("Csis::Type_vo_linenumber", [GEnum1.const_6]);
        smethod_1<GClass387>("CubeType", [GEnum1.const_6]);
        smethod_1<GClass224>("AtttributeRefSpec", [GEnum1.const_6]);
        smethod_1<GClass295>("AxlePairCurve", [GEnum1.const_6]);
        smethod_1<GClass221>("Attrib::Gen::ClassRefSpec_highway_pattern", [GEnum1.const_6]);
        smethod_1<GClass223>("Attrib::Gen::ClassRefSpec_pursuit_threat_select", [GEnum1.const_6]);
        smethod_1<GClass371>("Csis::Type_offroad_moment_id", [GEnum1.const_6]);
        smethod_1<GClass385>("Csis::Type_pursuit_breaker_type", [GEnum1.const_6]);
        smethod_1<GClass239>("DamageFilter::Control", [GEnum1.const_6]);
        smethod_1<GClass388>("EmitterShaderTechnique", [GEnum1.const_6]);
        smethod_1<GClass389>("ePaintSlot", [GEnum1.const_6]);
        smethod_1<GClass390>("ePaintUsage", [GEnum1.const_6]);
        smethod_1<GClass393>("eSNDCTLSTATE", [GEnum1.const_6]);
        smethod_1<GClass244>("FEHintsData", [GEnum1.const_6]);
        smethod_1<GClass176>("FEPartData", [GEnum1.const_6]);
        smethod_1<GClass248>("FEQuickUpgrade", [GEnum1.const_6]);
        smethod_1<GClass372>("Game::EventRegion", [GEnum1.const_6]);
        smethod_1<GClass373>("Game::GameMode", [GEnum1.const_6]);
        smethod_1<GClass374>("Game::RewardType", [GEnum1.const_6]);
        smethod_1<GClass378>("GRace::MissionType", [GEnum1.const_6]);
        smethod_1<GClass379>("GRace::NISLength", [GEnum1.const_6]);
        smethod_1<GClass253>("HighwayPatternCarData", [GEnum1.const_6]);
        smethod_1<GClass394>("ICEContextIDs", [GEnum1.const_6]);
        smethod_1<GClass396>("NIS::eFinishOutcome", [GEnum1.const_6]);
        smethod_1<GClass395>("NIS::eBustedLevel", [GEnum1.const_6]);
        smethod_1<GClass257>("NIS::EndTransition", [GEnum1.const_6]);
        smethod_1<GClass397>("NIS::eOnlineStatus", [GEnum1.const_6]);
        smethod_1<GClass398>("NIS::ePlayerUnderAIControl", [GEnum1.const_6]);
        smethod_1<GClass399>("NIS::eRaceType", [GEnum1.const_6]);
        smethod_1<GClass258>("NIS::NISActor", [GEnum1.const_6]);
        smethod_1<GClass259>("NIS::NISCar", [GEnum1.const_6]);
        smethod_1<GClass260>("NIS::SceneRoot", [GEnum1.const_6]);
        smethod_1<GClass271>("PresetRideRandomPaint", [GEnum1.const_6]);
        smethod_1<GClass277>("RoadblockSetup", [GEnum1.const_6]);
        smethod_1<GClass402>("VinylsAttrib::VinylFinish", [GEnum1.const_6]);
        smethod_1<GClass222>("Attrib::Gen::ClassRefSpec_presetride", [GEnum1.const_6]);
        smethod_1<GClass376>("GRace::AIOpponentGoal", [GEnum1.const_6]);
        smethod_1<GClass210>("FEAutosculptAliasing::Alias", [GEnum1.const_6]);
        smethod_1<GClass250>("FEVinylGroupInfo", [GEnum1.const_6]);
        smethod_1<GClass255>("LightFlash", [GEnum1.const_6]);
        smethod_1<GClass272>("RenderReflect::cBlendStateAttribDefinition", [GEnum1.const_6]);
        smethod_1<GClass273>("RenderReflect::cDepthStencilStateAttribDefinition", [GEnum1.const_6]);
        smethod_1<GClass274>("RenderReflect::cRasterizerStateAttribDefinition", [GEnum1.const_6]);
        smethod_1<GClass275>("RenderReflect::cRenderTargetAttribDefinition", [GEnum1.const_6]);
        smethod_1<GClass276>("RenderReflect::cSamplerStateAttribDefinition", [GEnum1.const_6]);
        smethod_1<GClass283>("Sound::JittererParams", [GEnum1.const_6]);
        smethod_1<GClass292>("VinylsAttrib::VinylLayer", [GEnum1.const_6]);
        smethod_1<GClass225>("CameraCurveReactionRecord", [GEnum1.const_6]);
        smethod_1<GClass231>("CCarDamageMarkerEntry", [GEnum1.const_6]);
        smethod_1<GClass182>("Attrib::Gen::ClassRefSpec_emittergroup", [GEnum1.const_7]);
        smethod_1<GClass183>("Attrib::Gen::ClassRefSpec_fe_flashers", [GEnum1.const_7]);
        smethod_1<GClass171>("Attrib::Gen::ClassRefSpec_powerup_fegroup", [GEnum1.const_7]);
        smethod_1<GClass180>("Attrib::Gen::ClassRefSpec_aud_world_reverb", [GEnum1.const_7]);
        smethod_1<GClass181>("Attrib::Gen::ClassRefSpec_coplights_flashpattern", [GEnum1.const_7]);
        smethod_1<GClass178>("Commerce::HatBonus", [GEnum1.const_7]);
        smethod_1<GClass179>("Commerce::LocalizedString", [GEnum1.const_7]);
        smethod_1<GClass312>("Csis::Type_arrest_line_number", [GEnum1.const_7]);
        smethod_1<GClass314>("DISTORTION_BASIS", [GEnum1.const_7]);
        smethod_1<GClass315>("eSFXOBJ_BLACKBOARD_MIXINPUT", [GEnum1.const_7]);
        smethod_1<GClass316>("eSFXOBJ_MUSICPLAYER_MIXINPUT", [GEnum1.const_7]);
        smethod_1<GClass317>("eSFXOBJ_MUSICPLAYER_MIXOUT", [GEnum1.const_7]);
        smethod_1<GClass184>("FEMsgToMixTrigger", [GEnum1.const_7]);
        smethod_1<GClass318>("GameCore::BlackBoardChannel", [GEnum1.const_7]);
        smethod_1<GClass185>("GameCore::KeyValuePair", [GEnum1.const_7]);
        smethod_1<GClass319>("GameCore::LocalizationHash", [GEnum1.const_7]);
        smethod_1<GClass186>("GameCore::PhysicsEntityPair", [GEnum1.const_7]);
        smethod_1<GClass320>("GameCore::PowerupConfiguration", [GEnum1.const_7]);
        smethod_1<GClass187>("GameCore::Pursuit::CopCountRecord", [GEnum1.const_7]);
        smethod_1<GClass188>("GameCore::Pursuit::CopFormationRecord", [GEnum1.const_7]);
        smethod_1<GClass190>("IntegratedKitWheelOffset", [GEnum1.const_7]);
        smethod_1<GClass321>("Interop::FEState", [GEnum1.const_7]);
        smethod_1<GClass322>("Interop::FLASHER_ALIGNMENT", [GEnum1.const_7]);
        smethod_1<GClass191>("PowerUps::EmitterEffectAndTarget", [GEnum1.const_7]);
        smethod_1<GClass174>("PowerUps::GameMode", [GEnum1.const_7]);
        smethod_1<GClass323>("PowerUps::GameplayEffect", [GEnum1.const_7]);
        smethod_1<GClass192>("PowerUps::GameplayEffectAndTarget", [GEnum1.const_7]);
        smethod_1<GClass324>("PowerUps::Restriction", [GEnum1.const_7]);
        smethod_1<GClass325>("PowerupTriggerAndTarget", [GEnum1.const_7]);
        smethod_1<GClass326>("SkyDomeModelStruct", [GEnum1.const_7]);
        smethod_1<GClass328>("Splicer_Collision_Mass", [GEnum1.const_7]);
        smethod_1<GClass327>("Sound::TriggeredAudioFeature", [GEnum1.const_7]);
        smethod_1<GClass329>("Victory::DataLayer::Serialization::enumPowerUpType", [GEnum1.const_7]);
        smethod_1<GClass172>("CameraCauseAndEffect", [GEnum1.const_8]);
        smethod_1<GClass175>("SpecialAbility", [GEnum1.const_8]);
        smethod_1<GClass438>("KIT_TYPE",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass263>("PerformanceStatsRange",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass264>("PerformanceWeight",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass265>("PerformanceWeightWithDirection",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass446>("Physics::ePerformanceType",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass447>("Physics::Info::eInductionType",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass266>("PhysicsTuningDescription",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass287>("TargetTimeOverrides",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass291>("UpgradeDescription",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass452>("SpecialSliderType",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass422>("BluePrintType",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass226>("CameraReactionRecord",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass227>("CameraSpeedReactionRecord",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass230>("CCarDamageLevels",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass232>("CCarDamageThreshold",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass233>("CCarKitSlotEntry",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass209>("CCarSlotEntry",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass238>("CPartsPackageEntry",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass409>("ePackageType",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass432>("EmitterPostProcessingEffect",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass408>("eLiveryID",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass418>("eSkyStyle",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass444>("PartType",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass249>("FETuningSlider",
        [
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass214>("GMapCurve",
        [
            GEnum1.const_4,
            GEnum1.const_6
        ]);
        smethod_1<GClass211>("GMapCurvePoint",
        [
            GEnum1.const_4,
            GEnum1.const_6
        ]);
        smethod_1<GClass215>("GMapCurveRef",
        [
            GEnum1.const_4,
            GEnum1.const_6
        ]);
        smethod_1<GClass375>("GMapTriangle",
        [
            GEnum1.const_4,
            GEnum1.const_6
        ]);
        smethod_1<GClass377>("GRace::CornerMarker",
        [
            GEnum1.const_4,
            GEnum1.const_6
        ]);
        smethod_1<GClass383>("IndexedBarrierName",
        [
            GEnum1.const_4,
            GEnum1.const_6
        ]);
        smethod_1<GClass465>("GCollectionKey",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass298>("Attrib::Blob",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass412>("eRewardCardArea",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass413>("eRewardCardConditionModifyer",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass414>("eRewardCardConditions",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass415>("eRewardCardDifficulty",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass416>("eRewardCardOnlineStat",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass417>("eRewardCardUnit",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass380>("GRace::RaceLigthingMode",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass381>("GRace::ShortcutType",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6
        ]);
        smethod_1<GClass351>("Csis::Type_NIS_Camera",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass353>("Csis::Type_NIS_Scene_End",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass354>("Csis::Type_NIS_Scene_Intro",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass355>("Csis::Type_P_Breaker_Code",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass356>("Csis::Type_P_Breaker_Type",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass357>("Csis::Type_SoundFX_Param",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass358>("Csis::Type_SoundFX_Type",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass360>("Csis::Type_UCAP_Assembly",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass364>("GRace::Boss",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass368>("NIS::ePLATFORM_CLASS",
        [
            GEnum1.const_4,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass218>("AirSupport",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass219>("Attrib::Gen::ClassRefSpec_aud_moment",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass220>("Attrib::Gen::ClassRefSpec_aud_wall_reverb",
        [
            GEnum1.const_6,
            GEnum1.const_7
        ]);
        smethod_1<GClass294>("Attrib::Types::FloatColour",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass193>("AUDENGLOOPVOLUMESst",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass194>("AUDENGRPMRANGEst",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass423>("CAR_SLOT_ID",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass424>("COLLISIONSFX_LAYERS",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass195>("CollisionStream",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5
        ]);
        smethod_1<GClass237>("CopFormationRecord",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass384>("Csis::Type_car_type",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass313>("Csis::Type_speaker_battalion",
        [
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass359>("Csis::Type_subject_battalion",
        [
            GEnum1.const_3,
            GEnum1.const_4
        ]);
        smethod_1<GClass430>("EAIBreakerType",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass403>("eControllerHudType",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_8
        ]);
        smethod_1<GClass404>("eControllerTypeMask",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_8
        ]);
        smethod_1<GClass405>("eDecalType",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass407>("eENGINE_GROUP",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass242>("EmittedGeometryRecord",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass243>("EngineLFOParams",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7
        ]);
        smethod_1<GClass410>("ePresetCarFilter",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_8
        ]);
        smethod_1<GClass391>("eSFXOBJ_MOMENT_MIXINPUT",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass392>("eSFXOBJ_MOMENT_MIXOUT",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass419>("eSongPlayability",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_8
        ]);
        smethod_1<GClass361>("eUnlockableEntity",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_8
        ]);
        smethod_1<GClass421>("eVOL_MOMENT",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass202>("FEDefaultUnlockable",
        [
            GEnum1.const_4,
            GEnum1.const_8
        ]);
        smethod_1<GClass245>("FEMsgToSoundTrigger",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass203>("FEPerfSliderTextures",
        [
            GEnum1.const_4,
            GEnum1.const_8
        ]);
        smethod_1<GClass362>("FXROADNOISE_LOOP",
        [
            GEnum1.const_3,
            GEnum1.const_4
        ]);
        smethod_1<GClass363>("FXROADNOISE_TRANSITION",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_7
        ]);
        smethod_1<GClass434>("GRace::RaceCarClass",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass435>("GRace::Tier",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass382>("GRace::Type",
        [
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass367>("GRace::WingmanShortcutTriggerHint",
        [
            GEnum1.const_4,
            GEnum1.const_5
        ]);
        smethod_1<GClass252>("HeavySupport",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass189>("HudSFXStringIdToSoundTrigger",
        [
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass254>("LeaderSupport",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass205>("LightStreakSplineRecord",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass256>("MovieVolume",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass439>("NIS::eCAR_COUNT_CATEGORY",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass443>("NIS::ePIP_EVENT_CATEGORY",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass442>("NIS::ePIPTrigger",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass445>("PathEventEnum",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_8
        ]);
        smethod_1<GClass448>("ROLLFX_LOOP",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass206>("RPMLOOPPOINTSst",
        [
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass449>("RUMBLEFX",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass279>("RwacSampleBankAsset",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass450>("SCRAPE_SURFACES",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass280>("Sound::BattleMusicTuning",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass281>("Sound::BinarySequence",
        [
            GEnum1.const_6,
            GEnum1.const_7
        ]);
        smethod_1<GClass282>("Sound::ChasedownMusicTuning",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass400>("Sound::EMomentChokeGroup",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass401>("Sound::EMomentPanning",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass284>("Sound::PursuitMusicTuning",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass285>("Sound::SirenSequence",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass286>("Sound::SirenTuning",
        [
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass458>("SPLICE_DAMAGE",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass455>("Splicer_Collision_Core",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass456>("Splicer_Collision_Object",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass457>("Splicer_Collision_Surface",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass207>("SteeringSensitivityParameter",
        [
            GEnum1.const_4,
            GEnum1.const_8
        ]);
        smethod_1<GClass459>("STICH_COLLISION_TYPE",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass208>("StitchCollisionVol",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_5
        ]);
        smethod_1<GClass369>("stShiftPair",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_8
        ]);
        smethod_1<GClass461>("SURFACE_SFX",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass289>("TireTimeEffectRecord",
        [
            GEnum1.const_5,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass290>("TrafficPatternRecord",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        smethod_1<GClass308>("UpgradeSpecs",
        [
            GEnum1.const_3,
            GEnum1.const_4,
            GEnum1.const_6,
            GEnum1.const_7,
            GEnum1.const_8
        ]);
        foreach (IDictionary<uint, GClass488> value in idictionary_1.Values)
        {
            foreach (GClass488 value2 in value.Values)
            {
                if (!idictionary_2.ContainsKey(value2.Type))
                {
                    int num = GClass108.smethod_0(value2.Type).Count();
                    idictionary_2.Add(value2.Type, num <= 1);
                }
            }
        }
    }

    private static void smethod_1<T>(string string_0, params GEnum1[] genum1_1)
    {
        smethod_2<T>(string_0, 0, genum1_1);
    }

    private static void smethod_2<T>(string string_0, byte byte_0, params GEnum1[] genum1_1)
    {
        uint key = GClass486.smethod_8(string_0);
        if (genum1_1.Length == 1 && genum1_1[0] == GEnum1.const_9)
        {
            smethod_2<T>(string_0, byte_0,
            [
                GEnum1.const_3,
                GEnum1.const_4,
                GEnum1.const_5,
                GEnum1.const_6,
                GEnum1.const_7,
                GEnum1.const_8
            ]);
        }
        else
        {
            GClass488 value = new()
            {
                Type = typeof(T),
                Alignment = byte_0
            };
            foreach (GEnum1 key2 in genum1_1)
            {
                idictionary_1[key2].Add(key, value);
            }
        }
    }

    public static byte smethod_3(uint uint_2)
    {
        if (idictionary_0.TryGetValue(uint_2, out var value))
        {
            return value.Alignment;
        }
        return 0;
    }

    public static Type smethod_4(uint uint_2, uint uint_3, ushort? nullable_0 = null)
    {
        if (uint_2 == uint_1 && uint_3 == uint_0)
        {
            if (genum1_0 != GEnum1.const_3)
            {
                return typeof(GClass305);
            }
            return typeof(GClass169);
        }
        if (idictionary_0.TryGetValue(uint_2, out var value))
        {
            return value.Type;
        }
        return typeof(GClass307);
    }

    public static bool smethod_5(Type type_0)
    {
        return idictionary_2.TryGetValue(type_0, out bool value) && value;
    }

    public static void smethod_6(GEnum1 genum1_1)
    {
        genum1_0 = genum1_1;
        idictionary_0 = idictionary_1[genum1_1];
    }
}
