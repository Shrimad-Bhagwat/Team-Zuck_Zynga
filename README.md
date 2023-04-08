# Team-Zuck_Zynga

![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white) ![Blender](https://img.shields.io/badge/blender-%23F5792A.svg?style=for-the-badge&logo=blender&logoColor=white)

## Team Members:
1. Udit Shrivastava (20BCG10109)
2. Shivam Singhal (20BCG10108)
3. Shrimad Yogesh Bhagwat(20BCG10003)
4. Aviral Srivastava(20BCG10108)

### Game Download Link : [Meteor Crush](https://github.com/Shrimad-Bhagwat/Team-Zuck_Zynga/blob/main/Meteor%20Crush.rar?raw=true)

## Design Architecture:

METEOR CRUSH:
Meteor crush is an endless space shooter survival game where the player has to survive the endless array of meteors being shot randomly throughout the open space. The player scored points for dodging and destroying meteors, 5 points per meteor destroyed and 1 per meteor dodged. This score can then be viewed under the score tab with the highscore being visible on the top.
We have designed the game using UNITY 3D using its URP render pipeline. We maintained our instructions and variations to the game design document provided by the company. We designed the game's assets ourselves using other external graphic design software like Blender. All of the assets and sprites used in the game were designed originally taking external inspirational references. 

We divided the game development phase among the team members all using their key strengths to perform the task best suited for them.

For the core architecture of the game we followed the game document given to us and made an endlessly running environment which randomly shoots meteors towards the player. Each hit will result in player's death.
For the design we followed a fixed perspective 3D design instead of a 2D design. All the elements of the game are designed in 3D and the camera is placed at the top and given a pixelated look using a specialised canvas. This allowed us to give the game the "Retro Arcade Style" look. It also allowed us to make the game more creative by allowing us to implement features like body roll in various game objects.
We created the spaceship and meteors using Blender. Complex components like shooting bullets and movement of the game Objects were done in UNITY 3D and scripted using C# as the main language. 
We used UNITY to create the background environment using its canvas and a little scripting to create the infinite loop. We also added the particle system in the background to give it a special sparkling effect.
We further used the particle system to give effects to our bullets/laser; and to create small object related animations like jet thrusters and destruction animations. 

The project phases were divided among the team members as follows:

- Environment (background, infinite loop, particle system for the environment, User Interface) - Shivam Singhal (20BCG10113)

- Environment (Meteor Random Spawner), Player Movement(Body Roll, default movement), Mechanics(Point/scoring System), Scripting, Final Compilation - Udit Shrivastava (20BCG10109)

- Player actions (Shooting, Bullet instantiation, bullet animation/particle system, damage/health system, Game Designer, Documentation, Scripting) - Aviral Srivastava(20BCG10108)

- Environment(Pixelation effect canvas), Asset Creation (Spaceship, meteors, thruster animations, destroy animations, Textures and materials), Final Compilation - Shrimad Bhagwat (20BCG10003)

---
We definitely see a future for this build of our game. With expanded timespan we could've added many different power ups, retaliating enemies, Boss Fights and even a story arc to the game. Further, it's possible to add a multiplayer mode to Meteor Crush, where players can compete against each other for the highest score. This can be achieved by introducing online leader boards or adding a real-time multiplayer mode where players can play together in the same game session. To make the multiplayer mode engaging, the game mechanics and difficulty curve may need to be adjusted accordingly. Additionally, new power-ups and obstacles may be added to make the game more challenging and exciting. Implementing a multiplayer mode can increase the game's replay value and attract more players, but it also requires a significant amount of development effort and resources.




