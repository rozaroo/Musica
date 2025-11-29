/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_ANIMALSOUNDS = 1685167594U;
        static const AkUniqueID PLAY_CAVE_AMBIENCE = 1911082204U;
        static const AkUniqueID PLAY_FOOTSTEPS_SWITCH_CONTAINER = 1367080338U;
        static const AkUniqueID PLAY_HEARTBEAT = 3765695918U;
        static const AkUniqueID PLAY_JUNGLE_AMBIENCE = 2245623692U;
        static const AkUniqueID PLAY_WEATHER = 3308884970U;
        static const AkUniqueID PLAYBGM = 2542411811U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace CAVE_STATE
        {
            static const AkUniqueID GROUP = 2803997424U;

            namespace STATE
            {
                static const AkUniqueID CAVE_OFF = 1396027332U;
                static const AkUniqueID CAVE_ON = 887119646U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace CAVE_STATE

        namespace PLAYERSTATUS
        {
            static const AkUniqueID GROUP = 3800848640U;

            namespace STATE
            {
                static const AkUniqueID ALIVE = 655265632U;
                static const AkUniqueID DEAD = 2044049779U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace PLAYERSTATUS

        namespace SITUATION
        {
            static const AkUniqueID GROUP = 4223905515U;

            namespace STATE
            {
                static const AkUniqueID EXPLORING = 1823678183U;
                static const AkUniqueID INBATTLE = 717651098U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace SITUATION

    } // namespace STATES

    namespace SWITCHES
    {
        namespace CLIMATE_JUNGLE_SWITCH
        {
            static const AkUniqueID GROUP = 971377033U;

            namespace SWITCH
            {
                static const AkUniqueID RAIN = 2043403999U;
                static const AkUniqueID SUNNY = 3569642402U;
            } // namespace SWITCH
        } // namespace CLIMATE_JUNGLE_SWITCH

        namespace FOOTSTEPSSWITCH
        {
            static const AkUniqueID GROUP = 3586861854U;

            namespace SWITCH
            {
                static const AkUniqueID FOOTSTEPS_GRASS = 7365553U;
                static const AkUniqueID FOOTSTEPS_GRAVEL = 1676031848U;
                static const AkUniqueID FOOTSTEPS_MUD = 2466159333U;
            } // namespace SWITCH
        } // namespace FOOTSTEPSSWITCH

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID BIRD_SOUNDS = 2445204491U;
        static const AkUniqueID HEALTH = 3677180323U;
        static const AkUniqueID PLAYBACK_RATE = 1524500807U;
        static const AkUniqueID RAIN_INTENSITY = 2520241501U;
        static const AkUniqueID RPM = 796049864U;
        static const AkUniqueID SS_AIR_FEAR = 1351367891U;
        static const AkUniqueID SS_AIR_FREEFALL = 3002758120U;
        static const AkUniqueID SS_AIR_FURY = 1029930033U;
        static const AkUniqueID SS_AIR_MONTH = 2648548617U;
        static const AkUniqueID SS_AIR_PRESENCE = 3847924954U;
        static const AkUniqueID SS_AIR_RPM = 822163944U;
        static const AkUniqueID SS_AIR_SIZE = 3074696722U;
        static const AkUniqueID SS_AIR_STORM = 3715662592U;
        static const AkUniqueID SS_AIR_TIMEOFDAY = 3203397129U;
        static const AkUniqueID SS_AIR_TURBULENCE = 4160247818U;
        static const AkUniqueID WINDINTENSITY = 1042517418U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID JUEGO = 1157012013U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MOTION_FACTORY_BUS = 985987111U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID CAVE_REVERB = 3177428469U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID DEFAULT_MOTION_DEVICE = 4230635974U;
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
