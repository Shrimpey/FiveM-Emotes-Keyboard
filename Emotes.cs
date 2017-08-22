using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;

namespace Emotes
{
    public class Emotes : BaseScript
    {
        //String names of all the emotes
        private string[] emoteStrings = {
            "WORLD_HUMAN_AA_COFFEE",
            "WORLD_HUMAN_AA_SMOKE",
            "WORLD_HUMAN_BINOCULARS",
            "WORLD_HUMAN_BUM_FREEWAY",
            "WORLD_HUMAN_BUM_SLUMPED",
            "WORLD_HUMAN_BUM_STANDING",
            "WORLD_HUMAN_BUM_WASH",
            "WORLD_HUMAN_CAR_PARK_ATTENDANT",
            "WORLD_HUMAN_CHEERING",
            "WORLD_HUMAN_CLIPBOARD",
            "WORLD_HUMAN_CONST_DRILL",
            "WORLD_HUMAN_COP_IDLES",
            "WORLD_HUMAN_DRINKING",
            "WORLD_HUMAN_DRUG_DEALER",
            "WORLD_HUMAN_DRUG_DEALER_HARD",
            "WORLD_HUMAN_MOBILE_FILM_SHOCKING",
            "WORLD_HUMAN_GARDENER_LEAF_BLOWER",
            "WORLD_HUMAN_GARDENER_PLANT",
            "WORLD_HUMAN_GOLF_PLAYER",
            "WORLD_HUMAN_GUARD_PATROL",
            "WORLD_HUMAN_GUARD_STAND",
            "WORLD_HUMAN_GUARD_STAND_ARMY",
            "WORLD_HUMAN_HAMMERING",
            "WORLD_HUMAN_HANG_OUT_STREET",
            "WORLD_HUMAN_HIKER_STANDING",
            "WORLD_HUMAN_HUMAN_STATUE",
            "WORLD_HUMAN_JANITOR",
            "WORLD_HUMAN_JOG_STANDING",
            "WORLD_HUMAN_LEANING",
            "WORLD_HUMAN_MAID_CLEAN",
            "WORLD_HUMAN_MUSCLE_FLEX",
            "WORLD_HUMAN_MUSCLE_FREE_WEIGHTS",
            "WORLD_HUMAN_MUSICIAN",
            "WORLD_HUMAN_PAPARAZZI",
            "WORLD_HUMAN_PARTYING",
            "WORLD_HUMAN_PICNIC",
            "WORLD_HUMAN_PROSTITUTE_HIGH_CLASS",
            "WORLD_HUMAN_PROSTITUTE_LOW_CLASS",
            "WORLD_HUMAN_PUSH_UPS",
            "WORLD_HUMAN_SEAT_LEDGE",
            "WORLD_HUMAN_SEAT_LEDGE_EATING",
            "WORLD_HUMAN_SEAT_STEPS",
            "WORLD_HUMAN_SEAT_WALL",
            "WORLD_HUMAN_SEAT_WALL_EATING",
            "WORLD_HUMAN_SEAT_WALL_TABLET",
            "WORLD_HUMAN_SECURITY_SHINE_TORCH",
            "WORLD_HUMAN_SIT_UPS",
            "WORLD_HUMAN_SMOKING",
            "WORLD_HUMAN_SMOKING_POT",
            "WORLD_HUMAN_STAND_FIRE",
            "WORLD_HUMAN_STAND_FISHING",
            "WORLD_HUMAN_STAND_IMPATIENT",
            "WORLD_HUMAN_STAND_IMPATIENT_UPRIGHT",
            "WORLD_HUMAN_STAND_MOBILE",
            "WORLD_HUMAN_STAND_MOBILE_UPRIGHT",
            "WORLD_HUMAN_STRIP_WATCH_STAND",
            "WORLD_HUMAN_STUPOR",
            "WORLD_HUMAN_SUNBATHE",
            "WORLD_HUMAN_SUNBATHE_BACK",
            "WORLD_HUMAN_SUPERHERO",
            "WORLD_HUMAN_SWIMMING",
            "WORLD_HUMAN_TENNIS_PLAYER",
            "WORLD_HUMAN_TOURIST_MAP",
            "WORLD_HUMAN_TOURIST_MOBILE",
            "WORLD_HUMAN_VEHICLE_MECHANIC",
            "WORLD_HUMAN_WELDING",
            "WORLD_HUMAN_WINDOW_SHOP_BROWSE",
            "WORLD_HUMAN_YOGA",
            "PROP_HUMAN_ATM",
            "PROP_HUMAN_BBQ",
            "PROP_HUMAN_BUM_BIN",
            "PROP_HUMAN_BUM_SHOPPING_CART",
            "PROP_HUMAN_MUSCLE_CHIN_UPS",
            "PROP_HUMAN_MUSCLE_CHIN_UPS_ARMY",
            "PROP_HUMAN_MUSCLE_CHIN_UPS_PRISON",
            "PROP_HUMAN_PARKING_METER",
            "PROP_HUMAN_SEAT_ARMCHAIR",
            "PROP_HUMAN_SEAT_BAR",
            "PROP_HUMAN_SEAT_BENCH",
            "PROP_HUMAN_SEAT_BENCH_DRINK",
            "PROP_HUMAN_SEAT_BENCH_DRINK_BEER",
            "PROP_HUMAN_SEAT_BENCH_FOOD",
            "PROP_HUMAN_SEAT_BUS_STOP_WAIT",
            "PROP_HUMAN_SEAT_CHAIR",
            "PROP_HUMAN_SEAT_CHAIR_DRINK",
            "PROP_HUMAN_SEAT_CHAIR_DRINK_BEER",
            "PROP_HUMAN_SEAT_CHAIR_FOOD",
            "PROP_HUMAN_SEAT_CHAIR_UPRIGHT",
            "PROP_HUMAN_SEAT_CHAIR_MP_PLAYER",
            "PROP_HUMAN_SEAT_COMPUTER",
            "PROP_HUMAN_SEAT_DECKCHAIR",
            "PROP_HUMAN_SEAT_DECKCHAIR_DRINK",
            "PROP_HUMAN_SEAT_MUSCLE_BENCH_PRESS",
            "PROP_HUMAN_SEAT_MUSCLE_BENCH_PRESS_PRISON",
            "PROP_HUMAN_SEAT_SEWING",
            "PROP_HUMAN_SEAT_STRIP_WATCH",
            "PROP_HUMAN_SEAT_SUNLOUNGER",
            "PROP_HUMAN_STAND_IMPATIENT",
            "CODE_HUMAN_COWER",
            "CODE_HUMAN_CROSS_ROAD_WAIT",
            "CODE_HUMAN_PARK_CAR",
            "PROP_HUMAN_MOVIE_BULB",
            "PROP_HUMAN_MOVIE_STUDIO_LIGHT",
            "CODE_HUMAN_MEDIC_KNEEL",
            "CODE_HUMAN_MEDIC_TEND_TO_DEAD",
            "CODE_HUMAN_MEDIC_TIME_OF_DEATH",
            "CODE_HUMAN_POLICE_CROWD_CONTROL",
            "CODE_HUMAN_POLICE_INVESTIGATE",
            "CODE_HUMAN_STAND_COWER",
            "EAR_TO_TEXT",
            "EAR_TO_TEXT_FAT"
        };

