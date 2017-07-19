# VRND-BuildanApartment (P2)
The task was to build a new apartment scene with nice lighting and custom animation. Then, deploy it to your Cardboard headset. 

* Unity Version: Unity 5.5.1f
* Google VR SDK for Unity: version 1.0; gvr-unity-sdk-1.0.3
* Platform: Android 7.0, Sony Xperia X Compact
* Duration: plain working hours: 30h. 
* Unity Assets: Lamps pack, Ornament Flower Set, plants 
* Soundfile: http://soundbible.com/2175-Street.html
* Scripts, first drafts, not scaleable: Fps.cs-60fps on smartphone? (adb), Intersect.cs-any intersections, isstatic? 

## Screenshots  
![app screenshot](/Screenshot/final80app-sshot1.png)
![app screenshot](/Screenshot/final80app-sshot2.png)
![app screenshot](/Screenshot/final80app-sshot3.png)
 
## Lessons Learned:
- 1 Unity unit = 1 metric meter
- Positioning Objects: Snapping (Grid, Vertex, Surface)
- Difference between Texture and Material
- using adb (adb devices, adb logcat)
- import assets (free assets from unity)
- use audio 
- first steps with scripts

## I liked: 
arrangement of the apartment (3D objects in the scene, glow material, adding textures, a.s.o). 

## My Challenges:

* Challenging Globe: It was unclear for me (focusing on the rubric not on the build your project site) that I have to add an empty object (coordinate system, empty object) for the visually pleasing rotation 
of the sphere in the globe holder. Looking for suggestions in the forum solved that problem. After that I read it at the build your project site :)  
* Challenging Lighting: 
	* Positioning of point light in Assets downloaded from unity. There where in Hierachry but not visible in scene (when baked). 
      Positioning of point lights a little bit under the lamp models solved the problem. 
	* Understanding area lights.
	* Understanding the baking process and difference from realtime: 
      workflow of adding lights -- placement and rotation in realtime, after that bake the lights.


## TODOs:
* Models
	* Overall Layout: The overall placement of 3D objects in the scene is reasonable and is visually pleasing. 
All materials should be assigned, objects should NOT intersect with each other, and objects should NOT be levitating without a reason. (DONE)
	* Sufficient Detail: The apartment contains at least 15 models arranged in an interesting way (DONE)

	* Static Models: All models are marked as Static (except the globe) (DONE)

* Google VR
	* VR Functionality: When you run the scene, the Cardboard stereoscopic view appears and functions correctly (DONE)

* Deployment
	* Player Settings: Verify that your Player Settings are correct for your device.
For example:
Company Name = Your Name (E.g. MattSonic),
Product Name = ''Course 2 Project'',
Default Orientation: ''Landscape Left'',
Set Bundle Identifier = com.YourName.Course2Project,
For the ''Other Settings'' section, refer to the Hello World course for proper settings for your device. (DONE)
Make sure to indicate in your README.md file whether you are submitting for iOS or Android. (DONE)

* Quality Settings: 
Delete all of the quality settings but one by clicking the trash can
Rename the quality setting to ''Mobile'',
Set the pixel light count to 0,
Texture Quality: Full Res,
Anti Aliasing: 2x Multi Sampling,
Shadows: Disable Shadows,
Blend Weights: 1 bone (DONE)
 * UNCHECK:
Soft Particles,
Realtime rendering probes,
Billboards face camera position (DONE)

* Screenshot of App Running on Phone (DONE)
	* Take a screenshot of your phone screen with the app they built running. Ideally, it shows a nice wide view of the apartment.

* Lighting
 * Lights: There are several spotlights and/or area lights (DONE)

	* Static Lights: All lights are marked as Static (DONE)

	* Baked: All lights are baked and none are realtime (except for one directional light if they choose) (DONE)

	* Lightmap Settings:
Turn off Precomputed Realtime GI
Set Directional Mode to Non-Directional
Turn off Auto baking
Test different bakes with a Baked Resolution of between 2-5, then do a test bake at 40, then do a final bake with a resolution of 80
You' ll probably want to activate ''Soft Shadows'' on each light (so the baked lighting produces nice shadows)
If you notice lighting artifacts, then switch to uncompressed lightmap. 
If your app does not perform well any more, you may revert to compressed lightmaps, but you must include in your submission notes what you tried and what happened.

* Globe
	* Globe Exists: A globe should exist and be readily visible in the scene (DONE)

	* Globe Spins: When you press the Cardboard button, the globe should spin until you press the button again (DONE)

	* Globe is Textured: The globe should have a texture map of a planet. We provide a texture map of the Earth, but feel free to use your own texture. (DONE)



## Installation
* Clone or download project, if downloaded Extract the zip
* Open Unity 5.5.1f
* Open new project --> select unziped folder
* Got to Assets --> Import Package --> Costume Package --> select GoogleVRForUnity.unitypackage
* Confirm import
* Window: API Update Import Required --> select I Made a Backup, Go Ahead
* Window: Package Import Required --> select Import Package
* Confirm import
* Open Scene VRND-Course2-Starter_Project.unity in VRND-Course2-Starter-Project/Scenes
* Play
* Go to File --> Build Settings --> select Android --> confirm with Switch Platform
* Build and Run