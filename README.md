# PowerPlants_Consumption_Pollution_Production Mod
Tweaks the Consumption & Pollution & Production of PowerPlants to make the number of PowerPlants required more sane/realistic.

Affected Buildings:
* Gas PowerPlant
* Small Coal PowerPlant

Consumption
* Upkeep = 50
* Garbage Accumulation = 0
* Water Consumption = 0

Pollution
* Air Pollution = 0
* Ground Pollution = 0
* Noise Pollution = 0

Production
* Electricity Production = 1000MW

# WaterPump_Consumption_Pollution_Production Mod
Tweaks the Consumption & Pollution & Production of WaterPump to make the number of WaterPump required more sane/realistic.

Affected Buildings:
* Water PumpingStation

Consumption
* Upkeep = 50
* Garbage Accumulation = 0
* Electricity Consumption = 0

Pollution
* Noise Pollution = 0

Production
* Capacity = 1.000.000

# Transformer Station Mod
Tweaks the Consumption & Pollution & Production of Transformer Station to make the number of Transformer Station required more sane/realistic.

Affected Buildings:
* Transformer Station

Consumption   
* Upkeep = 50
* Garbage Accumulation = 0

Pollution            
* Noise Pollution = 0

# Server Farm Mod
Tweaks the Consumption & Pollution & Production of Server Farm to make the number of Server Farm required more sane/realistic.

Affected Buildings:
* Server Farm

Consumption
* Upkeep = 50
* Garbage Accumulation = 0
* Electricity Consumption = 0
* Water Consumption = 0

Pollution            
* Noise Pollution = 0

Production
* Range = 12500
* Network Capacity = 200.000

# Garbage Truck Mod
Tweaks the Capacity & Unload speed of Garbage Truck to make the number of Garbage Truck required more sane/realistic.

Affected Vehicle:
* Garbage Truck

Tweaks
* Capacity = 80t
* Unload Speed 10t

# Public Transport Bus Mod
Tweaks the Capacity & Maintenance Radius of Public Transport Bus to make the number of Public Transport Bus required more sane/realistic.

Affected Vehicle:
* Public Transport Bus
* Public Transport Bus Electrical
* Public Transport Bus Emergency Shelter Evacuation

Tweaks
* Capacity = 1000
* Maintenance Radius 10.000
		
# Parking Garage Mod
Tweaks the Capacity & Comfort of Parking Garage to make the number of Parking Garage required more sane/realistic.

Affected Buildings:
* Overground Parking
* Underground Parking

Tweaks
* Capacity = 1000
* Comfort = 100

# Public Park Mod
Tweaks the Capacity & Attaction of Public Parks to make the number of Public Parks required more sane/realistic.

Affected Buildings:
* Small Park
* Small Plaza
* Large City Park
* Large Plaza

Consumption
* Garbage Accumulation = 0
* Electricity Consumption = 0
* Water Consumption = 0

Coverage
* Range = 100.000
* Capacity = 20.000    
* Magnitude = 50

Attraction
* Attraction = 50.000

Leisure
* Efficiency = 50

# Wastewater Treatment Plant Mod
Tweaks the Consumption & Pollution & Production of Wastewater Treatment Plant to make the number of Wastewater Treatment Plant required more sane/realistic.

Affected Buildings:
* Wastewater Treatment Plant

Consumption
* Upkeep = 50
* Garbage Accumulation = 0

Pollution
* Air Pollution = 0
* Ground Pollution = 0
* Noise Pollution = 0		

Tweaks
* Capacity = 10.000.000
* purification = 1		

# Pop Musician Mansion Mod
Tweaks the Wellbeing & Radius of Pop Musician Mansion to make the Pop Musician Mansion more sane/realistic.

Affected Buildings:
* Pop Musician Mansion

Tweaks
* wellbeing = 10.000
* radius = 50.000
		
# Public Transport Train Mod
Tweaks the Capacity & Maintenance Radius of Public Transport Train to make the number of Public Transport Train required more sane/realistic.

Affected Vehicle:
* Public Transport Train Engine
* Public Transport Train Car

Tweaks
* Capacity = 1000 (8.000 total)
* Maintenance Radius 10.000

# Public Transport Subway Mod
Tweaks the Capacity & Maintenance Radius of Public Transport Subway to make the number of Public Transport Subway required more sane/realistic.

Affected Vehicle:
* Public Transport Subway Engine
* Public Transport Subway Car

Tweaks
* Capacity = 1000 (8.000 total)
* Maintenance Radius 10.000

# Public Transport Tram Mod
Tweaks the Capacity & Maintenance Radius of Public Transport Tram to make the number of Public Transport Tram required more sane/realistic.

Affected Vehicle:
* Public Transport Tram Engine
* Public Transport Tram Car

Tweaks
* Capacity = 1000 (3.000 total)
* Maintenance Radius 10.000
		
# Post Office Mod
Tweaks the Capacity of Post Office to make the number of Post Office required more sane/realistic.

Affected Buildings:
* Post Office

Capacity
* MailStorage Capacity = 1.000.000
* MailBox Capacity = 3000
* PostVan Capacity = 50
		
#Garbage Incinerator Plant Mod
Tweaks the Consumption & Pollution & Production of Garbage Incinerator Plant to make the number of Garbage Incinerator Plant required more sane/realistic.

Affected Buildings:
* Garbage Incinerator Plant

Consumption
* Upkeep = 50
* Water Consumption = 0

Pollution
* Ground Pollution = 0
* Air Pollution = 0
* Noise Pollution = 0

Capacity
* Garbage Capacity = 3.000.000
* Vehicle Capacity = 100


## Installation - Thunderstore
Coming soon

## Installation - Manual
1. Install [BepInEx 6 Bleeding Edge build](https://builds.bepinex.dev/projects/bepinex_be) or BepInEx 5. 

   The pre-release version of BepInEx 6 available on their GitHub release page is quite outdated (dated August 2022) and may not support loading this mod. Please download the Bleeding Edge version from [their website](https://builds.bepinex.dev/projects/bepinex_be)

   * Download `BepInEx-Unity.Mono-win-x64-6.0.0-be.674+82077ec.zip` (or a newer version), and unzip all of its contents into the game's installation directory, typically `C:/Program Files (x86)/Steam/steamapps/common/Cities Skylines II`

   * The installation directory should now have the `BepInEx` folder, the `doorstop_config.ini` file, and the `winhttp.dll` file

2. Run the game once, then close it. You can close it when the main menu appears

3. Download the mod from the [release page](https://github.com/whiteshark-1975/WhitesharkCheatOverhaul). Make sure you select the download that is compatible with your version of BepInEx. Unzip it into the `Cities Skylines II/BepInEx/plugins` folder.

4. Launch the game, and your mods should be loaded automatically

## Compiling the Mod Yourself
You will need to add references to Unity yourself if you wish to compile the project.

In the .csproj, you can set the location of your game install and enable the PostBuild install step, to automatically install the mod after build.

## Thank You
* Wayz for having teached me how to write mods. https://github.com/Wayzware/EducationBalancer/releases
* optimus-code for their [template mod repo](https://github.com/optimus-code/Cities2Modding/tree/main), especially the .csproj
* [slyh](https://github.com/slyh) for their installation instructions
* The creators of Harmony and BepInEx
* The Cities Skylines II modding discord in general
