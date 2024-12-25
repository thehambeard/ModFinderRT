$\color{red}\Huge{\textsf{This is my fork and will NOT be up to date!}}$

$\color{red}\Huge{\textsf{Download latest ModFinder version for Rogue Trader here:}}$

[![Download zip](https://custom-icon-badges.herokuapp.com/badge/-Download-blue?style=for-the-badge&logo=download&logoColor=white "Download zip")](https://github.com/CasDragon/ModFinder/releases/latest/download/ModFinder.zip)


# ModFinder

A tool for browsing and managing Warhammer 40k Rogue Trader mods and their dependencies.

![2024-04-12 14 18 12 - MainWindow](https://github.com/CasDragon/ModFinder/assets/91767316/4eff53cd-61c0-4e47-97b6-99ca2a129a8d)


## Features

* Browse mods hosted on Nexus and GitHub
* Detects out of date mods
* Automatically installs mods hosted on GitHub
* Enable / disable mods
* Detects missing dependencies, enabling one-click install (mods on GitHub) or download link (mods on Nexus)
* Uninstall mods
* Rollback mod updates
* And more

## For Users

[![Download zip](https://custom-icon-badges.herokuapp.com/badge/-Download-blue?style=for-the-badge&logo=download&logoColor=white "Download zip")](https://github.com/CasDragon/ModFinder/releases/latest/download/ModFinder.zip) the latest release, extract the folder, and run `ModFinder.exe`!

### **You must have [.NET Destkop Runtime 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.302-windows-x64-installer) or later installed.**

### If it doesn't work, see [Troubleshooting](#troubleshooting).

Tips:

* Searching checks mod name and author by default
* You can search specifically name, author, or [tag](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder/blob/main/ModFinderClient/Mod/Tag.cs):
    * `a:bub` to include authors with "bub" in their name, or `-a:bub` to exclude them
    * `n:super` to include mods with "super" in the name, or `-n:super` to exclude them
    * `t:game` to include tags with "game" in their name, or `-n:game` to exclude them
* Version updates are checked every 30 minutes, but you need to restart the app to get the latest version data
    * If the latest version is for a more recent game version (e.g beta) it will install it even if it doesn't work with your local version
* When you open it mods missing pre-requisites are shown first, followed by mods with an update available
* The overflow menu has more functionality like viewing the changelog, description, and homepage
* When you update a mod using ModFinder you can revert to the previous version, open the overflow menu and select "Rollback"
    
### Missing a mod?

Ask the mod developer to add it or file an [issue](https://github.com/CasDragon/ModFinder/issues/new).

## For Mod Devs

Currently ModFinder only supports mods hosted on Nexus or GitHub. It can handle both Owlcat Template mods and UMM based mods.

To add (or change details about) your mod:

1. Update [internal_manifest.json](https://github.com/CasDragon/ModFinder/blob/RogueTrader/ManifestUpdater/Resources/internal_manifest.json)
    * Don't include any version data or description, this is automatically updated roughly every 2 hours
    * You can submit a PR or file an issue
    
That's it! The manifest format is documented [in the code](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder/blob/main/ModFinderClient/Mod/ModManifest.cs).

Make sure to apply the appropriate [tags](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder/blob/main/ModFinderClient/Mod/Tag.cs) so users can find your mod.
 
Assumptions for GitHub:

* The first release asset is a zip file containing the mod (i.e. what a user would drag into UMM)
    * You can specify a `ReleaseFilter`, look at [MewsiferConsole](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder/blob/main/ManifestUpdater/Resources/internal_manifest.json) for an example
* Your releases are tagged with a version string in the format `1.2.3e`. Prefixes are ignored.
    * If there's a mismatch between your GitHub tag version and `Info.json` version it will think the mod is always out of date

If necessary you can host your own `ModManifest` JSON file by adding a direct download link to `ExternalManifestUrls` in [master_manifest.json](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder/blob/main/ManifestUpdater/Resources/master_manifest.json). Keep in mind, this will not be automatically updated so it is up to you to populate description and version info.

### Want your mod removed from the list?

File an [issue](https://github.com/CasDragon/ModFinder/issues/new) or submit a PR.

## Troubleshooting

* Make sure you have [.NET Destkop Runtime 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.302-windows-x64-installer) or later installed
* Try [running it as an Administrator](https://www.itechtics.com/run-programs-administrator/)
* Make sure your anti-virus is not blocking it
    * Some anti-virus flags it as a trojan
        * ModFinder sends requests to GitHub to download mod metadata and mods themselves
        * ModFinder also writes files (logs) and deletes, moves, and unzips files related to mods you have installed
    * Update changelog includes a sha1 hash you can use to verify your download
    * Here are the scan results for v1.1 on [VirusTotal](https://www.virustotal.com/gui/file/882b5b1e5eb0dc2d51413a663d116b89856ab3f35681505e7d5286f1ecd0aee6/detection)
* File an [issue](https://github.com/CasDragon/ModFinder/issues/new) or reach out on Discord
    * Share your log file: `%UserProfile%\AppData\Local\ModfinderRT\Log.txt`

### Problems with a mod?

If there's an issue installing, downloading, displaying information about, or anything else regarding a specific mod file an [issue](https://github.com/CasDragon/ModFinder/issues/new). That includes mods that no longer work and are abandoned.

### Other issues?

You guessed it: file an [issue](https://github.com/CasDragon/ModFinder/issues/new). Include your log file: `%UserProfile%\AppData\Local\ModfinderRT\Log.txt`.

## Acknowledgements
* Wolfie for finishing the Wrath version of Modfinder, without which this RT port wouldn't exist
* Barley for starting this project in the first place ([ModFinder_WOTR](https://github.com/BarleyFlour/ModFinder_WOTR))
* Bubbles for his excellent work on the UI styling and Barley for handling the GitHub action setup
* The modding community on [Discord](https://discord.com/invite/owlcat), an invaluable and supportive resource for help modding.
* All the Owlcat modders who came before me, wrote documents, and open sourced their code.

## Interested in modding?

* Check out the [OwlcatModdingWiki](https://github.com/WittleWolfie/OwlcatModdingWiki/wiki).
* Join us on [Discord](https://discord.com/invite/owlcat).
