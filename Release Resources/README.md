## DO NOT ADD CONFIG TO THE FILE ONLY THE VALUES IN THE FILE CAN BE EDITED.
* NEW UPDATE METHOD YOU DO NOT NEED TO DELETE your settings file after this new update.
* NEXT update all your settings will remain and only the new items will be added to your settings file.
* Should you have messed up please delete the settingsfile and the mod will create a new file on next startup.
* \AppData\LocalLow\Colossal Order\Cities Skylines II\ModSettings\WhitesharkCheatOverhaul\settings.json

## Modded Assets For Cities Skylines II
* SchoolOptions
* PowerplantOptions
* WaterpumpOptions
* TransformerstationOptions
* ServerfarmOptions
* GarbagetruckOptions
* TransportbusOptions
* ParkinghallOptions
* CityparkOptions
* WastewaterOptions
* IncinerationPlantOptions
* HealthcareOptions
* PostofficeOptions
* CemeteryOptions
* CrematoriumOptions
* WindturbineOptions
* EmergencybatteryOptions
* GeothermalpowerplantOptions
* SolarpowerstationOptions
* SignatureResidentialbuildingOptions
* SignatureCommercialbuildingOptions
* PostVanOptions
* SignatureOfficebuildingOptions
* SignatureMixedbuildingOptions
* FireStationOptions
* FireHelicopterDepotOptions
* FirewatchTowerOptions
* PoliceStationOptions
* PrisonOptions
* DiseaseControlCenterOptions
* HeathResearchInstituteOptions
* RadioTelescopeOptions
* GeologicalResearchCenterOptions
* TechnicalUniversityOptions
* EarlyDisasterWarningSystemOptions
* WelfareOfficeOptions
* CityHallOptions
* LargeEmergencyShelterOptions
* CentralBankOptions
* MedicalUniversityOptions
* LargeHadronColliderOptions
* PublicTransportStopsOptions
* PublicTransportDepotsOptions
* PublicTransportStationsOptions
* AirportOptions
* SpaceCenterOptions

## A setting File will be created at 1st run.
Location for settingsfile:
* \AppData\LocalLow\Colossal Order\Cities Skylines II\ModSettings\WhitesharkCheatOverhaul\settings.json
## you can use this to edit the settingfile with an GUI 
* https://jsoneditoronline.org
after edit just save it as:
* \AppData\LocalLow\Colossal Order\Cities Skylines II\ModSettings\WhitesharkCheatOverhaul\settings.json
## Installation - Thunderstore
Coming soon

## Installation - Manual
* This Thunderstore Version only support BepInEX 5

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