        //Custom names of the emotes - those ones can be changed
        private string[] emoteStringNames = {
            "coffee",
            "smoke",
            "binoculars",
            "beg",
            "bum",
            "bum2",
            "wash",
            "traffic",
            "cheer",
            "clipboard",
            "drill",
            "cop",
            "drink",
            "drug",
            "stand",
            "film",
            "blow",
            "plant",
            "golf",
            "scout",
            "guard",
            "stand2",
            "hammer",
            "uhuh",
            "hiker",
            "pose",
            "janitor",
            "jog",
            "lean",
            "clean",
            "flex",
            "flex2",
            "music",
            "photo",
            "party",
            "sit",
            "prostitute",
            "prostitute2",
            "pushup",
            "sit2",
            "sit3",
            "sit4",
            "sit5",
            "sit6",
            "sit7",
            "torch",
            "situp",
            "smoke2",
            "smoke3",
            "fire",
            "fish",
            "stand3",
            "stand4",
            "phone",
            "phone2",
            "cheer2",
            "sit8",
            "sunbathe",
            "sunbathe2",
            "WORLD_HUMAN_SUPERHERO",
            "swim",
            "tennis",
            "map",
            "phone3",
            "fix",
            "weld",
            "think",
            "yoga",
            "atm",
            "bbq",
            "bin",
            "bum3",
            "chinup",
            "chinup2",
            "chinup3",
            "coins",
            "sit9",
            "sit10",
            "sit11",
            "sit12",
            "sit13",
            "sit14",
            "sit15",
            "sit16",
            "sit17",
            "sit18",
            "sit19",
            "sit20",
            "sit21",
            "sit22",
            "sit23",
            "sit24",
            "sit25",
            "sit26",
            "sit27",
            "sit28",
            "sit29",
            "stand5",
            "stand6",
            "crossroad",
            "CODE_HUMAN_PARK_CAR",
            "PROP_HUMAN_MOVIE_BULB",
            "PROP_HUMAN_MOVIE_STUDIO_LIGHT",
            "kneel",
            "medic",
            "notepad",
            "crowd",
            "investigate",
            "CODE_HUMAN_STAND_COWER",
            "phone4",
            "phone5"
        };

