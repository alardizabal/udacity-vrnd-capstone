# Volcano VR
 Udacity VR Developer Nanodegree Term 3 - Capstone
 Designed by: Albert Lardizabal
 Tested on an HTC Vive
 
 
 ## Highlights
 
 Run 'build.exe' in the `Capstone` folder
 
 [Walkthrough Video](https://youtu.be/xPksw9rp3Bw)
 Volcano Game Planning and Scoping [PDF][DOCX]
 
 ## Achievements

 **Fundamentals** - 500
 ==================

 1. Scale (100)
 ..* The volcanoes appear large and overbearing compared to the player. The mountains, hills, and pyramids make the player feel small. I wanted to achieve a David vs. Goliath effect as the player tries to outmaneuver the lava bombs.

 2. Animation (100)
 ..* The sun will animate through the sky as the scene transitions from night to day.
 ..* The artifact at the top of the pyramid acts as a spotlight. An animation rotates the artifact, sweeping the scene with a spotlight.
 ..* There is a Boids simulation of birds when you win the game. The birds fly around overhead in random directions.

 3. Lighting (100)
 ..* Directional - Sun (Realtime)
 ..* Point lights - The flaming monkey head columns have a baked point light that provide illumination of the gameplay area. The artifact at the top of the pyramid has a baked point light attached to it to draw the player's attention as it rotates back and forth. The tops of the volcanoes have a baked point light at the top of the dome to give it a glow that implies an eruption is expected soon.
 ..* Spotlight - The artifact at the top of the pyramid has a realtime spotlight that sweeps back and forth, illuminating the gameplay area.

 4. Locomotion (100)
 ..* Teleport around the play area using the trackpad on the left controller. If you press down on the trackpad, a red laser and a green aiming cylinder will appear. You can only teleport within a defined area bounded by the flaming monkey head columns.

 5. Physics (100)
 ..* I created two cannon-like launcher gameobjects for the volcanoes. To randomize the trajectories, the rotation of the launcher and the added force have an element of randomness.

 **Completeness** - 750
 ==================

 1. Gamification (250)
 ..* Survive until dawn by teleporting, ducking, and dodging the lava bombs launched by the two volcanoes.
 ..* If you get hit by a lava bomb, you die and the level restarts
 ..* If you survive until the sun rises (about 1 minute), you win the game!

 2. AI (250)
 ..* Boids animation - I used code from the Advanced Effects lesson in the second module of the VR Nanodegree program. There are a number of birds that will fly around overhead in different directions if you win the game!

 3. 3D Modeling (250)
 Models created in Blender
 ..* Pyramid
 ..* Artifact - A torus mesh that I extruded to create a unique shape that was meant to be an artifact by an ancient civilization.
 ..* Volcano - Started as a conic mesh that I then extruded multiple times to create a mountain-like shape with a central crater.
 ..* Lava bomb
 ..* Monkey head column - A combination of box, cyclinder, and monkey meshes.

 **Challenges** - 500
 ================

 User Testing (500 - 2x due to 750 points from Completeness)

 1. Wife
 ..* Thought the original gameplay with one volcano was too easy. Suggested that I reduce the game area a bit to give the player less space to avoid the lava bombs. Resolution: I reduced the scale of the gameplay area and moved the flaming monkey heads closer.
 ..* Suggested I add a second volcano to give the player another element to pay attention to, increasing difficulty. Resolution: Added second volcano.
 ..* Thought the sounds were too loud and unbalanced. Resolution: I reduced the volume on the spatial sounds emanating from the volcanoes and pyramid, but kept the volume on the lava bombs flying through the air so that the player would have an idea where the lava bombs were coming from.

 2. Daughter
 ..* Add more levels and make them progressively harder (more lava bombs, decreased gameplay area). Resolution: I didn’t have enough time to add more levels, but makes sense as a future feature.
 ..* Add coins, stars, gems, or anything else for the player to collect. Collectibles could incentivize players to venture into the middle of the gameplay area despite the chance of getting hit by a lava bomb. Resolution: Great suggestion, but I didn't have time to implement. I could create a leaderboard ranking players by the number of collectibles they found while playing. Alternatively, instead of a time-based system, it might be interesting to tie progression with collecting a certain number of stars or coins.