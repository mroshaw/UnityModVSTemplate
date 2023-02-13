# Unity Mod Templates

A collection of Project and Item templates to speed up the process of creating Unity game mods using the BepInEx patcher and plugin framework.

## Overview

The template pack comes with the following:

### Unity Mod Project Template

The project template contains a suggested folder structure, references and boilerplate starter classes for a new BepInEx based Unity mod.

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/newprojectemplate.png?raw=true)

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/projecttemplate.png?raw=true)

### Item Templates

Four item templates are included that provide boiler plate code for a number of core mod class types, that you might want to add to your project.

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/newitemtemplates.png?raw=true)

#### BepInEx Plugin Class Item Template

This contains a suggested structure for a "plugin" class for use with the BepInEx framework.

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/pluginclasstemplate.png?raw=true)

#### MonoBehaviour Class Item Template

This contains a suggested structure for a "monobehaviour" class, for introducing new components and behaviours.

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/monobehaviourclasstemplate.png?raw=true)

#### Static Utils Class Item Template

This contains a suggested structure for a static "utils" class, for creating static helper methods.

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/utilsclasstemplate.png?raw=true)

#### Harmony Patch Class Item Template 

This contains a suggested structure for a "patch" class, for building Harmony patch classes and methods.

![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/patchclasstemplate.png?raw=true)

## Installation

The template pack comes as a single ZIP file and the latest version for you to use can be found here under [Releases](https://github.com/mroshaw/UnityModVSTemplate/releases).

To install the latest release:

1. Unzip the download file to a location on your machine.

2. You should have a folder structure as follows:

   ![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/templatefolderstructure.png?raw=true)

3. In Windows Explorer, navigate to this location. Note that the physical location of "Documents" may change depending on a number of factors, including whether or not you have OneDrive installed:

   ```Documents\Visual Studio 2022\```

4. Copy the unzipped Templates folder into the Visual Studio 2022 folder on top of the existing Templates folder. This will add the appropriate ZIP files to the Visual Studio template folder.

5. Restart Visual Studio.

The templates should now be available for use.

## Usage

Once you've installed the templates, you can create a new project using the Project template.

1. Create a new project by selecting the "Unity Mod (BepInEx)" project template.
2. Enter a name for the new project. This name will be used in both the default plugin class and in the default namespace for the project.
3. Click create.
4. The project structure will be created with boilerplate code class files in place for your to amend.

### IMPORTANT - Configuring the new project

There are a number of things you must now change to suit your needs. It is VERY IMPORTANT that you do this, or your mod will not compile or deploy properly, and may behave in ways you do not expect.

You need to review and amend the following:

#### References

You will need to modify the following references to point to your installed game location:

- 0Harmony
- Assembly-CSharp-firstpass_publicized
- Assembly-CSharp_publicized
- BepInEx
- UnityEngine
- UnityEngine.CoreModule

#### Post-build scripts

Review and edit the post-build scripts to include the path to your target game BepInEx plugin folder.

#### Boilerplate code

Review and edit the boilerplate code to your needs. Review, remove, or update the following:

- <YourMod>Plugin.cs
- Patches\\PlayerPatches.cs
- MonoBehaviours\\<YourMod>Component.cs
- Utils\ModUtils.cs

## Refreshing the Templates

If you download and apply an update to the templates, you may have to run this process to make the updated templates available in Visual Studio:

1. From the Start menu, open Visual Studio 2022, right click Developer Command Prompt for VS2022 and select More > Run as administrator:

   ![](https://github.com/mroshaw/UnityModVSTemplate/blob/main/media/runcommandprompt.png?raw=true)

2. Enter and execute the following command:

   ```
   devenv /installvstemplates
   devenv /updateconfiguration
   ```

3. Restart Visual Studio.

The updated templates should now be available for use.

## Building the Templates

All source is available in the Templates folder. To build and deploy changes to the templates, you can use the included batch files.

1. Amend ```config.bat``` and set the path to 7-zip, Visual Studio Documents folder and the Visual Studio IDE folder. You need to set all of these parameters correctly. Do not include double quotes and do not include trailing slash characters on folder paths. For example:

   ```
   set zip=C:\Program Files\7-Zip\7z.exe
   set vsdocs=C:\Users\MyUser\Documents\Visual Studio 2022
   set vsbin=C:\Program Files\Microsoft Visual Studio\VS2022\Community\Common7\IDE
   ```
2. Run ```build.bat``` to build a new release ZIP in the Releases folder.
3. Run ```build.bat Y``` to build and deploy to your local Visual Studio installation.

A ZIP file for release and deployment can be found in the Releases folder, postfixed with the build date and time.