        //Dictionary for binding custom names to the strings
        private Dictionary<string, string> emoteNames = new Dictionary<string, string>();

        //Last emote played
        private string lastEmote;
  
        private bool playedEmote = true;

        //Default constructor
        public Emotes()
        {
            Tick += OnTick;

            //After player joins - set up stuff
            EventHandlers["onPlayerJoining"] += new Action(OnPlayerJoining);
        }

        private void SetEmoteNames()
        {
            //Adding names
            for (int i = 0; i < emoteStrings.Length; i++)
            {
                emoteNames.Add(emoteStringNames[i], emoteStrings[i]);
            }

            //Adding IDs
            for (int i = 0; i < emoteStrings.Length; i++)
            {
                emoteNames.Add(i.ToString(), emoteStrings[i]);
            }

            //To add custom additional names - check this command:
            //emoteNames.Add("New custom name", "STRING_NAME");
            //Example:
            //emoteNames.Add("drink coffee", "WORLD_HUMAN_AA_COFFEE");
            //You can have multiple custom names for the same emote
        }


        public async Task OnTick()
        {
            //Do all the stuff only if player is not in vehicle
            if (!Game.PlayerPed.IsInVehicle())
            {
                //Display keyboard on "Z" key
                if (playedEmote && Game.IsControlJustReleased(0, Control.MultiplayerInfo))
                {
                    DisplayKeyboard();
                    playedEmote = false;
                }

                //Play emote on keyboard exit
                if (!playedEmote)
                {
                    if (emoteNames.ContainsKey(GetKeyboardInput()))
                    {
                        CancelEmote();
                        PlayEmote(emoteNames[GetKeyboardInput()]);
                        playedEmote = true;
                        lastEmote = emoteNames[GetKeyboardInput()];
                    }
                }


                //Cancel emote on "X" key
                if (Game.IsControlJustReleased(0, Control.VehicleDuck))
                {
                    CancelEmote();
                    playedEmote = true;
                }

                //Play last emote on "C" key
                if (Game.IsControlJustReleased(0, Control.LookBehind))
                {
                    CancelEmote();
                    PlayEmote(lastEmote);
                    playedEmote = true;
                }
            }
        }

        void DisplayKeyboard()
        {
            Function.Call(Hash.DISPLAY_ONSCREEN_KEYBOARD, 1, "FMMC_KEY_TIP8S", "Emote name (lowercase) or emote ID", "", "", "", "", 25);
        }

        string GetKeyboardInput()
        {
            Function.Call(Hash.UPDATE_ONSCREEN_KEYBOARD);
            return Function.Call<string>(Hash.GET_ONSCREEN_KEYBOARD_RESULT);
        }

        void PlayEmote(string emoteName)
        {
            Function.Call(Hash.TASK_START_SCENARIO_IN_PLACE, Game.PlayerPed, emoteName, 0, false);
        }

        void CancelEmote()
        {
            Function.Call(Hash.CLEAR_PED_TASKS, Game.PlayerPed);
        }

        public void OnPlayerJoining()
        {
            //Setting emote names to the dictionary
            SetEmoteNames();
        }
    }
}
