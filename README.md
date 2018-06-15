# Volcano VR
 Udacity VR Developer Nanodegree Term 3 - Capstone

 Designed by: Albert Lardizabal

 Tested on an HTC Vive
 
 <br>

 ## Highlights
 
 Run `build.exe` in the `Capstone` folder
 
 [Walkthrough Video](https://youtu.be/xPksw9rp3Bw)

 In root folder:

 Volcano Game Planning and Scoping PDF and DOCX
 
 <br>

 ## The Story

 You're alone on an island with two volcanoes that are about to erupt. Your goal is to survive until the next morning by doing your best to avoid incoming lava bombs by teleporting, ducking, and dodging. The inspiration for this came from reading about the destruction of Pompeii in Italy when Mount Vesuvius erupted in 79 AD. The player starts the game in darkness and is meant to feel fear and a desire to survive. VR is a perfect platform to tap into a player's primitive instincts, and I added fire, smoke, explosions, and foreboding sounds in order to immerse the player and elicit a feeling of dread and panic.

 *You'll find more details in the Planning and Scoping document*

 <br>

 ## Achievements

 **Fundamentals** - 500
 ======================

 <br>

 1. **Scale (+100)**

     The volcanoes appear large and overbearing compared to the player. The mountains, hills, and pyramids make the player feel small. I wanted to achieve a David vs. Goliath effect as the player tries to outmaneuver the lava bombs.

 2. **Animation (+100)**

   The sun will animate through the sky as the scene transitions from night to day.

   The artifact at the top of the pyramid acts as a lighthouse. An animation rotates the artifact, sweeping the scene with a spotlight.

   There is a Boids simulation of birds when you win the game. The birds fly around overhead in random directions.

 3. **Lighting (+100)**

   *Directional* - Sun (Realtime)

   *Point lights* - The flaming monkey head columns have baked point lights that provide illumination of the gameplay area. The artifact at the top of the pyramid has a realtime point light attached to it to draw the player's attention as it rotates back and forth. The volcanoes have baked point lights at the tops of their domes to give them a glow that imply an eruption is expected soon.

   *Spotlight* - The artifact at the top of the pyramid has a realtime spotlight that sweeps back and forth, illuminating the gameplay area.

 4. **Locomotion (+100)**

   Teleport around the gameplay area using the trackpad on the left controller. If you press the top of the trackpad, a red laser and a green aiming cylinder will appear. You can only teleport within a defined area bounded by the flaming monkey head columns.

 5. **Physics (+100)**
   
   I created two cannon-like launcher gameobjects for the volcanoes. To randomize the trajectories, the rotation of the launchers and the added force vary by some randomly generated numbers. This was to make where the lava bombs fell more unpredictable.

<br>
**Completeness** - 750
=======================
<br>

 1. **Gamification (+250)**

   Survive until dawn by teleporting, ducking, and dodging the lava bombs launched by the two volcanoes.
   
   If you get hit by a lava bomb, you die and the level restarts

   If you survive until the sun rises (about 1 minute), you win the game!

 2. **AI (+250)**
   
   Boids Animation - I used code from the Advanced Effects lesson in the second module of the VR Nanodegree program. There are a number of birds that will fly around overhead in different directions if you win the game! The core components of the simulation are:
     1. *Separation* - The birds give each other space.
     2. *Alignment* - The birds fly along the direction of the other birds.
     3. *Cohesion* - The birds head towards the position of most of the other birds.

 3. **3D Modeling (+250)**

  Models created in Blender
    * *Pyramid*
    * *Artifact* - A torus mesh that I extruded in various spots to create a unique shape that was meant to be an artifact by an ancient civilization.
    * *Volcano* - Started as a conic mesh that I then extruded multiple times to create a mountain-like shape with a central crater.
    * *Lava Bomb* - A sphere that has a smooth and reflective surface. I was able to add fire particle effects by using Unity's particle effects package.
    * *Monkey Head Column* - A combination of box, cylinder, and monkey meshes.

<br>
 **Challenges** - 500
 ====================
<br>

 **User Testing (+500) - 2x points for having 750 points from Completeness**


   1. **Wife**

     1. Thought the original gameplay with one volcano was too easy. Suggested that I reduce the game area a bit to give the player less space to avoid the lava bombs.

       *Resolution:* I reduced the scale of the gameplay area and moved the flaming monkey heads closer. This made it less likely that the player would be able to stay in one spot and not get hit by a lava bomb.
 
     2. Suggested I add a second volcano to give the player another element to pay attention to, increasing difficulty.

       *Resolution:* I added a second volcano which made the game much more exciting and suspenseful.
   
     3. Thought the sounds were too loud and unbalanced.

       *Resolution:* I reduced the volume on the spatial sounds emanating from the volcanoes and pyramid, but kept the volume on the lava bombs flying through the air so that the player would have an idea where the lava bombs were coming from.

   2. **Daughter**

     1. Add more levels and make them progressively harder (more lava bombs, decreased gameplay area).

       *Resolution:* I didn’t have enough time to add more levels, but makes sense as a future feature. I can increase difficulty by increasing the rate of lava bomb launches, or with some clever programming, better targeting of the player.

     2. At first, she didn't understand how to play the game -- needed better instructions.

       *Resolution:* Initially, I had 3D text objects that outlined how to play the game. The text was hard to read and made the experience less immersive. I replaced the text with recordings of me explaining how to play the game and indicating when a player won or lost. I could see a future version implementing a more diagetic UI by using voiceovers meant to be the player's subconscious or a spiritual being.
   
     3. Add coins, stars, gems, or anything else for the player to collect. Collectibles could incentivize players to venture into the middle of the gameplay area even though there's a greater chance of getting hit by a lava bomb.

       *Resolution:* Great suggestion. In an updated version, I could create a leaderboard ranking players by the number of collectibles they found while playing. Alternatively, instead of a time-based system, it might be interesting to tie progression through future levels with collecting a certain number of stars or coins.